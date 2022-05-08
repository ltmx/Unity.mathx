using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Burst;

namespace Unity.Mathematics
{
    public static partial class Math
    {

        // Using Maclaurin Series
        [MethodImpl(INLINE)]
        public static float fcos(float x)
        {
            x -= PIo2;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }


        [MethodImpl(INLINE)]
        public static float veryFastCos(float x)
        {
            x -= PIo2;
            var b = x * x;
            return x * (b * (b * (1 / 120f) - 1 / 6f) + 1);
        }



        [MethodImpl(INLINE)]
        public static float ultraFastCos(float x)
        {
            const float a = 1 / 0.9428f; 
            const float b = -1 / 6f;
            x -= PIo2;
            return (x - x * x * x * b) * a;
        }



        [MethodImpl(INLINE)]
        public static float CosLoop(this int x)
        {
            return (x % PI2 - x).abs() - PIo2;
        }

        [MethodImpl(INLINE)]
        public static float SinLoop(this int y)
        {
            var x = y - HPI;
            return (x % PI2 - x).abs() - PIo2;
        }


        // Overloads

        [BurstCompile(OptimizeFor = OptimizeFor.Performance)]
        public static float fcos(int y)
        {
            var x = y - PIo2;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }
        
        public static float sfcos(int y)
        {
            var x = y - PIo2;
            var b = x * x;
            return x * (b * (b * (1 / 120f - b / 5040) - 1 / 6f) + 1);
        }


        [MethodImpl(INLINE)]
        public static float veryFastCos(int y)
        {
            var x = y - PIo2;
            var b = x * x;
            return x * (b * (b * (1 / 120f) - 1 / 6f) + 1);
        }

        [MethodImpl(INLINE)]
        public static float ultraFastCos(int y)
        {
            const float a = 1 / 0.9428f; 
            const float b = -1 / 6f;
            var x = y - PIo2;
            return (x - x * x * x * b) * a;
        }

        [MethodImpl(INLINE)]
        public static float fmod(this float f, float mod) => (f / mod).frac() * mod; // 5% faster

        [MethodImpl(INLINE)]
        public static float mod(this float f, float mod) => f % mod;

        [MethodImpl(INLINE)]
        public static float fmod(this int f, float mod) => (f / mod).frac() * mod; // 5% faster

        [MethodImpl(INLINE)]
        public static float mod(this int f, float mod) => f % mod;

        [MethodImpl(INLINE)]
        public static float modfaster(this int f, float invMod, float mod) => (f * invMod).frac() * mod;

        [MethodImpl(INLINE)]
        [BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
        public static float modrcp(this int f, float mod) => (f * mod.rcp()).frac() * mod;


        [StructLayout(LayoutKind.Explicit)]
        private struct FloatUInt32Union
        {
            [FieldOffset(0)] public float f;
            [FieldOffset(0)] public UInt32 u;
        }

        private static FloatUInt32Union fiu;
        
        [BurstCompile]
        public static float frcp(this float x)
        {
            fiu.f = x;
            fiu.u = (0xbe6eb3beU - fiu.u) >> 1; // pow( x, -0.5 )
            return fiu.f * fiu.f; // pow( pow(x,-0.5), 2 ) = pow( x, -1 ) = 1.0 / x
        }
        
        [BurstCompile]
        public static float frcp(this int x)
        {
            fiu.f = x;
            fiu.u = (0xbe6eb3beU - fiu.u) >> 1; // pow( x, -0.5 )
            return fiu.f * fiu.f; // pow( pow(x,-0.5), 2 ) = pow( x, -1 ) = 1.0 / x
        }

    }
}
