// Translation to C# from https://easings.net/
// by LTMX - https://github.com/LTMX

namespace Unity.Mathematics
{
    public static partial class Math
    {
        public static float easeInSine(this float x) => 1 - cos((x * PI) / 2);
        public static float easeOutSine(this float x) => sin(x * PI / 2);
        public static float easeInOutSine(this float x) => - (cos(PI * x) - 1) / 2;
        public static float easeInQuad(this float x) => x * x;
        public static float easeOutQuad(this float x) => 1 - (1 - x) * (1 - x);
        public static float easeInOutQuad(this float x) => x < 0.5 ? 2 * x * x : 1 - (-2 * x + 2).sqr() / 2;
        public static float easeInCubic(this float x) => x.cube();
        public static float easeOutCubic(this float x) => 1 - (1 - x).cube();
        public static float easeInOutCubic(this float x) => x < 0.5 ? 4 * x.cube() : 1 - (-2 * x + 2).cube() / 2;
        public static float easeInQuart(this float x) => x * x * x * x;
        public static float easeOutQuart(this float x) => 1 - pow(1 - x, 4);
        public static float easeInOutQuart(this float x) => x < 0.5 ? 8 * x.quart() : 1 - math.pow(-2 * x + 2, 4) / 2;
        public static float easeInQuint(this float x) => x.quint();
        public static float easeOutQuint(this float x) => 1 - math.pow(1 - x, 5);
        public static float easeInOutQuint(this float x) => x < 0.5 ? 16 * x.quint() : 1 - math.pow(-2 * x + 2, 5) / 2;
        public static float easeInExpo(this float x) => x == 0 ? 0 : exp2( 10 * x - 10);
        public static float easeOutExpo(this float x) => x == 1 ? 1 : 1 - exp2( -10 * x);
        public static float easeInOutExpo(this float x) {
            if (x == 0 || x == 1) return x;
            if (x < 0.5) return exp2(20 * x - 10) / 2;
            return (2 - exp2(-20 * x + 10)) / 2;
        }
        public static float easeInCirc(this float x) => 1 - sqrt(1 - x * x);
        public static float easeOutCirc(this float x) => sqrt(1 - math.pow(x - 1, 2));

        public static float easeInOutCirc(this float x){
            return x < 0.5
                ? (1 - sqrt(1 - (2 * x).sqr())) / 2
                : (sqrt(1 - (-2 * x + 2).sqr()) + 1) / 2;
        }
        public static float easeInBack(this float x){
            const float c1 = 1.70158f;
            const float c3 = c1 + 1;
            return c3 * x.cube() - c1 * x.sqr();
        }
        public static float easeOutBack(this float x){
            const float c1 = 1.70158f;
            const float c3 = c1 + 1;
            return 1 + c3 * (x - 1).cube() + c1 * (x - 1).sqr();
        }
        public static float easeInOutBack(this float x){
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;
            return x < 0.5
                ? ((2 * x).sqr() * ((c2 + 1) * 2 * x - c2)) / 2
                : ((2 * x - 2).sqr() * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2;
        }
        public static float easeInElastic(this float x) {
            const float c4 = (2 * PI) / 3;
            if (x == 0 || x == 1) return x;
            return - exp2(10 * x - 10) * sin((x * 10 - 10.75f) * c4);
        }
        public static float easeOutElastic(this float x) {
            const float c4 = (2 * PI) / 3;
            if (x == 0 || x == 1) return x;
            return exp2( -10 * x) * sin((x * 10 - 0.75f) * c4) + 1;
        }
        public static float easeInOutElastic(this float x) {
            const float c5 = (2 * PI) / 4.5f;

            if (x == 0 || x == 1) return x;
            if (x < 0.5f) 
                return -(exp2(20 * x - 10) * sin((20 * x - 11.125f) * c5)) / 2;
            return (exp2(-20 * x + 10) * sin((20 * x - 11.125f) * c5)) / 2 + 1;
        }
        public static float easeInBounce(this float x) => 1 - easeOutBounce(1 - x);

        public static float easeOutBounce(this float x){
            const float n1 = 7.5625f;
            const float d1 = 2.75f;

            if (x < 1 / d1) return n1 * x * x; 
            if (x < 2 / d1) return n1 * (x -= 1.5f / d1) * x + 0.75f;
            if (x < 2.5 / d1) return n1 * (x -= 2.25f / d1) * x + 0.9375f;
            return n1 * (x -= 2.625f / d1) * x + 0.984375f;

        }
        public static float easeInOutBounce(this float x){
            return x < 0.5
                ? (1 - easeOutBounce(1 - 2 * x)) / 2
                : (1 + easeOutBounce(2 * x - 1)) / 2;
        }
    }
}