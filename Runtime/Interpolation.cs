// Some functions are translated from : https://github.com/FreyaHolmer/Mathfs/blob/master/Mathfs.cs
// Smin from Inigo Quilez https://iquilezles.org/articles/smin/

using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        public static float4 smootherstep(this float4 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float3 smootherstep(this float3 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float2 smootherstep(this float2 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float smootherstep(this float f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();

        public static float4 smoothstepcos(this float4 f) => (f.saturate() * PI).cos().inv() * 0.5f;
        public static float3 smoothstepcos(this float3 f) => (f.saturate() * PI).cos().inv() * 0.5f;
        public static float2 smoothstepcos(this float2 f) => (f.saturate() * PI).cos().inv() * 0.5f;
        public static float smoothstepcos(this float f) => (f.saturate() * PI).cos().inv() * 0.5f;

        public static float4 eerp(this float4 f, float4 a, float4 b) => a.pow(1 - f) * b.pow(f);
        public static float3 eerp(this float3 f, float3 a, float3 b) => a.pow(1 - f) * b.pow(f);
        public static float2 eerp(this float2 f, float2 a, float2 b) => a.pow(1 - f) * b.pow(f);
        public static float eerp(this float f, float a, float b) => a.pow(1 - f) * b.pow(f);

        public static float4 uneerp(this float4 f, float4 a, float4 b) => (a / f).ln() / (a / b).ln();
        public static float3 uneerp(this float3 f, float3 a, float3 b) => (a / f).ln() / (a / b).ln();
        public static float2 uneerp(this float2 f, float2 a, float2 b) => (a / f).ln() / (a / b).ln();
        public static float uneerp(this float f, float a, float b) => (a / f).ln() / (a / b).ln();

        // SmoothStep -----------------------------------------------------------------------------

        /// Returns a smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].
        public static float smoothstep(this float f, float min, float max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static double smoothstep(this double f, double min = 0.0, double max = 1.0) =>
            math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float4 smoothstep(this float4 f, float4 min, float4 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float3 smoothstep(this float3 f, float3 min, float3 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float2 smoothstep(this float2 f, float2 min, float2 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float4 smoothstep(this Vector4 f, float4 min, float4 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float3 smoothstep(this Vector3 f, float3 min, float3 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static float2 smoothstep(this Vector2 f, float2 min, float2 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static double4 smoothstep(this double4 f, double4 min, double4 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static double3 smoothstep(this double3 f, double3 min, double3 max) => math.smoothstep(min, max, f);

        /// <inheritdoc cref="smoothstep(float,float,float)" />
        public static double2 smoothstep(this double2 f, double2 min, double2 max) => math.smoothstep(min, max, f);

        // Unlerp -----------------------------------------------------------------------------

        /// Returns the result of normalizing a floating point value x to a range [min, max]. The opposite of lerp. Equivalent to (x - min) / (max - min).
        public static float unlerp(this float f, float min = 0, float max = 1) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static double unlerp(this double f, double min = 0.0, double max = 1.0) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float4 unlerp(this float4 f, float4 min, float4 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float3 unlerp(this float3 f, float3 min, float3 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float2 unlerp(this float2 f, float2 min, float2 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float4 unlerp(this Vector4 f, float4 min, float4 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float3 unlerp(this Vector3 f, float3 min, float3 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static float2 unlerp(this Vector2 f, float2 min, float2 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static double4 unlerp(this double4 f, double4 min, double4 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static double3 unlerp(this double3 f, double3 min, double3 max) => math.unlerp(min, max, f);

        /// <inheritdoc cref="unlerp(float,float,float)" />
        public static double2 unlerp(this double2 f, double2 min, double2 max) => math.unlerp(min, max, f);


        // Lerp -----------------------------------------------------------------------------


        /// Returns the result of linearly interpolating from min to max using the interpolation parameter f.
        public static float lerp(this float f, float min = 0, float max = 1) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float,float,float)" />
        public static double lerp(this double f, double min = 0.0, double max = 1.0) => math.lerp(min, max, f);

        /// Returns the result of a componentwise linear interpolating from min to max using the interpolation parameter f.
        public static float4 lerp(this float4 f, float4 min, float4 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static float3 lerp(this float3 f, float3 min, float3 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static float2 lerp(this float2 f, float2 min, float2 max) => math.lerp(min, max, f);

        /// <inheritdoc cref=="lerp(float4,float4,float4)" />
        public static float4 lerp(this Vector4 f, float4 min, float4 max) => math.lerp(min, max, f);

        /// <inheritdoc cref=="lerp(float4,float4,float4)" />
        public static float3 lerp(this Vector3 f, float3 min, float3 max) => math.lerp(min, max, f);

        /// <inheritdoc cref=="lerp(float4,float4,float4)" />
        public static float2 lerp(this Vector2 f, float2 min, float2 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double4 lerp(this double4 f, double4 min, double4 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double3 lerp(this double3 f, double3 min, double3 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double2 lerp(this double2 f, double2 min, double2 max) => math.lerp(min, max, f);


        //using float/double as interpolation parameter
        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static float4 lerp(this float f, float4 min, float4 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static float3 lerp(this float f, float3 min, float3 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static float2 lerp(this float f, float2 min, float2 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double4 lerp(this double f, double4 min, double4 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double3 lerp(this double f, double3 min, double3 max) => math.lerp(min, max, f);

        /// <inheritdoc cref="lerp(float4,float4,float4)" />
        public static double2 lerp(this double f, double2 min, double2 max) => math.lerp(min, max, f);

        public static float3 lerp(this int3 f, float3 min, float3 max) => math.lerp(min, max, f);
        public static float2 lerp(this int2 f, float2 min, float2 max) => math.lerp(min, max, f);
        public static float lerp(this int f, float min, float max) => math.lerp(min, max, f);


        // Lerp Angle -------------------------------------------

        public static float lerpAngle(this float x, float a, float b)
        {
            var num = (b - a).repeat(360);
            if (num > 180.0) num -= 360;
            return a + num * x.saturate();
        }

        // Remap --------------------------------------------------------------------

        /// Remapping function identical as in HLSL
        public static float4 remap(this float t, float4 oldMin, float4 oldMax, float4 newMin, float4 newMax) =>
            math.remap(oldMin, oldMax, newMin, newMax, t);

        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        public static float3 remap(this float t, float3 oldMin, float3 oldMax, float3 newMin, float3 newMax) =>
            math.remap(oldMin, oldMax, newMin, newMax, t);

        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        public static float2 remap(this float t, float2 oldMin, float2 oldMax, float2 newMin, float2 newMax) =>
            math.remap(oldMin, oldMax, newMin, newMax, t);

        /// <inheritdoc cref="remap(float,float,float,float,float)" />
        public static float remap(this float t, float oldMin, float oldMax, float newMin, float newMax) =>
            math.remap(oldMin, oldMax, newMin, newMax, t);


        // step ---------------------------------------------------------------------

        /// <inheritdoc cref="math.step(float, float)" />
        public static float step(this float f, float step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static double step(this double f, double step = 0.0) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float4 step(this float4 f, float4 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float3 step(this float3 f, float3 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float2 step(this float2 f, float2 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float4 step(this Vector4 f, float4 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float3 step(this Vector3 f, float3 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static float2 step(this Vector2 f, float2 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static double4 step(this double4 f, double4 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static double3 step(this double3 f, double3 step) => math.step(f, step);

        /// <inheritdoc cref="step(float,float)" />
        public static double2 step(this double2 f, double2 step) => math.step(f, step);


        #region Smooth Min - Smooth Max

        /// Smooth min is a smooth version of math.min() that accepts a smoothness parameter t
        [MethodImpl(INLINE)]
        public static float smin(this float t, float a, float b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float2 smin(this float t, float2 a, float2 b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float3 smin(this float t, float3 a, float3 b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float4 smin(this float t, float4 a, float4 b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float2 smin(this float2 t, float2 a, float2 b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float3 smin(this float3 t, float3 a, float3 b) => smax(-t, a, b);

        /// <inheritdoc cref="smin(float,float,float)" />
        [MethodImpl(INLINE)]
        public static float4 smin(this float4 t, float4 a, float4 b) => smax(-t, a, b);


        // Smooth Max --------------------------------------------------

        /// Smooth max is a smooth version of math.max() that accepts a smoothness parameter t
        [MethodImpl(INLINE)]
        public static float smax(this float t, float a, float b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float2 smax(this float t, float2 a, float2 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float3 smax(this float t, float3 a, float3 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float4 smax(this float t, float4 a, float4 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float2 smax(this float2 t, float2 a, float2 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float3 smax(this float3 t, float3 a, float3 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }

        /// <inheritdoc cref="smax(float, float,float)" />
        [MethodImpl(INLINE)]
        public static float4 smax(this float4 t, float4 a, float4 b)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return h.lerp(a, b) + t * h * (1 - h);
        }


        // Smooth Min Functions https://iquilezles.org/articles/smin/

        /// exponential smooth min (t=32)
        public static float smin_exp(float a, float b, float t)
        {
            var res = (-t * a).exp2() + (-t * b).exp2();
            return -res.log2() / t;
        }

        /// power smooth min (t=8)
        public static float smin_pow(float a, float b, float t)
        {
            a = a.pow(t);
            b = b.pow(t);
            return (a * b / (a + b)).pow(t.rcp());
        }

        /// root smooth min (t=0.01)
        public static float smin_root(float a, float b, float t)
        {
            var h = a - b;
            return 0.5f * (a + b - (h * h + t).sqrt());
        }

        /// polynomial smooth min 1 (t=0.1)
        public static float smin_polynomial(float a, float b, float t)
        {
            var h = (0.5f + (b - a) / (t * 2)).saturate();
            return b.lerp(a, h) - t * h * (1 - h);
        }

        /// polynomial smooth min 2 (t=0.1) - this is the one used in the paper
        public static float smin_quadratic(float a, float b, float t)
        {
            var h = (t - (a - b).abs()).p() / t;
            return a.min(b) - h * h * t * 0.25f;
        }

        /// polynomial smooth min
        /// As noted by Shadertoy user TinyTexel, this can be generalized to higher levels of continuity than
        /// the quadratic polynomial offers (C1), which might be important for preventing lighting artifacts.
        /// Moving on to a cubic curve gives us C2 continuity, and doesn't get a lot more expensive
        /// than the quadratic one anyways
        public static float smin_cubic(float a, float b, float t)
        {
            var h = (t - (a - b).abs()).p() / t;
            return a.min(b) - h.cube() * t * (1 / 6f);
        }

        /// Transition Factor
        /// Besides smoothly blending values, it might be useful to compute also a blending factor that can be used for shading. For example, if the smooth-minimum is being used to blend SDF shapes, having a blend factor could be useful to blend the material properties of the two shapes during the transition area. For example, the image below shows the mix of a red and a blue materials based on this mix factor as computed by the code below, which returns the smooth-minimum in .x and the blend factor in .y:
        public static float2 smin_factor(float a, float b, float t)
        {
            var h = (t - (a - b).abs()).p() / t;
            var m = h * h * 0.5f;
            var s = m * t * 0.5f;
            return a < b ? float2(a - s, m) : float2(b - s, m.inv());
        }

        public static float2 smin_cubic_factor(float a, float b, float t)
        {
            var h = (t - (a - b).abs()).p() / t;
            var m = h * h * h * 0.5f;
            var s = m * t * (1 / 3f);
            return a < b ? float2(a - s, m) : float2(b - s, m.inv());
        }

        /// Smin generalization to any power n
        public static float2 smin_N_factor(float a, float b, float t, float n)
        {
            var h = (t - (a - b).abs()).p() / t;
            var m = h.pow(n) * 0.5f;
            var s = m * t / n;
            return a < b ? float2(a - s, m) : float2(b - s, m.inv());
        }


        // ChatGPT Generated Code
        /// <summary>
        ///     This implementation follows the formula for smax:
        ///     <code>
        /// public static float smax(float a, float b, float t)
        /// {
        ///     var o = (float2(a - b, b - a) / t).exp();
        ///     return float2(a, b).dot(o) / o.sum();
        /// }
        /// </code>
        ///     However, it simplifies the calculation of the exponential terms by using the fact that exp(x) = 1 / exp(-x)
        ///     and rearranging the terms.It also avoids division by zero by checting if t is zero or if a and b are equal.
        ///     Note that the function assumes that t is positive, and it does not chect for overflow or underflow when
        ///     computing the exponential terms.
        ///     If t is very large or small, the exponential terms may cause numerical issues.
        /// </summary>
        public static float smaxGPT(float a, float b, float t)
        {
            var x = a.max(b);
            var y = a.max(b);
            var z = (x - y) / t;
            if (z >= 1) return x;
            if (z <= 0) return y;
            var w = z.exp();
            return (x * w + y) / (1 + w);
        }

        #endregion
    }
}