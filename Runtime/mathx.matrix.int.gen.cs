#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public static partial class mathx
    {

        /// <inheritdoc cref="math.int4x4(int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int4x4 i4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.int3x4(int, int, int, int, int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int4x3 i4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.int4x2(int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int4x2 i4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.int3x4(int, int, int, int, int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int3x4 i3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.int3x3(int, int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int3x3 i3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.int3x2(int, int, int, int, int, int)"/>
        [MI(IL)] public static int3x2 i3x2(int m00, int m01, int m10, int m11, int m20, int m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.int2x4(int, int, int, int, int, int, int, int)"/>
        [MI(IL)] public static int2x4 i2x4(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.int2x3(int, int, int, int, int, int)"/>
        [MI(IL)] public static int2x3 i2x3(int m00, int m01, int m10, int m11, int m20, int m21)
            => new(m00, m01, m10, m11, m20, m21);
        
        /// <inheritdoc cref="math.int2x2(int, int, int, int)"/>
        [MI(IL)] public static int2x2 i2x2(int m00, int m01, int m10, int m11)
            => new(m00, m01, m10, m11);
        
        
        #region Matrix Gen
        
        
        
        /// <inheritdoc cref="math.int4x4(int4, int4, int4, int4)"/>
        [MI(IL)] public static int4x4 i4x4(int4 a, int4 b, int4 c, int4 d) => new(a,b,c,d);
        ///<inheritdoc cref="math.int4x3(int4, int4, int4)"/>
        [MI(IL)] public static int4x3 i4x3(int4 a, int4 b, int4 c) => new(a,b,c);
        /// <inheritdoc cref="math.int4x2(int4, int4)"/>
        [MI(IL)] public static int4x2 i4x2(int4 a, int4 b) => new(a,b);
        /// <inheritdoc cref="math.int3x4(int3, int3, int3, int3)"/>
        [MI(IL)] public static int3x4 i3x4(int3 a, int3 b, int3 c, int3 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.int3x3(int3, int3, int3)"/>
        [MI(IL)] public static int3x3 i3x3(int3 a, int3 b, int3 c) => new(a,b,c);
        /// <inheritdoc cref="math.int3x2(int3, int3)"/>
        [MI(IL)] public static int3x2 i3x2(int3 a, int3 b) => new(a,b);
        /// <inheritdoc cref="math.int2x4(int2, int2, int2, int2)"/>
        [MI(IL)] public static int2x4 i2x4(int2 a, int2 b, int2 c, int2 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.int2x3(int2, int2, int2)"/>
        [MI(IL)] public static int2x3 i2x3(int2 a, int2 b, int2 c) => new(a,b,c);
        /// <inheritdoc cref="math.int2x2(int2, int2)"/>
        [MI(IL)] public static int2x2 i2x2(int2 a, int2 b) => new(a,b);
        
        

        /// Creates a matrix with the same value in every row
        [MI(IL)] public static int4x4 i4x4(this int4 f) => new(f, f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int4x3 i4x3(this int4 f) => new(f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int4x2 i4x2(this int4 f) => new(f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int3x4 i3x4(this int3 f) => new(f, f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int3x3 i3x3(this int3 f) => new(f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int3x2 i3x2(this int3 f) => new(f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int2x4 i2x4(this int2 f) => new(f, f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int2x3 i2x3(this int2 f) => new(f, f, f);
        ///<inheritdoc cref="i4x4(int4)"/>
        [MI(IL)] public static int2x2 i2x2(this int2 f) => new(f, f);


        /// <inheritdoc cref="math.int4x4(int)"/>
        [MI(IL)] public static int4x4 i4x4(this int f) => new(f);
        /// <inheritdoc cref="math.int4x3(int)"/>
        [MI(IL)] public static int4x3 i4x3(this int f) => new(f);
        /// <inheritdoc cref="math.int4x2(int)"/>
        [MI(IL)] public static int4x2 i4x2(this int f) => new(f);
        /// <inheritdoc cref="math.int3x4(int)"/>
        [MI(IL)] public static int3x4 i3x4(this int f) => new(f);
        /// <inheritdoc cref="math.int3x3(int)"/>
        [MI(IL)] public static int3x3 i3x3(this int f) => new(f);
        /// <inheritdoc cref="math.int3x2(int)"/>
        [MI(IL)] public static int3x2 i3x2(this int f) => new(f);
        /// <inheritdoc cref="math.int2x4(int)"/>
        [MI(IL)] public static int2x4 i2x4(this int f) => new(f);
        /// <inheritdoc cref="math.int2x3(int)"/>
        [MI(IL)] public static int2x3 i2x3(this int f) => new(f);
        /// <inheritdoc cref="math.int2x2(int)"/>
        [MI(IL)] public static int2x2 i2x2(this int f) => new(f);

        #endregion
        
        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MI(IL)] public static int2x2 i2x2(this int2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x2 i2x2(this int3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x2 i2x2(this int4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x2 i2x2(this int2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x2 i2x2(this int3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x2 i2x2(this int4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x3 i2x3(this int3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x3 i2x3(this int4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x3 i2x3(this int3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x3 i2x3(this int4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x4 i2x4(this int3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int2x4 i2x4(this int4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x2 i3x2(this int3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x2 i3x2(this int4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x2 i3x2(this int3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x2 i3x2(this int4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x3 i3x3(this int4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x3 i3x3(this int3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x3 i3x3(this int4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int3x4 i3x4(this int4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int4x2 i4x2(this int4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int4x2 i4x2(this int4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="i2x2(int2x3)"/>
        [MI(IL)] public static int4x3 i4x3(this int4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion
        
    }
}