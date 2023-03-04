//Refactored and optimized by LTMX - from - https://web.archive.org/web/20180616003313/http://lab.polygonal.de/2007/07/18/fast-and-accurate-sinecosine-approximation/

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        private const float t1 = 1.27323954f;
        private const float t2 = 0.405284735f;
        
        /// Low precision sine (~14x faster) - always wrap input angle to -PI..PI
        public static float sfastsine(this float x){
            
            if (x < -PI) x += TAU;
            else if (x >  PI) x -= TAU;
            return x < 0 ? x * (t1 + t2 * x) : x * (t1 - t2 * x);
        }
        
        //sin(x + PI/2) = cos(x)
        /// Low precision cosine (~14x faster)
        public static float sfastcosine(this float x)
        {
            x += HPI;
            if (x >  PI) x -= TAU;
            return x < 0 ? x * (t1+ t2* x) : x * (t1- t2* x);
        }
        
        //
        /// High precision sine (~8x faster) - always wrap input angle to -PI..PI
        public static float fastsine(this float x)
        {
            if (x < -PI) x += TAU;
            else if (x >  PI) x -= TAU;
            if (x < 0) {
                var s = x * (t1 + t2 * x);
                return s < 0 ? .225f * (s * -s - s) + s : .225f * (s * s - s) + s;
            }
            var s2 = x * (t1 - t2 * x);
            return s2 < 0 ? .225f * (s2 * -s2 - s2) + s2 : .225f * (s2 * s2 - s2) + s2;
        }

        //sin(x + PI/2) = cos(x)
        /// High precision cosine (~8x faster) - always wrap input angle to -PI..PI
        public static float fastcosine(this float x)
        {
            if (x > HPI) x -= 4.71238898f;
            if (x < 0) {
                var c = x * (t1+ t2* x);
                return c < 0 ? .225f * (c * -c - c) + c : .225f * (c * c - c) + c;
            }
            var c2 = x * (t1- t2* x);
            return c2 < 0 ? .225f * (c2 * -c2 - c2) + c2 : .225f * (c2 * c2 - c2) + c2;
        }
        
        // Overloads
        
        //sin(x + PI/2) = cos(x)
        /// Low precision cosine (~14x faster)
        public static float sfastcosine(this int f)
        {
            var x = f + HPI;
            if (x >  PI) x -= TAU;
            return x < 0 ? x * (t1+ t2* x) : x * (t1- t2* x);
        }
    }
}