#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

// using System.Runtime.CompilerServices;
// // using static Unity.Mathematics.math;
// using static Unity.Mathematics.mathx;
//
// namespace Unity.Mathematics {
//
// public static partial class Noise
// {
//     #region 1D gradient noise (base implementation)
//
//     [MethodImpl(IL)]
//     public static float Float(float p, uint seed)
//     {
//         var hash = new hash(seed);
//
//         var i = (uint)((int)p + 0x10000000);
//         var x = p.frac();
//
//         var k = f2(x, 1 - x).sq().inv().cube();
//
//         var g = f2(
//             hash.Float(-1, 1, i),
//             hash.Float(-1, 1, i + 1));
//
//         var n = (k * g).dot(f2(x, x - 1));
//         return n * 2 * 32 / 27;
//     }
//
//     #endregion
//
//     #region Vector generators
//
//     public static float2 Float2(float2 p, uint seed)
//     {
//         var hash = new XXHash(seed);
//         var i = (uint2)((int2)p + 0x10000000);
//         var x = p.frac();
//         var x0 = x.sq().inv().cube() + x.inv().sq().inv().cube() * 2.82842712475f;
//         var g0 = hash.Float2(-1, 1, i);
//         var g1 = hash.Float2(-1, 1, i + 1);
//         return x.lerp(g0, g1) * x0;
//     }
//
//     public static float3 Float3(float3 p, uint seed)
//     {
//         var hash = new XXHash(seed);
//
//         var i = (uint3)((int3)p + 0x10000000);
//         var x = p.frac();
//
//         var x0 = x.sq().inv().cube();
//         var x1 = x.inv().sq().inv().cube();
//
//         var g0 = hash.Float3(-1, 1, i);
//         var g1 = hash.Float3(-1, 1, i + 1);
//
//         var n = x0 * g0 * x + x1 * g1 * (x - 1);
//         return n * 2.82842712475f;
//     }
//
//     public static float4 Float4(float4 p, uint seed)
//     {
//         var hash = new XXHash(seed);
//
//         var i = (uint4)((int4)p + 0x10000000);
//         var x = p.frac();
//
//         var x0 = x.sq().inv().cube();
//         var x1 = x.inv().sq().inv().cube();
//
//         var g0 = hash.Float4(-1, 1, i);
//         var g1 = hash.Float4(-1, 1, i + 1);
//
//         var n = x0 * g0 * x + x1 * g1 * (x - 1);
//         return n * 2.82842712475f;
//     }
//
//     #endregion
//
//     #region Fractal noise
//
//     public static float Fractal(float p, int octave, uint seed)
//     {
//         float f = 0;
//         float w = 1;
//         for (var i = 0; i < octave; i++)
//         {
//             f += w * Float(p, seed);
//             p *= 2;
//             w /= 2;
//         }
//         return f;
//     }
//
//     public static float2 Fractal2(float2 p, int octave, uint seed)
//     {
//         float2 f = 0;
//         float w = 1;
//         for (var i = 0; i < octave; i++)
//         {
//             f += w * Float2(p, seed);
//             p *= 2;
//             w /= 2;
//         }
//         return f;
//     }
//
//     public static float3 Fractal3(float3 p, int octave, uint seed)
//     {
//         float3 f = 0;
//         float w = 1;
//         for (var i = 0; i < octave; i++)
//         {
//             f += w * Float3(p, seed);
//             p *= 2;
//             w /= 2;
//         }
//         return f;
//     }
//
//     public static float4 Fractal4(float4 p, int octave, uint seed)
//     {
//         float4 f = 0;
//         float w = 1;
//         for (var i = 0; i < octave; i++)
//         {
//             f += w * Float4(p, seed);
//             p *= 2;
//             w /= 2;
//         }
//         return f;
//     }
//
//     #endregion
//
//     #region Quaternion generators
//
//     public static quaternion Rotation(float3 p, float3 angles, uint seed)
//       => quaternion.EulerZXY(angles * Float3(p, seed));
//
//     public static quaternion
//       FractalRotation(float3 p, int octave, float3 angles, uint seed)
//       => quaternion.EulerZXY(angles * Fractal3(p, octave, seed));
//
//     #endregion
// }
//
// } // namespace Klak.Math
