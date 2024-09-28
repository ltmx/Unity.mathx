#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using UnityEngine;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        #region exp

        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float4 exp(this float4 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float3 exp(this float3 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float2 exp(this float2 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float exp(this float f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float exp(this int f) => math.exp(f);
        
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float4 exp(this Vector4 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float3 exp(this Vector3 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static float2 exp(this Vector2 f) => math.exp(f);

        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static double4 exp(this double4 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static double3 exp(this double3 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static double2 exp(this double2 f) => math.exp(f);
        /// <inheritdoc cref="math.exp(float4)"/>
        [MI(IL)] public static double exp(this double f) => math.exp(f);

        #endregion

        #region nexp

        /// exp(-x) => The exponential function e raised to the power of negative x.
        [MI(IL)] public static float4 nexp(this float4 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float3 nexp(this float3 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float2 nexp(this float2 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float nexp(this float f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float nexp(this int f) => math.exp(-f);
        
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float4 nexp(this Vector4 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float3 nexp(this Vector3 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static float2 nexp(this Vector2 f) => math.exp(-f);

        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static double4 nexp(this double4 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static double3 nexp(this double3 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static double2 nexp(this double2 f) => math.exp(-f);
        /// <inheritdoc cref="nexp(float4)"/>
        [MI(IL)] public static double nexp(this double f) => math.exp(-f);

        #endregion
        

        #region exp2

        /// <inheritdoc cref="math.exp2(float4)"/>
        [MI(IL)] public static float4 exp2(this float4 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float3 exp2(this float3 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float2 exp2(this float2 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float exp2(this float f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float exp2(this int f) => math.exp2(f);
        
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float4 exp2(this Vector4 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float3 exp2(this Vector3 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static float2 exp2(this Vector2 f) => math.exp2(f);

        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static double4 exp2(this double4 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static double3 exp2(this double3 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static double2 exp2(this double2 f) => math.exp2(f);
        /// <inheritdoc cref="exp2(float4)"/>
        [MI(IL)] public static double exp2(this double f) => math.exp2(f);

        #endregion

        #region exp10

        /// <inheritdoc cref="math.exp10(float4)"/>
        [MI(IL)] public static float4 exp10(this float4 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float3 exp10(this float3 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float2 exp10(this float2 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float exp10(this float f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float exp10(this int f) => math.exp10(f);
        
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float4 exp10(this Vector4 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float3 exp10(this Vector3 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static float2 exp10(this Vector2 f) => math.exp10(f);
        
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static double4 exp10(this double4 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static double3 exp10(this double3 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static double2 exp10(this double2 f) => math.exp10(f);
        /// <inheritdoc cref="exp10(float4)"/>
        [MI(IL)] public static double exp10(this double f) => math.exp10(f);

        #endregion

        // Logarithms -----------------------------------------------

        #region ln

        /// Natural Logarithm renamed to "ln", to avoid confusion in the scientific community
        [MI(IL)] public static float4 ln(this float4 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float3 ln(this float3 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float2 ln(this float2 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float ln(this float f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float ln(this int f) => math.log(f);
        
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float4 ln(this Vector4 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float3 ln(this Vector3 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static float2 ln(this Vector2 f) => math.log(f);

        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static double4 ln(this double4 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static double3 ln(this double3 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static double2 ln(this double2 f) => math.log(f);
        /// <inheritdoc cref="ln(float4)"/>
        [MI(IL)] public static double ln(this double f) => math.log(f);

        #endregion

        #region log2

        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float4 log2(this float4 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float3 log2(this float3 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float2 log2(this float2 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float log2(this float f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float log2(this int f) => math.log2(f);
        
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float4 log2(this Vector4 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float3 log2(this Vector3 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static float2 log2(this Vector2 f) => math.log2(f);

        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static double4 log2(this double4 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static double3 log2(this double3 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static double2 log2(this double2 f) => math.log2(f);
        /// <iheritdoc cref="math.log2(float4)"/>
        [MI(IL)] public static double log2(this double f) => math.log2(f);

        #endregion

        #region log10

        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float4 log10(this float4 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float3 log10(this float3 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float2 log10(this float2 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float log10(this float f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float log10(this int f) => math.log10(f);
        
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float4 log10(this Vector4 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float3 log10(this Vector3 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static float2 log10(this Vector2 f) => math.log10(f);
        
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static double4 log10(this double4 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static double3 log10(this double3 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static double2 log10(this double2 f) => math.log10(f);
        /// <iheritdoc cref="math.log10(float4)"/>
        [MI(IL)] public static double log10(this double f) => math.log10(f);

        #endregion
    }
}