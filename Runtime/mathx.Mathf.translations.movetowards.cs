#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

namespace Unity.Mathematics
{
    public partial class mathx
    {
        /// Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta
        public static float4 movetowards(this float4 current, float4 target, float4 maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta),maxDistanceDelta),sign(delta),current);
        }

        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float4)"/>
        public static float4 movetowards(this float4 current, float4 target, float maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta),maxDistanceDelta),sign(delta),current);
        }
        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
        public static float3 movetowards(this float3 current, float3 target, float3 maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta), maxDistanceDelta), sign(delta),current);
        }
        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
        public static float3 movetowards(this float3 current, float3 target, float maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta), maxDistanceDelta),sign(delta),current);
        }
        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
        public static float2 movetowards(this float2 current, float2 target, float2 maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta),maxDistanceDelta),sign(delta),current);
        }
        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
        public static float2 movetowards(this float2 current, float2 target, float maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta),maxDistanceDelta),sign(delta),current);
        }
        /// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
        public static float movetowards(this float current, float target, float maxDistanceDelta)
        {
            var delta = target - current;
            return math.mad(min(abs(delta),maxDistanceDelta),sign(delta),current);
        }
        
        // For Reference
        // float3 MoveTowards(float3 current, float3 target, float maxDistanceDelta)
        // {
        //     float3 delta = target - current;
        //     float invDeltaLength = math.rsqrt(math.lengthsq(delta)); // Reciprocal square root
        //     return current + (delta * invDeltaLength) * maxDistanceDelta;
        // }
    }
}