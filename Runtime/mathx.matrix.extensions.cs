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
        
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float2 mul(this float2x2 matrix, float2 f) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float3x3 matrix, float3 f) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float4 mul(this float4x4 matrix, float4 f) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float2 mul(this float2 f, float2x2 matrix) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float3 f, float3x3 matrix) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float4 mul(this float4 f, float4x4 matrix) => math.mul(matrix, f);
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float3 f, float3x4 m) => m[0] * f.x + m[1] * f.y + m[2] * f.z + m[3];
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float3x4 m, float3 f) => m[0] * f.x + m[1] * f.y + m[2] * f.z + m[3];
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float4 f, float3x4 m) => m[0] * f.x + m[1] * f.y + m[2] * f.z + m[3] * f.w;
        /// Performs a matrix multiplication of the form: m * f
        [MI(IL)] public static float3 mul(this float3x4 m, float4 f) => m[0] * f.x + m[1] * f.y + m[2] * f.z + m[3] * f.w;
        
        // truncated Matrices
        
        /// Performs a matrix multiplication of the form: m * f (omits the last column of the matrix)
        [MI(IL)] public static float3 mul(this float4x4 m, float3 f) => m[0].xyz * f.x + m[1].xyz * f.y + m[2].xyz * f.z + m[3].xyz;
        
        /// Performs a matrix multiplication of the form: m * f (omits the last column of the matrix)
        [MI(IL)] public static float3 mul(this float3 f, float4x4 m) => m[0].xyz * f.x + m[1].xyz * f.y + m[2].xyz * f.z + m[3].xyz;
        
        
        
        
        
        // float4xN --------------------------------------------------

        /// Performs a dot product between the vectors of the matrices and returns the result as a vector.
        [MI(IL)] public static float4 dot(this float4x4 m1, float4x4 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2), m1.c3.dot(m2.c3));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)]
        static float4 dot(this float4x4 m1, float4 f) => new(m1.c0.dot(f), m1.c1.dot(f), m1.c2.dot(f), m1.c3.dot(f));
        /// <inheritdoc cref="mathx.dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float4x3 m1, float4x3 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float4x3 m1, float4 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2), m1.c2.dot(m2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float2 dot(this float4x2 m1, float4x2 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float2 dot(this float4x2 m1, float4 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2));
        
        
        /// Returns the squared length of each vector in the matrix.
        [MI(IL)] public static float4 lengthsq(this float4x4 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq(), m1.c3.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float3 lengthsq(this float4x3 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float2 lengthsq(this float4x2 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq());

        
        // float3xN --------------------------------------------------
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float4 dot(this float3x4 m1, float3x4 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2), m1.c3.dot(m2.c3));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float4 dot(this float3x4 m1, float3 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2), m1.c2.dot(m2), m1.c3.dot(m2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float3x3 m1, float3x3 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float3x3 m1, float3 f) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq());
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float2 dot(this float3x2 m1, float3x2 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float2 dot(this float3x2 m1, float3 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2));
        
        /// Returns the squared length of each vector in the matrix.
        [MI(IL)] public static float4 lengthsq(this float3x4 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq(), m1.c3.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float3 lengthsq(this float3x3 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float2 lengthsq(this float3x2 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq());

        
        // float2xN --------------------------------------------------
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float4 dot(this float2x4 m1, float2x4 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2), m1.c3.dot(m2.c3));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float4 dot(this float2x4 m1, float2 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2), m1.c2.dot(m2), dot(m1.c3, m2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float2x3 m1, float2x3 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1), m1.c2.dot(m2.c2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float3 dot(this float2x3 m1, float2 m2) => new(m1.c0.dot(m2), m1.c1.dot(m2), m1.c2.dot(m2));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        [MI(IL)] public static float2 dot(this float2x2 m1, float2x2 m2) => new(m1.c0.dot(m2.c0), m1.c1.dot(m2.c1));
        /// <inheritdoc cref="dot(float4x4,float4x4)" />
        public static float2 dot(this float2x2 m1, float2 f) => new(m1.c0.dot(f), m1.c1.dot(f));
        
        /// Returns the squared length of each vector in the matrix.
        [MI(IL)] public static float4 lengthsq(this float2x4 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq(), m1.c3.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float3 lengthsq(this float2x3 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq(), m1.c2.lengthsq());
        /// <inheritdoc cref="lengthsq(float4x4)" />
        [MI(IL)] public static float2 lengthsq(this float2x2 m1) => new(m1.c0.lengthsq(), m1.c1.lengthsq());

        
        /// Subtracts a vector to each component of a matrix
        [MI(IL)] public static float4x4 sub(this float4x4 m1, float4 f) => new(m1.c0 - f.x, m1.c1 - f.y, m1.c2 - f.z, m1.c3 - f.w);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float4x3 sub(this float4x3 m1, float4 f) => new(m1.c0 - f.x, m1.c1 - f.y, m1.c2 - f.z);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float4x2 sub(this float4x2 m1, float4 f) => new(m1.c0 - f.x, m1.c1 - f.y);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float3x4 sub(this float3x4 m1, float3 f) => new (m1.c0 - f.x, m1.c1 - f.y, m1.c2 - f.z, m1.c3);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float3x3 sub(this float3x3 m1, float3 f) => new(m1.c0 - f.x, m1.c1 - f.y, m1.c2 - f.z);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float3x2 sub(this float3x2 m1, float3 f) => new(m1.c0 - f.x, m1.c1 - f.y);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float2x4 sub(this float2x4 m1, float2 f) => new (m1.c0 - f.x, m1.c1 - f.y, m1.c2, m1.c3);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float2x3 sub(this float2x3 m1, float2 f) => new (m1.c0 - f.x, m1.c1 - f.y, m1.c2);
        /// <inheritdoc cref="sub(float4x4,float4)" />
        [MI(IL)] public static float2x2 sub(this float2x2 m1, float2 f) => new(m1.c0 - f.x, m1.c1 - f.y);

        
        /// Adds a vector to each component of a matrix
        [MI(IL)] public static float4x4 add(this float4x4 m1, float4 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2 + f.z, m1.c3 + f.w);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float4x3 add(this float4x3 m1, float4 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2 + f.z);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float4x2 add(this float4x2 m1, float4 f) => new(m1.c0 + f.x, m1.c1 + f.y);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float3x4 add(this float3x4 m1, float3 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2 + f.z, m1.c3);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float3x3 add(this float3x3 m1, float3 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2 + f.z);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float3x2 add(this float3x2 m1, float3 f) => new(m1.c0 + f.x, m1.c1 + f.y);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float2x4 add(this float2x4 m1, float2 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2, m1.c3);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float2x3 add(this float2x3 m1, float2 f) => new(m1.c0 + f.x, m1.c1 + f.y, m1.c2);
        /// <inheritdoc cref="add(float4x4,float4)" />
        [MI(IL)] public static float2x2 add(this float2x2 m1, float2 f) => new(m1.c0 + f.x, m1.c1 + f.y);
        
        
        /// Multiplies a vector to each component of a matrix
        [MI(IL)] public static float4x4 mult(this float4x4 m1, float4 f) => new(m1.c0 * f.x, m1.c1 * f.y, m1.c2 * f.z, m1.c3 * f.w);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float4x3 mult(this float4x3 m1, float4 f) => new(m1.c0 * f.x, m1.c1 * f.y, m1.c2 * f.z);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float4x2 mult(this float4x2 m1, float4 f) => new(m1.c0 * f.x, m1.c1 * f.y);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float3x4 mult(this float3x4 m1, float3 f) => new (m1.c0 * f.x, m1.c1 * f.y, m1.c2 * f.z, m1.c3);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float3x3 mult(this float3x3 m1, float3 f) => new(m1.c0 * f.x, m1.c1 * f.y, m1.c2 * f.z);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float3x2 mult(this float3x2 m1, float3 f) => new(m1.c0 * f.x, m1.c1 * f.y);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float2x4 mult(this float2x4 m1, float2 f) => new (m1.c0 * f.x, m1.c1 * f.y, m1.c2, m1.c3);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float2x3 mult(this float2x3 m1, float2 f) => new (m1.c0 * f.x, m1.c1 * f.y, m1.c2);
        /// <inheritdoc cref="mult(float4x4,float4)" />
        [MI(IL)] public static float2x2 mult(this float2x2 m1, float2 f) => new(m1.c0 * f.x, m1.c1 * f.y);
        

        /// Divides a vector to each component of a matrix
        [MI(IL)] public static float4x4 div(this float4x4 m1, float4 f) => new(m1.c0 / f.x, m1.c1 / f.y, m1.c2 / f.z, m1.c3 / f.w);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float4x3 div(this float4x3 m1, float4 f) => new(m1.c0 / f.x, m1.c1 / f.y, m1.c2 / f.z);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float4x2 div(this float4x2 m1, float4 f) => new(m1.c0 / f.x, m1.c1 / f.y);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float3x4 div(this float3x4 m1, float3 f) => new (m1.c0 / f.x, m1.c1 / f.y, m1.c2 / f.z, m1.c3);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float3x3 div(this float3x3 m1, float3 f) => new(m1.c0 / f.x, m1.c1 / f.y, m1.c2 / f.z);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float3x2 div(this float3x2 m1, float3 f) => new(m1.c0 / f.x, m1.c1 / f.y);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float2x4 div(this float2x4 m1, float2 f) => new (m1.c0 / f.x, m1.c1 / f.y, m1.c2, m1.c3);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float2x3 div(this float2x3 m1, float2 f) => new (m1.c0 / f.x, m1.c1 / f.y, m1.c2);
        /// <inheritdoc cref="div(float4x4,float4)" />
        [MI(IL)] public static float2x2 div(this float2x2 m1, float2 f) => new(m1.c0 / f.x, m1.c1 / f.y);
        
        
        
        /// returns the negated value of a matrix
        [MI(IL)] public static float4x4 neg(this float4x4 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float4x3 neg(this float4x3 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float4x2 neg(this float4x2 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float3x4 neg(this float3x4 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float3x3 neg(this float3x3 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float3x2 neg(this float3x2 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float2x4 neg(this float2x4 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float2x3 neg(this float2x3 m1) => -m1;
        /// <inheritdoc cref="neg(float4x4)" />
        [MI(IL)] public static float2x2 neg(this float2x2 m1) => -m1;
        
        
        /// Returns the transposed value of a matrix
        [MI(IL)] public static float4x4 transpose(this float4x4 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float3x4 transpose(this float4x3 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float2x4 transpose(this float4x2 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float4x3 transpose(this float3x4 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float3x3 transpose(this float3x3 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float2x3 transpose(this float3x2 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float4x2 transpose(this float2x4 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float3x2 transpose(this float2x3 m1) => math.transpose(m1);
        /// <inheritdoc cref="transpose(float4x4)" />
        [MI(IL)] public static float2x2 transpose(this float2x2 m1) => math.transpose(m1);
        
        /// Creates a 2x2 matrix with the scale vector as the diagonal elements. The remaining spots zeros
        [MI(IL)] public static float2x2 diag(this float2 scale) => new(scale.x, 0, 0, scale.y);
        /// Creates a 3x3 matrix with the scale vector as the diagonal elements. The remaining spots zeros
        [MI(IL)] public static float3x3 diag(this float3 scale) => new(scale.x, 0, 0, 0, scale.y, 0, 0, 0, scale.z);
        /// Creates a 4x4 matrix with the scale vector as the diagonal elements. The remaining spots zeros
        [MI(IL)] public static float4x4 diag(this float4 scale) => new(scale.x, 0, 0, 0, 0, scale.y, 0, 0,  0, 0, scale.z, 0, 0, 0, 0, scale.w);
    }
}