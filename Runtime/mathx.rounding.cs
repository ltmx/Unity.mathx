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
        [MethodImpl(INLINE)] public static float4 round(this float4 f) => math.round(f);
        [MethodImpl(INLINE)] public static float3 round(this float3 f) => math.round(f);
        [MethodImpl(INLINE)] public static float2 round(this float2 f) => math.round(f);
        [MethodImpl(INLINE)] public static float round(this float f) => math.round(f);

        [MethodImpl(INLINE)] public static float4 round(this Vector4 f) => math.round(f);
        [MethodImpl(INLINE)] public static float3 round(this Vector3 f) => math.round(f);
        [MethodImpl(INLINE)] public static float2 round(this Vector2 f) => math.round(f);

        [MethodImpl(INLINE)] public static double4 round(this double4 f) => math.round(f);
        [MethodImpl(INLINE)] public static double3 round(this double3 f) => math.round(f);
        [MethodImpl(INLINE)] public static double2 round(this double2 f) => math.round(f);
        [MethodImpl(INLINE)] public static double round(this double f) => math.round(f);

        // Round To Int --------------------------------------------------

        /// Round to int
        [MethodImpl(INLINE)] public static int4 rint(this float4 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int3 rint(this float3 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int2 rint(this float2 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int rint(this float f) => f.round().asint();


        [MethodImpl(INLINE)] public static int4 rint(this Vector4 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int3 rint(this Vector3 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int2 rint(this Vector2 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int4 rint(this double4 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int3 rint(this double3 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int2 rint(this double2 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MethodImpl(INLINE)] public static int rint(this double f) => f.round().asint();

        // Clamp
        ///<inheritdoc cref="clamp(float4, float4, float4)"/>
        [MethodImpl(INLINE)] public static float4 clamp(this float4 f, float4 min, float4 max) => min.max(max.min(f));
        ///<inheritdoc cref="clamp(float3, float3, float3)"/>
        [MethodImpl(INLINE)] public static float3 clamp(this float3 f, float3 min, float3 max) => min.max(max.min(f));
        ///<inheritdoc cref="clamp(float2, float2, float2)"/>
        [MethodImpl(INLINE)] public static float2 clamp(this float2 f, float2 min, float2 max) => min.max(max.min(f));
        ///<inheritdoc cref="clamp(float, float, float)"/>
        [MethodImpl(INLINE)] public static float clamp(this float f, float min, float max) => min.max(max.min(f));
        

        
        [MethodImpl(INLINE)] public static float4 clamp(this float4 f, float min, float max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static float3 clamp(this float3 f, float min, float max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static float2 clamp(this float2 f, float min, float max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static float clamp(this int f, float min, float max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static float clamp(this float f, int min, int max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static int clamp(this int f, int min, int max) => min.max(max.min(f));



        [MethodImpl(INLINE)] public static double4 clamp(this double4 f, double4 min, double4 max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static double3 clamp(this double3 f, double3 min, double3 max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static double2 clamp(this double2 f, double2 min, double2 max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static double clamp(this double f, double min, double max) => min.max(max.min(f));

        [MethodImpl(INLINE)] public static double4 clamp(this double4 f, double min, double max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static double3 clamp(this double3 f, double min, double max) => min.max(max.min(f));
        [MethodImpl(INLINE)] public static double2 clamp(this double2 f, double min, double max) => min.max(max.min(f));

        ///<inheritdoc cref="clamp(float4, float4, float4)"/>
        [MethodImpl(INLINE)] public static Vector4 clamp(this Vector4 f, float min, float max) => min.max(max.min(f));
        ///<inheritdoc cref="clamp(float3, float3, float3)"/>
        [MethodImpl(INLINE)] public static Vector3 clamp(this Vector3 f, float min, float max) => min.max(max.min(f));
        ///<inheritdoc cref="clamp(float2, float2, float2)"/>
        [MethodImpl(INLINE)] public static Vector2 clamp(this Vector2 f, float min, float max) => min.max(max.min(f));


        // Min --------------------------------------------------

        /// <inheritdoc cref="min(float4,float4)"/>
        [MethodImpl(INLINE)] public static float4 min(this float4 f, float4 min) => math.min(f, min);
        /// <inheritdoc cref="min(float3,float3)"/>
        [MethodImpl(INLINE)] public static float3 min(this float3 f, float3 min) => math.min(f, min);
        /// <inheritdoc cref="min(float2,float2)"/>
        [MethodImpl(INLINE)] public static float2 min(this float2 f, float2 min) => math.min(f, min);

        /// <inheritdoc cref="min(float,float)"/>
        [MethodImpl(INLINE)] public static float min(this float f, float min) => math.min(f, min);
        /// <inheritdoc cref="min(float,float)"/>
        [MethodImpl(INLINE)] public static float min(this int f, float min) => math.min(f, min);
        /// <inheritdoc cref="min(float,float)"/>
        [MethodImpl(INLINE)] public static int min(this int f, int min) => math.min(f, min);

        /// <inheritdoc cref="min(double4,double4)"/>
        [MethodImpl(INLINE)] public static double4 min(this double4 f, double4 min) => math.min(f, min);
        /// <inheritdoc cref="min(double3,double3)"/>
        [MethodImpl(INLINE)] public static double3 min(this double3 f, double3 min) => math.min(f, min);
        /// <inheritdoc cref="min(double2,double2)"/>
        [MethodImpl(INLINE)] public static double2 min(this double2 f, double2 min) => math.min(f, min);
        /// <inheritdoc cref="min(double,double)"/>
        [MethodImpl(INLINE)] public static double min(this double f, double min) => math.min(f, min);




        #region Max

        /// <inheritdoc cref="max(float4, float4)"/>
        [MethodImpl(INLINE)] public static float4 max(this float4 f, float4 max) => math.max(f, max);
        /// <inheritdoc cref="max(float3, float3)"/>
        [MethodImpl(INLINE)] public static float3 max(this float3 f, float3 max) => math.max(f, max);
        /// <inheritdoc cref="max(Mathematics.float2, Mathematics.float2)"/>
        [MethodImpl(INLINE)] public static float2 max(this float2 f, float2 max) => math.max(f, max);
        /// <inheritdoc cref="max(float, float)"/>
        [MethodImpl(INLINE)] public static float max(this float f, float max) => math.max(f, max);
        
        
        /// <inheritdoc cref="max(float, float)"/>
        [MethodImpl(INLINE)] public static float max(this int f, float max) => math.max(f, max);
        /// <inheritdoc cref="max(float, float)"/>
        [MethodImpl(INLINE)] public static float max(this float f, int max) => math.max(f, max);
        /// <inheritdoc cref="max(int, int)"/>
        [MethodImpl(INLINE)] public static int max(this int f, int max) => math.max(f, max);
        

        /// Returns the componentwise maximum of a f4 and a float value
        [MethodImpl(INLINE)] public static float4 max(this float4 x, float y) => new (max(x.x, y), max(x.y, y), max(x.z, y), max(x.w, y));
        /// Returns the componentwise maximum of a f3 and a float value
        [MethodImpl(INLINE)] public static float3 max(this float3 x, float y) => new (max(x.x, y), max(x.y, y), max(x.z, y));
        /// Returns the componentwise maximum of a f2 and a float value
        [MethodImpl(INLINE)] public static float2 max(this float2 x, float y) => new (max(x.x, y), max(x.y, y));
        /// Returns the componentwise maximum of a f4 and a float value
        [MethodImpl(INLINE)] public static float4 max(this float x, float4 y) => new (max(x, y.x), max(x, y.y), max(x, y.z), max(x, y.w));
        /// Returns the componentwise maximum of a f3 and a float value
        [MethodImpl(INLINE)] public static float3 max(this float x, float3 y) => new (max(x, y.x), max(x, y.y), max(x, y.z));
        /// Returns the componentwise maximum of a f2 and a float value
        [MethodImpl(INLINE)] public static float2 max(this float x, float2 y) => new (max(x, y.x), max(x, y.y));
        
        /// Returns the componentwise minimum of a f4 and a float value
        [MethodImpl(INLINE)] public static float4 min(this float4 x, float y) => new (min(x.x, y), min(x.y, y), min(x.z, y), min(x.w, y));
        /// Returns the componentwise minimum of a f3 and a float value
        [MethodImpl(INLINE)] public static float3 min(this float3 x, float y) => new (min(x.x, y), min(x.y, y), min(x.z, y));
        /// Returns the componentwise minimum of a f2 and a float value
        [MethodImpl(INLINE)] public static float2 min(this float2 x, float y) => new (min(x.x, y), min(x.y, y));
        /// Returns the componentwise minimum of a f4 and a float value
        [MethodImpl(INLINE)] public static float4 min(this float x, float4 y) => new (min(x, y.x), min(x, y.y), min(x, y.z), min(x, y.w));
        /// Returns the componentwise minimum of a f3 and a float value
        [MethodImpl(INLINE)] public static float3 min(this float x, float3 y) => new (min(x, y.x), min(x, y.y), min(x, y.z));
        /// Returns the componentwise minimum of a f2 and a float value
        [MethodImpl(INLINE)] public static float2 min(this float x, float2 y) => new (min(x, y.x), min(x, y.y));
        
        
        /// <inheritdoc cref="max(double4, double4)"/>
        [MethodImpl(INLINE)] public static double4 max(this double4 f, double4 max) => math.max(f, max);
        /// <inheritdoc cref="max(double3, double3)"/>
        [MethodImpl(INLINE)] public static double3 max(this double3 f, double3 max) => math.max(f, max);
        /// <inheritdoc cref="max(double2, double2)"/>
        [MethodImpl(INLINE)] public static double2 max(this double2 f, double2 max) => math.max(f, max);
        /// <inheritdoc cref="max(double, double)"/>
        [MethodImpl(INLINE)] public static double max(this double f, double max) => math.max(f, max);
        
        /// Returns the componentwise maximum of a f4 and a float value
        [MethodImpl(INLINE)] public static double4 max(this double4 x, double y) => new (max(x.x, y), max(x.y, y), max(x.z, y), max(x.w, y));
        /// Returns the componentwise maximum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 max(this double3 x, double y) => new (max(x.x, y), max(x.y, y), max(x.z, y));
        /// Returns the componentwise maximum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 max(this double2 x, double y) => new (max(x.x, y), max(x.y, y));
        /// Returns the componentwise maximum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 max(this double x, double4 y) => new (max(x, y.x), max(x, y.y), max(x, y.z), max(x, y.w));
        /// Returns the componentwise maximum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 max(this double x, double3 y) => new (max(x, y.x), max(x, y.y), max(x, y.z));
        /// Returns the componentwise maximum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 max(this double x, double2 y) => new (max(x, y.x), max(x, y.y));
        
        /// Returns the componentwise minimum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 min(this double4 x, double y) => new (min(x.x, y), min(x.y, y), min(x.z, y), min(x.w, y));
        /// Returns the componentwise minimum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 min(this double3 x, double y) => new (min(x.x, y), min(x.y, y), min(x.z, y));
        /// Returns the componentwise minimum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 min(this double2 x, double y) => new (min(x.x, y), min(x.y, y));
        /// Returns the componentwise minimum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 min(this double x, double4 y) => new (min(x, y.x), min(x, y.y), min(x, y.z), min(x, y.w));
        /// Returns the componentwise minimum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 min(this double x, double3 y) => new (min(x, y.x), min(x, y.y), min(x, y.z));
        /// Returns the componentwise minimum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 min(this double x, double2 y) => new (min(x, y.x), min(x, y.y));

        #endregion


        #region Ceil

        /// <inheritdoc cref="ceil(float4)"/>
        [MethodImpl(INLINE)] public static float4 ceil(this float4 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(float3)"/>
        [MethodImpl(INLINE)] public static float3 ceil(this float3 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(Mathematics.float2)"/>
        [MethodImpl(INLINE)] public static float2 ceil(this float2 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(float)"/>
        [MethodImpl(INLINE)] public static float ceil(this float f) => math.ceil(f);

        /// <inheritdoc cref="ceil(float4)"/>
        [MethodImpl(INLINE)] public static double4 ceil(this double4 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(float3)"/>
        [MethodImpl(INLINE)] public static double3 ceil(this double3 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(Mathematics.float2)"/>
        [MethodImpl(INLINE)] public static double2 ceil(this double2 f) => math.ceil(f);
        /// <inheritdoc cref="ceil(float)"/>
        [MethodImpl(INLINE)] public static double ceil(this double f) => math.ceil(f);

        #endregion

        // Ceil To Int

        #region CeilToInt

        /// Ceil to int
        [MethodImpl(INLINE)] public static int4 clint(this float4 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int3 clint(this float3 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int2 clint(this float2 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int clint(this float f) => math.ceil(f).asint();
        
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int4 clint(this double4 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int3 clint(this double3 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int2 clint(this double2 f) => math.ceil(f).asint();
        /// <inheritdoc cref="clint(float4)" />
        [MethodImpl(INLINE)] public static int clint(this double f) => math.ceil(f).asint();

        #endregion


        // Floor

        #region Floor

        /// ///
        /// <inheritdoc cref="floor(float4)" />
        [MethodImpl(INLINE)] public static float4 floor(this float4 f) => math.floor(f);
        /// <inheritdoc cref="floor(float3)" />
        [MethodImpl(INLINE)] public static float3 floor(this float3 f) => math.floor(f);
        /// <inheritdoc cref="floor(Mathematics.float2)" />
        [MethodImpl(INLINE)] public static float2 floor(this float2 f) => math.floor(f);
        /// <inheritdoc cref="floor(float)" />
        [MethodImpl(INLINE)] public static float floor(this float f) => math.floor(f);

        /// <inheritdoc cref="floor(double4)" />
        [MethodImpl(INLINE)] public static double4 floor(this double4 f) => math.floor(f);
        /// <inheritdoc cref="floor(double3)" />
        [MethodImpl(INLINE)] public static double3 floor(this double3 f) => math.floor(f);
        /// <inheritdoc cref="floor(double2)" />
        [MethodImpl(INLINE)] public static double2 floor(this double2 f) => math.floor(f);
        /// <inheritdoc cref="floor(double)" />
        [MethodImpl(INLINE)] public static double floor(this double f) => math.floor(f);

        #endregion


        #region Floor To Int

        /// Floor To Int
        [MethodImpl(INLINE)] public static int4 flint(this float4 f) => f.greater(0).select(f, f + 1).asint();
        
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int3 flint(this float3 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int2 flint(this float2 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int flint(this float f) => f.greater(0).select(f, f + 1).asint();

        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int4 flint(this double4 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int3 flint(this double3 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int2 flint(this double2 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MethodImpl(INLINE)] public static int flint(this double f) => f.greater(0).select(f, f + 1).asint();

        #endregion

        // Saturate

        #region Saturate

        /// Returns the result of clamping f to [0, 1]
        [MethodImpl(INLINE)] public static float4 saturate(this float4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float3)" />
        [MethodImpl(INLINE)] public static float3 saturate(this float3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(Mathematics.float2)" />
        [MethodImpl(INLINE)] public static float2 saturate(this float2 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float)" />
        [MethodImpl(INLINE)] public static float saturate(this float f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float)" />
        [MethodImpl(INLINE)] public static float saturate(this int f) => math.saturate(f);

        /// <inheritdoc cref="saturate(float4)" />
        [MethodImpl(INLINE)] public static float4 saturate(this Vector4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(float3)" />
        [MethodImpl(INLINE)] public static float3 saturate(this Vector3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(Mathematics.float2)" />
        [MethodImpl(INLINE)] public static float2 saturate(this Vector2 f) => math.saturate(f);

        /// <inheritdoc cref="saturate(double4)" />
        [MethodImpl(INLINE)] public static double4 saturate(this double4 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(double3)" />
        [MethodImpl(INLINE)] public static double3 saturate(this double3 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(double2)" />
        [MethodImpl(INLINE)] public static double2 saturate(this double2 f) => math.saturate(f);
        /// <inheritdoc cref="saturate(double)" />
        [MethodImpl(INLINE)] public static double saturate(this double f) => math.saturate(f);

        #endregion

        // npsat

        #region npSaturate

        /// Returns the result of clamping f to [-1, 1]
        [MethodImpl(INLINE)] public static float4 npsat(this float4 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static float3 npsat(this float3 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static float2 npsat(this float2 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static float npsat(this float f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static float npsat(this int f) => f.clamp(-1, 1);

        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static double4 npsat(this double4 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static double3 npsat(this double3 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static double2 npsat(this double2 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="npsat(Unity.Mathematics.float4)" />
        [MethodImpl(INLINE)] public static double npsat(this double f) => f.clamp(-1, 1);

        #endregion


        // Max0

        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MethodImpl(INLINE)] public static float4 limp(this float4 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static float3 limp(this float3 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static float2 limp(this float2 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static float limp(this float f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static float limp(this int f) => f.max(0);

        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static double4 limp(this double4 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static double3 limp(this double3 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static double2 limp(this double2 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MethodImpl(INLINE)] public static double limp(this double f) => f.max(0);


        //Min0

        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MethodImpl(INLINE)] public static float4 limn(this float4 f) => f.min(0);
        /// <inheritdoc cref="limn(float)" />
        [MethodImpl(INLINE)] public static float3 limn(this float3 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static float2 limn(this float2 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static float limn(this float f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static float limn(this int f) => f.min(0);
        

        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static double4 limn(this double4 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static double3 limn(this double3 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static double2 limn(this double2 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MethodImpl(INLINE)] public static double limn(this double f) => f.min(0);


        //Min0

        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MethodImpl(INLINE)] public static float4 under1(this float4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static float3 under1(this float3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static float2 under1(this float2 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static float under1(this float f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static float under1(this int f) => f.min(1);

        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static double4 under1(this double4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static double3 under1(this double3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static double2 under1(this double2 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MethodImpl(INLINE)] public static double under1(this double f) => f.min(1);
    }
}