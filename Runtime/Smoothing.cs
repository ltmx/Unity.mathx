namespace Unity.Mathematics
{
    public static partial class Math
    {
        static float smoothstep(float x) => x.sq() * (3 - 2 * x);
        static float smoothstepD(float x) => 6 * x * (1 - x); // Derivative

        static float smoothstep5(float x) => x.cube() * (x * (6 * x - 15) + 10);
        static float smoothstep5D(float x) => 30 * x.sq() * (x * (x - 2) + 1); // Derivative


        static float smoothstep7(float x) => x.pow4() * (x * (x * (-20 * x + 70) - 84) + 35);
        static float smootherstep7D(float x) => 140 * x.cube() * (x * (x * (-x + 3) - 3) + 1); // Derivative


        static float smoothstep9(float x) => x.pow5() * (x * (x * (x * (70 * x - 315) + 540) - 420) + 126);
        static float smoothstep9D(float x) => 630 * x.pow4() * (x * (x * (x * (x - 4) + 6) - 4) + 1); // Derivative

        static float smoothstep11(float x) => x.pow5() * (x * (x * (x * (x * (-252 * x + 1386) - 3080) + 3465) - 1980) + 462);

        static float smoothstep11D(float x) => 2772 * x.pow5() * (x * (x * (x * (x * (-x + 5) - 10) + 10) - 5) + 1); // Derivative
    }
}