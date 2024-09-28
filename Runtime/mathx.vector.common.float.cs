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

        /// <inheritdoc cref="math.normalize(float2)"/>
        [MI(IL)] public static float4 norm(this float4 f) => math.normalize(f);
        /// <inheritdoc cref="math.normalize(float3)"/>
        [MI(IL)] public static float3 norm(this float3 f) => math.normalize(f);
        /// <inheritdoc cref="math.normalize(float2)"/>
        [MI(IL)] public static float2 norm(this float2 f) => math.normalize(f);

        /// <inheritdoc cref="math.normalizesafe(float2,float2)"/>
        [MI(IL)] public static float4 normsafe(this float4 f, float4 d = default) => math.normalizesafe(f, d);
        /// <inheritdoc cref="math.normalizesafe(float3,float3)"/>
        [MI(IL)] public static float3 normsafe(this float3 f, float3 d = default) => math.normalizesafe(f, d);
        /// <inheritdoc cref="math.normalizesafe(float2,float2)"/>
        [MI(IL)] public static float2 normsafe(this float2 f, float2 d = default) => math.normalizesafe(f, d);
        
        /// <inheritdoc cref="math.distance(float2,float2)"/>
        [MI(IL)] public static float distance(this float2 f, float2 f2) => math.distance(f, f2);
        /// <inheritdoc cref="math.distance(float3,float3)"/>
        [MI(IL)] public static float distance(this float3 f, float3 f2) => math.distance(f, f2);
        /// <inheritdoc cref="math.distance(float4,float4)"/>
        [MI(IL)] public static float distance(this float4 f, float4 f2) => math.distance(f, f2);
        
        /// <inheritdoc cref="math.distancesq(float2,float2)"/>
        [MI(IL)] public static float distancesq(this float2 f, float2 f2) => math.distancesq(f, f2);
        /// <inheritdoc cref="math.distancesq(float3,float3)"/>
        [MI(IL)] public static float distancesq(this float3 f, float3 f2) => math.distancesq(f, f2);
        /// <inheritdoc cref="math.distancesq(float4,float4)"/>
        [MI(IL)] public static float distancesq(this float4 f, float4 f2) => math.distancesq(f, f2);

        /// <inheritdoc cref="math.length(float4)"/>
        [MI(IL)] public static float length(this float4 f) => math.length(f);
        /// <inheritdoc cref="math.length(float3)"/>
        [MI(IL)] public static float length(this float3 f) => math.length(f);
        /// <inheritdoc cref="math.length(float2)"/>
        [MI(IL)] public static float length(this float2 f) => math.length(f);
        

        /// <inheritdoc cref="math.lengthsq(float4)"/>
        [MI(IL)] public static float lengthsq(this float4 f) => math.lengthsq(f);
        /// <inheritdoc cref="math.lengthsq(float3)"/>
        [MI(IL)] public static float lengthsq(this float3 f) => math.lengthsq(f);
        /// <inheritdoc cref="math.lengthsq(float2)"/>
        [MI(IL)] public static float lengthsq(this float2 f) => math.lengthsq(f);


        /// <inheritdoc cref="dot(float4,float4)"/>
        [MI(IL)] public static float dot(this float4 f, float4 f2) => math.dot(f, f2);
        /// <inheritdoc cref="dot(float4,float4)"/>
        [MI(IL)] public static float dot(this float3 f, float3 f2) => math.dot(f, f2);
        /// <inheritdoc cref="dot(float4,float4)"/>
        [MI(IL)] public static float dot(this float2 f, float2 f2) => math.dot(f, f2);
        

        /// <inheritdoc cref="math.reflect(float4,float4)"/>
        [MI(IL)] public static float4 reflect(this float4 f, float4 n) => math.reflect(f, n);
        /// <inheritdoc cref="math.reflect(float3,float3)"/>
        [MI(IL)] public static float3 reflect(this float3 f, float3 n) => math.reflect(f, n);
        /// <inheritdoc cref="math.reflect(float2,float2)"/>
        [MI(IL)] public static float2 reflect(this float2 f, float2 n) => math.reflect(f, n);
        
        
        /// <inheritdoc cref="math.refract(float2,float2,float)"/>
        [MI(IL)] public static float2 refract(this float2 f, float2 f2, float eta) => math.refract(f, f2, eta);
        /// <inheritdoc cref="math.refract(float3,float3,float)"/>
        [MI(IL)] public static float3 refract(this float3 f, float3 f2, float eta) => math.refract(f, f2, eta);
        /// <inheritdoc cref="math.refract(float4,float4,float)"/>
        [MI(IL)] public static float4 refract(this float4 f, float4 f2, float eta) => math.refract(f, f2, eta);

        /// <inheritdoc cref="math.project(float4,float4)"/>
        [MI(IL)] public static float4 project(this float4 f, float4 n) => math.project(f, n);
        /// <inheritdoc cref="math.project(float3,float3)"/>
        [MI(IL)] public static float3 project(this float3 f, float3 n) => math.project(f, n);
        /// <inheritdoc cref="math.project(float2,float2)"/>
        [MI(IL)] public static float2 project(this float2 f, float2 n) => math.project(f, n);
        
        /// <inheritdoc cref="math.projectsafe(float4,float4,float4)"/>
        [MI(IL)] public static float4 projectsafe(this float4 f, float4 n, float4 defaultValue = default) => math.projectsafe(f, n, defaultValue);
        /// <inheritdoc cref="math.projectsafe(float3,float3,float3)"/>
        [MI(IL)] public static float3 projectsafe(this float3 f, float3 n, float3 defaultValue = default) => math.projectsafe(f, n, defaultValue);
        /// <inheritdoc cref="math.projectsafe(float2,float2,float2)"/>
        [MI(IL)] public static float2 projectsafe(this float2 f, float2 n, float2 defaultValue = default) => math.projectsafe(f, n, defaultValue);

        
        /// Returns the Manhattan distance between two vectors
        /// <remarks>Manhattan distance is the sum of the absolute differences of the components</remarks>
        /// <see href="https://simple.wikipedia.org/wiki/Manhattan_Distance"/>
        [MI(IL)] public static float manhattan(this float4 a, float4 b) => (a-b).abs().csum();
        /// <inheritdoc cref="manhattan(float4,float4)"/>
        [MI(IL)] public static float manhattan(this float3 a, float3 b) => (a-b).abs().csum();
        /// <inheritdoc cref="manhattan(float4,float4)"/>
        [MI(IL)] public static float manhattan(this float2 a, float2 b) => (a-b).abs().csum();
        /// <inheritdoc cref="manhattan(float4,float4)"/>
        [MI(IL)] public static float manhattan(this float a, float b) => (a - b).abs();
        
        /// Returns the Minkowski distance between two vectors
        /// <remarks>Minkowski distance is the generalized version of the Manhattan and Euclidean distances</remarks>
        /// <see href="https://en.wikipedia.org/wiki/Minkowski_distance"/>
        [MI(IL)] public static float minkowski(this float4 a, float4 b, float p) => (a - b).abs().pow(p).csum().pow(1 / p);
        /// <inheritdoc cref="minkowski(float4,float4,float)"/>
        [MI(IL)] public static float minkowski(this float3 a, float3 b, float p) => (a - b).abs().pow(p).csum().pow(1 / p);
        /// <inheritdoc cref="minkowski(float4,float4,float)"/>
        [MI(IL)] public static float minkowski(this float2 a, float2 b, float p) => (a - b).abs().pow(p).csum().pow(1 / p);
        /// <inheritdoc cref="minkowski(float4,float4,float)"/>
        [MI(IL)] public static float minkowski(this float a, float b) => (a - b).abs();

        /// Returns the Chebyshev distance between two vectors
        /// <remarks>Also known as the Chessboard distance</remarks>
        /// <see href="wikipedia"/>https://en.wikipedia.org/wiki/Chebyshev_distance
        [MI(IL)] public static float chebyshev(this float4 a, float4 b) => (a - b).acmax();
        /// <inheritdoc cref="chebyshev(float4,float4)"/>
        [MI(IL)] public static float chebyshev(this float3 a, float3 b) => (a - b).acmax();
        /// <inheritdoc cref="chebyshev(float4,float4)"/>
        [MI(IL)] public static float chebyshev(this float2 a, float2 b) => (a - b).acmax();
        /// <inheritdoc cref="chebyshev(float4,float4)"/>
        [MI(IL)] public static float chebyshev(this float a, float b) => (a - b).abs();



        #region Single Purpose Functions

        ///<inheritdoc cref="math.cross(float3,float3)"/>
        [MI(IL)] public static float3 cross(this float3 f, float3 f2) => math.cross(f, f2);
        
        /// returns a vector perpendicular to the input vector
        [MI(IL)] public static float2 perp(this float2 f) => new(-f.y, f.x);
        
        /// Returns the exterior product of two vectors. its magnitude is the area of the parallelogram they span.
        /// note: this is not the cross product
        [MI(IL)] public static float3 exterior(this float3 a, float3 b) => a.yzx * b.zxy - a.zxy * b.yzx;

        /// orthonormalize
        [MI(IL)] public static float3 orthonorm(ref float3 normal, float3 tangent) => tangent - tangent.projectsafe(normal.norm());
        
        #endregion

        #region Matrix Operations

        ///Returns the distance the two vectors in the matrix
        [MI(IL)] public static float cdistance(this float2x2 f) => math.distance(f.c0, f.c1);
        [MI(IL)] public static float cdistance(this float3x2 f) => math.distance(f.c0, f.c1);
        [MI(IL)] public static float cdistance(this float4x2 f) => math.distance(f.c0, f.c1);
        
        ///Returns the squared distance the two vectors in the matrix
        [MI(IL)] public static float cdistancesq(this float2x2 f) => math.distancesq(f.c0, f.c1);
        [MI(IL)] public static float cdistancesq(this float3x2 f) => math.distancesq(f.c0, f.c1);
        [MI(IL)] public static float cdistancesq(this float4x2 f) => math.distancesq(f.c0, f.c1);
        
        
        ///Returns the cross product of the two vectors in the matrix
        [MI(IL)] public static float3 ccross(this float3x2 f) => math.cross(f.c0, f.c1);
        
        ///Returns the dot product of the two vectors in the matrix
        [MI(IL)] public static float cdot(this float4x2 f) => math.dot(f.c0, f.c1);
        /// <inheritdoc cref="cdot(float4x2)"/>
        [MI(IL)] public static float cdot(this float3x2 f) => math.dot(f.c0, f.c1);
        ///Returns the dot product of the two vectors in the matrix
        [MI(IL)] public static float cdot(this float2x2 f) => math.dot(f.c0, f.c1);

        #endregion
    
        
    
    }
}