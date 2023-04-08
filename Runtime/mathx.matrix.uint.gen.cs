#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {

        /// <inheritdoc cref="math.uint4x4(uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint4x4 u4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.uint3x4(uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.uint4x2(uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.uint3x4(uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.uint3x3(uint, uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.uint3x2(uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.uint2x4(uint, uint, uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.uint2x3(uint, uint, uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
            => new(m00, m01, m10, m11, m20, m21);
        
        /// <inheritdoc cref="math.uint2x2(uint, uint, uint, uint)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(uint m00, uint m01, uint m10, uint m11)
            => new(m00, m01, m10, m11);
        
        
        #region Matrix Gen
        
        
        
        /// <inheritdoc cref="math.uint4x4(uint4, uint4, uint4, uint4)"/>
        [MethodImpl(IL)] public static uint4x4 u4x4(uint4 a, uint4 b, uint4 c, uint4 d) => new(a,b,c,d);
        ///<inheritdoc cref="math.uint4x3(uint4, uint4, uint4)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(uint4 a, uint4 b, uint4 c) => new(a,b,c);
        /// <inheritdoc cref="math.uint4x2(uint4, uint4)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(uint4 a, uint4 b) => new(a,b);
        /// <inheritdoc cref="math.uint3x4(uint3, uint3, uint3, uint3)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(uint3 a, uint3 b, uint3 c, uint3 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.uint3x3(uint3, uint3, uint3)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(uint3 a, uint3 b, uint3 c) => new(a,b,c);
        /// <inheritdoc cref="math.uint3x2(uint3, uint3)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(uint3 a, uint3 b) => new(a,b);
        /// <inheritdoc cref="math.uint2x4(uint2, uint2, uint2, uint2)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(uint2 a, uint2 b, uint2 c, uint2 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.uint2x3(uint2, uint2, uint2)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(uint2 a, uint2 b, uint2 c) => new(a,b,c);
        /// <inheritdoc cref="math.uint2x2(uint2, uint2)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(uint2 a, uint2 b) => new(a,b);
        
        

        /// Creates a matrix with the same value in every row
        [MethodImpl(IL)] public static uint4x4 u4x4(this uint4 f) => new(f, f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(this uint4 f) => new(f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(this uint4 f) => new(f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(this uint3 f) => new(f, f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint3 f) => new(f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint3 f) => new(f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(this uint2 f) => new(f, f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint2 f) => new(f, f, f);
        ///<inheritdoc cref="u4x4(uint4)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint2 f) => new(f, f);


        /// <inheritdoc cref="math.uint4x4(uint)"/>
        [MethodImpl(IL)] public static uint4x4 u4x4(this uint f) => new(f);
        /// <inheritdoc cref="math.uint4x3(uint)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(this uint f) => new(f);
        /// <inheritdoc cref="math.uint4x2(uint)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(this uint f) => new(f);
        /// <inheritdoc cref="math.uint3x4(uint)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(this uint f) => new(f);
        /// <inheritdoc cref="math.uint3x3(uint)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint f) => new(f);
        /// <inheritdoc cref="math.uint3x2(uint)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint f) => new(f);
        /// <inheritdoc cref="math.uint2x4(uint)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(this uint f) => new(f);
        /// <inheritdoc cref="math.uint2x3(uint)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint f) => new(f);
        /// <inheritdoc cref="math.uint2x2(uint)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint f) => new(f);

        #endregion
        
        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(this uint3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(this uint4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(this uint4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(this uint4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(this uint4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="u2x2(uint2x3)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(this uint4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion
        
    }
}