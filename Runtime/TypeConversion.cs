using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace UME
{
    public static partial class UnityMathematicsExtensions
    {
        // Type Conversion -----------------------------------------------------------------------------
        
        // floats to ints
        public static int4 asint(this float4 f) => math.asint(f);
        public static int3 asint(this float3 f) => math.asint(f);
        public static int2 asint(this float2 f) => math.asint(f);
        public static int asint(this float f) => math.asint(f);

        // ints to floats
        public static float4 asfloat(this int4 f) => math.asfloat(f);
        public static float3 asfloat(this int3 f) => math.asfloat(f);
        public static float2 asfloat(this int2 f) => math.asfloat(f);
        public static float asfloat(this int f) => math.asfloat(f);

        // Vectors to floats
        public static float4 asfloat(this Vector4 f) => f;
        public static float3 asfloat(this Vector3 f) => f;
        public static float2 asfloat(this Vector2 f) => f;
        
        
        // Complex to doubles or floats
        public static double2 asdouble2(this Complex c) => new double2(c.Real, c.Imaginary);
        public static float2 asfloat2(this Complex c) => (float2)c.asdouble2();
        
        
        public static float2 asfloat2(this double2 d) => (float2)d;
        
        // bools to ints
        public static int4 asint(this bool4 b) => new int4(b.x.asint(), b.y.asint(), b.z.asint(), b.w.asint());
        public static int3 asint(this bool3 b) => new int3(b.x.asint(), b.y.asint(), b.z.asint());
        public static int2 asint(this bool2 b) => new int2(b.x.asint(), b.y.asint());
        public static int asint(this bool b) => b ? 1 : 0;
        
        // bools to floats
        public static float4 asfloat(this bool4 b) => b.asint();
        public static float3 asfloat(this bool3 b) => b.asint();
        public static float2 asfloat(this bool2 b) => b.asint();
        public static float asfloat(this bool b) => b.asint();
        
        // doubles to floats
        public static float4 asfloat(this double4 f) => (float4)f;
        public static float3 asfloat(this double3 f) => (float3)f;
        public static float2 asfloat(this double2 f) => (float2)f;
        public static float asfloat(this double f) => (float)f;
        
        // floats to doubles
        public static double4 asdouble(this float4 f) => Convert.ToDouble(f);
        public static double3 asdouble(this float3 f) => Convert.ToDouble(f);
        public static double2 asdouble(this float2 f) => Convert.ToDouble(f);
        public static double asdouble(this float f) => Convert.ToDouble(f);
        
        // Quaternion to float4
        public static float4 asfloat(quaternion q) => q.value;


        //IEnumerable Type Conversion -----------------------------------------------------------------------
        
        public static List<Vector4> asvectors(this IEnumerable<float4> f4s) => f4s.Select(f => (Vector4) f).ToList();
        public static List<Vector3> asvectors(this IEnumerable<float3> f3s) => f3s.Select(f => (Vector3) f).ToList();
        public static List<Vector2> asvectors(this IEnumerable<float2> f2s) => f2s.Select(f => (Vector2) f).ToList();


        public static List<float4> asfloats(this IEnumerable<Vector4> v4s) => v4s.Select(f => (float4) f).ToList();
        public static List<float3> asfloats(this IEnumerable<Vector3> v3s) => v3s.Select(f => (float3) f).ToList();
        public static List<float2> asfloats(this IEnumerable<Vector2> v2s) => v2s.Select(f => (float2) f).ToList();

        public static List<Color> ascolors(this IEnumerable<float4> f4s) => f4s.Select(f => f.ascolor()).ToList();
        public static List<Color> ascolors(this IEnumerable<float3> f3s) => f3s.Select(f => f.ascolor()).ToList();
        public static List<Color> ascolors(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor()).ToList();
        
        public static List<float4> asfloat4s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat4()).ToList();
        public static List<float3> asfloat3s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat3()).ToList();
        public static List<float2> asfloat2s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat2()).ToList();
        
        
        
        public static Vector4[] asvectors(this float4[] f4s) => f4s.Select(f => (Vector4) f).ToArray();
        public static Vector3[] asvectors(this float3[] f3s) => f3s.Select(f => (Vector3) f).ToArray();
        public static Vector2[] asvectors(this float2[] f2s) => f2s.Select(f => (Vector2) f).ToArray();


        public static float4[] asfloats(this Vector4[] v) => v.asfloats().ToArray();
        public static float3[] asfloats(this Vector3[] v) => v.asfloats().ToArray();
        public static float2[] asfloats(this Vector2[] v) => v.asfloats().ToArray();

        public static Color[] ascolors(this float4[] v) => v.ascolors().ToArray();
        public static Color[] ascolors(this float3[] v) => v.ascolors().ToArray();
        public static Color[] ascolors(this float2[] v) => v.ascolors().ToArray();
        
        public static float4[] asfloat4s(this Color[] c) => c.asfloat4s().ToArray();
        public static float3[] asfloat3s(this Color[] c) => c.asfloat3s().ToArray();
        public static float2[] asfloat2s(this Color[] c) => c.asfloat2s().ToArray();

        // floats as Color
        public static Color ascolor(this float4 f) => new Color(f.x, f.y, f.z, f.w);
        public static Color ascolor(this float3 f) => new Color(f.x, f.y, f.z);
        public static Color ascolor(this float2 f) => new Color(f.x, f.y, 0);
        public static Color ascolor(this float f) => new Color(f,f,f);

        // Color as floats
        public static float4 asfloat4(this Color c) => new float4(c.r, c.g, c.b, c.a);
        public static float3 asfloat3(this Color c) => new float3(c.r, c.g, c.b);
        public static float2 asfloat2(this Color c) => new float2(c.r, c.g);


        public static float3 youopie(this Vector3 v) => v;
    }
}