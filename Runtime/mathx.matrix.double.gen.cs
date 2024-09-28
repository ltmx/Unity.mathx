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

        /// <inheritdoc cref="math.double4x4(double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double4x4 d4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33);

        /// <inheritdoc cref="math.double3x4(double, double, double, double, double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double4x3 d4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32);

        /// <inheritdoc cref="math.double4x2(double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double4x2 d4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.double3x4(double, double, double, double, double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double3x4 d3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
            => new(m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23);

        /// <inheritdoc cref="math.double3x3(double, double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double3x3 d3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
            => new(m00, m01, m02, m10, m11, m12, m20, m21, m22);

        /// <inheritdoc cref="math.double3x2(double, double, double, double, double, double)"/>
        [MI(IL)] public static double3x2 d3x2(double m00, double m01, double m10, double m11, double m20, double m21)
            => new(m00, m01, m10, m11, m20, m21);

        /// <inheritdoc cref="math.double2x4(double, double, double, double, double, double, double, double)"/>
        [MI(IL)] public static double2x4 d2x4(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
            => new(m00, m01, m10, m11, m20, m21, m30, m31);

        /// <inheritdoc cref="math.double2x3(double, double, double, double, double, double)"/>
        [MI(IL)] public static double2x3 d2x3(double m00, double m01, double m10, double m11, double m20, double m21)
            => new(m00, m01, m10, m11, m20, m21);
        
        /// <inheritdoc cref="math.double2x2(double, double, double, double)"/>
        [MI(IL)] public static double2x2 d2x2(double m00, double m01, double m10, double m11)
            => new(m00, m01, m10, m11);
        
        
        #region Matrix Gen
        
        
        
        /// <inheritdoc cref="math.double4x4(double4, double4, double4, double4)"/>
        [MI(IL)] public static double4x4 d4x4(double4 a, double4 b, double4 c, double4 d) => new(a,b,c,d);
        ///<inheritdoc cref="math.double4x3(double4, double4, double4)"/>
        [MI(IL)] public static double4x3 d4x3(double4 a, double4 b, double4 c) => new(a,b,c);
        /// <inheritdoc cref="math.double4x2(double4, double4)"/>
        [MI(IL)] public static double4x2 d4x2(double4 a, double4 b) => new(a,b);
        /// <inheritdoc cref="math.double3x4(double3, double3, double3, double3)"/>
        [MI(IL)] public static double3x4 d3x4(double3 a, double3 b, double3 c, double3 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.double3x3(double3, double3, double3)"/>
        [MI(IL)] public static double3x3 d3x3(double3 a, double3 b, double3 c) => new(a,b,c);
        /// <inheritdoc cref="math.double3x2(double3, double3)"/>
        [MI(IL)] public static double3x2 d3x2(double3 a, double3 b) => new(a,b);
        /// <inheritdoc cref="math.double2x4(double2, double2, double2, double2)"/>
        [MI(IL)] public static double2x4 d2x4(double2 a, double2 b, double2 c, double2 d) => new(a,b,c,d);
        /// <inheritdoc cref="math.double2x3(double2, double2, double2)"/>
        [MI(IL)] public static double2x3 d2x3(double2 a, double2 b, double2 c) => new(a,b,c);
        /// <inheritdoc cref="math.double2x2(double2, double2)"/>
        [MI(IL)] public static double2x2 d2x2(double2 a, double2 b) => new(a,b);
        
        

        /// Creates a matrix with the same value in every row
        [MI(IL)] public static double4x4 d4x4(this double4 f) => new(f, f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double4x3 d4x3(this double4 f) => new(f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double4x2 d4x2(this double4 f) => new(f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double3x4 d3x4(this double3 f) => new(f, f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double3x3 d3x3(this double3 f) => new(f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double3x2 d3x2(this double3 f) => new(f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double2x4 d2x4(this double2 f) => new(f, f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double2x3 d2x3(this double2 f) => new(f, f, f);
        ///<inheritdoc cref="d4x4(double4)"/>
        [MI(IL)] public static double2x2 d2x2(this double2 f) => new(f, f);


        /// <inheritdoc cref="math.double4x4(double)"/>
        [MI(IL)] public static double4x4 d4x4(this double f) => new(f);
        /// <inheritdoc cref="math.double4x3(double)"/>
        [MI(IL)] public static double4x3 d4x3(this double f) => new(f);
        /// <inheritdoc cref="math.double4x2(double)"/>
        [MI(IL)] public static double4x2 d4x2(this double f) => new(f);
        /// <inheritdoc cref="math.double3x4(double)"/>
        [MI(IL)] public static double3x4 d3x4(this double f) => new(f);
        /// <inheritdoc cref="math.double3x3(double)"/>
        [MI(IL)] public static double3x3 d3x3(this double f) => new(f);
        /// <inheritdoc cref="math.double3x2(double)"/>
        [MI(IL)] public static double3x2 d3x2(this double f) => new(f);
        /// <inheritdoc cref="math.double2x4(double)"/>
        [MI(IL)] public static double2x4 d2x4(this double f) => new(f);
        /// <inheritdoc cref="math.double2x3(double)"/>
        [MI(IL)] public static double2x3 d2x3(this double f) => new(f);
        /// <inheritdoc cref="math.double2x2(double)"/>
        [MI(IL)] public static double2x2 d2x2(this double f) => new(f);

        #endregion
        
        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MI(IL)] public static double2x2 d2x2(this double2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x2 d2x2(this double3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x2 d2x2(this double4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x2 d2x2(this double2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x2 d2x2(this double3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x2 d2x2(this double4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x3 d2x3(this double3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x3 d2x3(this double4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x3 d2x3(this double3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x3 d2x3(this double4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x4 d2x4(this double3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double2x4 d2x4(this double4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x2 d3x2(this double3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x2 d3x2(this double4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x2 d3x2(this double3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x2 d3x2(this double4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x3 d3x3(this double4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x3 d3x3(this double3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x3 d3x3(this double4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double3x4 d3x4(this double4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double4x2 d4x2(this double4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double4x2 d4x2(this double4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="d2x2(double2x3)"/>
        [MI(IL)] public static double4x3 d4x3(this double4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion
        
    }
}