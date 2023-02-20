using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        // angle() translated from UnityEngine
        
        /// Returns the signed angle between two vectors in radians
        public static float anglerad(this float2 from, float2 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsaturate().acos(); // * 57.29578f;
        }
        
        /// <inheritdoc cref="anglerad(float2, float2)" />
        public static float anglerad(this float3 from, float3 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsaturate().acos(); // * 57.29578f;
        }

        /// <inheritdoc cref="anglerad(float2, float2)" />
        public static float anglerad(this float4 from, float4 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt();
            return num < 1.00000000362749E-15f ? 0 : (from.dot(to) / num).npsaturate().acos(); // * 57.29578f;
        }

        public static float angledeg(float2 from, float2 to) => from.anglerad(to).deg();
        public static float angledeg(float3 from, float3 to) => from.anglerad(to).deg();
        public static float angledeg(float4 from, float4 to) => from.anglerad(to).deg();


        /// a fast and accurate way of computing angles
        public static float fastangle(this float4 from, float4 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsaturate().acos();

        public static float fastangle(this float3 from, float3 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsaturate().acos();

        public static float fastangle(this float2 from, float2 to) => (from.dot(to) / (from.lengthsq() * to.lengthsq()).fsqrt()).npsaturate().acos();

        // another way of computing angles
        // public static float otherangle(float2 v1, float2 v2) => math.atan2(v1.x * v2.y - v2.x * v1.y, (v1 * v2).sum()) * (180 / Math.PI);

        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-Mathutil-cs-L24

        /// Determine the signed angle between two vectors, with normal 'n' as the rotation axis.
        /// straightforward formulae to compute the signed angle between two vectors
        public static float straightsignedangle(float3 f1, float3 f2, float3 n) => n.dot(f1.cross(f2)).atan2(f1.dot(f2));

        /// <inheritdoc cref="straightsignedangle(float3,float3,float3)" />
        public static double straightsignedangle(double3 f1, double3 f2, double3 n) => n.dot(f1.cross(f2)).atan2(f1.dot(f2));

        public static float preciseangle(float3 v1, float3 v2)
        {
            var v3 = v1.norm();
            var v4 = v2.norm();
            return v1.dot(v2) < 0 ? PI - 2 * ((-v3 - v4).length() / 2).asin() : 2 * ((v3 - v4).length() / 2).asin();
        }

        public static float preciseangle(float2 v1, float2 v2)
        {
            var v3 = v1.norm();
            var v4 = v2.norm();
            return v3.dot(v4) < 0 ? PI - 2 * ((-v3 - v4).length() / 2).asin() : 2 * ((v3 - v4).length() / 2).asin();
        }

        /// Returns the signed angle between two vectors in radians using an axis of rotation
        public static float signedangle(float4 from, float4 to, float4 axis) =>
            anglerad(from, to) * ((from.yzwx * to.zwxy - from.zwxy * to.yzwx) * axis).sum().sign();

        /// Returns the signed angle between two vectors in radians using an axis of rotation
        public static float signedangle(float3 from, float3 to, float3 axis) =>
            anglerad(from, to) * ((from.yzx * to.zxy - from.zxy * to.yzx) * axis).sum().sign();

        /// Returns the signed angle between two vectors in radians;
        public static float signedangle(Vector2 from, Vector2 to) =>
            anglerad(from, to) * (from.x * to.y - from.y * to.x).sign();

        /// https://gist.github.com/voidqk/fc5a58b7d9fc020ecf7f2f5fc907dfa5
        /// Computes atan2(y,x), fast -->  max err: 0.071115
        public static float fastatan2(float y, float x)
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

        /// Returns the result of rotating a vector by a unit quaternion
        public static float3 rotate(this float3 f, quaternion rotation) => math.rotate(rotation, f);

        /// Returns the result of rotating a vector by a rotation matrix
        public static float3 rotate(this float3 f, float3x3 rotation) => rotation.mul(f);

        /// Returns the result of rotating a vector using euler angles in radians, and an axis of rotation
        public static float3 rotateAxisAngle(this float3 f, float3 axis, float angle) => f.rotate(quaternion(axis, angle));

        /// Rotates using euler angles in radians
        /// <param name="f">input vector</param>
        /// <param name="rotation">radians</param>
        public static float3 rotateRad(this float3 f, float3 rotation) => f.rotate(quaternion(rotation));

        /// Rotates using euler angles
        /// <param name="f">input vector</param>
        /// <param name="rotation">degrees</param>
        public static float3 rotateDeg(this float3 f, float3 rotation) => f.rotate(quaternion(rotation * RAD));

        public static quaternion quaternion(float3 axis, float angle) => Mathematics.quaternion.AxisAngle(axis, angle);
        public static quaternion quaternion(float3 eulerangles) => Mathematics.quaternion.Euler(eulerangles);
    }
}