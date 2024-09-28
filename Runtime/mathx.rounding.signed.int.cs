#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Rounding --------------------------------------------------

        #region ClampSigned

        /// Returns the signed result of clamping of the value x into the interval [a, b] componentwise
        [MI(IL)] public static int4 clampsigned(this int4 f, int4 min, int4 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(int4, int4, int4)"/>
        [MI(IL)] public static int3 clampsigned(this int3 f, int3 min, int3 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(int4, int4, int4)"/>
        [MI(IL)] public static int2 clampsigned(this int2 f, int2 min, int2 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(int4, int4, int4)"/>
        [MI(IL)] public static int clampsigned(this int f, int min, int max) => min.max(max.min(f));
        
        /// Returns the signed result of clamping of the value x into the interval [a, b]
        [MI(IL)] public static int4 clampsigned(this int4 f, int min, int max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(int4, int, int)"/>
        [MI(IL)] public static int3 clampsigned(this int3 f, int min, int max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(int4, int, int)"/>
        [MI(IL)] public static int2 clampsigned(this int2 f, int min, int max) => f.abs().clamp(min, max) * math.sign(f);
        
        #endregion
        
        #region MaxSigned
        
        /// Returns the signed componentwise maximum of a f4 and a int value
        [MI(IL)] public static int4 maxsigned(this int4 f, int4 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(int4, int4)"/>
        [MI(IL)] public static int3 maxsigned(this int3 f, int3 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(int4, int4)"/>
        [MI(IL)] public static int2 maxsigned(this int2 f, int2 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(int4, int4)"/>
        [MI(IL)] public static int maxsigned(this int f, int y) => f.abs().max(y) * math.sign(f);
        
        /// Returns the signed componentwise maximum of a f4 and a int value
        [MI(IL)] public static int4 maxsigned(this int4 f, int y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f3 and a int value
        [MI(IL)] public static int3 maxsigned(this int3 f, int y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f2 and a int value
        [MI(IL)] public static int2 maxsigned(this int2 f, int y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a int and a int4
        [MI(IL)] public static int4 maxsigned(this int f, int4 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a int and a int3
        [MI(IL)] public static int3 maxsigned(this int f, int3 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a int and a int2
        [MI(IL)] public static int2 maxsigned(this int f, int2 y) => f.abs().max(y) * math.sign(f);
        
        #endregion
        
        #region MinSigned
        
        /// Returns the signed componentwise minimum of a f4 and a int value
        [MI(IL)] public static int4 minsigned(this int4 f, int4 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(int4, int4)"/>
        [MI(IL)] public static int3 minsigned(this int3 f, int3 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(int4, int4)"/>
        [MI(IL)] public static int2 minsigned(this int2 f, int2 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(int4, int4)"/>
        [MI(IL)] public static int minsigned(this int f, int y) => f.abs().min(y) * math.sign(f);
        
        /// Returns the signed componentwise minimum of a f4 and a int value
        [MI(IL)] public static int4 minsigned(this int4 f, int y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f3 and a int value
        [MI(IL)] public static int3 minsigned(this int3 f, int y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f2 and a int value
        [MI(IL)] public static int2 minsigned(this int2 f, int y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a int and a int4
        [MI(IL)] public static int4 minsigned(this int f, int4 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a int and a int3
        [MI(IL)] public static int3 minsigned(this int f, int3 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a int and a int2
        [MI(IL)] public static int2 minsigned(this int f, int2 y) => f.abs().min(y) * math.sign(f);
        
        #endregion

        #region SaturateSigned

        /// Returns the result of clamping f to [-1, 1]
        [MI(IL)] public static int4 satsigned(this int4 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(int4)" />
        [MI(IL)] public static int3 satsigned(this int3 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(int4)" />
        [MI(IL)] public static int2 satsigned(this int2 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(int4)" />
        [MI(IL)] public static int satsigned(this int f) => f.clamp(-1, 1);

        #endregion
        
    }
}