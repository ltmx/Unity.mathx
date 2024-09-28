#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{

    public static partial class mathx
    {
        #region pingpong
        /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
        [MI(IL)] public static float4 pingpong(float4 x, float4 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float4 pingpong(float4 x, float length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float3 pingpong(float3 x, float3 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float3 pingpong(float3 x, float length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float2 pingpong(float2 x, float2 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float2 pingpong(float2 x, float length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static float pingpong(float x, float length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double4 pingpong(double4 x, double4 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double4 pingpong(double4 x, double length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double3 pingpong(double3 x, double3 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double3 pingpong(double3 x, double length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double2 pingpong(double2 x, double2 length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double2 pingpong(double2 x, double length) => length - math.abs(x.repeat(length * 2) - length);
        [MI(IL)] public static double pingpong(double x, double length) => length - math.abs(x.repeat(length * 2) - length);

        // Pingpongs the value t between a and b
        [MI(IL)] public static float4 pingpong(float4 a, float4 b, float4 t) => a+pingpong(t,b-a);
        [MI(IL)] public static float4 pingpong(float4 a, float4 b, float t) => a+pingpong(t,b-a);
        [MI(IL)] public static float3 pingpong(float3 a, float3 b, float3 t) => a+pingpong(t,b-a);
        [MI(IL)] public static float3 pingpong(float3 a, float3 b, float t) => a+pingpong(t,b-a);
        [MI(IL)] public static float2 pingpong(float2 a, float2 b, float2 t) => a+pingpong(t,b-a);
        [MI(IL)] public static float2 pingpong(float2 a, float2 b, float t) => a+pingpong(t,b-a);
        [MI(IL)] public static float pingpong(float a, float b, float t) => a+pingpong(t,b-a);
        [MI(IL)] public static double4 pingpong(double4 a, double4 b, double4 t) => a+pingpong(t,b-a);
        [MI(IL)] public static double4 pingpong(double4 a, double4 b, double t) => a+pingpong(t,b-a);
        [MI(IL)] public static double3 pingpong(double3 a, double3 b, double3 t) => a+pingpong(t,b-a);
        [MI(IL)] public static double3 pingpong(double3 a, double3 b, double t) => a+pingpong(t,b-a);
        [MI(IL)] public static double2 pingpong(double2 a, double2 b, double2 t) => a+pingpong(t,b-a);
        [MI(IL)] public static double2 pingpong(double2 a, double2 b, double t) => a+pingpong(t,b-a);
        [MI(IL)] public static double pingpong(double a, double b, double t) => a+pingpong(t,b-a);
        #endregion
        

        /// Sample a parabola trajectory
        /// <param name="start">Start position</param>
        /// <param name="end">End position</param>
        /// <param name="height">Height of the parabola</param>
        /// <param name="t">Time parameter to sample</param>
        /// <returns>The position in the parabola at time t</returns>
        [MI(IL)] public static float3 SampleParabola(float3 start, float3 end, float height, float t)
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
    }
}