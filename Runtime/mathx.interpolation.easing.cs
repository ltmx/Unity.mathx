#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        [MI(IL)] public static float easeInSine(this float x) => 1 - cos(x * HPI);
        [MI(IL)] public static float easeOutSine(this float x) => sin(x * HPI);
        [MI(IL)] public static float easeInOutSine(this float x) => - (cos(PI * x) - 1) * 0.5f;
        [MI(IL)] public static float easeInQuad(this float x) => x * x;
        [MI(IL)] public static float easeOutQuad(this float x) => 1 - (1 - x) * (1 - x);
        [MI(IL)] public static float easeInOutQuad(this float x) => x < 0.5f ? 2 * x * x : 1 - (-2 * x + 2).sq() * 0.5f;
        [MI(IL)] public static float easeInCubic(this float x) => x.cube();
        [MI(IL)] public static float easeOutCubic(this float x) => 1 - (1 - x).cube();
        [MI(IL)] public static float easeInOutCubic(this float x) => x < 0.5f ? 4 * x.cube() : 1 - (-2 * x + 2).cube() * 0.5f;
        [MI(IL)] public static float easeInQuart(this float x) => x * x * x * x;
        [MI(IL)] public static float easeOutQuart(this float x) => 1 - pow4(1 - x);
        [MI(IL)] public static float easeInOutQuart(this float x) => x < 0.5f ? 8 * x.pow4() : 1 - (-2 * x + 2).pow4() * 0.5f;
        [MI(IL)] public static float easeInQuint(this float x) => x.pow5();
        [MI(IL)] public static float easeOutQuint(this float x) => 1 - pow5(1 - x);
        [MI(IL)] public static float easeInOutQuint(this float x) => x < 0.5f ? 16 * x.pow5() : 1 - (-2 * x + 2).pow5() * 0.5f;
        [MI(IL)] public static float easeInExpo(this float x) => x == 0 ? 0 : exp2( 10 * x - 10);
        [MI(IL)] public static float easeOutExpo(this float x) => x == 1 ? 1 : 1 - exp2( -10 * x);
        [MI(IL)] public static float easeInOutExpo(this float x) {
            if (x is 0 or 1) return x;
            if (x < 0.5) return exp2(20 * x - 10) / 2;
            return (2 - exp2(-20 * x + 10)) / 2;
        }
        [MI(IL)] public static float easeInCirc(this float x) => 1 - sqrt(1 - x * x);
        [MI(IL)] public static float easeOutCirc(this float x) => sqrt(1 - (x - 1).sq());
        [MI(IL)] public static float easeInOutCirc(this float x){
            return x < 0.5
                ? (1 - sqrt(1 - (2 * x).sq())) * 0.5f
                : (sqrt(1 - (-2 * x + 2).sq()) + 1) * 0.5f;
        }
        [MI(IL)] public static float easeInBack(this float x){
            const float c1 = 1.70158f;
            const float c3 = c1 + 1;
            return c3 * x.cube() - c1 * x.sq();
        }
        [MI(IL)] public static float easeOutBack(this float x){
            const float c1 = 1.70158f;
            const float c3 = c1 + 1;
            return 1 + c3 * (x - 1).cube() + c1 * (x - 1).sq();
        }
        [MI(IL)] public static float easeInOutBack(this float x){
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;
            return x < 0.5
                ? (2 * x).sq() * ((c2 + 1) * 2 * x - c2) * 0.5f
                : ((2 * x - 2).sq() * ((c2 + 1) * (x * 2 - 2) + c2) + 2) * 0.5f;
        }
        [MI(IL)] public static float easeInElastic(this float x) {
            const float c4 = TAU / 3;
            if (x is 0 or 1) return x;
            return - exp2(10 * x - 10) * sin((x * 10 - 10.75f) * c4);
        }
        [MI(IL)] public static float easeOutElastic(this float x) {
            const float c4 = 2 * PI / 3;
            if (x is 0 or 1f) return x;
            return exp2( -10 * x) * sin((x * 10 - 0.75f) * c4) + 1;
        }
        [MI(IL)] public static float easeInOutElastic(this float x) {
            const float c5 = 2 * PI / 4.5f;

            return x switch
            {
                0 or 1 => x,
                < 0.5f => -(exp2(20 * x - 10) * sin((20 * x - 11.125f) * c5)) * 0.5f,
                _ => exp2(-20 * x + 10) * sin((20 * x - 11.125f) * c5) * 0.5f + 1
            };
        }
        [MI(IL)] public static float easeInBounce(this float x) => 1 - easeOutBounce(1 - x);

        [MI(IL)] public static float easeOutBounce(this float x){
            const float n1 = 7.5625f;
            const float d1 = 2.75f;

            if (x < 1 / d1) return n1 * x * x; 
            if (x < 2 / d1) return n1 * (x -= 1.5f / d1) * x + 0.75f;
            if (x < 2.5 / d1) return n1 * (x -= 2.25f / d1) * x + 0.9375f;
            return n1 * (x -= 2.625f / d1) * x + 0.984375f;
 
        }
        [MI(IL)] public static float easeInOutBounce(this float x){
            return x < 0.5f
                ? (1 - easeOutBounce(1 - 2 * x)) / 2
                : (1 + easeOutBounce(2 * x - 1)) / 2;
        }


    }
}