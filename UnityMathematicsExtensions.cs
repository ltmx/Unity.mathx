/**************************************************************************************
**
**    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
**    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
** 
***************************************************************************************/

//https://github.com/LTMX/Unity-Mathematics-Extensions

using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public static class UnityMathematicsExtensions
{
    
    // Vector Specific Functions ------------------------------------------------------

    // Normalized
    public static float4 normalized(this float4 f) => math.normalize(f);
    public static float3 normalized(this float3 f) => math.normalize(f);
    public static float2 normalized(this float2 f) => math.normalize(f);
    
    public static float4 normalized(this Vector4 f) => math.normalize(f);
    public static float3 normalized(this Vector3 f) => math.normalize(f);
    public static float2 normalized(this Vector2 f) => math.normalize(f);
    
    
    //length
    public static float length(this float4 f) => math.length(f);
    public static float length(this float3 f) => math.length(f);
    public static float length(this float2 f) => math.length(f);
    
    public static float length(this Vector4 f) => math.length(f);
    public static float length(this Vector3 f) => math.length(f);
    public static float length(this Vector2 f) => math.length(f);
    
    public static float haha => new Vector3().length();
    
    
    //Length Squared
    public static float lengthsq(this float4 f) => math.lengthsq(f);
    public static float lengthsq(this float3 f) => math.lengthsq(f);
    public static float lengthsq(this float2 f) => math.lengthsq(f);
    
    public static float lengthsq(this Vector4 f) => math.lengthsq(f);
    public static float lengthsq(this Vector3 f) => math.lengthsq(f);
    public static float lengthsq(this Vector2 f) => math.lengthsq(f);


    //Saturate
    public static float4 saturate(this float4 f) => math.saturate(f);
    public static float3 saturate(this float3 f) => math.saturate(f);
    public static float2 saturate(this float2 f) => math.saturate(f);
    public static float saturate(this float f) => math.saturate(f);
    
    public static float4 saturate(this Vector4 f) => math.saturate(f);
    public static float3 saturate(this Vector3 f) => math.saturate(f);
    public static float2 saturate(this Vector2 f) => math.saturate(f);
    
    
    // Square Root
    public static float4 sqrt(this float4 f) => math.sqrt(f);
    public static float3 sqrt(this float3 f) => math.sqrt(f);
    public static float2 sqrt(this float2 f) => math.sqrt(f);
    public static float sqrt(this float f) => math.sqrt(f);
    public static float sqrt(this int f) => math.sqrt(f);
    
    public static float4 sqrt(this Vector4 f) => math.sqrt(f);
    public static float3 sqrt(this Vector3 f) => math.sqrt(f);
    public static float2 sqrt(this Vector2 f) => math.sqrt(f);
    
    
    // Reverse Square Root
    public static float4 rsqrt(this float4 f) => math.rsqrt(f);
    public static float3 rsqrt(this float3 f) => math.rsqrt(f);
    public static float2 rsqrt(this float2 f) => math.rsqrt(f);
    public static float rsqrt(this float f) => math.rsqrt(f);
    public static float rsqrt(this int f) => math.rsqrt(f);
    
    public static float4 rsqrt(this Vector4 f) => math.rsqrt(f);
    public static float3 rsqrt(this Vector3 f) => math.rsqrt(f);
    public static float2 rsqrt(this Vector2 f) => math.rsqrt(f);


    //Math Operations From Matrices ----------------------------------------------------------------------------
    public static float distance(this float2x2 f) => math.distance(f.c0, f.c1);
    public static float distance(this float3x2 f) => math.distance(f.c0, f.c1);
    public static float distance(this float4x2 f) => math.distance(f.c0, f.c1);
    
    public static float distancesq(this float2x2 f) => math.distancesq(f.c0, f.c1);
    public static float distancesq(this float3x2 f) => math.distancesq(f.c0, f.c1);
    public static float distancesq(this float4x2 f) => math.distancesq(f.c0, f.c1);

    public static float3 cross(this float3x2 f) => math.cross(f.c0, f.c1);
    public static double3 cross(this double3x2 f) => math.cross(f.c0, f.c1);

    public static float dot(this float4x2 f) => math.dot(f.c0, f.c1);
    public static float dot(this float3x2 f) => math.dot(f.c0, f.c1);
    public static float dot(this float2x2 f) => math.dot(f.c0, f.c1);


    
    
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
    
    // Sine
    public static float4 sin(this float4 f) => math.sin(f);
    public static float3 sin(this float3 f) => math.sin(f);
    public static float2 sin(this float2 f) => math.sin(f);
    public static float sin(this float f) => math.sin(f);
    public static float sin(this int f) => math.sin(f);
    
    public static float4 sin(this Vector4 f) => math.sin(f);
    public static float3 sin(this Vector3 f) => math.sin(f);
    public static float2 sin(this Vector2 f) => math.sin(f);
    
    // Tangent
    public static float4 tan(this float4 f) => math.tan(f);
    public static float3 tan(this float3 f) => math.tan(f);
    public static float2 tan(this float2 f) => math.tan(f);
    public static float tan(this float f) => math.tan(f);
    public static float tan(this int f) => math.tan(f);
    
    public static float4 tan(this Vector4 f) => math.tan(f);
    public static float3 tan(this Vector3 f) => math.tan(f);
    public static float2 tan(this Vector2 f) => math.tan(f);
    
    
    // Hyperbolic Cosine
    public static float4 cosh(this float4 f) => math.cosh(f);
    public static float3 cosh(this float3 f) => math.cosh(f);
    public static float2 cosh(this float2 f) => math.cosh(f);
    public static float cosh(this float f) => math.cosh(f);
    public static float cosh(this int f) => math.cosh(f);
    
    public static float4 cosh(this Vector4 f) => math.cosh(f);
    public static float3 cosh(this Vector3 f) => math.cosh(f);
    public static float2 cosh(this Vector2 f) => math.cosh(f);
    
    
    // Hyperbolic Sine
    public static float4 sinh(this float4 f) => math.sinh(f);
    public static float3 sinh(this float3 f) => math.sinh(f);
    public static float2 sinh(this float2 f) => math.sinh(f);
    public static float sinh(this float f) => math.sinh(f);
    public static float sinh(this int f) => math.sinh(f);
    
    public static float4 sinh(this Vector4 f) => math.sinh(f);
    public static float3 sinh(this Vector3 f) => math.sinh(f);
    public static float2 sinh(this Vector2 f) => math.sinh(f);
    
    // Hyperbolic Tangent
    public static float4 tanh(this float4 f) => math.tanh(f);
    public static float3 tanh(this float3 f) => math.tanh(f);
    public static float2 tanh(this float2 f) => math.tanh(f);
    public static float tanh(this float f) => math.tanh(f);
    public static float tanh(this int f) => math.tanh(f);
    
    public static float4 tanh(this Vector4 f) => math.tanh(f);
    public static float3 tanh(this Vector3 f) => math.tanh(f);
    public static float2 tanh(this Vector2 f) => math.tanh(f);
    
    // Arccosine
    public static float4 acos(this float4 f) => math.acos(f);
    public static float3 acos(this float3 f) => math.acos(f);
    public static float2 acos(this float2 f) => math.acos(f);
    public static float acos(this float f) => math.acos(f);
    public static float acos(this int f) => math.acos(f);
    
    public static float4 acos(this Vector4 f) => math.acos(f);
    public static float3 acos(this Vector3 f) => math.acos(f);
    public static float2 acos(this Vector2 f) => math.acos(f);
    
    // Arcsine
    public static float4 asin(this float4 f) => math.asin(f);
    public static float3 asin(this float3 f) => math.asin(f);
    public static float2 asin(this float2 f) => math.asin(f);
    public static float asin(this float f) => math.asin(f);
    public static float asin(this int f) => math.asin(f);
    
    public static float4 asin(this Vector4 f) => math.asin(f);
    public static float3 asin(this Vector3 f) => math.asin(f);
    public static float2 asin(this Vector2 f) => math.asin(f);
    
    // Arctangent
    public static float4 atan(this float4 f) => math.atan(f);
    public static float3 atan(this float3 f) => math.atan(f);
    public static float2 atan(this float2 f) => math.atan(f);
    public static float atan(this float f) => math.atan(f);
    public static float atan(this int f) => math.atan(f);
    
    public static float4 atan(this Vector4 f) => math.atan(f);
    public static float3 atan(this Vector3 f) => math.atan(f);
    public static float2 atan(this Vector2 f) => math.atan(f);
    
    // Secant
    public static float4 sec(this float4 f) => f.cosh().rcp();
    public static float3 sec(this float3 f) => f.cosh().rcp();
    public static float2 sec(this float2 f) => f.cosh().rcp();
    public static float sec(this float f) => f.cosh().rcp();
    public static float sec(this int f) => f.cosh().rcp();
    
    public static float4 sec(this Vector4 f) => f.cosh().rcp();
    public static float3 sec(this Vector3 f) => f.cosh().rcp();
    public static float2 sec(this Vector2 f) => f.cosh().rcp();
    
    // Secant²
    public static float4 sec2(this float4 f) => f.cosh().sqr().rcp();
    public static float3 sec2(this float3 f) => f.cosh().sqr().rcp();
    public static float2 sec2(this float2 f) => f.cosh().sqr().rcp();
    public static float sec2(this float f) => f.cosh().sqr().rcp();
    public static float sec2(this int f) => f.cosh().sqr().rcp();
    
    public static float4 sec2(this Vector4 f) => f.cosh().sqr().rcp();
    public static float3 sec2(this Vector3 f) => f.cosh().sqr().rcp();
    public static float2 sec2(this Vector2 f) => f.cosh().sqr().rcp();

    
    // Cosine²
    public static float4 cos2(this float4 f) => (1 + f.cos()) / 2;
    public static float3 cos2(this float3 f) => (1 + f.cos()) / 2;
    public static float2 cos2(this float2 f) => (1 + f.cos()) / 2;
    public static float cos2(this float f) => (1 + f.cos()) / 2;
    public static float cos2(this int f) => (1 + f.cos()) / 2;
    
    public static float4 cos2(this Vector4 f) => (1 + f.cos()) / 2;
    public static float3 cos2(this Vector3 f) => (1 + f.cos()) / 2;
    public static float2 cos2(this Vector2 f) => (1 + f.cos()) / 2;
    
    // Sine²
    public static float4 sin2(this float4 f) => (1 - f.cos()) / 2;
    public static float3 sin2(this float3 f) => (1 - f.cos()) / 2;
    public static float2 sin2(this float2 f) => (1 - f.cos()) / 2;
    public static float sin2(this float f) => (1 - f.cos()) / 2;
    public static float sin2(this int f) => (1 - f.cos()) / 2;
    
    public static float4 sin2(this Vector4 f) => (1 - f.cos()) / 2;
    public static float3 sin2(this Vector3 f) => (1 - f.cos()) / 2;
    public static float2 sin2(this Vector2 f) => (1 - f.cos()) / 2;

    // Tangent²
    public static float4 tan2(this float4 f) => f.sec2() - 1;
    public static float3 tan2(this float3 f) => f.sec2() - 1;
    public static float2 tan2(this float2 f) => f.sec2() - 1;
    public static float tan2(this float f) => f.sec2() - 1;
    public static float tan2(this int f) => f.sec2() - 1;
    
    public static float4 tan2(this Vector4 f) => f.sec2() - 1;
    public static float3 tan2(this Vector3 f) => f.sec2() - 1;
    public static float2 tan2(this Vector2 f) => f.sec2() - 1;
    
    // Degrees
    public static float4 degrees(this float4 f) => math.degrees(f);
    public static float3 degrees(this float3 f) => math.degrees(f);
    public static float2 degrees(this float2 f) => math.degrees(f);
    public static float degrees(this float f) => math.degrees(f);
    public static float degrees(this int f) => math.degrees(f);
    
    public static float4 degrees(this Vector4 f) => math.degrees(f);
    public static float3 degrees(this Vector3 f) => math.degrees(f);
    public static float2 degrees(this Vector2 f) => math.degrees(f);
    
    // Radians
    public static float4 radians(this float4 f) => math.radians(f);
    public static float3 radians(this float3 f) => math.radians(f);
    public static float2 radians(this float2 f) => math.radians(f);
    public static float radians(this float f) => math.radians(f);
    public static float radians(this int f) => math.radians(f);
    
    public static float4 radians(this Vector4 f) => math.radians(f);
    public static float3 radians(this Vector3 f) => math.radians(f);
    public static float2 radians(this Vector2 f) => math.radians(f);
    
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
    
    
    
    // Rounding Values ----------------------------------------------------
    public static float4 ceil(this float4 f) => math.ceil(f);
    public static float3 ceil(this float3 f) => math.ceil(f);
    public static float2 ceil(this float2 f) => math.ceil(f);
    public static float ceil(this float f) => math.ceil(f);
    public static int ceil(this int f) => (int)math.ceil(f);
    
    public static float4 ceil(this Vector4 f) => math.ceil(f);
    public static float3 ceil(this Vector3 f) => math.ceil(f);
    public static float2 ceil(this Vector2 f) => math.ceil(f);
    
    // Floor
    public static float4 floor(this float4 f) => math.floor(f);
    public static float3 floor(this float3 f) => math.floor(f);
    public static float2 floor(this float2 f) => math.floor(f);
    public static float floor(this float f) => math.floor(f);
    public static int floor(this int f) => (int)math.floor(f);
    
    public static float4 floor(this Vector4 f) => math.floor(f);
    public static float3 floor(this Vector3 f) => math.floor(f);
    public static float2 floor(this Vector2 f) => math.floor(f);
    
    
    // Fractional Remainder
    public static float4 frac(this float4 f) => math.frac(f);
    public static float3 frac(this float3 f) => math.frac(f);
    public static float2 frac(this float2 f) => math.frac(f);
    public static float frac(this float f) => math.frac(f);
    
    public static float4 frac(this Vector4 f) => math.frac(f);
    public static float3 frac(this Vector3 f) => math.frac(f);
    public static float2 frac(this Vector2 f) => math.frac(f);
    
    // Round
    public static float4 round(this float4 f) => math.round(f);
    public static float3 round(this float3 f) => math.round(f);
    public static float2 round(this float2 f) => math.round(f);
    public static float round(this float f) => math.round(f);
    
    public static float4 round(this Vector4 f) => math.round(f);
    public static float3 round(this Vector3 f) => math.round(f);
    public static float2 round(this Vector2 f) => math.round(f);
    
    // Sign
    public static float4 sign(this float4 f) => math.sign(f);
    public static float3 sign(this float3 f) => math.sign(f);
    public static float2 sign(this float2 f) => math.sign(f);
    public static float sign(this float f) => math.sign(f);
    public static int sign(this int f) => (int)math.sign(f);
    
    public static float4 sign(this Vector4 f) => math.sign(f);
    public static float3 sign(this Vector3 f) => math.sign(f);
    public static float2 sign(this Vector2 f) => math.sign(f);
    
    // Absolute Value -------------------------------------------------------------------------------
    public static float4 abs(this float4 f) => math.abs(f);
    public static float3 abs(this float3 f) => math.abs(f);
    public static float2 abs(this float2 f) => math.abs(f);
    public static float abs(this float f) => math.abs(f);
    public static int abs(this int f) => math.abs(f);
    
    public static float4 abs(this Vector4 f) => math.abs(f);
    public static float3 abs(this Vector3 f) => math.abs(f);
    public static float2 abs(this Vector2 f) => math.abs(f);
    
    
    // Component-wise Sum --------------------------------------------------------------------------
    public static float sum(this float4 f) => math.csum(f);
    public static float sum(this float3 f) => math.csum(f);
    public static float sum(this float2 f) => math.csum(f);
    
    public static float sum(this Vector4 f) => math.csum(f);
    public static float sum(this Vector3 f) => math.csum(f);
    public static float sum(this Vector2 f) => math.csum(f);
    
    public static int sum(this int4 f) => math.csum(f);
    public static int sum(this int3 f) => math.csum(f);
    public static int sum(this int2 f) => math.csum(f);
    
    
    // Reciprocal ---------------------------------------------------------------------------------
    public static float4 rcp(this float4 f) => math.rcp(f);
    public static float3 rcp(this float3 f) => math.rcp(f);
    public static float2 rcp(this float2 f) => math.rcp(f);
    public static float rcp(this float f) => math.rcp(f);
    public static float rcp(this int f) => math.rcp(f);
    
    public static float4 rcp(this Vector4 f) => math.rcp(f);
    public static float3 rcp(this Vector3 f) => math.rcp(f);
    public static float2 rcp(this Vector2 f) => math.rcp(f);




    // Clamp ---------------------------------------------------------------------------------------
    
    // Clamp to floats
    public static float4 clamp(this float4 f, float min, float max) => math.clamp(f, min, max);
    public static float3 clamp(this float3 f, float min, float max) => math.clamp(f, min, max);
    public static float2 clamp(this float2 f, float min, float max) => math.clamp(f, min, max);
    public static float clamp(this int f, float min, float max) => math.clamp(f, min, max);
    
    // Clamp UnityEngine Vectors to floats
    public static float4 clamp(this Vector4 f, float min, float max) => math.clamp(f, min, max);
    public static float3 clamp(this Vector3 f, float min, float max) => math.clamp(f, min, max);
    public static float2 clamp(this Vector2 f, float min, float max) => math.clamp(f, min, max);

    // Clamp to integers
    public static float4 clamp(this Vector4 f, int min, int max) => math.clamp(f, min, max);
    public static float3 clamp(this Vector3 f, int min, int max) => math.clamp(f, min, max);
    public static float2 clamp(this Vector2 f, int min, int max) => math.clamp(f, min, max);

    // clamp to same data types
    public static float4 clamp(this float4 f, float4 min, float4 max) => math.clamp(f, min, max);
    public static float3 clamp(this float3 f, float3 min, float3 max) => math.clamp(f, min, max);
    public static float2 clamp(this float2 f, float2 min, float2 max) => math.clamp(f, min, max);
    public static float clamp(this float f, float min, float max) => math.clamp(f, min, max);

    // Clamp UnityEngine Vectors to equivalent Unity.Mathematics type
    public static float4 clamp(this Vector4 f, float4 min, float4 max) => math.clamp(f, min, max);
    public static float3 clamp(this Vector3 f, float3 min, float3 max) => math.clamp(f, min, max);
    public static float2 clamp(this Vector2 f, float2 min, float2 max) => math.clamp(f, min, max);
    
    
    // Minimum ------------------------------------------------------------------------------------
    public static float4 min(this float4 f, float min) => math.min(f, min);
    public static float3 min(this float3 f, float min) => math.min(f, min);
    public static float2 min(this float2 f, float min) => math.min(f, min);
    public static float min(this float f, float min) => math.min(f, min);
    public static float min(this int f, float min) => math.min(f, min);
    
    public static float4 min(this Vector4 f, float min) => math.min(f, min);
    public static float3 min(this Vector3 f, float min) => math.min(f, min);
    public static float2 min(this Vector2 f, float min) => math.min(f, min);
    
    // Maximum ------------------------------------------------------------------------------------
    public static float4 max(this float4 f, float max) => math.max(f, max);
    public static float3 max(this float3 f, float max) => math.max(f, max);
    public static float2 max(this float2 f, float max) => math.max(f, max);
    public static float max(this float f, float max) => math.max(f, max);
    public static float max(this int f, float max) => math.max(f, max);
    
    public static float4 max(this Vector4 f, float max) => math.max(f, max);
    public static float3 max(this Vector3 f, float max) => math.max(f, max);
    public static float2 max(this Vector2 f, float max) => math.max(f, max);
    
    
    // Power ---------------------------------------------------------------------------------
    public static float4 pow(this float4 f, float pow) => math.pow(f, pow);
    public static float3 pow(this float3 f, float pow) => math.pow(f, pow);
    public static float2 pow(this float2 f, float pow) => math.pow(f, pow);
    
    public static float4 pow(this float4 f, float4 pow) => math.pow(f, pow);
    public static float3 pow(this float3 f, float3 pow) => math.pow(f, pow);
    public static float2 pow(this float2 f, float2 pow) => math.pow(f, pow);
    
    public static float pow(this float f, float pow) => math.pow(f, pow);
    public static int pow(this int f, int pow) => (int)math.pow(f, pow);
    public static float pow(this int f, float pow) => (int)math.pow(f, pow);

    public static float4 pow(this Vector4 f, float pow) => math.pow(f, pow);
    public static float3 pow(this Vector3 f, float pow) => math.pow(f, pow);
    public static float2 pow(this Vector2 f, float pow) => math.pow(f, pow);
    
    public static float4 pow(this Vector4 f, float4 pow) => math.pow(f, pow);
    public static float3 pow(this Vector3 f, float3 pow) => math.pow(f, pow);
    public static float2 pow(this Vector2 f, float2 pow) => math.pow(f, pow);

    // Square ---------------------------------------------------------------------------------
    public static float4 sqr(this float4 f) => f * f;
    public static float3 sqr(this float3 f) => f * f;
    public static float2 sqr(this float2 f) => f * f;
    public static float sqr(this float f) => f * f;
    public static int sqr(this int f) => f * f;
    
    public static float4 sqr(this Vector4 f) => f.asfloat() * f;
    public static float3 sqr(this Vector3 f) => f.asfloat() * f;
    public static float2 sqr(this Vector2 f) => f * f;
    
    // Exponential ----------------------------------------------------------------------------
    public static float4 exp(this float4 f) => math.exp(f);
    public static float3 exp(this float3 f) => math.exp(f);
    public static float2 exp(this float2 f) => math.exp(f);
    public static float exp(this float f) => math.exp(f);
    public static float exp(this int f) => math.exp(f);
    
    public static float4 exp(this Vector4 f) => math.exp(f);
    public static float3 exp(this Vector3 f) => math.exp(f);
    public static float2 exp(this Vector2 f) => math.exp(f);
    
    // Exponential Base 2
    public static float4 exp2(this float4 f) => math.exp2(f);
    public static float3 exp2(this float3 f) => math.exp2(f);
    public static float2 exp2(this float2 f) => math.exp2(f);
    public static float exp2(this float f) => math.exp2(f);
    public static float exp2(this int f) => math.exp2(f);
    
    public static float4 exp2(this Vector4 f) => math.exp2(f);
    public static float3 exp2(this Vector3 f) => math.exp2(f);
    public static float2 exp2(this Vector2 f) => math.exp2(f);
    
    // Exponential Base 10
    public static float4 exp10(this float4 f) => math.exp10(f);
    public static float3 exp10(this float3 f) => math.exp10(f);
    public static float2 exp10(this float2 f) => math.exp10(f);
    public static float exp10(this float f) => math.exp10(f);
    public static float exp10(this int f) => math.exp10(f);
    
    public static float4 exp10(this Vector4 f) => math.exp10(f);
    public static float3 exp10(this Vector3 f) => math.exp10(f);
    public static float2 exp10(this Vector2 f) => math.exp10(f);

    // Log ------------------------------------------------------------------------------------
    public static float4 log(this float4 f) => math.log(f);
    public static float3 log(this float3 f) => math.log(f);
    public static float2 log(this float2 f) => math.log(f);
    public static float log(this float f) => math.log(f);
    public static float log(this int f) => math.log(f);
    
    public static float4 log(this Vector4 f) => math.log(f);
    public static float3 log(this Vector3 f) => math.log(f);
    public static float2 log(this Vector2 f) => math.log(f);
    
    // Log Base 2
    public static float4 log2(this float4 f) => math.log2(f);
    public static float3 log2(this float3 f) => math.log2(f);
    public static float2 log2(this float2 f) => math.log2(f);
    public static float log2(this float f) => math.log2(f);
    public static float log2(this int f) => math.log2(f);
    
    public static float4 log2(this Vector4 f) => math.log2(f);
    public static float3 log2(this Vector3 f) => math.log2(f);
    public static float2 log2(this Vector2 f) => math.log2(f);
    
    // Log Base 10
    public static float4 log10(this float4 f) => math.log10(f);
    public static float3 log10(this float3 f) => math.log10(f);
    public static float2 log10(this float2 f) => math.log10(f);
    public static float log10(this float f) => math.log10(f);
    public static float log10(this int f) => math.log10(f);
    
    public static float4 log10(this Vector4 f) => math.log10(f);
    public static float3 log10(this Vector3 f) => math.log10(f);
    public static float2 log10(this Vector2 f) => math.log10(f);
    
    
    // SmoothStep -----------------------------------------------------------------------------
    
    /// Interpolate smoothly between min and max based on the input value 
    public static float4 smoothstep(this float4 f, float min, float max) {
        var a = ((f - min) / (max - min)).saturate();
        return a * a * (3 - 2 * a);
    }
    /// Interpolate smoothly between min and max based on the input value 
    public static float3 smoothstep(this float3 f, float min, float max) {
        var a = ((f - min) / (max - min)).saturate();
        return a * a * (3 - 2 * a);
    }
    /// Interpolate smoothly between min and max based on the input value 
    public static float2 smoothstep(this float2 f, float min, float max) {
        var a = ((f - min) / (max - min)).saturate();
        return a * a * (3 - 2 * a);
    }
    /// Interpolate smoothly between min and max based on the input value 
    public static float smoothstep(this float f, float min, float max) {
        var a = ((f - min) / (max - min)).saturate();
        return a * a * (3 - 2 * a);
    }

    // Component-wise comparison --------------------------------------------------------------

    public static float cmax(this float4 f) => math.cmax(f);
    public static float cmax(this float3 f) => math.cmax(f);
    public static float cmax(this float2 f) => math.cmax(f);

    public static float cmin(this float4 f) => math.cmin(f);
    public static float cmin(this float3 f) => math.cmin(f);
    public static float cmin(this float2 f) => math.cmin(f);
    
    
    
    /// Returns 1 inside the longest(s) axis(es) and 0 in the others
    public static bool4 cmaxAxis(this float4 f) {
        var m = f.cmax();
        return new bool4(f.x == m, f.y == m,f.z == m,f.w == m);
    }
    /// Returns 1 inside the longest(s) axis(es) and 0 in the others
    public static bool3 cmaxAxis(this float3 f) {
        var m = f.cmax();
        return new bool3(f.x == m, f.y == m,f.z == m);
    }
    /// Returns 1 inside the longest(s) axis(es) and 0 in the others
    public static bool2 cmaxAxis(this float2 f) {
        var m = f.cmax();
        return new bool2(f.x == m, f.y == m);
    }
    
    /// Returns true inside the shortest axes
    public static bool4 cminAxis(this float4 f) {
        var m = f.cmin();
        return new bool4(f.x == m, f.y == m,f.z == m,f.w == m);
    }
    /// Returns true inside the shortest axes
    public static bool3 cminAxis(this float3 f) {
        var m = f.cmin();
        return new bool3(f.x == m, f.y == m,f.z == m);
    }
    /// Returns true inside the shortest axes
    public static bool2 cminAxis(this float2 f) {
        var m = f.cmin();
        return new bool2(f.x == m, f.y == m);
    }
    
    
    //Primitives -------------------------------------------------------------------------------------------------
    
    /// Shorthand for writing new float4(1,1,1,1)
    public static float4 float4one = new float4(1,1,1,1);
    
    /// Shorthand for writing new float4(0,0,0,0)
    public static float4 float4zero = new float4(0,0,0,0);


    /// Shorthand for writing new float2(1,1)
    public static float2 float2one = new float2(1,1);
    
    /// Shorthand for writing new float2(0,0)
    public static float2 float2zero = new float2(0,0);
    
    /// Shorthand for writing new float2(0,1)
    public static float2 float2up = new float2(0,1);
    
    /// Shorthand for writing new float2(0,1)
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
    
    // Type Conversion -----------------------------------------------------------------------------
    public static int4 asint(this float4 f) => math.asint(f);
    public static int3 asint(this float3 f) => math.asint(f);
    public static int2 asint(this float2 f) => math.asint(f);
    public static int asint(this float f) => math.asint(f);

    public static int4 asint(this Vector4 f) => math.asint(f);
    public static int3 asint(this Vector3 f) => math.asint(f);
    public static int2 asint(this Vector2 f) => math.asint(f);
    
    public static float4 asfloat(this int4 f) => math.asfloat(f);
    public static float3 asfloat(this int3 f) => math.asfloat(f);
    public static float2 asfloat(this int2 f) => math.asfloat(f);
    public static float asfloat(this int f) => math.asfloat(f);
    
    public static float4 asfloat(this Vector4 f) => f;
    public static float3 asfloat(this Vector3 f) => f;
    public static float2 asfloat(this Vector2 f) => f;
    
    public static int4 asint4(this bool4 b) => new int4(b.x.asint(), b.y.asint(), b.z.asint(), b.w.asint());
    public static int3 asint3(this bool3 b) => new int3(b.x.asint(), b.y.asint(), b.z.asint());
    public static int2 asint2(this bool2 b) => new int2(b.x.asint(), b.y.asint());
    public static int asint(this bool b) => b ? 1 : 0;
    
    public static float4 asfloat4(this bool4 b) => b.asint4();
    public static float3 asfoat3(this bool3 b) => b.asint3();
    public static float2 asfloat2(this bool2 b) => b.asint2();
    public static float asfloat(this bool b) => b.asint();
    
    
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

    public static Color ascolor(this float4 f) => new Color(f.x, f.y, f.z, f.w);
    public static Color ascolor(this float3 f) => new Color(f.x, f.y, f.z);
    public static Color ascolor(this float2 f) => new Color(f.x, f.y, 0);
    public static Color ascolor(this float f) => new Color(f,f,f);

    public static float4 asfloat4(this Color c) => new float4(c.r, c.g, c.b, c.a);
    public static float3 asfloat3(this Color c) => new float3(c.r, c.g, c.b);
    public static float2 asfloat2(this Color c) => new float2(c.r, c.g);
    
    
    //Specific Functions ------------------------------------------------------------------------------------------
    //Existing In UnityEngine Code, converted

    /// Loops the value t, so that it is never larger than length and never smaller than 0.
    public static float Repeat(float t, float length) => t - (t / length).floor() * length.clamp(0, length);
    
    /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
    public static float PingPong(float t, float length)
    {
        t = Repeat(t, length * 2);
        return length - (t - length).abs();
    }
    
}