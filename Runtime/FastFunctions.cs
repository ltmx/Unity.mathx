using System.Runtime.CompilerServices;
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


        public static float4 fastsqrt(this float4 f) => new float4(f.xy.fastsqrt(), f.zw.fastsqrt());
        public static float3 fastsqrt(this float3 f) => new float3(f.xy.fastsqrt(), f.z.fastsqrt());
        public static float2 fastsqrt(this float2 f) => new float2(f.x.fastsqrt(), f.y.fastsqrt()); // to never simplify to new float2(f.xy.fastsqrt())


        /// Returns the distance between a and b (fast but low accuracy)
        public static float fastdistance(float4 a, float4 b) => fastsqrt((a - b).selfmul());
        /// <inheritdoc cref="fastdistance(float4,float4)"/>
        public static float fastdistance(float3 a, float3 b) => fastsqrt((a - b).selfmul());
        /// <inheritdoc cref="fastdistance(float4,float4)"/>
        public static float fastdistance(float2 a, float2 b) => fastsqrt((a - b).selfmul());
        

        /// Returns the length of the vector (fast but low accuracy)
        public static float fastlength(this float4 f) => fastsqrt(f.selfmul());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this float3 f) => fastsqrt(f.selfmul());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this float2 f) => fastsqrt(f.selfmul());
        
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector4 f) => fastsqrt(f.selfmul());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector3 f) => fastsqrt(f.selfmul());
        /// <inheritdoc cref="fastlength(float4)"/>
        public static float fastlength(this Vector2 f) => fastsqrt(f.selfmul());
        
        // https://github.com/SunsetQuest/Fast-Integer-Log2 --------------------------
        [StructLayout(LayoutKind.Explicit)]
        private struct ConverterStruct2
        {
            [FieldOffset(0)] public ulong asLong;
            [FieldOffset(0)] public double asDouble;
        }

        // Same as Log2_SunsetQuest3 except it uses FP64.
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int log2int(this int value)
        {
            ConverterStruct2 a;  a.asLong = 0; a.asDouble = (uint)value;
            return (int)((a.asLong >> 52) + 1) & 0xFF;
        }
        // -------------------------------------------------------------------------------
        
    }
}