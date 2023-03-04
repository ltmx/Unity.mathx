// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    (C) 2023 Nicolas Reinhard https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions


namespace Unity.Mathematics
{
    /// <summary>Extension Library for Unity.Mathematics</summary>
    /// <permission>
    /// **    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
    /// **    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
    /// </permission>
    /// <remarks>See also : https://github.com/LTMX/Unity.Mathematics-Extensions</remarks>
    public static partial class mathx
    {
        //Specific Functions ------------------------------------------------------------------------------------------
        //Existing In UnityEngine Code, converted

        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        // public static float repeat(this float t, float length) => (t - (t / length).floor() * length).clamp(0, length);
        // public static float repeat(this float x, float length) => ((x / length).frac() * length).clamp(0, length); // Refactored
        public static float repeat(this float x, float length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float2 repeat(this float2 x, float2 length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float3 repeat(this float3 x, float3 length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float4 repeat(this float4 x, float4 length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float2 repeat(this float2 x, float length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float3 repeat(this float3 x, float length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float4 repeat(this float4 x, float length) =>  ((x / length).frac() * length).clamp(0, length);

        /// <inheritdoc cref="repeat(float,float)"/>
        public static double2 repeat(this double2 x, double2 length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double3 repeat(this double3 x, double3 length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double4 repeat(this double4 x, double4 length) =>  ((x / length).frac() * length).clamp(0, length);

        /// <inheritdoc cref="repeat(float,float)"/>
        public static double2 repeat(this double2 x, float length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double3 repeat(this double3 x, float length) =>  ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double4 repeat(this double4 x, float length) =>  ((x / length).frac() * length).clamp(0, length);

        /// PingPongs the value t, so that it is never larger than length and never smaller than 0.
        public static float pingpong(float x, float length) {
            return length - (x.repeat(length * 2) - length).abs();
        }

        /// Sample a parabola trajectory
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
    }
}