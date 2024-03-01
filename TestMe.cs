#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

#if UNITY_EDITOR

using System;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        [MenuItem("Tools/mathx/Test")]
        public static void TestBenchmark()
        {
            var d = 2.3;
            var stopWatch = new Stopwatch();
            var f = new float3(1.4f,5.6f,8.1f);
            var v = new Vector3(1.4f,5.6f,8.1f);
            var d3 = new double3(1.4f,5.6f,8.1f);
            var i = new int3(1,2,3);
            var f4 = new float4(1.4f,5.6f,8.12f, 4.1f);
            var f3 = new float3(1.4f,5.6f,8.12f);
            var f2 = new float2(1.4f,5.6f);
            var f4x4 = new float4x4(1.4f,5.6f,8.12f, 4.1f, 1.4f,5.6f,8.12f, 4.1f, 1.4f,5.6f,8.12f, 4.1f, 1.4f,5.6f,8.12f, 4.1f);
            var f2x2 = new float2x2(1.4f,5.6f,8.12f, 4.1f);
            // var a = 1.2f;
            // var b = 1.3f;
            // var c = 1.4f;
            var q1 = new quaternion(1.4f,5.6f,8.12f, 4.1f);
            var q2 = new quaternion(1.4f,5.6f,8.12f, 4.1f);

            TestMethod(()=> f4x4.mult(f4), "mult");
            Debug.Log("mult value of v" + f4x4.mult(f4));
            // TestMethod(()=> mathx.anglerad(), "asfloat");
            // Debug.Log("sq2 value of v" + d3.sq2());
            // TestMethod(()=> f.fcmin(), "fcmin");
            // TestMethod(()=> f.cmin(), "cmin");
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
            Debug.Log(name + " took "+ stopWatch.ElapsedMilliseconds + " ms to complete 1.000.000 times");
        }
    }
}

#endif