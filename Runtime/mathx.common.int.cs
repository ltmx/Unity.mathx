#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    /// <summary>Extension Library for Unity.Mathematics</summary>
    /// <permission>
    /// **    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
    /// **    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
    /// </permission>
    /// <remarks>See also : https://github.com/LTMX/Unity.mathx</remarks>
    public static partial class mathx
    {
        
        #region sign

        /// Returns the sign of the given value.
        [MethodImpl(IL)] public static int4 sign(this int4 f) => math.sign(f);
        ///<inheritdoc cref="sign(int4)"/>
        [MethodImpl(IL)] public static int3 sign(this int3 f) => math.sign(f);
        ///<inheritdoc cref="sign(int4)"/>
        [MethodImpl(IL)] public static int2 sign(this int2 f) => math.sign(f);
        ///<inheritdoc cref="sign(int4)"/>
        [MethodImpl(IL)] public static int sign(this int f) => math.sign(f);

        #endregion
        
        #region abs

        /// The componentwise absolute value of the input.
        [MethodImpl(IL)] public static int4 abs(this int4 f) => math.abs(f);
        /// <inheritdoc cref="abs(int4)"/>
        [MethodImpl(IL)] public static int3 abs(this int3 f) => math.abs(f);
        /// <inheritdoc cref="abs(int4)"/>
        [MethodImpl(IL)] public static int2 abs(this int2 f) => math.abs(f);
        /// <inheritdoc cref="abs(int4)"/>
        [MethodImpl(IL)] public static int abs(this int f) => math.abs(f);

        #endregion

        
        #region mod

        /// fast mod function
        /// <remarks>
        /// approx 5% faster than math.mod()
        /// It is also exact for negative values of x;
        /// </remarks>
        [MethodImpl(IL)] public static int4 mod(this int4 f, int4 mod) => new(f.x.mod(mod.x), f.y.mod(mod.y), f.z.mod(mod.z), f.w.mod(mod.w));
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int3 mod(this int3 f, int3 mod) =>  new(f.x.mod(mod.x), f.y.mod(mod.y), f.z.mod(mod.z));
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int2 mod(this int2 f, int2 mod) => new(f.x.mod(mod.x), f.y.mod(mod.y));
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int mod(this int f, int mod) => f % mod < 0 ? f % mod + mod : f % mod;
        
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float4 mod(this int4 f, float4 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float3 mod(this int3 f, float3 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float2 mod(this int2 f, float2 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float mod(this int f, float mod) => (f / mod).frac() * mod;

        
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int4 mod(this int4 f, int mod) => (int4)((float4)f / mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int3 mod(this int3 f, int mod) =>  f % mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static int2 mod(this int2 f, int mod) =>  f % mod;

        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float4 mod(this int4 f, float mod) => f.div(mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float3 mod(this int3 f, float mod) => f.div(mod).frac() * mod;
        /// <inheritdoc cref="mod(int4, int4)"/>
        [MethodImpl(IL)] public static float2 mod(this int2 f, float mod) => f.div(mod).frac() * mod;

        #endregion
        
        #region frac

        // /// <summary>Returns the fractional part of a int value.</summary>
        // /// <remarks>Fractional Remainder (f - (int)f) is x3 faster than math.frac() </remarks>
        // [MethodImpl(IL)] public static int4 frac(this int4 f) => f - f;
        // /// <inheritdoc cref="frac(int4)" />
        // [MethodImpl(IL)] public static int3 frac(this int3 f) => f - f;
        // /// <inheritdoc cref="frac(int4)" />
        // [MethodImpl(IL)] public static int2 frac(this int2 f) => f - f;
        // /// <inheritdoc cref="frac(int4)" />
        // [MethodImpl(IL)] public static int frac(this int f) => f - f;
        

        #endregion
        
        #region csum

        /// Returns the csum of all components of the vector
        [MethodImpl(IL)] public static int csum(this int4 f) => math.csum(f);
        /// <inheritdoc cref="csum(Unity.Mathematics.int4)"/> 
        [MethodImpl(IL)] public static int csum(this int3 f) => math.csum(f);
        /// <inheritdoc cref="csum(Unity.Mathematics.int4)"/> 
        [MethodImpl(IL)] public static int csum(this int2 f) => math.csum(f);

        #endregion

        #region cmul

        /// Returns the product of all components of the vector
        [MethodImpl(IL)] public static int cmul(this int4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(int4)"/>
        [MethodImpl(IL)] public static int cmul(this int3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(int4)"/>
        [MethodImpl(IL)] public static int cmul(this int2 f) => f.x * f.y;

        #endregion

        #region inv

        /// Returns one minus the given value. => ex : color inversion
        [MethodImpl(IL)] public static int4 inv(this int4 f) => 1 - f;
        /// <inheritdoc cref="inv(int4)"/>
        [MethodImpl(IL)] public static int3 inv(this int3 f) => 1 - f;
        /// <inheritdoc cref="inv(int4)"/>
        [MethodImpl(IL)] public static int2 inv(this int2 f) => 1 - f;
        /// <inheritdoc cref="inv(int4)"/>
        [MethodImpl(IL)] public static int inv(this int f) => 1 - f;

        #endregion

        #region neg

        /// Returns the negation of the given value.
        [MethodImpl(IL)] public static int4 neg(this int4 f) => -f;
        /// <inheritdoc cref="neg(int4)"/>
        [MethodImpl(IL)] public static int3 neg(this int3 f) => -f;
        /// <inheritdoc cref="neg(int4)"/>
        [MethodImpl(IL)] public static int2 neg(this int2 f) => -f;
        /// <inheritdoc cref="neg(int4)"/>
        [MethodImpl(IL)] public static int neg(this int f) => -f;
        
        #endregion
        
        #region rcp

        /// Returns the componentwise reciprocal a vector.
        [MethodImpl(IL)] public static float4 rcp(this int4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(int4)"/>
        [MethodImpl(IL)] public static float3 rcp(this int3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(int4)"/>
        [MethodImpl(IL)] public static float2 rcp(this int2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(int4)"/>
        [MethodImpl(IL)] public static float rcp(this int f) => math.rcp(f);

        #endregion

        #region pow

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static float4 pow(this int4 f, int4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float3 pow(this int3 f, int3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float2 pow(this int2 f, int2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float pow(this int f, int y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float4 pow(this int4 f, int pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float3 pow(this int3 f, int y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float2 pow(this int2 f, int y) => new(math.pow(f.x, y), math.pow(f.y, y));
        
        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static float4 pow(this int4 f, float4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float3 pow(this int3 f, float3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float2 pow(this int2 f, float2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float pow(this int f, float y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float4 pow(this int4 f, float pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float3 pow(this int3 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(int4,int4)"/>
        [MethodImpl(IL)] public static float2 pow(this int2 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y));

        #endregion

        #region sq

        /// Returns x^2
        [MethodImpl(IL)] public static int4 sq(this int4 f) => f * f;
        /// <inheritdoc cref="sq(int4)"/>
        [MethodImpl(IL)] public static int3 sq(this int3 f) => f * f;
        /// <inheritdoc cref="sq(int4)"/>
        [MethodImpl(IL)] public static int2 sq(this int2 f) => f * f;
        /// <inheritdoc cref="sq(int4)"/>
        [MethodImpl(IL)] public static int sq(this int f) => f * f;

        #endregion

        #region cube

        /// <summary> Returns x^3 </summary>
        [MethodImpl(IL)] public static int4 cube(this int4 f) => f * f * f;
        /// <inheritdoc cref="cube(int4)"/>
        [MethodImpl(IL)] public static int3 cube(this int3 f) => f * f * f;
        /// <inheritdoc cref="cube(int4)"/>
        [MethodImpl(IL)] public static int2 cube(this int2 f) => f * f * f;
        /// <inheritdoc cref="cube(int4)"/>
        [MethodImpl(IL)] public static int cube(this int f) => f * f * f;

        #endregion

        #region pow4

        /// <summary> Returns x^4 </summary>
        [MethodImpl(IL)] public static int4 pow4(this int4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(int4)"/>
        [MethodImpl(IL)] public static int3 pow4(this int3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(int4)"/>
        [MethodImpl(IL)] public static int2 pow4(this int2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(int4)"/>
        [MethodImpl(IL)] public static int pow4(this int f) => f.sq().sq();

        #endregion

        #region pow5

        /// <summary> Returns x^5 </summary>
        [MethodImpl(IL)] public static int4 pow5(this int4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(int4)" />
        [MethodImpl(IL)] public static int3 pow5(this int3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(int4)" />
        [MethodImpl(IL)] public static int2 pow5(this int2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(int4)" />
        [MethodImpl(IL)] public static int pow5(this int f) => f.sq().sq() * f;

        #endregion
        
        
        #region Component-wise Math

        /// <inheritdoc cref="math.sqrt(float4)"/>
        [MethodImpl(IL)] public static float4 sqrt(this int4 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float3)"/>
        [MethodImpl(IL)] public static float3 sqrt(this int3 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float2)"/>
        [MethodImpl(IL)] public static float2 sqrt(this int2 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float)"/>
        [MethodImpl(IL)] public static float sqrt(this int f) => math.sqrt(f);
        
        /// Cube Root Function
        [MethodImpl(IL)] public static float4 cbrt(this int4 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(int4)"/>
        [MethodImpl(IL)] public static float3 cbrt(this int3 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(int4)"/>
        [MethodImpl(IL)] public static float2 cbrt(this int2 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(int4)"/>
        [MethodImpl(IL)] public static float cbrt(this int f) => f.sign() * f.abs().pow(THIRD);

        /// returns 1 / cbrt(f) : inverse Cube root
        [MethodImpl(IL)] public static float4 rcbrt(this int4 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(int4)"/>
        [MethodImpl(IL)] public static float3 rcbrt(this int3 f) =>  1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(int4)"/>
        [MethodImpl(IL)] public static float2 rcbrt(this int2 f) =>  1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(int4)"/>
        [MethodImpl(IL)] public static float rcbrt(this int f) =>  1 / f.cbrt();
        

        /// <inheritdoc cref="math.rsqrt(float4)"/>
        [MethodImpl(IL)] public static float4 rsqrt(this int4 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float3)"/>
        [MethodImpl(IL)] public static float3 rsqrt(this int3 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float2)"/>
        [MethodImpl(IL)] public static float2 rsqrt(this int2 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float)"/>
        [MethodImpl(IL)] public static float rsqrt(this int f) => 1 / f.sqrt();
        
        
        #endregion Component-wise Math

        /// Returns input * 2 - 1
        /// Effectively remaps the range [0, 1] to [-1, 1]
        [MethodImpl(IL)] public static int m2n1(this int f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int2 m2n1(this int2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int3 m2n1(this int3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int4 m2n1(this int4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int2x2 m2n1(this int2x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int2x3 m2n1(this int2x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int2x4 m2n1(this int2x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int3x2 m2n1(this int3x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int3x3 m2n1(this int3x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int3x4 m2n1(this int3x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int4x2 m2n1(this int4x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int4x3 m2n1(this int4x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(int)"/>
        [MethodImpl(IL)] public static int4x4 m2n1(this int4x4 f) => f * 2 - 1;
        
        /// Addition Operation
        
        [MethodImpl(IL)] public static int add(this int x, int y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int2 add(this int2 x, int2 y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int3 add(this int3 x, int3 y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int4 add(this int4 x, int4 y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int2 add(this int2 x, int y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int3 add(this int3 x, int y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int4 add(this int4 x, int y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int2 add(this int x, int2 y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int3 add(this int x, int3 y) => x + y;
        /// <inheritdoc cref="add(int, int)"/>
        [MethodImpl(IL)] public static int4 add(this int x, int4 y) => x + y;

        /// Subtraction Operation
        [MethodImpl(IL)] public static int sub(this int x, int y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int2 sub(this int2 x, int2 y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int3 sub(this int3 x, int3 y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int4 sub(this int4 x, int4 y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int2 sub(this int2 x, int y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int3 sub(this int3 x, int y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int4 sub(this int4 x, int y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int2 sub(this int x, int2 y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int3 sub(this int x, int3 y) => x - y;
        /// <inheritdoc cref="sub(int, int)"/>
        [MethodImpl(IL)] public static int4 sub(this int x, int4 y) => x - y;
        
        /// Division Operation
        [MethodImpl(IL)] public static int div(this int x, int y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int2 div(this int2 x, int2 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int3 div(this int3 x, int3 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int4 div(this int4 x, int4 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int2 div(this int2 x, int y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int3 div(this int3 x, int y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int4 div(this int4 x, int y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int2 div(this int x, int2 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int3 div(this int x, int3 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static int4 div(this int x, int4 y) => x / y;
        
        
        /// Division Operation
        [MethodImpl(IL)] public static float div(this int x, float y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float2 div(this int2 x, float2 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float3 div(this int3 x, float3 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float4 div(this int4 x, float4 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float2 div(this int2 x, float y) => (float2)x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float3 div(this int3 x, float y) => (float3)x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float4 div(this int4 x, float y) => (float4)x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float2 div(this int x, float2 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float3 div(this int x, float3 y) => x / y;
        /// <inheritdoc cref="div(int, int)"/>
        [MethodImpl(IL)] public static float4 div(this int x, float4 y) => x / y;
        
        
        /// Cycle components from x to y to z to w and back to x
        [MethodImpl(IL)] public static int2 cycle(this int2 f) => new(f.y, f.x);
        /// <inheritdoc cref="cycle(int2)"/>
        [MethodImpl(IL)] public static int3 cycle(this int3 f) => new(f.y, f.z, f.x);
        /// <inheritdoc cref="cycle(int2)"/>
        [MethodImpl(IL)] public static int4 cycle(this int4 f) => new(f.y, f.z, f.w, f.x);
        
        
        /// applies a function to a int2 n times
        [MethodImpl(IL)] public static int2 cycle(this int2 f, int n) => f.apply(cycle, n);
        /// applies a function to a int3 n times
        [MethodImpl(IL)] public static int3 cycle(this int3 f, int n) => f.apply(cycle, n);
        /// applies a function to a int4 n times
        [MethodImpl(IL)] public static int4 cycle(this int4 f, int n) => f.apply(cycle, n);
    }
}