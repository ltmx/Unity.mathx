#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Projects a vector onto a plane defined by a normal orthogonal to the plane.
        [MethodImpl(IL)] public static float3 projectplane(this float3 f, float3 planeNormal) => f - project(f, planeNormal);
        // [MethodImpl(IL)] public static f3 MultiplyPoint(this float4x4 m, f3 v) => v.mul(m) / m[3].xyz;

        public static IEnumerable<T> apply<T>(this IEnumerable<T> t, Func<T, T> f) => t.Select(x => GetFunctionPointerDelegate(f).Invoke(x));

        /// <summary>Apply a function to a value a number of times </summary>
        /// <param name="input">input object</param>
        /// <param name="function">Function</param>
        /// <param name="cycles">number of times to apply the function to the input</param>
        /// <returns>the result of the iterative process</returns>
        [MethodImpl(IL)]
        [BurstCompile]
        public static T apply<T>(this T input, Func<T, T> function, int cycles) {
            var cachedpointer = GetFunctionPointerDelegate(function).Invoke; // Need to cache the function pointer to avoid the overhead of calling the delegate and be compatible with burst
            for (var i = 0; i < cycles; i++)
                input = cachedpointer(input);
            return input;
        }

        public static FunctionPointer<T> GetFunctionPointerDelegate<T>(T functionPointer) where T : Delegate => new(Marshal.GetFunctionPointerForDelegate(functionPointer));
        // public static ActionJob ToActionJob(this Action action) => new(GetFunctionPointerDelegate(action));
    }
}