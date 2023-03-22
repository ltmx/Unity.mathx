#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        
        /// <inheritdoc cref="f4x4(Mathematics.float4)"/>
        public static float4x4 float4x4(float4 f) => f.f4x4();
        /// <inheritdoc cref="f4x3(Mathematics.float4)"/>
        public static float4x3 float4x3(float4 f) => f.f4x3();
        /// <inheritdoc cref="f4x2(Mathematics.float4)"/>
        public static float4x2 float4x2(float4 f) => f.f4x2();
        /// <inheritdoc cref="f3x4(Mathematics.float3)"/>
        public static float3x4 float3x4(float3 f) => f.f3x4();
        /// <inheritdoc cref="f3x3(Mathematics.float3)"/>
        public static float3x3 float3x3(float3 f) => f.f3x3();
        /// <inheritdoc cref="f3x2(Mathematics.float3)"/>
        public static float3x2 float3x2(float3 f) => f.f3x2();
        /// <inheritdoc cref="f2x4(Mathematics.float2)"/>
        public static float2x4 float2x4(float2 f) => f.f2x4();
        /// <inheritdoc cref="f2x3(Mathematics.float2)"/>
        public static float2x3 float2x3(float2 f) => f.f2x3();
        /// <inheritdoc cref="f2x2(Mathematics.float2)"/>
        public static float2x2 float2x2(float2 f) => f.f2x2();
        
        /// <inheritdoc cref="math.float4x4(float)"/>
        public static float4x4 float4x4(float f) => new(f);
        /// <inheritdoc cref="math.float4x3(float)"/>
        public static float4x3 float4x3(float f) => new(f);
        /// <inheritdoc cref="math.float4x2(float)"/>
        public static float4x2 float4x2(float f) => new(f);
        /// <inheritdoc cref="math.float3x4(float)"/>
        public static float3x4 float3x4(float f) => new(f);
        /// <inheritdoc cref="math.float3x3(float)"/>
        public static float3x3 float3x3(float f) => new(f);
        /// <inheritdoc cref="math.float3x2(float)"/>
        public static float3x2 float3x2(float f) => new(f);
        /// <inheritdoc cref="math.float2x4(float)"/>
        public static float2x4 float2x4(float f) => new(f);
        /// <inheritdoc cref="math.float2x3(float)"/>
        public static float2x3 float2x3(float f) => new(f);
        /// <inheritdoc cref="math.float2x2(float)"/>
        public static float2x2 float2x2(float f) => new(f);

        /// <inheritdoc cref="math.float4x4(Mathematics.float4, Mathematics.float4, Mathematics.float4, Mathematics.float4)"/>
        public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) => new(c0, c1, c2, c3);
        /// <inheritdoc cref="math.float4x4(float, float, float, float, float, float, float, float, float, float, float, float, float, float, float, float)"/>
        public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.float3x4(Mathematics.float3, Mathematics.float3, Mathematics.float3, Mathematics.float3)"/>
        public static float4x3 float4x3(float4 c0, float4 c1, float4 c2) => new(c0, c1, c2);
        /// <inheritdoc cref="math.float3x4(float, float, float, float, float, float, float, float, float, float, float, float)"/>
        public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.float4x2(Mathematics.float4, Mathematics.float4)"/>
        public static float4x2 float4x2(float4 c0, float4 c1) => new(c0, c1);
        /// <inheritdoc cref="math.float4x2(float, float, float, float, float, float, float, float)"/>
        public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.float3x4(Mathematics.float3, Mathematics.float3, Mathematics.float3, Mathematics.float3)"/>
        public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3) => new(c0, c1, c2, c3);
        /// <inheritdoc cref="math.float3x4(float, float, float, float, float, float, float, float, float, float, float, float)"/>
        public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.float3x3(Mathematics.float3, Mathematics.float3, Mathematics.float3)"/>
        public static float3x3 float3x3(float3 c0, float3 c1, float3 c2) => new(c0, c1, c2);
        /// <inheritdoc cref="math.float3x3(float, float, float, float, float, float, float, float, float)"/>
        public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.float3x2(Mathematics.float3, Mathematics.float3)"/>
        public static float3x2 float3x2(float3 c0, float3 c1) => new(c0, c1);
        /// <inheritdoc cref="math.float3x2(float, float, float, float, float, float)"/>
        public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.float2x4(Mathematics.float2, Mathematics.float2, Mathematics.float2, Mathematics.float2)"/>
        public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) => new(c0, c1, c2, c3);
        /// <inheritdoc cref="math.float2x4(float, float, float, float, float, float, float, float)"/>
        public static float2x4 float2x4(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.float2x3(Mathematics.float2, Mathematics.float2, Mathematics.float2)"/>
        public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) => new(c0, c1, c2);
        /// <inheritdoc cref="math.float2x3(float, float, float, float, float, float)"/>
        public static float2x3 float2x3(float m00, float m01, float m10, float m11, float m20, float m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.float2x2(Mathematics.float2, Mathematics.float2)"/>
        public static float2x2 float2x2(float2 c0, float2 c1) => new(c0, c1);
        /// <inheritdoc cref="math.float2x2(float, float, float, float)"/>
        public static float2x2 float2x2(float m00, float m01, float m10, float m11)
            => new(m00, m01, m10, m11);
        
    }
}