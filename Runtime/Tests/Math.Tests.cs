#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Diagnostics;
using Unity.Burst;
using Unity.Mathematics;
using UnityEditor;
using static Unity.Mathematics.math;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;

namespace Tests
{
    [BurstCompile]
    public static class MathTests
    {
        static Stopwatch stopwatch = new ();
        private static float staticfloat;
        private static float2 staticfloat2;
        // [MenuItem("Math/Tests/Exponential")]
        public static void Benchmark()
        {
            // Benchmark(mathx.smax_exp2).Log("smax");
            // Benchmark(mathx.smax_expOP).Log("smaxOP");
            // Benchmark<float4>(mathx.frac).Log("fast frac4");
            // // Benchmark<float4>(Math.frac2).Log("fast frac4");
            // Benchmark<float4>(frac).Log("frac4");
        }

        private static void Run(Func<float, float> function, float input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat = function(input);
        }
        private static void Run(Func<float, float, float> function, float input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat = function(input, input);
        }
        private static void Run(Func<float2, float2, float2> function, float2 input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat2 = function(input, input);
        }
        private static void Run(Func<float, float, float, float> function, float input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat = function(input, input, input);
        }
        private static void Run(Func<float2, float2, float2, float2> function, float2 input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat2 = function(input, input, input);
        }
        
        // private static void Run<T>(Func<T, T> function, T input) where T : struct
        // {
        //     for (int i = 0; i < 1000000; i++) function(input);
        // }
        // private static void Run<T>(Func<T, T, T> function, T input) where T : struct
        // {
        //     for (int i = 0; i < 1000000; i++) function(input, input);
        // }
        // private static void Run<T>(Func<T, T, T, T> function, T input) where T : struct
        // {
        //     for (int i = 0; i < 1000000; i++) function(input, input, input);
        // }
        private static long Benchmark(Func<float, float> function)
        {
            
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        private static long Benchmark(Func<float, float, float> function)
        {
            var nanosecPerTick = 1000L*1000L*1000L / Stopwatch.Frequency;
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks / nanosecPerTick;
        }
        private static long Benchmark(Func<float2, float2, float2> function)
        {
            
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat2);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        private static long Benchmark(Func<float, float, float, float> function)
        {
            var nanosecPerTick = 1000L*1000L*1000L / Stopwatch.Frequency;
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks / nanosecPerTick;
        }
        private static long NanoSeconds(Func<float2, float2, float2, float2> function)
        {
            var nanosecPerTick = 1000L*1000L*1000L / Stopwatch.Frequency;
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat2);
            stopwatch.Stop();
            return stopwatch.ElapsedTicks / nanosecPerTick;
        }
        
        
        private static void Log(this long time, string name) => Debug.Log($"{name} took {time}ms");
    }
}

