// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		// Gradient set is a normalized expanded rhombic dodecahedron
		static float3 grad2S(float hash)
		{
			// Random vertex of a cube, +/- 1 each
			float3 cube = (hash / f3(1, 2, 4)).floor().mod(2) * 2 - 1;

			// Random edge of the three edges connected to that vertex
			// Also a cuboctahedral vertex
			// And corresponds to the face of its dual, the rhombic dodecahedron
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
			grad *= (1 - 0.042942436724648037f * type) * 3.5946317686139184f;

			return grad;
		}

		// BCC lattice split up into 2 cube lattices
		static float4 openSimplex2SDerivativesPart(float3 X)
		{
			float3 b = X.floor();
			float4 i4 = f4(X - b, 2.5f);

			// Pick between each pair of opposite corners in the cube.
			float3x4 vx = new(b + i4.dot(f4(.25f, .25f, .25f, .25f)).floor(), b + f3(1, 0, 0) + f3(-1, 1, 1) * i4.dot(f4(-.25f, .25f, .25f, .35f)).floor(),
				b + f3(0, 1, 0) + f3(1, -1, 1) * i4.dot(f4(.25f, -.25f, .25f, .35f)).floor(), b + f3(0, 0, 1) + f3(1, 1, -1) * i4.dot(f4(.25f, .25f, -.25f, .35f)).floor());

			// Gradient hashes for the four vertices in this half-lattice.
			float4x3 transpose = vx.transpose();
			float4 hashes = transpose.c0.mod(289).permute();
			hashes = (hashes + transpose.c1).mod(289).permute();
			hashes = (hashes + transpose.c2).mod(289).permute().mod(48);

			// Gradient extrapolations & kernel function
			float3x4 dx = vx.neg().add(X);

			var gx = new float3x4(grad2S(hashes.x), grad2S(hashes.y), grad2S(hashes.z), grad2S(hashes.w));
			float4 extrapolations = dx.dot(gx);

			// Derivatives of the noise
			float4 a = max(0.75f - dx.lengthsq(), 0);
			float4 aa = a * a;
			float4 aaaa = aa * aa;
			float3 derivative = -8 * (aa * a * extrapolations).mul(dx) + aaaa.mul(gx);

			// Return it all as a f4
			return derivative.append(aaaa.dot(extrapolations));
		}

		// Use this if you don't want Z to look different from X and Y
		static float4 openSimplex2SDerivatives_Conventional(float3 X)
		{
			X = X.dot(f3(2 / 3)) - X;
			float4 result = openSimplex2SDerivativesPart(X) + openSimplex2SDerivativesPart(X + 144.5f);
			return f4(result.xyz.dot(f3(2 / 3)) - result.xyz, result.w);
		}

		// Use this if you want to show X and Y in a plane, then use Z for time, vertical, etc.
		public static float4 openSimplex2SDerivatives_ImproveXY(float3 X)
		{
			// Not a skew transform.
			float3x3 orthonormalMap = new(0.788675134594813f, -0.211324865405187f, -0.577350269189626f, -0.211324865405187f, 0.788675134594813f, -0.577350269189626f, 0.577350269189626f,
				0.577350269189626f, 0.577350269189626f);

			X = mul(X, orthonormalMap);
			float4 result = openSimplex2SDerivativesPart(X) + openSimplex2SDerivativesPart(X + 144.5f);

			return f4(orthonormalMap.mul(result.xyz), result.w);
		}
	}
}