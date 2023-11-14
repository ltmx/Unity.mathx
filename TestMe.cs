#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

#if UNITY_EDITOR

using System;
using System.Diagnostics;
using UnityEditor;
using Debug = UnityEngine.Debug;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        [MenuItem("Athena/Test")]
        public static void TestBenchmark()
        {
            var stopWatch = new Stopwatch();
            var f = new float3(1.4f,5.6f,8.1f);
            var f4 = new float4(1.4f,5.6f,8.12f, 4.1f);
            var f3 = new float3(1.4f,5.6f,8.12f);
            var f2 = new float2(1.4f,5.6f);
            // var a = 1.2f;
            // var b = 1.3f;
            // var c = 1.4f;

            // TestMethod(()=> f.abs(), "abs");
            // TestMethod(()=> f.fabs(), "fabs");
            // TestMethod(()=> f.sign(), "sign");
            // TestMethod(()=> f.fsign(), "fsign");
            // TestMethod(()=> f.min(0.2f), "max");
            // TestMethod(()=> f.fmin(0.2f), "fmax");
            // TestMethod(()=> f.fcmin(), "fcmin");
            // TestMethod(()=> f.cmin(), "cmin");
            TestMethod(()=> f3.fsign(), "fsign");
            TestMethod(()=> f3.fsign2(), "fsign2");
            // TestMethod(() => f2.cycle(3), "cycle");
            // Debug.Log("fabs value of 0.2f" + fabs(a));
            // Debug.Log("fabs value of -0.2f" + fabs(-a));
            // Debug.Log("fabs value of 0.2f" + fabs(0.2));
            // Debug.Log("fmax value of f and 2.4f" + f.fmax(2.4f));
            // Debug.Log("fcmax value of f (8.1f) is : " + f.fcmax());
            // Debug.Log("fabs2 value of 0.2f" + fabs2(a));
            // Debug.Log("fabs2 value of -0.2f" + fabs2(-a));
            // TestMethod(()=> f.abs(), "abs");
            // TestMethod(()=> mathx.Interpolate(a,b,c), "interpolate");

        }
    
        public static void TestMethod(Action action, string name)
        {
            var stopWatch = new Stopwatch();
            var f = new float3(1.4f,5.6f,8.1f);
            
            stopWatch.Start();
            for (int i = 0; i < 1000000; i++) {
                action.Invoke();
            }
            stopWatch.Stop();
            Debug.Log(name + " took "+ stopWatch.ElapsedMilliseconds);
        }
    }
}

#endif