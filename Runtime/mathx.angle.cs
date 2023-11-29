#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // angle() translated from UnityEngine
        
        /// Returns the signed angle between two vectors in radians
        [MethodImpl(IL)] public static float anglerad(this float2 from, float2 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsat().acos(); // * 57.29578f;
        }
        
        /// <inheritdoc cref="anglerad(float2, float2)" />
        [MethodImpl(IL)] public static float anglerad(this float3 from, float3 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsat().acos(); // * 57.29578f;
        }

        /// <inheritdoc cref="anglerad(float2, float2)" />
        [MethodImpl(IL)] public static float anglerad(this float4 from, float4 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsat().acos(); // * 57.29578f;
        }
        
        /// <inheritdoc cref="math.angle(Unity.Mathematics.quaternion, Unity.Mathematics.quaternion)" />
        [MethodImpl(IL)] public static float anglerad(this quaternion q1, quaternion q2) => math.angle(q1, q2);

        

        /// Returns the signed angle between two vectors in degrees
        [MethodImpl(IL)] public static float angledeg(float2 from, float2 to) => from.anglerad(to).deg();
        /// <inheritdoc cref="angledeg(float2, float2)" />
        [MethodImpl(IL)] public static float angledeg(float3 from, float3 to) => from.anglerad(to).deg();
        /// <inheritdoc cref="angledeg(float2, float2)" />s
        [MethodImpl(IL)] public static float angledeg(float4 from, float4 to) => from.anglerad(to).deg();
        /// <summary>Returns the angle in degrees between two unit quaternions.</summary>
        /// <param name="q1">The first quaternion.</param>
        /// <param name="q2">The second quaternion.</param>
        /// <returns>The angle between two unit quaternions.</returns>
        [MethodImpl(IL)] public static float angledeg(quaternion q1, quaternion q2) => q1.anglerad(q2).deg();


        /// a fast and accurate way of computing angles
        [MethodImpl(IL)] public static float fastangle(this float4 from, float4 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsat().acos();

        [MethodImpl(IL)] public static float fastangle(this float3 from, float3 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsat().acos();

        [MethodImpl(IL)] public static float fastangle(this float2 from, float2 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsat().acos();

        // // another way of computing angles
        // [MethodImpl(IL)] public static float otherangle(f2 v1, f2 v2) => math.atan2(v1.x * v2.y - v2.x * v1.y, (v1 * v2).csum()) * (180 / PI);

        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-Mathutil-cs-L24

        /// Determine the signed angle between two vectors, with normal 'limn' as the rotation axis.
        /// straightforward formulae to compute the signed angle between two vectors
        [MethodImpl(IL)] public static float straightsignedangle(float3 f1, float3 f2, float3 n) => n.dot(f1.cross(f2)).atan2(f1.dot(f2));


        [MethodImpl(IL)] public static float preciseangle(float3 v1, float3 v2)
        {
            var v3 = v1.norm();
            var v4 = v2.norm();
            return v1.dot(v2) < 0 ? PI - 2 * ((-v3 - v4).length() / 2).asin() : 2 * ((v3 - v4).length() / 2).asin();
        }

        [MethodImpl(IL)] public static float preciseangle(float2 v1, float2 v2)
        {
            var v3 = v1.norm();
            var v4 = v2.norm();
            return v3.dot(v4) < 0 ? PI - 2 * ((-v3 - v4).length() / 2).asin() : 2 * ((v3 - v4).length() / 2).asin();
        }

        /// Returns the signed angle between two vectors in radians using an axis of rotation
        [MethodImpl(IL)] public static float signedangle(float4 from, float4 to, float4 axis) =>
            anglerad(from, to) * ((from.yzwx * to.zwxy - from.zwxy * to.yzwx) * axis).csum().sign();

        /// Returns the signed angle between two vectors in radians using an axis of rotation
        [MethodImpl(IL)] public static float signedangle(float3 from, float3 to, float3 axis) =>
            anglerad(from, to) * ((from.yzx * to.zxy - from.zxy * to.yzx) * axis).csum().sign();

        /// Returns the signed angle between two vectors in radians;
        [MethodImpl(IL)] public static float signedangle(Vector2 from, Vector2 to) =>
            anglerad(from, to) * (from.x * to.y - from.y * to.x).sign();

        /// https://gist.github.com/voidqk/fc5a58b7d9fc020ecf7f2f5fc907dfa5
        /// Computes atan2(y,x), fast -->  max err: 0.071115
        [MethodImpl(IL)] public static float fastatan2(float y, float x)
        {
            const float c1 = PI / 4;
            const float c2 = PI * 0.75f;
            if (y == 0 && x == 0) return 0;
            var abs_y = y.abs();
            float angle;
            if (x >= 0) angle = c1 - c1 * ((x - abs_y) / (x + abs_y));
            else angle = c2 - c1 * ((x + abs_y) / (abs_y - x));
            if (y < 0) return -angle;
            return angle;
        }
        // rotation -----------------------------------------------------

        // Builds a quaternion rotation from and axis and an angle in radians
    }
}