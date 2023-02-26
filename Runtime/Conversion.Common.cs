using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Matrix4x4 = UnityEngine.Matrix4x4;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        
        // floats to ints
        /// Returns an equivalent int-type
        [MethodImpl(INLINE)] public static int4 asint(this float4 f) => (int4)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int3 asint(this float3 f) => (int3)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int2 asint(this float2 f) => (int2)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int asint(this float f) => (int) f;

        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int4 asint(this Vector4 f) => new ((int)f.x, (int)f.y, (int)f.z, (int)f.w);
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int3 asint(this Vector3 f) => new ((int)f.x, (int)f.y, (int)f.z);
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int2 asint(this Vector2 f) => new ((int)f.x, (int)f.y);

        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int4 asint(this double4 f) => (int4) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int3 asint(this double3 f) => (int3) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int2 asint(this double2 f) => (int2) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(INLINE)] public static int asint(this double f) => (int) f;

        /// Return an equivalent bool-type
        [MethodImpl(INLINE)] public static bool4 asbool(this int4 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(INLINE)] public static bool3 asbool(this int3 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(INLINE)] public static bool2 asbool(this int2 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(INLINE)] public static bool asbool(this int f) => f != 0;

        
        // ints to floats -------------------------------------------
        /// Returns equivalent float-type
        [MethodImpl(INLINE)] public static float4 asfloat(this int4 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(INLINE)] public static float3 asfloat(this int3 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(INLINE)] public static float2 asfloat(this int2 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(INLINE)] public static float asfloat(this int f) => f;

        
        // Vectors to floats -------------------------------------------
        /// Returns a float-type equivalent
        [MethodImpl(INLINE)] public static float4 asfloat(this Vector4 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(INLINE)] public static float3 asfloat(this Vector3 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(INLINE)] public static float2 asfloat(this Vector2 f) => f;


        // Complex conversions -------------------------------------------
        /// Returns a double2 equivalent
        [MethodImpl(INLINE)] public static double2 asdouble(this Complex f) => new(f.Real, f.Imaginary);
        /// Returns a float2 equivalent
        [MethodImpl(INLINE)] public static float2 asfloat(this Complex f) => (float2)f.asdouble();

        // Color to floats -------------------------------------------
        /// Returns a float4 equivalent
        [MethodImpl(INLINE)] public static float4 asfloat(this Color f) => f.cast();
        /// Returns a float4 equivalent
        [MethodImpl(INLINE)] public static float4 asfloat(this color f) => f; // Compatibility
        
        // bools as ints -------------------------------------------
        
        /// Returns 1 when true, componentwise
        [MethodImpl(INLINE)] public static int4 asint(this bool4 b) => (int4) b;
        /// <inheritdoc cref="asint(bool4)"/>
        [MethodImpl(INLINE)] public static int3 asint(this bool3 b) => (int3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(INLINE)] public static int2 asint(this bool2 b) => (int2) b;
        /// Returns 1 when true
        [MethodImpl(INLINE)] public static int asint(this bool b) => b ? 1 : 0;
        
        
        // bools as floats -------------------------------------------
        
        /// Returns 1 when true, componentwise
        [MethodImpl(INLINE)] public static float4 asfloat(this bool4 b) => (float4) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(INLINE)] public static float3 asfloat(this bool3 b) => (float3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(INLINE)] public static float2 asfloat(this bool2 b) => (float2) b;
        /// Returns 1 when true
        [MethodImpl(INLINE)] public static float asfloat(this bool b) => b.asint();
        
        // doubles as floats -------------------------------------------
        
        /// Returns a float-type equivalent
        [MethodImpl(INLINE)] public static float4 asfloat(this double4 f) => (float4)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(INLINE)] public static float3 asfloat(this double3 f) => (float3)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(INLINE)] public static float2 asfloat(this double2 f) => (float2)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(INLINE)] public static float asfloat(this double f) => (float)f;
        
        // floats as doubles -------------------------------------------
        /// Returns a double type equivalent
        [MethodImpl(INLINE)] public static double4 asdouble(this float4 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(INLINE)] public static double3 asdouble(this float3 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(INLINE)] public static double2 asdouble(this float2 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(INLINE)] public static double asdouble(this float f) => Convert.ToDouble(f);
        
        /// Returns a float4 from the quaternion's components
        [MethodImpl(INLINE)] public static float4 asfloat(quaternion q) => q.value;
        

        // floats as Color -------------------------------------------

        /// Converts a float-type to a Unity.Mathematics.color
        [MethodImpl(INLINE)] public static color ascolor(this float4 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(INLINE)] public static color ascolor(this float3 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(INLINE)] public static color ascolor(this float2 f) => new(f.xy, 0, 1);
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(INLINE)] public static color ascolor(this float f) => f;

        // Color as floats
        /// Converts to a float4
        [MethodImpl(INLINE)] public static float4 asfloat4(this Color f) => new(f.r, f.g, f.b, f.a); // compatibility
        /// Converts to a float3
        [MethodImpl(INLINE)] public static float3 asfloat3(this Color f) => new(f.r, f.g, f.b);
        /// Converts to a float3
        [MethodImpl(INLINE)] public static float3 asfloat3(this color f) => (float3) f;


        //IEnumerable Type Conversion -------------------------------------------------------------------

        /// Converts to a Unity Vector type List
        [MethodImpl(INLINE)] public static List<Vector4> toVectorList(this IEnumerable<float4> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<Vector3> toVectorList(this IEnumerable<float3> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<Vector2> toVectorList(this IEnumerable<float2> f) => f.toVectorIE().ToList();

        /// Converts to a float-type List
        [MethodImpl(INLINE)] public static List<float4> tofloatList(this IEnumerable<Vector4> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static List<float3> tofloatList(this IEnumerable<Vector3> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static List<float2> tofloatList(this IEnumerable<Vector2> f) => f.tofloatIE().ToList();

        /// Converts to a UnityEngine.Color List
        [MethodImpl(INLINE)] public static List<Color> toColorList(this IEnumerable<float4> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<Color> toColorList(this IEnumerable<float3> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<Color> toColorList(this IEnumerable<float2> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<Color> toColorList(this IEnumerable<float> f) => f.toColorIE().ToList();

        /// Converts to a Unity.Mathematics.color List
        [MethodImpl(INLINE)] public static List<color> tocolorList(this IEnumerable<float4> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<color> tocolorList(this IEnumerable<float3> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static List<color> tocolorList(this IEnumerable<float2> f) => f.tocolorIE().ToList();

        /// Converts to a UnityEngine.Color Array
        [MethodImpl(INLINE)] public static Color[] toColorArray(this IEnumerable<float4> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static Color[] toColorArray(this IEnumerable<float3> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static Color[] toColorArray(this IEnumerable<float2> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static Color[] toColorArray(this IEnumerable<float> f) => f.toColorIE().ToArray();

        /// Converts to a color Array
        [MethodImpl(INLINE)] public static color[] tocolorArray(this IEnumerable<float4> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static color[] tocolorArray(this IEnumerable<float3> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static color[] tocolorArray(this IEnumerable<float2> f) => f.tocolorIE().ToArray();

        /// Converts to a float4 List
        [MethodImpl(INLINE)] public static List<float4> tofloat4List(this IEnumerable<Color> colors) => colors.tofloat4IE().ToList();
        /// <inheritdoc cref="tofloat4List(IEnumerable{Color})"/>
        [MethodImpl(INLINE)] public static List<float3> tofloat3List(this IEnumerable<Color> colors) => colors.tofloat3IE().ToList();

        /// Converts to a float4 Array
        [MethodImpl(INLINE)] public static float4[] tofloat4Array(this IEnumerable<Color> colors) => colors.tofloat4IE().ToArray();
        /// Converts to a float3 Array
        [MethodImpl(INLINE)] public static float3[] tofloat3Array(this IEnumerable<Color> colors) => colors.tofloat3IE().ToArray();

        /// Converts to a Unity Vector Array
        [MethodImpl(INLINE)] public static Vector4[] toVectorArray(this IEnumerable<float4> f) => f.toVectorIE().ToArray();
        /// <inheritdoc cref="toVectorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static Vector3[] toVectorArray(this IEnumerable<float3> f) => f.toVectorIE().ToArray();
        /// <inheritdoc cref="toVectorArray(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static Vector2[] toVectorArray(this IEnumerable<float2> f) => f.toVectorIE().ToArray();

        /// Converts to a float-type Array
        [MethodImpl(INLINE)] public static float4[] tofloatArray(this IEnumerable<Vector4> f) => f.tofloatIE().ToArray();
        /// <inheritdoc cref="tofloatArray(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static float3[] tofloatArray(this IEnumerable<Vector3> f) => f.tofloatIE().ToArray();
        /// <inheritdoc cref="tofloatArray(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static float2[] tofloatArray(this IEnumerable<Vector2> f) => f.tofloatIE().ToArray();

        /// Converts to a Unity.Mathematics.color Array
        [MethodImpl(INLINE)] public static color[] tocolorArray(this IEnumerable<Color> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{Color})"/>
        [MethodImpl(INLINE)] public static Color[] toColorArray(this IEnumerable<color> f) => f.toColorIE().ToArray();
        
        
        // Type Conversion SubMethods -------------------------------------------
        
        /// Converts to a Unity Vector IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<Vector4> toVectorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static IEnumerable<Vector3> toVectorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] public static IEnumerable<Vector2> toVectorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(INLINE)] public static IEnumerable<float4> tofloatIE(this IEnumerable<Vector4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static IEnumerable<float3> tofloatIE(this IEnumerable<Vector3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(INLINE)] public static IEnumerable<float2> tofloatIE(this IEnumerable<Vector2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<Color> toColorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] private static IEnumerable<Color> toColorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] private static IEnumerable<Color> toColorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] private static IEnumerable<Color> toColorIE(this IEnumerable<float> f2s) => f2s.Select(f => f.ascolor().cast());
        
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<color> tocolorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] private static IEnumerable<color> tocolorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(INLINE)] private static IEnumerable<color> tocolorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(INLINE)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat3());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(INLINE)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(INLINE)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat3());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<Color> toColorIE(this IEnumerable<color> f2s) => f2s.Select(f => f.cast());
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(INLINE)] private static IEnumerable<color> tocolorIE(this IEnumerable<Color> f2s) => f2s.Select(f => f.cast());
        
        
        // Simple Casts to Classic Types -------------------------------------------
        
        /// Casts to and from Unity's Vector Types
        [MethodImpl(INLINE)] public static Vector2 cast(this float2 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(INLINE)] public static Vector3 cast(this float3 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(INLINE)] public static Vector4 cast(this float4 f) => f;

        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(INLINE)] public static float2 cast(this Vector2 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(INLINE)] public static float3 cast(this Vector3 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(INLINE)] public static float4 cast(this Vector4 f) => f;

        /// Casts to Unity's Vector Type Equivalent
        [MethodImpl(INLINE)] public static Vector2 cast(this double2 f) => f.asfloat();
        /// <inheritdoc cref="cast(double2)"/>
        [MethodImpl(INLINE)] public static Vector3 cast(this double3 f) => f.asfloat();
        /// <inheritdoc cref="cast(double2)"/>
        [MethodImpl(INLINE)] public static Vector4 cast(this double4 f) => f.asfloat();

        /// Casts to a float4x4
        [MethodImpl(INLINE)] public static float4x4 cast(this Matrix4x4 f) => f;
        /// Casts to Matrix4x4
        [MethodImpl(INLINE)] public static Matrix4x4 cast(this float4x4 f) => f;

        /// casts to a Unity.Mathematics.color (interop created type)
        [MethodImpl(INLINE)] public static color cast(this Color f) => f;
        /// casts to a UnityEngine.Color
        [MethodImpl(INLINE)] public static Color cast(this color f) => f;

    }
}