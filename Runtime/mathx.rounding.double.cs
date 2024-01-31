#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Rounding --------------------------------------------------

        // Round
        
        /// <inheritdoc cref="math.round(double4)"/>
        [MethodImpl(INLINE)] public static double4 round(this double4 f) => math.round(f);
        ///<inheritdoc cref="math.round(double3)"/>
        [MethodImpl(INLINE)] public static double3 round(this double3 f) => math.round(f);
        ///<inheritdoc cref="math.round(double3)"/>
        [MethodImpl(INLINE)] public static double2 round(this double2 f) => math.round(f);
        ///<inheritdoc cref="math.round(double3)"/>
        [MethodImpl(INLINE)] public static double round(this double f) => math.round(f);
        

        /// Round to int
        [MethodImpl(INLINE)] public static int4 rint(this double4 f) => f.round().asint();
        ///<inheritdoc cref="rint(double4)"/>
        [MethodImpl(INLINE)] public static int3 rint(this double3 f) => f.round().asint();
        ///<inheritdoc cref="rint(double4)"/>
        [MethodImpl(INLINE)] public static int2 rint(this double2 f) => f.round().asint();
        ///<inheritdoc cref="rint(double4)"/>
        [MethodImpl(INLINE)] public static int rint(this double f) => f.round().asint();
        

        // Clamp
        ///<inheritdoc cref="math.clamp(double4, double4, double4)"/>
        [MethodImpl(INLINE)] public static double4 clamp(this double4 f, double4 min, double4 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(double3, double3, double3)"/>
        [MethodImpl(INLINE)] public static double3 clamp(this double3 f, double3 min, double3 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(double2, double2, double2)"/>
        [MethodImpl(INLINE)] public static double2 clamp(this double2 f, double2 min, double2 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(double, double, double)"/>
        [MethodImpl(INLINE)] public static double clamp(this double f, double min, double max) => min.max(max.min(f));
        

        /// Returns the result of clamping of the value x into the interval [a, b]
        [MethodImpl(INLINE)] public static double4 clamp(this double4 f, double min, double max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double3 clamp(this double3 f, double min, double max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double2 clamp(this double2 f, double min, double max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double clamp(this int f, double min, double max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double clamp(this double f, int min, int max) => math.max(min, math.min(f, max));
        

        /// <inheritdoc cref="math.min(double4,double4)"/>
        [MethodImpl(INLINE)] public static double4 min(this double4 f, double4 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(double3,double3)"/>
        [MethodImpl(INLINE)] public static double3 min(this double3 f, double3 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(double2,double2)"/>
        [MethodImpl(INLINE)] public static double2 min(this double2 f, double2 min) => math.min(f, min);

        /// <inheritdoc cref="math.min(double,double)"/>
        [MethodImpl(INLINE)] public static double min(this double f, double min) => math.min(f, min);
        /// <inheritdoc cref="math.min(double,double)"/>
        [MethodImpl(INLINE)] public static double min(this double f, int y) => math.min(f, y);


        #region Max

        /// <inheritdoc cref="math.max(double4, double4)"/>
        [MethodImpl(INLINE)] public static double4 max(this double4 f, double4 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(double3, double3)"/>
        [MethodImpl(INLINE)] public static double3 max(this double3 f, double3 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(Mathematics.double2, Mathematics.double2)"/>
        [MethodImpl(INLINE)] public static double2 max(this double2 f, double2 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(double, double)"/>
        [MethodImpl(INLINE)] public static double max(this double f, double max) => math.max(f, max);
        /// <inheritdoc cref="math.max(double, double)"/>
        [MethodImpl(INLINE)] public static double max(this double f, int y) => math.max(f, y);


        /// Returns the componentwise maximum of a f4 and a double value
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

        /// <inheritdoc cref="math.ceil(double4)"/>
        [MethodImpl(INLINE)] public static double4 ceil(this double4 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(double3)"/>
        [MethodImpl(INLINE)] public static double3 ceil(this double3 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(Mathematics.double2)"/>
        [MethodImpl(INLINE)] public static double2 ceil(this double2 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(double)"/>
        [MethodImpl(INLINE)] public static double ceil(this double f) => math.ceil(f);


        #endregion


        #region CeilToInt

        /// Ceil to int
        [MethodImpl(INLINE)] public static int4 clint(this double4 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(double4)" />
        [MethodImpl(INLINE)] public static int3 clint(this double3 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(double4)" />
        [MethodImpl(INLINE)] public static int2 clint(this double2 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(double4)" />
        [MethodImpl(INLINE)] public static int clint(this double f) => f.ceil().asint();

        #endregion
        
        #region Floor
        
        /// <inheritdoc cref="math.floor(double4)" />
        [MethodImpl(INLINE)] public static double4 floor(this double4 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(double3)" />
        [MethodImpl(INLINE)] public static double3 floor(this double3 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(Mathematics.double2)" />
        [MethodImpl(INLINE)] public static double2 floor(this double2 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(double)" />
        [MethodImpl(INLINE)] public static double floor(this double f) => math.floor(f);

        #endregion
        
        #region Floor To Int

        /// Floor To Int
        [MethodImpl(INLINE)] public static int4 flint(this double4 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(double4)" />
        [MethodImpl(INLINE)] public static int3 flint(this double3 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(double4)" />
        [MethodImpl(INLINE)] public static int2 flint(this double2 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(double4)" />
        [MethodImpl(INLINE)] public static int flint(this double f) => f.greater(0).select(f, f + 1).asint();
        

        #endregion

        #region Saturate

        /// Returns the result of clamping f to [0, 1]
        [MethodImpl(INLINE)] public static double4 sat(this double4 f) => math.saturate(f);
        /// <inheritdoc cref="sat(Unity.Mathematics.double3)" />
        [MethodImpl(INLINE)] public static double3 sat(this double3 f) => math.saturate(f);
        /// <inheritdoc cref="sat(Unity.Mathematics.double2)" />
        [MethodImpl(INLINE)] public static double2 sat(this double2 f) => math.saturate(f);
        /// <inheritdoc cref="sat(double)" />
        [MethodImpl(INLINE)] public static double sat(this double f) => math.saturate(f);

        #endregion

        // npsat
        
        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MethodImpl(INLINE)] public static double4 limp(this double4 f) => f.max(0);
        /// <inheritdoc cref="limp(double4)" />
        [MethodImpl(INLINE)] public static double3 limp(this double3 f) => f.max(0);
        /// <inheritdoc cref="limp(double4)" />
        [MethodImpl(INLINE)] public static double2 limp(this double2 f) => f.max(0);
        /// <inheritdoc cref="limp(double4)" />
        [MethodImpl(INLINE)] public static double limp(this double f) => f.max(0);
        
        
        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MethodImpl(INLINE)] public static double4 limn(this double4 f) => f.min(0);
        /// <inheritdoc cref="limn(double)" />
        [MethodImpl(INLINE)] public static double3 limn(this double3 f) => f.min(0);
        /// <inheritdoc cref="limn(double4)" />
        [MethodImpl(INLINE)] public static double2 limn(this double2 f) => f.min(0);
        /// <inheritdoc cref="limn(double4)" />
        [MethodImpl(INLINE)] public static double limn(this double f) => f.min(0);

        
        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MethodImpl(INLINE)] public static double4 under1(this double4 f) => f.min(1);
        /// <inheritdoc cref="under1(double4)" />
        [MethodImpl(INLINE)] public static double3 under1(this double3 f) => f.min(1);
        /// <inheritdoc cref="under1(double4)" />
        [MethodImpl(INLINE)] public static double2 under1(this double2 f) => f.min(1);
        /// <inheritdoc cref="under1(double4)" />
        [MethodImpl(INLINE)] public static double under1(this double f) => f.min(1);

    }
}