/////////////// K.jpg's Simplex-like Re-oriented 4-Point BCC Noise ///////////////
//////////////////// Output: float4(dF/dx, dF/dy, dF/dz, value) ////////////////////

using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        private static float4 permute(this float4 t) => t * (t * 34 + 133);

        // Gradient set is a normalized expanded rhombic-dodecahedron
        private static float3 grad(float hash)
        {
            // Random vertex of a cube, +/- 1 each
            var cube = (hash / float3(1, 2, 4)).floor().mod(2) * 2 - 1;

            // Random edge of the three edges connected to that vertex
            // Also a cuboctahedral-vertex
            // And corresponds to the face of its dual, the rhombic-dodecahedron
            var cuboct = cube;

            var index = (int)(hash / 16);

            if (index == 0)
                cuboct.x = 0;
            else if (index == 1)
                cuboct.y = 0;
            else
                cuboct.z = 0;

            // In a funky way, pick one of the four points on the rhombic face
            var type = (hash / 8).floor().mod(2);
            var rhomb = (1 - type) * cube + type * (cuboct + cube.cross(cuboct));

            // Expand it so that the new edges are the same length
            // as the existing ones
            var grad = cuboct * 1.22474487139f + rhomb;

            // To make all gradients the same length, we only need to shorten the
            // second type of vector. We also put in the whole noise scale constant.
            // The compiler should reduce it into the existing floats. I think.
            grad *= (1 - 0.042942436724648037f * type) * 32.80201376986577f;

            return grad;
        }

        // BCC lattice split up into 2 cube lattices
        private static float4 openSimplex2Base(float3 X)
        {
            float3x4 vx = new();
            float3x4 dx = new();
            // First half-lattice, closest edge
            vx.c0 = X.round();
            dx.c0 = X - vx.c0;
            var score1 = dx.c0.abs();
            var dir1 = score1.yzx.max(score1.zxy).step(score1);
            vx.c1 = vx.c0 + dir1 * dx.c0.sign();
            dx.c1 = X - vx.c1;

            // Second half-lattice, closest edge
            var X2 = X + 144.5f;
            vx.c2 = X2.round();
            dx.c2 = X2 - vx.c2;
            var score2 = dx.c2.abs();
            var dir2 = score2.yzx.max(score2.zxy).step(score2);
            vx.c3 = vx.c2 + dir2 * dx.c2.sign();
            dx.c3 = X2 - vx.c3;

            // Gradient hashes for the four points, two from each half-lattice
            var transpose = vx.transpose();
            var hashes = transpose.c0.mod(289).permute();
            hashes = (hashes + transpose.c1).mod(289).permute();
            hashes = (hashes + transpose.c2).mod(289).permute().mod(48);

            // Gradient extrapolations & kernel function
            var gx = new float3x4(grad(hashes.x), grad(hashes.y), grad(hashes.z), grad(hashes.w));
            var extrapolations = dx.dot(gx);

            var a = (0.5f - dx.lengthsq()).p();
            var aa = a * a;
            var aaaa = aa * aa;
            // Derivatives of the noise
            var derivative = - 8 * (aa * a * extrapolations).mul(dx) + aaaa.mul(gx);

            // Return it all as a float4
            return float4(derivative, aaaa.dot(extrapolations));
        }

        // Use this if you don't want Z to look different from X and Y
        private static float4 openSimplex2_Conventional(float3 X)
        {
            // Rotate around the main diagonal. Not a skew transform.
            var result = openSimplex2Base(X.sum() * 2/3 - X);
            return float4(result.xyz.sum() * 2/3 - result.xyz, result.w);
        }

        // Use this if you want to show X and Y in a plane, then use Z for time, vertical, etc.
        public static float4 openSimplex2_ImproveXY(float3 X)
        {
            // Rotate so Z points down the main diagonal. Not a skew transform.
            float3x3 orthonormalMap = new(
                0.788675134594813f, -0.211324865405187f, -0.577350269189626f,
                -0.211324865405187f, 0.788675134594813f, -0.577350269189626f,
                0.577350269189626f, 0.577350269189626f, 0.577350269189626f
            );

            var result = openSimplex2Base(X.mul(orthonormalMap));
            return float4(orthonormalMap.mul(result.xyz), result.w);
        }
    }
}