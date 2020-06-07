/**************************************************************************************
**
**    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
**    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
** 
***************************************************************************************/

//https://github.com/LTMX/Unity-Mathematics-Extensions

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
using Vector4 = UnityEngine.Vector4;
using Uei = UnityEngine.Internal;

namespace LTMX
{
    public static partial class UnityMathematicsExtensions
    {
    
        // Vector Specific Functions ------------------------------------------------------

        // Normalized
        public static float4 normalized(this float4 f) => math.normalize(f);
        public static float3 normalized(this float3 f) => math.normalize(f);
        public static float2 normalized(this float2 f) => math.normalize(f);
        
        public static float4 normalized(this Vector4 f) => math.normalize(f);
        public static float3 normalized(this Vector3 f) => math.normalize(f);
        public static float2 normalized(this Vector2 f) => math.normalize(f);
        
        public static double4 normalized(this double4 f) => math.normalize(f);
        public static double3 normalized(this double3 f) => math.normalize(f);
        public static double2 normalized(this double2 f) => math.normalize(f);

        
        //length
        public static float length(this float4 f) => math.length(f);
        public static float length(this float3 f) => math.length(f);
        public static float length(this float2 f) => math.length(f);
        
        public static float length(this Vector4 f) => math.length(f);
        public static float length(this Vector3 f) => math.length(f);
        public static float length(this Vector2 f) => math.length(f);
        
        public static double4 length(this double4 f) => math.length(f);
        public static double3 length(this double3 f) => math.length(f);
        public static double2 length(this double2 f) => math.length(f);


        //Length Squared
        public static float lengthsq(this float4 f) => math.lengthsq(f);
        public static float lengthsq(this float3 f) => math.lengthsq(f);
        public static float lengthsq(this float2 f) => math.lengthsq(f);
        
        public static float lengthsq(this Vector4 f) => math.lengthsq(f);
        public static float lengthsq(this Vector3 f) => math.lengthsq(f);
        public static float lengthsq(this Vector2 f) => math.lengthsq(f);
        
        public static double4 lengthsq(this double4 f) => math.lengthsq(f);
        public static double3 lengthsq(this double3 f) => math.lengthsq(f);
        public static double2 lengthsq(this double2 f) => math.lengthsq(f);

        //Saturate
        public static float4 saturate(this float4 f) => math.saturate(f);
        public static float3 saturate(this float3 f) => math.saturate(f);
        public static float2 saturate(this float2 f) => math.saturate(f);
        public static float saturate(this float f) => math.saturate(f);
        
        public static float4 saturate(this Vector4 f) => math.saturate(f);
        public static float3 saturate(this Vector3 f) => math.saturate(f);
        public static float2 saturate(this Vector2 f) => math.saturate(f);
        
        public static double4 saturate(this double4 f) => math.saturate(f);
        public static double3 saturate(this double3 f) => math.saturate(f);
        public static double2 saturate(this double2 f) => math.saturate(f);
        public static double saturate(this double f) => math.saturate(f);
        
        
        // Square Root
        public static float4 sqrt(this float4 f) => math.sqrt(f);
        public static float3 sqrt(this float3 f) => math.sqrt(f);
        public static float2 sqrt(this float2 f) => math.sqrt(f);
        public static float sqrt(this float f) => math.sqrt(f);
        public static float sqrt(this int f) => math.sqrt(f);
        
        public static float4 sqrt(this Vector4 f) => math.sqrt(f);
        public static float3 sqrt(this Vector3 f) => math.sqrt(f);
        public static float2 sqrt(this Vector2 f) => math.sqrt(f);
        
        public static double4 sqrt(this double4 f) => math.sqrt(f);
        public static double3 sqrt(this double3 f) => math.sqrt(f);
        public static double2 sqrt(this double2 f) => math.sqrt(f);
        public static double sqrt(this double f) => math.sqrt(f);
        
        // Cube Root
        
        private const double dthird = 0.333333333333333333333;
        private const float fthird = 0.3333333333f;
            
        public static float4 cbrt(this float4 f) => f.cbrt().rcp();
        public static float3 cbrt(this float3 f) => f.cbrt().rcp();
        public static float2 cbrt(this float2 f) => f.cbrt().rcp();
        public static float cbrt(this float f) => f.cbrt().rcp();
        public static float cbrt(this int f) => f.cbrt().rcp();
        
        public static float4 cbrt(this Vector4 f) => f.cbrt().rcp();
        public static float3 cbrt(this Vector3 f) => f.cbrt().rcp();
        public static float2 cbrt(this Vector2 f) => f.sign() * (f.asfloat() * f.sign()).pow(fthird);

        public static double4 cbrt(this double4 f) => f.sign() * (f * f.sign()).pow(dthird);
        public static double3 cbrt(this double3 f) => f.sign() * (f * f.sign()).pow(dthird);
        public static double2 cbrt(this double2 f) => f.sign() * (f * f.sign()).pow(dthird);
        public static double cbrt(this double f) => f.sign() * (f * f.sign()).pow(dthird);
        
        // Inverse cube root

        public static float4 rcbrt(this float4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this float3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this float2 f) => f.cbrt().rcp();
        public static float rcbrt(this float f) => f.cbrt().rcp();
        public static float rcbrt(this int f) => f.cbrt().rcp();
        
        public static float4 rcbrt(this Vector4 f) => f.cbrt().rcp();
        public static float3 rcbrt(this Vector3 f) => f.cbrt().rcp();
        public static float2 rcbrt(this Vector2 f) => f.cbrt().rcp();

        public static double4 rcbrt(this double4 f) => f.cbrt().rcp();
        public static double3 rcbrt(this double3 f) => f.cbrt().rcp();
        public static double2 rcbrt(this double2 f) => f.cbrt().rcp();
        public static double rcbrt(this double f) => f.cbrt().rcp();


        // Inverse Square Root
        public static float4 rsqrt(this float4 f) => math.rsqrt(f);
        public static float3 rsqrt(this float3 f) => math.rsqrt(f);
        public static float2 rsqrt(this float2 f) => math.rsqrt(f);
        public static float rsqrt(this float f) => math.rsqrt(f);
        public static float rsqrt(this int f) => math.rsqrt(f);
        
        public static float4 rsqrt(this Vector4 f) => math.rsqrt(f);
        public static float3 rsqrt(this Vector3 f) => math.rsqrt(f);
        public static float2 rsqrt(this Vector2 f) => math.rsqrt(f);
        
        public static double4 rsqrt(this double4 f) => math.rsqrt(f);
        public static double3 rsqrt(this double3 f) => math.rsqrt(f);
        public static double2 rsqrt(this double2 f) => math.rsqrt(f);
        public static double rsqrt(this double f) => math.rsqrt(f);


        //Math Operations From Matrices ------------------------------------------------------------------
        //Self Distance
        public static float distance(this float2x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float3x2 f) => math.distance(f.c0, f.c1);
        public static float distance(this float4x2 f) => math.distance(f.c0, f.c1);
        
        public static double distance(this double4x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double3x2 f) => math.distance(f.c0, f.c1);
        public static double distance(this double2x2 f) => math.distance(f.c0, f.c1);
        
        // Self Squared Distance
        public static float distancesq(this float2x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float3x2 f) => math.distancesq(f.c0, f.c1);
        public static float distancesq(this float4x2 f) => math.distancesq(f.c0, f.c1);
        
        public static double distancesq(this double4x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double3x2 f) => math.distancesq(f.c0, f.c1);
        public static double distancesq(this double2x2 f) => math.distancesq(f.c0, f.c1);
        
        // Self Cross
        public static float3 cross(this float3x2 f) => math.cross(f.c0, f.c1);
        public static double3 cross(this double3x2 f) => math.cross(f.c0, f.c1);
        
        // Self Dot
        public static float dot(this float4x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float3x2 f) => math.dot(f.c0, f.c1);
        public static float dot(this float2x2 f) => math.dot(f.c0, f.c1);
        
        public static double dot(this double4x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double3x2 f) => math.dot(f.c0, f.c1);
        public static double dot(this double2x2 f) => math.dot(f.c0, f.c1);


        
        
        // Trigonometry ----------------------------------------------------------------------------------
        
        // Cosine
        public static float4 cos(this float4 f) => math.cos(f);
        public static float3 cos(this float3 f) => math.cos(f);
        public static float2 cos(this float2 f) => math.cos(f);
        public static float cos(this float f) => math.cos(f);
        public static float cos(this int f) => math.cos(f);
        
        public static float4 cos(this Vector4 f) => math.cos(f);
        public static float3 cos(this Vector3 f) => math.cos(f);
        public static float2 cos(this Vector2 f) => math.cos(f);
        
        public static double4 cos(this double4 f) => math.cos(f);
        public static double3 cos(this double3 f) => math.cos(f);
        public static double2 cos(this double2 f) => math.cos(f);
        public static double cos(this double f) => math.cos(f);
        
        // Sine
        public static float4 sin(this float4 f) => math.sin(f);
        public static float3 sin(this float3 f) => math.sin(f);
        public static float2 sin(this float2 f) => math.sin(f);
        public static float sin(this float f) => math.sin(f);
        public static float sin(this int f) => math.sin(f);
        
        public static float4 sin(this Vector4 f) => math.sin(f);
        public static float3 sin(this Vector3 f) => math.sin(f);
        public static float2 sin(this Vector2 f) => math.sin(f);
        
        public static double4 sin(this double4 f) => math.sin(f);
        public static double3 sin(this double3 f) => math.sin(f);
        public static double2 sin(this double2 f) => math.sin(f);
        public static double sin(this double f) => math.sin(f);
        
        
        // Tangent
        public static float4 tan(this float4 f) => math.tan(f);
        public static float3 tan(this float3 f) => math.tan(f);
        public static float2 tan(this float2 f) => math.tan(f);
        public static float tan(this float f) => math.tan(f);
        public static float tan(this int f) => math.tan(f);
        
        public static float4 tan(this Vector4 f) => math.tan(f);
        public static float3 tan(this Vector3 f) => math.tan(f);
        public static float2 tan(this Vector2 f) => math.tan(f);
        
        public static double4 tan(this double4 f) => math.tan(f);
        public static double3 tan(this double3 f) => math.tan(f);
        public static double2 tan(this double2 f) => math.tan(f);
        public static double tan(this double f) => math.tan(f);
        
        
        // Hyperbolic Cosine
        public static float4 cosh(this float4 f) => math.cosh(f);
        public static float3 cosh(this float3 f) => math.cosh(f);
        public static float2 cosh(this float2 f) => math.cosh(f);
        public static float cosh(this float f) => math.cosh(f);
        public static float cosh(this int f) => math.cosh(f);
        
        public static float4 cosh(this Vector4 f) => math.cosh(f);
        public static float3 cosh(this Vector3 f) => math.cosh(f);
        public static float2 cosh(this Vector2 f) => math.cosh(f);
        
        public static double4 cosh(this double4 f) => math.cosh(f);
        public static double3 cosh(this double3 f) => math.cosh(f);
        public static double2 cosh(this double2 f) => math.cosh(f);
        public static double cosh(this double f) => math.cosh(f);
        
        
        // Hyperbolic Sine
        public static float4 sinh(this float4 f) => math.sinh(f);
        public static float3 sinh(this float3 f) => math.sinh(f);
        public static float2 sinh(this float2 f) => math.sinh(f);
        public static float sinh(this float f) => math.sinh(f);
        public static float sinh(this int f) => math.sinh(f);
        
        public static float4 sinh(this Vector4 f) => math.sinh(f);
        public static float3 sinh(this Vector3 f) => math.sinh(f);
        public static float2 sinh(this Vector2 f) => math.sinh(f);
        
        public static double4 sinh(this double4 f) => math.sinh(f);
        public static double3 sinh(this double3 f) => math.sinh(f);
        public static double2 sinh(this double2 f) => math.sinh(f);
        public static double sinh(this double f) => math.sinh(f);
        
        // Hyperbolic Tangent
        public static float4 tanh(this float4 f) => math.tanh(f);
        public static float3 tanh(this float3 f) => math.tanh(f);
        public static float2 tanh(this float2 f) => math.tanh(f);
        public static float tanh(this float f) => math.tanh(f);
        public static float tanh(this int f) => math.tanh(f);
        
        public static float4 tanh(this Vector4 f) => math.tanh(f);
        public static float3 tanh(this Vector3 f) => math.tanh(f);
        public static float2 tanh(this Vector2 f) => math.tanh(f);
        
        public static double4 tanh(this double4 f) => math.tanh(f);
        public static double3 tanh(this double3 f) => math.tanh(f);
        public static double2 tanh(this double2 f) => math.tanh(f);
        public static double tanh(this double f) => math.tanh(f);
        
        // Arccosine
        public static float4 acos(this float4 f) => math.acos(f);
        public static float3 acos(this float3 f) => math.acos(f);
        public static float2 acos(this float2 f) => math.acos(f);
        public static float acos(this float f) => math.acos(f);
        public static float acos(this int f) => math.acos(f);
        
        public static float4 acos(this Vector4 f) => math.acos(f);
        public static float3 acos(this Vector3 f) => math.acos(f);
        public static float2 acos(this Vector2 f) => math.acos(f);
        
        public static double4 acos(this double4 f) => math.acos(f);
        public static double3 acos(this double3 f) => math.acos(f);
        public static double2 acos(this double2 f) => math.acos(f);
        public static double acos(this double f) => math.acos(f);
        
        // Arcsine
        public static float4 asin(this float4 f) => math.asin(f);
        public static float3 asin(this float3 f) => math.asin(f);
        public static float2 asin(this float2 f) => math.asin(f);
        public static float asin(this float f) => math.asin(f);
        public static float asin(this int f) => math.asin(f);
        
        public static float4 asin(this Vector4 f) => math.asin(f);
        public static float3 asin(this Vector3 f) => math.asin(f);
        public static float2 asin(this Vector2 f) => math.asin(f);
        
        public static double4 asin(this double4 f) => math.asin(f);
        public static double3 asin(this double3 f) => math.asin(f);
        public static double2 asin(this double2 f) => math.asin(f);
        public static double asin(this double f) => math.asin(f);
        
        // Arctangent
        public static float4 atan(this float4 f) => math.atan(f);
        public static float3 atan(this float3 f) => math.atan(f);
        public static float2 atan(this float2 f) => math.atan(f);
        public static float atan(this float f) => math.atan(f);
        public static float atan(this int f) => math.atan(f);
        
        public static float4 atan(this Vector4 f) => math.atan(f);
        public static float3 atan(this Vector3 f) => math.atan(f);
        public static float2 atan(this Vector2 f) => math.atan(f);
        
        public static double4 atan(this double4 f) => math.atan(f);
        public static double3 atan(this double3 f) => math.atan(f);
        public static double2 atan(this double2 f) => math.atan(f);
        public static double atan(this double f) => math.atan(f);
        
        // Secant
        public static float4 sec(this float4 f) => f.cosh().rcp();
        public static float3 sec(this float3 f) => f.cosh().rcp();
        public static float2 sec(this float2 f) => f.cosh().rcp();
        public static float sec(this float f) => f.cosh().rcp();
        public static float sec(this int f) => f.cosh().rcp();
        
        public static float4 sec(this Vector4 f) => f.cosh().rcp();
        public static float3 sec(this Vector3 f) => f.cosh().rcp();
        public static float2 sec(this Vector2 f) => f.cosh().rcp();
        
        public static double4 sec(this double4 f) => f.cosh().rcp();
        public static double3 sec(this double3 f) => f.cosh().rcp();
        public static double2 sec(this double2 f) => f.cosh().rcp();
        public static double sec(this double f) => f.cosh().rcp();
        
        // Secant²
        public static float4 sec2(this float4 f) => f.cosh().sqr().rcp();
        public static float3 sec2(this float3 f) => f.cosh().sqr().rcp();
        public static float2 sec2(this float2 f) => f.cosh().sqr().rcp();
        public static float sec2(this float f) => f.cosh().sqr().rcp();
        public static float sec2(this int f) => f.cosh().sqr().rcp();
        
        public static float4 sec2(this Vector4 f) => f.cosh().sqr().rcp();
        public static float3 sec2(this Vector3 f) => f.cosh().sqr().rcp();
        public static float2 sec2(this Vector2 f) => f.cosh().sqr().rcp();
        
        public static double4 sec2(this double4 f) => f.cosh().sqr().rcp();
        public static double3 sec2(this double3 f) => f.cosh().sqr().rcp();
        public static double2 sec2(this double2 f) => f.cosh().sqr().rcp();
        public static double sec2(this double f) => f.cosh().sqr().rcp();

        
        // Cosine²
        public static float4 cos2(this float4 f) => (1 + f.cos()) / 2;
        public static float3 cos2(this float3 f) => (1 + f.cos()) / 2;
        public static float2 cos2(this float2 f) => (1 + f.cos()) / 2;
        public static float cos2(this float f) => (1 + f.cos()) / 2;
        public static float cos2(this int f) => (1 + f.cos()) / 2;
        
        public static float4 cos2(this Vector4 f) => (1 + f.cos()) / 2;
        public static float3 cos2(this Vector3 f) => (1 + f.cos()) / 2;
        public static float2 cos2(this Vector2 f) => (1 + f.cos()) / 2;
        
        public static double4 cos2(this double4 f) => (1 + f.cos()) / 2;
        public static double3 cos2(this double3 f) => (1 + f.cos()) / 2;
        public static double2 cos2(this double2 f) => (1 + f.cos()) / 2;
        public static double cos2(this double f) => (1 + f.cos()) / 2;
        
        // Sine²
        public static float4 sin2(this float4 f) => (1 - f.cos()) / 2;
        public static float3 sin2(this float3 f) => (1 - f.cos()) / 2;
        public static float2 sin2(this float2 f) => (1 - f.cos()) / 2;
        public static float sin2(this float f) => (1 - f.cos()) / 2;
        public static float sin2(this int f) => (1 - f.cos()) / 2;
        
        public static float4 sin2(this Vector4 f) => (1 - f.cos()) / 2;
        public static float3 sin2(this Vector3 f) => (1 - f.cos()) / 2;
        public static float2 sin2(this Vector2 f) => (1 - f.cos()) / 2;
        
        public static double4 sin2(this double4 f) => (1 - f.cos()) / 2;
        public static double3 sin2(this double3 f) => (1 - f.cos()) / 2;
        public static double2 sin2(this double2 f) => (1 - f.cos()) / 2;
        public static double sin2(this double f) => (1 - f.cos()) / 2;

        // Tangent²
        public static float4 tan2(this float4 f) => f.sec2() - 1;
        public static float3 tan2(this float3 f) => f.sec2() - 1;
        public static float2 tan2(this float2 f) => f.sec2() - 1;
        public static float tan2(this float f) => f.sec2() - 1;
        public static float tan2(this int f) => f.sec2() - 1;
        
        public static float4 tan2(this Vector4 f) => f.sec2() - 1;
        public static float3 tan2(this Vector3 f) => f.sec2() - 1;
        public static float2 tan2(this Vector2 f) => f.sec2() - 1;
        
        public static double4 tan2(this double4 f) => f.sec2() - 1;
        public static double3 tan2(this double3 f) => f.sec2() - 1;
        public static double2 tan2(this double2 f) => f.sec2() - 1;
        public static double tan2(this double f) => f.sec2() - 1;
        
        // Degrees
        public static float4 degrees(this float4 f) => math.degrees(f);
        public static float3 degrees(this float3 f) => math.degrees(f);
        public static float2 degrees(this float2 f) => math.degrees(f);
        public static float degrees(this float f) => math.degrees(f);
        public static float degrees(this int f) => math.degrees(f);
        
        public static float4 degrees(this Vector4 f) => math.degrees(f);
        public static float3 degrees(this Vector3 f) => math.degrees(f);
        public static float2 degrees(this Vector2 f) => math.degrees(f);
        
        public static double4 degrees(this double4 f) => math.degrees(f);
        public static double3 degrees(this double3 f) => math.degrees(f);
        public static double2 degrees(this double2 f) => math.degrees(f);
        public static double degrees(this double f) => math.degrees(f);
        
        // Radians
        public static float4 radians(this float4 f) => math.radians(f);
        public static float3 radians(this float3 f) => math.radians(f);
        public static float2 radians(this float2 f) => math.radians(f);
        public static float radians(this float f) => math.radians(f);
        public static float radians(this int f) => math.radians(f);
        
        public static float4 radians(this Vector4 f) => math.radians(f);
        public static float3 radians(this Vector3 f) => math.radians(f);
        public static float2 radians(this Vector2 f) => math.radians(f);
        
        public static double4 radians(this double4 f) => math.radians(f);
        public static double3 radians(this double3 f) => math.radians(f);
        public static double2 radians(this double2 f) => math.radians(f);
        public static double radians(this double f) => math.radians(f);
        
        // SinCos
        public static float4x2 sincos(this float4 f4) {
            var f = new float4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static float3x2 sincos(this float3 f3) {
            var f = new float3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static float2x2 sincos(this float2 f2) {
            var f = new float2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }
        public static float2 sincos(this float f) {
            var f2 = new float2();
            math.sincos(f,out f2.x, out f2.y);
            return f2;
        }
        public static float4x2 sincos(this Vector4 f4) {
            var f = new float4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static float3x2 sincos(this Vector3 f3) {
            var f = new float3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static float2x2 sincos(this Vector2 f2) {
            var f = new float2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }

        public static double4x2 sincos(this double4 f4) {
            var f = new double4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static double3x2 sincos(this double3 f3) {
            var f = new double3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static double2x2 sincos(this double2 f2) {
            var f = new double2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }
        public static double2 sincos(this double f) {
            var f2 = new double2();
            math.sincos(f,out f2.x, out f2.y);
            return f2;
        }



        // Rounding Values ----------------------------------------------------
        public static float4 ceil(this float4 f) => math.ceil(f);
        public static float3 ceil(this float3 f) => math.ceil(f);
        public static float2 ceil(this float2 f) => math.ceil(f);
        public static float ceil(this float f) => math.ceil(f);
        public static int ceil(this int f) => (int)math.ceil(f);
        
        public static float4 ceil(this Vector4 f) => math.ceil(f);
        public static float3 ceil(this Vector3 f) => math.ceil(f);
        public static float2 ceil(this Vector2 f) => math.ceil(f);
        
        public static double4 ceil(this double4 f) => math.ceil(f);
        public static double3 ceil(this double3 f) => math.ceil(f);
        public static double2 ceil(this double2 f) => math.ceil(f);
        public static double ceil(this double f) => math.ceil(f);
        
        // Floor
        public static float4 floor(this float4 f) => math.floor(f);
        public static float3 floor(this float3 f) => math.floor(f);
        public static float2 floor(this float2 f) => math.floor(f);
        public static float floor(this float f) => math.floor(f);
        public static int floor(this int f) => (int)math.floor(f);
        
        public static float4 floor(this Vector4 f) => math.floor(f);
        public static float3 floor(this Vector3 f) => math.floor(f);
        public static float2 floor(this Vector2 f) => math.floor(f);
        
        public static double4 floor(this double4 f) => math.floor(f);
        public static double3 floor(this double3 f) => math.floor(f);
        public static double2 floor(this double2 f) => math.floor(f);
        public static double floor(this double f) => math.floor(f);
        
        
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
        
        // Round
        public static float4 round(this float4 f) => math.round(f);
        public static float3 round(this float3 f) => math.round(f);
        public static float2 round(this float2 f) => math.round(f);
        public static float round(this float f) => math.round(f);
        
        public static float4 round(this Vector4 f) => math.round(f);
        public static float3 round(this Vector3 f) => math.round(f);
        public static float2 round(this Vector2 f) => math.round(f);
        
        public static double4 round(this double4 f) => math.round(f);
        public static double3 round(this double3 f) => math.round(f);
        public static double2 round(this double2 f) => math.round(f);
        public static double round(this double f) => math.round(f);
        
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
        
     
        //https://rosettacode.org/wiki/Gamma_function#C.23
        
        //Factorial Lanczos Interpolated ---------------------------------------------------------------
        
        private static readonly double[] P = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
            771.32342877765313, -176.61502916214059, 12.507343278686905,
            -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};

        /// <summary>Returns the factorial componentwise Lanczos-interpolated value (gamma function)</summary>
        // public static float fct(this float f) => (float)f.asdouble().fct();
        /// <inheritdoc cref="fct(float)"/>>
        public static double fct(this double f)
        {
            if (f == 0 || f == 1) return 1;
            if (f < 0.5) return math.PI_DBL / ((math.PI_DBL * f).sin() * fct(1 - f));

            var f2 = f - 1;
            var x = P[0];
            for (var i = 1; i < 9; i++) x += P[i] / (f2 + i);
            
            var t = f2 + 7.5;
            return (2 * math.PI_DBL).sqrt() * t.pow(f2 + 0.5) * (-t).exp() * x;
        }
        
        public static float fct(this float f)
        {
            if (f == 0 || f == 1) return 1;
            if (f < 0.5f) return math.PI / ((math.PI * f).sin() * fct(1 - f));

            var f2 = f - 1;
            var x = (float)P[0];
            for (var i = 1; i < 9; i++) x += (float)P[i] / (f2 + i);
            
            var t = f2 + 7.5f;
            return (2 * math.PI).sqrt() * t.pow(f2 + 0.5f) * (-t).exp() * x;
        }
        
        /// <inheritdoc cref="fct(float)"/>>
        public static Complex fct(this Complex z)
        {
            // Reflection formula
            if (z.Real < 0.5) return math.PI_DBL / (Complex.Sin( math.PI_DBL * z) * fct(1 - z));
            
            z -= 1;
            Complex x = P[0];
            for (var i = 1; i < 9; i++) x += P[i]/(z+i);
            
            var t = z + 7.5;
            return Complex.Sqrt(2 * math.PI_DBL) * Complex.Pow(t, z + 0.5) * Complex.Exp(-t) * x;
        }
        
        /// <inheritdoc cref="fct(float)"/>>
        public static float4 fct(this float4 f) => new float4(f.xy.fct(), f.zw.fct());
        /// <inheritdoc cref="fct(float)"/>>
        public static float3 fct(this float3 f) => new float3(f.xy.fct(), f.z.fct());
        /// <inheritdoc cref="fct(float)"/>>
        public static float2 fct(this float2 f) => new float2(f.x.fct(), f.y.fct());
        /// <inheritdoc cref="fct(float)"/>>

        public static float4 fct(this Vector4 f) => f.asfloat().fct();
        /// <inheritdoc cref="fct(float)"/>>
        public static float3 fct(this Vector3 f) => f.asfloat().fct();
        /// <inheritdoc cref="fct(float)"/>>
        public static float2 fct(this Vector2 f) => f.asfloat().fct();
        
        /// <inheritdoc cref="fct(float)"/>>
        public static double4 fct(this double4 f) => new double4(f.xy.fct(), f.zw.fct());
        /// <inheritdoc cref="fct(float)"/>>
        public static double3 fct(this double3 f) => new double3(f.xy.fct(), f.z.fct());
        /// <inheritdoc cref="fct(float)"/>> ///
        public static double2 fct(this double2 f) => new double2(f.x.fct(), f.y.fct());


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

        
        // Clamp ---------------------------------------------------------------------------------------
        
        public static float4 clamp(this float4 f, float4 min, float4 max) => math.clamp(f, min, max);
        public static float3 clamp(this float3 f, float3 min, float3 max) => math.clamp(f, min, max);
        public static float2 clamp(this float2 f, float2 min, float2 max) => math.clamp(f, min, max);
        public static float clamp(this float f, float min, float max) => math.clamp(f, min, max);
        public static float clamp(this int f, float min, float max) => math.clamp(f, min, max);
        public static int clamp(this int f, int min, int max) => math.clamp(f, min, max);
        
        public static float4 min(this Vector4 f, float4 min, float4 max) => math.clamp(f, min, max);
        public static float3 min(this Vector3 f, float3 min, float3 max) => math.clamp(f, min, max);
        public static float2 min(this Vector2 f, float2 min, float2 max) => math.clamp(f, min, max);
        
        public static double4 clamp(this double4 f, double4 min, double4 max) => math.clamp(f, min, max);
        public static double3 clamp(this double3 f, double3 min, double3 max) => math.clamp(f, min, max);
        public static double2 clamp(this double2 f, double2 min, double2 max) => math.clamp(f, min, max);
        public static double clamp(this double f, double min, double max) => math.clamp(f, min, max);

        
        // Minimum ------------------------------------------------------------------------------------
        
        public static float4 min(this float4 f, float4 m) => math.min(f, m);
        public static float3 min(this float3 f, float3 m) => math.min(f, m);
        public static float2 min(this float2 f, float2 m) => math.min(f, m);
        public static float min(this float f, float m) => math.min(f, m);
        public static float min(this int f, float m) => math.min(f, m);
        public static int min(this int f, int m) => math.min(f, m);
        
        public static float4 min(this Vector4 f, float4 m) => math.min(f, m);
        public static float3 min(this Vector3 f, float3 m) => math.min(f, m);
        public static float2 min(this Vector2 f, float2 m) => math.min(f, m);
        
        public static double4 min(this double4 f, double4 m) => math.min(f, m);
        public static double3 min(this double3 f, double3 m) => math.min(f, m);
        public static double2 min(this double2 f, double2 m) => math.min(f, m);
        public static double min(this double f, double m) => math.min(f, m);
        
        // Maximum ------------------------------------------------------------------------------------

        public static float4 max(this float4 f, float4 m) => math.max(f, m);
        public static float3 max(this float3 f, float3 m) => math.max(f, m);
        public static float2 max(this float2 f, float2 m) => math.max(f, m);
        public static float max(this float f, float m) => math.max(f, m);
        public static float max(this int f, float m) => math.max(f, m);
        public static int max(this int f, int m) => math.max(f, m);

        public static float4 max(this Vector4 f, float4 m) => math.max(f, m);
        public static float3 max(this Vector3 f, float3 m) => math.max(f, m);
        public static float2 max(this Vector2 f, float2 m) => math.max(f, m);
        
        public static double4 max(this double4 f, double4 m) => math.max(f, m);
        public static double3 max(this double3 f, double3 m) => math.max(f, m);
        public static double2 max(this double2 f, double2 m) => math.max(f, m);
        public static double max(this double f, double m) => math.max(f, m);
        
        
        // Power ---------------------------------------------------------------------------------

        public static float4 pow(this float4 f, float4 pow) => math.pow(f, pow);
        public static float3 pow(this float3 f, float3 pow) => math.pow(f, pow);
        public static float2 pow(this float2 f, float2 pow) => math.pow(f, pow);
        public static float pow(this float f, float pow) => math.pow(f, pow);
        public static float pow(this int f, float pow) => (int)math.pow(f, pow);
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
        public static int sqr(this int f) => f * f;
        
        public static float4 sqr(this Vector4 f) => f.asfloat() * f;
        public static float3 sqr(this Vector3 f) => f.asfloat() * f;
        public static float2 sqr(this Vector2 f) => f * f;
        
        public static double4 sqr(this double4 f) => f * f;
        public static double3 sqr(this double3 f) => f * f;
        public static double2 sqr(this double2 f) => f * f;
        public static double sqr(this double f) => f * f;
        
        // Cube -----------------------------------------------------------------------------------
        
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

        // Exponential ----------------------------------------------------------------------------
        public static float4 exp(this float4 f) => math.exp(f);
        public static float3 exp(this float3 f) => math.exp(f);
        public static float2 exp(this float2 f) => math.exp(f);
        public static float exp(this float f) => math.exp(f);
        public static float exp(this int f) => math.exp(f);
        
        public static float4 exp(this Vector4 f) => math.exp(f);
        public static float3 exp(this Vector3 f) => math.exp(f);
        public static float2 exp(this Vector2 f) => math.exp(f);

        public static double4 exp(this double4 f) => math.exp(f);
        public static double3 exp(this double3 f) => math.exp(f);
        public static double2 exp(this double2 f) => math.exp(f);
        public static double exp(this double f) => math.exp(f);

        // Exponential Base 2
        public static float4 exp2(this float4 f) => math.exp2(f);
        public static float3 exp2(this float3 f) => math.exp2(f);
        public static float2 exp2(this float2 f) => math.exp2(f);
        public static float exp2(this float f) => math.exp2(f);
        public static float exp2(this int f) => math.exp2(f);
        
        public static float4 exp2(this Vector4 f) => math.exp2(f);
        public static float3 exp2(this Vector3 f) => math.exp2(f);
        public static float2 exp2(this Vector2 f) => math.exp2(f);

        public static double4 exp2(this double4 f) => math.exp2(f);
        public static double3 exp2(this double3 f) => math.exp2(f);
        public static double2 exp2(this double2 f) => math.exp2(f);
        public static double exp2(this double f) => math.exp2(f);
        
        // Exponential Base 10
        public static float4 exp10(this float4 f) => math.exp10(f);
        public static float3 exp10(this float3 f) => math.exp10(f);
        public static float2 exp10(this float2 f) => math.exp10(f);
        public static float exp10(this float f) => math.exp10(f);
        public static float exp10(this int f) => math.exp10(f);
        
        public static float4 exp10(this Vector4 f) => math.exp10(f);
        public static float3 exp10(this Vector3 f) => math.exp10(f);
        public static float2 exp10(this Vector2 f) => math.exp10(f);
        
        public static double4 exp10(this double4 f) => math.exp10(f);
        public static double3 exp10(this double3 f) => math.exp10(f);
        public static double2 exp10(this double2 f) => math.exp10(f);
        public static double exp10(this double f) => math.exp10(f);

        // Logaryhms ------------------------------------------------------------------------------------
        // Natural Logarithm renamed to "ln", to avoid confusion in the scientific community
        public static float4 ln(this float4 f) => math.log(f);
        public static float3 ln(this float3 f) => math.log(f);
        public static float2 ln(this float2 f) => math.log(f);
        public static float ln(this float f) => math.log(f);
        public static float ln(this int f) => math.log(f);
        
        public static float4 ln(this Vector4 f) => math.log(f);
        public static float3 ln(this Vector3 f) => math.log(f);
        public static float2 ln(this Vector2 f) => math.log(f);

        public static double4 ln(this double4 f) => math.log(f);
        public static double3 ln(this double3 f) => math.log(f);
        public static double2 ln(this double2 f) => math.log(f);
        public static double ln(this double f) => math.log(f);
        
        // Log Base 2
        public static float4 log2(this float4 f) => math.log2(f);
        public static float3 log2(this float3 f) => math.log2(f);
        public static float2 log2(this float2 f) => math.log2(f);
        public static float log2(this float f) => math.log2(f);
        public static float log2(this int f) => math.log2(f);
        
        public static float4 log2(this Vector4 f) => math.log2(f);
        public static float3 log2(this Vector3 f) => math.log2(f);
        public static float2 log2(this Vector2 f) => math.log2(f);

        public static double4 log2(this double4 f) => math.log2(f);
        public static double3 log2(this double3 f) => math.log2(f);
        public static double2 log2(this double2 f) => math.log2(f);
        public static double log2(this double f) => math.log2(f);
        
        // Log Base 10
        public static float4 log10(this float4 f) => math.log10(f);
        public static float3 log10(this float3 f) => math.log10(f);
        public static float2 log10(this float2 f) => math.log10(f);
        public static float log10(this float f) => math.log10(f);
        public static float log10(this int f) => math.log10(f);
        
        public static float4 log10(this Vector4 f) => math.log10(f);
        public static float3 log10(this Vector3 f) => math.log10(f);
        public static float2 log10(this Vector2 f) => math.log10(f);
        
        public static double4 log10(this double4 f) => math.log10(f);
        public static double3 log10(this double3 f) => math.log10(f);
        public static double2 log10(this double2 f) => math.log10(f);
        public static double log10(this double f) => math.log10(f);
        
        
        
        // SmoothStep -----------------------------------------------------------------------------
        
        /// Returns a smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].
        public static float smoothstep(this float f, float min, float max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double smoothstep(this double f, double min, double max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float4 smoothstep(this float4 f, float4 min, float4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float3 smoothstep(this float3 f, float3 min, float3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float2 smoothstep(this float2 f, float2 min, float2 max) => math.smoothstep(min, max, f);
        
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float4 smoothstep(this Vector4 f, float4 min, float4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float3 smoothstep(this Vector3 f, float3 min, float3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static float2 smoothstep(this Vector2 f, float2 min, float2 max) => math.smoothstep(min, max, f);
        
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double4 smoothstep(this double4 f, double4 min, double4 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double3 smoothstep(this double3 f, double3 min, double3 max) => math.smoothstep(min, max, f);
        /// <inheritdoc cref="smoothstep(float,float,float)"/>
        public static double2 smoothstep(this double2 f, double2 min, double2 max) => math.smoothstep(min, max, f);


        // Component-wise comparison --------------------------------------------------------------

        public static float cmax(this float4 f) => math.cmax(f);
        public static float cmax(this float3 f) => math.cmax(f);
        public static float cmax(this float2 f) => math.cmax(f);
        
        public static double cmax(this double4 f) => math.cmax(f);
        public static double cmax(this double3 f) => math.cmax(f);
        public static double cmax(this double2 f) => math.cmax(f);
        
        public static float cmax(this Vector4 f) => math.cmax(f);
        public static float cmax(this Vector3 f) => math.cmax(f);
        public static float cmax(this Vector2 f) => math.cmax(f);

        public static float cmin(this float4 f) => math.cmin(f);
        public static float cmin(this float3 f) => math.cmin(f);
        public static float cmin(this float2 f) => math.cmin(f);
        
        public static float cmin(this Vector4 f) => math.cmin(f);
        public static float cmin(this Vector3 f) => math.cmin(f);
        public static float cmin(this Vector2 f) => math.cmin(f);
        
        public static double cmin(this double4 f) => math.cmin(f);
        public static double cmin(this double3 f) => math.cmin(f);
        public static double cmin(this double2 f) => math.cmin(f);
        
        
        /// Returns 1 inside the longest(s) axis(es) and 0 in the others
        public static bool4 cmaxAxis(this float4 f) { var m = f.cmax(); return new bool4(f.x == m, f.y == m,f.z == m,f.w == m); }
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool3 cmaxAxis(this float3 f) { var m = f.cmax(); return new bool3(f.x == m, f.y == m,f.z == m); }
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool2 cmaxAxis(this float2 f) { var m = f.cmax(); return new bool2(f.x == m, f.y == m); }
        
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool4 cmaxAxis(this Vector4 f) => f.asfloat().cmaxAxis();
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool3 cmaxAxis(this Vector3 f) => f.asfloat().cmaxAxis();
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool2 cmaxAxis(this Vector2 f) => f.asfloat().cmaxAxis();

        /// Returns true inside the shortest axes
        public static bool4 cminAxis(this float4 f) { var m = f.cmin(); return new bool4(f.x == m, f.y == m,f.z == m,f.w == m); }
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool3 cminAxis(this float3 f) { var m = f.cmin(); return new bool3(f.x == m, f.y == m,f.z == m); }
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool2 cminAxis(this float2 f) { var m = f.cmin(); return new bool2(f.x == m, f.y == m); }
        
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool4 cminAxis(this Vector4 f) => f.asfloat().cminAxis();
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool3 cminAxis(this Vector3 f) => f.asfloat().cminAxis();
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool2 cminAxis(this Vector2 f) => f.asfloat().cminAxis();
        
        
        
        // Shorthands -------------------------------------------------------------------------------------------------


        /// Shorthand for writing new float2(1,1)
        public static float2 float2one = new float2(1,1);
        
        /// Shorthand for writing new float2(0,0)
        public static float2 float2zero = new float2(0,0);
        
        /// Shorthand for writing new float2(0,1)
        public static float2 float2up = new float2(0,1);
        
        /// Shorthand for writing new float2(0,-1)
        public static float2 float2down = new float2(0,-1);
        
        /// Shorthand for writing new float2(1,0)
        public static float2 float2right = new float2(1,0);
        
        /// Shorthand for writing new float2(-1,0)
        public static float2 float2left = new float2(-1,0);



        /// Shorthand for writing new float3(1,1,1)
        public static float3 float3one = new float3(1,1,1);
        
        /// Shorthand for writing new float3(0,0,0)
        public static float3 float3zero = new float3(0,0,0);
        
        /// Shorthand for writing new float3(0,1,0)
        public static float3 float3up = new float3(0,1,0);
        
        /// Shorthand for writing new float3(1,0,0);
        public static float3 float3right = new float3(1,0,0);
        
        /// Shorthand for writing new float3(0,0,1)
        public static float3 float3forward = new float3(0,0,1);
        
        /// Shorthand for writing new new float3(0,-1,0)
        public static float3 float3down = new float3(0,-1,0);
        
        /// Shorthand for writing new float3(-1,0,0)
        public static float3 float3left = new float3(-1,0,0);
        
        /// Shorthand for writing new float3(0,0,-1)
        public static float3 float3back = new float3(0,0,-1);
        
        
        
        /// Shorthand for writing new float4(1,1,1,1)
        public static float4 float4one = new float4(1,1,1,1);
        
        /// Shorthand for writing new float4(0,0,0,0)
        public static float4 float4zero = new float4(0,0,0,0);
        


        /// Shorthand for writing new double2(1,1)
        public static double2 double2one = new double2(1,1);
        
        /// Shorthand for writing new double2(0,0)
        public static double2 double2zero = new double2(0,0);
        
        /// Shorthand for writing new double2(0,1)
        public static double2 double2up = new double2(0,1);
        
        /// Shorthand for writing new double2(0,-1)
        public static double2 double2down = new double2(0,-1);
        
        /// Shorthand for writing new double2(1,0)
        public static double2 double2right = new double2(1,0);
        
        /// Shorthand for writing new double2(-1,0)
        public static double2 double2left = new double2(-1,0);



        /// Shorthand for writing new double3(1,1,1)
        public static double3 double3one = new double3(1,1,1);
        
        /// Shorthand for writing new double3(0,0,0)
        public static double3 double3zero = new double3(0,0,0);
        
        /// Shorthand for writing new double3(0,1,0)
        public static double3 double3up = new double3(0,1,0);
        
        /// Shorthand for writing new double3(1,0,0);
        public static double3 double3right = new double3(1,0,0);
        
        /// Shorthand for writing new double3(0,0,1)
        public static double3 double3forward = new double3(0,0,1);
        
        /// Shorthand for writing new new double3(0,-1,0)
        public static double3 double3down = new double3(0,-1,0);
        
        /// Shorthand for writing new double3(-1,0,0)
        public static double3 double3left = new double3(-1,0,0);
        
        /// Shorthand for writing new double3(0,0,-1)
        public static double3 double33back = new double3(0,0,-1);
        
        
        /// Shorthand for writing new double4(1,1,1,1)
        public static double4 double4one = new double4(1,1,1,1);
        
        /// Shorthand for writing new float4(0,0,0,0)
        public static double4 double4zero = new double4(0,0,0,0);
        
        
        // Type Conversion -----------------------------------------------------------------------------
        
        // floats to ints
        public static int4 asint(this float4 f) => math.asint(f);
        public static int3 asint(this float3 f) => math.asint(f);
        public static int2 asint(this float2 f) => math.asint(f);
        public static int asint(this float f) => math.asint(f);

        // ints to floats
        public static float4 asfloat(this int4 f) => math.asfloat(f);
        public static float3 asfloat(this int3 f) => math.asfloat(f);
        public static float2 asfloat(this int2 f) => math.asfloat(f);
        public static float asfloat(this int f) => math.asfloat(f);

        // Vectors to floats
        public static float4 asfloat(this Vector4 f) => f;
        public static float3 asfloat(this Vector3 f) => f;
        public static float2 asfloat(this Vector2 f) => f;
        
        
        // Complex to doubles or floats
        public static double2 asdouble2(this Complex c) => new double2(c.Real, c.Imaginary);
        public static float2 asfloat2(this Complex c) => (float2)c.asdouble2();
        
        
        public static float2 asfloat2(this double2 d) => (float2)d;
        
        // bools to ints
        public static int4 asint(this bool4 b) => new int4(b.x.asint(), b.y.asint(), b.z.asint(), b.w.asint());
        public static int3 asint(this bool3 b) => new int3(b.x.asint(), b.y.asint(), b.z.asint());
        public static int2 asint(this bool2 b) => new int2(b.x.asint(), b.y.asint());
        public static int asint(this bool b) => b ? 1 : 0;
        
        // bools to floats
        public static float4 asfloat(this bool4 b) => b.asint();
        public static float3 asfloat(this bool3 b) => b.asint();
        public static float2 asfloat(this bool2 b) => b.asint();
        public static float asfloat(this bool b) => b.asint();
        
        // doubles to floats
        public static float4 asfloat(this double4 f) => (float4)f;
        public static float3 asfloat(this double3 f) => (float3)f;
        public static float2 asfloat(this double2 f) => (float2)f;
        public static float asfloat(this double f) => (float)f;
        
        // floats to doubles
        public static double4 asdouble(this float4 f) => Convert.ToDouble(f);
        public static double3 asdouble(this float3 f) => Convert.ToDouble(f);
        public static double2 asdouble(this float2 f) => Convert.ToDouble(f);
        public static double asdouble(this float f) => Convert.ToDouble(f);


        //IEnumerable Type Conversion -----------------------------------------------------------------------
        
        public static List<Vector4> asvectors(this IEnumerable<float4> f4s) => f4s.Select(f => (Vector4) f).ToList();
        public static List<Vector3> asvectors(this IEnumerable<float3> f3s) => f3s.Select(f => (Vector3) f).ToList();
        public static List<Vector2> asvectors(this IEnumerable<float2> f2s) => f2s.Select(f => (Vector2) f).ToList();


        public static List<float4> asfloats(this IEnumerable<Vector4> v4s) => v4s.Select(f => (float4) f).ToList();
        public static List<float3> asfloats(this IEnumerable<Vector3> v3s) => v3s.Select(f => (float3) f).ToList();
        public static List<float2> asfloats(this IEnumerable<Vector2> v2s) => v2s.Select(f => (float2) f).ToList();

        public static List<Color> ascolors(this IEnumerable<float4> f4s) => f4s.Select(f => f.ascolor()).ToList();
        public static List<Color> ascolors(this IEnumerable<float3> f3s) => f3s.Select(f => f.ascolor()).ToList();
        public static List<Color> ascolors(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor()).ToList();
        
        public static List<float4> asfloat4s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat4()).ToList();
        public static List<float3> asfloat3s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat3()).ToList();
        public static List<float2> asfloat2s(this IEnumerable<Color> colors) => colors.Select(c => c.asfloat2()).ToList();

        // floats as Color
        public static Color ascolor(this float4 f) => new Color(f.x, f.y, f.z, f.w);
        public static Color ascolor(this float3 f) => new Color(f.x, f.y, f.z);
        public static Color ascolor(this float2 f) => new Color(f.x, f.y, 0);
        public static Color ascolor(this float f) => new Color(f,f,f);

        // Color as floats
        public static float4 asfloat4(this Color c) => new float4(c.r, c.g, c.b, c.a);
        public static float3 asfloat3(this Color c) => new float3(c.r, c.g, c.b);
        public static float2 asfloat2(this Color c) => new float2(c.r, c.g);


        //Specific Functions ------------------------------------------------------------------------------------------
        //Existing In UnityEngine Code, converted

        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        public static float repeat(this float t, float length) => (t - (t / length).floor() * length).clamp(0, length);
        
        /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
        public static float pingpong(float t, float length)
        {
            t = t.repeat(length * 2);//repeat(t, length * 2);
            return length - (t - length).abs();
        }
        
        
        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24
        
        // Evil floating point bit level hacking.
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatIntUnion
        {
            [FieldOffset(0)] public float f;
            [FieldOffset(0)] public int tmp;
        }
        /// The Infamous Unusual Fast Inverse Square Root (TM).
        public static float fastrsqrt(this float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.tmp = 0;
            float xhalf = 0.5f * z;
            u.f = z;
            u.tmp = 0x5f375a86 - (u.tmp >> 1);
            u.f *= 1.5f - xhalf * u.f * u.f;
            return u.f * z;
        }
        
        /// Returns the distance between a and b (fast but very low accuracy).
        public static float fastdistance(float4 a, float4 b) => fastsqrt((a - b).sqr().sum());
        public static float fastdistance(float3 a, float3 b) => fastsqrt((a - b).sqr().sum());
        public static float fastdistance(float2 a, float2 b) => fastsqrt((a - b).sqr().sum());

        public static float fastlength(this float4 f) => fastsqrt(f.sqr().sum());
        public static float fastlength(this float3 f) => fastsqrt(f.sqr().sum());
        public static float fastlength(this float2 f) => fastsqrt(f.sqr().sum());
        
        public static float fastlength(this Vector4 f) => fastsqrt(f.sqr().sum());
        public static float fastlength(this Vector3 f) => fastsqrt(f.sqr().sum());
        public static float fastlength(this Vector2 f) => fastsqrt(f.sqr().sum());

        /// Low accuracy sqrt method for fast calculation.
        public static float fastsqrt(this float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.tmp = 0;
            u.f = z;
            u.tmp -= 1 << 23; // Subtract 2^m.
            u.tmp >>= 1; // Divide by 2.
            u.tmp += 1 << 29; // Add ((b + 1) / 2) * 2^m.
            return u.f;
        }
        

        /// Determine the signed angle between two vectors, with normal 'n' as the rotation axis.

        public static float AngleSigned(float3 f1, float3 f2, float3 n) => math.atan2(math.dot(n, math.cross(f1, f2)), math.dot(f1, f2)).degrees();
        public static double AngleSigned(double3 f1, double3 f2, double3 n) => math.atan2(math.dot(n, math.cross(f1, f2)), math.dot(f1, f2)).degrees();
        
        /// <summary>
        /// Sample a parabola trajectory
        /// </summary>
        /// <param name="start">Start position</param>
        /// <param name="end">End position</param>
        /// <param name="height">Height of the parabola</param>
        /// <param name="t">Time parameter to sample</param>
        /// <returns>The position in the parabola at time t</returns>
        public static float3 SampleParabola(float3 start, float3 end, float height, float t)
        {
            if ((start.y - end.y).abs() < 0.1f)
            {
                // Start and end are roughly level, pretend they are - simpler solution with less steps
                var travelDirection = end - start;
                var result = start + t * travelDirection;
                result.y += (t * math.PI).sin() * height;
                return result;
            } else {
                // Start and end are not level, gets more complicated
                var travelDirection = end - start;
                var levelDirection = end - new float3(start.x, end.y, start.z);
                var right = math.cross(travelDirection, levelDirection);
                var up = math.cross(right, travelDirection);
                if (end.y > start.y) up = -up;
                var result = start + t * travelDirection;
                result += (t * Mathf.PI).sin() * height * up.normalized();
                return result;
            }
        }

        public const float TAU = 6.28318530717959f;
        public const double TAU_DBL = 6.283185307179586477;
        public const float PHI = 1.61803398875f;
        public const double PHI_DBL = 1.6180339887498948482;
        public const float PINFINITY = float.PositiveInfinity;
        public const float NINFINITY = float.NegativeInfinity;
        public const double PINFINITY_DBL = double.PositiveInfinity;
        public const double NINFINITY_DBL = double.NegativeInfinity;

        //TODO: cosec, cotan, and other trig functions
        
        // doing

        // https://github.com/FreyaHolmer/Mathfs/blob/master/Mathfs.cs
        
        public static float smootherstep(this float f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float smoothstepcos(this float f) => - (f * math.PI).cos() * 0.5f + 0.5f;
        public static float eerp(this float f, float a, float b) => a.pow(1 - f) * b.pow(f);
        public static float uneerp(this float f, float a, float b) => (a / f).ln() / (a / b).ln();

        public static float SmoothDamp( float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed ) {
            float deltaTime = Time.deltaTime;
            return SmoothDamp( current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime );
        }

        public static float SmoothDamp( float current, float target, ref float currentVelocity, float smoothTime ) 
        {
            return SmoothDamp( current, target, ref currentVelocity, smoothTime, float.PositiveInfinity, Time.deltaTime );
        }
        
        // From Game Programming Gems 4 Chapter 1.10
        public static float SmoothDamp( float current, float target, ref float currentVelocity, float smoothTime, [Uei.DefaultValue( "Mathf.Infinity" )] float maxSpeed, [Uei.DefaultValue( "Time.deltaTime" )] float deltaTime ) {
            
            smoothTime = smoothTime.max(0.0001f);
            var omega = 2F / smoothTime;

            var x = omega * deltaTime;
            var exp = (1 + x + 0.48f * x.sqr() + 0.235f * x.cube()).rcp();
            var change = current - target;
            var originalTo = target;

            // Clamp maximum speed
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(- maxChange, maxChange);
            target = current - change;

            var temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            var output = target + (change + temp) * exp;

            // Prevent overshooting
            if (originalTo - current > 0 != output > originalTo) return output;
            output = originalTo;
            currentVelocity = ( output - originalTo ) / deltaTime;

            return output;
        }

    }
}