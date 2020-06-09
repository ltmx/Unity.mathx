/**************************************************************************************
**
**    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
**    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
** 
***************************************************************************************/

//https://github.com/LTMX/Unity-Mathematics-Extensions

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
        
        public static float cmul(this float4 f) => math.mul(f,f);
        public static float cmul(this float3 f) => math.mul(f,f);
        public static float cmul(this float2 f) => math.mul(f,f);

        public static float cmul(this Vector4 f) => math.mul(f,f);
        public static float cmul(this Vector3 f) => math.mul(f,f);
        public static float cmul(this Vector2 f) => math.mul(f,f);
        
        public static int cmul(this int4 f) => math.mul(f,f);
        public static int cmul(this int3 f) => math.mul(f,f);
        public static int cmul(this int2 f) => math.mul(f,f);
        
        public static double4 cmul(this double4 f) => math.mul(f,f);
        public static double3 cmul(this double3 f) => math.mul(f,f);
        public static double2 cmul(this double2 f) => math.mul(f,f);
        
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

    }
}