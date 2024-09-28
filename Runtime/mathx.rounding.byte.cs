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

        // Round


        // Clamp
        ///<inheritdoc cref="math.clamp(int4, int4, int4)"/>
        [MI(IL)] public static byte4 clamp(this byte4 f, byte4 min, byte4 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int3, int3, int3)"/>
        [MI(IL)] public static byte3 clamp(this byte3 f, byte3 min, byte3 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int2, int2, int2)"/>
        [MI(IL)] public static byte2 clamp(this byte2 f, byte2 min, byte2 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int, int, int)"/>
        [MI(IL)] public static byte clamp(this byte f, byte min, byte max) => min.max(max.min(f));
        

        /// Returns the result of clamping of the value x into the interval [a, b]
        [MI(IL)] public static byte4 clamp(this byte4 f, byte min, byte max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(int4, int, int)"/>
        [MI(IL)] public static byte3 clamp(this byte3 f, byte min, byte max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(int4, int, int)"/>
        [MI(IL)] public static byte2 clamp(this byte2 f, byte min, byte max) => min.max(max.min(f));


        /// <inheritdoc cref="min(int4,int4)"/>
        [MI(IL)] public static byte4 min(this byte4 f, byte4 m) => new(min(f.x, m.x), min(f.y, m.y), min(f.z, m.z), min(f.w, m.w));
        /// <inheritdoc cref="min(int3,int3)"/>
        [MI(IL)] public static byte3 min(this byte3 f, byte3 m) => new(min(f.x, m.x), min(f.y, m.y), min(f.z, m.z));
        /// <inheritdoc cref="min(int2,int2)"/>
        [MI(IL)] public static byte2 min(this byte2 f, byte2 m) => new(f.x.min(m.x), min(f.y, m.y));
        /// <inheritdoc cref="min(int,int)"/>
        [MI(IL)] public static byte min(this byte f, byte m) => f < m ? f : m;


        #region Max

        /// <inheritdoc cref="math.max(int4, Mathematics.int4)"/>
        [MI(IL)] public static byte4 max(this byte4 f, byte4 m) => new(max(f.x, m.x), max(f.y, m.y), max(f.z, m.z), max(f.w, m.w));
        /// <inheritdoc cref="math.max(int4, Mathematics.int4)"/>
        [MI(IL)] public static byte3 max(this byte3 f, byte3 m) => new(max(f.x, m.x), max(f.y, m.y), max(f.z, m.z));
        /// <inheritdoc cref="math.max(int2, Mathematics.int2)"/>
        [MI(IL)] public static byte2 max(this byte2 f, byte2 m) => new(f.x.max(m.x), max(f.y, m.y));
        /// <inheritdoc cref="math.max(int, int)"/>
        [MI(IL)] public static byte max(this byte f, byte max) => f > max ? f : max;

        /// Returns the componentwise maximum of a f4 and a byte value
        [MI(IL)] public static byte4 max(this byte4 x, byte y) => new (max(x.x, y), max(x.y, y), max(x.z, y), max(x.w, y));
        /// Returns the componentwise maximum of a f3 and a byte value
        [MI(IL)] public static byte3 max(this byte3 x, byte y) => new (max(x.x, y), max(x.y, y), max(x.z, y));
        /// Returns the componentwise maximum of a f2 and a byte value
        [MI(IL)] public static byte2 max(this byte2 x, byte y) => new (max(x.x, y), max(x.y, y));
        /// Returns the componentwise maximum of a f4 and a byte value
        [MI(IL)] public static byte4 max(this byte x, byte4 m) => new (max(x, m.x), max(x, m.y), max(x, m.z), max(x, m.w));
        /// Returns the componentwise maximum of a f3 and a byte value
        [MI(IL)] public static byte3 max(this byte x, byte3 m) => new (max(x, m.x), max(x, m.y), max(x, m.z));
        /// Returns the componentwise maximum of a f2 and a byte value
        [MI(IL)] public static byte2 max(this byte x, byte2 m) => new (max(x, m.x), max(x, m.y));
        
        /// Returns the componentwise minimum of a f4 and a byte value
        [MI(IL)] public static byte4 min(this byte4 x, byte y) => new (min(x.x, y), min(x.y, y), min(x.z, y), min(x.w, y));
        /// Returns the componentwise minimum of a f3 and a byte value
        [MI(IL)] public static byte3 min(this byte3 x, byte y) => new (min(x.x, y), min(x.y, y), min(x.z, y));
        /// Returns the componentwise minimum of a f2 and a byte value
        [MI(IL)] public static byte2 min(this byte2 x, byte y) => new (min(x.x, y), min(x.y, y));
        /// Returns the componentwise minimum of a f4 and a byte value
        [MI(IL)] public static byte4 min(this byte x, byte4 y) => new (min(x, y.x), min(x, y.y), min(x, y.z), min(x, y.w));
        /// Returns the componentwise minimum of a f3 and a byte value
        [MI(IL)] public static byte3 min(this byte x, byte3 y) => new (min(x, y.x), min(x, y.y), min(x, y.z));
        /// Returns the componentwise minimum of a f2 and a byte value
        [MI(IL)] public static byte2 min(this byte x, byte2 y) => new (min(x, y.x), min(x, y.y));

        #endregion

    }
}