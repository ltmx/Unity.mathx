using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static partial class UnityMathematicsExtensions
    {
        // https://github.com/FreyaHolmer/Mathfs/blob/master/Mathfs.cs
        
        public static float4 smootherstep(this float4 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float3 smootherstep(this float3 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float2 smootherstep(this float2 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float smootherstep(this float f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();

        public static float4 smoothstepcos(this float4 f) => (f.saturate() * PI).cos().onem() * 0.5f;
        public static float3 smoothstepcos(this float3 f) => (f.saturate() * PI).cos().onem() * 0.5f;
        public static float2 smoothstepcos(this float2 f) => (f.saturate() * PI).cos().onem() * 0.5f;
        public static float smoothstepcos(this float f) => (f.saturate() * PI).cos().onem() * 0.5f;

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
        public static float smoothstep(this float f, float min = 0, float max = 1) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double smoothstep(this double f, double min = 0.0, double max = 1.0) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float4 smoothstep(this float4 f, float4 min, float4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float3 smoothstep(this float3 f, float3 min, float3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float2 smoothstep(this float2 f, float2 min, float2 max) => math.smoothstep(min, max, f);
        
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float4 smoothstep(this Vector4 f, float4 min, float4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float3 smoothstep(this Vector3 f, float3 min, float3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float2 smoothstep(this Vector2 f, float2 min, float2 max) => math.smoothstep(min, max, f);
        
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double4 smoothstep(this double4 f, double4 min, double4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double3 smoothstep(this double3 f, double3 min, double3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double2 smoothstep(this double2 f, double2 min, double2 max) => math.smoothstep(min, max, f);
        
        
        
        /// Returns the result of normalizing a floating point value x to a range [min, max]. The opposite of lerp. Equivalent to (x - min) / (max - min).
        public static float unlerp(this float f, float min = 0, float max = 1) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static double unlerp(this double f, double min = 0.0, double max = 1.0) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float4 unlerp(this float4 f, float4 min, float4 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float3 unlerp(this float3 f, float3 min, float3 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float2 unlerp(this float2 f, float2 min, float2 max) => math.unlerp(min, max, f);
        
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float4 unlerp(this Vector4 f, float4 min, float4 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float3 unlerp(this Vector3 f, float3 min, float3 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static float2 unlerp(this Vector2 f, float2 min, float2 max) => math.unlerp(min, max, f);
        
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double4 unlerp(this double4 f, double4 min, double4 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static double3 unlerp(this double3 f, double3 min, double3 max) => math.unlerp(min, max, f);
        /// <inheritdoc cref="unlerp(float,float,float)"/>
        public static double2 unlerp(this double2 f, double2 min, double2 max) => math.unlerp(min, max, f);
    }
}
