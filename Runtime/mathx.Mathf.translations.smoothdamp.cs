#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using Unity.Mathematics;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // https://github.com/FreyaHolmer/Mathfs/blob/master/Runtime/Mathfs.cs

        // SmoothDamp ------------------------------------------------------------------------------------------------
        public static float4 smoothdamp(float4 current, float4 target, ref float4 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity) {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float3 smoothdamp(float3 current, float3 target, ref float3 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity) {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float2 smoothdamp(float2 current, float2 target, ref float2 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity) {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float smoothdamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity) {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }
        

        public static float smoothdamp(float current, float target, ref float velocity, float smoothTime, 
            [System.ComponentModel.DefaultValue("float.PositiveInfinity")]float maxSpeed, 
            [System.ComponentModel.DefaultValue("Time.deltaTime")]float deltaTime)
        {
            smoothTime = 0.0001f.max(smoothTime);
            float omega = 2 / smoothTime;

            float x = omega * deltaTime;
            float exp = (x * (x * (0.48f + x * 0.235f) + 1 )).rcp();

            var change = current - target;
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);

            var temp = (velocity + omega * change) * deltaTime;
            velocity = (velocity - omega * temp) * exp;

            var result = current - change + (change + temp) * exp;

            if ((target - current) * (result - target) <= 0) return result;
            
            result = target;
            velocity = 0;

            return result;
        }

        public static float2 smoothdamp(float2 current, float2 target, ref float2 velocity, float smoothTime, 
            [System.ComponentModel.DefaultValue("float.PositiveInfinity")]float maxSpeed, 
            [System.ComponentModel.DefaultValue("Time.deltaTime")]float deltaTime)
        {
            smoothTime = 0.0001f.max(smoothTime);
            float omega = 2 / smoothTime;

            float x = omega * deltaTime;
            float exp = (x * (x * (0.48f + x * 0.235f) + 1 )).rcp();

            var change = current - target;
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);

            var temp = (velocity + omega * change) * deltaTime;
            velocity = (velocity - omega * temp) * exp;

            var result = current - change + (change + temp) * exp;

            if ((target - current).dot(result - target) <= 0) return result;
            
            result = target;
            velocity = 0;

            return result;
        }

        public static float3 smoothdamp(float3 current, float3 target, ref float3 velocity, float smoothTime, 
            [System.ComponentModel.DefaultValue("float.PositiveInfinity")]float maxSpeed, 
            [System.ComponentModel.DefaultValue("Time.deltaTime")]float deltaTime)
        {
            smoothTime = 0.0001f.max(smoothTime);
            float omega = 2 / smoothTime;

            float x = omega * deltaTime;
            float exp = (x * (x * (0.48f + x * 0.235f) + 1 )).rcp();

            var change = current - target;
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);

            var temp = (velocity + omega * change) * deltaTime;
            velocity = (velocity - omega * temp) * exp;

            var result = current - change + (change + temp) * exp;

            if ((target - current).dot(result - target) <= 0) return result;
            
            result = target;
            velocity = 0;

            return result;
        }
        
        public static float4 smoothdamp(float4 current, float4 target, ref float4 velocity, float smoothTime, 
            [System.ComponentModel.DefaultValue("float.PositiveInfinity")]float maxSpeed, 
            [System.ComponentModel.DefaultValue("Time.deltaTime")]float deltaTime)
        {
            smoothTime = 0.0001f.max(smoothTime);
            float omega = 2 / smoothTime;

            float x = omega * deltaTime;
            float exp = (x * (x * (0.48f + x * 0.235f) + 1 )).rcp();

            var change = current - target;
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);

            var temp = (velocity + omega * change) * deltaTime;
            velocity = (velocity - omega * temp) * exp;

            var result = current - change + (change + temp) * exp;

            if ((target - current).dot(result - target) <= 0) return result;
            
            result = target;
            velocity = 0;

            return result;
        }

    }
}