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
        
        
        /// Returns a if s is true, b otherwise
        public static T select<T>(this bool s, T a, T b) => s ? a : b;
        /// Returns a if s is true, b otherwise
        public static T select<T>(this int s, T a, T b) => s.asbool() ? a : b;

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

        /// Returns true if a is odd
        public static bool odd(this float a) => ((int)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool2 odd(this float2 a) => ((int2)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool3 odd(this float3 a) => ((int3)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool4 odd(this float4 a) => ((int4)a & 1) != 0;
        
        /// Returns true if a is even
        public static bool even(this int a) => (a & 1) != 1; // 12% faster than a % 2 == 0
        /// Returns true if a is even component-wise
        public static bool2 even(this int2 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool3 even(this int3 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool4 even(this int4 a) => (a & 1) != 1;

        /// Returns true if a is even
        public static bool even(this float a) => ((int)a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool2 even(this float2 a) => ((int2) a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool3 even(this float3 a) => ((int3)a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool4 even(this float4 a) => ((int4)a & 1) != 1;

        
        // packed data accessing ------------------------------------
        
        /// selects an element of an array using an int as index;
        public static T get<T>(this int id, T[] t) => t[id];
        /// selects an element of an array of arrays using an int2 as index;
        public static T get<T>(this int2 id, T[][] t) => t[id.x][id.y];
        /// selects an element of an array of arrays using an int2 as index;
        public static T get<T>(this int3 id, T[][][] t) => t[id.x][id.y][id.z];
        
        /// selects an element of an array using an int2 as index;
        public static T get<T>(this int2 id, T[,] t) => t[id.x, id.y];
        /// selects an element of an array using an int3 as index;
        public static T get<T>(this int3 id, T[,,] t) => t[id.x, id.y, id.z];
        /// selects an element of a multidimensional array of arrays using an int3 as index;
        public static T get<T>(this int3 id, T[,][] t) => t[id.x, id.y][id.z];
        /// selects an element of an array of multidimensional arrays using an int3 as index;
        public static T get<T>(this int3 id, T[][,] t) => t[id.x][id.y, id.z];

        
        /// selects an element of an array using an int as index;
        public static T get<T>(this T[] t, int id) => t[id];
        /// selects an element of an array of arrays using an int2 as index;
        public static T get<T>(this T[][] t, int2 id) => t[id.x][id.y];
        /// selects an element of an array of arrays using an int2 as index;
        public static T get<T>(this T[][][] t, int3 id) => t[id.x][id.y][id.z];
        /// selects an element of an array using an int2 as index;
        public static T get<T>(this T[,] t, int2 id) => t[id.x, id.y];
        /// selects an element of an array using an int3 as index;
        public static T get<T>(this T[,,] t, int3 id) => t[id.x, id.y, id.z];
        /// selects an element of a multidimensional array of arrays using an int3 as index;
        public static T get<T>(this T[,][] t, int3 id) => t[id.x, id.y][id.z];
        /// selects an element of an array of multidimensional arrays using an int3 as index;
        public static T get<T>(this T[][,] t, int3 id) => t[id.x][id.y, id.z];
        
        
        // public static bool allnan(this float4 f) => f.xy.allnan() && f.zw.allnan();
        // public static bool allnan(this float3 f) => f.xy.allnan() && f.z.isnan();
        // public static bool allnan(this float2 f) => f.x.isnan() && f.y.isnan();
        
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this float4 f) => f.xy.anynan() || f.zw.anynan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this float3 f) => f.xy.anynan() || f.z.isnan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this float2 f) => f.x.isnan() || f.y.isnan();
        /// returns true if the value is NAN, otherwise false
        public static bool isnan(this float f) => math.isnan(f);
        
        public static bool4 isgreaterthan(this float4 f, float value) => (f > value);
        public static bool3 isgreaterthan(this float3 f, float value) => (f > value);
        public static bool2 isgreaterthan(this float2 f, float value) => (f > value);
        public static bool isgreaterthan(this float f, float value) => (f > value);

    }
}

