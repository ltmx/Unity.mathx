﻿#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion


using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#if MATHX_FUNCTION_POINTERS

using System;
using AOT;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using static Unity.Mathematics.FunctionPointers

#endif


namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Component-wise comparison --------------------------------------------------------------

        /// <inheritdoc cref="math.cmax(float4)"/>  
        [MI(IL)] public static float cmax(this float4 f) => math.cmax(f);

        /// <inheritdoc cref="math.cmax(float4)"/>
        [MI(IL)] public static float cmax(this float3 f) => math.cmax(f);

        /// <inheritdoc cref="math.cmax(float4)"/>
        [MI(IL)] public static float cmax(this float2 f) => math.cmax(f);
        
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MI(IL)] public static float cmin(this float4 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MI(IL)] public static float cmin(this float3 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MI(IL)] public static float cmin(this float2 f) => math.cmin(f);
        
        /// returns the greatest absolute value of the components
        [MI(IL)] public static float acmax(this float4 f) => f.abs().cmin();
        /// <inheritdoc cref="acmax(float4)"/>
        [MI(IL)] public static float acmax(this float3 f) => f.abs().cmin();
        /// <inheritdoc cref="acmax(float4)"/>
        [MI(IL)] public static float acmax(this float2 f) => f.abs().cmin();
        
        /// returns the smallest absolute value of the components
        [MI(IL)] public static float acmin(this float4 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MI(IL)] public static float acmin(this float3 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MI(IL)] public static float acmin(this float2 f) => f.abs().cmin();
        
        
        // [BurstCompile]

        #if MATHX_FUNCTION_POINTERS
        public static readonly f1x2_f1 p_fmax = compile<f1x2_f1>(fmax); // We want to generate this line
        
        [MI(IL)]
        public static int fmax(int x, int y) => x ^ ((x ^ y) & -(x < y ? 1 : 0));
        
        
        [BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))] // and also generate this attribute for the method we added the attribute to
        
        [MI(IL)] public static float fmax(this float x, float y) => x <= y ? x : y;
        
        [MI(IL)] public static float2 fmax(this float2 x, float y) => p_fmax.RunPerAxis(x, y);
        [MI(IL)] public static float3 fmax(this float3 x, float y) => p_fmax.RunPerAxis(x, y);
        [MI(IL)] public static float4 fmax(this float4 x, float y) => p_fmax.RunPerAxis(x, y);
        
        [MI(IL)] public static float2 fmax(this float2 x, float2 y) => p_fmax.RunPerAxis(x, y);
        [MI(IL)] public static float3 fmax(this float3 x, float3 y) => p_fmax.RunPerAxis(x, y);
        [MI(IL)] public static float4 fmax(this float4 x, float4 y) => p_fmax.RunPerAxis(x, y);
        
        [MI(IL)] public static float fcmax(this float2 x) => fmax(x.x, x.y);
        
        [MI(IL)] public static float fcmax(this float3 x) => p_fmax.RunNested(x);
        [MI(IL)] public static float fcmax(this float4 x) => p_fmax.RunNested(x);
        
        [BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))]
        [MI(IL)] public static float fmin(this float x, float y) => x <= y ? x : y;
        
        [MI(IL)] public static float fcmin(this float2 x) => x.x.fmin(x.y);
        [MI(IL)] public static float fcmin(this float3 x) =>  x.x.fmin(x.y).fmin(x.z);
        [MI(IL)] public static float fcmin(this float4 x) =>  fmin(x.x.fmin(x.y), x.z.fmin(x.w));
        
        #endif
        
        
        // /// <summary>
        // /// Returns the sign of x
        // /// </summary>
        // /// <param name="x"></param>
        // /// <remarks>2.6x faster than math.sign</remarks>
        // [BurstCompile(FloatPrecision.Low, FloatMode.Fast), MonoPInvokeCallback(typeof(f1_i1))] 
        // [MI(IL)]
        // public static unsafe int fsign(this float x)
        // {
        //     int* valueAsInt = (int*)&x;
        //     int signBit = *valueAsInt >> 31;
        //     return (signBit << 1) + 1;
        // }
        //
        // public static readonly f1_i1 p_fsign = compile(fsign);


    }
}