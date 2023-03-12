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

using static Unity.Mathematics.FunctionPointers.MethodSignatures;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Projects a vector onto a plane defined by a normal orthogonal to the plane.
        [MethodImpl(IL)] public static float3 projectplane(this float3 f, float3 planeNormal) => f - project(f, planeNormal);
        // [MethodImpl(IL)] public static float3 MultiplyPoint(this float4x4 m, float3 v) => v.mul(m) / m[3].xyz;
        
        public static IEnumerable<T> Iterate<T>(this IEnumerable<T> t, Func<T, T> f) => t.Select(x => GetFunctionPointerDelegate(f).Invoke(x));

        public static FunctionPointer<T> GetFunctionPointerDelegate<T>(T functionPointer) where T : Delegate => new(Marshal.GetFunctionPointerForDelegate(functionPointer));
        // public static ActionJob ToActionJob(this Action action) => new(GetFunctionPointerDelegate(action));
    }
}