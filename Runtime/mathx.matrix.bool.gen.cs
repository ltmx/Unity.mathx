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

        /// <inheritdoc cref="math.bool4x4(bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool4x4 b4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.bool3x4(bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool4x3 b4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.bool4x2(bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool4x2 b4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.bool3x4(bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool3x4 b3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.bool3x3(bool, bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool3x3 b3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.bool3x2(bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool3x2 b3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.bool2x4(bool, bool, bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool2x4 b2x4(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.bool2x3(bool, bool, bool, bool, bool, bool)"/>
        [MI(IL)] public static bool2x3 b2x3(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21)
            => new(m00, m01, m10, m11, m20, m21);
        
        /// <inheritdoc cref="math.bool2x2(bool, bool, bool, bool)"/>
        [MI(IL)] public static bool2x2 b2x2(bool m00, bool m01, bool m10, bool m11)
            => new(m00, m01, m10, m11);
        
        
        #region Matrix Gen
        
        
        
        /// <inheritdoc cref="math.bool4x4(bool4, bool4, bool4, bool4)"/>
        [MI(IL)] public static bool4x4 b4x4(bool4 a, bool4 b, bool4 c, bool4 d) => new(a,b,c,d);
        ///<inheritdoc cref="math.bool4x3(bool4, bool4, bool4)"/>
        [MI(IL)] public static bool4x3 b4x3(bool4 a, bool4 b, bool4 c) => new(a,b,c);
        /// <inheritdoc cref="math.bool4x2(bool4, bool4)"/>
        [MI(IL)] public static bool4x2 b4x2(bool4 a, bool4 b) => new(a,b);
        /// <inheritdoc cref="math.bool3x4(bool3, bool3, bool3, bool3)"/>
        [MI(IL)] public static bool3x4 b3x4(bool3 a, bool3 b, bool3 c, bool3 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.bool3x3(bool3, bool3, bool3)"/>
        [MI(IL)] public static bool3x3 b3x3(bool3 a, bool3 b, bool3 c) => new(a,b,c);
        /// <inheritdoc cref="math.bool3x2(bool3, bool3)"/>
        [MI(IL)] public static bool3x2 b3x2(bool3 a, bool3 b) => new(a,b);
        /// <inheritdoc cref="math.bool2x4(bool2, bool2, bool2, bool2)"/>
        [MI(IL)] public static bool2x4 b2x4(bool2 a, bool2 b, bool2 c, bool2 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.bool2x3(bool2, bool2, bool2)"/>
        [MI(IL)] public static bool2x3 b2x3(bool2 a, bool2 b, bool2 c) => new(a,b,c);
        /// <inheritdoc cref="math.bool2x2(bool2, bool2)"/>
        [MI(IL)] public static bool2x2 b2x2(bool2 a, bool2 b) => new(a,b);
        
        

        /// Creates a matrix with the same value in every row
        [MI(IL)] public static bool4x4 b4x4(this bool4 f) => new(f, f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool4x3 b4x3(this bool4 f) => new(f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool4x2 b4x2(this bool4 f) => new(f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool3x4 b3x4(this bool3 f) => new(f, f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool3x3 b3x3(this bool3 f) => new(f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool3 f) => new(f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool2x4 b2x4(this bool2 f) => new(f, f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool2 f) => new(f, f, f);
        ///<inheritdoc cref="b4x4(bool4)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool2 f) => new(f, f);


        /// <inheritdoc cref="math.bool4x4(bool)"/>
        [MI(IL)] public static bool4x4 b4x4(this bool f) => new(f);
        /// <inheritdoc cref="math.bool4x3(bool)"/>
        [MI(IL)] public static bool4x3 b4x3(this bool f) => new(f);
        /// <inheritdoc cref="math.bool4x2(bool)"/>
        [MI(IL)] public static bool4x2 b4x2(this bool f) => new(f);
        /// <inheritdoc cref="math.bool3x4(bool)"/>
        [MI(IL)] public static bool3x4 b3x4(this bool f) => new(f);
        /// <inheritdoc cref="math.bool3x3(bool)"/>
        [MI(IL)] public static bool3x3 b3x3(this bool f) => new(f);
        /// <inheritdoc cref="math.bool3x2(bool)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool f) => new(f);
        /// <inheritdoc cref="math.bool2x4(bool)"/>
        [MI(IL)] public static bool2x4 b2x4(this bool f) => new(f);
        /// <inheritdoc cref="math.bool2x3(bool)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool f) => new(f);
        /// <inheritdoc cref="math.bool2x2(bool)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool f) => new(f);

        #endregion
        
        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MI(IL)] public static bool2x2 b2x2(this bool2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x2 b2x2(this bool4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x3 b2x3(this bool4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x4 b2x4(this bool3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool2x4 b2x4(this bool4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x2 b3x2(this bool4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x3 b3x3(this bool4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x3 b3x3(this bool3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x3 b3x3(this bool4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool3x4 b3x4(this bool4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool4x2 b4x2(this bool4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool4x2 b4x2(this bool4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="b2x2(bool2x3)"/>
        [MI(IL)] public static bool4x3 b4x3(this bool4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion
        
    }
}