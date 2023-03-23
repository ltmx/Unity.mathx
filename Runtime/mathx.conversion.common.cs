#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

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
        #region asint

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
        
        /// Returns 1 when true, zero otherwise, componentwise
        [MethodImpl(IL)] public static int4 asint(this bool4 b) => (int4) b;
        /// <inheritdoc cref="asint(bool4)"/>
        [MethodImpl(IL)] public static int3 asint(this bool3 b) => (int3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static int2 asint(this bool2 b) => (int2) b;
        /// Returns 1 when true, zero otherwise
        [MethodImpl(IL)] public static int asint(this bool b) => b ? 1 : 0;
        
        /// Cast to int4
        [MethodImpl(IL)] public static int4 asint(this uint4 b) => (int4)b;
        /// Cast to int3
        [MethodImpl(IL)] public static int3 asint(this uint3 b) => (int3)b;
        /// Cast to int2
        [MethodImpl(IL)] public static int2 asint(this uint2 b) => (int2)b;
        /// Cast to int
        [MethodImpl(IL)] public static int asint(this uint b) => (int)b;

        #endregion
        
        #region asbool

        /// Return an equivalent bool-type
        [MethodImpl(IL)] public static bool4 asbool(this int4 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool3 asbool(this int3 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool2 asbool(this int2 f) => f != 0;
        /// <inheritdoc cref="asbool(int4)"/>
        [MethodImpl(IL)] public static bool asbool(this int f) => f != 0;
        
        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static bool4 asbool(this uint4 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool3 asbool(this uint3 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool2 asbool(this uint2 b) => b != 0;
        /// Returns true when not zero
        [MethodImpl(IL)] public static bool asbool(this uint b) => b != 0;
        
        
        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static bool4 asbool(this byte4 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool3 asbool(this byte3 b) => b != 0;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static bool2 asbool(this byte2 b) => b != 0;
        /// Returns true when not zero
        [MethodImpl(IL)] public static bool asbool(this byte1 b) => b != 0;
        /// Returns true when not zero
        [MethodImpl(IL)] public static bool asbool(this byte b) => b != 0;

        #endregion

        #region asfloat

        /// Returns equivalent float-type
        [MethodImpl(IL)] public static float4 asfloat(this int4 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this int3 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this int2 f) => f;
        /// <inheritdoc cref="asfloat(int4)"/>
        [MethodImpl(IL)] public static float asfloat(this int f) => f;
        
        /// Returns a float-type equivalent
        [MethodImpl(IL)] public static float4 asfloat(this Vector4 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this Vector3 f) => f;
        /// <inheritdoc cref="asfloat(Vector4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this Vector2 f) => f;

        /// Returns a f4 equivalent
        [MethodImpl(IL)] public static float4 asfloat(this Color f) => f.cast();
        /// Returns a f4 equivalent
        [MethodImpl(IL)] public static float4 asfloat(this color f) => f; // Compatibility
        
        
        /// Returns 1 when true, zero otherwise, componentwise
        [MethodImpl(IL)] public static float4 asfloat(this bool4 b) => (float4) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this bool3 b) => (float3) b;
        /// <inheritdoc cref="asfloat(bool4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this bool2 b) => (float2) b;
        /// Returns 1 when true, zero otherwise
        [MethodImpl(IL)] public static float asfloat(this bool b) => b ? 1 : 0;
        
        
        /// Returns a float-type equivalent
        [MethodImpl(IL)] public static float4 asfloat(this double4 f) => (float4)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float3 asfloat(this double3 f) => (float3)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float2 asfloat(this double2 f) => (float2)f;
        /// <inheritdoc cref="asfloat(double4)"/>
        [MethodImpl(IL)] public static float asfloat(this double f) => (float)f;
        
        /// Returns a f4 from the quaternion's components
        [MethodImpl(IL)] public static float4 asfloat(this quaternion q) => q.value;

        #endregion
        
        #region asdouble

        /// Cast to double4
        [MethodImpl(IL)] public static double4 asdouble(this float4 f) => f;
        /// Cast to double3
        [MethodImpl(IL)] public static double3 asdouble(this float3 f) => f;
        /// Cast to double2
        [MethodImpl(IL)] public static double2 asdouble(this float2 f) => f;
        /// Cast to double
        [MethodImpl(IL)] public static double asdouble(this float f) => f;
        
        /// Returns a double2 equivalent
        [MethodImpl(IL)] public static double2 asdouble(this Complex f) => new(f.Real, f.Imaginary);

        #endregion

        #region asuint

        /// Returns 1 when true, zero otherwise componentwise
        [MethodImpl(IL)] public static uint4 asuint(this bool4 b) => (uint4) b;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static uint3 asuint(this bool3 b) => (uint3) b;
        /// <inheritdoc cref="asuint(bool4)"/>
        [MethodImpl(IL)] public static uint2 asuint(this bool2 b) => (uint2) b;
        /// Returns 1 when true, zero otherwise
        [MethodImpl(IL)] public static uint asuint(this bool b) => b ? 1u : 0u;
        
        /// Cast to uint4
        [MethodImpl(IL)] public static uint4 asuint(this int4 b) => (uint4)b;
        /// Cast to uint3
        [MethodImpl(IL)] public static uint3 asuint(this int3 b) => (uint3)b;
        /// Cast to uint2
        [MethodImpl(IL)] public static uint2 asuint(this int2 b) => (uint2)b;
        /// Cast to uint
        [MethodImpl(IL)] public static uint asuint(this int b) => (uint)b;
        
        /// Cast to uint4
        [MethodImpl(IL)] public static uint4 asuint(this float4 b) => (uint4)b;
        /// Cast to uint3
        [MethodImpl(IL)] public static uint3 asuint(this float3 b) => (uint3)b;
        /// Cast to uint2
        [MethodImpl(IL)] public static uint2 asuint(this float2 b) => (uint2)b;
        /// Cast to uint
        [MethodImpl(IL)] public static uint asuint(this float b) => (uint)b;

        #endregion

        #region ascolor and others

        /// Converts a float-type to a Unity.Mathematics.color
        [MethodImpl(IL)] public static color ascolor(this float4 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float3 f) => f;
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float2 f) => new(f.xy, 0, 1);
        /// <inheritdoc cref="ascolor(float4)"/>
        [MethodImpl(IL)] public static color ascolor(this float f) => f;
        
        /// Converts a float-type to a Unity.Mathematics.color
        [MethodImpl(IL)] public static Color asColor(this float4 f) => new(f.x, f.y, f.z, f.w);
        /// <inheritdoc cref="asColor(float4)"/>
        [MethodImpl(IL)] public static Color asColor(this float3 f) => new(f.x, f.y, f.z, 1);
        /// <inheritdoc cref="asColor(float4)"/>
        [MethodImpl(IL)] public static Color asColor(this float2 f) => new(f.x, f.y, 0, 1);
        /// <inheritdoc cref="asColor(float4)"/>
        [MethodImpl(IL)] public static Color asColor(this float f) => new(f,f,f, 1);
        
        /// Converts to a f4
        [MethodImpl(IL)] public static float4 asfloat4(this Color f) => new(f.r, f.g, f.b, f.a); // compatibility
        /// Converts to a f3
        [MethodImpl(IL)] public static float3 asfloat3(this Color f) => new(f.r, f.g, f.b);
        /// Converts to a f3
        [MethodImpl(IL)] public static float3 asfloat3(this color f) => (float3) f;

        #endregion

        #region cast

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
        

        #endregion
    }
}