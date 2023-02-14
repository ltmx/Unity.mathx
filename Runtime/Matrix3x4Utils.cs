 // Source : https://iquilezles.org/articles/distfunctions/

// using static Unity.Mathematics.math;
using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 inversematrix(this RigidTransform m)
        {
            var r = float3x3(m.rot);
            var t = m.pos;
            return float3x4(r, t.rotate(-r));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 matrix(this RigidTransform m)
        {
            var r = float3x3(m.rot);
            return float3x4(r, m.pos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 inverse(this float3x4 m) => float3x4(m.rotation(), m[3].rotate(-m.rotation()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float3x3 r, float3 t) => math.float3x4(r.c0, r.c1, r.c2, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 f3x3(this float3x4 m) => float3x3(m[0], m[1], m[2]);
        
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 rotation(this float3x4 m) => m.f3x3();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 translation(this float3x4 m) => m[3];
        
        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 transform(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 transform(this float3x4 m, float4 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3] * p.w;

        

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 mul(this float2x2 matrix, float2 f) => math.mul(matrix, f);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(this float3x3 matrix, float3 f) => math.mul(matrix, f);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 mul(this float4x4 matrix, float4 f) => math.mul(matrix, f);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 mul(this float2 f, float2x2 matrix) => math.mul(matrix, f);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(this float3 f, float3x3 matrix) => math.mul(matrix, f);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 mul(this float4 f, float4x4 matrix) => math.mul(matrix, f);
        
        /// public static float3 mul(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(this float3 p, float3x4 m) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        /// Returns the result of transforming a vector by a quaternion
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(this float3 f, quaternion rotation) => math.mul(rotation, f);
        

   




    }
}