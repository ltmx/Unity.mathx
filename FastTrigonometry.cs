namespace LTMX
{
    //Refactored and optimized by LTMX - from - https://web.archive.org/web/20180616003313/http://lab.polygonal.de/2007/07/18/fast-and-accurate-sinecosine-approximation/
    public partial class UnityMathematicsExtensions
    {
        private const float t1 = 1.27323954f;
        private const float t2 = 0.405284735f;
        
        /// Low precision sine (~14x faster) - always wrap input angle to -PI..PI
        public static double sfastsine(this double x){
            
            if (x < -PI_DBL) x += TAU_DBL;
            else if (x >  PI_DBL) x -= TAU_DBL;
            return x < 0 ? x * (t1 + t2 * x) : x * (t1 - t2 * x);
        }
        
        //sin(x + PI/2) = cos(x)
        /// Low precision cosine (~14x faster)
        public static double sfastcosine(this double x)
        {
            x += 1.57079632;
            if (x >  PI) x -= TAU;
            return x < 0 ? x * (t1+ t2* x) : x * (t1- t2* x);
        }
        
        //
        /// High precision sine (~8x faster) - always wrap input angle to -PI..PI
        public static double fastsine(this double x)
        {
            if (x < -PI) x += TAU;
            else if (x >  PI) x -= TAU;
            if (x < 0) {
                var s = x * (t1 + t2 * x);
                return s < 0 ? 0.225 * (s * -s - s) + s : 0.225 * (s * s - s) + s;
            }
            var s2 = x * (t1 - t2 * x);
            return s2 < 0 ? .225 * (s2 * -s2 - s2) + s2 : 0.225 * (s2 * s2 - s2) + s2;
        }

        //sin(x + PI/2) = cos(x)
        /// High precision cosine (~8x faster) - always wrap input angle to -PI..PI
        public static double fastcosine(this double x)
        {
            if (x > 1.57079632) x -= 4.71238898;
            if (x < 0) {
                var c = x * (t1+ t2* x);
                return c < 0 ? 0.225 * (c * -c - c) + c : 0.225 * (c * c - c) + c;
            }
            var c2 = x * (t1- t2* x);
            return c2 < 0 ? .225 * (c2 * -c2 - c2) + c2 : .225 * (c2 * c2 - c2) + c2;
        }
    }
}