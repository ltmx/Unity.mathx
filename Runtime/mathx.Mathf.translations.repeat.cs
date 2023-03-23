#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        public static float repeat(this float x, float length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float2 repeat(this float2 x, float2 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float3 repeat(this float3 x, float3 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float4 repeat(this float4 x, float4 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float2 repeat(this float2 x, float length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float3 repeat(this float3 x, float length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static float4 repeat(this float4 x, float length) => ((x / length).frac() * length).clamp(0, length);
        
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double repeat(this double x, double length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double2 repeat(this double2 x, double2 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double3 repeat(this double3 x, double3 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double4 repeat(this double4 x, double4 length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double2 repeat(this double2 x, double length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double3 repeat(this double3 x, double length) => ((x / length).frac() * length).clamp(0, length);
        /// <inheritdoc cref="repeat(float,float)"/>
        public static double4 repeat(this double4 x, double length) => ((x / length).frac() * length).clamp(0, length);
    }
}