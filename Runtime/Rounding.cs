using UnityEngine;
using m = Unity.Mathematics.math;
using f4 = Unity.Mathematics.float4;
using f3 = Unity.Mathematics.float3;
using f2 = Unity.Mathematics.float2;
using f1 = System.Single;


namespace Unity.Mathematics
{
    public static partial class Math
    {
        
    
        // Rounding --------------------------------------------------
        
        // Round
        public static f4 round(this f4 f) => m.round(f);
        public static f3 round(this f3 f) => m.round(f);
        public static f2 round(this f2 f) => m.round(f);
        public static f1 round(this f1 f) => m.round(f);
        
        public static f4 round(this Vector4 f) => m.round(f);
        public static f3 round(this Vector3 f) => m.round(f);
        public static f2 round(this Vector2 f) => m.round(f);
        
        public static double4 round(this double4 f) => m.round(f);
        public static double3 round(this double3 f) => m.round(f);
        public static double2 round(this double2 f) => m.round(f);
        public static double round(this double f) => m.round(f);
        
        // Round To Int
        public static int4 roundtoint(this f4 f) => f.round().asint();
        public static int3 roundtoint(this f3 f) => f.round().asint();
        public static int2 roundtoint(this f2 f) => f.round().asint();
        public static int roundtoint(this f1 f) => f.round().asint();
        
        public static int4 roundtoint(this Vector4 f) => f.round().asint();
        public static int3 roundtoint(this Vector3 f) => f.round().asint();
        public static int2 roundtoint(this Vector2 f) => f.round().asint();
        
        public static int4 roundtoint(this double4 f) => f.round().asint();
        public static int3 roundtoint(this double3 f) => f.round().asint();
        public static int2 roundtoint(this double2 f) => f.round().asint();
        public static int roundtoint(this double f) => f.round().asint();

        // Clamp
        public static f4 clamp(this f4 f, f4 min, f4 max) => m.clamp(f, min, max);
        public static f3 clamp(this f3 f, f3 min, f3 max) => m.clamp(f, min, max);
        public static f2 clamp(this f2 f, f2 min, f2 max) => m.clamp(f, min, max);
        public static f1 clamp(this f1 f, f1 min, f1 max) => m.clamp(f, min, max);
        public static f1 clamp(this int f, f1 min, f1 max) => m.clamp(f, min, max);
        public static int clamp(this int f, int min, int max) => m.clamp(f, min, max);
        
        public static f4 min(this Vector4 f, f4 min, f4 max) => m.clamp(f, min, max);
        public static f3 min(this Vector3 f, f3 min, f3 max) => m.clamp(f, min, max);
        public static f2 min(this Vector2 f, f2 min, f2 max) => m.clamp(f, min, max);
        
        public static double4 clamp(this double4 f, double4 min, double4 max) => m.clamp(f, min, max);
        public static double3 clamp(this double3 f, double3 min, double3 max) => m.clamp(f, min, max);
        public static double2 clamp(this double2 f, double2 min, double2 max) => m.clamp(f, min, max);
        public static double clamp(this double f, double min, double max) => m.clamp(f, min, max);


        // Minimum
        public static f4 min(this f4 f, f4 min) => m.min(f, min);
        public static f3 min(this f3 f, f3 min) => m.min(f, min);
        public static f2 min(this f2 f, f2 min) => m.min(f, min);
        public static f1 min(this f1 f, f1 min) => m.min(f, min);
        public static f1 min(this int f, f1 min) => m.min(f, min);
        public static int min(this int f, int min) => m.min(f, min);
        
        public static f4 min(this Vector4 f, f4 min) => m.min(f, min);
        public static f3 min(this Vector3 f, f3 min) => m.min(f, min);
        public static f2 min(this Vector2 f, f2 min) => m.min(f, min);
        
        public static double4 min(this double4 f, double4 min) => m.min(f, min);
        public static double3 min(this double3 f, double3 min) => m.min(f, min);
        public static double2 min(this double2 f, double2 min) => m.min(f, min);
        public static double min(this double f, double min) => m.min(f, min);

        // Maximum
        public static f4 max(this f4 f, f4 max) => m.max(f, max);
        public static f3 max(this f3 f, f3 max) => m.max(f, max);
        public static f2 max(this f2 f, f2 max) => m.max(f, max);
        public static f1 max(this f1 f, f1 max) => m.max(f, max);
        public static f1 max(this int f, f1 max) => m.max(f, max);
        public static int max(this int f, int max) => m.max(f, max);

        public static f4 max(this Vector4 f, f4 max) => m.max(f, max);
        public static f3 max(this Vector3 f, f3 max) => m.max(f, max);
        public static f2 max(this Vector2 f, f2 max) => m.max(f, max);
        
        public static double4 max(this double4 f, double4 max) => m.max(f, max);
        public static double3 max(this double3 f, double3 max) => m.max(f, max);
        public static double2 max(this double2 f, double2 max) => m.max(f, max);
        public static double max(this double f, double max) => m.max(f, max);

        // Ceiling
        public static f4 ceil(this f4 f) => m.ceil(f);
        public static f3 ceil(this f3 f) => m.ceil(f);
        public static f2 ceil(this f2 f) => m.ceil(f);
        public static f1 ceil(this f1 f) => m.ceil(f);
        
        public static f4 ceil(this Vector4 f) => m.ceil(f);
        public static f3 ceil(this Vector3 f) => m.ceil(f);
        public static f2 ceil(this Vector2 f) => m.ceil(f);
        
        public static double4 ceil(this double4 f) => m.ceil(f);
        public static double3 ceil(this double3 f) => m.ceil(f);
        public static double2 ceil(this double2 f) => m.ceil(f);
        public static double ceil(this double f) => m.ceil(f);
        
        // Ceil To Int
        public static int4 ceiltoint(this f4 f) => m.ceil(f).asint();
        public static int3 ceiltoint(this f3 f) => m.ceil(f).asint();
        public static int2 ceiltoint(this f2 f) => m.ceil(f).asint();
        public static int ceiltoint(this f1 f) => m.ceil(f).asint();
        
        public static int4 ceiltoint(this Vector4 f) => m.ceil(f).asint();
        public static int3 ceiltoint(this Vector3 f) => m.ceil(f).asint();
        public static int2 ceiltoint(this Vector2 f) => m.ceil(f).asint();
        
        public static int4 ceiltoint(this double4 f) => m.ceil(f).asint();
        public static int3 ceiltoint(this double3 f) => m.ceil(f).asint();
        public static int2 ceiltoint(this double2 f) => m.ceil(f).asint();
        public static int ceiltoint(this double f) => m.ceil(f).asint();

        // Floor
        public static f4 floor(this f4 f) => m.floor(f);
        public static f3 floor(this f3 f) => m.floor(f);
        public static f2 floor(this f2 f) => m.floor(f);
        public static f1 floor(this f1 f) => m.floor(f);
        

        public static f4 floor(this Vector4 f) => m.floor(f);
        public static f3 floor(this Vector3 f) => m.floor(f);
        public static f2 floor(this Vector2 f) => m.floor(f);
        
        public static double4 floor(this double4 f) => m.floor(f);
        public static double3 floor(this double3 f) => m.floor(f);
        public static double2 floor(this double2 f) => m.floor(f);
        public static double floor(this double f) => m.floor(f);
        
        // Floor To Int
        public static int4 floortoint(this f4 f) => m.floor(f).asint();
        public static int3 floortoint(this f3 f) => m.floor(f).asint();
        public static int2 floortoint(this f2 f) => m.floor(f).asint();
        public static int floortoint(this f1 f) => m.floor(f).asint();
        
        public static int4 floortoint(this Vector4 f) => m.floor(f).asint();
        public static int3 floortoint(this Vector3 f) => m.floor(f).asint();
        public static int2 floortoint(this Vector2 f) => m.floor(f).asint();
        
        public static int4 floortoint(this double4 f) => m.floor(f).asint();
        public static int3 floortoint(this double3 f) => m.floor(f).asint();
        public static int2 floortoint(this double2 f) => m.floor(f).asint();
        public static int floortoint(this double f) => m.floor(f).asint();
        
        // Saturate
        /// Returns the result of clamping f to [0, 1]
        public static f4 saturate(this f4 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f3 saturate(this f3 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f2 saturate(this f2 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f1 saturate(this f1 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f1 saturate(this int f) => m.saturate(f);
        
        /// <inheritdoc cref="saturate(f4)"/>
        public static f4 saturate(this Vector4 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f3 saturate(this Vector3 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static f2 saturate(this Vector2 f) => m.saturate(f);
        
        /// <inheritdoc cref="saturate(f4)"/>
        public static double4 saturate(this double4 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static double3 saturate(this double3 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static double2 saturate(this double2 f) => m.saturate(f);
        /// <inheritdoc cref="saturate(f4)"/>
        public static double saturate(this double f) => m.saturate(f);


        /// Returns the result of clamping f to [-1, 1]
        public static f4 npsaturate(this f4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f3 npsaturate(this f3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f2 npsaturate(this f2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f1 npsaturate(this f1 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f1 npsaturate(this int f) => f.clamp(-1,1);
        
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f4 npsaturate(this Vector4 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f3 npsaturate(this Vector3 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static f2 npsaturate(this Vector2 f) => clamp(f, -1,1);
        
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static double4 npsaturate(this double4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static double3 npsaturate(this double3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static double2 npsaturate(this double2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(f4)"/>
        public static double npsaturate(this double f) => f.clamp(-1,1);
        
    }
}