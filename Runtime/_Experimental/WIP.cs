#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System;
using System.Runtime.CompilerServices;
using NUnit.Compatibility;
using static Unity.Mathematics.math;
using static Unity.Mathematics.quaternion;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        [MethodImpl(IL)] public static float3 position(this float4x4 m) => m.c3.xyz;
        [MethodImpl(IL)] public static float3 forward(this float4x4 m) => m.c2.xyz;
        [MethodImpl(IL)] public static float3 up(this float4x4 m) => m.c1.xyz;
        [MethodImpl(IL)] public static float3 right(this float4x4 m) => m.c0.xyz;
        ///     Extracts the dim vector from the matrix
        [MethodImpl(IL)] public static float3 dim(this float4x4 m) => new(mathx.length(m.c0), mathx.length(m.c1), mathx.length(m.c2));
        /// Extracts rotation from the matrix
        [MethodImpl(IL)] public static quaternion rotation(this float4x4 m) => LookRotationSafe(m.forward(), m.up());
        [MethodImpl(IL)] private static float3 mod360(this ref float3 angles) => angles = new float3(angles.x.mod360(), angles.y.mod360(), angles.z.mod360());
        [MethodImpl(IL)] private static float mod360(this float angle) => angle.mod(360);
        [MethodImpl(IL)] private static float mod2PI(this float angle) => angle.mod(TAU);
        [MethodImpl(IL)]
        public static float4x4 rotateAround(this float4x4 localToWorld, float3 point, float3 angles) 
            => localToWorld
                .rotateAround(point, localToWorld.up(), angles.x)
                .rotateAround(point, localToWorld.right(), angles.y)
                .rotateAround(point, localToWorld.forward(), angles.z);
        
        [MethodImpl(IL)]
        public static float4x4 rotateAround(this float4x4 localToWorld, float3 center, float3 axis, float angle) {
            var initialRot = localToWorld.rotation();
            var rotAmount = quaternion(axis, angle);
            var finalPos = center + rotAmount.rotate(localToWorld.position() - center);
            var finalRot = initialRot.mul(initialRot.inverse().mul(rotAmount)).mul(initialRot);
            return new float4x4(finalRot, finalPos);
        }
        
        [MethodImpl(IL)]
        public static float2 GetAxis(this float2 vector, float threshold) {
            if (vector.lengthsq() > threshold.sq() && vector.x != vector.y)
                if (vector.x.abs() > vector.y.abs()) return new float2(1, 0);
                else return new float2(0, 1);
            return new float2();
        }
        [MethodImpl(IL)] public static float3 Right(this float3 forward) => math.normalize(math.cross(forward, new float3(0, 1, 0)));
        [MethodImpl(IL)] public static float3 Up(this float3 forward) => math.normalize(math.cross(forward.Right(), forward));
        [MethodImpl(IL)] public static float Max(this float3 f) => f.x > f.y && f.x > f.z ? f.x : f.y > f.z ? f.y : f.z;
        [MethodImpl(IL)] public static int MaxAbsAxis(this float3 f) => f.x.abs() > f.y.abs() && f.x.abs() > f.z.abs() ? 0 : f.y.abs() > f.z.abs() ? 1 : 2;
        [MethodImpl(IL)] public static int MinAbsAxis(this float3 f) => f.x.abs() < f.y.abs() && f.x.abs() < f.z.abs() ? 0 :
            f.y.abs() < f.z.abs() ? 1 : 2;
        /// <summary>Projects a vector onto a plane defined by a normal orthogonal to the plane.</summary>
        [MethodImpl(IL)] public static float3 projectplane(this float3 f, float3 planeNormal) => f - project(f, planeNormal);
        [MethodImpl(IL)] public static float3 MultiplyPoint(this float4x4 m, float3 v) {
            var v4 = v.append(1).mul(m);
            v4 *= v4.w.rcp().dim(v4);
            return v4.xyz;
        }
        /// <inheritdoc cref="Mathematics.quaternion(float, float, float, float)"/>
        [MethodImpl(IL)] public static quaternion quaternion(float x, float y, float z, float w) => new(x, y, z, w);
        /// <inheritdoc cref="Mathematics.quaternion(float4)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float4 value) => new(value);
        /// <inheritdoc cref="Mathematics.quaternion(float3x3)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float3x3 m) => new(m);
        /// <inheritdoc cref="Mathematics.quaternion(float4x4)"/>
        [MethodImpl(IL)] public static quaternion quaternion(this float4x4 m) => new(m);
        /// <inheritdoc cref="math.conjugate(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion conjugate(this quaternion q) => new(q.value * float4(-1.0f, -1.0f, -1.0f, 1.0f));
        /// <inheritdoc cref="math.inverse(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion inverse(this quaternion q) => math.inverse(q);
        /// <inheritdoc cref="math.dot(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float dot(this quaternion a, quaternion b) => dot(a.value, b.value);
        /// <inheritdoc cref="math.length(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float length(this quaternion q) => sqrt(dot(q.value, q.value));
        /// <inheritdoc cref="math.lengthsq(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static float lengthsq(this quaternion q) => dot(q.value, q.value);
        /// <inheritdoc cref="math.normalize(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion normalize(this quaternion q) => math.normalize(q);
        /// <inheritdoc cref="math.normalizesafe(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion normalizesafe(this quaternion q) => math.normalizesafe(q);
        /// <inheritdoc cref="math.normalizesafe(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion normalizesafe(this quaternion q, quaternion defaultvalue) => math.normalizesafe(q, defaultvalue);
        /// <inheritdoc cref="math.unitexp(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion unitexp(this quaternion q) => math.unitexp(q);
        /// <inheritdoc cref="math.exp(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion exp(this quaternion q) => math.exp(q);
        /// <inheritdoc cref="math.unitlog(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion unitlog(this quaternion q) => math.unitlog(q);
        /// <inheritdoc cref="math.log(Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion log(this quaternion q) => math.log(q);
        /// <inheritdoc cref="math.mul(Mathematics.quaternion, Mathematics.quaternion)"/>
        [MethodImpl(IL)] public static quaternion mul(this quaternion a, quaternion b) => new quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * float4(1.0f, 1.0f, 1.0f, -1.0f) - a.value.zxyz * b.value.yzxz);
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