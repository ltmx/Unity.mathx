// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx
// Credits: XXHash — Yann Collet (https://github.com/Cyan4973/xxHash)

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		const uint HashPrime1 = 2654435761u;
		const uint HashPrime2 = 2246822519u;
		const uint HashPrime3 = 3266489917u;
		const uint HashPrime4 = 668265263u;
		const uint HashPrime5 = 374761393u;

		[MI(IL)] public static uint hash(this int v) => math.hash(v);
		[MI(IL)] public static uint hash(this int2 v) => math.hash(v);
		[MI(IL)] public static uint hash(this int3 v) => math.hash(v);
		[MI(IL)] public static uint hash(this int4 v) => math.hash(v);
		[MI(IL)] public static uint hash(this uint v) => math.hash(v);
		[MI(IL)] public static uint hash(this uint2 v) => math.hash(v);
		[MI(IL)] public static uint hash(this uint3 v) => math.hash(v);
		[MI(IL)] public static uint hash(this uint4 v) => math.hash(v);

		[MI(IL)] public static uint2 hashwide(this int2 v) => math.hash(v).xx();
		[MI(IL)] public static uint3 hashwide(this int3 v) => math.hash(v).xxx();
		[MI(IL)] public static uint4 hashwide(this int4 v) => math.hash(v).xxxx();
		[MI(IL)] public static uint2 hashwide(this uint2 v) => math.hash(v).xx();
		[MI(IL)] public static uint3 hashwide(this uint3 v) => math.hash(v).xxx();
		[MI(IL)] public static uint4 hashwide(this uint4 v) => math.hash(v).xxxx();

		[MI(IL)] public static uint xxhash32(this uint seed)
		{
			uint hash = seed + HashPrime5;
			hash *= HashPrime1;
			hash = rotl(hash, 17) * HashPrime2;
			hash *= HashPrime3;
			hash = rotl(hash, 17) * HashPrime4;
			hash ^= hash >> 15;
			hash *= HashPrime5;
			hash ^= hash >> 13;
			hash *= HashPrime2;
			hash ^= hash >> 16;
			return hash;
		}

		[MI(IL)] public static float hash01(this uint seed) => seed.xxhash32() / (float)uint.MaxValue;
		[MI(IL)] public static float hashnp01(this uint seed) => seed.hash01() * 2f - 1f;

		[MI(IL)] static uint rotl(uint value, int count) => value << count | value >> 32 - count;

		[MI(IL)] public static float4 make(int4 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
		[MI(IL)] public static float3 make(int3 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
		[MI(IL)] public static float2 make(int2 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
		[MI(IL)] public static float make(int f, i1_f1 func) => func.Invoke(f);

		[MI(IL)] public static int4 make(int4 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
		[MI(IL)] public static int3 make(int3 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
		[MI(IL)] public static int2 make(int2 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
		[MI(IL)] public static int make(int f, i1_i1 func) => func.Invoke(f);

		[MI(IL)] public static double4 make(double4 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
		[MI(IL)] public static double3 make(double3 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
		[MI(IL)] public static double2 make(double2 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
		[MI(IL)] public static double make(double f, d1_d1 func) => func.Invoke(f);

		[MI(IL)] public static float4 make(uint4 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
		[MI(IL)] public static float3 make(uint3 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
		[MI(IL)] public static float2 make(uint2 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
		[MI(IL)] public static float make(uint f, u1_f1 func) => func.Invoke(f);
	}
}
