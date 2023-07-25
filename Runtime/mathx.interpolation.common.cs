#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;

namespace Unity.Mathematics
{
    [BurstCompile]
    public static partial class mathx
    {
        ///<summary>Quintic Smoothstep</summary>
        [MethodImpl(IL)] public static  float4 smootherstep(this float4 f) => f.cube() * (f * (f * 6 - 15) + 10).sat();
        ///<inheritdoc cref="smootherstep(float4)"/>
        [MethodImpl(IL)] public static  float3 smootherstep(this float3 f) => f.cube() * (f * (f * 6 - 15) + 10).sat();
        ///<inheritdoc cref="smootherstep(float4)"/>
        [MethodImpl(IL)] public static  float2 smootherstep(this float2 f) => f.cube() * (f * (f * 6 - 15) + 10).sat();
        ///<inheritdoc cref="smootherstep(float4)"/>
        [MethodImpl(IL)] public static  float smootherstep(this float f) => f.cube() * (f * (f * 6 - 15) + 10).sat();
        
        ///<summary>Smoothstep using Cosine function to interpolate smoothly</summary>
        [MethodImpl(IL)] public static  float4 smoothstepcos(this float4 f) => (f.sat() * PI).cos().inv() * 0.5f;
        ///<inheritdoc cref="smoothstepcos(float4)"/>
        [MethodImpl(IL)] public static  float3 smoothstepcos(this float3 f) => (f.sat() * PI).cos().inv() * 0.5f;
        ///<inheritdoc cref="smoothstepcos(float4)"/>
        [MethodImpl(IL)] public static  float2 smoothstepcos(this float2 f) => (f.sat() * PI).cos().inv() * 0.5f;
        ///<inheritdoc cref="smoothstepcos(float4)"/>
        [MethodImpl(IL)] public static  float smoothstepcos(this float f) => (f.sat() * PI).cos().inv() * 0.5f;
        
        ///<summary>Lerp with a custom power</summary>
        [MethodImpl(IL)] public static  float4 eerp(this float4 f, float4 a, float4 b) => a.pow(1 - f) * b.pow(f);
        ///<inheritdoc cref="eerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float3 eerp(this float3 f, float3 a, float3 b) => a.pow(1 - f) * b.pow(f);
        ///<inheritdoc cref="eerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float2 eerp(this float2 f, float2 a, float2 b) => a.pow(1 - f) * b.pow(f);
        ///<inheritdoc cref="eerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float eerp(this float f, float a, float b) => a.pow(1 - f) * b.pow(f);
        
        ///<summary>Inverse-Lerp with a custom power</summary>
        [MethodImpl(IL)] public static  float4 uneerp(this float4 f, float4 a, float4 b) => (a / f).ln() / (a / b).ln();
        ///<inheritdoc cref="uneerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float3 uneerp(this float3 f, float3 a, float3 b) => (a / f).ln() / (a / b).ln();
        ///<inheritdoc cref="uneerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float2 uneerp(this float2 f, float2 a, float2 b) => (a / f).ln() / (a / b).ln();
        ///<inheritdoc cref="uneerp(float4,float4,float4)"/>
        [MethodImpl(IL)] public static  float uneerp(this float f, float a, float b) => (a / f).ln() / (a / b).ln();

        // SmoothStep -----------------------------------------------------------------------------
        /// Returns a smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].
        [MethodImpl(IL)] public static  float smoothstep(this float f, float min, float max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double smoothstep(this double f, double min, double max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float4 smoothstep(this float4 f, float4 min, float4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float3 smoothstep(this float3 f, float3 min, float3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float2 smoothstep(this float2 f, float2 min, float2 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double4 smoothstep(this double4 f, double4 min, double4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double3 smoothstep(this double3 f, double3 min, double3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double2 smoothstep(this double2 f, double2 min, double2 max) => math.smoothstep(min, max, f);
        /// Returns a smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].
        [MethodImpl(IL)] public static  float smoothstep(this float f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double smoothstep(this double f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float4 smoothstep(this float4 f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float3 smoothstep(this float3 f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  float2 smoothstep(this float2 f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double4 smoothstep(this double4 f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double3 smoothstep(this double3 f) => f.smoothstep(0, 1);
        /// <inheritdoc cref="smoothstep(float,float,float)" />
        [MethodImpl(IL)] public static  double2 smoothstep(this double2 f) => f.smoothstep(0, 1);

        // Unlerp -----------------------------------------------------------------------------
        /// Returns the result of normalizing a floating point value x to a range [min, max]. The opposite of lerp. Equivalent to (x - min) / (max - min).
        [MethodImpl(IL)] public static  float unlerp(this float f, float min = 0, float max = 1) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  double unlerp(this double f, double min = 0.0, double max = 1.0) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  float4 unlerp(this float4 f, float4 min, float4 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  float3 unlerp(this float3 f, float3 min, float3 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  float2 unlerp(this float2 f, float2 min, float2 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  double4 unlerp(this double4 f, double4 min, double4 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  double3 unlerp(this double3 f, double3 min, double3 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)" />
        [MethodImpl(IL)] public static  double2 unlerp(this double2 f, double2 min, double2 max) => math.unlerp(min, max, f);

        // Lerp -----------------------------------------------------------------------------
        /// Returns the result of linearly interpolating from min to max using the interpolation parameter f.
        [MethodImpl(IL)] public static  float lerp(this float f, float min = 0, float max = 1) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float,float,float)" />
        [MethodImpl(IL)] public static  double lerp(this double f, double min = 0.0, double max = 1.0) => math.lerp(min, max, f);
        /// Returns the result of a componentwise linear interpolating from min to max using the interpolation parameter f.
        [MethodImpl(IL)] public static  float4 lerp(this float4 f, float4 min, float4 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  float3 lerp(this float3 f, float3 min, float3 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  float2 lerp(this float2 f, float2 min, float2 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double4 lerp(this double4 f, double4 min, double4 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double3 lerp(this double3 f, double3 min, double3 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double2 lerp(this double2 f, double2 min, double2 max) => math.lerp(min, max, f);

        //using vectors as interpolation parameter
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  float4 lerp(this float f, float4 min, float4 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  float3 lerp(this float f, float3 min, float3 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  float2 lerp(this float f, float2 min, float2 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double4 lerp(this double f, double4 min, double4 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double3 lerp(this double f, double3 min, double3 max) => math.lerp(min, max, f);
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static  double2 lerp(this double f, double2 min, double2 max) => math.lerp(min, max, f);
        
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2x2 lerp(this float t, float2x2 f1, float2x2 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2x3 lerp(this float t, float2x3 f1, float2x3 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2x4 lerp(this float t, float2x4 f1, float2x4 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3x2 lerp(this float t, float3x2 f1, float3x2 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3x3 lerp(this float t, float3x3 f1, float3x3 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3x4 lerp(this float t, float3x4 f1, float3x4 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float4x2 lerp(this float t, float4x2 f1, float4x2 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float4x3 lerp(this float t, float4x3 f1, float4x3 f2) => t.inv() * f1 + t * f2;
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        [MethodImpl(IL)] public static float4x4 lerp(this float t, float4x4 f1, float4x4 f2) => t.inv() * f1 + t * f2;

        // Lerp Angle -------------------------------------------
        [MethodImpl(IL)] public static  float lerpAngle(this float x, float a, float b) {
            var num = (b - a).repeat(360);
            if (num > 180.0) num -= 360;
            return a + num * x.sat();
        }

        /// Remapping function identical as in HLSL
        [MethodImpl(IL)] public static  float4 remap(this float t, float4 oldMin, float4 oldMax, float4 newMin, float4 newMax) => math.remap(oldMin, oldMax, newMin, newMax, t);
        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        [MethodImpl(IL)] public static  float3 remap(this float t, float3 oldMin, float3 oldMax, float3 newMin, float3 newMax) => math.remap(oldMin, oldMax, newMin, newMax, t);
        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        [MethodImpl(IL)] public static  float2 remap(this float t, float2 oldMin, float2 oldMax, float2 newMin, float2 newMax) => math.remap(oldMin, oldMax, newMin, newMax, t);
        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        [MethodImpl(IL)] public static  float remap(this float t, float oldMin, float oldMax, float newMin, float newMax) => math.remap(oldMin, oldMax, newMin, newMax, t);

        /// <inheritdoc cref="math.step(float, float)" />
        [MethodImpl(IL)] public static  float step(this float f, float step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  double step(this double f, double step = 0.0) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  float4 step(this float4 f, float4 step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  float3 step(this float3 f, float3 step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  float2 step(this float2 f, float2 step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  double4 step(this double4 f, double4 step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  double3 step(this double3 f, double3 step) => math.step(f, step);
        /// <inheritdoc cref="step(float,float)" />
        [MethodImpl(IL)] public static  double2 step(this double2 f, double2 step) => math.step(f, step);
        
        #region arc
       
        /// <summary> Returns the absolute version of sin(x) </summary>
        [MethodImpl(IL)] public static float4 arc(this float4 x) => abs(sine01(x));
        /// <inheritdoc cref="arc(float4)" />
        [MethodImpl(IL)] public static float3 arc(this float3 x) => abs(sine01(x));
        /// <inheritdoc cref="arc(float4)" />
        [MethodImpl(IL)] public static float2 arc(this float2 x) => abs(sine01(x));
        /// <inheritdoc cref="arc(float4)" />
        [MethodImpl(IL)] public static float arc(this float x) => abs(sine01(x));
        
        #endregion
        
        #region arch2
       
        /// <summary> Returns x multiplied by inv(x) </summary>
        [MethodImpl(IL)] public static float4 arch2(float4 x) => x * inv(x);
        /// <inheritdoc cref="arch2(float4)" />
        [MethodImpl(IL)] public static float3 arch2(float3 x) => x * inv(x);
        /// <inheritdoc cref="arch2(float4)" />
        [MethodImpl(IL)] public static float2 arch2(float2 x) => x * inv(x);
        /// <inheritdoc cref="arch2(float4)" />
        [MethodImpl(IL)] public static float arch2(float x) => x * inv(x);
        
        #endregion
        
        #region linstep
        
        /// <summary> Remaps a value from a min to max to tih </summary>
        [MethodImpl(IL)] public static float4 linstep(float4 value, float4 zero, float4 one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float4 linstep(float4 value, float4 zero, float one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3 linstep(float3 value, float3 zero, float3 one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3 linstep(float3 value, float3 zero, float one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 linstep(float2 value, float2 zero, float2 one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 linstep(float2 value, float2 zero, float one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 linstep(float2 value, float zero, float2 one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 linstep(float2 value, float zero, float one) => saturate(value.unlerp(zero, one));
        /// <inheritdoc cref="linstep(float4,float4,float4)" />
        [MethodImpl(IL)] public static float linstep(float value, float zero, float one) => saturate(zero.unlerp(one, value));
        
        #endregion

        #region sine01
        
        /// <summary> Returns the sin of x multiplied by PI. </summary>
        [MethodImpl(IL)] public static float4 sine01(float4 x) => sin(x*PI);
        /// <inheritdoc cref="sine01(float4)" />
        [MethodImpl(IL)] public static float3 sine01(float3 x) => sin(x*PI);
        /// <inheritdoc cref="sine01(float4)" />
        [MethodImpl(IL)] public static float2 sine01(float2 x) => sin(x*PI);
        /// <inheritdoc cref="sine01(float4)" />
        [MethodImpl(IL)] public static float sine01(float x) => sin(x*PI);
        
        #endregion

        
        #region Smooth Min

        /// Smooth min is a smooth version of math.min() that accepts a smoothness parameter t
        [MethodImpl(IL)] public static float smin(this float t, float a, float b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float2 smin(this float t, float2 a, float2 b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float3 smin(this float t, float3 a, float3 b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float4 smin(this float t, float4 a, float4 b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float2 smin(this float2 t, float2 a, float2 b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float3 smin(this float3 t, float3 a, float3 b) => smax(-t, a, b);
        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(IL)] public static float4 smin(this float4 t, float4 a, float4 b) => smax(-t, a, b);

        #endregion

        #region Smooth Max

        /// Smooth max is a smooth version of math.max() that accepts a smoothness parameter t
        [MethodImpl(IL)] public static float smax(this float t, float a, float b) {
            var h = (0.5f + (b - a) / (t * 2)).sat();
            return h.lerp(a, b) + t * h * (1 - h);
        }
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float2 smax(this float t, float2 a, float2 b) => f2(t.smax(a.x, b.x), t.smax(a.y, b.y));
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float3 smax(this float t, float3 a, float3 b) => f3(t.smax(a.x, b.x), t.smax(a.y, b.y), t.smax(a.z, b.z));
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float4 smax(this float t, float4 a, float4 b) => f4(t.smax(a.x, b.x), t.smax(a.y, b.y), t.smax(a.z, b.z), t.smax(a.w, b.w));
        
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float2 smax(this float2 t, float2 a, float2 b) => f2(t.x.smax(a.x, b.x), t.y.smax(a.y, b.y));
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float3 smax(this float3 t, float3 a, float3 b) => f3(t.x.smax(a.x, b.x), t.y.smax(a.y, b.y), t.z.smax(a.z, b.z));
        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(IL)] public static float4 smax(this float4 t, float4 a, float4 b) => f4(t.x.smax(a.x, b.x), t.y.smax(a.y, b.y), t.z.smax(a.z, b.z), t.w.smax(a.w, b.w));

        
        
        [MethodImpl(IL)] public static float smax_exp(this float t, float a, float b) {
            var o = (f2(a - b, b - a) / t).exp();
            return f2(a, b).dot(o) / o.csum();
        }
        public static float2 smax_exp2(this float2 t, float2 a, float2 b) => f2(t.x.smax_exp(a.x, b.x), t.y.smax_exp(a.y, b.y));
        public static float2 smax_expOP(this float2 t, float2 a, float2 b) => FunctionPointers.FP_smax_exp.InvokeParallelAndParam(a, b, t);
        public static float3 smax_exp(this float3 t, float3 a, float3 b) => f3(t.x.smax_exp(a.x, b.x), t.y.smax_exp(a.y, b.y), t.z.smax_exp(a.z, b.z));
        public static float4 smax_exp(this float4 t, float4 a, float4 b) => f4(t.x.smax_exp(a.x, b.x), t.y.smax_exp(a.y, b.y), t.z.smax_exp(a.z, b.z), t.w.smax_exp(a.w, b.w));
        
        #endregion

        // Smooth Min Functions https://iquilezles.org/articles/smin/
        /// exponential smooth min (t=32)
        [MethodImpl(IL)] public static  float smin_exp(this float t, float a, float b) {
            var res = (-t * a).exp2() + (-t * b).exp2();
            return -res.log2() / t;
        }
        public static float2 smin_exp(this float2 t, float2 a, float2 b) => f2(t.x.smin_exp(a.x, b.x), t.y.smin_exp(a.y, b.y));
        public static float3 smin_exp(this float3 t, float3 a, float3 b) => f3(t.x.smin_exp(a.x, b.x), t.y.smin_exp(a.y, b.y), t.z.smin_exp(a.z, b.z));
        public static float4 smin_exp(this float4 t, float4 a, float4 b) => f4(t.x.smin_exp(a.x, b.x), t.y.smin_exp(a.y, b.y), t.z.smin_exp(a.z, b.z), t.w.smin_exp(a.w, b.w));

        /// power smooth min (t=8)
        [MethodImpl(IL)] public static  float smin_pow(this float t, float a, float b) {
            a = a.pow(t);
            b = b.pow(t);
            return (a * b / (a + b)).pow(t.rcp());
        }
        public static float2 smin_pow(this float2 t, float2 a, float2 b) => f2(t.x.smin_pow(a.x, b.x), t.y.smin_pow(a.y, b.y));
        public static float3 smin_pow(this float3 t, float3 a, float3 b) => f3(t.x.smin_pow(a.x, b.x), t.y.smin_pow(a.y, b.y), t.z.smin_pow(a.z, b.z));
        public static float4 smin_pow(this float4 t, float4 a, float4 b) => f4(t.x.smin_pow(a.x, b.x), t.y.smin_pow(a.y, b.y), t.z.smin_pow(a.z, b.z), t.w.smin_pow(a.w, b.w));

        /// root smooth min (t=0.01)
        [MethodImpl(IL)] public static  float smin_root(this float t, float a, float b) {
            var h = a - b;
            return 0.5f * (a + b - (h * h + t).sqrt());
        }
        public static float2 smin_root(this float2 t, float2 a, float2 b) => f2(t.x.smin_root(a.x, b.x), t.y.smin_root(a.y, b.y));
        public static float3 smin_root(this float3 t, float3 a, float3 b) => f3(t.x.smin_root(a.x, b.x), t.y.smin_root(a.y, b.y), t.z.smin_root(a.z, b.z));
        public static float4 smin_root(this float4 t, float4 a, float4 b) => f4(t.x.smin_root(a.x, b.x), t.y.smin_root(a.y, b.y), t.z.smin_root(a.z, b.z), t.w.smin_root(a.w, b.w));

        /// polynomial smooth min 1 (t=0.1)
        [MethodImpl(IL)] public static  float smin_polynomial(this float t, float a, float b) {
            var h = (0.5f + (b - a) / (t * 2)).sat();
            return b.lerp(a, h) - t * h * (1 - h);
        }
        public static float2 smin_polynomial(this float2 t, float2 a, float2 b) => f2(t.x.smin_polynomial(a.x, b.x), t.y.smin_polynomial(a.y, b.y));
        public static float3 smin_polynomial(this float3 t, float3 a, float3 b) => f3(t.x.smin_polynomial(a.x, b.x), t.y.smin_polynomial(a.y, b.y), t.z.smin_polynomial(a.z, b.z));
        public static float4 smin_polynomial(this float4 t, float4 a, float4 b) => f4(t.x.smin_polynomial(a.x, b.x), t.y.smin_polynomial(a.y, b.y), t.z.smin_polynomial(a.z, b.z), t.w.smin_polynomial(a.w, b.w));

        /// polynomial smooth min 2 (t=0.1) - this is the one used in the paper
        [MethodImpl(IL)] public static  float smin_quadratic(this float t, float a, float b) {
            var h = (t - (a - b).abs()).limp() / t;
            return a.min(b) - h * h * t * 0.25f;
        }
        public static float2 smin_quadratic(this float2 t, float2 a, float2 b) => f2(t.x.smin_quadratic(a.x, b.x), t.y.smin_quadratic(a.y, b.y));
        public static float3 smin_quadratic(this float3 t, float3 a, float3 b) => f3(t.x.smin_quadratic(a.x, b.x), t.y.smin_quadratic(a.y, b.y), t.z.smin_quadratic(a.z, b.z));
        public static float4 smin_quadratic(this float4 t, float4 a, float4 b) => f4(t.x.smin_quadratic(a.x, b.x), t.y.smin_quadratic(a.y, b.y), t.z.smin_quadratic(a.z, b.z), t.w.smin_quadratic(a.w, b.w));
        
        /// polynomial smooth min
        /// As noted by ShaderToy user TinyTexel, this can be generalized to higher levels of continuity than
        /// the quadratic polynomial offers (C1), which might be important for preventing lighting artifacts.
        /// Moving on to a cubic curve gives us C2 continuity, and doesn't get a lot more expensive
        /// than the quadratic one anyways
        [MethodImpl(IL)] public static  float smin_cubic(this float t, float a, float b) {
            var h = (t - (a - b).abs()).limp() / t;
            return a.min(b) - h.cube() * t * (1 / 6f);
        }
        public static float2 smin_cubic(this float2 t, float2 a, float2 b) => f2(t.x.smin_cubic(a.x, b.x), t.y.smin_cubic(a.y, b.y));
        public static float3 smin_cubic(this float3 t, float3 a, float3 b) => f3(t.x.smin_cubic(a.x, b.x), t.y.smin_cubic(a.y, b.y), t.z.smin_cubic(a.z, b.z));
        public static float4 smin_cubic(this float4 t, float4 a, float4 b) => f4(t.x.smin_cubic(a.x, b.x), t.y.smin_cubic(a.y, b.y), t.z.smin_cubic(a.z, b.z), t.w.smin_cubic(a.w, b.w));
        
        /// Transition Factor
        /// Besides smoothly blending values, it might be useful to compute also a blending factor that can be used for shading. For example, if the smooth-minimum is being used to blend SDF shapes, having a blend factor could be useful to blend the material properties of the two shapes during the transition area. For example, the image below shows the mix of a red and a blue materials based on this mix factor as computed by the code below, which returns the smooth-minimum in .x and the blend factor in .y:
        [MethodImpl(IL)] public static  float smin_factor(this float t, float a, float b, out float factor) {
            var h = (t - (a - b).abs()).limp() / t;
            var m = h * h * 0.5f;
            var s = m * t * 0.5f;
            if (a < b) {
                factor = m;
                return a - s;
            }
            factor = m.inv();
            return b - s;
        }
        public static float2 smin_factor(this float2 t, float2 a, float2 b, out float2 factor) => f2(t.x.smin_factor(a.x, b.x, out factor.x), t.y.smin_factor(a.y, b.y, out factor.y));
        public static float3 smin_factor(this float3 t, float3 a, float3 b, out float3 factor) => f3(t.x.smin_factor(a.x, b.x, out factor.x), t.y.smin_factor(a.y, b.y, out factor.y), t.z.smin_factor(a.z, b.z, out factor.z));
        public static float4 smin_factor(this float4 t, float4 a, float4 b, out float4 factor) => f4(t.x.smin_factor(a.x, b.x, out factor.x), t.y.smin_factor(a.y, b.y, out factor.y), t.z.smin_factor(a.z, b.z, out factor.z), t.w.smin_factor(a.w, b.w, out factor.w));

        [MethodImpl(IL)] public static  float smin_cubic_factor(this float t, float a, float b, out float factor) {
            var h = (t - (a - b).abs()).limp() / t;
            var m = h * h * h * 0.5f;
            var s = m * t * (1 / 3f);
            if (a < b) {
                factor = m;
                return a - s;
            }
            factor = m.inv();
            return b - s;
        }
        public static float2 smin_cubic_factor(this float2 t, float2 a, float2 b, out float2 factor) => f2(t.x.smin_cubic_factor(a.x, b.x, out factor.x), t.y.smin_cubic_factor(a.y, b.y, out factor.y));
        public static float3 smin_cubic_factor(this float3 t, float3 a, float3 b, out float3 factor) => f3(t.x.smin_cubic_factor(a.x, b.x, out factor.x), t.y.smin_cubic_factor(a.y, b.y, out factor.y), t.z.smin_cubic_factor(a.z, b.z, out factor.z));
        public static float4 smin_cubic_factor(this float4 t, float4 a, float4 b, out float4 factor) => f4(t.x.smin_cubic_factor(a.x, b.x, out factor.x), t.y.smin_cubic_factor(a.y, b.y, out factor.y), t.z.smin_cubic_factor(a.z, b.z, out factor.z), t.w.smin_cubic_factor(a.w, b.w, out factor.w));
            
        
        /// Smin generalization to any power limn
        [MethodImpl(IL)] public static  float smin_N_factor(this float t, float a, float b, float n, out float factor) {
            var h = (t - (a - b).abs()).limp() / t;
            var m = h.pow(n) * 0.5f;
            var s = m * t / n;
            if (a < b) {
                factor = m;
                return a - s;
            }
            factor = m.inv();
            return b - s;
        }
        public static float2 smin_N_factor(this float2 t, float2 a, float2 b, float2 n, out float2 factor) => f2(t.x.smin_N_factor(a.x, b.x, n.x, out factor.x), t.y.smin_N_factor(a.y, b.y, n.y, out factor.y));
        public static float3 smin_N_factor(this float3 t, float3 a, float3 b, float3 n, out float3 factor) => f3(t.x.smin_N_factor(a.x, b.x, n.x, out factor.x), t.y.smin_N_factor(a.y, b.y, n.y, out factor.y), t.z.smin_N_factor(a.z, b.z, n.z, out factor.z));
        public static float4 smin_N_factor(this float4 t, float4 a, float4 b, float4 n, out float4 factor) => f4(t.x.smin_N_factor(a.x, b.x, n.x, out factor.x), t.y.smin_N_factor(a.y, b.y, n.y, out factor.y), t.z.smin_N_factor(a.z, b.z, n.z, out factor.z), t.w.smin_N_factor(a.w, b.w, n.w, out factor.w));

        #region mix
        // <summary>Returns (1-t)*a + t*b.</summary>
        [MethodImpl(IL)] public static float4 mix(float4 a, float4 b, float4 t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float4 mix(float4 a, float4 b, float t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3 mix(float3 a, float3 b, float3 t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float3 mix(float3 a, float3 b, float t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 mix(float2 a, float2 b, float2 t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float2 mix(float2 a, float2 b, float t) => math.mad(t,b,math.mad(-t,a,a));
        /// <inheritdoc cref="mix(float4,float4,float4)" />
        [MethodImpl(IL)] public static float mix(float a, float b, float t) => math.mad(t,b,math.mad(-t,a,a));
        #endregion

        #region smoothstart
        // <summary>Returns a smoother version of the value at the start.</summary>
        [MethodImpl(IL)] public static float4 smoothstart(float4 t, int n) => pow(t,n);
        /// <inheritdoc cref="smoothstart(float4,int)" />
        [MethodImpl(IL)] public static float3 smoothstart(float3 t, int n) => pow(t,n);
        /// <inheritdoc cref="smoothstart(float4,int)" />
        [MethodImpl(IL)] public static float2 smoothstart(float2 t, int n) => pow(t,n);
        /// <inheritdoc cref="smoothstart(float4,int)" />
        [MethodImpl(IL)] public static float smoothstart(float t, int n) => pow(t,n);
        #endregion

        #region smoothstop
        // <summary>Returns a smoother version of the value at the end.</summary>
        [MethodImpl(IL)] public static float4 smoothstop(float4 t, int n) => inv(pow(inv(t), n));
        /// <inheritdoc cref="smoothstop(float4,int)" />
        [MethodImpl(IL)] public static float3 smoothstop(float3 t, int n) => inv(pow(inv(t), n));
        /// <inheritdoc cref="smoothstop(float4,int)" />
        [MethodImpl(IL)] public static float2 smoothstop(float2 t, int n) => inv(pow(inv(t), n));
        /// <inheritdoc cref="smoothstop(float4,int)" />
        [MethodImpl(IL)] public static float smoothstop(float t, int n) => inv(pow(inv(t), n));
        #endregion

        #region xfade (crossfade)
        // <summary>Fades between values a and b.</summary>
        [MethodImpl(IL)] public static float4 xfade(float4 a, float4 b, float4 t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float4 xfade(float4 a, float4 b, float t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float3 xfade(float3 a, float3 b, float3 t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float3 xfade(float3 a, float3 b, float t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float2 xfade(float2 a, float2 b, float2 t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float2 xfade(float2 a, float2 b, float t) => math.mad(b-a,t,a);
        /// <inheritdoc cref="xfade(float4,float4,float)" />
        [MethodImpl(IL)] public static float xfade(float a, float b, float t) => math.mad(b-a,t,a);
        #endregion
    }
}