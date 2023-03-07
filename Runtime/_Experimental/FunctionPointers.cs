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
    [BurstCompile]
    public static partial class FunctionPointers
    {
        //generic function pointer compiler
        public static T ToPointerInvoke<T>(T function) where T : Delegate => CompileFunctionPointer(function).Invoke; // Inferred Type
        // ** Very important to cache the function pointer for performance reasons
        public readonly static p3 FP_smax_exp = ToPointerInvoke<p3>(mathx.smax_exp);
        public readonly static p3 FP_smin_exp = ToPointerInvoke<p3>(mathx.smin_exp);
        public readonly static p3 FP_smax = ToPointerInvoke<p3>(mathx.smax);
        public readonly static p3 FP_smin = ToPointerInvoke<p3>(mathx.smin);
        // public readonly static p1x2 FP_dot = ToPointerInvoke<p1x2>(mathx.cmul);
        


        // Operation Interface ------------------------------------------------------------------
        // Parallel operations

        // Parallel operations and float parameter

        // Summing operations (for example, for calculating a dot product)
    }
}