#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

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
    public static partial class mathx
    {
        /// Returns an equivalent int-type
        [MethodImpl(IL)] public static int4 asint(this float4 f) => (int4)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int3 asint(this float3 f) => (int3)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int2 asint(this float2 f) => (int2)f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int asint(this float f) => (int) f;

        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int4 asint(this Vector4 f) => new ((int)f.x, (int)f.y, (int)f.z, (int)f.w);
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int3 asint(this Vector3 f) => new ((int)f.x, (int)f.y, (int)f.z);
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int2 asint(this Vector2 f) => new ((int)f.x, (int)f.y);

        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int4 asint(this double4 f) => (int4) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int3 asint(this double3 f) => (int3) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int2 asint(this double2 f) => (int2) f;
        /// <inheritdoc cref="asint(float4)"/>>
        [MethodImpl(IL)] public static int asint(this double f) => (int) f;
        
        

        /// Return an equivalent bool-type
        [MethodImpl(IL)] public static bool4 asbool(this int4 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool3 asbool(this int3 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool2 asbool(this int2 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool asbool(this int f) => f != 0;

        
        // ints to floats -------------------------------------------
        /// Returns equivalent float-type
        [MethodImpl(IL)] public static float4 asfloat(this int4 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this int3 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this int2 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float asfloat(this int f) => f;

        
        // Vectors to floats -------------------------------------------
        /// Returns a float-type equivalent
        [MethodImpl(IL)] public static float4 asfloat(this Vector4 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this Vector3 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this Vector2 f) => f;


        // Complex conversions -------------------------------------------
        /// Returns a double2 equivalent
        [MethodImpl(IL)] public static double2 asdouble(this Complex f) => new(f.Real, f.Imaginary);
        /// Returns a float2 equivalent
        [MethodImpl(IL)] public static float2 asfloat(this Complex f) => (float2)f.asdouble();

        // Color to floats -------------------------------------------
        /// Returns a float4 equivalent
        [MethodImpl(IL)] public static float4 asfloat(this Color f) => f.cast();
        /// Returns a float4 equivalent
        [MethodImpl(IL)] public static float4 asfloat(this color f) => f; // Compatibility
        
        // bools as ints -------------------------------------------
        
        /// Returns 1 when true, componentwise
        [MethodImpl(IL)] public static int4 asint(this bool4 b) => (int4) b;
        /// <inheritdoc cref="asint(bool4)"/>
        [MethodImpl(IL)] public static int3 asint(this bool3 b) => (int3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static int2 asint(this bool2 b) => (int2) b;
        /// Returns 1 when true
        [MethodImpl(IL)] public static int asint(this bool b) => b ? 1 : 0;
        
        
        // bools as uints -------------------------------------------
        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static uint4 asuint(this bool4 b) => (uint4) b;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static uint3 asuint(this bool3 b) => (uint3) b;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static uint2 asuint(this bool2 b) => (uint2) b;
        [MethodImpl(IL)] public static uint asuint(this bool b) => b ? 1u : 0u;
        
        // ints as uints -------------------------------------------
        [MethodImpl(IL)] public static uint4 asuint(this int4 b) => (uint4)b;
        [MethodImpl(IL)] public static uint3 asuint(this int3 b) => (uint3)b;
        [MethodImpl(IL)] public static uint2 asuint(this int2 b) => (uint2)b;
        [MethodImpl(IL)] public static uint asuint(this int b) => (uint)b;
        
        // floats as uints -------------------------------------------
        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static uint4 asuint(this float4 b) => (uint4)b;
        /// <inheritdoc cref="asuint(float4)"/>
        [MethodImpl(IL)] public static uint3 asuint(this float3 b) => (uint3)b;
        /// <inheritdoc cref="asuint(float4)"/>
        [MethodImpl(IL)] public static uint2 asuint(this float2 b) => (uint2)b;
        [MethodImpl(IL)] public static uint asuint(this float b) => (uint)b;
        
        // uints as ints -------------------------------------------
        /// Cast to int4
        [MethodImpl(IL)] public static int4 asint(this uint4 b) => (int4)b;
        /// Cast to int
        [MethodImpl(IL)] public static int3 asint(this uint3 b) => (int3)b;
        /// Cast to int2
        [MethodImpl(IL)] public static int2 asint(this uint2 b) => (int2)b;
        /// Cast to int
        [MethodImpl(IL)] public static int asint(this uint b) => (int)b;
        
        // uints as floats -------------------------------------------
        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static bool4 asbool(this uint4 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool3 asbool(this uint3 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool2 asbool(this uint2 b) => b != 0;
        /// Returns true when not zero
        [MethodImpl(IL)] public static bool asbool(this uint b) => b != 0;
        
        // bools as floats -------------------------------------------
        
        /// Returns 1 when true, componentwise
        [MethodImpl(IL)] public static float4 asfloat(this bool4 b) => (float4) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this bool3 b) => (float3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this bool2 b) => (float2) b;
        /// Returns 1 when true
        [MethodImpl(IL)] public static float asfloat(this bool b) => b ? 1f : 0f;
        
        // doubles as floats -------------------------------------------
        
        /// Returns a float-type equivalent
        [MethodImpl(IL)] public static float4 asfloat(this double4 f) => (float4)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this double3 f) => (float3)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this double2 f) => (float2)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float asfloat(this double f) => (float)f;
        
        // floats as doubles -------------------------------------------
        /// Returns a double type equivalent
        [MethodImpl(IL)] public static double4 asdouble(this float4 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(IL)] public static double3 asdouble(this float3 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(IL)] public static double2 asdouble(this float2 f) => Convert.ToDouble(f);
        /// <inheritdoc cref="asdouble(float4)"/>
        [MethodImpl(IL)] public static double asdouble(this float f) => Convert.ToDouble(f);
        
        /// Returns a float4 from the quaternion's components
        [MethodImpl(IL)] public static float4 asfloat(quaternion q) => q.value;
        

        // floats as Color -------------------------------------------

        /// Converts a float-type to a Unity.Mathematics.color
        [MethodImpl(IL)] public static color ascolor(this float4 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float3 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float2 f) => new(f.xy, 0, 1);
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float f) => f;

        // Color as floats
        /// Converts to a float4
        [MethodImpl(IL)] public static float4 asfloat4(this Color f) => new(f.r, f.g, f.b, f.a); // compatibility
        /// Converts to a float3
        [MethodImpl(IL)] public static float3 asfloat3(this Color f) => new(f.r, f.g, f.b);
        /// Converts to a float3
        [MethodImpl(IL)] public static float3 asfloat3(this color f) => (float3) f;


        //IEnumerable Type Conversion -------------------------------------------------------------------

        /// Converts to a Unity Vector type List
        [MethodImpl(IL)] public static List<Vector4> toVectorList(this IEnumerable<float4> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Vector3> toVectorList(this IEnumerable<float3> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Vector2> toVectorList(this IEnumerable<float2> f) => f.toVectorIE().ToList();

        /// Converts to a float-type List
        [MethodImpl(IL)] public static List<float4> tofloatList(this IEnumerable<Vector4> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static List<float3> tofloatList(this IEnumerable<Vector3> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static List<float2> tofloatList(this IEnumerable<Vector2> f) => f.tofloatIE().ToList();

        /// Converts to a UnityEngine.Color List
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float4> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float3> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float2> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float> f) => f.toColorIE().ToList();

        /// Converts to a Unity.Mathematics.color List
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float4> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float3> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float2> f) => f.tocolorIE().ToList();

        /// Converts to a UnityEngine.Color Array
        [MethodImpl(IL)] public static Color[] toColorArray(this IEnumerable<float4> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static Color[] toColorArray(this IEnumerable<float3> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static Color[] toColorArray(this IEnumerable<float2> f) => f.toColorIE().ToArray();
        /// <inheritdoc cref="toColorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static Color[] toColorArray(this IEnumerable<float> f) => f.toColorIE().ToArray();

        /// Converts to a color Array
        [MethodImpl(IL)] public static color[] tocolorArray(this IEnumerable<float4> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static color[] tocolorArray(this IEnumerable<float3> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static color[] tocolorArray(this IEnumerable<float2> f) => f.tocolorIE().ToArray();

        /// Converts to a float4 List
        [MethodImpl(IL)] public static List<float4> tofloat4List(this IEnumerable<Color> colors) => colors.tofloat4IE().ToList();
        /// <inheritdoc cref="tofloat4List(IEnumerable{Color})"/>
        [MethodImpl(IL)] public static List<float3> tofloat3List(this IEnumerable<Color> colors) => colors.tofloat3IE().ToList();

        /// Converts to a float4 Array
        [MethodImpl(IL)] public static float4[] tofloat4Array(this IEnumerable<Color> colors) => colors.tofloat4IE().ToArray();
        /// Converts to a float3 Array
        [MethodImpl(IL)] public static float3[] tofloat3Array(this IEnumerable<Color> colors) => colors.tofloat3IE().ToArray();

        /// Converts to a Unity Vector Array
        [MethodImpl(IL)] public static Vector4[] toVectorArray(this IEnumerable<float4> f) => f.toVectorIE().ToArray();
        /// <inheritdoc cref="toVectorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static Vector3[] toVectorArray(this IEnumerable<float3> f) => f.toVectorIE().ToArray();
        /// <inheritdoc cref="toVectorArray(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static Vector2[] toVectorArray(this IEnumerable<float2> f) => f.toVectorIE().ToArray();

        /// Converts to a float-type Array
        [MethodImpl(IL)] public static float4[] tofloatArray(this IEnumerable<Vector4> f) => f.tofloatIE().ToArray();
        /// <inheritdoc cref="tofloatArray(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static float3[] tofloatArray(this IEnumerable<Vector3> f) => f.tofloatIE().ToArray();
        /// <inheritdoc cref="tofloatArray(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static float2[] tofloatArray(this IEnumerable<Vector2> f) => f.tofloatIE().ToArray();

        /// Converts to a Unity.Mathematics.color Array
        [MethodImpl(IL)] public static color[] tocolorArray(this IEnumerable<Color> f) => f.tocolorIE().ToArray();
        /// <inheritdoc cref="tocolorArray(IEnumerable{Color})"/>
        [MethodImpl(IL)] public static Color[] toColorArray(this IEnumerable<color> f) => f.toColorIE().ToArray();
        
        
        // Type Conversion SubMethods -------------------------------------------
        
        /// Converts to a Unity Vector IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Vector4> toVectorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static IEnumerable<Vector3> toVectorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static IEnumerable<Vector2> toVectorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(IL)] public static IEnumerable<float4> tofloatIE(this IEnumerable<Vector4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static IEnumerable<float3> tofloatIE(this IEnumerable<Vector3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static IEnumerable<float2> tofloatIE(this IEnumerable<Vector2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor().cast());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float> f2s) => f2s.Select(f => f.ascolor().cast());
        
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(IL)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat3());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat3());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<color> f2s) => f2s.Select(f => f.cast());
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<Color> f2s) => f2s.Select(f => f.cast());
        
        
        // Simple Casts to Classic Types -------------------------------------------
        
        /// Casts to and from Unity's Vector Types
        [MethodImpl(IL)] public static Vector2 cast(this float2 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(IL)] public static Vector3 cast(this float3 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(IL)] public static Vector4 cast(this float4 f) => f;

        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(IL)] public static float2 cast(this Vector2 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(IL)] public static float3 cast(this Vector3 f) => f;
        ///<inheritdoc cref="cast(float2)"/>
        [MethodImpl(IL)] public static float4 cast(this Vector4 f) => f;

        /// Casts to Unity's Vector Type Equivalent
        [MethodImpl(IL)] public static Vector2 cast(this double2 f) => f.asfloat();
        /// <inheritdoc cref="cast(double2)"/>
        [MethodImpl(IL)] public static Vector3 cast(this double3 f) => f.asfloat();
        /// <inheritdoc cref="cast(double2)"/>
        [MethodImpl(IL)] public static Vector4 cast(this double4 f) => f.asfloat();

        /// Casts to a float4x4
        [MethodImpl(IL)] public static float4x4 cast(this Matrix4x4 f) => f;
        /// Casts to Matrix4x4
        [MethodImpl(IL)] public static Matrix4x4 cast(this float4x4 f) => f;

        /// casts to a Unity.Mathematics.color (interop created type)
        [MethodImpl(IL)] public static color cast(this Color f) => f;
        /// casts to a UnityEngine.Color
        [MethodImpl(IL)] public static Color cast(this color f) => f;

    }
}