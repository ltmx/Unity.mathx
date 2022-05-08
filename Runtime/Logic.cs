using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        // logic ----------------------------------------------------

        /// returns true if any of the components is true
        public static bool any(this bool4 s) => s.x || s.y || s.z || s.w;
        /// returns true in all components are true
        public static bool all(this bool4 s) => s.x && s.y && s.z && s.w;
        
        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool3 s) => s.x || s.y || s.z;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool3 s) => s.x && s.y && s.z;

        /// <inheritdoc cref="any(bool4)"/>
        public static bool any(this bool2 s) => s.x || s.y;
        /// <inheritdoc cref="all(bool4)"/>
        public static bool all(this bool2 s) => s.x && s.y;
        
        // Select ---------------------------------------------------
        
        /// Returns a component-wise selection of a or b using s (selector)
        public static float4 select(this bool4 s, float4 a, float4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        public static float3 select(this bool3 s, float3 a, float3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        public static float2 select(this bool2 s, float2 a, float2 b) => math.select(b, a, s);
        
        
        /// Returns a if s is true, b otherwise
        public static T select<T>(this bool s, T a, T b) => s ? a : b;
        /// Returns a if s is true, b otherwise
        public static T select<T>(this int s, T a, T b) => s.asbool() ? a : b;
        
        
        /// Compares two floating point values and returns true if they are similar.
        public static bool approx(this float a, float b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        /// Compares two floating point values and returns true if they are similar.
        public static bool approx(this double a, double b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        
        
        /// Returns true if a is within the range [b, c]
        // a % 2 != 0; // odd
        // a % 2 == 0; // even
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool odd(this int a) => (a & 1) != 0; // 12% faster than % 2 == 1
        public static bool2 odd(this int2 a) => (a & 1) != 0;
        public static bool3 odd(this int3 a) => (a & 1) != 0;
        public static bool4 odd(this int4 a) => (a & 1) != 0;
        public static bool even(this int a) => (a & 1) != 1;
        public static bool2 even(this int2 a) => (a & 1) != 1;
        public static bool3 even(this int3 a) => (a & 1) != 1;
        public static bool4 even(this int4 a) => (a & 1) != 1;
        
        public static bool odd(this float a) => ((int)a & 1) != 0;
        public static bool2 odd(this float2 a) => ((int2)a & 1) != 0;
        public static bool3 odd(this float3 a) => ((int3)a & 1) != 0;
        public static bool4 odd(this float4 a) => ((int4)a & 1) != 0;
        
        public static bool even(this float a) => ((int)a & 1) != 1;
        public static bool2 even(this float2 a) => ((int2)a & 1) != 1;
        public static bool3 even(this float3 a) => ((int3)a & 1) != 1;
        public static bool4 even(this float4 a) => ((int4)a & 1) != 1;




    }
}

