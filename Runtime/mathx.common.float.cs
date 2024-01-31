#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AOT;
using Unity.Burst;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        
        #region sign

        /// Returns the sign of the given value.
        /// <remarks>
        /// This implementation is 2.6x faster than math.sign.
        /// </remarks>
        [MethodImpl(IL)] public static float4 sign(this float4 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float3 sign(this float3 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float2 sign(this float2 f) => math.sign(f);
        ///<inheritdoc cref="sign(float4)"/>
        [MethodImpl(IL)] public static float sign(this float f) => math.sign(f);
        
        ///<inheritdoc cref="math.chgsign(float4,float4)"/>
        [MethodImpl(IL)] public static float4 chgsign(this float4 f, float4 y) => math.chgsign(f, y);
        ///<inheritdoc cref="math.chgsign(float3,float3)"/>
        [MethodImpl(IL)] public static float3 chgsign(this float3 f, float3 y) => math.chgsign(f, y);
        ///<inheritdoc cref="math.chgsign(float2,float2)"/>
        [MethodImpl(IL)] public static float2 chgsign(this float2 f, float2 y) => math.chgsign(f, y);
        ///<inheritdoc cref="math.chgsign(float,float)"/>
        [MethodImpl(IL)] public static float chgsign(this float f, float y) => math.chgsign(f, y);
        
        ///<inheritdoc cref="math.chgsign(float4,float4)"/>
        [MethodImpl(IL)] public static float4 chgsign(this float4 f, float y) => math.asfloat(math.asuint(f) ^ (math.asuint(y) & 0x80000000));
        ///<inheritdoc cref="math.chgsign(float3,float3)"/>
        [MethodImpl(IL)] public static float3 chgsign(this float3 f, float y) => math.asfloat(math.asuint(f) ^ (math.asuint(y) & 0x80000000));
        ///<inheritdoc cref="math.chgsign(float2,float2)"/>
        [MethodImpl(IL)] public static float2 chgsign(this float2 f, float y) => math.asfloat(math.asuint(f) ^ (math.asuint(y) & 0x80000000));

        #endregion
        
        #region abs

        /// The component-wise absolute value of the input.
        [MethodImpl(IL)] public static float4 abs(this float4 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float3 abs(this float3 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float2 abs(this float2 f) => math.abs(f);
        /// <inheritdoc cref="abs(float4)"/>
        [MethodImpl(IL)] public static float abs(this float f) => math.abs(f);

        #endregion
        
        #region mod

        /// fast mod function
        /// <remarks>
        /// approx 5% faster than math.mod()
        /// It is also exact for negative values of x;
        /// </remarks>
        [MethodImpl(IL)] public static float4 mod(this float4 f, float4 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float3 mod(this float3 f, float3 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float2 mod(this float2 f, float2 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float mod(this float f, float mod) => f % mod;
        
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float4 mod(this float4 f, int4 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float3 mod(this float3 f, int3 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float2 mod(this float2 f, int2 mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float mod(this float f, int mod) => f % mod;

        
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float4 mod(this float4 f, float mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float3 mod(this float3 f, float mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float2 mod(this float2 f, float mod) => f % mod;
        
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float4 mod(this float4 f, int mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float3 mod(this float3 f, int mod) => f % mod;
        /// <inheritdoc cref="mod(float4, float4)"/>
        [MethodImpl(IL)] public static float2 mod(this float2 f, int mod) => f % mod;

        #endregion
        
        #region frac

        /// <summary>Returns the fractional part of a float value.</summary>
        /// <remarks>Fractional Remainder (f - (int)f) is x3 faster than math.frac() (1.3.1)</remarks>
        [MethodImpl(IL)] public static float4 frac(this float4 f) => f - (int4)f;
        /// <inheritdoc cref="frac(float4)"/>
        [MethodImpl(IL)] public static float3 frac(this float3 f) => f - (int3)f;
        /// <inheritdoc cref="frac(float4)"/>
        [MethodImpl(IL)] public static float2 frac(this float2 f) => f - (int2)f;
        /// <inheritdoc cref="frac(float4)"/>
        [MethodImpl(IL)] public static float frac(this float f) => f - (int)f;
        

        #endregion
        
        #region csum

        /// Returns the csum of all components of the vector
        [MethodImpl(IL)] public static float csum(this float4 f) => math.csum(f);
        /// <inheritdoc cref="csum(float4)"/> 
        [MethodImpl(IL)] public static float csum(this float3 f) => math.csum(f);
        /// <inheritdoc cref="csum(float4)"/>
        [MethodImpl(IL)] public static float csum(this float2 f) => math.csum(f);

        #endregion

        #region cmul

        /// Returns the product of all components of the vector
        [MethodImpl(IL)] public static float cmul(this float4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this float3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(float4)"/>
        [MethodImpl(IL)] public static float cmul(this float2 f) => f.x * f.y;

        #endregion

        #region inv

        /// Returns one minus the given value. => ex : color inversion
        [MethodImpl(IL)] public static float4 inv(this float4 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float3 inv(this float3 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float2 inv(this float2 f) => 1 - f;
        /// <inheritdoc cref="inv(float4)"/>
        [MethodImpl(IL)] public static float inv(this float f) => 1 - f;

        #endregion

        #region neg

        /// Returns the negation of the given value.
        [MethodImpl(IL)] public static float4 neg(this float4 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float3 neg(this float3 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float2 neg(this float2 f) => -f;
        /// <inheritdoc cref="neg(float4)"/>
        [MethodImpl(IL)] public static float neg(this float f) => -f;
        
        #endregion
        
        #region rcp

        /// Returns the componentwise reciprocal a vector.
        [MethodImpl(IL)] public static float4 rcp(this float4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float3 rcp(this float3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float2 rcp(this float2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(float4)"/>
        [MethodImpl(IL)] public static float rcp(this float f) => math.rcp(f);

        #endregion

        #region pow

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static float4 pow(this float4 f, float4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float3 pow(this float3 f, float3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float2 pow(this float2 f, float2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float pow(this float f, float y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float4 pow(this float4 f, float pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float3 pow(this float3 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(float4,float4)"/>
        [MethodImpl(IL)] public static float2 pow(this float2 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y));

        #endregion

        #region sq

        /// Returns x^2
        [MethodImpl(IL)] public static float4 sq(this float4 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float3 sq(this float3 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float2 sq(this float2 f) => f * f;
        /// <inheritdoc cref="sq(float4)"/>
        [MethodImpl(IL)] public static float sq(this float f) => f * f;

        #endregion

        #region cube

        /// <summary> Returns x^3 </summary>
        [MethodImpl(IL)] public static float4 cube(this float4 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float3 cube(this float3 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float2 cube(this float2 f) => f * f * f;
        /// <inheritdoc cref="cube(float4)"/>
        [MethodImpl(IL)] public static float cube(this float f) => f * f * f;

        #endregion

        #region pow4

        /// <summary> Returns x^4 </summary>
        [MethodImpl(IL)] public static float4 pow4(this float4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float3 pow4(this float3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float2 pow4(this float2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(float4)"/>
        [MethodImpl(IL)] public static float pow4(this float f) => f.sq().sq();

        #endregion

        #region pow5

        /// <summary> Returns x^5 </summary>
        [MethodImpl(IL)] public static float4 pow5(this float4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float3 pow5(this float3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float2 pow5(this float2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(float4)" />
        [MethodImpl(IL)] public static float pow5(this float f) => f.sq().sq() * f;

        #endregion

        #region saturate
        /// <inheritdoc cref="math.saturate(float4)" />
        [MethodImpl(IL)] public static float4 saturate(this float4 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float3)" />
        [MethodImpl(IL)] public static float3 saturate(this float3 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float2)" />
        [MethodImpl(IL)] public static float2 saturate(this float2 f) => math.saturate(f);
        /// <inheritdoc cref="math.saturate(float)" />
        [MethodImpl(IL)] public static float saturate(this float f) => math.saturate(f);
        #endregion

        #region snap
        /// <summary> Rounds a value to the closest multiplier of snap. </summary>
        [MethodImpl(IL)] public static float4 snap(this float4 x, float4 snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float4 snap(this float4 x, float snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float3 snap(this float3 x, float3 snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float3 snap(this float3 x, float snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float2 snap(this float2 x, float2 snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float2 snap(this float2 x, float snap) => round(x / snap) * snap;
        /// <inheritdoc cref="snap(float4,float4)" />
        [MethodImpl(IL)] public static float snap(this float x, float snap) => round(x / snap) * snap;
        #endregion

        #region bitwave
        /// <summary> Samples a square wave that goes between 0 and 1. </summary>
        [MethodImpl(IL)] public static float4 bitwave(this float4 x) => floor(math.fmod(x, 2));
        /// <inheritdoc cref="bitwave(float4)" />
        [MethodImpl(IL)] public static float3 bitwave(this float3 x) => floor(math.fmod(x, 2));
        /// <inheritdoc cref="bitwave(float4)" />
        [MethodImpl(IL)] public static float2 bitwave(this float2 x) => floor(math.fmod(x, 2));
        /// <inheritdoc cref="bitwave(float4)" />
        [MethodImpl(IL)] public static float bitwave(this float x) => floor(math.fmod(x, 2));
        #endregion
        
        #region bitwave

        /// <summary> Samples a square wave that goes between 0 and 1. </summary>
        [MethodImpl(IL)] public static float4 bitwave2(this float4 x) => (int4)x & 1;
        /// <inheritdoc cref="bitwave2(float4)" />
        [MethodImpl(IL)] public static float3 bitwave2(this float3 x) => (int3)x & 1;
        /// <inheritdoc cref="bitwave2(float4)" />
        [MethodImpl(IL)] public static float2 bitwave2(this float2 x) => (int2)x & 1;
        /// <inheritdoc cref="bitwave2(float4)" />
        [MethodImpl(IL)] public static float bitwave2(this float x) => (int)x & 1;
        #endregion

        #region triwave
        /// <summary> Samples a triangle wave between +0.5f and -0.5f. </summary>
        [MethodImpl(IL)] public static float4 triwave(this float4 x) => abs(frac(x) - 0.5f);
        /// <inheritdoc cref="triwave(float4)" />
        [MethodImpl(IL)] public static float3 triwave(this float3 x) => abs(frac(x) - 0.5f);
        /// <inheritdoc cref="triwave(float4)" />
        [MethodImpl(IL)] public static float2 triwave(this float2 x) => abs(frac(x) - 0.5f);
        /// <inheritdoc cref="triwave(float4)" />
        [MethodImpl(IL)] public static float triwave(this float x) => abs(frac(x) - 0.5f);
        #endregion
        
        #region Component-wise Math

        /// <inheritdoc cref="math.sqrt(float4)"/>
        [MethodImpl(IL)] public static float4 sqrt(this float4 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float3)"/>
        [MethodImpl(IL)] public static float3 sqrt(this float3 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float2)"/>
        [MethodImpl(IL)] public static float2 sqrt(this float2 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float)"/>
        [MethodImpl(IL)] public static float sqrt(this float f) => math.sqrt(f);
        
        /// Cube Root Function
        [MethodImpl(IL)] public static float4 cbrt(this float4 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(float4)"/>
        [MethodImpl(IL)] public static float3 cbrt(this float3 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(float4)"/>
        [MethodImpl(IL)] public static float2 cbrt(this float2 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(float4)"/>
        [MethodImpl(IL)] public static float cbrt(this float f) => f.sign() * f.abs().pow(THIRD);

        /// returns 1 / cbrt(f) : inverse Cube root
        [MethodImpl(IL)] public static float4 rcbrt(this float4 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(float4)"/>
        [MethodImpl(IL)] public static float3 rcbrt(this float3 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(float4)"/>
        [MethodImpl(IL)] public static float2 rcbrt(this float2 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(float4)"/>
        [MethodImpl(IL)] public static float rcbrt(this float f) => 1 / f.cbrt();
        

        /// <inheritdoc cref="math.rsqrt(float4)"/>
        [MethodImpl(IL)] public static float4 rsqrt(this float4 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(float3)"/>
        [MethodImpl(IL)] public static float3 rsqrt(this float3 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(float2)"/>
        [MethodImpl(IL)] public static float2 rsqrt(this float2 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(float)"/>
        [MethodImpl(IL)] public static float rsqrt(this float f) => math.rsqrt(f);
        
        
        #endregion Component-wise Math

        /// Returns input * 2 - 1
        /// Effectively remaps the range [0, 1] to [-1, 1]
        [MethodImpl(IL)] public static float m2n1(this float f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2 m2n1(this float2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3 m2n1(this float3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4 m2n1(this float4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x2 m2n1(this float2x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x3 m2n1(this float2x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float2x4 m2n1(this float2x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x2 m2n1(this float3x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x3 m2n1(this float3x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float3x4 m2n1(this float3x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x2 m2n1(this float4x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x3 m2n1(this float4x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(float)"/>
        [MethodImpl(IL)] public static float4x4 m2n1(this float4x4 f) => f * 2 - 1;
        
        /// Addition Operation
        
        [MethodImpl(IL)] public static float add(this float x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float2 x, float2 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float3 x, float3 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float4 x, float4 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float2 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float3 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float4 x, float y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float2 add(this float x, float2 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float3 add(this float x, float3 y) => x + y;
        /// <inheritdoc cref="add(float, float)"/>
        [MethodImpl(IL)] public static float4 add(this float x, float4 y) => x + y;

        /// Subtraction Operation
        [MethodImpl(IL)] public static float sub(this float x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float2 x, float2 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float3 x, float3 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float4 x, float4 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float2 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float3 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float4 x, float y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float2 sub(this float x, float2 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float3 sub(this float x, float3 y) => x - y;
        /// <inheritdoc cref="sub(float, float)"/>
        [MethodImpl(IL)] public static float4 sub(this float x, float4 y) => x - y;
        
        /// Division Operation
        [MethodImpl(IL)] public static float div(this float x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float2 x, float2 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float3 x, float3 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float4 x, float4 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float2 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float3 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float4 x, float y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float2 div(this float x, float2 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float3 div(this float x, float3 y) => x / y;
        /// <inheritdoc cref="div(float, float)"/>
        [MethodImpl(IL)] public static float4 div(this float x, float4 y) => x / y;

        /// Cycle components from x to y to z to w and back to x
        [MethodImpl(IL)] public static float2 cycle(this float2 f) => f.yx;
        /// <inheritdoc cref="cycle(float2)"/>
        [MethodImpl(IL)] public static float3 cycle(this float3 f) => f.yzx;
        /// <inheritdoc cref="cycle(float2)"/>
        [MethodImpl(IL)] public static float4 cycle(this float4 f) => f.yzwx;
        
        /// cycles the components n times
        [MethodImpl(IL)] public static float2 cycle(this float2 f, int n) => f.apply(cycle, n % 2);
        /// cycles the components n times
        [MethodImpl(IL)] public static float3 cycle(this float3 f, int n) => f.apply(cycle, n % 3);
        /// cycles the components n times
        [MethodImpl(IL)] public static float4 cycle(this float4 f, int n) => f.apply(cycle, n % 4);
        
    }
}