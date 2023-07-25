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

        /// <inheritdoc cref="math.normalize(float4)"/>
        [MethodImpl(IL)] public static float4 norm(this int4 f) => math.normalize(f);
        /// <inheritdoc cref="math.normalize(float3)"/>
        [MethodImpl(IL)] public static float3 norm(this int3 f) => math.normalize(f);
        /// <inheritdoc cref="math.normalize(float2)"/>
        [MethodImpl(IL)] public static float2 norm(this int2 f) => math.normalize(f);

        /// <inheritdoc cref="math.normalizesafe(float2,float2)"/>
        [MethodImpl(IL)] public static float4 normsafe(this int4 f, int4 d = default) => math.normalizesafe(f, d);
        /// <inheritdoc cref="math.normalizesafe(int3,int3)"/>
        [MethodImpl(IL)] public static float3 normsafe(this int3 f, int3 d = default) => math.normalizesafe(f, d);
        /// <inheritdoc cref="math.normalizesafe(float2,float2)"/>
        [MethodImpl(IL)] public static float2 normsafe(this int2 f, int2 d = default) => math.normalizesafe(f, d);
        
        /// <inheritdoc cref="math.distance(int2,int2)"/>
        [MethodImpl(IL)] public static float distance(this int2 f, int2 f2) => math.distance(f, f2);
        /// <inheritdoc cref="math.distance(int3,int3)"/>
        [MethodImpl(IL)] public static float distance(this int3 f, int3 f2) => math.distance(f, f2);
        /// <inheritdoc cref="math.distance(int4,int4)"/>
        [MethodImpl(IL)] public static float distance(this int4 f, int4 f2) => math.distance(f, f2);
        
        /// <inheritdoc cref="math.distancesq(int2,int2)"/>
        [MethodImpl(IL)] public static float distancesq(this int2 f, int2 f2) => math.distancesq(f, f2);
        /// <inheritdoc cref="math.distancesq(int3,int3)"/>
        [MethodImpl(IL)] public static float distancesq(this int3 f, int3 f2) => math.distancesq(f, f2);
        /// <inheritdoc cref="math.distancesq(int4,int4)"/>
        [MethodImpl(IL)] public static float distancesq(this int4 f, int4 f2) => math.distancesq(f, f2);

        
        /// <inheritdoc cref="math.length(int4)"/>
        [MethodImpl(IL)] public static float length(this int4 f) => math.length(f);
        /// <inheritdoc cref="math.length(int3)"/>
        [MethodImpl(IL)] public static float length(this int3 f) => math.length(f);
        /// <inheritdoc cref="math.length(int2)"/>
        [MethodImpl(IL)] public static float length(this int2 f) => math.length(f);
        

        /// <inheritdoc cref="math.lengthsq(int4)"/>
        [MethodImpl(IL)] public static float lengthsq(this int4 f) => math.lengthsq(f);
        /// <inheritdoc cref="math.lengthsq(int3)"/>
        [MethodImpl(IL)] public static float lengthsq(this int3 f) => math.lengthsq(f);
        /// <inheritdoc cref="math.lengthsq(int2)"/>
        [MethodImpl(IL)] public static float lengthsq(this int2 f) => math.lengthsq(f);


        /// <inheritdoc cref="dot(int4,int4)"/>
        [MethodImpl(IL)] public static int dot(this int4 f, int4 f2) => math.dot(f, f2);
        /// <inheritdoc cref="dot(int4,int4)"/>
        [MethodImpl(IL)] public static int dot(this int3 f, int3 f2) => math.dot(f, f2);
        /// <inheritdoc cref="dot(int4,int4)"/>
        [MethodImpl(IL)] public static int dot(this int2 f, int2 f2) => math.dot(f, f2);
        

        /// Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.
        [MethodImpl(IL)] public static int4 reflect(this int4 i, int4 n) => i - 2 * n * dot(i, n);
        /// <inheritdoc cref="reflect(int4,int4)"/>
        [MethodImpl(IL)] public static int3 reflect(this int3 i, int3 n) => i - 2 * n * dot(i, n);
        /// <inheritdoc cref="reflect(int4,int4)"/>
        [MethodImpl(IL)] public static int2 reflect(this int2 i, int2 n) => i - 2 * n * dot(i, n);
        
        
        /// Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.
        [MethodImpl(IL)] public static float2 refract(this int2 f, int2 f2, float eta) => math.refract(f, f2, eta);
        /// <inheritdoc cref="refract(int2,int2,float)"/>
        [MethodImpl(IL)] public static float3 refract(this int3 f, int3 f2, float eta) => math.refract(f, f2, eta);
        /// <inheritdoc cref="refract(int2,int2,float)"/>
        [MethodImpl(IL)] public static float4 refract(this int4 f, int4 f2, float eta) => math.refract(f, f2, eta);

        /// <inheritdoc cref="math.project(float4,float4)"/>
        [MethodImpl(IL)] public static float4 project(this int4 f, int4 n) => math.project(f, n);
        /// <inheritdoc cref="math.project(float3,float3)"/>
        [MethodImpl(IL)] public static float3 project(this int3 f, int3 n) => math.project(f, n);
        /// <inheritdoc cref="math.project(float2,float2)"/>
        [MethodImpl(IL)] public static float2 project(this int2 f, int2 n) => math.project(f, n);
        
        /// <inheritdoc cref="math.projectsafe(float4,float4,float4)"/>
        [MethodImpl(IL)] public static float4 projectsafe(this int4 f, float4 n, float4 defaultValue = default) => math.projectsafe(f, n, defaultValue);
        /// <inheritdoc cref="math.projectsafe(float2,float2,float2)"/>
        [MethodImpl(IL)] public static float3 projectsafe(this int3 f, float3 n, float3 defaultValue = default) => math.projectsafe(f, n, defaultValue);
        /// <inheritdoc cref="math.projectsafe(float2,float2,float2)"/>
        [MethodImpl(IL)] public static float2 projectsafe(this int2 f, float2 n, float2 defaultValue = default) => math.projectsafe(f, n, defaultValue);
        
        
        /// Returns the Manhattan distance between two float4a
        [MethodImpl(IL)] public static int manhattan(this int4 a, int4 b) => a.sub(b).abs().csum();
        /// Returns the Manhattan distance between two int3s
        [MethodImpl(IL)] public static int manhattan(this int3 a, int3 b) => a.sub(b).abs().csum();
        /// Returns the Manhattan distance between two int2s
        [MethodImpl(IL)] public static int manhattan(this int2 a, int2 b) => a.sub(b).abs().csum();
        /// Returns the Manhattan distance between two ints
        [MethodImpl(IL)] public static int manhattan(this int a, int b) => a.sub(b).abs();

        
        
        #region Single Purpose Functions

        ///<inheritdoc cref="math.cross(float3,float3)"/>
        [MethodImpl(IL)] public static int3 cross(this int3 x, int3 y) => (x * y.yzx - x.yzx * y).yzx;
        
        /// returns a vector perpendicular to the input vector
        [MethodImpl(IL)] public static int2 perp(this int2 f) => new(-f.y, f.x);
        
        /// Returns the exterior product of two vectors. its magnitude is the area of the parallelogram they span.
        /// note: this is not the cross product
        [MethodImpl(IL)] public static int3 exterior(this int3 a, int3 b) => a.yzx * b.zxy - a.zxy * b.yzx;

        /// orthonormalize
        [MethodImpl(IL)] public static float3 orthonorm(ref int3 normal, float3 tangent) => tangent - tangent.projectsafe(normal.norm());
        
        #endregion

        #region Matrix Operations

        ///Returns the distance the two vectors in the matrix
        [MethodImpl(IL)] public static float cdistance(this int2x2 f) => math.distance(f.c0, f.c1);
        [MethodImpl(IL)] public static float cdistance(this int3x2 f) => math.distance(f.c0, f.c1);
        [MethodImpl(IL)] public static float cdistance(this int4x2 f) => math.distance(f.c0, f.c1);
        
        ///Returns the squared distance the two vectors in the matrix
        [MethodImpl(IL)] public static float cdistancesq(this int2x2 f) => math.distancesq(f.c0, f.c1);
        [MethodImpl(IL)] public static float cdistancesq(this int3x2 f) => math.distancesq(f.c0, f.c1);
        [MethodImpl(IL)] public static float cdistancesq(this int4x2 f) => math.distancesq(f.c0, f.c1);
        
        
        ///Returns the cross product of the two vectors in the matrix
        [MethodImpl(IL)] public static float3 ccross(this int3x2 f) => math.cross(f.c0, f.c1);
        
        ///Returns the dot product of the two vectors in the matrix
        [MethodImpl(IL)] public static int cdot(this int4x2 f) => math.dot(f.c0, f.c1);
        /// <inheritdoc cref="cdot(int4x2)"/>
        [MethodImpl(IL)] public static int cdot(this int3x2 f) => math.dot(f.c0, f.c1);
        /// <inheritdoc cref="cdot(int4x2)"/>
        [MethodImpl(IL)] public static int cdot(this int2x2 f) => math.dot(f.c0, f.c1);

        #endregion
    
        
    
    }
}