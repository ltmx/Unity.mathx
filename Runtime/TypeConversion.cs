using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UME;
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
        
        // Color conversion -------------------------------------------
        
        public static float4 asfloat(this Color c) => c.cast();
        public static float4 asfloat(this color c) => c; // Compatibility
        
        

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
        
        public static color ascolor(this float4 f) => new Color(f.x, f.y, f.z, f.w);
        public static color ascolor(this float3 f) => new Color(f.x, f.y, f.z);
        public static color ascolor(this float2 f) => new Color(f.x, f.y, 0);
        public static color ascolor(this float f) => new Color(f,f,f);

        // Color as floats
        // public static float4 asfloat4(this Color c) => c.cast(); // compatibility
        public static float3 asfloat3(this Color c) => new float3(c.r, c.g, c.b);
        public static float3 asfloat3(this color c) => (float3)c;


        //IEnumerable Type Conversion -------------------------------------------------------------------
        
        
        public static List<Vector4> toVectorList(this IEnumerable<float4> f) => f.toVectorIE().ToList();
        public static List<Vector3> toVectorList(this IEnumerable<float3> f) => f.toVectorIE().ToList();
        public static List<Vector2> toVectorList(this IEnumerable<float2> f) => f.toVectorIE().ToList();
        
        public static List<float4> tofloatList(this IEnumerable<Vector4> f) => f.tofloatIE().ToList();
        public static List<float3> tofloatList(this IEnumerable<Vector3> f) => f.tofloatIE().ToList();
        public static List<float2> tofloatList(this IEnumerable<Vector2> f) => f.tofloatIE().ToList();

        public static List<Color> toColorList(this IEnumerable<float4> f) => f.toColorIE().ToList();
        public static List<Color> toColorList(this IEnumerable<float3> f) => f.toColorIE().ToList();
        public static List<Color> toColorList(this IEnumerable<float2> f) => f.toColorIE().ToList();

        public static List<color> tocolorList(this IEnumerable<float4> f) => f.tocolorIE().ToList();
        public static List<color> tocolorList(this IEnumerable<float3> f) => f.tocolorIE().ToList();
        public static List<color> tocolorList(this IEnumerable<float2> f) => f.tocolorIE().ToList();
        
        public static Color[] toColorArray(this IEnumerable<float4> f) => f.toColorIE().ToArray();
        public static Color[] toColorArray(this IEnumerable<float3> f) => f.toColorIE().ToArray();
        public static Color[] toColorArray(this IEnumerable<float2> f) => f.toColorIE().ToArray();
        
        public static color[] tocolorArray(this IEnumerable<float4> f) => f.tocolorIE().ToArray();
        public static color[] tocolorArray(this IEnumerable<float3> f) => f.tocolorIE().ToArray();
        public static color[] tocolorArray(this IEnumerable<float2> f) => f.tocolorIE().ToArray();

        public static List<float4> tofloat4List(this IEnumerable<Color> colors) => colors.tofloat4IE().ToList();
        public static List<float3> tofloat3List(this IEnumerable<Color> colors) => colors.tofloat3IE().ToList();
        public static float4[] tofloat4Array(this IEnumerable<Color> colors) => colors.tofloat4IE().ToArray();
        public static float3[] tofloat3Array(this IEnumerable<Color> colors) => colors.tofloat3IE().ToArray();
        
        public static Vector4[] toVectorArray(this IEnumerable<float4> f) => f.toVectorIE().ToArray();
        public static Vector3[] toVectorArray(this IEnumerable<float3> f) => f.toVectorIE().ToArray();
        public static Vector2[] toVectorArray(this IEnumerable<float2> f) => f.toVectorIE().ToArray();

        public static float4[] tofloatArray(this IEnumerable<Vector4> f) => f.tofloatIE().ToArray();
        public static float3[] tofloatArray(this IEnumerable<Vector3> f) => f.tofloatIE().ToArray();
        public static float2[] tofloatArray(this IEnumerable<Vector2> f) => f.tofloatIE().ToArray();
        
        
        public static color[] tocolorArray(this IEnumerable<Color> f) => f.tocolorIE().ToArray();
        public static Color[] toColorArray(this IEnumerable<color> f) => f.toColorIE().ToArray();
        
        
        // Type Conversion SubMethods -------------------------------------------
        private static IEnumerable<Vector4> toVectorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.cast());
        public static IEnumerable<Vector3> toVectorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.cast());
        public static IEnumerable<Vector2> toVectorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.cast());

        public static IEnumerable<float4> tofloatIE(this IEnumerable<Vector4> f2s) => f2s.Select(f => f.cast());
        public static IEnumerable<float3> tofloatIE(this IEnumerable<Vector3> f2s) => f2s.Select(f => f.cast());
        public static IEnumerable<float2> tofloatIE(this IEnumerable<Vector2> f2s) => f2s.Select(f => f.cast());

        private static IEnumerable<Color> toColorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor().cast());
        private static IEnumerable<Color> toColorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor().cast());
        private static IEnumerable<Color> toColorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor().cast());

        private static IEnumerable<color> tocolorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor());
        private static IEnumerable<color> tocolorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor());
        private static IEnumerable<color> tocolorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor());

        private static IEnumerable<float4> tofloat4IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat());
        private static IEnumerable<float3> tofloat3IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat3());
        
        private static IEnumerable<float4> tofloat4IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat());
        private static IEnumerable<float3> tofloat3IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat3());
        
        
        private static IEnumerable<Color> toColorIE(this IEnumerable<color> f2s) => f2s.Select(f => f.cast());
        private static IEnumerable<color> tocolorIE(this IEnumerable<Color> f2s) => f2s.Select(f => f.cast());
        
        
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
        
        /// returns a float4 with the same sub-components
        /// returns a float4 with the same sub-components
        public static color cast(this Color f) => f;
        public static Color cast(this color f) => f;

    }
}