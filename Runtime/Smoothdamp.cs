using Unity.Mathematics;
using UnityEngine;

namespace Plugins.Mathematics_Extensions.Runtime
{
    public static partial class UME
    {
        // https://github.com/FreyaHolmer/Mathfs/blob/master/Mathfs.cs

        // SmoothDamp ------------------------------------------------------------------------------------------------
        public static float4 smoothdamp(float4 current, float4 target, ref float4 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity)
        {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float3 smoothdamp(float3 current, float3 target, ref float3 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity)
        {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float2 smoothdamp(float2 current, float2 target, ref float2 currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity)
        {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }

        public static float smoothdamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed = float.PositiveInfinity)
        {
            return smoothdamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
        }


        // From Game Programming Gems 4 Chapter 1.10
        public static float4 smoothdamp(float4 current, float4 target, ref float4 currentVelocity, float smoothTime,
            [System.ComponentModel.DefaultValue("Mathf.Infinity")] float maxSpeed, [System.ComponentModel.DefaultValue("Time.deltaTime")] float deltaTime)
        {
            smoothTime = smoothTime.max(0.0001f);
            var omega = 2 / smoothTime;

            var x = omega * deltaTime;
            var exp = (x * (1 + x * (0.48f + x * 0.235f))).rcp();
            var change = current - target;
            var originalTo = target;

            // Clamp maximum speed
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);
            // var num9 = change.sqr().sum();
            // if (num9 > maxChange.sqr()) change /= num9.sqrt() * maxChange;
            target = current - change;

            var temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            var output = target + (change + temp) * exp;

            var num14 = originalTo - current.x;
            var num17 = output - originalTo;

            if ((num14 * num17).sum() <= 0) return output;

            output = originalTo;
            currentVelocity = (output - originalTo.x) / deltaTime;
            return output;
        }

        public static float smoothdamp(float current, float target, ref float currentVelocity, float smoothTime,
            [UnityEngine.Internal.DefaultValueAttribute("Mathf.Infinity")]
            float maxSpeed, [UnityEngine.Internal.DefaultValueAttribute("Time.deltaTime")]
            float deltaTime)
        {
            smoothTime = smoothTime.max(0.0001f);
            var omega = 2 / smoothTime;

            var x = omega * deltaTime;
            var exp = (x * (1 + x * (0.48f + x * 0.235f))).rcp();
            var change = current - target;
            var originalTo = target;

            // Clamp maximum speed
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);
            target = current - change;

            var temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            var output = target + (change + temp) * exp;

            // Prevent overshooting
            if (originalTo - current > 0 != output > originalTo) return output;
            output = originalTo;
            currentVelocity = (output - originalTo) / deltaTime;

            return output;
        }


        public static float3 smoothdamp(float3 current, float3 target, ref float3 currentVelocity, float smoothTime,
            [System.ComponentModel.DefaultValue("Mathf.Infinity")] float maxSpeed, [System.ComponentModel.DefaultValue("Time.deltaTime")] float deltaTime)
        {
            smoothTime = smoothTime.max(0.0001f);
            var omega = 2 / smoothTime;

            var x = omega * deltaTime;
            var exp = (x * (1 + x * (0.48f + x * 0.235f))).rcp();
            var change = current - target;
            var originalTo = target;

            // Clamp maximum speed
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);
            target = current - change;

            var temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            var output = target + (change + temp) * exp;

            var num14 = originalTo - current.x;
            var num17 = output - originalTo;

            if ((num14 * num17).sum() <= 0) return output;

            output = originalTo;
            currentVelocity = (output - originalTo.x) / deltaTime;
            return output;
        }

        public static float2 smoothdamp(float2 current, float2 target, ref float2 currentVelocity, float smoothTime,
            [System.ComponentModel.DefaultValue("Mathf.Infinity")] float maxSpeed, [System.ComponentModel.DefaultValue("Time.deltaTime")] float deltaTime)
        {
            smoothTime = smoothTime.max(0.0001f);
            var omega = 2 / smoothTime;

            var x = omega * deltaTime;
            var exp = (x * (1 + x * (0.48f + x * 0.235f))).rcp();
            var change = current - target;
            var originalTo = target;

            // Clamp maximum speed
            var maxChange = maxSpeed * smoothTime;
            change = change.clamp(-maxChange, maxChange);
            target = current - change;

            var temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            var output = target + (change + temp) * exp;

            var num14 = originalTo - current.x;
            var num17 = output - originalTo;

            if ((num14 * num17).sum() <= 0) return output;

            output = originalTo;
            currentVelocity = (output - originalTo.x) / deltaTime;
            return output;
        }
    }
}