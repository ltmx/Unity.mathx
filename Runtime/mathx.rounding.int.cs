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
        [MI(IL)] public static int4 clamp(this int4 f, int4 min, int4 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int3, int3, int3)"/>
        [MI(IL)] public static int3 clamp(this int3 f, int3 min, int3 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int2, int2, int2)"/>
        [MI(IL)] public static int2 clamp(this int2 f, int2 min, int2 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(int, int, int)"/>
        [MI(IL)] public static int clamp(this int f, int min, int max) => min.max(max.min(f));
        

        /// Returns the result of clamping of the value x into the interval [a, b]
        [MI(IL)] public static int4 clamp(this int4 f, int min, int max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(int4, int, int)"/>
        [MI(IL)] public static int3 clamp(this int3 f, int min, int max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(int4, int, int)"/>
        [MI(IL)] public static int2 clamp(this int2 f, int min, int max) => min.max(max.min(f));


        /// <inheritdoc cref="math.min(int4,int4)"/>
        [MI(IL)] public static int4 min(this int4 f, int4 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(int3,int3)"/>
        [MI(IL)] public static int3 min(this int3 f, int3 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(int2,int2)"/>
        [MI(IL)] public static int2 min(this int2 f, int2 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(int,int)"/>
        [MI(IL)] public static int min(this int f, int y) => math.min(f, y);
        
        /// <inheritdoc cref="math.min(int,int)"/>
        [MI(IL)] public static float min(this int f, float y) => math.min(f, y);


        #region Max

        /// <inheritdoc cref="math.max(int4, int4)"/>
        [MI(IL)] public static int4 max(this int4 f, int4 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(int3, int3)"/>
        [MI(IL)] public static int3 max(this int3 f, int3 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(Mathematics.int2, Mathematics.int2)"/>
        [MI(IL)] public static int2 max(this int2 f, int2 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(int, int)"/>
        [MI(IL)] public static int max(this int f, int y) => math.max(f, y);
        /// <inheritdoc cref="math.max(int, int)"/>
        [MI(IL)] public static float max(this int f, float y) => math.max(f, y);


        /// Returns the componentwise maximum of a f4 and a int value
        [MI(IL)] public static int4 max(this int4 x, int y) => new (max(x.x, y), max(x.y, y), max(x.z, y), max(x.w, y));
        /// Returns the componentwise maximum of a f3 and a int value
        [MI(IL)] public static int3 max(this int3 x, int y) => new (max(x.x, y), max(x.y, y), max(x.z, y));
        /// Returns the componentwise maximum of a f2 and a int value
        [MI(IL)] public static int2 max(this int2 x, int y) => new (max(x.x, y), max(x.y, y));
        /// Returns the componentwise maximum of a f4 and a int value
        [MI(IL)] public static int4 max(this int x, int4 y) => new (max(x, y.x), max(x, y.y), max(x, y.z), max(x, y.w));
        /// Returns the componentwise maximum of a f3 and a int value
        [MI(IL)] public static int3 max(this int x, int3 y) => new (max(x, y.x), max(x, y.y), max(x, y.z));
        /// Returns the componentwise maximum of a f2 and a int value
        [MI(IL)] public static int2 max(this int x, int2 y) => new (max(x, y.x), max(x, y.y));
        
        /// Returns the componentwise minimum of a f4 and a int value
        [MI(IL)] public static int4 min(this int4 x, int y) => new (min(x.x, y), min(x.y, y), min(x.z, y), min(x.w, y));
        /// Returns the componentwise minimum of a f3 and a int value
        [MI(IL)] public static int3 min(this int3 x, int y) => new (min(x.x, y), min(x.y, y), min(x.z, y));
        /// Returns the componentwise minimum of a f2 and a int value
        [MI(IL)] public static int2 min(this int2 x, int y) => new (min(x.x, y), min(x.y, y));
        /// Returns the componentwise minimum of a f4 and a int value
        [MI(IL)] public static int4 min(this int x, int4 y) => new (min(x, y.x), min(x, y.y), min(x, y.z), min(x, y.w));
        /// Returns the componentwise minimum of a f3 and a int value
        [MI(IL)] public static int3 min(this int x, int3 y) => new (min(x, y.x), min(x, y.y), min(x, y.z));
        /// Returns the componentwise minimum of a f2 and a int value
        [MI(IL)] public static int2 min(this int x, int2 y) => new (min(x, y.x), min(x, y.y));

        #endregion
        
        
        #region Ceil
        
        
        #endregion


        #region CeilToInt
        

        #endregion
        
        #region Floor
        

        #endregion
        
        #region Floor To Int
        
        
        #endregion

        #region Saturate

        #endregion

        
        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MI(IL)] public static int4 limp(this int4 f) => f.max(0);
        /// <inheritdoc cref="limp(int4)" />
        [MI(IL)] public static int3 limp(this int3 f) => f.max(0);
        /// <inheritdoc cref="limp(int4)" />
        [MI(IL)] public static int2 limp(this int2 f) => f.max(0);
        /// <inheritdoc cref="limp(int4)" />
        [MI(IL)] public static int limp(this int f) => f.max(0);
        
        
        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MI(IL)] public static int4 limn(this int4 f) => f.min(0);
        /// <inheritdoc cref="limn(int)" />
        [MI(IL)] public static int3 limn(this int3 f) => f.min(0);
        /// <inheritdoc cref="limn(int4)" />
        [MI(IL)] public static int2 limn(this int2 f) => f.min(0);
        /// <inheritdoc cref="limn(int4)" />
        [MI(IL)] public static int limn(this int f) => f.min(0);

        
        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MI(IL)] public static int4 under1(this int4 f) => f.min(1);
        /// <inheritdoc cref="under1(int4)" />
        [MI(IL)] public static int3 under1(this int3 f) => f.min(1);
        /// <inheritdoc cref="under1(int4)" />
        [MI(IL)] public static int2 under1(this int2 f) => f.min(1);
        /// <inheritdoc cref="under1(int4)" />
        [MI(IL)] public static int under1(this int f) => f.min(1);

    }
}