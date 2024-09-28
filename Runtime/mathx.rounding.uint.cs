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
        ///<inheritdoc cref="math.clamp(uint4, uint4, uint4)"/>
        [MI(IL)] public static uint4 clamp(this uint4 f, uint4 min, uint4 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(uint3, uint3, uint3)"/>
        [MI(IL)] public static uint3 clamp(this uint3 f, uint3 min, uint3 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(uint2, uint2, uint2)"/>
        [MI(IL)] public static uint2 clamp(this uint2 f, uint2 min, uint2 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(uint, uint, uint)"/>
        [MI(IL)] public static uint clamp(this uint f, uint min, uint max) => min.max(max.min(f));
        

        /// Returns the result of clamping of the value x uinto the uinterval [a, b]
        [MI(IL)] public static uint4 clamp(this uint4 f, uint min, uint max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(uint4, uint, uint)"/>
        [MI(IL)] public static uint3 clamp(this uint3 f, uint min, uint max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(uint4, uint, uint)"/>
        [MI(IL)] public static uint2 clamp(this uint2 f, uint min, uint max) => min.max(max.min(f));


        /// <inheritdoc cref="math.min(uint4,uint4)"/>
        [MI(IL)] public static uint4 min(this uint4 f, uint4 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(uint3,uint3)"/>
        [MI(IL)] public static uint3 min(this uint3 f, uint3 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(uint2,uint2)"/>
        [MI(IL)] public static uint2 min(this uint2 f, uint2 min) => math.min(f, min);
        /// <inheritdoc cref="math.min(uint,uint)"/>
        [MI(IL)] public static uint min(this uint f, uint y) => math.min(f, y);
        
        /// <inheritdoc cref="math.min(uint,uint)"/>
        [MI(IL)] public static float min(this uint f, float y) => math.min(f, y);


        #region Max

        /// <inheritdoc cref="math.max(uint4, uint4)"/>
        [MI(IL)] public static uint4 max(this uint4 f, uint4 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(uint3, uint3)"/>
        [MI(IL)] public static uint3 max(this uint3 f, uint3 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(Mathematics.uint2, Mathematics.uint2)"/>
        [MI(IL)] public static uint2 max(this uint2 f, uint2 max) => math.max(f, max);
        /// <inheritdoc cref="math.max(uint, uint)"/>
        [MI(IL)] public static uint max(this uint f, uint y) => math.max(f, y);
        /// <inheritdoc cref="math.max(uint, uint)"/>
        [MI(IL)] public static float max(this uint f, float y) => math.max(f, y);


        /// Returns the componentwise maximum of a f4 and a uint value
        [MI(IL)] public static uint4 max(this uint4 x, uint y) => new (max(x.x, y), max(x.y, y), max(x.z, y), max(x.w, y));
        /// Returns the componentwise maximum of a f3 and a uint value
        [MI(IL)] public static uint3 max(this uint3 x, uint y) => new (max(x.x, y), max(x.y, y), max(x.z, y));
        /// Returns the componentwise maximum of a f2 and a uint value
        [MI(IL)] public static uint2 max(this uint2 x, uint y) => new (max(x.x, y), max(x.y, y));
        /// Returns the componentwise maximum of a f4 and a uint value
        [MI(IL)] public static uint4 max(this uint x, uint4 y) => new (max(x, y.x), max(x, y.y), max(x, y.z), max(x, y.w));
        /// Returns the componentwise maximum of a f3 and a uint value
        [MI(IL)] public static uint3 max(this uint x, uint3 y) => new (max(x, y.x), max(x, y.y), max(x, y.z));
        /// Returns the componentwise maximum of a f2 and a uint value
        [MI(IL)] public static uint2 max(this uint x, uint2 y) => new (max(x, y.x), max(x, y.y));
        
        /// Returns the componentwise minimum of a f4 and a uint value
        [MI(IL)] public static uint4 min(this uint4 x, uint y) => new (min(x.x, y), min(x.y, y), min(x.z, y), min(x.w, y));
        /// Returns the componentwise minimum of a f3 and a uint value
        [MI(IL)] public static uint3 min(this uint3 x, uint y) => new (min(x.x, y), min(x.y, y), min(x.z, y));
        /// Returns the componentwise minimum of a f2 and a uint value
        [MI(IL)] public static uint2 min(this uint2 x, uint y) => new (min(x.x, y), min(x.y, y));
        /// Returns the componentwise minimum of a f4 and a uint value
        [MI(IL)] public static uint4 min(this uint x, uint4 y) => new (min(x, y.x), min(x, y.y), min(x, y.z), min(x, y.w));
        /// Returns the componentwise minimum of a f3 and a uint value
        [MI(IL)] public static uint3 min(this uint x, uint3 y) => new (min(x, y.x), min(x, y.y), min(x, y.z));
        /// Returns the componentwise minimum of a f2 and a uint value
        [MI(IL)] public static uint2 min(this uint x, uint2 y) => new (min(x, y.x), min(x, y.y));

        #endregion
        
        
        #region Ceil
        
        
        #endregion


        #region CeilTouint
        

        #endregion
        
        #region Floor
        

        #endregion
        
        #region Floor To uint
        
        
        #endregion

        #region Saturate

        #endregion

        
        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MI(IL)] public static uint4 limp(this uint4 f) => f.max(0);
        /// <inheritdoc cref="limp(uint4)" />
        [MI(IL)] public static uint3 limp(this uint3 f) => f.max(0);
        /// <inheritdoc cref="limp(uint4)" />
        [MI(IL)] public static uint2 limp(this uint2 f) => f.max(0);
        /// <inheritdoc cref="limp(uint4)" />
        [MI(IL)] public static uint limp(this uint f) => f.max(0);
        
        
        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MI(IL)] public static uint4 limn(this uint4 f) => f.min(0);
        /// <inheritdoc cref="limn(uint)" />
        [MI(IL)] public static uint3 limn(this uint3 f) => f.min(0);
        /// <inheritdoc cref="limn(uint4)" />
        [MI(IL)] public static uint2 limn(this uint2 f) => f.min(0);
        /// <inheritdoc cref="limn(uint4)" />
        [MI(IL)] public static uint limn(this uint f) => f.min(0);

        
        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MI(IL)] public static uint4 under1(this uint4 f) => f.min(1);
        /// <inheritdoc cref="under1(uint4)" />
        [MI(IL)] public static uint3 under1(this uint3 f) => f.min(1);
        /// <inheritdoc cref="under1(uint4)" />
        [MI(IL)] public static uint2 under1(this uint2 f) => f.min(1);
        /// <inheritdoc cref="under1(uint4)" />
        [MI(IL)] public static uint under1(this uint f) => f.min(1);

    }
}