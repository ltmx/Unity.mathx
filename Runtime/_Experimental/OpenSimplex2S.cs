////////////////// K.jpg's Smooth Re-oriented 8-Point BCC Noise //////////////////
//////////////////// Output: float4(dF/dx, dF/dy, dF/dz, value) ////////////////////

using Unity.Mathematics;
using static Unity.Mathematics.math;

// using static Unity.Mathematics.math;
///
public static class OpenSimplex
{
// Borrowed from Stefan Gustavson's noise code
    private static float4 permute(float4 t) => t * (t * 34 + 133);

    private static float mod(float x, float y) => x - y * floor(x / y);

    private static float2 mod(float2 x, float2 y) => x - y * floor(x / y);

    private static float3 mod(float3 x, float3 y) => x - y * floor(x / y);

    private static float4 mod(float4 x, float4 y) => x - y * floor(x / y);

// Gradient set is a normalized expanded rhombic dodecahedron
    private static float3 grad(float hash)
    { // Random vertex of a cube, +/- 1 each
      var cube = mod(floor(hash / float3(1, 2, 4)), 2) * 2 - 1;

      // Random edge of the three edges connected to that vertex
      // Also a cuboctahedral vertex
      // And corresponds to the face of its dual, the rhombic dodecahedron
      var cuboct = cube;

      var index = (int)(hash / 16);
      if (index == 0)
          cuboct.x = 0;
      else if (index == 1)
          cuboct.y = 0;
      else
          cuboct.z = 0;

      // In a funky way, pick one of the four points on the rhombic face
      var type = mod(floor(hash / 8), 2);
      var rhomb = (1 - type) * cube + type * (cuboct + cross(cube, cuboct));

      // Expand it so that the new edges are the same length
      // as the existing ones
      var grad = cuboct * 1.22474487139f + rhomb;

      // To make all gradients the same length, we only need to shorten the
      // second type of vector. We also put in the whole noise scale constant.
      // The compiler should reduce it into the existing floats. I think.
      grad *= (1 - 0.042942436724648037f * type) * 3.5946317686139184f;

      return grad; }

// BCC lattice split up into 2 cube lattices
    private static float4 openSimplex2SDerivativesPart(float3 X)
    { var b = floor(X);
      var i4 = float4(X - b, 2.5f);

      // Pick between each pair of oppposite corners in the cube.
      var v1 = b + floor(dot(i4, float4(.25f, .25f, .25f, .25f)));
      var v2 = b + float3(1, 0, 0) + float3(-1, 1, 1) * floor(dot(i4, float4(-.25f, .25f, .25f, .35f)));
      var v3 = b + float3(0, 1, 0) + float3(1, -1, 1) * floor(dot(i4, float4(.25f, -.25f, .25f, .35f)));
      var v4 = b + float3(0, 0, 1) + float3(1, 1, -1) * floor(dot(i4, float4(.25f, .25f, -.25f, .35f)));

      // Gradient hashes for the four vertices in this half-lattice.
      var hashes = permute(mod(float4(v1.x, v2.x, v3.x, v4.x), 289));
      hashes = permute(mod(hashes + float4(v1.y, v2.y, v3.y, v4.y), 289));
      hashes = mod(permute(mod(hashes + float4(v1.z, v2.z, v3.z, v4.z), 289)), 48);

      // Gradient extrapolations & kernel function
      var d1 = X - v1;
      var d2 = X - v2;
      var d3 = X - v3;
      var d4 = X - v4;
      var a = max(0.75f - float4(dot(d1, d1), dot(d2, d2), dot(d3, d3), dot(d4, d4)), 0);
      var aa = a * a;
      var aaaa = aa * aa;
      var g1 = grad(hashes.x);
      var g2 = grad(hashes.y);
      var g3 = grad(hashes.z);
      var g4 = grad(hashes.w);
      var extrapolations = float4(dot(d1, g1), dot(d2, g2), dot(d3, g3), dot(d4, g4));

      float3x4 derivativeMatrix = new(d1, d2, d3, d4);
      float3x4 gradientMatrix = new(g1, g2, g3, g4);

      // Derivatives of the noise
      var derivative = -8 * mul(derivativeMatrix, aa * a * extrapolations) + mul(gradientMatrix, aaaa);

      // Return it all as a float4
      return float4(derivative, dot(aaaa, extrapolations)); }

// Use this if you don't want Z to look different from X and Y
    private static float4 openSimplex2SDerivatives_Conventional(float3 X)
    { X = dot(X, float3(2 / 3, 2 / 3, 2 / 3)) - X;

      var result = openSimplex2SDerivativesPart(X) + openSimplex2SDerivativesPart(X + 144.5f);

      return float4(dot(result.xyz, float3(2 / 3, 2 / 3, 2 / 3)) - result.xyz, result.w); }

// Use this if you want to show X and Y in a plane, then use Z for time, vertical, etc.
    private static float4 openSimplex2SDerivatives_ImproveXY(float3 X)
    { // Not a skew transform.
      float3x3 orthonormalMap = new(
          0.788675134594813f, -0.211324865405187f, -0.577350269189626f,
          -0.211324865405187f, 0.788675134594813f, -0.577350269189626f,
          0.577350269189626f, 0.577350269189626f, 0.577350269189626f);

      X = mul(X, orthonormalMap);
      var result = openSimplex2SDerivativesPart(X) + openSimplex2SDerivativesPart(X + 144.5f);

      return float4(mul(orthonormalMap, result.xyz), result.w); }
}