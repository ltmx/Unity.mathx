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

        #region Round
        
        /// <inheritdoc cref="math.round(float4)"/>
        [MI(IL)] public static float4 round(this float4 f) => math.round(f);
        ///<inheritdoc cref="math.round(float3)"/>
        [MI(IL)] public static float3 round(this float3 f) => math.round(f);
        ///<inheritdoc cref="math.round(float3)"/>
        [MI(IL)] public static float2 round(this float2 f) => math.round(f);
        ///<inheritdoc cref="math.round(float3)"/>
        [MI(IL)] public static float round(this float f) => math.round(f);
        
        /// Round to int
        [MI(IL)] public static int4 rint(this float4 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MI(IL)] public static int3 rint(this float3 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MI(IL)] public static int2 rint(this float2 f) => f.round().asint();
        ///<inheritdoc cref="rint(float4)"/>
        [MI(IL)] public static int rint(this float f) => f.round().asint();

        #endregion

        #region Clamp

        // Clamp
        ///<inheritdoc cref="math.clamp(float4, float4, float4)"/>
        [MI(IL)] public static float4 clamp(this float4 f, float4 min, float4 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(float3, float3, float3)"/>
        [MI(IL)] public static float3 clamp(this float3 f, float3 min, float3 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(float2, float2, float2)"/>
        [MI(IL)] public static float2 clamp(this float2 f, float2 min, float2 max) => min.max(max.min(f));
        ///<inheritdoc cref="math.clamp(float, float, float)"/>
        [MI(IL)] public static float clamp(this float f, float min, float max) => min.max(max.min(f));
        

        /// Returns the result of clamping of the value x into the interval [a, b]
        [MI(IL)] public static float4 clamp(this float4 f, float min, float max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(float4, float, float)"/>
        [MI(IL)] public static float3 clamp(this float3 f, float min, float max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(float4, float, float)"/>
        [MI(IL)] public static float2 clamp(this float2 f, float min, float max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(float4, float, float)"/>
        [MI(IL)] public static float clamp(this int f, float min, float max) => min.max(max.min(f));
        /// <inheritdoc cref="clamp(float4, float, float)"/>
        [MI(IL)] public static float clamp(this float f, int min, int max) => math.max(min, math.min(f, max));

        #endregion

        #region Min

        /// <inheritdoc cref="math.min(float4,float4)"/>
        [MI(IL)] public static float4 min(this float4 f, float4 y) => math.min(f, y);
        /// <inheritdoc cref="math.min(float3,float3)"/>
        [MI(IL)] public static float3 min(this float3 f, float3 y) => math.min(f, y);
        /// <inheritdoc cref="math.min(float2,float2)"/>
        [MI(IL)] public static float2 min(this float2 f, float2 y) => math.min(f, y);
        /// <inheritdoc cref="math.min(float,float)"/>
        [MI(IL)] public static float min(this float f, float y) => math.min(f, y);
        /// <inheritdoc cref="math.min(float,float)"/>
        [MI(IL)] public static float min(this float f, int y) => math.min(f, y);
                
        /// Returns the componentwise minimum of a f4 and a float value
        [MI(IL)] public static float4 min(this float4 f, float y) => math.min(f, y);
        /// Returns the componentwise minimum of a f3 and a float value
        [MI(IL)] public static float3 min(this float3 f, float y) => math.min(f, y);
        /// Returns the componentwise minimum of a f2 and a float value
        [MI(IL)] public static float2 min(this float2 f, float y) => math.min(f, y);
        /// Returns the componentwise minimum of a f4 and a float value
        [MI(IL)] public static float4 min(this float f, float4 y) => math.min(f, y);
        /// Returns the componentwise minimum of a f3 and a float value
        [MI(IL)] public static float3 min(this float f, float3 y) => math.min(f, y);
        /// Returns the componentwise minimum of a f2 and a float value
        [MI(IL)] public static float2 min(this float f, float2 y) => math.min(f, y);
        
        #endregion

        
        #region Max

        /// <inheritdoc cref="math.max(float4, float4)"/>
        [MI(IL)] public static float4 max(this float4 f, float4 y) => math.max(f, y);
        /// <inheritdoc cref="math.max(float3, float3)"/>
        [MI(IL)] public static float3 max(this float3 f, float3 y) => math.max(f, y);
        /// <inheritdoc cref="math.max(float2, float2)"/>
        [MI(IL)] public static float2 max(this float2 f, float2 y) => math.max(f, y);
        /// <inheritdoc cref="math.max(float, float)"/>
        [MI(IL)] public static float max(this float f, float y) => math.max(f, y);
        /// <inheritdoc cref="math.max(float, float)"/>
        [MI(IL)] public static float max(this float f, int y) => math.max(f, y);
        
        /// Returns the componentwise maximum of a f4 and a float value
        [MI(IL)] public static float4 max(this float4 f, float y) => math.max(f, y);
        /// Returns the componentwise maximum of a f3 and a float value
        [MI(IL)] public static float3 max(this float3 f, float y) => math.max(f, y);
        /// Returns the componentwise maximum of a f2 and a float value
        [MI(IL)] public static float2 max(this float2 f, float y) => math.max(f, y);
        /// Returns the componentwise maximum of a f4 and a float value
        [MI(IL)] public static float4 max(this float f, float4 y) => math.max(f, y);
        /// Returns the componentwise maximum of a f3 and a float value
        [MI(IL)] public static float3 max(this float f, float3 y) => math.max(f, y);
        /// Returns the componentwise maximum of a f2 and a float value
        [MI(IL)] public static float2 max(this float f, float2 y) => math.max(f, y);
        
        #endregion
        
        

        #region Ceil

        /// <inheritdoc cref="math.ceil(float4)"/>
        [MI(IL)] public static float4 ceil(this float4 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(float3)"/>
        [MI(IL)] public static float3 ceil(this float3 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(Mathematics.float2)"/>
        [MI(IL)] public static float2 ceil(this float2 f) => math.ceil(f);
        /// <inheritdoc cref="math.ceil(float)"/>
        [MI(IL)] public static float ceil(this float f) => math.ceil(f);


        #endregion

        #region CeilToInt

        /// Ceil to int
        [MI(IL)] public static int4 clint(this float4 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(float4)" />
        [MI(IL)] public static int3 clint(this float3 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(float4)" />
        [MI(IL)] public static int2 clint(this float2 f) => f.ceil().asint();
        /// <inheritdoc cref="clint(float4)" />
        [MI(IL)] public static int clint(this float f) => f.ceil().asint();

        #endregion
        
        #region Floor
        
        /// <inheritdoc cref="math.floor(float4)" />
        [MI(IL)] public static float4 floor(this float4 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(float3)" />
        [MI(IL)] public static float3 floor(this float3 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(Mathematics.float2)" />
        [MI(IL)] public static float2 floor(this float2 f) => math.floor(f);
        /// <inheritdoc cref="math.floor(float)" />
        [MI(IL)] public static float floor(this float f) => math.floor(f);

        #endregion
        
        #region Floor To Int

        /// Floor To Int
        [MI(IL)] public static int4 flint(this float4 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MI(IL)] public static int3 flint(this float3 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MI(IL)] public static int2 flint(this float2 f) => f.greater(0).select(f, f + 1).asint();
        /// <inheritdoc cref="flint(float4)" />
        [MI(IL)] public static int flint(this float f) => f.greater(0).select(f, f + 1).asint();
        

        #endregion

        #region Saturate

        /// <inheritdoc cref="sat(Unity.Mathematics.float4)" />
        [MI(IL)] public static float4 sat(this float4 f) => math.saturate(f);
        /// <inheritdoc cref="sat(Unity.Mathematics.float3)" />
        [MI(IL)] public static float3 sat(this float3 f) => math.saturate(f);
        /// <inheritdoc cref="sat(Unity.Mathematics.float2)" />
        [MI(IL)] public static float2 sat(this float2 f) => math.saturate(f);
        /// <inheritdoc cref="sat(float)" />
        [MI(IL)] public static float sat(this float f) => math.saturate(f);

        #endregion
        
        /// Same as max(f, 0); It can be useful to prevent negative values in some cases
        /// returns 0 if f is negative, otherwise returns f
        [MI(IL)] public static float4 limp(this float4 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MI(IL)] public static float3 limp(this float3 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MI(IL)] public static float2 limp(this float2 f) => f.max(0);
        /// <inheritdoc cref="limp(float4)" />
        [MI(IL)] public static float limp(this float f) => f.max(0);
        
        
        /// Short for min(f, 0);
        /// returns 0 if f is positive, otherwise returns f
        [MI(IL)] public static float4 limn(this float4 f) => f.min(0);
        /// <inheritdoc cref="limn(float)" />
        [MI(IL)] public static float3 limn(this float3 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MI(IL)] public static float2 limn(this float2 f) => f.min(0);
        /// <inheritdoc cref="limn(float4)" />
        [MI(IL)] public static float limn(this float f) => f.min(0);

        
        /// Short for min(f, 1);
        /// Clamps values over 1 to 1;
        [MI(IL)] public static float4 under1(this float4 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MI(IL)] public static float3 under1(this float3 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MI(IL)] public static float2 under1(this float2 f) => f.min(1);
        /// <inheritdoc cref="under1(float4)" />
        [MI(IL)] public static float under1(this float f) => f.min(1);

    }
}