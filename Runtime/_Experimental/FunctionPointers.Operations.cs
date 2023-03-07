#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System;
using Unity.Burst;
using static Unity.Burst.BurstCompiler;
using static Unity.Mathematics.FunctionPointers.MethodSignatures;
using fx = Unity.Mathematics.float4;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        public static float4 InvokeParallel(this MethodSignatures.p2 func, float4 a, float4 b) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z), func(a.w, b.w));
        public static float3 InvokeParallel(this MethodSignatures.p2 func, float3 a, float3 b) => new(func(a.x, b.x), func(a.y, b.y), func(a.z, b.z));
        public static float2 InvokeParallel(this MethodSignatures.p2 func, float2 a, float2 b) => new(func(a.x, b.x), func(a.y, b.y));
        public static float InvokeParallel(this MethodSignatures.p2 func, float a, float b) => func(a, b);
        public static float4 ParallelAndParam(this MethodSignatures.p3 func, float4 a, float4 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t), func(a.w, b.w, t));
        public static float3 ParallelAndParam(this MethodSignatures.p3 func, float3 a, float3 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t));
        public static float2 ParallelAndParam(this MethodSignatures.p3 func, float2 a, float2 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t));
        public static float ParallelAndParam(this MethodSignatures.p3 func, float a, float b, float t) => func(a, b, t);
        public static float4 ParallelAndParam(this MethodSignatures.p3 func, float4 a, float4 b, float2 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.x), func(a.w, b.w, t.y));
        public static float3 ParallelAndParam(this MethodSignatures.p3 func, float3 a, float3 b, float2 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.x));
        public static float2 ParallelAndParam(this MethodSignatures.p3 func, float2 a, float2 b, float2 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y));
        public static float4 InvokeParallelAndParam(this MethodSignatures.p3 func, float4 a, float4 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t), func(a.w, b.w, t));
        public static float3 InvokeParallelAndParam(this MethodSignatures.p3 func, float3 a, float3 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t), func(a.z, b.z, t));
        public static float2 InvokeParallelAndParam(this MethodSignatures.p3 func, float2 a, float2 b, float t) => new(func(a.x, b.x, t), func(a.y, b.y, t));
        public static float InvokeParallelAndParam(this MethodSignatures.p3 func, float a, float b, float t) => func(a, b, t);
        public static float4 InvokeParallelAndParam(this MethodSignatures.p3 func, float4 a, float4 b, float4 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.z), func(a.w, b.w, t.w));
        public static float3 InvokeParallelAndParam(this MethodSignatures.p3 func, float3 a, float3 b, float3 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y), func(a.z, b.z, t.z));
        public static float2 InvokeParallelAndParam(this MethodSignatures.p3 func, float2 a, float2 b, float2 t) => new(func(a.x, b.x, t.x), func(a.y, b.y, t.y));
        public static float SumOperations(this MethodSignatures.p2 func, float4 a, float4 b) => func(a.x, b.x) + func(a.y, b.y) + func(a.z, b.z) + func(a.w, b.w);
        public static float SumOperations(this MethodSignatures.p2 func, float3 a, float3 b) => func(a.x, b.x) + func(a.y, b.y) + func(a.z, b.z);
        public static float SumOperations(this MethodSignatures.p2 func, float2 a, float2 b) => func(a.x, b.x) + func(a.y, b.y);
    }
}