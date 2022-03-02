using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static partial class Math
    {
        // Component-wise comparison --------------------------------------------------------------

        public static float cmax(this float4 f) => math.cmax(f);
        public static float cmax(this float3 f) => math.cmax(f);
        public static float cmax(this float2 f) => math.cmax(f);
        
        public static double cmax(this double4 f) => math.cmax(f);
        public static double cmax(this double3 f) => math.cmax(f);
        public static double cmax(this double2 f) => math.cmax(f);
        
        public static float cmax(this Vector4 f) => math.cmax(f);
        public static float cmax(this Vector3 f) => math.cmax(f);
        public static float cmax(this Vector2 f) => math.cmax(f);
        
        public static float cmax(this color f) => math.cmax(f);

        public static float cmin(this float4 f) => math.cmin(f);
        public static float cmin(this float3 f) => math.cmin(f);
        public static float cmin(this float2 f) => math.cmin(f);
        
        public static float cmin(this Vector4 f) => math.cmin(f);
        public static float cmin(this Vector3 f) => math.cmin(f);
        public static float cmin(this Vector2 f) => math.cmin(f);
        
        public static double cmin(this double4 f) => math.cmin(f);
        public static double cmin(this double3 f) => math.cmin(f);
        public static double cmin(this double2 f) => math.cmin(f);
        
        public static double cmin(this color f) => math.cmin(f);
        
        
        /// Returns 1 inside the longest(s) axis(es) and 0 in the others
        public static bool4 cmaxAxis(this float4 f) { var m = f.cmax(); return new bool4(f.x == m, f.y == m,f.z == m,f.w == m); }
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool3 cmaxAxis(this float3 f) { var m = f.cmax(); return new bool3(f.x == m, f.y == m,f.z == m); }
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool2 cmaxAxis(this float2 f) { var m = f.cmax(); return new bool2(f.x == m, f.y == m); }
        
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool4 cmaxAxis(this Vector4 f) => f.asfloat().cmaxAxis();
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool3 cmaxAxis(this Vector3 f) => f.asfloat().cmaxAxis();
        /// <inheritdoc cref="cmaxAxis(Unity.Mathematics.float4)"/>
        public static bool2 cmaxAxis(this Vector2 f) => f.asfloat().cmaxAxis();

        /// Returns true inside the shortest axes
        public static bool4 cminAxis(this float4 f) { var m = f.cmin(); return new bool4(f.x == m, f.y == m,f.z == m,f.w == m); }
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool3 cminAxis(this float3 f) { var m = f.cmin(); return new bool3(f.x == m, f.y == m,f.z == m); }
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool2 cminAxis(this float2 f) { var m = f.cmin(); return new bool2(f.x == m, f.y == m); }
        
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool4 cminAxis(this Vector4 f) => f.asfloat().cminAxis();
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool3 cminAxis(this Vector3 f) => f.asfloat().cminAxis();
        /// <inheritdoc cref="cminAxis(Unity.Mathematics.float4)"/>
        public static bool2 cminAxis(this Vector2 f) => f.asfloat().cminAxis();
    }
}