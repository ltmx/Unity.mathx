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
        [MI(IL)] public static float4 clampsigned(this float4 f, float4 min, float4 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(float4, float4, float4)"/>
        [MI(IL)] public static float3 clampsigned(this float3 f, float3 min, float3 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(float4, float4, float4)"/>
        [MI(IL)] public static float2 clampsigned(this float2 f, float2 min, float2 max) => min.max(max.min(f));
        ///<inheritdoc cref="clampsigned(float4, float4, float4)"/>
        [MI(IL)] public static float clampsigned(this float f, float min, float max) => min.max(max.min(f));
        
        /// Returns the signed result of clamping of the value x into the interval [a, b]
        [MI(IL)] public static float4 clampsigned(this float4 f, float min, float max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(float4, float, float)"/>
        [MI(IL)] public static float3 clampsigned(this float3 f, float min, float max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(float4, float, float)"/>
        [MI(IL)] public static float2 clampsigned(this float2 f, float min, float max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(float4, float, float)"/>
        [MI(IL)] public static float clampsigned(this int f, float min, float max) => f.abs().clamp(min, max) * math.sign(f);
        /// <inheritdoc cref="clampsigned(float4, float, float)"/>
        [MI(IL)] public static float clampsigned(this float f, int min, int max) => f.abs().clamp(min, max) * math.sign(f);
        
        #endregion
        
        #region MaxSigned
        
        /// Returns the signed componentwise maximum of a f4 and a float value
        [MI(IL)] public static float4 maxsigned(this float4 f, float4 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(float4, float4)"/>
        [MI(IL)] public static float3 maxsigned(this float3 f, float3 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(float4, float4)"/>
        [MI(IL)] public static float2 maxsigned(this float2 f, float2 y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(float4, float4)"/>
        [MI(IL)] public static float maxsigned(this float f, float y) => f.abs().max(y) * math.sign(f);
        /// <inheritdoc cref="maxsigned(float4, float4)"/>
        [MI(IL)] public static float maxsigned(this float f, int y) => f.abs().max(y) * math.sign(f);
        
        /// Returns the signed componentwise maximum of a f4 and a float value
        [MI(IL)] public static float4 maxsigned(this float4 f, float y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f3 and a float value
        [MI(IL)] public static float3 maxsigned(this float3 f, float y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a f2 and a float value
        [MI(IL)] public static float2 maxsigned(this float2 f, float y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a float and a float4
        [MI(IL)] public static float4 maxsigned(this float f, float4 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a float and a float3
        [MI(IL)] public static float3 maxsigned(this float f, float3 y) => f.abs().max(y) * math.sign(f);
        /// Returns the signed componentwise maximum of a float and a float2
        [MI(IL)] public static float2 maxsigned(this float f, float2 y) => f.abs().max(y) * math.sign(f);
        
        #endregion
        
        #region MinSigned
        
        /// Returns the signed componentwise minimum of a f4 and a float value
        [MI(IL)] public static float4 minsigned(this float4 f, float4 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(float4, float4)"/>
        [MI(IL)] public static float3 minsigned(this float3 f, float3 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(float4, float4)"/>
        [MI(IL)] public static float2 minsigned(this float2 f, float2 y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(float4, float4)"/>
        [MI(IL)] public static float minsigned(this float f, float y) => f.abs().min(y) * math.sign(f);
        /// <inheritdoc cref="minsigned(float4, float4)"/>
        [MI(IL)] public static float minsigned(this float f, int y) => f.abs().min(y) * math.sign(f);
        
        /// Returns the signed componentwise minimum of a f4 and a float value
        [MI(IL)] public static float4 minsigned(this float4 f, float y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f3 and a float value
        [MI(IL)] public static float3 minsigned(this float3 f, float y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a f2 and a float value
        [MI(IL)] public static float2 minsigned(this float2 f, float y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a float and a float4
        [MI(IL)] public static float4 minsigned(this float f, float4 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a float and a float3
        [MI(IL)] public static float3 minsigned(this float f, float3 y) => f.abs().min(y) * math.sign(f);
        /// Returns the signed componentwise minimum of a float and a float2
        [MI(IL)] public static float2 minsigned(this float f, float2 y) => f.abs().min(y) * math.sign(f);
        
        #endregion

        #region SaturateSigned

        /// Returns the result of clamping f to [-1, 1]
        [MI(IL)] public static float4 satsigned(this float4 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(float4)" />
        [MI(IL)] public static float3 satsigned(this float3 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(float4)" />
        [MI(IL)] public static float2 satsigned(this float2 f) => f.clamp(-1, 1);
        /// <inheritdoc cref="satsigned(float4)" />
        [MI(IL)] public static float satsigned(this float f) => f.clamp(-1, 1);

        #endregion
        
    }
}