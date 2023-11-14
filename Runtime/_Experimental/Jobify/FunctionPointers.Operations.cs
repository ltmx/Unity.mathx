#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using static Unity.Mathematics.FunctionPointers.Signature;
using static Unity.Mathematics.mathx;
using fx = Unity.Mathematics.float4;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        [MethodImpl(IL)] public static float4 RunPerAxis(this f1x2_f1 fn, float4 a, float4 b) => new(fn(a.x, b.x), fn(a.y, b.y), fn(a.z, b.z), fn(a.w, b.w));
        [MethodImpl(IL)] public static float3 RunPerAxis(this f1x2_f1 fn, float3 a, float3 b) => new(fn(a.x, b.x), fn(a.y, b.y), fn(a.z, b.z));
        [MethodImpl(IL)] public static float2 RunPerAxis(this f1x2_f1 fn, float2 a, float2 b) => new(fn(a.x, b.x), fn(a.y, b.y));

        // for cmin, cmax, cmul, csum
        [MethodImpl(IL)] public static float RunNested(this f1x2_f1 func, float4 a) => func(func(func(a.x, a.y), a.z), a.w);
        [MethodImpl(IL)] public static float RunNested(this f1x2_f1 func, float3 a) => func(func(a.x, a.y), a.z);
        
        [MethodImpl(IL)] public static float4 RunPerAxis(this f1x2_f1 fn, float4 a, float b) => new(fn(a.x, b), fn(a.y, b), fn(a.z, b), fn(a.w, b));
        [MethodImpl(IL)] public static float3 RunPerAxis(this f1x2_f1 fn, float3 a, float b) => new(fn(a.x, b), fn(a.y, b), fn(a.z, b));
        [MethodImpl(IL)] public static float2 RunPerAxis(this f1x2_f1 fn, float2 a, float b) => new(fn(a.x, b), fn(a.y, b));
        // [MethodImpl(IL)] public static float Run(this f1x2_f1 fn, float a, float b) => fn(a, b);
        // [MethodImpl(IL)] public static float Run(this f1_f1 fn, float a) => fn(a);
        [MethodImpl(IL)] public  static float2 RunPerAxis(this f1_f1 func, float2 a) => new(func(a.x), func(a.y));
        [MethodImpl(IL)] public static float3 RunPerAxis(this f1_f1 func, float3 a) => new(func(a.x), func(a.y), func(a.z));
        [MethodImpl(IL)] public static float4 RunPerAxis(this f1_f1 func, float4 a) => new(func(a.x), func(a.y), func(a.z), func(a.w));
        // [MethodImpl(IL)] public static float3 RunPerAxis(this f1_i1 fn, float3 a) => new(fn(a.x), fn(a.y), fn(a.z));
        [MethodImpl(IL)] public static int3 RunPerAxis(this f1_i1 func, float3 a) => new(func(a.x), func(a.y), func(a.z));
        
        
        // For lerp, unlerp, eerp, uneerp, smoothstep, smin, etc....
        // for mathx.interpolation.common
        // [MethodImpl(IL)] public static float4 ParallelAndParam(this f1x3_f1 fn, float4 a, float4 b, float t) => new(fn(a.x, b.x, t), fn(a.y, b.y, t), fn(a.z, b.z, t), fn(a.w, b.w, t));
        // [MethodImpl(IL)] public static float3 ParallelAndParam(this f1x3_f1 fn, float3 a, float3 b, float t) => new(fn(a.x, b.x, t), fn(a.y, b.y, t), fn(a.z, b.z, t));
        // [MethodImpl(IL)] public static float2 ParallelAndParam(this f1x3_f1 fn, float2 a, float2 b, float t) => new(fn(a.x, b.x, t), fn(a.y, b.y, t));
        // [MethodImpl(IL)] public static float ParallelAndParam(this f1x3_f1 fn, float a, float b, float t) => fn(a, b, t);
        //
        // [MethodImpl(IL)] public static float4 ParallelAndParam(this f1x3_f1 fn, float4 a, float4 b, float2 t) => new(fn(a.x, b.x, t.x), fn(a.y, b.y, t.y), fn(a.z, b.z, t.x), fn(a.w, b.w, t.y));
        // [MethodImpl(IL)] public static float3 ParallelAndParam(this f1x3_f1 fn, float3 a, float3 b, float2 t) => new(fn(a.x, b.x, t.x), fn(a.y, b.y, t.y), fn(a.z, b.z, t.x));
        // [MethodImpl(IL)] public static float2 ParallelAndParam(this f1x3_f1 fn, float2 a, float2 b, float2 t) => new(fn(a.x, b.x, t.x), fn(a.y, b.y, t.y));
        //
        [MethodImpl(IL)] public static float4 RunPerAxisWithParam(this f1x3_f1 func, float4 a, float4 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t), func(a.w, b.w, t));
        [MethodImpl(IL)] public static float3 RunPerAxisWithParam(this f1x3_f1 func, float3 a, float3 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t));
        [MethodImpl(IL)] public static float2 RunPerAxisWithParam(this f1x3_f1 func, float2 a, float2 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t));

        [MethodImpl(IL)] public static float4 RunPerAxisWithParam(this f1x3_f1 func, float4 a, float4 b, float4 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.z), func(a.w, b.w, t.w));
        [MethodImpl(IL)] public static float3 RunPerAxisWithParam(this f1x3_f1 func, float3 a, float3 b, float3 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.z));
        [MethodImpl(IL)] public static float2 RunPerAxisWithParam(this f1x3_f1 func, float2 a, float2 b, float2 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y));
        [MethodImpl(IL)] public static float RunPerAxisWithParam(this f1x3_f1 func, float a, float b, float t) => func(a, b, t);

        // for dot, csum, mean....
        [MethodImpl(IL)] public static float RunAdditive(this f1x2_f1 func, float4 a, float4 b) => func(a.x, b.x) + func(a.y, b.y) + func(a.z, b.z) + func(a.w, b.w);
        [MethodImpl(IL)] public static float RunAdditive(this f1x2_f1 func, float3 a, float3 b) => func(a.x, b.x) + func(a.y, b.y) + func(a.z, b.z);
        [MethodImpl(IL)] public static float RunAdditive(this f1x2_f1 func, float2 a, float2 b) => func(a.x, b.x) + func(a.y, b.y);
        
        
    }
}