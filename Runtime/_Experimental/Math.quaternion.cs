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
        /// <inheritdoc cref="Mathematics.quaternion(float, float, float, float)"/>
        [MethodImpl(IL)] public static quaternion quaternion(float x, float y, float z, float w) => new(x, y, z, w);
        /// <inheritdoc cref="Mathematics.quaternion(float4)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float4 value) => new(value);
        /// <inheritdoc cref="Mathematics.quaternion(float3x3)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float3x3 m) => new(m);
        /// <inheritdoc cref="Mathematics.quaternion(float4x4)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float4x4 m) => new(m);
        /// <inheritdoc cref="math.conjugate(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion conjugate(this quaternion q) => new(q.value * math.float4(-1.0f, -1.0f, -1.0f, 1.0f));
        /// <inheritdoc cref="math.inverse(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion inverse(this quaternion q) => math.inverse(q);
        /// <inheritdoc cref="math.dot(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float dot(this quaternion a, quaternion b) => dot(a.value, b.value);
        /// <inheritdoc cref="math.length(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float length(this quaternion q) => sqrt(dot(q.value, q.value));
        /// <inheritdoc cref="math.lengthsq(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float lengthsq(this quaternion q) => dot(q.value, q.value);
        /// <inheritdoc cref="math.normalize(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion norm(this quaternion q) => math.normalize(q);
        /// <inheritdoc cref="math.normalizesafe(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion normsafe(this quaternion q) => math.normalizesafe(q);
        /// <inheritdoc cref="math.normalizesafe(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion normsafe(this quaternion q, quaternion defaultvalue) => math.normalizesafe(q, defaultvalue);
        /// <inheritdoc cref="math.unitexp(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion unitexp(this quaternion q) => math.unitexp(q);
        /// <inheritdoc cref="math.exp(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion exp(this quaternion q) => math.exp(q);
        /// <inheritdoc cref="math.unitlog(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion unitlog(this quaternion q) => math.unitlog(q);
        /// <inheritdoc cref="math.log(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion log(this quaternion q) => math.log(q);
        /// <inheritdoc cref="math.mul(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion mul(this quaternion a, quaternion b) => new quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * math.float4(1.0f, 1.0f, 1.0f, -1.0f) - a.value.zxyz * b.value.yzxz);
        /// <inheritdoc cref="math.mul(Mathematics.quaternion, float3)"/>
        [MethodImpl(IL)] public static float3 mul(this float3 f, quaternion rotation) => math.mul(rotation, f);
        /// <inheritdoc cref="math.mul(Mathematics.quaternion, float3)"/>
        [MethodImpl(IL)] public static float3 mul(this quaternion q, float3 v) => math.mul(q, v);
        /// <inheritdoc cref="math.nlerp(Mathematics.quaternion, Mathematics.quaternion, float)"/>
        [MethodImpl(IL)] public static quaternion nlerp(this float t, quaternion q1, quaternion q2) => math.nlerp(q1, q2, t);
        /// <inheritdoc cref="math.slerp(Mathematics.quaternion, Mathematics.quaternion, float)"/>
        [MethodImpl(IL)] public static quaternion slerp(this float t, quaternion q1, quaternion q2) => math.slerp(q1, q2, t);
        /// <inheritdoc cref="math.hash(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static uint hash(this quaternion q) => math.hash(q.value);
        /// <inheritdoc cref="math.hashwide(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static uint4 hashwide(this quaternion q) => math.hashwide(q.value);
        /// <inheritdoc cref="math.forward(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float3 forward(this quaternion q) => math.forward(q);
    }
}