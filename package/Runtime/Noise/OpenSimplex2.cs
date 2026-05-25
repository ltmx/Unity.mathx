// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		static float4 permutesimplex(this float4 t) => t * (t * 34 + 133);

		// Gradient set is a normalized expanded rhombic-dodecahedron
		static float3 grad(float hash)
		{
			// Random vertex of a cube, +/- 1 each
			float3 cube = (hash / f3(1, 2, 4)).floor().mod(2) * 2 - 1;

			// Random edge of the three edges connected to that vertex
			// Also a cuboctahedral-vertex
			// And corresponds to the face of its dual, the rhombic-dodecahedron
			float3 cuboct = cube;

			var index = (int)(hash / 16);

			if (index == 0)
				cuboct.x = 0;
			else if (index == 1)
				cuboct.y = 0;
			else
				cuboct.z = 0;

			// In a funky way, pick one of the four points on the rhombic face
			float type = (hash / 8).floor().mod(2);
			float3 rhomb = (1 - type) * cube + type * (cuboct + cube.cross(cuboct));

			// Expand it so that the new edges are the same length
			// as the existing ones
			float3 grad = cuboct * 1.22474487139f + rhomb;

			// To make all gradients the same length, we only need to shorten the
			// second type of vector. We also put in the whole noise scale constant.
			// The compiler should reduce it into the existing floats. I think.
			grad *= (1 - 0.042942436724648037f * type) * 32.80201376986577f;

			return grad;
		}

		// BCC lattice split up into 2 cube lattices
		static float4 openSimplex2Base(float3 X)
		{
			float3x4 vx = new();
			float3x4 dx = new();
			// First half-lattice, closest edge
			vx.c0 = X.round();
			dx.c0 = X - vx.c0;
			float3 score1 = dx.c0.abs();
			float3 dir1 = score1.yzx.max(score1.zxy).step(score1);
			vx.c1 = vx.c0 + dir1 * dx.c0.sign();
			dx.c1 = X - vx.c1;

			// Second half-lattice, closest edge
			float3 X2 = X + 144.5f;
			vx.c2 = X2.round();
			dx.c2 = X2 - vx.c2;
			float3 score2 = dx.c2.abs();
			float3 dir2 = score2.yzx.max(score2.zxy).step(score2);
			vx.c3 = vx.c2 + dir2 * dx.c2.sign();
			dx.c3 = X2 - vx.c3;

			// Gradient hashes for the four points, two from each half-lattice
			float4x3 transpose = vx.transpose();
			float4 hashes = transpose.c0.mod(289).permute();
			hashes = (hashes + transpose.c1).mod(289).permute();
			hashes = (hashes + transpose.c2).mod(289).permute().mod(48);

			// Gradient extrapolations & kernel function
			var gx = new float3x4(grad(hashes.x), grad(hashes.y), grad(hashes.z), grad(hashes.w));
			float4 extrapolations = dx.dot(gx);

			float4 a = (0.5f - dx.lengthsq()).limp();
			float4 aa = a * a;
			float4 aaaa = aa * aa;
			// Derivatives of the noise
			float3 derivative = -8 * (aa * a * extrapolations).mul(dx) + aaaa.mul(gx);

			// Return it all as a f4
			return f4(derivative, aaaa.dot(extrapolations));
		}

		// Use this if you don't want Z to look different from X and Y
		static float4 openSimplex2_Conventional(float3 X)
		{
			// Rotate around the main diagonal. Not a skew transform.
			float4 result = openSimplex2Base(X.csum() * 2 / 3 - X);
			return f4(result.xyz.csum() * 2 / 3 - result.xyz, result.w);
		}

		// Use this if you want to show X and Y in a plane, then use Z for time, vertical, etc.
		public static float4 openSimplex2_ImproveXY(float3 X)
		{
			// Rotate so Z points down the main diagonal. Not a skew transform.
			float3x3 orthonormalMap = new(0.788675134594813f, -0.211324865405187f, -0.577350269189626f, -0.211324865405187f, 0.788675134594813f, -0.577350269189626f, 0.577350269189626f,
				0.577350269189626f, 0.577350269189626f);

			float4 result = openSimplex2Base(X.mul(orthonormalMap));
			return f4(orthonormalMap.mul(result.xyz), result.w);
		}
	}
}