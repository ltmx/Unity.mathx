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
		[MI(IL)] public static float hashcoord(this float2 coord)
		{
			var p = (coord * new float2(127.1f, 311.7f)).frac();
			p += p.dot(p.yx + 19.19f);
			return (p.x * p.y).frac();
		}

		[MI(IL)] public static float hashcoord(this float3 coord)
		{
			var p = (coord * new float3(127.1f, 311.7f, 74.7f)).frac();
			p += p.dot(p.yzx + 19.19f);
			return (p.x * p.y * p.z).frac();
		}

		[MI(IL)] public static float gradientNoise2(this float2 pos)
		{
			var i = pos.floor();
			var f = pos.frac();
			var u = f * f * f * (f * (f * 6f - 15f) + 10f);

			var a = hashcoord(i);
			var b = hashcoord(i + new float2(1, 0));
			var c = hashcoord(i + new float2(0, 1));
			var d = hashcoord(i + new float2(1, 1));

			return math.lerp(math.lerp(a, b, u.x), math.lerp(c, d, u.x), u.y) * 2f - 1f;
		}

		[MI(IL)] public static float gradientNoise3(this float3 pos)
		{
			var i = pos.floor();
			var f = pos.frac();
			var u = f * f * f * (f * (f * 6f - 15f) + 10f);

			float sample(int x, int y, int z) => hashcoord(i + new float3(x, y, z)) * 2f - 1f;

			var x00 = math.lerp(sample(0, 0, 0), sample(1, 0, 0), u.x);
			var x10 = math.lerp(sample(0, 1, 0), sample(1, 1, 0), u.x);
			var x01 = math.lerp(sample(0, 0, 1), sample(1, 0, 1), u.x);
			var x11 = math.lerp(sample(0, 1, 1), sample(1, 1, 1), u.x);
			return math.lerp(math.lerp(x00, x10, u.y), math.lerp(x01, x11, u.y), u.z);
		}
	}
}
