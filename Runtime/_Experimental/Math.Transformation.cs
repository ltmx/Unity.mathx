#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// returns the float3x4 (simpler form) matrix of a RigidTransform
        [MethodImpl(IL)] public static float3x4 matrix(this RigidTransform m) => float3x4(m.rot.matrix(), m.pos);
        /// returns the float3x3 (simpler form) matrix of a quaternion
        [MethodImpl(IL)] public static float3x3 matrix(this quaternion q) => math.float3x3(q);
        /// Returns the inverse of a float3x4 matrix
        [MethodImpl(IL)] public static float3x4 inverse(this float3x4 m) => float3x4(m.rotation(), m[3].rotate(-m.rotation()));
        /// Returns a float3x4 matrix from a float3x3 rotation matrix and a f3 translation vector
        [MethodImpl(IL)] public static float3x4 float3x4(float3x3 r, float3 t) => math.float3x4(r.c0, r.c1, r.c2, t);
        /// Returns the rotation component of a float3x4 matrix
        [MethodImpl(IL)] public static float3x3 rotation(this float3x4 m) => m.f3x3();
        /// Returns the rotation component of a float4x3 matrix
        [MethodImpl(IL)] public static float3x3 rotation(this float4x3 m) => m.f3x3();
        /// Returns the rotation component of a float4x4 matrix
        [MethodImpl(IL)] public static float3x3 rotation(this float4x4 m) => m.f3x3();
        /// Returns the rotation component of a float4x3 matrix
        [MethodImpl(IL)] public static float3 translation(this float4x3 m) => m[3].xyz;
        /// Returns the rotation component of a float4x4 matrix
        [MethodImpl(IL)] public static float3 translation(this float4x4 m) => m[3].xyz;
        /// Returns the translation component of a float3x4 matrix
        [MethodImpl(IL)] public static float3 translation(this float3x4 m) => m[3];
        /// Transform a f3 point by a float3x4 matrix;
        [MethodImpl(IL)] public static float3 transform(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        /// Transform a f3 point by a float3x4 matrix;
        [MethodImpl(IL)] public static float3 transform(this float3x4 m, float4 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3] * p.w;

        
        /// Returns the rotation component of a matrix
        [MethodImpl(IL)] public static float3 forward(this float4x4 m) => m.c2.xyz;
        /// Returns the up vector of a matrix
        [MethodImpl(IL)] public static float3 up(this float4x4 m) => m.c1.xyz;
        /// Returns the right vector of a matrix
        [MethodImpl(IL)] public static float3 right(this float4x4 m) => m.c0.xyz;
        /// Returns the scale vector from the matrix
        [MethodImpl(IL)] public static float3 scale(this float4x4 m) => new(m.c0.length(), m.c1.length(), m.c2.length());
        /// Returns the bi-tangent vector of a forward vector.
        [MethodImpl(IL)] public static float3 right(this float3 forward) => forward.cross(new float3(0, 1, 0)).norm();
        /// Returns the tangent vector of a forward vector.
        [MethodImpl(IL)] public static float3 up(this float3 forward) => forward.right().cross(forward).norm();
    }
}