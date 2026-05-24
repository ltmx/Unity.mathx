// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx
// Credits: XXHash — Yann Collet (https://github.com/Cyan4973/xxHash)
// Hash constants match Unity.Mathematics vector hash implementations.

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

		[MI(IL)] public static uint hash(this int v) => math.asuint(v) * 0x9B13B92Du + 0xD75513F9u;
		[MI(IL)] public static uint hash(this int2 v) => math.csum(math.asuint(v) * math.uint2(0x83B58237u, 0x833E3E29u)) + 0xA9D919BFu;
		[MI(IL)] public static uint hash(this int3 v) => math.csum(math.asuint(v) * math.uint3(0x4C7F6DD1u, 0x4822A3E9u, 0xAAC3C25Du)) + 0xD21D0945u;
		[MI(IL)] public static uint hash(this int4 v) => math.csum(math.asuint(v) * math.uint4(0x6E050B01u, 0x750FDBF5u, 0x7F3DD499u, 0x52EAAEBBu)) + 0x4599C793u;

		[MI(IL)] public static uint hash(this uint v) => v * 0x9B13B92Du + 0xD75513F9u;
		[MI(IL)] public static uint hash(this uint2 v) => math.csum(v * math.uint2(0x4473BBB1u, 0xCBA11D5Fu)) + 0x685835CFu;
		[MI(IL)] public static uint hash(this uint3 v) => math.csum(v * math.uint3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u)) + 0x863E3729u;
		[MI(IL)] public static uint hash(this uint4 v) => math.csum(v * math.uint4(0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu, 0xE16BC89Du)) + 0x7AA07CD3u;

		[MI(IL)] public static uint2 hashwide(this int2 v) => math.asuint(v) * math.uint2(0xC3EC1D97u, 0xB8B208C7u) + 0x5D3ED947u;
		[MI(IL)] public static uint3 hashwide(this int3 v) => math.asuint(v) * math.uint3(0x88FCAB2Du, 0x614DA60Du, 0x5BA2C50Bu) + 0x8C455ACBu;
		[MI(IL)] public static uint4 hashwide(this int4 v) => math.asuint(v) * math.uint4(0x83B5E729u, 0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u) + 0x822A7D6Du;

		[MI(IL)] public static uint2 hashwide(this uint2 v) => v * math.uint2(0xC3D32AE1u, 0xB966942Fu) + 0xFE9856B3u;
		[MI(IL)] public static uint3 hashwide(this uint3 v) => v * math.uint3(0xE191B035u, 0x68586FAFu, 0xD4DFF6D3u) + 0xCB634F4Du;
		[MI(IL)] public static uint4 hashwide(this uint4 v) => v * math.uint4(0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u, 0xAC60D0C3u) + 0x9263662Fu;

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
