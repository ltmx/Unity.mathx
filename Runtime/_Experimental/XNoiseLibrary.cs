//----------------------------------------------------------------------------------------------------------
// X-PostProcessing Library
// https://github.com/QianMo/X-PostProcessing-Library
// Copyright (C) 2020 QianMo. All rights reserved.
// Licensed under the MIT License
// You may not use this file except in compliance with the License.You may obtain a copy of the License at
// http://opensource.org/licenses/MIT
//----------------------------------------------------------------------------------------------------------

//----------------------------------------------------------------------------------------------------------
//  XNoiseLibrary.hlsl
// A Collection of  2D/3D/4D Simplex Noise 、 2D/3D textureless classic Noise 、Re-oriented 4 / 8-Point BCC Noise
//
// Reference 1: Webgl Noise -  https://github.com/ashima/webgl-noise
// Reference 2: KdotJPG New Simplex Style Gradient Noise - https://github.com/KdotJPG/New-Simplex-Style-Gradient-Noise
// Reference 3: Noise Shader Library for Unity - https://github.com/keijiro/NoiseShader
// Reference 4: noiseSimplex.cginc - https://forum.unity.com/threads/2d-3d-4d-optimised-perlin-noise-cg-hlsl-library-cginc.218372/
// ----------------------------------------------------------------------------------------------------------

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // 1 / 289
        private const float NOISE_SIMPLEX_1_DIV_289 = 0.00346020761245674740484429065744f;

        private static float mod289(float x) => x - (x * NOISE_SIMPLEX_1_DIV_289).floor() * 289;

        private static float2 mod289(float2 x) => x - (x * NOISE_SIMPLEX_1_DIV_289).floor() * 289;

        private static float3 mod289(float3 x) => x - (x * NOISE_SIMPLEX_1_DIV_289).floor() * 289;

        private static float4 mod289(float4 x) => x - (x * NOISE_SIMPLEX_1_DIV_289).floor() * 289;


// ( x*34 + 1 )*x =x*x*34 + x
        private static float permute(float x) => mod289(x * x * 34 + x);

        private static float3 permute(float3 x) => mod289(x * x * 34 + x);

        private static float4 permute(this float4 x) => mod289(x * x * 34 + x);

        private static float3 taylorInvSqrt(float3 r) => 1.79284291400159f - 0.85373472095314f * r;

        private static float4 taylorInvSqrt(float4 r) => 1.79284291400159f - r * 0.85373472095314f;

        private static float2 fade(float2 t) => t * t * t * (t * (t * 6 - 15) + 10);
        private static float3 fade(float3 t) => t * t * t * (t * (t * 6 - 15) + 10);

//==================================================================================================================================
// 1. Simplex Noise
//==================================================================================================================================
// 
// This shader is based on the webgl-noise GLSL shader. For further details
// of the original shader, please see the following description from the
// original source code.
//
//
// Description : Array and textureless GLSL 2D/3D/4D simplex
//               noise functions.
//      Author : Ian McEwan, Ashima Arts.
//  Maintainer : ijm
//     Lastmod : 20110822 (ijm)
//     License : Copyright (C) 2011 Ashima Arts. All rights reserved.
//               Distributed under the MIT License. See LICENSE file.
//               https://github.com/ashima/webgl-noise
//
//
// Usage:
//		float ns = snoise(v);
//		v is any of: float2, float3, float4
// Return type is float.
// To generate 2 or more components of noise(colorful noise),
// call these functions several times with different
// constant offsets for the arguments.
// E.g.:

// float3 colorNs = float3(
//	snoise(v),
//	snoise(v + 17),
//	snoise(v - 43),
//	);


//----------------------------------------------------[1.1]  2D Simplex Noise ----------------------------------------------------


        private static float snoise(float2 v)
        { var C = float4(0.211324865405187f, // (3-sqrt(3))/6
              0.366025403784439f, // 0.5f*(sqrt(3)-1)
              -0.577350269189626f, // -1 + 2 * C.x
              024390243902439f); // 1 / 41
          // First corner
          var i = (v + v.dot(C.yy)).floor();
          var x0 = v - i + i.dot(C.xx);

          // Other corners
          float2 i1;
          i1.x = x0.y.step(x0.x);
          i1.y = 1 - i1.x;

          // x1 = x0 - i1  + 1 * C.xx;
          // x2 = x0 - 1 + 2 * C.xx;
          var x1 = x0 + C.xx - i1;
          var x2 = x0 + C.zz;

          // Permutations
          i = mod289(i); // Avoid truncation effects in permutation
          var p = permute(permute(i.y + float3(0, i1.y, 1))
                          + i.x + float3(0, i1.x, 1));

          var m = (0.5f - float3(x0.dot(x0), x1.dot(x1), x2.dot(x2))).max(0);
          m = m * m;
          m = m * m;

          // Gradients: 41 points uniformly over a line, mapped onto a diamond.
          // The ring size 17*17 = 289 is close to a multiple of 41 (41*7 = 287)
          var x = 2 * (p * C.www).frac() - 1;
          var h = x.abs() - 0.5f;
          var ox = (x + 0.5f).floor();
          var a0 = x - ox;

          // Normalise gradients implicitly by scaling m
          m *= taylorInvSqrt(a0 * a0 + h * h);

          // Compute final noise value at P
          float3 g;
          g.x = a0.x * x0.x + h.x * x0.y;
          g.y = a0.y * x1.x + h.y * x1.y;
          g.z = a0.z * x2.x + h.z * x2.y;
          return 130 * m.dot(g); }

        private static float3 snoise_grad(float2 v)
        { var C = float4(0.211324865405187f, // (3-sqrt(3))/6
              0.366025403784439f, // 0.5f*(sqrt(3)-1)
              -0.577350269189626f, // -1 + 2 * C.x
              024390243902439f); // 1 / 41
          // First corner
          var i = (v + v.dot(C.yy)).floor();
          var x0 = v - i + i.dot(C.xx);

          // Other corners
          float2 i1;
          i1.x = x0.y.step(x0.x);
          i1.y = 1 - i1.x;

          // x1 = x0 - i1  + 1 * C.xx;
          // x2 = x0 - 1 + 2 * C.xx;
          var x1 = x0 + C.xx - i1;
          var x2 = x0 + C.zz;

          // Permutations
          i = mod289(i); // Avoid truncation effects in permutation
          var p = permute(permute(i.y + float3(0, i1.y, 1))
                          + i.x + float3(0, i1.x, 1));

          var m = (0.5f - float3(x0.dot(x0), x1.dot(x1), x2.dot(x2))).max(0);
          var m2 = m * m;
          var m3 = m2 * m;
          var m4 = m2 * m2;

          // Gradients: 41 points uniformly over a line, mapped onto a diamond.
          // The ring size 17*17 = 289 is close to a multiple of 41 (41*7 = 287)
          var x = 2 * (p * C.www).frac() - 1;
          var h = x.abs() - 0.5f;
          var ox = (x + 0.5f).floor();
          var a0 = x - ox;

          // Normalise gradients
          var norm = taylorInvSqrt(a0 * a0 + h * h);
          var g0 = float2(a0.x, h.x) * norm.x;
          var g1 = float2(a0.y, h.y) * norm.y;
          var g2 = float2(a0.z, h.z) * norm.z;

          // Compute noise and gradient at P
          var grad = -6 * m3.x * x0 * x0.dot(g0) + m4.x * g0 +
                     -6 * m3.y * x1 * x1.dot(g1) + m4.y * g1 +
                     -6 * m3.z * x2 * x2.dot(g2) + m4.z * g2;
          var px = float3(x0.dot(g0), x1.dot(g1), x2.dot(g2));
          return 130 * float3(grad, m4.dot(px)); }


//---------------------------------------------------[1.2] 3D Simplex Noise ---------------------------------------------

        private static float snoise(float3 v)
        { var C = float2(1 / 6f, 1 / 3);

          // First corner
          var i = (v + v.dot(C.yyy)).floor();
          var x0 = v - i + i.dot(C.xxx);

          // Other corners
          var g = x0.yzx.step(x0.xyz);
          var l = 1 - g;
          var i1 = g.xyz.min(l.zxy);
          var i2 = g.xyz.max(l.zxy);

          // x1 = x0 - i1  + 1 * C.xxx;
          // x2 = x0 - i2  + 2 * C.xxx;
          // x3 = x0 - 1 + 3 * C.xxx;
          var x1 = x0 - i1 + C.xxx;
          var x2 = x0 - i2 + C.yyy;
          var x3 = x0 - 0.5f;

          // Permutations
          i = mod289(i); // Avoid truncation effects in permutation
          var p = permute(permute(permute(i.z + float4(0, i1.z, i2.z, 1))
                                  + i.y + float4(0, i1.y, i2.y, 1))
                          + i.x + float4(0, i1.x, i2.x, 1));

          // Gradients: 7x7 points over a square, mapped onto an octahedron.
          // The ring size 17*17 = 289 is close to a multiple of 49 (49*6 = 294)
          var j = p - 49 * (p / 49).floor(); // mod(p,7*7)

          var x_ = (j / 7).floor();
          var y_ = (j - 7 * x_).floor(); // mod(j,N)

          var x = (x_ * 2 + 0.5f) / 7 - 1;
          var y = (y_ * 2 + 0.5f) / 7 - 1;

          var h = 1 - x.abs() - y.abs();

          var b0 = float4(x.xy, y.xy);
          var b1 = float4(x.zw, y.zw);

          //float4 s0 = float4(lessThan(b0, 0)) * 2 - 1;
          //float4 s1 = float4(lessThan(b1, 0)) * 2 - 1;
          var s0 = b0.floor() * 2 + 1;
          var s1 = b1.floor() * 2 + 1;
          var sh = -h.step(0);

          var a0 = b0.xzyw + s0.xzyw * sh.xxyy;
          var a1 = b1.xzyw + s1.xzyw * sh.zzww;

          var g0 = float3(a0.xy, h.x);
          var g1 = float3(a0.zw, h.y);
          var g2 = float3(a1.xy, h.z);
          var g3 = float3(a1.zw, h.w);

          // Normalise gradients
          var norm = taylorInvSqrt(float4(g0.dot(g0), g1.dot(g1), g2.dot(g2), g3.dot(g3)));
          g0 *= norm.x;
          g1 *= norm.y;
          g2 *= norm.z;
          g3 *= norm.w;

          // Mix final noise value
          var m = (0.6f - float4(x0.dot(x0), x1.dot(x1), x2.dot(x2), x3.dot(x3))).max(0);
          m = m * m;
          m = m * m;

          var px = float4(x0.dot(g0), x1.dot(g1), x2.dot(g2), x3.dot(g3));
          return 42 * m.dot(px); }

        private static float4 snoise_grad(float3 v)
        { var C = float2(1 / 6f, 1 / 3f);

          // First corner
          var i = (v + v.dot(C.yyy)).floor();
          var x0 = v - i + i.dot(C.xxx);

          // Other corners
          var g = x0.yzx.step(x0.xyz);
          var l = 1 - g;
          var i1 = g.xyz.min(l.zxy);
          var i2 = g.xyz.max(l.zxy);

          // x1 = x0 - i1  + 1 * C.xxx;
          // x2 = x0 - i2  + 2 * C.xxx;
          // x3 = x0 - 1 + 3 * C.xxx;
          var x1 = x0 - i1 + C.xxx;
          var x2 = x0 - i2 + C.yyy;
          var x3 = x0 - 0.5f;

          // Permutations
          i = mod289(i); // Avoid truncation effects in permutation
          var p = permute(permute(permute(i.z + float4(0, i1.z, i2.z, 1))
                                  + i.y + float4(0, i1.y, i2.y, 1))
                          + i.x + float4(0, i1.x, i2.x, 1));

          // Gradients: 7x7 points over a square, mapped onto an octahedron.
          // The ring size 17*17 = 289 is close to a multiple of 49 (49*6 = 294)
          var j = p - 49 * (p / 49).floor(); // mod(p,7*7)

          var x_ = (j / 7).floor();
          var y_ = (j - 7 * x_).floor(); // mod(j,N)

          var x = (x_ * 2 + 0.5f) / 7 - 1;
          var y = (y_ * 2 + 0.5f) / 7 - 1;

          var h = 1 - x.abs() - y.abs();

          var b0 = float4(x.xy, y.xy);
          var b1 = float4(x.zw, y.zw);

          //float4 s0 = float4(lessThan(b0, 0)) * 2 - 1;
          //float4 s1 = float4(lessThan(b1, 0)) * 2 - 1;
          var s0 = b0.floor() * 2 + 1;
          var s1 = b1.floor() * 2 + 1;
          var sh = -h.step(0);

          var a0 = b0.xzyw + s0.xzyw * sh.xxyy;
          var a1 = b1.xzyw + s1.xzyw * sh.zzww;

          var g0 = float3(a0.xy, h.x);
          var g1 = float3(a0.zw, h.y);
          var g2 = float3(a1.xy, h.z);
          var g3 = float3(a1.zw, h.w);

          // Normalise gradients
          var norm = taylorInvSqrt(float4(g0.dot(g0), g1.dot(g1), g2.dot(g2), g3.dot(g3)));
          g0 *= norm.x;
          g1 *= norm.y;
          g2 *= norm.z;
          g3 *= norm.w;

          // Compute noise and gradient at P
          var m = (0.6f - float4(x0.dot(x0), x1.dot(x1), x2.dot(x2), x3.dot(x3))).max(0);
          var m2 = m * m;
          var m3 = m2 * m;
          var m4 = m2 * m2;
          var grad = -6 * m3.x * x0 * x0.dot(g0) + m4.x * g0 +
                     -6 * m3.y * x1 * x1.dot(g1) + m4.y * g1 +
                     -6 * m3.z * x2 * x2.dot(g2) + m4.z * g2 +
                     -6 * m3.w * x3 * x3.dot(g3) + m4.w * g3;
          var px = float4(x0.dot(g0), x1.dot(g1), x2.dot(g2), x3.dot(g3));
          return 42 * float4(grad, m4.dot(px)); }


//----------------------------------------------------[1.3]  4D Simplex Noise ----------------------------------------------------

        private static float4 grad4(float j, float4 ip)
        { var ones = float4(1, 1, 1, -1);
          float4 p = new();

          p.xyz = (frac(j * ip.xyz) * 7).floor() * ip.z - 1;
          p.w = 1.5f - p.xyz.abs().dot(ones.xyz);

          // GLSL: lessThan(x, y) = x < y
          // HLSL: 1 -mathx.step(y, x) = x < y
          p.xyz -= p.xyz.sign().dim(p.w < 0);

          return p; }

        private static float snoise(float4 v)
        { var C = float4(
              0.138196601125011f, // (5 - sqrt(5))/20 G4
              0.276393202250021f, // 2 * G4
              0.414589803375032f, // 3 * G4
              -0.447213595499958f // -1 + 4 * G4
          );

          // First corner
          var i = (v + v.dot(0.309016994374947451f)).floor(); // (sqrt(5) - 1) / 4
          var x0 = v - i + i.dot(C.xxxx);

          // Other corners

          // Rank sorting originally contributed by Bill Licea-Kane, AMD (formerly ATI)
          float4 i0 = new();
          var isX = x0.yzw.step(x0.xxx);
          var isYZ = x0.zww.step(x0.yyz);
          i0.x = isX.x + isX.y + isX.z;
          i0.yzw = 1 - isX;
          i0.y += isYZ.x + isYZ.y;
          i0.zw += 1 - isYZ.xy;
          i0.z += isYZ.z;
          i0.w += 1 - isYZ.z;

          // i0 now contains the unique values 0,1,2,3 in each channel
          var i3 = saturate(i0);
          var i2 = saturate(i0 - 1);
          var i1 = saturate(i0 - 2);

          //    x0 = x0 - 0 + 0 * C.xxxx
          //    x1 = x0 - i1  + 1 * C.xxxx
          //    x2 = x0 - i2  + 2 * C.xxxx
          //    x3 = x0 - i3  + 3 * C.xxxx
          //    x4 = x0 - 1 + 4.0 * C.xxxx
          var x1 = x0 - i1 + C.xxxx;
          var x2 = x0 - i2 + C.yyyy;
          var x3 = x0 - i3 + C.zzzz;
          var x4 = x0 + C.wwww;

          // Permutations
          i = mod289(i);
          var j0 = permute(permute(permute(permute(i.w) + i.z) + i.y) + i.x);
          var j1 = permute(permute(permute(permute(i.w + float4(i1.w, i2.w, i3.w, 1)) + i.z + float4(i1.z, i2.z, i3.z, 1)) + i.y + float4(i1.y, i2.y, i3.y, 1)) + i.x + float4(i1.x, i2.x, i3.x, 1));

          // Gradients: 7x7x6 points over a cube, mapped onto a 4-cross polytope
          // 7*7*6 = 294, which is close to the ring size 17*17 = 289.
          var ip = float4(003401360544217687075f, // 1/294
              020408163265306122449f, // 1/49
              0.142857142857142857143f, // 1/7
              0);

          var p0 = grad4(j0, ip);
          var p1 = grad4(j1.x, ip);
          var p2 = grad4(j1.y, ip);
          var p3 = grad4(j1.z, ip);
          var p4 = grad4(j1.w, ip);

          // Normalise gradients
          var norm = rsqrt(float4(p0.dot(p0), p1.dot(p1), p2.dot(p2), p3.dot(p3)));
          p0 *= norm.x;
          p1 *= norm.y;
          p2 *= norm.z;
          p3 *= norm.w;
          p4 *= rsqrt(p4.dot(p4));

          // Mix contributions from the five corners
          var m0 = (0.6f - float3(x0.dot(x0), x1.dot(x1), x2.dot(x2))).max(0);
          var m1 = (0.6f - float2(x3.dot(x3), x4.dot(x4))).max(0);
          m0 = m0 * m0;
          m1 = m1 * m1;

          return 49 * ((m0 * m0).dot(float3(p0.dot(x0), p1.dot(x1), p2.dot(x2))) + (m1 * m1).dot(float2(p3.dot(x3), p4.dot(x4)))); }


//==================================================================================================================================
// 2. Classic Noise
//==================================================================================================================================
//
// GLSL textureless classic 2D noise "cnoise",
// with an RSL-style periodic variant "pnoise".
// Author:  Stefan Gustavson (stefan.gustavson@liu.se)
// Version: 2011-08-22
//
// Many thanks to Ian McEwan of Ashima Arts for the
// ideas for permutation and gradient selection.
//
// Copyright (c) 2011 Stefan Gustavson. All rights reserved.
// Distributed under the MIT license. See LICENSE file.
// https://github.com/ashima/webgl-noise


//-------------------------------------------------------[2.1] 2D  Classic Noise---------------------------------------------
// Classic Perlin noise
        private static float cnoise(float2 P)
        { var Pi = P.xyxy.floor() + float4(0, 0, 1, 1);
          var Pf = P.xyxy.frac() - float4(0, 0, 1, 1);
          Pi = mod289(Pi); // To avoid truncation effects in permutation
          var ix = Pi.xzxz;
          var iy = Pi.yyww;
          var fx = Pf.xzxz;
          var fy = Pf.yyww;

          var i = permute(permute(ix) + iy);

          var gx = (i / 41).frac() * 2 - 1;
          var gy = gx.abs() - 0.5f;
          var tx = (gx + 0.5f).floor();
          gx = gx - tx;

          var g00 = float2(gx.x, gy.x);
          var g10 = float2(gx.y, gy.y);
          var g01 = float2(gx.z, gy.z);
          var g11 = float2(gx.w, gy.w);

          var norm = taylorInvSqrt(float4(g00.dot(g00), g01.dot(g01), g10.dot(g10), g11.dot(g11)));
          g00 *= norm.x;
          g01 *= norm.y;
          g10 *= norm.z;
          g11 *= norm.w;

          var n00 = g00.dot(float2(fx.x, fy.x));
          var n10 = g10.dot(float2(fx.y, fy.y));
          var n01 = g01.dot(float2(fx.z, fy.z));
          var n11 = g11.dot(float2(fx.w, fy.w));

          var fade_xy = fade(Pf.xy);
          var n_x = lerp(float2(n00, n01), float2(n10, n11), fade_xy.x);
          var n_xy = lerp(n_x.x, n_x.y, fade_xy.y);
          return 2.3f * n_xy; }

// Classic Perlin noise, periodic variant
        private static float pnoise(float2 P, float2 rep)
        { var Pi = P.xyxy.floor() + float4(0, 0, 1, 1);
          var Pf = P.xyxy.frac() - float4(0, 0, 1, 1);
          Pi = mod(Pi, rep.xyxy); // To create noise with explicit period
          Pi = mod289(Pi); // To avoid truncation effects in permutation
          var ix = Pi.xzxz;
          var iy = Pi.yyww;
          var fx = Pf.xzxz;
          var fy = Pf.yyww;

          var i = permute(permute(ix) + iy);

          var gx = (i / 41).frac() * 2 - 1;
          var gy = gx.abs() - 0.5f;
          var tx = (gx + 0.5f).floor();
          gx = gx - tx;

          var g00 = float2(gx.x, gy.x);
          var g10 = float2(gx.y, gy.y);
          var g01 = float2(gx.z, gy.z);
          var g11 = float2(gx.w, gy.w);

          var norm = taylorInvSqrt(float4(g00.dot(g00), g01.dot(g01), g10.dot(g10), g11.dot(g11)));
          g00 *= norm.x;
          g01 *= norm.y;
          g10 *= norm.z;
          g11 *= norm.w;

          var n00 = g00.dot(float2(fx.x, fy.x));
          var n10 = g10.dot(float2(fx.y, fy.y));
          var n01 = g01.dot(float2(fx.z, fy.z));
          var n11 = g11.dot(float2(fx.w, fy.w));

          var fade_xy = fade(Pf.xy);
          var n_x = lerp(float2(n00, n01), float2(n10, n11), fade_xy.x);
          var n_xy = lerp(n_x.x, n_x.y, fade_xy.y);
          return 2.3f * n_xy; }


//----------------------------------------------------[2.2] 3D  Classic Noise--------------------------------------------------
// Classic Perlin noise
        private static float cnoise(float3 P)
        { var Pi0 = P.floor(); // Integer part for indexing
          var Pi1 = Pi0 + (float3)1; // Integer part + 1
          Pi0 = mod289(Pi0);
          Pi1 = mod289(Pi1);
          var Pf0 = P.frac(); //mathx.fractional part for interpolation
          var Pf1 = Pf0 - (float3)1; //mathx.fractional part - 1
          var ix = float4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
          var iy = float4(Pi0.y, Pi0.y, Pi1.y, Pi1.y);
          float4 iz0 = Pi0.z;
          float4 iz1 = Pi1.z;

          var ixy = permute(permute(ix) + iy);
          var ixy0 = permute(ixy + iz0);
          var ixy1 = permute(ixy + iz1);

          var gx0 = ixy0 / 7;
          var gy0 = (gx0.floor() / 7).frac() - 0.5f;
          gx0 = gx0.frac();
          var gz0 = (float4)0.5f - gx0.abs() - gy0.abs();
          var sz0 = gz0.step(0);
          gx0 -= sz0 * (step(0, gx0) - 0.5f);
          gy0 -= sz0 * (step(0, gy0) - 0.5f);

          var gx1 = ixy1 / 7;
          var gy1 = (gx1.floor() / 7).frac() - 0.5f;
          gx1 = gx1.frac();
          var gz1 = (float4)0.5f - gx1.abs() - gy1.abs();
          var sz1 = gz1.step(0);
          gx1 -= sz1 * (step(0, gx1) - 0.5f);
          gy1 -= sz1 * (step(0, gy1) - 0.5f);

          var g000 = float3(gx0.x, gy0.x, gz0.x);
          var g100 = float3(gx0.y, gy0.y, gz0.y);
          var g010 = float3(gx0.z, gy0.z, gz0.z);
          var g110 = float3(gx0.w, gy0.w, gz0.w);
          var g001 = float3(gx1.x, gy1.x, gz1.x);
          var g101 = float3(gx1.y, gy1.y, gz1.y);
          var g011 = float3(gx1.z, gy1.z, gz1.z);
          var g111 = float3(gx1.w, gy1.w, gz1.w);

          var norm0 = taylorInvSqrt(float4(g000.dot(g000), g010.dot(g010), g100.dot(g100), g110.dot(g110)));
          g000 *= norm0.x;
          g010 *= norm0.y;
          g100 *= norm0.z;
          g110 *= norm0.w;

          var norm1 = taylorInvSqrt(float4(g001.dot(g001), g011.dot(g011), g101.dot(g101), g111.dot(g111)));
          g001 *= norm1.x;
          g011 *= norm1.y;
          g101 *= norm1.z;
          g111 *= norm1.w;

          var n000 = g000.dot(Pf0);
          var n100 = g100.dot(float3(Pf1.x, Pf0.y, Pf0.z));
          var n010 = g010.dot(float3(Pf0.x, Pf1.y, Pf0.z));
          var n110 = g110.dot(float3(Pf1.x, Pf1.y, Pf0.z));
          var n001 = g001.dot(float3(Pf0.x, Pf0.y, Pf1.z));
          var n101 = g101.dot(float3(Pf1.x, Pf0.y, Pf1.z));
          var n011 = g011.dot(float3(Pf0.x, Pf1.y, Pf1.z));
          var n111 = g111.dot(Pf1);

          var fade_xyz = fade(Pf0);
          var n_z = lerp(float4(n000, n100, n010, n110), float4(n001, n101, n011, n111), fade_xyz.z);
          var n_yz = lerp(n_z.xy, n_z.zw, fade_xyz.y);
          var n_xyz = lerp(n_yz.x, n_yz.y, fade_xyz.x);
          return 2.2f * n_xyz; }

// Classic Perlin noise, periodic variant
        private static float pnoise(float3 P, float3 rep)
        { var Pi0 = mod(P.floor(), rep); // Integer part, modulo period
          var Pi1 = mod(Pi0 + (float3)1, rep); // Integer part + 1, mod period
          Pi0 = mod289(Pi0);
          Pi1 = mod289(Pi1);
          var Pf0 = P.frac(); //mathx.fractional part for interpolation
          var Pf1 = Pf0 - (float3)1; //mathx.fractional part - 1
          var ix = float4(Pi0.x, Pi1.x, Pi0.x, Pi1.x);
          var iy = float4(Pi0.y, Pi0.y, Pi1.y, Pi1.y);
          float4 iz0 = Pi0.z;
          float4 iz1 = Pi1.z;

          var ixy = permute(permute(ix) + iy);
          var ixy0 = permute(ixy + iz0);
          var ixy1 = permute(ixy + iz1);

          var gx0 = ixy0 / 7;
          var gy0 = (gx0.floor() / 7).frac() - 0.5f;
          gx0 = gx0.frac();
          var gz0 = (float4)0.5f - gx0.abs() - gy0.abs();
          var sz0 = gz0.step(0);
          gx0 -= sz0 * (step(0, gx0) - 0.5f);
          gy0 -= sz0 * (step(0, gy0) - 0.5f);

          var gx1 = ixy1 / 7;
          var gy1 = (gx1.floor() / 7).frac() - 0.5f;
          gx1 = gx1.frac();
          var gz1 = (float4)0.5f - gx1.abs() - gy1.abs();
          var sz1 = gz1.step(0);
          gx1 -= sz1 * (step(0, gx1) - 0.5f);
          gy1 -= sz1 * (step(0, gy1) - 0.5f);

          var g000 = float3(gx0.x, gy0.x, gz0.x);
          var g100 = float3(gx0.y, gy0.y, gz0.y);
          var g010 = float3(gx0.z, gy0.z, gz0.z);
          var g110 = float3(gx0.w, gy0.w, gz0.w);
          var g001 = float3(gx1.x, gy1.x, gz1.x);
          var g101 = float3(gx1.y, gy1.y, gz1.y);
          var g011 = float3(gx1.z, gy1.z, gz1.z);
          var g111 = float3(gx1.w, gy1.w, gz1.w);

          var norm0 = taylorInvSqrt(float4(g000.dot(g000), g010.dot(g010), g100.dot(g100), g110.dot(g110)));
          g000 *= norm0.x;
          g010 *= norm0.y;
          g100 *= norm0.z;
          g110 *= norm0.w;
          var norm1 = taylorInvSqrt(float4(g001.dot(g001), g011.dot(g011), g101.dot(g101), g111.dot(g111)));
          g001 *= norm1.x;
          g011 *= norm1.y;
          g101 *= norm1.z;
          g111 *= norm1.w;

          var n000 = g000.dot(Pf0);
          var n100 = g100.dot(float3(Pf1.x, Pf0.y, Pf0.z));
          var n010 = g010.dot(float3(Pf0.x, Pf1.y, Pf0.z));
          var n110 = g110.dot(float3(Pf1.x, Pf1.y, Pf0.z));
          var n001 = g001.dot(float3(Pf0.x, Pf0.y, Pf1.z));
          var n101 = g101.dot(float3(Pf1.x, Pf0.y, Pf1.z));
          var n011 = g011.dot(float3(Pf0.x, Pf1.y, Pf1.z));
          var n111 = g111.dot(Pf1);

          var fade_xyz = fade(Pf0);
          var n_z = lerp(float4(n000, n100, n010, n110), float4(n001, n101, n011, n111), fade_xyz.z);
          var n_yz = lerp(n_z.xy, n_z.zw, fade_xyz.y);
          var n_xyz = lerp(n_yz.x, n_yz.y, fade_xyz.x);
          return 2.2f * n_xyz; }


//==================================================================================================================================
// 3. Simplex-like Re-oriented BBC Noise
//==================================================================================================================================

//
// The original shader was created by KdotJPG and released into the public
// domain (Unlicense). Refer to the following GitHub repository for the details
// of the original work.
//
// https://github.com/KdotJPG/New-Simplex-Style-Gradient-Noise
//


        private static float4 bcc4_mod(float4 x, float4 y) => x - y * (x / y).floor();

// Inspired by Stefan Gustavson's noise
        private static float4 bcc4_permute(float4 t) => t * (t * 34 + 133);


//--------------------------------------------------[3.1] 4-Point BCC Noise-----------------------------------------------
// K.jpg's Smooth Re-oriented 8-Point BCC Noise
// Output: float4(dF/dx, dF/dy, dF/dz, value)


// Gradient set is a normalized expanded rhombic dodecahedron
        private static float3 bcc4_grad(float hash)
        { // Random vertex of a cube, +/- 1 each
          var cube = ((hash / float3(1, 2, 4)).floor() * 0.5f).frac() * 4 - 1;

          // Random edge of the three edges connected to that vertex
          // Also a cuboctahedral vertex
          // And corresponds to the face of its dual, the rhombic dodecahedron
          var cuboct = cube;
          cuboct *= (float3(0, 1, 2) != (int)(hash / 16)).asfloat();

          // In a funky way, pick one of the four points on the rhombic face
          var type = ((hash / 8).floor() * 0.5f).frac() * 2;
          var rhomb = (1 - type) * cube + type * (cuboct + cross(cube, cuboct));

          // Expand it so that the new edges are the same length
          // as the existing ones
          var grad = cuboct * 1.22474487139f + rhomb;

          // To make all gradients the same length, we only need to shorten the
          // second type of vector. We also put in the whole noise scale constant.
          // The compiler should reduce it into the existing floats. I think.
          grad *= (1 - 042942436724648037f * type) * 32.80201376986577f;

          return grad; }

// BCC lattice split up into 2 cube lattices
        private static float4 Bcc4NoiseBase(float3 X)
        { // First half-lattice, closest edge
          var v1 = round(X);
          var d1 = X - v1;
          var score1 = d1.abs();
          var dir1 = (score1.yzx.max(score1.zxy) < score1).asfloat();
          var v2 = v1 + dir1 * (d1 < 0).select(-1, 1);
          var d2 = X - v2;

          // Second half-lattice, closest edge
          var X2 = X + 144.5f;
          var v3 = round(X2);
          var d3 = X2 - v3;
          var score2 = d3.abs();
          var dir2 = (score2.yzx.max(score2.zxy) < score2).asfloat();
          var v4 = v3 + dir2 * (d3 < 0).select(-1, 1);
          var d4 = X2 - v4;

          // Gradient hashes for the four points, two from each half-lattice
          var hashes = bcc4_permute(bcc4_mod(float4(v1.x, v2.x, v3.x, v4.x), 289));
          hashes = bcc4_permute(bcc4_mod(hashes + float4(v1.y, v2.y, v3.y, v4.y), 289));
          hashes = bcc4_mod(bcc4_permute(bcc4_mod(hashes + float4(v1.z, v2.z, v3.z, v4.z), 289)), 48);

          // Gradient extrapolations & kernel function
          var a = (0.5f - float4(d1.dot(d1), d2.dot(d2), d3.dot(d3), d4.dot(d4))).max(0);
          var aa = a * a;
          var aaaa = aa * aa;
          var g1 = bcc4_grad(hashes.x);
          var g2 = bcc4_grad(hashes.y);
          var g3 = bcc4_grad(hashes.z);
          var g4 = bcc4_grad(hashes.w);
          var extrapolations = float4(d1.dot(g1), d2.dot(g2), d3.dot(g3), d4.dot(g4));

          // Derivatives of the noise
          var derivative = -8 * mul(aa * a * extrapolations, float3x4(d1, d2, d3, d4)) + mul(aaaa, float3x4(g1, g2, g3, g4));

          // Return it all as a float4
          return float4(derivative, aaaa.dot(extrapolations)); }

// Use this if you don't want Z to look different from X and Y
        private static float4 Bcc4NoiseClassic(float3 X)
        { // Rotate around the main diagonal. Not a skew transform.
          var result = Bcc4NoiseBase(X.dot(2 / 3) - X);
          return float4(result.xyz.dot(2 / 3) - result.xyz, result.w); }

// Use this if you want to show X and Y in a plane, and use Z for time, etc.
        private static float4 Bcc4NoisePlaneFirst(float3 X)
        { // Rotate so Z points down the main diagonal. Not a skew transform.
          float3x3 orthonormalMap = new(
              0.788675134594813f, -0.211324865405187f, -0.577350269189626f,
              -0.211324865405187f, 0.788675134594813f, -0.577350269189626f,
              0.577350269189626f, 0.577350269189626f, 0.577350269189626f);

          var result = Bcc4NoiseBase(mul(X, orthonormalMap));
          return float4(mul(orthonormalMap, result.xyz), result.w); }


//------------------------------------------------[3.2] 8-Point BCC Noise------------------------------------------------------
// K.jpg's Smooth Re-oriented 8-Point BCC Noise
// Output: float4(dF/dx, dF/dy, dF/dz, value)


        private static float4 bcc8_mod(float4 x, float4 y) => x - y * (x / y).floor();

// Borrowed from Stefan Gustavson's noise code
        private static float4 bcc8_permute(float4 t) => t * (t * 34 + 133);

// Gradient set is a normalized expanded rhombic dodecahedron
        private static float3 bcc8_grad(float hash)
        { // Random vertex of a cube, +/- 1 each
          var cube = ((hash / float3(1, 2, 4)).floor() * 0.5f).frac() * 4 - 1;

          // Random edge of the three edges connected to that vertex
          // Also a cuboctahedral vertex
          // And corresponds to the face of its dual, the rhombic dodecahedron
          var cuboct = cube;
          cuboct.dim(new int3(0, 1, 2) != (int)(hash / 16));

          // In a funky way, pick one of the four points on the rhombic face
          var type = ((hash / 8).floor() * 0.5f).frac() * 2;
          var rhomb = (1 - type) * cube + type * (cuboct + cross(cube, cuboct));

          // Expand it so that the new edges are the same length
          // as the existing ones
          var grad = cuboct * 1.22474487139f + rhomb;

          // To make all gradients the same length, we only need to shorten the
          // second type of vector. We also put in the whole noise scale constant.
          // The compiler should reduce it into the existing floats. I think.
          grad *= (1 - 042942436724648037f * type) * 3.5946317686139184f;

          return grad; }

// BCC lattice split up into 2 cube lattices
        private static float4 Bcc8NoiseBase(float3 X)
        { var b = X.floor();
          var i4 = float4(X - b, 2.5f);

          // Pick between each pair of oppposite corners in the cube.
          var v1 = b + i4.dot(0.25f).floor();
          var v2 = b + float3(1, 0, 0) + float3(-1, 1, 1) * i4.dot(float4(-.25f, .25f, .25f, .35f)).floor();
          var v3 = b + float3(0, 1, 0) + float3(1, -1, 1) * i4.dot(float4(.25f, -.25f, .25f, .35f)).floor();
          var v4 = b + float3(0, 0, 1) + float3(1, 1, -1) * i4.dot(float4(.25f, .25f, -.25f, .35f)).floor();

          // Gradient hashes for the four vertices in this half-lattice.
          var hashes = bcc8_permute(bcc8_mod(float4(v1.x, v2.x, v3.x, v4.x), 289));
          hashes = bcc8_permute(bcc8_mod(hashes + float4(v1.y, v2.y, v3.y, v4.y), 289));
          hashes = bcc8_mod(bcc8_permute(bcc8_mod(hashes + float4(v1.z, v2.z, v3.z, v4.z), 289)), 48);

          // Gradient extrapolations & kernel function
          var d1 = X - v1;
          var d2 = X - v2;
          var d3 = X - v3;
          var d4 = X - v4;
          var a = (0.75f - float4(d1.dot(d1), d2.dot(d2), d3.dot(d3), d4.dot(d4))).max(0);
          var aa = a * a;
          var aaaa = aa * aa;
          var g1 = bcc8_grad(hashes.x);
          var g2 = bcc8_grad(hashes.y);
          var g3 = bcc8_grad(hashes.z);
          var g4 = bcc8_grad(hashes.w);
          var extrapolations = float4(d1.dot(g1), d2.dot(g2), d3.dot(g3), d4.dot(g4));

          // Derivatives of the noise
          var derivative = -8 * mul(aa * a * extrapolations, float3x4(d1, d2, d3, d4)) + mul(aaaa, float4(g1.x, g2.x, g3.x, g4.x)).xyz();

          // Return it all as a float4
          return float4(derivative, aaaa.dot(extrapolations)); }

// Rotates domain, but preserve shape. Hides grid better in cardinal slices.
// Good for texturing 3D objects with lots of flat parts along cardinal planes.
        private static float4 Bcc8NoiseClassic(float3 X)
        { X = X.dot(2 / 3) - X;

          var result = Bcc8NoiseBase(X) + Bcc8NoiseBase(X + 144.5f);

          return float4(result.xyz.dot(2 / 3) - result.xyz, result.w); }

// Gives X and Y a triangular alignment, and lets Z move up the main diagonal.
// Might be good for terrain, or a time varying X/Y plane. Z repeats.
        private static float4 Bcc8NoisePlaneFirst(float3 X)
        { // Not a skew transform.
          var orthonormalMap = float3x3(
              0.788675134594813f, -0.211324865405187f, -0.577350269189626f,
              -0.211324865405187f, 0.788675134594813f, -0.577350269189626f,
              0.577350269189626f, 0.577350269189626f, 0.577350269189626f);

          X = mul(X, orthonormalMap);
          var result = Bcc8NoiseBase(X) + Bcc8NoiseBase(X + 144.5f);

          return float4(mul(orthonormalMap, result.xyz), result.w); }
    }
}