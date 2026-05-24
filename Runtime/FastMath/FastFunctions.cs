// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst.Intrinsics;

#endregion

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		// https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24

		[StructLayout(LayoutKind.Explicit)]
		struct FloatIntUnion
		{
			[FieldOffset(0)] public float f;
			[FieldOffset(0)] public int   tmp;
		}

		/// <summary>Implementation of the fast inverse square root algorithm - From 2x to 6x faster (even faster for bigger numbers)</summary>
		/// <remarks>https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24</remarks>
		[MethodImpl(IL)] public static float fsqrt(this float z)
		{
			if (z == 0) return 0;
			FloatIntUnion u;
			u.tmp =   0;
			u.f   =   z;
			u.tmp -=  1 << 23; // Subtract 2^m.
			u.tmp >>= 1; // Divide by 2.
			u.tmp +=  1 << 29; // Add ((b + 1) / 2) * 2^m.
			return u.f;
		}

		/// <inheritdoc cref="fsqrt(float)"/>
		[MethodImpl(IL)] public static float4 fsqrt(this float4 f) => new(f.x.fsqrt(), f.y.fsqrt(), f.z.fsqrt(), f.w.fsqrt());
		/// <inheritdoc cref="fsqrt(float)"/>
		[MethodImpl(IL)] public static float3 fsqrt(this float3 f) => new(f.x.fsqrt(), f.y.fsqrt(), f.z.fsqrt());
		/// <inheritdoc cref="fsqrt(float)"/>
		[MethodImpl(IL)] public static float2 fsqrt(this float2 f) => new(f.x.fsqrt(), f.y.fsqrt()); // to never simplify to new f2(f.xy.fastsqrt())

		[StructLayout(LayoutKind.Explicit)]
		struct FloatV128
		{
			[FieldOffset(0)] public float f;
			[FieldOffset(0)] public v128  v;
		}

		/// Fast reciprocal (1 / f).
		/// 
		/// Primary path  : RCPSS hardware intrinsic  — ~0.037% max relative error
		/// Fallback path : IEEE 754 exponent bit-hack — ~3.4%  max relative error
		///
		/// Both are significantly faster than scalar division.
		/// Sign, zero, infinity and NaN are preserved on the intrinsic path.
		/// The bit-hack path handles normal floats only (see caveats below).
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe float fastrcp(this float f)
		{
			// if (X86.Sse.IsSseSupported)
			// {
			v128 result = X86.Sse.rcp_ss(*(v128*)&f);
			return *(float*)&result;
			// }
			//
			// return math.asfloat(0x7EF127EA - math.asint(f));
		}

		[StructLayout(LayoutKind.Explicit)]
		struct Float2V128
		{
			[FieldOffset(0)] public float2 f2;
			[FieldOffset(0)] public v128   v;
		}

		[StructLayout(LayoutKind.Explicit)]
		struct Float3V128
		{
			[FieldOffset(0)] public float3 f3;

			[FieldOffset(0)] public v128 v;
			// float3 = 12 bytes, v128 = 16 bytes
			// lane 3 is padding garbage — rcp_ps will compute it anyway, we just ignore it
		}

		[StructLayout(LayoutKind.Explicit)]
		struct Float4V128
		{
			[FieldOffset(0)] public float4 f4;

			[FieldOffset(0)] public v128 v;
			// float4 = 16 bytes = v128 exactly, perfect fit
		}

		const           int  Magic = 0x7EF127EA;
		static readonly v128 magic = new(0x7EF127EA, 0x7EF127EA, 0x7EF127EA, 0x7EF127EA);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe float2 fastrcp(this float2 f)
		{
			// broadcast the magic constant into all 4 lanes

			// integer subtract on all lanes at once — no lookup table, pure ALU
			v128 result = X86.Sse2.sub_epi32(magic, *(v128*)&f);
			return *(float2*)&result;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe float3 fastrcp(this float3 f)
		{
			// if (X86.Sse.IsSseSupported)
			// {
			v128 result = X86.Sse2.sub_epi32(magic, *(v128*)&f);
			return *(float3*)&result;
			// }
			//
			// return new float3(math.asfloat(Magic - math.asint(f.x)), math.asfloat(Magic - math.asint(f.y)), math.asfloat(Magic - math.asint(f.z)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static unsafe float4 fastrcp(this float4 f)
		{
			// if (X86.Sse.IsSseSupported)
			// {
			v128 result = X86.Sse2.sub_epi32(magic, *(v128*)&f);
			return *(float4*)&result;
			// }
			//
			// return new float4(math.asfloat(Magic - math.asint(f.x)), math.asfloat(Magic - math.asint(f.y)), math.asfloat(Magic - math.asint(f.z)),
			//     math.asfloat(Magic - math.asint(f.w)));
		}

		// /// <inheritdoc cref="fastrcp(float)"/>
		// [MethodImpl(IL)] public static float fastrcp(this int x) => ((float)x).fastrcp();
		// /// <inheritdoc cref="fastrcp(float)"/>
		// [MethodImpl(IL)] public static float4 fastrcp(this float4 f) => new(f.x.fastrcp(), f.y.fastrcp(), f.z.fastrcp(), f.w.fastrcp());
		// /// <inheritdoc cref="fastrcp(float)"/>
		// [MethodImpl(IL)] public static float3 fastrcp(this float3 f) => new(f.x.fastrcp(), f.y.fastrcp(), f.z.fastrcp());
		// /// <inheritdoc cref="fastrcp(float)"/>
		// [MethodImpl(IL)] public static float2 fastrcp(this float2 f) => new(f.x.fastrcp(), f.y.fastrcp());

		/// Returns the distance between a and b (fast but low accuracy)
		[MethodImpl(IL)] public static float fdistance(float4 a, float4 b) => (a - b).flengthsq().fsqrt();
		/// <inheritdoc cref="fdistance(float4, float4)"/>
		[MethodImpl(IL)] public static float fdistance(float3 a, float3 b) => (a - b).flengthsq().fsqrt();
		/// <inheritdoc cref="fdistance(float4, float4)"/>
		[MethodImpl(IL)] public static float fdistance(float2 a, float2 b) => (a - b).flengthsq().fsqrt();

		/// Returns the length of the vector (fast but low accuracy)
		[MethodImpl(IL)] public static float flength(this float4 f) => f.flengthsq().fsqrt();
		/// <inheritdoc cref="flength(float4)"/>
		[MethodImpl(IL)] public static float flength(this float3 f) => f.flengthsq().fsqrt();
		/// <inheritdoc cref="flength(float4)"/>
		[MethodImpl(IL)] public static float flength(this float2 f) => f.lengthsq().fsqrt();

		/// <inheritdoc cref="math.lengthsq(float4)"/>
		[MethodImpl(IL)] public static float flengthsq(this float4 f) => f.fdot(f);
		/// <inheritdoc cref="math.lengthsq(float3)"/>
		[MethodImpl(IL)] public static float flengthsq(this float3 f) => f.fdot(f);
		/// <inheritdoc cref="math.lengthsq(float2)"/>
		[MethodImpl(IL)] public static float flengthsq(this float2 f) => f.fdot(f);

		/// <inheritdoc cref="math.distancesq(float4, float4)"/>
		[MethodImpl(IL)] public static float fdistancesq(this float4 f, float4 f2) => flengthsq(f2 - f);
		/// <inheritdoc cref="math.distancesq(float4, float4)"/>
		[MethodImpl(IL)] public static float fdistancesq(this float3 f, float3 f2) => flengthsq(f2 - f);
		/// <inheritdoc cref="math.distancesq(float4, float4)"/>
		[MethodImpl(IL)] public static float fdistancesq(this float2 f, float2 f2) => flengthsq(f2 - f);

		/// faster dot method removing to double casts
		[MethodImpl(IL)] public static float fdot(this float4 f, float4 f2) => f.x * f2.x + f.y * f2.y + f.z * f2.z + f.w * f2.w;
		/// <inheritdoc cref="fdot(float4,float4)"/>
		[MethodImpl(IL)] public static float fdot(this float3 f, float3 f2) => f.x * f2.x + f.y * f2.y + f.z * f2.z;
		/// <inheritdoc cref="fdot(float4,float4)"/>
		[MethodImpl(IL)] public static float fdot(this float2 f, float2 f2) => f.x * f2.x + f.y * f2.y;

		/// https://github.com/SunsetQuest/Fast-Integer-Log2 --------------------------
		[StructLayout(LayoutKind.Explicit)]
		struct ConverterStruct2
		{
			[FieldOffset(0)] public ulong  asLong;
			[FieldOffset(0)] public double asDouble;
		}

		/// Same as Log2_SunsetQuest3 except it uses FP64.
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int log2int(this int value)
		{
			ConverterStruct2 a;
			a.asLong   = 0;
			a.asDouble = (uint)value;
			return (int)((a.asLong >> 52) + 1) & 0xFF;
		}

		// MOD ---------------------------------------------------------------------

		/// fast mod function using the inverse Mod
		[MethodImpl(IL)] public static float fastmodinv(this int f, float invMod, float mod) => (f * invMod).frac() * mod;

		/// Exp function approximation, around 2x faster than math.exp()
		[MethodImpl(IL)] public static float fexp(float f) => 1 / (f * f * (0.48f + 0.235f * f) + 1 + f);
		/// <inheritdoc cref="fexp(float)"/>
		[MethodImpl(IL)] public static float2 fexp(float2 f) => new(fexp(f.x), fexp(f.y));
		/// <inheritdoc cref="fexp(float)"/>
		[MethodImpl(IL)] public static float3 fexp(float3 f) => new(fexp(f.x), fexp(f.y), fexp(f.z));
		/// <inheritdoc cref="fexp(float)"/>
		[MethodImpl(IL)] public static float4 fexp(float4 f) => new(fexp(f.x), fexp(f.y), fexp(f.z), fexp(f.w));
	}
}