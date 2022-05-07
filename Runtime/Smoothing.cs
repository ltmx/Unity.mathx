
namespace Unity.Mathematics
{
    public static partial class Math
    {
        // Float
        public static float smoothstep(this float x) => x.sq() * (3 - 2 * x);
        public static float smoothstepD(this float x) => 6 * x * (1 - x); // Derivative

        public static float smoothstep5(this float x) => x.cube() * (x * (6 * x - 15) + 10);
        public static float smoothstep5D(this float x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        public static float smoothstep7(this float x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        public static float smootherstep7D(this float x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        public static float smoothstep9(this float x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        public static float smoothstep9D(this float x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        public static float smoothstep11(this float x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        public static float smoothstep11D(this float x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative
        
        // Float2
        public static float2 smoothstep(this float2 x) => x.sq() * (3 - 2 * x);
        public static float2 smoothstepD(this float2 x) => 6 * x * (1 - x); // Derivative

        public static float2 smoothstep5(this float2 x) => x.cube() * (x * (6 * x - 15) + 10);
        public static float2 smoothstep5D(this float2 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        public static float2 smoothstep7(this float2 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        public static float2 smootherstep7D(this float2 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        public static float2 smoothstep9(this float2 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        public static float2 smoothstep9D(this float2 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        public static float2 smoothstep11(this float2 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        public static float2 smoothstep11D(this float2 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative
        
        
        // Float3
        public static float3 smoothstep(this float3 x) => x.sq() * (3 - 2 * x);
        public static float3 smoothstepD(this float3 x) => 6 * x * (1 - x); // Derivative

        public static float3 smoothstep5(this float3 x) => x.cube() * (x * (6 * x - 15) + 10);
        public static float3 smoothstep5D(this float3 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        public static float3 smoothstep7(this float3 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        public static float3 smootherstep7D(this float3 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        public static float3 smoothstep9(this float3 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        public static float3 smoothstep9D(this float3 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        public static float3 smoothstep11(this float3 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        public static float3 smoothstep11D(this float3 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative

        
        // Float4
        public static float4 smoothstep(this float4 x) => x.sq() * (3 - 2 * x);
        public static float4 smoothstepD(this float4 x) => 6 * x * (1 - x); // Derivative

        public static float4 smoothstep5(this float4 x) => x.cube() * (x * (6 * x - 15) + 10);
        public static float4 smoothstep5D(this float4 x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative
        
        public static float4 smoothstep7(this float4 x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        public static float4 smootherstep7D(this float4 x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative
        
        public static float4 smoothstep9(this float4 x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        public static float4 smoothstep9D(this float4 x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        public static float4 smoothstep11(this float4 x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);
        public static float4 smoothstep11D(this float4 x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative


    }
}