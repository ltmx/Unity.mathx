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
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.MethodSignatures;

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
    
    
    public static class RandomUtils
    {
        private const uint PRIME1 = 2654435761u;
        private const uint PRIME2 = 2246822519u;
        private const uint PRIME3 = 3266489917u;
        private const uint PRIME4 = 668265263u;
        private const uint PRIME5 = 374761393u;
        
        private static readonly uint4 PRIMEX = new(2654435761u, 2246822519u, 3266489917u, 668265263u);

        public static float normalizeuint(this uint value) => value / (float)uint.MaxValue;

        private static float randf(int seed) => xxhash32((uint)seed).normalizeuint();
        private static float2 randf(int2 seed) => new();
        private static float3 randf(int3 seed) => new(randf(seed.x), randf(seed.y), randf(seed.z));
        private static float4 randf(int4 seed) => new(randf(seed.x), randf(seed.y), randf(seed.z), randf(seed.w));

        private static float rand(uint seed) => xxhash32(seed) / (float)uint.MaxValue;
        // private static float2 randf(uint2 seed) => new(randf(seed.x), randf(seed.y));
        // private static float3 randf(uint3 seed) => new(randf(seed.x), randf(seed.y), randf(seed.z));

        private static u1_f1 test_fp = ToPointerInvoke<u1_f1>(rand);
        private static float4 randf(uint4 seed) => make(seed, test_fp);
        private static float3 randf(uint3 seed) => make(seed, test_fp);
        private static float2 randf(uint2 seed) => make(seed, test_fp);
        private static float randf(uint seed) => make(seed, test_fp);
        
        public static float4 randfx(uint4 seed) => randf(seed + PRIMEX);
        public static float3 randfx(uint3 seed) => randf(seed + PRIMEX.xyz);
        public static float2 randfx(uint2 seed) => randf(seed + PRIMEX.xy);
        public static float randfx(uint seed) => randf(seed + PRIMEX.x);
        
        public static float4 make(int4 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
        public static float3 make(int3 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
        public static float2 make(int2 f, i1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
        public static float make(int f, i1_f1 func) => func.Invoke(f);
        
        public static int4 make(int4 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
        public static int3 make(int3 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
        public static int2 make(int2 f, i1_i1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
        public static int make(int f, i1_i1 func) => func.Invoke(f);
        
        public static double4 make(double4 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
        public static double3 make(double3 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
        public static double2 make(double2 f, d1_d1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
        public static double make(double f, d1_d1 func) => func.Invoke(f);
        
        public static float4 make(uint4 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z), func.Invoke(f.w));
        public static float3 make(uint3 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y), func.Invoke(f.z));
        public static float2 make(uint2 f, u1_f1 func) => new(func.Invoke(f.x), func.Invoke(f.y));
        public static float make(uint f, u1_f1 func) => func.Invoke(f);

        private static uint xxhash32(uint seed) {
            var hash = seed + PRIME5;
            hash *= PRIME1;
            hash = rotl(hash, 17) * PRIME2;
            hash *= PRIME3;
            hash = rotl(hash, 17) * PRIME4;
            hash ^= hash >> 15;
            hash *= PRIME5;
            hash ^= hash >> 13;
            hash *= PRIME2;
            hash ^= hash >> 16;
            return hash;
        }

        private static uint rotl(uint value, int count) => value << count | value >> 32 - count;
    }  
}
