using System;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEditor;
using static Unity.Mathematics.math;
using Debug = UnityEngine.Debug;
using Object = UnityEngine.Object;
using static UnityEditor.Build.Il2CppCodeGeneration;
using Math = Unity.Mathematics.Math;

namespace Tests
{
    public static class MathTests
    {
        static Stopwatch stopwatch = new ();
        private static Object staticObject;
        private static float staticfloat;
        private static float staticfloat4;
        [MenuItem("Math/Tests/Exponential")]
        public static void Benchmark()
        {
            Benchmark(Math.frac).Log("fast frac");
            Benchmark(frac).Log("exp");
            Benchmark<float4>(Math.frac).Log("fast frac4");
            // Benchmark<float4>(Math.frac2).Log("fast frac4");
            Benchmark<float4>(frac).Log("frac4");
        }

        private static void Run(Func<float, float> function, float input)
        {
            for (int i = 0; i < 1000000; i++) staticfloat = function(input);
        }
        private static void Run<T>(Func<T, T> function, T input) where T : struct
        {
            for (int i = 0; i < 1000000; i++) function(input);
        }
        private static long Benchmark(Func<float, float> function)
        {
            
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, staticfloat);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        private static long Benchmark<T>(Func<T, T> function) where T : struct
        {
            T poop = new T();
            stopwatch.Reset();
            stopwatch.Start();
            Run(function, poop);
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        
        private static void Log(this long time, string name) => Debug.Log($"{name} took {time}ms");
    }
}

