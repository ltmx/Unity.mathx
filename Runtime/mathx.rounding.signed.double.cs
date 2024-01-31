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

        #region ClampSigned

        /// Returns the signed result of clamping of the value x into the interval [a, b] componentwise
        [MethodImpl(INLINE)] public static double4 clampsigned(this double4 f, double4 min, double4 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(double4, double4, double4)"/>
        [MethodImpl(INLINE)] public static double3 clampsigned(this double3 f, double3 min, double3 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(double4, double4, double4)"/>
        [MethodImpl(INLINE)] public static double2 clampsigned(this double2 f, double2 min, double2 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(double4, double4, double4)"/>
        [MethodImpl(INLINE)] public static double clampsigned(this double f, double min, double max) => min.max(max.min(f));
        
        /// Returns the signed result of clamping of the value x into the interval [a, b]
        [MethodImpl(INLINE)] public static double4 clampsigned(this double4 f, double min, double max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double3 clampsigned(this double3 f, double min, double max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double2 clampsigned(this double2 f, double min, double max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double clampsigned(this int f, double min, double max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(double4, double, double)"/>
        [MethodImpl(INLINE)] public static double clampsigned(this double f, int min, int max) => f.abs().clamp(min, max) * math.sign(f);
        
        #endregion
        
        #region MaxSigned
        
        /// Returns the signed componentwise maximum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 maxsigned(this double4 f, double4 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double3 maxsigned(this double3 f, double3 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double2 maxsigned(this double2 f, double2 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double maxsigned(this double f, double y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double maxsigned(this double f, int y) => f.abs().max(y) * math.sign(f);
        
        /// Returns the signed componentwise maximum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 maxsigned(this double4 f, double y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 maxsigned(this double3 f, double y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 maxsigned(this double2 f, double y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a double and a double4
        [MethodImpl(INLINE)] public static double4 maxsigned(this double f, double4 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a double and a double3
        [MethodImpl(INLINE)] public static double3 maxsigned(this double f, double3 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a double and a double2
        [MethodImpl(INLINE)] public static double2 maxsigned(this double f, double2 y) => f.abs().max(y) * math.sign(f);
        
        #endregion
        
        #region MinSigned
        
        /// Returns the signed componentwise minimum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 minsigned(this double4 f, double4 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double3 minsigned(this double3 f, double3 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double2 minsigned(this double2 f, double2 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double minsigned(this double f, double y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(double4, double4)"/>
        [MethodImpl(INLINE)] public static double minsigned(this double f, int y) => f.abs().min(y) * math.sign(f);
        
        /// Returns the signed componentwise minimum of a f4 and a double value
        [MethodImpl(INLINE)] public static double4 minsigned(this double4 f, double y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f3 and a double value
        [MethodImpl(INLINE)] public static double3 minsigned(this double3 f, double y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f2 and a double value
        [MethodImpl(INLINE)] public static double2 minsigned(this double2 f, double y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a double and a double4
        [MethodImpl(INLINE)] public static double4 minsigned(this double f, double4 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a double and a double3
        [MethodImpl(INLINE)] public static double3 minsigned(this double f, double3 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a double and a double2
        [MethodImpl(INLINE)] public static double2 minsigned(this double f, double2 y) => f.abs().min(y) * math.sign(f);
        
        #endregion

        #region SaturateSigned

        /// Returns the result of clamping f to [-1, 1]
        [MethodImpl(INLINE)] public static double4 satsigned(this double4 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(double4)" />
        [MethodImpl(INLINE)] public static double3 satsigned(this double3 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(double4)" />
        [MethodImpl(INLINE)] public static double2 satsigned(this double2 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(double4)" />
        [MethodImpl(INLINE)] public static double satsigned(this double f) => f.clamp(-1, 1);

        #endregion
        
    }
}