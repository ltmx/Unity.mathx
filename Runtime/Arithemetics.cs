using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static partial class UnityMathematicsExtensions
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
        
        public static double4 sum(this double4 f) => math.csum(f);
        public static double3 sum(this double3 f) => math.csum(f);
        public static double2 sum(this double2 f) => math.csum(f);

        // Component-Wise Multiplication ---------------------------------------------------------------

        public static float cmul(this float4 f) => f.x * f.y * f.z * f.w;
        public static float cmul(this float3 f) => f.x * f.y * f.z;
        public static float cmul(this float2 f) => f.x * f.y;

        public static float cmul(this Vector4 f) => f.x * f.y * f.z * f.w;
        public static float cmul(this Vector3 f) => f.x * f.y * f.z;
        public static float cmul(this Vector2 f) => f.x * f.y;
        
        public static int cmul(this int4 f) => f.x * f.y * f.z * f.w;
        public static int cmul(this int3 f) => f.x * f.y * f.z;
        public static int cmul(this int2 f) => f.x * f.y;
        
        public static double4 cmul(this double4 f) => f.x * f.y * f.z * f.w;
        public static double3 cmul(this double3 f) => f.x * f.y * f.z;
        public static double2 cmul(this double2 f) => f.x * f.y;
        
        
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
        
        public static float4 onem(this Vector4 f) => 1 - f.asfloat();
        public static float3 onem(this Vector3 f) => 1 - f.asfloat();
        public static float2 onem(this Vector2 f) => 1 - f.asfloat();
        
     
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

        
        public static float4 exp(this Vector4 f, float4 pow) => math.pow(f, pow);
        public static float3 exp(this Vector3 f, float3 pow) => math.pow(f, pow);
        public static float2 exp(this Vector2 f, float2 pow) => math.pow(f, pow);

        public static double4 pow(this double4 f, double4 min) => math.pow(f, min);
        public static double3 pow(this double3 f, double3 min) => math.pow(f, min);
        public static double2 pow(this double2 f, double2 min) => math.pow(f, min);
        public static double pow(this double f, double min) => math.pow(f, min);
        

        // Square ---------------------------------------------------------------------------------
        
        public static float4 sqr(this float4 f) => f * f;
        public static float3 sqr(this float3 f) => f * f;
        public static float2 sqr(this float2 f) => f * f;
        public static float sqr(this float f) => f * f;
        public static float sqr(this int f) => f * f;
        
        public static float4 sqr(this Vector4 f) => f.asfloat() * f;
        public static float3 sqr(this Vector3 f) => f.asfloat() * f;
        public static float2 sqr(this Vector2 f) => f * f;
        
        public static double4 sqr(this double4 f) => f * f;
        public static double3 sqr(this double3 f) => f * f;
        public static double2 sqr(this double2 f) => f * f;
        public static double sqr(this double f) => f * f;
        
        // Cube --------------------------------------------------
        
        public static float4 cube(this float4 f) => f * f * f;
        public static float3 cube(this float3 f) => f * f * f;
        public static float2 cube(this float2 f) => f * f * f;
        public static float cube(this float f) => f * f * f;
        public static int cube(this int f) => f * f * f;
        
        public static float4 cube(this Vector4 f) => f.asfloat() * f * f;
        public static float3 cube(this Vector3 f) => f.asfloat() * f * f;
        public static float2 cube(this Vector2 f) => f * f;
        
        public static double4 cube(this double4 f) => f * f * f;
        public static double3 cube(this double3 f) => f * f * f;
        public static double2 cube(this double2 f) => f * f * f;
        public static double cube(this double f) => f * f * f;
        
        // Quart--------------------------------------------------
        
        public static float4 quart(this float4 f) => f * f * f * f;
        public static float3 quart(this float3 f) => f * f * f * f;
        public static float2 quart(this float2 f) => f * f * f * f;
        public static float quart(this float f) => f * f * f * f;
        public static int quart(this int f) => f * f * f * f;
        
        public static float4 quart(this Vector4 f) => f.asfloat() * f * f * f;
        public static float3 quart(this Vector3 f) => f.asfloat() * f * f * f;
        public static float2 quart(this Vector2 f) => f * f * f * f;
        
        public static double4 quart(this double4 f) => f * f * f * f;
        public static double3 quart(this double3 f) => f * f * f * f;
        public static double2 quart(this double2 f) => f * f * f * f;
        public static double quart(this double f) => f * f * f * f;
        
        // Quint --------------------------------------------------
        
        public static float4 quint(this float4 f) => f * f * f * f * f;
        public static float3 quint(this float3 f) => f * f * f * f * f;
        public static float2 quint(this float2 f) => f * f * f * f * f;
        public static float quint(this float f) => f * f * f * f * f;
        public static int quint(this int f) => f * f * f * f * f;
        
        public static float4 quint(this Vector4 f) => f.asfloat() * f * f * f * f;
        public static float3 quint(this Vector3 f) => f.asfloat() * f * f * f * f;
        public static float2 quint(this Vector2 f) => f * f * f * f * f;
        
        public static double4 quint(this double4 f) => f * f * f * f * f;
        public static double3 quint(this double3 f) => f * f * f * f * f;
        public static double2 quint(this double2 f) => f * f * f * f * f;
        public static double quint(this double f) => f * f * f * f * f;
        
        
        // Fractional Remainder
        public static float4 frac(this float4 f) => math.frac(f);
        public static float3 frac(this float3 f) => math.frac(f);
        public static float2 frac(this float2 f) => math.frac(f);
        public static float frac(this float f) => math.frac(f);
        
        public static float4 frac(this Vector4 f) => math.frac(f);
        public static float3 frac(this Vector3 f) => math.frac(f);
        public static float2 frac(this Vector2 f) => math.frac(f);
        
        public static double4 frac(this double4 f) => math.frac(f);
        public static double3 frac(this double3 f) => math.frac(f);
        public static double2 frac(this double2 f) => math.frac(f);
        public static double frac(this double f) => math.frac(f);
        
        // Matrix Multiplication ------------------------------------
        
        /// Returns the component sum of f², Equivalent to a matrix multiplication with itself as row and column;
        public static float selfmul(this float4 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float3 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float2 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this float f) => math.mul(f,f);
        
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector4 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector3 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static float selfmul(this Vector2 f) => math.mul(f,f);
        
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double4 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double3 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double2 f) => math.mul(f,f);
        /// <inheritdoc cref="selfmul(float4)"/>
        public static double selfmul(this double f) => math.mul(f,f);
    }
}