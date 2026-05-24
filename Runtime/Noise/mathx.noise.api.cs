// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		[MI(IL)] public static float simplex2(this float2 v) => snoise(v);
		[MI(IL)] public static float simplex3(this float3 v) => snoise(v);
		[MI(IL)] public static float simplex4(this float4 v) => snoise(v);

		[MI(IL)] public static float perlin2(this float2 v) => cnoise(v);
		[MI(IL)] public static float perlin3(this float3 v) => cnoise(v);
		[MI(IL)] public static float perlin2Periodic(this float2 v, float2 period) => pnoise(v, period);
		[MI(IL)] public static float perlin3Periodic(this float3 v, float3 period) => pnoise(v, period);

		[MI(IL)] public static float fbm2(float2 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				sum += amp * snoise(pos * freq);
				freq *= lacunarity;
				amp *= gain;
			}
			return sum;
		}

		[MI(IL)] public static float fbm3(float3 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				sum += amp * snoise(pos * freq);
				freq *= lacunarity;
				amp *= gain;
			}
			return sum;
		}

		[MI(IL)] public static float worley2(float2 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				minDist = math.min(minDist, math.length(point - pos));
			}
			return minDist;
		}

		[MI(IL)] public static float worley3(float3 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			for (var k = -1; k <= 1; k++)
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + float3(i, j, k);
				var point = neighbor + hashcell3(neighbor);
				minDist = math.min(minDist, math.length(point - pos));
			}
			return minDist;
		}

		[MI(IL)] public static float voronoi2(float2 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			var secondDist = 1e10f;
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				var dist = math.length(point - pos);
				if (dist < minDist)
				{
					secondDist = minDist;
					minDist = dist;
				}
				else if (dist < secondDist)
					secondDist = dist;
			}
			return secondDist - minDist;
		}

		[MI(IL)] public static float voronoi3(float3 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			var secondDist = 1e10f;
			for (var k = -1; k <= 1; k++)
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + float3(i, j, k);
				var point = neighbor + hashcell3(neighbor);
				var dist = math.length(point - pos);
				if (dist < minDist)
				{
					secondDist = minDist;
					minDist = dist;
				}
				else if (dist < secondDist)
					secondDist = dist;
			}
			return secondDist - minDist;
		}

		[MI(IL)] static float2 hashcell2(float2 cell)
		{
			var p = math.frac(cell * float2(443.897f, 441.423f));
			p += p.dot(p.yx + 19.19f);
			return math.frac(float2(p.x * p.y, p.x + p.y));
		}

		[MI(IL)] static float3 hashcell3(float3 cell)
		{
			var p = math.frac(cell * float3(443.897f, 441.423f, 437.195f));
			p += p.dot(p.yzx + 19.19f);
			return math.frac(float3(p.x * p.y, p.y * p.z, p.z * p.x));
		}
	}
}
