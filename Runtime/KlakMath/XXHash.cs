// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx
// Credits: XXHash — Yann Collet (https://github.com/Cyan4973/xxHash)

using static Unity.Mathematics.mathx;

namespace Unity.Mathematics
{
	public readonly struct XXHash
	{
		const uint Prime1 = 2654435761u;
		const uint Prime2 = 2246822519u;
		const uint Prime3 = 3266489917u;
		const uint Prime4 = 668265263u;
		const uint Prime5 = 374761393u;

		public uint Seed { get; }

		public XXHash(uint seed) => Seed = seed;

		public uint UInt(uint data) => CalculateHash(data, Seed);
		public uint2 UInt2(uint2 data) => CalculateHash(data, Seed);
		public uint3 UInt3(uint3 data) => CalculateHash(data, Seed);
		public uint4 UInt4(uint4 data) => CalculateHash(data, Seed);

		public uint2 UInt2(uint data) => UInt2(new uint2(data, data + 0x10000000u));
		public uint3 UInt3(uint data) => UInt3(new uint3(data, data + 0x10000000u, data + 0x20000000u));
		public uint4 UInt4(uint data) => UInt4(new uint4(data, data + 0x10000000u, data + 0x20000000u, data + 0x30000000u));

		public float Float(uint data) => UInt(data) / (float)uint.MaxValue;
		public float2 Float2(uint2 data) => (float2)UInt2(data) / uint.MaxValue;
		public float3 Float3(uint3 data) => (float3)UInt3(data) / uint.MaxValue;
		public float4 Float4(uint4 data) => (float4)UInt4(data) / uint.MaxValue;

		public float Float(float max, uint data) => Float(data) * max;
		public float2 Float2(float2 max, uint2 data) => Float2(data) * max;

		public float Float(float min, float max, uint data) => Float(data) * (max - min) + min;
		public float2 Float2(float2 min, float2 max, uint2 data) => Float2(data) * (max - min) + min;

		public bool Bool(uint data) => (UInt(data) & 1) != 0;

		public float2 OnCircle(uint data) => Float(TAU, data).cossin();
		public float2 InCircle(uint data) => OnCircle(data) * Float(data + 0x10000000u).sqrt();

		public float3 OnSphere(uint data)
		{
			var z = Float(-1f, 1f, data + 0x10000000u);
			return new float3(Float(PI * 2f, data).cossin() * (1f - z * z).sqrt(), z);
		}

		public float3 InSphere(uint data) => OnSphere(data) * Float(data + 0x20000000u).pow(1f / 3f);

		public quaternion Rotation(uint data)
		{
			var u1 = Float(data);
			var r1 = Float(TAU, data + 0x10000000u);
			var r2 = Float(TAU, data + 0x20000000u);
			var s1 = (1f - u1).sqrt();
			var s2 = u1.sqrt();
			var v = new float4(s1 * r1.sincos(), s2 * r2.sincos());
			return quaternion(math.select(v, -v, v.w < 0f));
		}

		static uint CalculateHash(uint data, uint seed)
		{
			var h32 = seed + Prime5 + 4u + data * Prime3;
			h32 = rotl32(h32, 17) * Prime4;
			h32 ^= h32 >> 15;
			h32 *= Prime2;
			h32 ^= h32 >> 13;
			h32 *= Prime3;
			h32 ^= h32 >> 16;
			return h32;
		}

		static uint2 CalculateHash(uint2 data, uint2 seed)
		{
			var h32 = seed + Prime5 + 4u + data * Prime3;
			h32 = rotl32(h32, 17) * Prime4;
			h32 ^= h32 >> 15;
			h32 *= Prime2;
			h32 ^= h32 >> 13;
			h32 *= Prime3;
			h32 ^= h32 >> 16;
			return h32;
		}

		static uint3 CalculateHash(uint3 data, uint3 seed)
		{
			var h32 = seed + Prime5 + 4u + data * Prime3;
			h32 = rotl32(h32, 17) * Prime4;
			h32 ^= h32 >> 15;
			h32 *= Prime2;
			h32 ^= h32 >> 13;
			h32 *= Prime3;
			h32 ^= h32 >> 16;
			return h32;
		}

		static uint4 CalculateHash(uint4 data, uint4 seed)
		{
			var h32 = seed + Prime5 + 4u + data * Prime3;
			h32 = rotl32(h32, 17) * Prime4;
			h32 ^= h32 >> 15;
			h32 *= Prime2;
			h32 ^= h32 >> 13;
			h32 *= Prime3;
			h32 ^= h32 >> 16;
			return h32;
		}

		static uint rotl32(uint x, int r) => x << r | x >> 32 - r;
		static uint2 rotl32(uint2 x, int r) => x << r | x >> 32 - r;
		static uint3 rotl32(uint3 x, int r) => x << r | x >> 32 - r;
		static uint4 rotl32(uint4 x, int r) => x << r | x >> 32 - r;
	}
}
