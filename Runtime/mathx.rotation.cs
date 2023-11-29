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
        /// Returns the result of rotating a vector by a unit quaternion
        [MethodImpl(IL)] public static float3 rotate(this float3 f, quaternion rotation) => math.rotate(rotation, f);
        /// Returns the result of rotating a vector by a unit quaternion
        [MethodImpl(IL)] public static float3 rotate(this quaternion rotation, float3 f) => math.rotate(rotation, f);
        /// Returns the result of rotating a vector by a rotation matrix
        [MethodImpl(IL)] public static float3 rotate(this float3 f, float3x3 rotation) => rotation.mul(f);
        /// Returns the result of rotating a vector using euler angles in radians, and an axis of rotation
        [MethodImpl(IL)] public static float3 rotateAxisAngle(this float3 f, float3 axis, float angle) => f.rotate(quaternion(axis, angle));
        /// Rotates using euler angles in radians
        /// <param name="f">input vector</param>
        /// <param name="rotation">radians</param>
        [MethodImpl(IL)] public static float3 rotateRad(this float3 f, float3 rotation) => f.rotate(quaternion(rotation));
        /// Rotates using euler angles
        /// <param name="f">input vector</param>
        /// <param name="rotation">degrees</param>
        [MethodImpl(IL)] public static float3 rotateDeg(this float3 f, float3 rotation) => f.rotate(quaternion(rotation * RAD));
        /// <inheritdoc cref="Mathematics.quaternion.AxisAngle(float3, float)"/>
        [MethodImpl(IL)] public static quaternion quaternion(float3 axis, float angle) => Mathematics.quaternion.AxisAngle(axis, angle);
        /// <inheritdoc cref="Mathematics.quaternion.EulerZXY(float3)"/>
        [MethodImpl(IL)] public static quaternion quaternion(float3 eulerangles, math.RotationOrder rotationOrder = math.RotationOrder.Default) => Mathematics.quaternion.Euler(eulerangles, rotationOrder);
        
        /// Rotates a matrix around a point using euler angles in radians
        [MethodImpl(IL)] public static float4x4 rotateAround(this float4x4 localToWorld, float3 point, float3 angles)
            => localToWorld
                .rotateAround(point, localToWorld.up(), angles.x)
                .rotateAround(point, localToWorld.right(), angles.y)
                .rotateAround(point, localToWorld.forward(), angles.z);

        /// Rotates a matrix around a point using euler angles in radians
        [MethodImpl(IL)] public static float4x4 rotateAround(this float4x4 localToWorld, float3 center, float3 axis, float angle) {
            var initialRot = localToWorld.quaternion();
            var rotAmount = quaternion(axis, angle);
            var finalPos = center + rotAmount.rotate(localToWorld.translationMatrix() - center);
            var finalRot = initialRot.mul(initialRot.inverse().mul(rotAmount)).mul(initialRot);
            return new float4x4(finalRot, finalPos);
        }
    }
    
    
    
}