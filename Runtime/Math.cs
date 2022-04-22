/**************************************************************************************
**
**    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
**    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
** 
***************************************************************************************/

//https://github.com/LTMX/Unity-Mathematics-Extensions

using System;
using System.ComponentModel;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        //Specific Functions ------------------------------------------------------------------------------------------
        //Existing In UnityEngine Code, converted

        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        // public static float repeat(this float t, float length) => (t - (t / length).floor() * length).clamp(0, length);
        // public static float repeat(this float x, float length) => ((x / length).frac() * length).clamp(0, length); // Refactored
        public static float repeat(this float x, float length) => (x % length).clamp(0, length); // is in fact a simple % operation
        public static float2 repeat(this float2 x, float2 length) => (x % length).clamp(0, length);
        public static float3 repeat(this float3 x, float3 length) => (x % length).clamp(0, length);
        public static float4 repeat(this float4 x, float4 length) => (x % length).clamp(0, length);
        public static float2 repeat(this float2 x, float length) => (x % length).clamp(0, length);
        public static float3 repeat(this float3 x, float length) => (x % length).clamp(0, length);
        public static float4 repeat(this float4 x, float length) => (x % length).clamp(0, length);

        public static double2 repeat(this double2 x, double2 length) => (x % length).clamp(0, length);
        public static double3 repeat(this double3 x, double3 length) => (x % length).clamp(0, length);
        public static double4 repeat(this double4 x, double4 length) => (x % length).clamp(0, length);

        public static double2 repeat(this double2 x, float length) => (x % length).clamp(0, length);
        public static double3 repeat(this double3 x, float length) => (x % length).clamp(0, length);
        public static double4 repeat(this double4 x, float length) => (x % length).clamp(0, length);

        /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
        public static float pingpong(float x, float length) {
            return length - (x.repeat(length * 2) - length).abs();
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
                result.y += (t * PI).sin() * height;
                return result;
            }
            else {
                // Start and end are not level, gets more complicated
                var travelDirection = end - start;
                var levelDirection = end - new float3(start.x, end.y, start.z);
                var right = travelDirection.cross(levelDirection);
                var up = right.cross(travelDirection);
                if (end.y > start.y) up = -up;
                var result = start + t * travelDirection;
                result += (t * PI).sin() * height * up.norm();
                return result;
            }
        }
        
        /// Compares two floating point values and returns true if they are similar.
        public static bool approx(this float a, float b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(math.EPSILON * 8);
        public static bool approx(this double a, double b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(math.EPSILON * 8);
        
        
        public static bool odd(this int a) => a % 2 == 1;
        public static bool2 odd(this int2 a) => a % 2 == 1;
        public static bool3 odd(this int3 a) => a % 2 == 1;
        public static bool4 odd(this int4 a) => a % 2 == 1;
        public static bool even(this int a) => a % 2 == 0;
        public static bool2 even(this int2 a) => a % 2 == 0;
        public static bool3 even(this int3 a) => a % 2 == 0;
        public static bool4 even(this int4 a) => a % 2 == 0;

    }
}