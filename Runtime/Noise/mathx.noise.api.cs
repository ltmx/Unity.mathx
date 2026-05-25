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

		[MI(IL)] public static float3 simplex2Derivatives(this float2 v) => snoise_grad(v);
		[MI(IL)] public static float4 simplex3Derivatives(this float3 v) => snoise_grad(v);

		[MI(IL)] public static float4 bcc4(this float3 pos) => Bcc4NoiseClassic(pos);
		[MI(IL)] public static float4 bcc8(this float3 pos) => Bcc8NoiseClassic(pos);
		[MI(IL)] public static float4 bcc4Plane(this float3 pos) => Bcc4NoisePlaneFirst(pos);
		[MI(IL)] public static float4 bcc8Plane(this float3 pos) => Bcc8NoisePlaneFirst(pos);

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

		[MI(IL)] public static float ridged2(float2 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				var n = 1f - pos.mul(freq).simplex2().abs();
				sum += amp * n * n;
				freq *= lacunarity;
				amp *= gain;
			}
			return sum;
		}

		[MI(IL)] public static float ridged3(float3 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				var n = 1f - pos.mul(freq).simplex3().abs();
				sum += amp * n * n;
				freq *= lacunarity;
				amp *= gain;
			}
			return sum;
		}

		[MI(IL)] public static float turbulence2(float2 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				sum += amp * pos.mul(freq).simplex2().abs();
				freq *= lacunarity;
				amp *= gain;
			}
			return sum;
		}

		[MI(IL)] public static float turbulence3(float3 pos, int octaves = 4, float lacunarity = 2f, float gain = 0.5f)
		{
			float sum = 0, amp = 1, freq = 1;
			for (var i = 0; i < octaves; i++)
			{
				sum += amp * pos.mul(freq).simplex3().abs();
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
				var neighbor = cell + new float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				minDist = minDist.min((point - pos).length());
			}
			return minDist;
		}

		[MI(IL)] public static float worley2F2(float2 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			var secondDist = 1e10f;
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + new float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				var dist = (point - pos).length();
				if (dist < minDist)
				{
					secondDist = minDist;
					minDist = dist;
				}
				else if (dist < secondDist)
					secondDist = dist;
			}
			return secondDist;
		}

		[MI(IL)] public static float4 voronoi2Cell(float2 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			var nearestCell = cell;
			var nearestPoint = float2.zero;
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + new float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				var dist = (point - pos).length();
				if (dist < minDist)
				{
					minDist = dist;
					nearestCell = neighbor;
					nearestPoint = point;
				}
			}
			return new float4(nearestCell, pos - nearestPoint);
		}

		[MI(IL)] public static float worley3(float3 pos)
		{
			var cell = pos.floor();
			var minDist = 1e10f;
			for (var k = -1; k <= 1; k++)
			for (var j = -1; j <= 1; j++)
			for (var i = -1; i <= 1; i++)
			{
				var neighbor = cell + new float3(i, j, k);
				var point = neighbor + hashcell3(neighbor);
				minDist = mathx.min(minDist, mathx.length(point - pos));
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
				var neighbor = cell + new float2(i, j);
				var point = neighbor + hashcell2(neighbor);
				var dist = (point - pos).length();
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
				var neighbor = cell + new float3(i, j, k);
				var point = neighbor + hashcell3(neighbor);
				var dist = (point - pos).length();
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
			var p = (cell * new float2(443.897f, 441.423f)).frac();
			p += p.dot(p.yx + 19.19f);
			return new float2(p.x * p.y, p.x + p.y).frac();
		}

		[MI(IL)] static float3 hashcell3(float3 cell)
		{
			var p = (cell * new float3(443.897f, 441.423f, 437.195f)).frac();
			p += p.dot(p.yzx + 19.19f);
			return new float3(p.x * p.y, p.y * p.z, p.z * p.x).frac();
		}
	}
}
