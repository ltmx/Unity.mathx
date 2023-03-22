#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{ 
    public static partial class mathx
    {
        
        // Rounding --------------------------------------------------
        
        // Round
        [MethodImpl(INLINE)]
        public static float4 round(this float4 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static float3 round(this float3 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static float2 round(this float2 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static float round(this float f) => math.round(f);

        [MethodImpl(INLINE)]
        public static float4 round(this Vector4 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static float3 round(this Vector3 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static float2 round(this Vector2 f) => math.round(f);

        [MethodImpl(INLINE)]
        public static double4 round(this double4 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static double3 round(this double3 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static double2 round(this double2 f) => math.round(f);
        [MethodImpl(INLINE)]
        public static double round(this double f) => math.round(f);

        // Round To Int --------------------------------------------------

        /// Round to int
        [MethodImpl(INLINE)]
        public static int4 rint(this float4 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int3 rint(this float3 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int2 rint(this float2 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int rint(this float f) => f.round().asint();


        [MethodImpl(INLINE)]
        public static int4 rint(this Vector4 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int3 rint(this Vector3 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int2 rint(this Vector2 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int4 rint(this double4 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int3 rint(this double3 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int2 rint(this double2 f) => f.round().asint();
        /// Round to int
        [MethodImpl(INLINE)]
        public static int rint(this double f) => f.round().asint();

        // Clamp
        [MethodImpl(INLINE)]
        public static float4 clamp(this float4 f, float4 min, float4 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float3 clamp(this float3 f, float3 min, float3 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float2 clamp(this float2 f, float2 min, float2 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float clamp(this float f, float min, float max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float clamp(this int f, float min, float max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static int clamp(this int f, int min, int max) => math.clamp(f, min, max);


        [MethodImpl(INLINE)]
        public static double4 clamp(this double4 f, double4 min, double4 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static double3 clamp(this double3 f, double3 min, double3 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static double2 clamp(this double2 f, double2 min, double2 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static double clamp(this double f, double min, double max) => math.clamp(f, min, max);


        // Min --------------------------------------------------

        [MethodImpl(INLINE)]
        public static float4 min(this float4 f, float4 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static float3 min(this float3 f, float3 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static float2 min(this float2 f, float2 min) => math.min(f, min);

        [MethodImpl(INLINE)]
        public static float min(this float f, float min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static float min(this int f, float min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static int min(this int f, int min) => math.min(f, min);

        [MethodImpl(INLINE)]
        public static float4 min(this Vector4 f, float4 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static float3 min(this Vector3 f, float3 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static float2 min(this Vector2 f, float2 min) => math.min(f, min);

        [MethodImpl(INLINE)]
        public static double4 min(this double4 f, double4 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static double3 min(this double3 f, double3 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static double2 min(this double2 f, double2 min) => math.min(f, min);
        [MethodImpl(INLINE)]
        public static double min(this double f, double min) => math.min(f, min);

        [MethodImpl(INLINE)]
        public static float4 min(this Vector4 f, float4 min, float4 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float3 min(this Vector3 f, float3 min, float3 max) => math.clamp(f, min, max);
        [MethodImpl(INLINE)]
        public static float2 min(this Vector2 f, float2 min, float2 max) => math.clamp(f, min, max);





        #region Max

        [MethodImpl(INLINE)]
        public static float4 max(this float4 f, float4 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float3 max(this float3 f, float3 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float2 max(this float2 f, float2 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float max(this float f, float max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float max(this int f, float max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static int max(this int f, int max) => math.max(f, max);

        [MethodImpl(INLINE)]
        public static float4 max(this Vector4 f, float4 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float3 max(this Vector3 f, float3 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static float2 max(this Vector2 f, float2 max) => math.max(f, max);

        [MethodImpl(INLINE)]
        public static double4 max(this double4 f, double4 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static double3 max(this double3 f, double3 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static double2 max(this double2 f, double2 max) => math.max(f, max);
        [MethodImpl(INLINE)]
        public static double max(this double f, double max) => math.max(f, max);

        #endregion





        #region Ceil

        [MethodImpl(INLINE)]
        public static float4 ceil(this float4 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static float3 ceil(this float3 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static float2 ceil(this float2 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static float ceil(this float f) => math.ceil(f);

        [MethodImpl(INLINE)]
        public static float4 ceil(this Vector4 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static float3 ceil(this Vector3 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static float2 ceil(this Vector2 f) => math.ceil(f);

        [MethodImpl(INLINE)]
        public static double4 ceil(this double4 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static double3 ceil(this double3 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static double2 ceil(this double2 f) => math.ceil(f);
        [MethodImpl(INLINE)]
        public static double ceil(this double f) => math.ceil(f);

        #endregion

        // Ceil To Int

        #region CeilToInt

        /// Ceil to int
        [MethodImpl(INLINE)]
        public static int4 clint(this float4 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int3 clint(this float3 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int2 clint(this float2 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int clint(this float f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int4 clint(this Vector4 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int3 clint(this Vector3 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int2 clint(this Vector2 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int4 clint(this double4 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int3 clint(this double3 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int2 clint(this double2 f) => math.ceil(f).asint();

        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)]
        public static int clint(this double f) => math.ceil(f).asint();

        #endregion


        // Floor

        #region Floor


        /// ///<inheritdoc cref="math.floor(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 floor(this float4 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float3)"/>
        [MethodImpl(INLINE)]
        public static float3 floor(this float3 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float2)"/>
        [MethodImpl(INLINE)]
        public static float2 floor(this float2 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float)"/>
        [MethodImpl(INLINE)]
        public static float floor(this float f) => math.floor(f);

        ///<inheritdoc cref="math.floor(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 floor(this Vector4 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float3)"/>
        [MethodImpl(INLINE)]
        public static float3 floor(this Vector3 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float2)"/>
        [MethodImpl(INLINE)]
        public static float2 floor(this Vector2 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(float)"/>

        ///<inheritdoc cref="math.floor(double4)"/>
        [MethodImpl(INLINE)]
        public static double4 floor(this double4 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(double3)"/>
        [MethodImpl(INLINE)]
        public static double3 floor(this double3 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(double2)"/>
        [MethodImpl(INLINE)]
        public static double2 floor(this double2 f) => math.floor(f);
        ///<inheritdoc cref="math.floor(double)"/>
        [MethodImpl(INLINE)]
        public static double floor(this double f) => math.floor(f);

        #endregion



        #region Floor To Int

        /// Floor To Int
        [MethodImpl(INLINE)]
        public static int4 flint(this float4 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int3 flint(this float3 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int2 flint(this float2 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int flint(this float f) => f.asint();

        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int4 flint(this Vector4 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int3 flint(this Vector3 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int2 flint(this Vector2 f) => f.asint();

        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int4 flint(this double4 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int3 flint(this double3 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int2 flint(this double2 f) => f.asint();
        /// <inheritdoc cref="flint(float4)"/>
        [MethodImpl(INLINE)]
        public static int flint(this double f) => f.asint();

        #endregion

        // Saturate

        #region Saturate

        /// Returns the result of clamping f to [0, 1]
        [MethodImpl(INLINE)]
        public static float4 saturate(this float4 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float3)"/>
        [MethodImpl(INLINE)]
        public static float3 saturate(this float3 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float2)"/>
        [MethodImpl(INLINE)]
        public static float2 saturate(this float2 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float)"/>
        [MethodImpl(INLINE)]
        public static float saturate(this float f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float)"/>
        [MethodImpl(INLINE)]
        public static float saturate(this int f) => math.saturate(f);

        /// <inheritdoc cref="math.saturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 saturate(this Vector4 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float3)"/>
        [MethodImpl(INLINE)]
        public static float3 saturate(this Vector3 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float2)"/>
        [MethodImpl(INLINE)]
        public static float2 saturate(this Vector2 f) => math.saturate(f);

        /// <inheritdoc cref="math.saturate(double4)"/>
        [MethodImpl(INLINE)]
        public static double4 saturate(this double4 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(double3)"/>
        [MethodImpl(INLINE)]
        public static double3 saturate(this double3 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(double2)"/>
        [MethodImpl(INLINE)]
        public static double2 saturate(this double2 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(double)"/>
        [MethodImpl(INLINE)]
        public static double saturate(this double f) => math.saturate(f);

        #endregion

        // npsaturate

        #region npSaturate

        /// Returns the result of clamping f to [-1, 1]
        [MethodImpl(INLINE)]
        public static float4 npsaturate(this float4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 npsaturate(this float3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 npsaturate(this float2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float npsaturate(this float f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float npsaturate(this int f) => f.clamp(-1,1);

        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 npsaturate(this Vector4 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 npsaturate(this Vector3 f) => clamp(f, -1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 npsaturate(this Vector2 f) => clamp(f, -1,1);

        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static double4 npsaturate(this double4 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static double3 npsaturate(this double3 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static double2 npsaturate(this double2 f) => f.clamp(-1,1);
        /// <inheritdoc cref="npsaturate(float4)"/>
        [MethodImpl(INLINE)]
        public static double npsaturate(this double f) => f.clamp(-1,1);

        #endregion


        // Max0

        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MethodImpl(INLINE)]
        public static float4 p(this float4 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 p(this float3 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 p(this float2 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float p(this float f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float p(this int f) => f.max(0);

        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 p(this Vector4 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 p(this Vector3 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 p(this Vector2 f) => f.max(0);

        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static double4 p(this double4 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static double3 p(this double3 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static double2 p(this double2 f) => f.max(0);
        /// <inheritdoc cref="p(float4)"/>
        [MethodImpl(INLINE)]
        public static double p(this double f) => f.max(0);



        //Min0

        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MethodImpl(INLINE)]
        public static float4 n(this float4 f) => f.min(0);
        /// <inheritdoc cref="n(float)"/>
        [MethodImpl(INLINE)]
        public static float3 n(this float3 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 n(this float2 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float n(this float f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float n(this int f) => f.min(0);

        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 n(this Vector4 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 n(this Vector3 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 n(this Vector2 f) => f.min(0);

        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static double4 n(this double4 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static double3 n(this double3 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static double2 n(this double2 f) => f.min(0);
        /// <inheritdoc cref="n(float4)"/>
        [MethodImpl(INLINE)]
        public static double n(this double f) => f.min(0);


        //Min0

        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MethodImpl(INLINE)]
        public static float4 under1(this float4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 under1(this float3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 under1(this float2 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float under1(this float f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float under1(this int f) => f.min(1);

        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float4 under1(this Vector4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float3 under1(this Vector3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static float2 under1(this Vector2 f) => f.min(1);

        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static double4 under1(this double4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static double3 under1(this double3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static double2 under1(this double2 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)"/>
        [MethodImpl(INLINE)]
        public static double under1(this double f) => f.min(1);

    }
}