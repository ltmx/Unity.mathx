#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;
using AOT;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Component-wise comparison --------------------------------------------------------------

        /// <inheritdoc cref="math.cmax(float4)"/>  
        [MethodImpl(IL)] public static float cmax(this float4 f) => f.xy.fmax(f.zw).cmax();

        /// <inheritdoc cref="math.cmax(float4)"/>
        [MethodImpl(IL)] public static float cmax(this float3 f) => f.x.max(f.y).max(f.z);

        /// <inheritdoc cref="math.cmax(float4)"/>
        [MethodImpl(IL)] public static float cmax(this float2 f) => f.x.max(f.y);
        
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float4 f) => fcmin(f);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float3 f) => f.x.min(f.y).min(f.z);
        /// <inheritdoc cref="math.cmin(float4)"/>
        [MethodImpl(IL)] public static float cmin(this float2 f) => fcmin(f);
        
        /// returns the greatest absolute value of the components
        [MethodImpl(IL)] public static float acmax(this float4 f) => f.abs().fcmin();
        /// <inheritdoc cref="acmax(float4)"/>
        [MethodImpl(IL)] public static float acmax(this float3 f) => f.abs().fcmin();
        /// <inheritdoc cref="acmax(float4)"/>
        [MethodImpl(IL)] public static float acmax(this float2 f) => f.abs().fcmin();
        
        /// returns the smallest absolute value of the components
        [MethodImpl(IL)] public static float acmin(this float4 f) => f.abs().fcmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MethodImpl(IL)] public static float acmin(this float3 f) => f.abs().fcmin();
        /// <inheritdoc cref="acmin(float4)"/>
        [MethodImpl(IL)] public static float acmin(this float2 f) => f.abs().fcmin();
        
        
        // [BurstCompile]

        
        public static readonly f1x2_f1 p_fmax = compile<f1x2_f1>(fmax); // We want to generate this line
        
        [MethodImpl(IL)]
        public static int fmax(int x, int y) => x ^ ((x ^ y) & -(x < y ? 1 : 0));
        
        [BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))] // and also generate this attribute for the method we added the attribute to
        [MethodImpl(IL)] public static float fmax(this float x, float y) => x <= y ? x : y;
        
        [MethodImpl(IL)] public static float2 fmax(this float2 x, float y) => p_fmax.RunPerAxis(x, y);
        [MethodImpl(IL)] public static float3 fmax(this float3 x, float y) => p_fmax.RunPerAxis(x, y);
        [MethodImpl(IL)] public static float4 fmax(this float4 x, float y) => p_fmax.RunPerAxis(x, y);
        
        [MethodImpl(IL)] public static float2 fmax(this float2 x, float2 y) => p_fmax.RunPerAxis(x, y);
        [MethodImpl(IL)] public static float3 fmax(this float3 x, float3 y) => p_fmax.RunPerAxis(x, y);
        [MethodImpl(IL)] public static float4 fmax(this float4 x, float4 y) => p_fmax.RunPerAxis(x, y);
        
        [MethodImpl(IL)] public static float fcmax(this float2 x) => fmax(x.x, x.y);
        [MethodImpl(IL)] public static float fcmax(this float3 x) => p_fmax.RunNested(x);
        [MethodImpl(IL)] public static float fcmax(this float4 x) => p_fmax.RunNested(x);
        
        [BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))]
        [MethodImpl(IL)] public static float fmin(this float x, float y) => x <= y ? x : y;
        
        [MethodImpl(IL)] public static float fcmin(this float2 x) => x.x.fmin(x.y);
        [MethodImpl(IL)] public static float fcmin(this float3 x) =>  x.x.fmin(x.y).fmin(x.z);
        [MethodImpl(IL)] public static float fcmin(this float4 x) =>  fmin(x.x.fmin(x.y), x.z.fmin(x.w));
        
        
        // /// <summary>
        // /// Returns the sign of x
        // /// </summary>
        // /// <param name="x"></param>
        // /// <remarks>2.6x faster than math.sign</remarks>
        // [BurstCompile(FloatPrecision.Low, FloatMode.Fast), MonoPInvokeCallback(typeof(f1_i1))] 
        // [MethodImpl(IL)]
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