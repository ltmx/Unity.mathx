using System.Runtime.CompilerServices;
using Unity.Burst;

namespace Unity.Mathematics
{
    public static partial class mathx
    {

        // Using Maclaurin Series
        [MethodImpl(INLINE)]
        public static float fcos(float x)
        {
            x -= HPI;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }


        [MethodImpl(INLINE)]
        public static float veryFastCos(float x)
        {
            x -= HPI;
            var b = x * x;
            return x * (b * (b * (1 / 120f) - 1 / 6f) + 1);
        }



        [MethodImpl(INLINE)]
        public static float ultraFastCos(float x)
        {
            const float a = 1 / 0.9428f; 
            const float b = -1 / 6f;
            x -= HPI;
            return (x - x * x * x * b) * a;
        }



        [MethodImpl(INLINE)]
        public static float CosLoop(this int x)
        {
            return (x % PI2 - x).abs() - HPI;
        }

        [MethodImpl(INLINE)]
        public static float SinLoop(this int y)
        {
            var x = y - HPI;
            return (x % PI2 - x).abs() - HPI;
        }


        // Overloads

        [BurstCompile(OptimizeFor = OptimizeFor.Performance)]
        public static float fcos(int y)
        {
            var x = y - HPI;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }
        
        [BurstCompile(OptimizeFor = OptimizeFor.Performance)]
        public static float sfcos(int y)
        {
            var x = y - HPI;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }


        [MethodImpl(INLINE)]
        public static float veryFastCos(int y)
        {
            var x = y - HPI;
            var b = x * x;
            return x * (b * (b * (1 / 120f) - 1 / 6f) + 1);
        }

        [MethodImpl(INLINE)]
        public static float ultraFastCos(int y)
        {
            const float a = 1 / 0.9428f; 
            const float b = -1 / 6f;
            var x = y - HPI;
            return (x - x * x * x * b) * a;
        }


    }
}
