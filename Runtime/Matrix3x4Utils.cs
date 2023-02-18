using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;
 
namespace Unity.Mathematics
{
    public static partial class Math
    {
        public static float3x4 matrix(this RigidTransform m) => float3x4(float3x3(m.rot), m.pos);

        [MethodImpl(INLINE)]
        public static float3x4 inverse(this float3x4 m) => float3x4(m.rotation(), m[3].rotate(-m.rotation()));

        [MethodImpl(INLINE)]
        public static float3x4 float3x4(float3x3 r, float3 t) => math.float3x4(r.c0, r.c1, r.c2, t);

        [MethodImpl(INLINE)]
        public static float3x3 f3x3(this float3x4 m) => float3x3(m[0], m[1], m[2]);
        
        

        [MethodImpl(INLINE)]
        public static float3x3 rotation(this float3x4 m) => m.f3x3();

        [MethodImpl(INLINE)]
        public static float3 translation(this float3x4 m) => m[3];
        
        

        [MethodImpl(INLINE)]
        public static float3 transform(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        [MethodImpl(INLINE)]
        public static float3 transform(this float3x4 m, float4 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3] * p.w;

        

        [MethodImpl(INLINE)]
        public static float2 mul(this float2x2 matrix, float2 f) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float3 mul(this float3x3 matrix, float3 f) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float4 mul(this float4x4 matrix, float4 f) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float2 mul(this float2 f, float2x2 matrix) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float3 mul(this float3 f, float3x3 matrix) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float4 mul(this float4 f, float4x4 matrix) => math.mul(matrix, f);
        
        [MethodImpl(INLINE)]
        public static float3 mul(this float3 p, float3x4 m) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        [MethodImpl(INLINE)]
        public static float3 mul(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        
        /// Returns the result of transforming a vector by a quaternion
        [MethodImpl(INLINE)]
        public static float3 mul(this float3 f, quaternion rotation) => math.mul(rotation, f);
        

   




    }
}