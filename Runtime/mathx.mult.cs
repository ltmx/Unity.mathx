#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        #region mult

        /// Scales a vector by a scalar.
        [MethodImpl(IL)] public static float mult(this float a, float b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, float2 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, float3 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, float4 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, float b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, float b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, float b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double mult(this double a, double b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double2 mult(this double2 a, double2 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double3 mult(this double3 a, double3 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double4 mult(this double4 a, double4 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double2 mult(this double2 a, double b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double3 mult(this double3 a, double b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double4 mult(this double4 a, double b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int mult(this int a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this int2 a, int2 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this int3 a, int3 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this int4 a, int4 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this int2 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this int3 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this int4 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float mult(this int a, float b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this int2 a, float2 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this int3 a, float3 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this int4 a, float4 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this int2 a, float b) => (float2)a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this int3 a, float b) => (float3)a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this int4 a, float b) => (float4)a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float mult(this float a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, int2 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, int3 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, int4 b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, int b) => a * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float a, float2 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float a, float3 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float a, float4 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this int a, float2 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this int a, float3 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this int a, float4 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double2 mult(this double a, double2 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double3 mult(this double a, double3 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double4 mult(this double a, double4 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double2 mult(this int a, double2 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double3 mult(this int a, double3 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double4 mult(this int a, double4 b) => b * a;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double2 mult(this double a, int2 b) => new(a * b.x, a * b.y);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double3 mult(this double a, int3 b) => new(a * b.x, a * b.y, a * b.z);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static double4 mult(this double a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float a, int2 b) => new(a * b.x, a * b.y);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float a, int3 b) => new(a * b.x, a * b.y, a * b.z);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float mult(this float a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, bool2 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, bool3 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, bool4 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this float2 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this float3 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this float4 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float mult(this bool a, float b) => b.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this bool2 a, float2 b) => a.asfloat() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this bool3 a, float3 b) => a.asfloat() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this bool4 a, float4 b) => a.asfloat() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float2 mult(this bool a, float2 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float3 mult(this bool a, float3 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static float4 mult(this bool a, float4 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int mult(this bool a, int b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this bool2 a, int2 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this bool3 a, int3 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this bool4 a, int4 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this bool a, int2 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this bool a, int3 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this bool a, int4 b) => a.asint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int mult(this int a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this int2 a, bool2 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this int3 a, bool3 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this int4 a, bool4 b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int2 mult(this int2 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int3 mult(this int3 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static int4 mult(this int4 a, bool b) => a * b.asint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint mult(this bool a, uint b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint2 mult(this bool2 a, uint2 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint3 mult(this bool3 a, uint3 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint4 mult(this bool4 a, uint4 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint2 mult(this bool a, uint2 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint3 mult(this bool a, uint3 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint4 mult(this bool a, uint4 b) => a.asuint() * b;

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint mult(this uint a, bool b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint2 mult(this uint2 a, bool2 b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint3 mult(this uint3 a, bool3 b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint4 mult(this uint4 a, bool4 b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint2 mult(this uint2 a, bool b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint3 mult(this uint3 a, bool b) => a * b.asuint();

        /// <inheritdoc cref="mult(float,float)"/>
        [MethodImpl(IL)] public static uint4 mult(this uint4 a, bool b) => a * b.asuint();

        #endregion
    }
}