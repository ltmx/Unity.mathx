using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static partial class UnityMathematicsExtensions
    {
        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24
        
        [StructLayout(LayoutKind.Explicit)]
        private struct FloatIntUnion
        {
            [FieldOffset(0)] public float f;
            [FieldOffset(0)] public int tmp;
        }
        /// The Infamous Unusual Fast Inverse Square Root (TM).
        public static float fastrsqrt(this float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.tmp = 0;
            float xhalf = 0.5f * z;
            u.f = z;
            u.tmp = 0x5f375a86 - (u.tmp >> 1);
            u.f *= 1.5f - xhalf * u.f * u.f;
            return u.f * z;
        }
        /// Low accuracy sqrt method for fast calculation.
        public static float fastsqrt(this float z)
        {
            if (z == 0) return 0;
            FloatIntUnion u;
            u.tmp = 0;
            u.f = z;
            u.tmp -= 1 << 23; // Subtract 2^m.
            u.tmp >>= 1; // Divide by 2.
            u.tmp += 1 << 29; // Add ((b + 1) / 2) * 2^m.
            return u.f;
        }
        
        /// Returns the distance between a and b (fast but low accuracy)
        public static float fastdistance(float4 a, float4 b) => fastsqrt((a - b).sqr().sum());
        /// <inheritdoc cref="fastdistance(float4,float4)"/>
        public static float fastdistance(float3 a, float3 b) => fastsqrt((a - b).sqr().sum());
        /// <inheritdoc cref="fastdistance(float4,float4)"/>
        public static float fastdistance(float2 a, float2 b) => fastsqrt((a - b).sqr().sum());

        /// Returns the length of the vector (fast but low accuracy)
        public static float fastlength(this float4 f) => fastsqrt(f.sqr().sum());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this float3 f) => fastsqrt(f.sqr().sum());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this float2 f) => fastsqrt(f.sqr().sum());
        
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector4 f) => fastsqrt(f.sqr().sum());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector3 f) => fastsqrt(f.sqr().sum());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector2 f) => fastsqrt(f.sqr().sum());
    }
}