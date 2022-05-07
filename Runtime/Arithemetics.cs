using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;


namespace Unity.Mathematics
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    
    public static partial class Math
    {
        // Sign
        public static float4 sign(this float4 f) => math.sign(f);
        public static float3 sign(this float3 f) => math.sign(f);
        public static float2 sign(this float2 f) => math.sign(f);
        public static float sign(this float f) => math.sign(f);
        public static int sign(this int f) => (int)math.sign(f);
        
        public static float4 sign(this Vector4 f) => math.sign(f);
        public static float3 sign(this Vector3 f) => math.sign(f);
        public static float2 sign(this Vector2 f) => math.sign(f);
        
        public static double4 sign(this double4 f) => math.sign(f);
        public static double3 sign(this double3 f) => math.sign(f);
        public static double2 sign(this double2 f) => math.sign(f);
        public static double sign(this double f) => math.sign(f);
        
        
        // Absolute Value ------------------------------------------------------------------------------
        
        public static float4 abs(this float4 f) => math.abs(f);
        public static float3 abs(this float3 f) => math.abs(f);
        public static float2 abs(this float2 f) => math.abs(f);
        public static float abs(this float f) => math.abs(f);
        public static int abs(this int f) => math.abs(f);
        
        public static float4 abs(this Vector4 f) => math.abs(f);
        public static float3 abs(this Vector3 f) => math.abs(f);
        public static float2 abs(this Vector2 f) => math.abs(f);
        
        public static double4 abs(this double4 f) => math.abs(f);
        public static double3 abs(this double3 f) => math.abs(f);
        public static double2 abs(this double2 f) => math.abs(f);
        public static double abs(this double f) => math.abs(f);


        // Component-Wise Sum --------------------------------------------------------------------------
        public static float sum(this float4 f) => math.csum(f);
        public static float sum(this float3 f) => math.csum(f);
        public static float sum(this float2 f) => math.csum(f);
        
        public static float sum(this Vector4 f) => math.csum(f);
        public static float sum(this Vector3 f) => math.csum(f);
        public static float sum(this Vector2 f) => math.csum(f);
        
        public static int sum(this int4 f) => math.csum(f);
        public static int sum(this int3 f) => math.csum(f);
        public static int sum(this int2 f) => math.csum(f);
        
        public static double sum(this double4 f) => math.csum(f);
        public static double sum(this double3 f) => math.csum(f);
        public static double sum(this double2 f) => math.csum(f);

        // Component-Wise Multiplication ---------------------------------------------------------------

        [MethodImpl(AggressiveInlining)]
        public static float cmul(this float4 f) => f.x * f.y * f.z * f.w;
        [MethodImpl(AggressiveInlining)]
        public static float cmul(this float3 f) => f.x * f.y * f.z;
        [MethodImpl(AggressiveInlining)]
        public static float cmul(this float2 f) => f.x * f.y;

        [MethodImpl(AggressiveInlining)]
        public static float cmul(this Vector4 f) => f.x * f.y * f.z * f.w;
        [MethodImpl(AggressiveInlining)]
        public static float cmul(this Vector3 f) => f.x * f.y * f.z;
        [MethodImpl(AggressiveInlining)]
        public static float cmul(this Vector2 f) => f.x * f.y;
        
        [MethodImpl(AggressiveInlining)]
        public static int cmul(this int4 f) => f.x * f.y * f.z * f.w;
        [MethodImpl(AggressiveInlining)]
        public static int cmul(this int3 f) => f.x * f.y * f.z;
        [MethodImpl(AggressiveInlining)]
        public static int cmul(this int2 f) => f.x * f.y;
        
        [MethodImpl(AggressiveInlining)]
        public static double cmul(this double4 f) => f.x * f.y * f.z * f.w;
        [MethodImpl(AggressiveInlining)]
        public static double cmul(this double3 f) => f.x * f.y * f.z;
        [MethodImpl(AggressiveInlining)]
        public static double cmul(this double2 f) => f.x * f.y;


        // One Minus -----------------------------------------------------------------------------------

        public static float4 onem(this float4 f) => 1 - f;
        public static float3 onem(this float3 f) => 1 - f;
        public static float2 onem(this float2 f) => 1 - f;
        public static float onem(this float f) => 1 - f;
        public static int onem(this int f) => 1 - f;
        
        public static double4 onem(this double4 f) => 1 - f;
        public static double3 onem(this double3 f) => 1 - f;
        public static double2 onem(this double2 f) => 1 - f;
        public static double onem(this double f) => 1 - f;
        
        public static float4 onem(this Vector4 f) => 1 - f.cast();
        public static float3 onem(this Vector3 f) => 1 - f.cast();
        public static float2 onem(this Vector2 f) => 1 - f.cast();

        // Negate -----------------------------------------------------------------------------------

        public static float4 neg(this float4 f) => - f;
        public static float3 neg(this float3 f) => - f;
        public static float2 neg(this float2 f) => - f;
        public static float neg(this float f) => - f;
        public static int neg(this int f) => - f;
        
        public static double4 neg(this double4 f) => - f;
        public static double3 neg(this double3 f) => - f;
        public static double2 neg(this double2 f) => - f;
        public static double neg(this double f) => - f;
        
        public static float4 neg(this Vector4 f) => - f;
        public static float3 neg(this Vector3 f) => - f;
        public static float2 neg(this Vector2 f) => - f;


        // Reciprocal ----------------------------------------------------------------------------------
        
        public static float4 rcp(this float4 f) => math.rcp(f);
        public static float3 rcp(this float3 f) => math.rcp(f);
        public static float2 rcp(this float2 f) => math.rcp(f);
        public static float rcp(this float f) => math.rcp(f);
        public static float rcp(this int f) => math.rcp(f);
        
        public static float4 rcp(this Vector4 f) => math.rcp(f);
        public static float3 rcp(this Vector3 f) => math.rcp(f);
        public static float2 rcp(this Vector2 f) => math.rcp(f);
        
        public static double4 rcp(this double4 f) => math.rcp(f);
        public static double3 rcp(this double3 f) => math.rcp(f);
        public static double2 rcp(this double2 f) => math.rcp(f);
        public static double rcp(this double f) => math.rcp(f);



        // Power ---------------------------------------------------------------------------------

        public static float4 pow(this float4 f, float4 pow) => math.pow(f, pow);
        public static float3 pow(this float3 f, float3 pow) => math.pow(f, pow);
        public static float2 pow(this float2 f, float2 pow) => math.pow(f, pow);
        public static float pow(this float f, float pow) => math.pow(f, pow);
        public static float pow(this int f, float pow) => math.pow(f, pow);
        public static int pow(this int f, int pow) => (int)math.pow(f, pow);

        public static float4 pow(this Vector4 f, float4 pow) => math.pow(f, pow);
        public static float3 pow(this Vector3 f, float3 pow) => math.pow(f, pow);
        public static float2 pow(this Vector2 f, float2 pow) => math.pow(f, pow);

        public static double4 pow(this double4 f, double4 min) => math.pow(f, min);
        public static double3 pow(this double3 f, double3 min) => math.pow(f, min);
        public static double2 pow(this double2 f, double2 min) => math.pow(f, min);
        public static double pow(this double f, double min) => math.pow(f, min);
        

        // Square ---------------------------------------------------------------------------------
        
        public static float4 sq(this float4 f) => f * f;
        public static float3 sq(this float3 f) => f * f;
        public static float2 sq(this float2 f) => f * f;
        public static float sq(this float f) => f * f;
        public static int sq(this int f) => f * f;
        
        public static float4 sq(this Vector4 f) => f.cast() * f;
        public static float3 sq(this Vector3 f) => f.cast() * f;
        public static float2 sq(this Vector2 f) => f * f;
        
        public static double4 sq(this double4 f) => f * f;
        public static double3 sq(this double3 f) => f * f;
        public static double2 sq(this double2 f) => f * f;
        public static double sq(this double f) => f * f;

        // Cube --------------------------------------------------
        
        /// <summary> returns x * x * x </summary>
        public static float4 cube(this float4 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static float3 cube(this float3 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static float2 cube(this float2 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static float cube(this float f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static int cube(this int f) => f * f * f;
        
        /// <inheritdoc cref="cube(float4)"/>
        public static float4 cube(this Vector4 f) => f.cast().cube();
        /// <inheritdoc cref="cube(float4)"/>
        public static float3 cube(this Vector3 f) => f.cast().cube();
        /// <inheritdoc cref="cube(float4)"/>
        public static float2 cube(this Vector2 f) => f.cast().cube();
        
        /// <inheritdoc cref="cube(float4)"/>
        public static double4 cube(this double4 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static double3 cube(this double3 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static double2 cube(this double2 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        public static double cube(this double f) => f * f * f;

        // Quart--------------------------------------------------
        
        public static float4 pow4(this float4 f) => f * f * (f * f);
        public static float3 pow4(this float3 f) => f * f * (f * f);
        public static float2 pow4(this float2 f) => f * f * (f * f);
        public static float pow4(this float f) => f * f * (f * f);
        public static int pow4(this int f) => f * f * (f * f);
        
        public static float4 pow4(this Vector4 f) => f.cast().pow4();
        public static float3 pow4(this Vector3 f) => f.cast().pow4();
        public static float2 pow4(this Vector2 f) => f.cast().pow4();
        
        public static double4 pow4(this double4 f) => f * f * (f * f);
        public static double3 pow4(this double3 f) => f * f * (f * f);
        public static double2 pow4(this double2 f) => f * f * (f * f);
        public static double pow4(this double f) => f * f * (f * f);

        // Quint --------------------------------------------------
        
        public static float4 pow5(this float4 f) => f.sq().sq() * f;
        public static float3 pow5(this float3 f) => f.sq().sq() * f;
        public static float2 pow5(this float2 f) => f.sq().sq() * f;
        public static float pow5(this float f) => f.sq().sq() * f;
        public static int pow5(this int f) => f.sq().sq() * f;
        
        public static float4 pow5(this Vector4 f) => f.cast().pow5();
        public static float3 pow5(this Vector3 f) => f.cast().pow5();
        public static float2 pow5(this Vector2 f) => f.cast().pow5();
        
        public static double4 pow5(this double4 f) => f.sq().sq() * f;
        public static double3 pow5(this double3 f) => f.sq().sq() * f;
        public static double2 pow5(this double2 f) => f.sq().sq() * f;
        public static double pow5(this double f) => f.sq().sq() * f;


        // Fractional Remainder (f - (int)f) is x3 faster than math.frac()
        public static float4 frac(this float4 f) => f - (int4)f;
        public static float3 frac(this float3 f) => f - (int3)f;
        public static float2 frac(this float2 f) => f - (int2)f;
        public static float frac(this float f) => f - (int)f;
        
        public static float4 frac(this Vector4 f) => f.cast() - f.asint();
        public static float3 frac(this Vector3 f) => f.cast() - f.asint();
        public static float2 frac(this Vector2 f) => f.cast() - f.asint();
        
        public static double4 frac(this double4 f) => f - (int4)f;
        public static double3 frac(this double3 f) => f - (int3)f;
        public static double2 frac(this double2 f) => f - (int2)f;
        public static double frac(this double f) => f - (int)f;

        // Matrix Multiplication ------------------------------------
        
        /// Returns the component sum of f², Equivalent to a matrix multiplication with itself as row and column;
        public static float selfmul(this float4 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float3 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float2 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float f) => math.mul(f, f);
        
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector4 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector3 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector2 f) => math.mul(f, f);
        
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double4 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double3 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double2 f) => math.mul(f, f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double f) => math.mul(f, f);
        
        
        
        // logic ----------------------------------------------------

        /// returns true if any of the components is true
        public static bool any(this bool4 b) => b.x || b.y || b.z || b.w;
        /// returns true in all components are true
        public static bool all(this bool4 b) => b.x && b.y && b.z && b.w;
        
        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool3 b) => b.x || b.y || b.z;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool3 b) => b.x && b.y && b.z;

        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool2 b) => b.x || b.y;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool2 b) => b.x && b.y;
        
        // WIP --------------------
        public static float4 select(this bool4 b, float4 ifIsTrue, float4 ifIsFalse) => new (b.asfloat().lerp(ifIsFalse, ifIsTrue)); // lerp order is reversed compared to boolean seelection
        public static float3 select(this bool3 b, float3 ifIsTrue, float3 ifIsFalse) => new (b.asfloat().lerp(ifIsFalse, ifIsTrue));
        public static float2 select(this bool2 b, float2 ifIsTrue, float2 ifIsFalse) => b.asfloat().lerp(ifIsFalse, ifIsTrue);
        
        public static float4 select(this bool b, float4 ifIsTrue, float4 ifIsFalse) => b ? ifIsTrue : ifIsFalse;
        public static float3 select(this bool b, float3 ifIsTrue, float3 ifIsFalse) => b ? ifIsTrue : ifIsFalse;
        public static float2 select(this bool b, float2 ifIsTrue, float2 ifIsFalse) => b ? ifIsTrue : ifIsFalse;
        public static float select(this bool b, float ifIsTrue, float ifIsFalse) => b ? ifIsTrue : ifIsFalse;

        // public static float select(this int b, float ifIsTrue, float ifIsFalse) => b.asbool().select(ifIsTrue, ifIsFalse);
        // public static float2 select(this int b, float2 ifIsTrue, float2 ifIsFalse) => b.asbool().select(ifIsTrue, ifIsFalse);
        // public static float3 select(this int b, float3 ifIsTrue, float3 ifIsFalse) => b.asbool().select(ifIsTrue, ifIsFalse);
        // public static float4 select(this int b, float4 ifIsTrue, float4 ifIsFalse) => b.asbool().select(ifIsTrue, ifIsFalse);
        public static T select<T>(this bool b, T ifIsTrue, T ifIsFalse) => b ? ifIsTrue : ifIsFalse;
        public static T select<T>(this int b, T ifIsTrue, T ifIsFalse) => b.asbool() ? ifIsTrue : ifIsFalse;

    }
}