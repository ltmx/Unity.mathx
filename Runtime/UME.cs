/**************************************************************************************
**
**    Copyright (C) 2020 Nicolas Reinhard, @LTMX. All rights reserved.
**    // (C) 2020 Nicolas Reinhard https://github.com/LTMX
** 
***************************************************************************************/

//https://github.com/LTMX/Unity-Mathematics-Extensions

using Unity.Mathematics;
using UnityEngine;

namespace Plugins.Mathematics_Extensions.Runtime
{
    public static partial class UME
    {

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