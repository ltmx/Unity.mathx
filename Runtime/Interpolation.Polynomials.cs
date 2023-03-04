
namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Float
        /// <summary>smoothstep unclamped easing(polynomial of degree 3)</summary>
        public static float smooth(this float x) => x.sq() * (3 - 2 * x);
        /// <summary>smooth function derivative</summary>
        /// <see cref="smooth(float)"/>
        public static float smoothstepD(this float x) => 6 * x * (1 - x); // Derivative

        /// <summary>Quintic unclamped easing (polynomial of degree 5)</summary>
        public static float smooth5(this float x) => x.cube() * (x * (6 * x - 15) + 10);
        /// <summary>smooth5 function derivative</summary>
        /// <see cref="smooth5(float)"/>
        public static float smooth5D(this float x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        /// <summary>Heptic unclamped easing (polynomial of degree 7)</summary>
        public static float smooth7(this float x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        /// <summary>smooth7 function derivative</summary>
        /// <see cref="smooth7(float)"/>
        public static float smooth7D(this float x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        /// <summary>Nonic unclamped easing (polynomial of degree 9)</summary>
        public static float smooth9(this float x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        /// <summary>smooth9 function derivative</summary>
        /// <see cref="smooth9(float)"/>
        public static float smooth9D(this float x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        /// <summary>Hencecic unclamped easing (polynomial of degree 11)</summary>
        public static float smooth11(this float x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        /// <summary>smooth11 function derivative</summary>
        /// <see cref="smooth11(float)"/>
        public static float smooth11D(this float x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative
        
        // Float2
        /// <inheritdoc cref="smooth(float)"/>
        public static float2 smooth(this float2 x) => x.sq() * (3 - 2 * x);
        /// <inheritdoc cref="smoothstepD(float)"/>
        public static float2 smoothD(this float2 x) => 6 * x * (1 - x); // Derivative

        /// <inheritdoc cref="smooth5(float)"/>
        public static float2 smooth5(this float2 x) => x.cube() * (x * (6 * x - 15) + 10);
        /// <inheritdoc cref="smooth5D(float)"/>
        public static float2 smooth5D(this float2 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        /// <inheritdoc cref="smooth7(float)"/>
        public static float2 smooth7(this float2 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        /// <inheritdoc cref="smooth7D(float)"/>
        public static float2 smoother7D(this float2 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        /// <inheritdoc cref="smooth9(float)"/>
        public static float2 smooth9(this float2 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        /// <inheritdoc cref="smooth9D(float)"/>
        public static float2 smooth9D(this float2 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        /// <inheritdoc cref="smooth11(float)"/>
        public static float2 smooth11(this float2 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        /// <inheritdoc cref="smooth11D(float)"/>
        public static float2 smooth11D(this float2 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative
        
        
        // Float3
        /// <inheritdoc cref="smooth(float)"/>
        public static float3 smooth(this float3 x) => x.sq() * (3 - 2 * x);
        /// <inheritdoc cref="smoothstepD(float)"/>
        public static float3 smoothD(this float3 x) => 6 * x * (1 - x); // Derivative

        /// <inheritdoc cref="smooth5(float)"/>
        public static float3 smooth5(this float3 x) => x.cube() * (x * (6 * x - 15) + 10);
        /// <inheritdoc cref="smooth5D(float)"/>
        public static float3 smooth5D(this float3 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        /// <inheritdoc cref="smooth7(float)"/>
        public static float3 smooth7(this float3 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        /// <inheritdoc cref="smooth7D(float)"/>
        public static float3 smoother7D(this float3 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        /// <inheritdoc cref="smooth9(float)"/>
        public static float3 smooth9(this float3 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        /// <inheritdoc cref="smooth9D(float)"/>
        public static float3 smooth9D(this float3 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        /// <inheritdoc cref="smooth11(float)"/>
        public static float3 smooth11(this float3 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        /// <inheritdoc cref="smooth11D(float)"/>
        public static float3 smooth11D(this float3 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative

        
        // Float4
        /// <inheritdoc cref="smooth(float)"/>
        public static float4 smooth(this float4 x) => x.sq() * (3 - 2 * x);
        /// <inheritdoc cref="smoothstepD(float)"/>
        public static float4 smoothD(this float4 x) => 6 * x * (1 - x); // Derivative
        
        /// <inheritdoc cref="smooth5(float)"/>
        public static float4 smooth5(this float4 x) => x.cube() * (x * (6 * x - 15) + 10);
        /// <inheritdoc cref="smooth5D(float)"/>
        public static float4 smooth5D(this float4 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        /// <inheritdoc cref="smooth7(float)"/>
        public static float4 smooth7(this float4 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        /// <inheritdoc cref="smooth7D(float)"/>
        public static float4 smoother7D(this float4 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        /// <inheritdoc cref="smooth9(float)"/>
        public static float4 smooth9(this float4 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        /// <inheritdoc cref="smooth9D(float)"/>
        public static float4 smooth9D(this float4 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        /// <inheritdoc cref="smooth11(float)"/>
        public static float4 smooth11(this float4 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        /// <inheritdoc cref="smooth11D(float)"/>
        public static float4 smooth11D(this float4 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative


    }
}