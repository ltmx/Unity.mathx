#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

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
        [MethodImpl(IL)] public static double4 sign(this double4 f) => math.sign(f);
        ///<inheritdoc cref="sign(double4)"/>
        [MethodImpl(IL)] public static double3 sign(this double3 f) => math.sign(f);
        ///<inheritdoc cref="sign(double4)"/>
        [MethodImpl(IL)] public static double2 sign(this double2 f) => math.sign(f);
        ///<inheritdoc cref="sign(double4)"/>
        [MethodImpl(IL)] public static double sign(this double f) => math.sign(f);
        

        #endregion
        
        #region abs

        /// The componentwise absolute value of the input.
        [MethodImpl(IL)] public static double4 abs(this double4 f) => math.abs(f);
        /// <inheritdoc cref="abs(double4)"/>
        [MethodImpl(IL)] public static double3 abs(this double3 f) => math.abs(f);
        /// <inheritdoc cref="abs(double4)"/>
        [MethodImpl(IL)] public static double2 abs(this double2 f) => math.abs(f);
        /// <inheritdoc cref="abs(double4)"/>
        [MethodImpl(IL)] public static double abs(this double f) => math.abs(f);

        #endregion

        
        #region mod

        /// fast mod function
        /// <remarks>
        /// approx 5% faster than math.mod()
        /// It is also exact for negative values of x;
        /// </remarks>
        [MethodImpl(IL)] public static double4 mod(this double4 f, double4 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double3 mod(this double3 f, double3 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double2 mod(this double2 f, double2 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double mod(this double f, double mod) => (f / mod).frac() * mod;
        
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double4 mod(this double4 f, int4 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double3 mod(this double3 f, int3 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double2 mod(this double2 f, int2 mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double mod(this double f, int mod) => (f / mod).frac() * mod;

        
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double4 mod(this double4 f, double mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double3 mod(this double3 f, double mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double2 mod(this double2 f, double mod) => (f / mod).frac() * mod;

        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double4 mod(this double4 f, int mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double3 mod(this double3 f, int mod) => (f / mod).frac() * mod;
        /// <inheritdoc cref="mod(double4, double4)"/>
        [MethodImpl(IL)] public static double2 mod(this double2 f, int mod) => (f / mod).frac() * mod;

        #endregion
        
        #region frac

        /// <summary>Returns the fractional part of a double value.</summary>
        /// <remarks>Fractional Remainder (f - (int)f) is x3 faster than math.frac() </remarks>
        [MethodImpl(IL)] public static double4 frac(this double4 f) => f - (int4)f;
        /// <inheritdoc cref="frac(double4)"/>
        [MethodImpl(IL)] public static double3 frac(this double3 f) => f - (int3)f;
        /// <inheritdoc cref="frac(double4)"/>
        [MethodImpl(IL)] public static double2 frac(this double2 f) => f - (int2)f;
        /// <inheritdoc cref="frac(double4)"/>
        [MethodImpl(IL)] public static double frac(this double f) => f - (int)f;
        

        #endregion
        
        #region csum

        /// Returns the csum of all components of the vector
        [MethodImpl(IL)] public static double csum(this double4 f) => math.csum(f);
        /// <inheritdoc cref="csum(double4)"/> 
        [MethodImpl(IL)] public static double csum(this double3 f) => math.csum(f);
        /// <inheritdoc cref="csum(double4)"/> 
        [MethodImpl(IL)] public static double csum(this double2 f) => math.csum(f);

        #endregion

        #region cmul

        /// Returns the product of all components of the vector
        [MethodImpl(IL)] public static double cmul(this double4 f) => f.x * f.y * f.z * f.w;
        /// <inheritdoc cref="cmul(double4)"/>
        [MethodImpl(IL)] public static double cmul(this double3 f) => f.x * f.y * f.z;
        /// <inheritdoc cref="cmul(double4)"/>
        [MethodImpl(IL)] public static double cmul(this double2 f) => f.x * f.y;

        #endregion

        #region inv

        /// Returns one minus the given value. => ex : color inversion
        [MethodImpl(IL)] public static double4 inv(this double4 f) => 1 - f;
        /// <inheritdoc cref="inv(double4)"/>
        [MethodImpl(IL)] public static double3 inv(this double3 f) => 1 - f;
        /// <inheritdoc cref="inv(double4)"/>
        [MethodImpl(IL)] public static double2 inv(this double2 f) => 1 - f;
        /// <inheritdoc cref="inv(double4)"/>
        [MethodImpl(IL)] public static double inv(this double f) => 1 - f;

        #endregion

        #region neg

        /// Returns the negation of the given value.
        [MethodImpl(IL)] public static double4 neg(this double4 f) => -f;
        /// <inheritdoc cref="neg(double4)"/>
        [MethodImpl(IL)] public static double3 neg(this double3 f) => -f;
        /// <inheritdoc cref="neg(double4)"/>
        [MethodImpl(IL)] public static double2 neg(this double2 f) => -f;
        /// <inheritdoc cref="neg(double4)"/>
        [MethodImpl(IL)] public static double neg(this double f) => -f;
        
        #endregion
        
        #region rcp

        /// Returns the componentwise reciprocal a vector.
        [MethodImpl(IL)] public static double4 rcp(this double4 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(double4)"/>
        [MethodImpl(IL)] public static double3 rcp(this double3 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(double4)"/>
        [MethodImpl(IL)] public static double2 rcp(this double2 f) => math.rcp(f);
        /// <inheritdoc cref="rcp(double4)"/>
        [MethodImpl(IL)] public static double rcp(this double f) => math.rcp(f);

        #endregion

        #region pow

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(IL)] public static double4 pow(this double4 f, double4 pow) => math.pow(f, pow);
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double3 pow(this double3 f, double3 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double2 pow(this double2 f, double2 y) => math.pow(f, y);
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double pow(this double f, double y) => math.pow(f, y);
        
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double4 pow(this double4 f, double pow) => new(math.pow(f.x, pow), math.pow(f.y, pow), math.pow(f.z, pow), math.pow(f.w, pow));
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double3 pow(this double3 f, double y) => new(math.pow(f.x, y), math.pow(f.y, y), math.pow(f.z, y));
        /// <inheritdoc cref="pow(double4,double4)"/>
        [MethodImpl(IL)] public static double2 pow(this double2 f, double y) => new(math.pow(f.x, y), math.pow(f.y, y));

        #endregion

        #region sq

        /// Returns x^2
        [MethodImpl(IL)] public static double4 sq(this double4 f) => f * f;
        /// <inheritdoc cref="sq(double4)"/>
        [MethodImpl(IL)] public static double3 sq(this double3 f) => f * f;
        /// <inheritdoc cref="sq(double4)"/>
        [MethodImpl(IL)] public static double2 sq(this double2 f) => f * f;
        /// <inheritdoc cref="sq(double4)"/>
        [MethodImpl(IL)] public static double sq(this double f) => f * f;

        #endregion

        #region cube

        /// <summary> Returns x^3 </summary>
        [MethodImpl(IL)] public static double4 cube(this double4 f) => f * f * f;
        /// <inheritdoc cref="cube(double4)"/>
        [MethodImpl(IL)] public static double3 cube(this double3 f) => f * f * f;
        /// <inheritdoc cref="cube(double4)"/>
        [MethodImpl(IL)] public static double2 cube(this double2 f) => f * f * f;
        /// <inheritdoc cref="cube(double4)"/>
        [MethodImpl(IL)] public static double cube(this double f) => f * f * f;

        #endregion

        #region pow4

        /// <summary> Returns x^4 </summary>
        [MethodImpl(IL)] public static double4 pow4(this double4 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(double4)"/>
        [MethodImpl(IL)] public static double3 pow4(this double3 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(double4)"/>
        [MethodImpl(IL)] public static double2 pow4(this double2 f) => f.sq().sq();
        /// <inheritdoc cref="pow4(double4)"/>
        [MethodImpl(IL)] public static double pow4(this double f) => f.sq().sq();

        #endregion

        #region pow5

        /// <summary> Returns x^5 </summary>
        [MethodImpl(IL)] public static double4 pow5(this double4 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(double4)" />
        [MethodImpl(IL)] public static double3 pow5(this double3 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(double4)" />
        [MethodImpl(IL)] public static double2 pow5(this double2 f) => f.sq().sq() * f;
        /// <inheritdoc cref="pow5(double4)" />
        [MethodImpl(IL)] public static double pow5(this double f) => f.sq().sq() * f;

        #endregion
        
        
        #region Component-wise Math

        /// <inheritdoc cref="math.sqrt(double4)"/>
        [MethodImpl(IL)] public static double4 sqrt(this double4 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(double3)"/>
        [MethodImpl(IL)] public static double3 sqrt(this double3 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(double2)"/>
        [MethodImpl(IL)] public static double2 sqrt(this double2 f) => math.sqrt(f);
        /// <inheritdoc cref="math.sqrt(double)"/>
        [MethodImpl(IL)] public static double sqrt(this double f) => math.sqrt(f);
        
        /// Cube Root Function
        [MethodImpl(IL)] public static double4 cbrt(this double4 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(double4)"/>
        [MethodImpl(IL)] public static double3 cbrt(this double3 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(double4)"/>
        [MethodImpl(IL)] public static double2 cbrt(this double2 f) => f.sign() * f.abs().pow(THIRD);
        /// <inheritdoc cref="cbrt(double4)"/>
        [MethodImpl(IL)] public static double cbrt(this double f) => f.sign() * f.abs().pow(THIRD);

        /// returns 1 / cbrt(f) : inverse Cube root
        [MethodImpl(IL)] public static double4 rcbrt(this double4 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(double4)"/>
        [MethodImpl(IL)] public static double3 rcbrt(this double3 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(double4)"/>
        [MethodImpl(IL)] public static double2 rcbrt(this double2 f) => 1 / f.cbrt();
        /// <inheritdoc cref="rcbrt(double4)"/>
        [MethodImpl(IL)] public static double rcbrt(this double f) => 1 / f.cbrt();
        

        /// <inheritdoc cref="math.rsqrt(double4)"/>
        [MethodImpl(IL)] public static double4 rsqrt(this double4 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(double3)"/>
        [MethodImpl(IL)] public static double3 rsqrt(this double3 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(double2)"/>
        [MethodImpl(IL)] public static double2 rsqrt(this double2 f) => math.rsqrt(f);
        /// <inheritdoc cref="math.rsqrt(double)"/>
        [MethodImpl(IL)] public static double rsqrt(this double f) => math.rsqrt(f);
        
        
        #endregion Component-wise Math

        /// Returns input * 2 - 1
        /// Effectively remaps the range [0, 1] to [-1, 1]
        [MethodImpl(IL)] public static double m2n1(this double f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double2 m2n1(this double2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double3 m2n1(this double3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double4 m2n1(this double4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double2x2 m2n1(this double2x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double2x3 m2n1(this double2x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double2x4 m2n1(this double2x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double3x2 m2n1(this double3x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double3x3 m2n1(this double3x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double3x4 m2n1(this double3x4 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double4x2 m2n1(this double4x2 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double4x3 m2n1(this double4x3 f) => f * 2 - 1;
        /// <inheritdoc cref="m2n1(double)"/>
        [MethodImpl(IL)] public static double4x4 m2n1(this double4x4 f) => f * 2 - 1;
        
        /// Addition Operation
        
        [MethodImpl(IL)] public static double add(this double x, double y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double2 add(this double2 x, double2 y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double3 add(this double3 x, double3 y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double4 add(this double4 x, double4 y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double2 add(this double2 x, double y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double3 add(this double3 x, double y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double4 add(this double4 x, double y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double2 add(this double x, double2 y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double3 add(this double x, double3 y) => x + y;
        /// <inheritdoc cref="add(double, double)"/>
        [MethodImpl(IL)] public static double4 add(this double x, double4 y) => x + y;

        /// Subtraction Operation
        [MethodImpl(IL)] public static double sub(this double x, double y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double2 sub(this double2 x, double2 y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double3 sub(this double3 x, double3 y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double4 sub(this double4 x, double4 y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double2 sub(this double2 x, double y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double3 sub(this double3 x, double y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double4 sub(this double4 x, double y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double2 sub(this double x, double2 y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double3 sub(this double x, double3 y) => x - y;
        /// <inheritdoc cref="sub(double, double)"/>
        [MethodImpl(IL)] public static double4 sub(this double x, double4 y) => x - y;
        
        /// Division Operation
        [MethodImpl(IL)] public static double div(this double x, double y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double2 div(this double2 x, double2 y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double3 div(this double3 x, double3 y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double4 div(this double4 x, double4 y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double2 div(this double2 x, double y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double3 div(this double3 x, double y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double4 div(this double4 x, double y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double2 div(this double x, double2 y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double3 div(this double x, double3 y) => x / y;
        /// <inheritdoc cref="div(double, double)"/>
        [MethodImpl(IL)] public static double4 div(this double x, double4 y) => x / y;
        
        /// Cycle components from x to y to z to w and back to x
        [MethodImpl(IL)] public static double2 cycle(this double2 f) => new(f.y, f.x);
        /// <inheritdoc cref="cycle(double2)"/>
        [MethodImpl(IL)] public static double3 cycle(this double3 f) => new(f.y, f.z, f.x);
        /// <inheritdoc cref="cycle(double2)"/>
        [MethodImpl(IL)] public static double4 cycle(this double4 f) => new(f.y, f.z, f.w, f.x);
        
        
        /// applies a function to a double2 n times
        [MethodImpl(IL)] public static double2 cycle(this double2 f, int n) => f.apply(cycle, n);
        /// applies a function to a double3 n times
        [MethodImpl(IL)] public static double3 cycle(this double3 f, int n) => f.apply(cycle, n);
        /// applies a function to a double4 n times
        [MethodImpl(IL)] public static double4 cycle(this double4 f, int n) => f.apply(cycle, n);


        /// <inheritdoc cref="subx(double4, double)"/>
        [MethodImpl(IL)] public static double2 subx(this double2 f, double x) => new(x, f.y);
        /// <inheritdoc cref="suby(double4, double)"/>
        [MethodImpl(IL)] public static double2 suby(this double2 f, double y) => new(f.x, y);
        /// <inheritdoc cref="subx(double4, double)"/>
        [MethodImpl(IL)] public static double3 subx(this double3 f, double x) => new(x, f.y, f.z);
        /// <inheritdoc cref="suby(double4, double)"/>
        [MethodImpl(IL)] public static double3 suby(this double3 f, double y) => new(f.x, y, f.z);
        /// <inheritdoc cref="subz(double4, double)"/>
        [MethodImpl(IL)] public static double3 subz(this double3 f, double z) => new(f.x, f.y, z);
        /// substitutes the component x
        [MethodImpl(IL)] public static double4 subx(this double4 f, double x) => new(x, f.y, f.z, f.w);
        /// substitutes the component y
        [MethodImpl(IL)] public static double4 suby(this double4 f, double y) => new(f.x, y, f.z, f.w);
        /// substitutes the component z
        [MethodImpl(IL)] public static double4 subz(this double4 f, double z) => new(f.x, f.y, z, f.w);
        /// substitutes the component w
        [MethodImpl(IL)] public static double4 subw(this double4 f, double w) => new(f.x, f.y, f.z, w);
    }
}