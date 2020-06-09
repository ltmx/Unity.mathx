using Unity.Mathematics;
using UnityEngine;

namespace LTMX
{
    public partial class UnityMathematicsExtensions
    {
        // Rounding --------------------------------------------------
        
        // Round
        
        public static float4 round(this float4 f) => math.round(f);
        public static float3 round(this float3 f) => math.round(f);
        public static float2 round(this float2 f) => math.round(f);
        public static float round(this float f) => math.round(f);
        
        public static float4 round(this Vector4 f) => math.round(f);
        public static float3 round(this Vector3 f) => math.round(f);
        public static float2 round(this Vector2 f) => math.round(f);
        
        public static double4 round(this double4 f) => math.round(f);
        public static double3 round(this double3 f) => math.round(f);
        public static double2 round(this double2 f) => math.round(f);
        public static double round(this double f) => math.round(f);
        
        // Clamp
        public static float4 clamp(this float4 f, float4 min, float4 max) => math.clamp(f, min, max);
        public static float3 clamp(this float3 f, float3 min, float3 max) => math.clamp(f, min, max);
        public static float2 clamp(this float2 f, float2 min, float2 max) => math.clamp(f, min, max);
        public static float clamp(this float f, float min, float max) => math.clamp(f, min, max);
        public static float clamp(this int f, float min, float max) => math.clamp(f, min, max);
        public static int clamp(this int f, int min, int max) => math.clamp(f, min, max);
        
        public static float4 min(this Vector4 f, float4 min, float4 max) => math.clamp(f, min, max);
        public static float3 min(this Vector3 f, float3 min, float3 max) => math.clamp(f, min, max);
        public static float2 min(this Vector2 f, float2 min, float2 max) => math.clamp(f, min, max);
        
        public static double4 clamp(this double4 f, double4 min, double4 max) => math.clamp(f, min, max);
        public static double3 clamp(this double3 f, double3 min, double3 max) => math.clamp(f, min, max);
        public static double2 clamp(this double2 f, double2 min, double2 max) => math.clamp(f, min, max);
        public static double clamp(this double f, double min, double max) => math.clamp(f, min, max);

        
        // Minimum
        
        public static float4 min(this float4 f, float4 m) => math.min(f, m);
        public static float3 min(this float3 f, float3 m) => math.min(f, m);
        public static float2 min(this float2 f, float2 m) => math.min(f, m);
        public static float min(this float f, float m) => math.min(f, m);
        public static float min(this int f, float m) => math.min(f, m);
        public static int min(this int f, int m) => math.min(f, m);
        
        public static float4 min(this Vector4 f, float4 m) => math.min(f, m);
        public static float3 min(this Vector3 f, float3 m) => math.min(f, m);
        public static float2 min(this Vector2 f, float2 m) => math.min(f, m);
        
        public static double4 min(this double4 f, double4 m) => math.min(f, m);
        public static double3 min(this double3 f, double3 m) => math.min(f, m);
        public static double2 min(this double2 f, double2 m) => math.min(f, m);
        public static double min(this double f, double m) => math.min(f, m);
        
        // Maximum

        public static float4 max(this float4 f, float4 m) => math.max(f, m);
        public static float3 max(this float3 f, float3 m) => math.max(f, m);
        public static float2 max(this float2 f, float2 m) => math.max(f, m);
        public static float max(this float f, float m) => math.max(f, m);
        public static float max(this int f, float m) => math.max(f, m);
        public static int max(this int f, int m) => math.max(f, m);

        public static float4 max(this Vector4 f, float4 m) => math.max(f, m);
        public static float3 max(this Vector3 f, float3 m) => math.max(f, m);
        public static float2 max(this Vector2 f, float2 m) => math.max(f, m);
        
        public static double4 max(this double4 f, double4 m) => math.max(f, m);
        public static double3 max(this double3 f, double3 m) => math.max(f, m);
        public static double2 max(this double2 f, double2 m) => math.max(f, m);
        public static double max(this double f, double m) => math.max(f, m);
        
        // Ceiling
        public static float4 ceil(this float4 f) => math.ceil(f);
        public static float3 ceil(this float3 f) => math.ceil(f);
        public static float2 ceil(this float2 f) => math.ceil(f);
        public static float ceil(this float f) => math.ceil(f);
        public static int ceil(this int f) => (int)math.ceil(f);
        
        public static float4 ceil(this Vector4 f) => math.ceil(f);
        public static float3 ceil(this Vector3 f) => math.ceil(f);
        public static float2 ceil(this Vector2 f) => math.ceil(f);
        
        public static double4 ceil(this double4 f) => math.ceil(f);
        public static double3 ceil(this double3 f) => math.ceil(f);
        public static double2 ceil(this double2 f) => math.ceil(f);
        public static double ceil(this double f) => math.ceil(f);
        
        // Floor
        public static float4 floor(this float4 f) => math.floor(f);
        public static float3 floor(this float3 f) => math.floor(f);
        public static float2 floor(this float2 f) => math.floor(f);
        public static float floor(this float f) => math.floor(f);
        public static int floor(this int f) => (int)math.floor(f);
        
        public static float4 floor(this Vector4 f) => math.floor(f);
        public static float3 floor(this Vector3 f) => math.floor(f);
        public static float2 floor(this Vector2 f) => math.floor(f);
        
        public static double4 floor(this double4 f) => math.floor(f);
        public static double3 floor(this double3 f) => math.floor(f);
        public static double2 floor(this double2 f) => math.floor(f);
        public static double floor(this double f) => math.floor(f);
        
        // Saturate
        /// Returns the result of clamping f to [0, 1]
        public static float4 saturate(this float4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float3 saturate(this float3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float2 saturate(this float2 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float saturate(this float f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float saturate(this int f) => math.saturate(f);
        
        /// <inheritdoc cref="saturate(float4)"/>
        public static float4 saturate(this Vector4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float3 saturate(this Vector3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static float2 saturate(this Vector2 f) => math.saturate(f);
        
        /// <inheritdoc cref="saturate(float4)"/>
        public static double4 saturate(this double4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static double3 saturate(this double3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static double2 saturate(this double2 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float4)"/>
        public static double saturate(this double f) => math.saturate(f);
        
        /// Returns the result of clamping f to [-1, 1]
        public static float4 npsaturate(this float4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float3 npsaturate(this float3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float2 npsaturate(this float2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float npsaturate(this float f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float npsaturate(this int f) => f.clamp(-1,1);
        
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float4 npsaturate(this Vector4 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float3 npsaturate(this Vector3 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static float2 npsaturate(this Vector2 f) => clamp(f, -1,1);
        
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static double4 npsaturate(this double4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static double3 npsaturate(this double3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static double2 npsaturate(this double2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        public static double npsaturate(this double f) => f.clamp(-1,1);
        
    }
}