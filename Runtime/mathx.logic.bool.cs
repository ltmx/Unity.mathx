#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Logic ----------------------------------------------------

        /// returns true if any of the components is true
        public static bool any(this bool4 s) => s.x || s.y || s.z || s.w;
        /// returns true in all components are true
        public static bool all(this bool4 s) => s is { x: true, y: true, z: true, w: true };
        
        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool3 s) => s.x || s.y || s.z;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool3 s) => s is { x: true, y: true, z: true };

        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool2 s) => s.x || s.y;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool2 s) => s is { x: true, y: true };
        


        // Select ---------------------------------------------------
        
        /// Returns a component-wise selection of a or b using s (selector)
        public static float4 select(this bool4 s, float4 a, float4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        public static float3 select(this bool3 s, float3 a, float3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        public static float2 select(this bool2 s, float2 a, float2 b) => math.select(b, a, s);
        

        // Approx ---------------------------------------------------
        
        /// Compares two floating point values and returns true if they are similar.
        public static bool approx(this float a, float b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        /// Compares two floating point values and returns true if they are similar.
        public static bool approx(this double a, double b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        
        // Odd & Even ----------------------------------------------
        
        /// Returns true if a is odd
        public static bool odd(this int a) => (a & 1) != 0; // 12% faster than a % 2 == 1
        /// Returns true if a is odd component-wise
        public static bool2 odd(this int2 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool3 odd(this int3 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool4 odd(this int4 a) => (a & 1) != 0;
        
        /// Returns true if a is even
        public static bool even(this int a) => (a & 1) != 1; // 12% faster than a % 2 == 0
        /// Returns true if a is even component-wise
        public static bool2 even(this int2 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool3 even(this int3 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool4 even(this int4 a) => (a & 1) != 1;
    }
}

