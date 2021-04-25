using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Matrix4x4 = UnityEngine.Matrix4x4;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace Plugins.Mathematics_Extensions.Runtime
{
    public static partial class UME
    {
        // Type Conversion -----------------------------------------------------------------------------
        
        // floats to ints
        /// Returns this float-type cast to an equivalent int-type
        public static int4 asint(this float4 f) => math.asint(f);
        /// <summary>
        /// <inheritdoc cref="asint(float4)"/>>
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static int3 asint(this float3 f) => math.asint(f);
        public static int2 asint(this float2 f) => math.asint(f);
        public static int asint(this float f) => math.asint(f);

        // ints to floats -------------------------------------------
        /// Returns a float type equivalent
        public static float4 asfloat(this int4 f) => math.asfloat(f);
        /// <inheritdoc cref="asfloat(int4)"/>
        public static float3 asfloat(this int3 f) => math.asfloat(f);
        /// <inheritdoc cref="asfloat(int4)"/>
        public static float2 asfloat(this int2 f) => math.asfloat(f);
        /// <inheritdoc cref="asfloat(int4)"/>
        public static float asfloat(this int f) => math.asfloat(f);

        // Vectors to floats -------------------------------------------
        
        /// Returns a float type equivalent
        public static float4 asfloat(this Vector4 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        public static float3 asfloat(this Vector3 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        public static float2 asfloat(this Vector2 f) => f;
        
        
        // Complex conversion -------------------------------------------
        
        /// Returns a double2 equivalent
        public static double2 asdouble(this Complex c) => new double2(c.Real, c.Imaginary);
        /// Returns a float2 equivalent
        public static float2 asfloat(this Complex c) => (float2)c.asdouble();
        
        

        /// Returns 1 when true, componentwise
        public static int4 asint(this bool4 b) => new int4(b);
        /// <inheritdoc cref="asint(bool4)"/>
        public static int3 asint(this bool3 b) => new int3(b);
        /// <inheritdoc cref="asfloat(bool4)"/>
        public static int2 asint(this bool2 b) => new int2(b);
        /// Returns 1 when true
        public static int asint(this bool b) => b ? 1 : 0;
        
        
        // bools as floats -------------------------------------------
        
        /// Returns 1 when true, componentwise
        public static float4 asfloat(this bool4 b) => new float4(b);
        /// <inheritdoc cref="asfloat(bool4)"/>
        public static float3 asfloat(this bool3 b) => new float3(b);
        /// <inheritdoc cref="asfloat(bool4)"/>
        public static float2 asfloat(this bool2 b) => new float2(b);
        /// Returns 1 when true
        public static float asfloat(this bool b) => b.asint();
        
        // doubles as floats -------------------------------------------
        
        /// Returns a float type equivalent
        public static float4 asfloat(this double4 f) => (float4)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        public static float3 asfloat(this double3 f) => (float3)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        public static float2 asfloat(this double2 f) => (float2)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        public static float asfloat(this double f) => (float)f;
        
        
        // floats as doubles -------------------------------------------
        
        /// Returns a double type equivalent
        public static double4 asdouble(this float4 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        public static double3 asdouble(this float3 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        public static double2 asdouble(this float2 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        public static double asdouble(this float f) => Convert.ToDouble(f);
        
        
        /// Returns a float4 from the quaternion's constituants
        public static float4 asfloat(quaternion q) => q.value;
        

        // floats as Color -------------------------------------------
        
        public static Color ascolor(this float4 f) => new Color(f.x, f.y, f.z, f.w);
        public static Color ascolor(this float3 f) => new Color(f.x, f.y, f.z);
        public static Color ascolor(this float2 f) => new Color(f.x, f.y, 0);
        public static Color ascolor(this float f) => new Color(f,f,f);

        // Color as floats
        public static float4 asfloat4(this Color c) => new float4(c.r, c.g, c.b, c.a);
        public static float3 asfloat3(this Color c) => new float3(c.r, c.g, c.b);


        //IEnumerable Type Conversion -------------------------------------------------------------------
        
        
        public static List<Vector4> asvectorslist(this IEnumerable<float4> f) => f.asIEVector().ToList();
        public static List<Vector3> asvectorslist(this IEnumerable<float3> f) => f.asIEVector().ToList();
        public static List<Vector2> asvectorslist(this IEnumerable<float2> f) => f.asIEVector().ToList();
        
        public static List<float4> asfloatlist(this IEnumerable<Vector4> f) => f.asIEfloat().ToList();
        public static List<float3> asfloatlist(this IEnumerable<Vector3> f) => f.asIEfloat().ToList();
        public static List<float2> asfloatlist(this IEnumerable<Vector2> f) => f.asIEfloat().ToList();

        public static List<Color> ascolorlist(this IEnumerable<float4> f) => f.asIEColor().ToList();
        public static List<Color> ascolorlist(this IEnumerable<float3> f) => f.asIEColor().ToList();
        public static List<Color> ascolorlist(this IEnumerable<float2> f) => f.asIEColor().ToList();
        
        public static Color[] ascolorarray(this IEnumerable<float4> f) => f.asIEColor().ToArray();
        public static Color[] ascolorarray(this IEnumerable<float3> f) => f.asIEColor().ToArray();
        public static Color[] ascolorarray(this IEnumerable<float2> f) => f.asIEColor().ToArray();

        public static List<float4> asfloat4list(this IEnumerable<Color> colors) => colors.asIEfloat4().ToList();
        public static List<float3> asfloat3list(this IEnumerable<Color> colors) => colors.asIEfloat3().ToList();
        public static float4[] asfloat4array(this IEnumerable<Color> colors) => colors.asIEfloat4().ToArray();
        public static float3[] asfloat3array(this IEnumerable<Color> colors) => colors.asIEfloat3() as float3[];
        
        public static Vector4[] asvectorarray(this IEnumerable<float4> f) => f.asIEVector().ToArray();
        public static Vector3[] asvectorarray(this IEnumerable<float3> f) => f.asIEVector().ToArray();
        public static Vector2[] asvectorarray(this IEnumerable<float2> f) => f.asIEVector().ToArray();

        public static float4[] asfloatarray(this IEnumerable<Vector4> f) => f.asIEfloat().ToArray();
        public static float3[] asfloatarray(this IEnumerable<Vector3> f) => f.asIEfloat().ToArray();
        public static float2[] asfloatarray(this IEnumerable<Vector2> f) => f.asIEfloat().ToArray();
        
        
        // Type Conversion SubMethods -------------------------------------------
        private static IEnumerable<Vector4> asIEVector(this IEnumerable<float4> f2s) => f2s.Select(f => (Vector4)f);
        public static IEnumerable<Vector3> asIEVector(this IEnumerable<float3> f2s) => f2s.Select(f => (Vector3)f);
        public static IEnumerable<Vector2> asIEVector(this IEnumerable<float2> f2s) => f2s.Select(f => (Vector2)f);

        public static IEnumerable<float4> asIEfloat(this IEnumerable<Vector4> f2s) => f2s.Select(f => (float4)f);
        public static IEnumerable<float3> asIEfloat(this IEnumerable<Vector3> f2s) => f2s.Select(f => (float3)f);
        public static IEnumerable<float2> asIEfloat(this IEnumerable<Vector2> f2s) => f2s.Select(f => (float2)f);

        private static IEnumerable<Color> asIEColor(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor());
        private static IEnumerable<Color> asIEColor(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor());
        private static IEnumerable<Color> asIEColor(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor());

        private static IEnumerable<float4> asIEfloat4(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat4());
        private static IEnumerable<float3> asIEfloat3(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat3());
        
        
        // Simple Casts to Classic Types -------------------------------------------
        
        public static Vector2 cast(this float2 f) => f;
        public static Vector3 cast(this float3 f) => f;
        public static Vector4 cast(this float4 f) => f;
    
        public static float2 cast(this Vector2 f) => f;
        public static float3 cast(this Vector3 f) => f;
        public static float4 cast(this Vector4 f) => f;
    
        public static Vector2 cast(this double2 f) => f.asfloat();
        public static Vector3 cast(this double3 f) => f.asfloat();
        public static Vector4 cast(this double4 f) => f.asfloat();
    
        public static float4x4 cast(this Matrix4x4 f) => f;
        public static Matrix4x4 cast(this float4x4 f) => f;

    }
}