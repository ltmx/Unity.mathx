#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static float[] Array(this float4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static float[] Array(this float3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static float[] Array(this float2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static double[] Array(this double4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static double[] Array(this double3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(double4)"/>
        [MethodImpl(IL)] public static double[] Array(this double2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static half[] Array(this half4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static half[] Array(this half3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(half4)"/>
        [MethodImpl(IL)] public static half[] Array(this half2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static uint[] Array(this uint4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static uint[] Array(this uint3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(uint4)"/>
        [MethodImpl(IL)] public static uint[] Array(this uint2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static int[] Array(this int4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static int[] Array(this int3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(int4)"/>
        [MethodImpl(IL)] public static int[] Array(this int2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        [MethodImpl(IL)] public static bool[] Array(this bool4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static bool[] Array(this bool3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(bool4)"/>
        [MethodImpl(IL)] public static bool[] Array(this bool2 f) => new[]{f.x, f.y};
        
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static float[] Array(this Vector4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)] public static float[] Array(this Vector3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(float4)"/>
        [MethodImpl(IL)]  public static float[] Array(this Vector2 f) => new[]{f.x, f.y};
        
        /// <summary> Returns an array containing individual components of this vector </summary>
        public static float[] Array(this float2x2 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y};
        /// <inheritdoc cref="Array(Mathematics.float2x2)"/>
        public static float[] Array(this float2x3 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y};
        public static float[] Array(this float2x4 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y, f.c3.x, f.c3.y};
        public static float[] Array(this float3x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z};
        public static float[] Array(this float3x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z};
        public static float[] Array(this float3x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z, f.c3.x, f.c3.y, f.c3.z};
        public static float[] Array(this float4x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w};
        public static float[] Array(this float4x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w};
        public static float[] Array(this float4x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w, f.c3.x, f.c3.y, f.c3.z, f.c3.w};
        
        public static double[] Array(this double2x2 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y};
        public static double[] Array(this double2x3 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y};
        public static double[] Array(this double2x4 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y, f.c3.x, f.c3.y};
        public static double[] Array(this double3x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z};
        public static double[] Array(this double3x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z};
        public static double[] Array(this double3x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z, f.c3.x, f.c3.y, f.c3.z};
        public static double[] Array(this double4x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w};
        public static double[] Array(this double4x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w};
        public static double[] Array(this double4x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w, f.c3.x, f.c3.y, f.c3.z, f.c3.w};
        
        public static int[] Array(this int2x2 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y};
        public static int[] Array(this int2x3 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y};
        public static int[] Array(this int2x4 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y, f.c3.x, f.c3.y};
        public static int[] Array(this int3x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z};
        public static int[] Array(this int3x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z};
        public static int[] Array(this int3x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z, f.c3.x, f.c3.y, f.c3.z};
        public static int[] Array(this int4x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w};
        public static int[] Array(this int4x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w};
        public static int[] Array(this int4x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w, f.c3.x, f.c3.y, f.c3.z, f.c3.w};
        
        public static bool[] Array(this bool2x2 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y};
        public static bool[] Array(this bool2x3 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y};
        public static bool[] Array(this bool2x4 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y, f.c3.x, f.c3.y};
        public static bool[] Array(this bool3x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z};
        public static bool[] Array(this bool3x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z};
        public static bool[] Array(this bool3x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z, f.c3.x, f.c3.y, f.c3.z};
        public static bool[] Array(this bool4x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w};
        public static bool[] Array(this bool4x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w};
        public static bool[] Array(this bool4x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w, f.c3.x, f.c3.y, f.c3.z, f.c3.w};
        
        public static uint[] Array(this uint2x2 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y};
        public static uint[] Array(this uint2x3 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y};
        public static uint[] Array(this uint2x4 f) => new[]{f.c0.x, f.c0.y, f.c1.x, f.c1.y, f.c2.x, f.c2.y, f.c3.x, f.c3.y};
        public static uint[] Array(this uint3x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z};
        public static uint[] Array(this uint3x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z};
        public static uint[] Array(this uint3x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c1.x, f.c1.y, f.c1.z, f.c2.x, f.c2.y, f.c2.z, f.c3.x, f.c3.y, f.c3.z};
        public static uint[] Array(this uint4x2 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w};
        public static uint[] Array(this uint4x3 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w};
        public static uint[] Array(this uint4x4 f) => new[]{f.c0.x, f.c0.y, f.c0.z, f.c0.w, f.c1.x, f.c1.y, f.c1.z, f.c1.w, f.c2.x, f.c2.y, f.c2.z, f.c2.w, f.c3.x, f.c3.y, f.c3.z, f.c3.w};


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

        /// Converts to a f4 List
        [MethodImpl(IL)] public static List<float4> tofloat4List(this IEnumerable<Color> colors) => colors.tofloat4IE().ToList();
        /// <inheritdoc cref="tofloat4List(IEnumerable{Color})"/>
        [MethodImpl(IL)] public static List<float3> tofloat3List(this IEnumerable<Color> colors) => colors.tofloat3IE().ToList();

        /// Converts to a f4 Array
        [MethodImpl(IL)] public static float4[] tofloat4Array(this IEnumerable<Color> colors) => colors.tofloat4IE().ToArray();
        /// Converts to a f3 Array
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
        
        
        /// <summary> Returns a NativeArray containing individual components of this vector </summary>
        [MethodImpl(IL)] public static void CopyFrom(this NativeArray<float> na, float4 f) => na.CopyFrom(f.Array());
        /// <inheritdoc cref="CopyFrom(NativeArray{float}, float4)"/>
        [MethodImpl(IL)] public static void CopyFrom(this NativeArray<float> na, float3 f) => na.CopyFrom(f.Array());
        /// <inheritdoc cref="CopyFrom(NativeArray{float}, float4)"/>
        [MethodImpl(IL)] public static void CopyFrom(this NativeArray<float> na, float2 f) => na.CopyFrom(f.Array());
        
    }
}
