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
        
        #region mod

        /// fast mod function
        /// <remarks>
        /// approx 5% faster than math.mod()
        /// It is also exact for negative values of x;
        /// </remarks>
        [MethodImpl(IL)] public static uint4 mod(this uint4 f, uint4 mod) => new(f.x.mod(mod.x), f.y.mod(mod.y), f.z.mod(mod.z), f.w.mod(mod.w));
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint3 mod(this uint3 f, uint3 mod) =>  new(f.x.mod(mod.x), f.y.mod(mod.y), f.z.mod(mod.z));
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint2 mod(this uint2 f, uint2 mod) => new(f.x.mod(mod.x), f.y.mod(mod.y));
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint mod(this uint f, uint mod) => f % mod < 0 ? f % mod + mod : f % mod;
        
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float4 mod(this uint4 f, float4 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float3 mod(this uint3 f, float3 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float2 mod(this uint2 f, float2 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float mod(this uint f, float mod) => (f / mod).frac() * mod;

        
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint4 mod(this uint4 f, uint mod) => (uint4)((float4)f / mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint3 mod(this uint3 f, uint mod) =>  f % mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint2 mod(this uint2 f, uint mod) =>  f % mod;

        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float4 mod(this uint4 f, float mod) => f.div(mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float3 mod(this uint3 f, float mod) => f.div(mod).frac() * mod;
        /// <inheritdoc cref="mod(uint4, uint4)"/>
        [MethodImpl(IL)] public static float2 mod(this uint2 f, float mod) => f.div(mod).frac() * mod;

        #endregion
        
        #region frac

        // /// <summary>Returns the fractional part of a uint value.</summary>
        // /// <remarks>Fractional Remainder (f - (uint)f) is x3 faster than math.frac() </remarks>
        // [MethodImpl(IL)] public static uint4 frac(this uint4 f) => f - f;
        // /// <inheritdoc cref="frac(uint4)" />
        // [MethodImpl(IL)] public static uint3 frac(this uint3 f) => f - f;
        // /// <inheritdoc cref="frac(uint4)" />
        // [MethodImpl(IL)] public static uint2 frac(this uint2 f) => f - f;
        // /// <inheritdoc cref="frac(uint4)" />
        // [MethodImpl(IL)] public static uint frac(this uint f) => f - f;
        

        #endregion
        
        #region csum

        /// Returns the csum of all components of the vector
        [MethodImpl(IL)] public static uint csum(this uint4 f) => math.csum(f);
        /// <inheritdoc cref="csum(Unity.Mathematics.uint4)"/> 
        [MethodImpl(IL)] public static uint csum(this uint3 f) => math.csum(f);
        /// <inheritdoc cref="csum(Unity.Mathematics.uint4)"/> 
        [MethodImpl(IL)] public static uint csum(this uint2 f) => math.csum(f);

        #endregion

        #region cmul

        /// Returns the product of all components of the vector
        [MethodImpl(IL)] public static uint cmul(this uint4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(uint4)"/>
        [MethodImpl(IL)] public static uint cmul(this uint3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(uint4)"/>
        [MethodImpl(IL)] public static uint cmul(this uint2 f) => f.x * f.y;

        #endregion

        #region inv

        /// Returns one minus the given value. => ex : color inversion
        [MethodImpl(IL)] public static uint4 inv(this uint4 f) => 1 - f;
        /// <inheritdoc cref="inv(uint4)"/>
        [MethodImpl(IL)] public static uint3 inv(this uint3 f) => 1 - f;
        /// <inheritdoc cref="inv(uint4)"/>
        [MethodImpl(IL)] public static uint2 inv(this uint2 f) => 1 - f;
        /// <inheritdoc cref="inv(uint4)"/>
        [MethodImpl(IL)] public static uint inv(this uint f) => 1 - f;

        #endregion

        #region neg

        /// Returns the negation of the given value.
        [MethodImpl(IL)] public static int4 neg(this uint4 f) => -(int4)f;
        /// <inheritdoc cref="neg(uint4)"/>
        [MethodImpl(IL)] public static int3 neg(this uint3 f) => -(int3)f;
        /// <inheritdoc cref="neg(uint4)"/>
        [MethodImpl(IL)] public static int2 neg(this uint2 f) => -(int2)f;
        /// <inheritdoc cref="neg(uint4)"/>
        [MethodImpl(IL)] public static int neg(this uint f) => -(int)f;
        
        #endregion
        
        #region rcp

        /// Returns the componentwise reciprocal a vector.
        [MethodImpl(IL)] public static float4 rcp(this uint4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(uint4)"/>
        [MethodImpl(IL)] public static float3 rcp(this uint3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(uint4)"/>
        [MethodImpl(IL)] public static float2 rcp(this uint2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(uint4)"/>
        [MethodImpl(IL)] public static float rcp(this uint f) => math.rcp(f);

        #endregion

        #region pow

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static float4 pow(this uint4 f, uint4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float3 pow(this uint3 f, uint3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float2 pow(this uint2 f, uint2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float pow(this uint f, uint y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float4 pow(this uint4 f, uint pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float3 pow(this uint3 f, uint y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float2 pow(this uint2 f, uint y) => new(math.pow(f.x, y), math.pow(f.y, y));
        
        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static float4 pow(this uint4 f, float4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float3 pow(this uint3 f, float3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float2 pow(this uint2 f, float2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float pow(this uint f, float y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float4 pow(this uint4 f, float pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float3 pow(this uint3 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(uint4,uint4)"/>
        [MethodImpl(IL)] public static float2 pow(this uint2 f, float y) => new(math.pow(f.x, y), math.pow(f.y, y));

        #endregion

        #region sq

        /// Returns x^2
        [MethodImpl(IL)] public static uint4 sq(this uint4 f) => f * f;
        /// <inheritdoc cref="sq(uint4)"/>
        [MethodImpl(IL)] public static uint3 sq(this uint3 f) => f * f;
        /// <inheritdoc cref="sq(uint4)"/>
        [MethodImpl(IL)] public static uint2 sq(this uint2 f) => f * f;
        /// <inheritdoc cref="sq(uint4)"/>
        [MethodImpl(IL)] public static uint sq(this uint f) => f * f;

        #endregion

        #region cube

        /// <summary> Returns x^3 </summary>
        [MethodImpl(IL)] public static uint4 cube(this uint4 f) => f * f * f;
        /// <inheritdoc cref="cube(uint4)"/>
        [MethodImpl(IL)] public static uint3 cube(this uint3 f) => f * f * f;
        /// <inheritdoc cref="cube(uint4)"/>
        [MethodImpl(IL)] public static uint2 cube(this uint2 f) => f * f * f;
        /// <inheritdoc cref="cube(uint4)"/>
        [MethodImpl(IL)] public static uint cube(this uint f) => f * f * f;

        #endregion

        #region pow4

        /// <summary> Returns x^4 </summary>
        [MethodImpl(IL)] public static uint4 pow4(this uint4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(uint4)"/>
        [MethodImpl(IL)] public static uint3 pow4(this uint3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(uint4)"/>
        [MethodImpl(IL)] public static uint2 pow4(this uint2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(uint4)"/>
        [MethodImpl(IL)] public static uint pow4(this uint f) => f.sq().sq();

        #endregion

        #region pow5

        /// <summary> Returns x^5 </summary>
        [MethodImpl(IL)] public static uint4 pow5(this uint4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(uint4)" />
        [MethodImpl(IL)] public static uint3 pow5(this uint3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(uint4)" />
        [MethodImpl(IL)] public static uint2 pow5(this uint2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(uint4)" />
        [MethodImpl(IL)] public static uint pow5(this uint f) => f.sq().sq() * f;

        #endregion
        
        
        #region Component-wise Math

        /// <inheritdoc cref="math.sqrt(float4)"/>
        [MethodImpl(IL)] public static float4 sqrt(this uint4 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float3)"/>
        [MethodImpl(IL)] public static float3 sqrt(this uint3 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float2)"/>
        [MethodImpl(IL)] public static float2 sqrt(this uint2 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(float)"/>
        [MethodImpl(IL)] public static float sqrt(this uint f) => math.sqrt(f);
        
        /// Cube Root Function
        [MethodImpl(IL)] public static float4 cbrt(this uint4 f) => f.pow(THIRD);
        /// <inheritdoc cref="cbrt(uint4)"/>
        [MethodImpl(IL)] public static float3 cbrt(this uint3 f) => f.pow(THIRD);
        /// <inheritdoc cref="cbrt(uint4)"/>
        [MethodImpl(IL)] public static float2 cbrt(this uint2 f) => f.pow(THIRD);
        /// <inheritdoc cref="cbrt(uint4)"/>
        [MethodImpl(IL)] public static float cbrt(this uint f) => f.pow(THIRD);

        /// returns 1 / cbrt(f) : inverse Cube root
        [MethodImpl(IL)] public static float4 rcbrt(this uint4 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(uint4)"/>
        [MethodImpl(IL)] public static float3 rcbrt(this uint3 f) =>  1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(uint4)"/>
        [MethodImpl(IL)] public static float2 rcbrt(this uint2 f) =>  1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(uint4)"/>
        [MethodImpl(IL)] public static float rcbrt(this uint f) =>  1 / f.cbrt();
        

        /// <inheritdoc cref="math.rsqrt(float4)"/>
        [MethodImpl(IL)] public static float4 rsqrt(this uint4 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float3)"/>
        [MethodImpl(IL)] public static float3 rsqrt(this uint3 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float2)"/>
        [MethodImpl(IL)] public static float2 rsqrt(this uint2 f) => 1 / f.sqrt();
        /// <inheritdoc cref="math.rsqrt(float)"/>
        [MethodImpl(IL)] public static float rsqrt(this uint f) => 1 / f.sqrt();
        
        
        #endregion Component-wise Math

        /// Returns input * 2 - 1
        /// Effectively remaps the range [0, 1] to [-1, 1]
        [MethodImpl(IL)] public static uint m2n1(this uint f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint2 m2n1(this uint2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint3 m2n1(this uint3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint4 m2n1(this uint4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint2x2 m2n1(this uint2x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint2x3 m2n1(this uint2x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint2x4 m2n1(this uint2x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint3x2 m2n1(this uint3x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint3x3 m2n1(this uint3x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint3x4 m2n1(this uint3x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint4x2 m2n1(this uint4x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint4x3 m2n1(this uint4x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(uint)"/>
        [MethodImpl(IL)] public static uint4x4 m2n1(this uint4x4 f) => f * 2 - 1;
        
        /// Addition Operation
        
        [MethodImpl(IL)] public static uint add(this uint x, uint y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 add(this uint2 x, uint2 y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 add(this uint3 x, uint3 y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 add(this uint4 x, uint4 y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 add(this uint2 x, uint y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 add(this uint3 x, uint y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 add(this uint4 x, uint y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 add(this uint x, uint2 y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 add(this uint x, uint3 y) => x + y;
        /// <inheritdoc cref="add(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 add(this uint x, uint4 y) => x + y;

        /// Subtraction Operation
        [MethodImpl(IL)] public static uint sub(this uint x, uint y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 sub(this uint2 x, uint2 y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 sub(this uint3 x, uint3 y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 sub(this uint4 x, uint4 y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 sub(this uint2 x, uint y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 sub(this uint3 x, uint y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 sub(this uint4 x, uint y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 sub(this uint x, uint2 y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 sub(this uint x, uint3 y) => x - y;
        /// <inheritdoc cref="sub(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 sub(this uint x, uint4 y) => x - y;
        
        /// Division Operation
        [MethodImpl(IL)] public static uint div(this uint x, uint y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 div(this uint2 x, uint2 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 div(this uint3 x, uint3 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 div(this uint4 x, uint4 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 div(this uint2 x, uint y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 div(this uint3 x, uint y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 div(this uint4 x, uint y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint2 div(this uint x, uint2 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint3 div(this uint x, uint3 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static uint4 div(this uint x, uint4 y) => x / y;
        
        
        /// Division Operation
        [MethodImpl(IL)] public static float div(this uint x, float y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float2 div(this uint2 x, float2 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float3 div(this uint3 x, float3 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float4 div(this uint4 x, float4 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float2 div(this uint2 x, float y) => (float2)x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float3 div(this uint3 x, float y) => (float3)x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float4 div(this uint4 x, float y) => (float4)x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float2 div(this uint x, float2 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float3 div(this uint x, float3 y) => x / y;
        /// <inheritdoc cref="div(uint, uint)"/>
        [MethodImpl(IL)] public static float4 div(this uint x, float4 y) => x / y;
        
        
        /// Cycle components from x to y to z to w and back to x
        [MethodImpl(IL)] public static uint2 cycle(this uint2 f) => new(f.y, f.x);
        /// <inheritdoc cref="cycle(uint2)"/>
        [MethodImpl(IL)] public static uint3 cycle(this uint3 f) => new(f.y, f.z, f.x);
        /// <inheritdoc cref="cycle(uint2)"/>
        [MethodImpl(IL)] public static uint4 cycle(this uint4 f) => new(f.y, f.z, f.w, f.x);
        
        
        /// applies a function to a uint2 n times
        [MethodImpl(IL)] public static uint2 cycle(this uint2 f, int n) => f.apply(cycle, n);
        /// applies a function to a uint3 n times
        [MethodImpl(IL)] public static uint3 cycle(this uint3 f, int n) => f.apply(cycle, n);
        /// applies a function to a uint4 n times
        [MethodImpl(IL)] public static uint4 cycle(this uint4 f, int n) => f.apply(cycle, n);


        /// <inheritdoc cref="subx(uint4, uint)"/>
        [MethodImpl(IL)] public static uint2 subx(this uint2 f, uint x) => new(x, f.y);
        /// <inheritdoc cref="suby(uint4, uint)"/>
        [MethodImpl(IL)] public static uint2 suby(this uint2 f, uint y) => new(f.x, y);
        /// <inheritdoc cref="subx(uint4, uint)"/>
        [MethodImpl(IL)] public static uint3 subx(this uint3 f, uint x) => new(x, f.y, f.z);
        /// <inheritdoc cref="suby(uint4, uint)"/>
        [MethodImpl(IL)] public static uint3 suby(this uint3 f, uint y) => new(f.x, y, f.z);
        /// <inheritdoc cref="subz(uint4, uint)"/>
        [MethodImpl(IL)] public static uint3 subz(this uint3 f, uint z) => new(f.x, f.y, z);
        /// substitutes the component x
        [MethodImpl(IL)] public static uint4 subx(this uint4 f, uint x) => new(x, f.y, f.z, f.w);
        /// substitutes the component y
        [MethodImpl(IL)] public static uint4 suby(this uint4 f, uint y) => new(f.x, y, f.z, f.w);
        /// substitutes the component z
        [MethodImpl(IL)] public static uint4 subz(this uint4 f, uint z) => new(f.x, f.y, z, f.w);
        /// substitutes the component w
        [MethodImpl(IL)] public static uint4 subw(this uint4 f, uint w) => new(f.x, f.y, f.z, w);
    }
}