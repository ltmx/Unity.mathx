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
        #region dim

        /// Scales a vector by a scalar.
        [MethodImpl(IL)] public static float dim(this float a, float b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, float2 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, float3 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, float4 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, float b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, float b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, float b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double dim(this double a, double b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double2 a, double2 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double3 a, double3 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double4 a, double4 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double2 a, double b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double3 a, double b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double4 a, double b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this int a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, int2 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, int3 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, int4 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this int a, float b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int2 a, float2 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int3 a, float3 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int4 a, float4 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int2 a, float b) => (float2)a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int3 a, float b) => (float3)a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int4 a, float b) => (float4)a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this float a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, int2 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, int3 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, int4 b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, int b) => a * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float a, float2 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float a, float3 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float a, float4 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this int a, float2 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this int a, float3 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this int a, float4 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double a, double2 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double a, double3 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double a, double4 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this int a, double2 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this int a, double3 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this int a, double4 b) => b * a;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double2 dim(this double a, int2 b) => new(a * b.x, a * b.y);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double3 dim(this double a, int3 b) => new(a * b.x, a * b.y, a * b.z);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static double4 dim(this double a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float a, int2 b) => new(a * b.x, a * b.y);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float a, int3 b) => new(a * b.x, a * b.y, a * b.z);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float a, int4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this float a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, bool2 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, bool3 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, bool4 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this float2 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this float3 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this float4 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float dim(this bool a, float b) => b.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this bool2 a, float2 b) => a.asfloat() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this bool3 a, float3 b) => a.asfloat() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this bool4 a, float4 b) => a.asfloat() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float2 dim(this bool a, float2 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float3 dim(this bool a, float3 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static float4 dim(this bool a, float4 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this bool a, int b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this bool2 a, int2 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this bool3 a, int3 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this bool4 a, int4 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this bool a, int2 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this bool a, int3 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this bool a, int4 b) => a.asint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int dim(this int a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, bool2 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, bool3 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, bool4 b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int2 dim(this int2 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int3 dim(this int3 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static int4 dim(this int4 a, bool b) => a * b.asint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint dim(this bool a, uint b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this bool2 a, uint2 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this bool3 a, uint3 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this bool4 a, uint4 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this bool a, uint2 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this bool a, uint3 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this bool a, uint4 b) => a.asuint() * b;

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint dim(this uint a, bool b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this uint2 a, bool2 b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this uint3 a, bool3 b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this uint4 a, bool4 b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint2 dim(this uint2 a, bool b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint3 dim(this uint3 a, bool b) => a * b.asuint();

        /// <inheritdoc cref="dim(float, float)"/>
        [MethodImpl(IL)] public static uint4 dim(this uint4 a, bool b) => a * b.asuint();

        #endregion
    }
}