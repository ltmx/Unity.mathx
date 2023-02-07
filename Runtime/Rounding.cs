using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class Math
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
        
        // Round To Int --------------------------------------------------
        
        /// Round to int
        public static int4 rint(this float4 f) => f.round().asint();
        /// Round to int
        public static int3 rint(this float3 f) => f.round().asint();
        /// Round to int
        public static int2 rint(this float2 f) => f.round().asint();
        /// Round to int
        public static int rint(this float f) => f.round().asint();
        
        
        public static int4 rint(this Vector4 f) => f.round().asint();
        /// Round to int
        public static int3 rint(this Vector3 f) => f.round().asint();
        /// Round to int
        public static int2 rint(this Vector2 f) => f.round().asint();
        /// Round to int
        public static int4 rint(this double4 f) => f.round().asint();
        /// Round to int
        public static int3 rint(this double3 f) => f.round().asint();
        /// Round to int
        public static int2 rint(this double2 f) => f.round().asint();
        /// Round to int
        public static int rint(this double f) => f.round().asint();

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
        public static float4 min(this float4 f, float4 min) => math.min(f, min);
        public static float3 min(this float3 f, float3 min) => math.min(f, min);
        public static float2 min(this float2 f, float2 min) => math.min(f, min);
        public static float min(this float f, float min) => math.min(f, min);
        public static float min(this int f, float min) => math.min(f, min);
        public static int min(this int f, int min) => math.min(f, min);
        
        public static float4 min(this Vector4 f, float4 min) => math.min(f, min);
        public static float3 min(this Vector3 f, float3 min) => math.min(f, min);
        public static float2 min(this Vector2 f, float2 min) => math.min(f, min);
        
        public static double4 min(this double4 f, double4 min) => math.min(f, min);
        public static double3 min(this double3 f, double3 min) => math.min(f, min);
        public static double2 min(this double2 f, double2 min) => math.min(f, min);
        public static double min(this double f, double min) => math.min(f, min);

        // Maximum
        public static float4 max(this float4 f, float4 max) => math.max(f, max);
        public static float3 max(this float3 f, float3 max) => math.max(f, max);
        public static float2 max(this float2 f, float2 max) => math.max(f, max);
        public static float max(this float f, float max) => math.max(f, max);
        public static float max(this int f, float max) => math.max(f, max);
        public static int max(this int f, int max) => math.max(f, max);

        public static float4 max(this Vector4 f, float4 max) => math.max(f, max);
        public static float3 max(this Vector3 f, float3 max) => math.max(f, max);
        public static float2 max(this Vector2 f, float2 max) => math.max(f, max);
        
        public static double4 max(this double4 f, double4 max) => math.max(f, max);
        public static double3 max(this double3 f, double3 max) => math.max(f, max);
        public static double2 max(this double2 f, double2 max) => math.max(f, max);
        public static double max(this double f, double max) => math.max(f, max);

        // Ceiling
        public static float4 ceil(this float4 f) => math.ceil(f);
        public static float3 ceil(this float3 f) => math.ceil(f);
        public static float2 ceil(this float2 f) => math.ceil(f);
        public static float ceil(this float f) => math.ceil(f);
        
        public static float4 ceil(this Vector4 f) => math.ceil(f);
        public static float3 ceil(this Vector3 f) => math.ceil(f);
        public static float2 ceil(this Vector2 f) => math.ceil(f);
        
        public static double4 ceil(this double4 f) => math.ceil(f);
        public static double3 ceil(this double3 f) => math.ceil(f);
        public static double2 ceil(this double2 f) => math.ceil(f);
        public static double ceil(this double f) => math.ceil(f);
        
        // Ceil To Int
        public static int4 clint(this float4 f) => math.ceil(f).asint();
        public static int3 clint(this float3 f) => math.ceil(f).asint();
        public static int2 clint(this float2 f) => math.ceil(f).asint();
        public static int clint(this float f) => math.ceil(f).asint();
        
        public static int4 clint(this Vector4 f) => math.ceil(f).asint();
        public static int3 clint(this Vector3 f) => math.ceil(f).asint();
        public static int2 clint(this Vector2 f) => math.ceil(f).asint();
        
        public static int4 clint(this double4 f) => math.ceil(f).asint();
        public static int3 clint(this double3 f) => math.ceil(f).asint();
        public static int2 clint(this double2 f) => math.ceil(f).asint();
        public static int clint(this double f) => math.ceil(f).asint();
        

        // Floor
        public static float4 floor(this float4 f) => math.floor(f);
        public static float3 floor(this float3 f) => math.floor(f);
        public static float2 floor(this float2 f) => math.floor(f);
        public static float floor(this float f) => math.floor(f);

        public static float4 floor(this Vector4 f) => math.floor(f);
        public static float3 floor(this Vector3 f) => math.floor(f);
        public static float2 floor(this Vector2 f) => math.floor(f);
        
        public static double4 floor(this double4 f) => math.floor(f);
        public static double3 floor(this double3 f) => math.floor(f);
        public static double2 floor(this double2 f) => math.floor(f);
        public static double floor(this double f) => math.floor(f);
        
        // Floor To Int
        public static int4 flint(this float4 f) => f.asint();
        public static int3 flint(this float3 f) => f.asint();
        public static int2 flint(this float2 f) => f.asint();
        public static int flint(this float f) => f.asint();
        
        public static int4 flint(this Vector4 f) => f.asint();
        public static int3 flint(this Vector3 f) => f.asint();
        public static int2 flint(this Vector2 f) => f.asint();
        
        public static int4 flint(this double4 f) => f.asint();
        public static int3 flint(this double3 f) => f.asint();
        public static int2 flint(this double2 f) => f.asint();
        public static int flint(this double f) => f.asint();
        
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

        // npsaturate
        
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
        
        
        // Max0
        
        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        public static float4 max0(this float4 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float3 max0(this float3 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float2 max0(this float2 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float max0(this float f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float max0(this int f) => f.max(0);
        
        /// <inheritdoc cref="max0(float4)"/>
        public static float4 max0(this Vector4 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float3 max0(this Vector3 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static float2 max0(this Vector2 f) => f.max(0);
        
        /// <inheritdoc cref="max0(float4)"/>
        public static double4 max0(this double4 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static double3 max0(this double3 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static double2 max0(this double2 f) => f.max(0);
        /// <inheritdoc cref="max0(float4)"/>
        public static double max0(this double f) => f.max(0);
        
        
        
        //Min0
        
        /// Short for min(f, 0);
        public static float4 min0(this float4 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float3 min0(this float3 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float2 min0(this float2 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float min0(this float f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float min0(this int f) => f.min(0);
        
        /// <inheritdoc cref="min0(float4)"/>
        public static float4 min0(this Vector4 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float3 min0(this Vector3 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static float2 min0(this Vector2 f) => f.min(0);
        
        /// <inheritdoc cref="min0(float4)"/>
        public static double4 min0(this double4 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static double3 min0(this double3 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static double2 min0(this double2 f) => f.min(0);
        /// <inheritdoc cref="min0(float4)"/>
        public static double min0(this double f) => f.min(0);

    }
}