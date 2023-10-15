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
        // Component-wise comparison --------------------------------------------------------------

        /// <inheritdoc cref="math.cmax(float4)"/>  
        [MethodImpl(IL)] public static float cmax(this float4 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(float4)"/>
        [MethodImpl(IL)] public static float cmax(this float3 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(float4)"/>
        [MethodImpl(IL)] public static float cmax(this float2 f) => math.cmax(f);
        
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float4 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float3 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float2 f) => math.cmin(f);
        
        /// returns the greatest absolute value of the components
        [MethodImpl(IL)] public static float acmax(this float4 f) => f.abs().cmax();
        /// <inheritdoc cref="acmax(float4)"/>
        [MethodImpl(IL)] public static float acmax(this float3 f) => f.abs().cmax();
        /// <inheritdoc cref="acmax(float4)"/>
        [MethodImpl(IL)] public static float acmax(this float2 f) => f.abs().cmax();
        
        /// returns the smallest absolute value of the components
        [MethodImpl(IL)] public static float acmin(this float4 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MethodImpl(IL)] public static float acmin(this float3 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MethodImpl(IL)] public static float acmin(this float2 f) => f.abs().cmin();
        


    }
}