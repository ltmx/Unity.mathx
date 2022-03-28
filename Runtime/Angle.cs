using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        //translated from UnityEngine
        /// Returns the signed angle between two vectors in radians
        public static float angle (float3 from, float3 to)
        {
            var num = (from.lengthsq() * to.lengthsq()).sqrt ();
            return num < 1.00000000362749E-15f ? 0 : (math.dot (from, to) / num).npsaturate ().acos (); // * 57.29578f;
        }

        /// <inheritdoc cref="angle(float3,float3)"/>
        public static float angle (float4 from, float4 to) {
            var num = (from.lengthsq() * to.lengthsq()).sqrt ();
            return num < 1.00000000362749E-15f ? 0 : (math.dot (from, to) / num).npsaturate ().acos (); // * 57.29578f;
        }
        /// <inheritdoc cref="angle(float3,float3)"/>
        public static float angle (float2 from, float2 to) {
            var num = (from.lengthsq () * to.lengthsq ()).sqrt ();
            return num < 1.00000000362749E-15f ? 0 : (math.dot (from, to) / num).npsaturate ().acos (); // * 57.29578f;
        }

        public static float fastangle (float4 from, float4 to) => (math.dot(from, to) / (from.lengthsq() * to.lengthsq()).fastsqrt()).npsaturate().acos();
        public static float fastangle (float3 from, float3 to) => (math.dot(from, to) / (from.lengthsq() * to.lengthsq()).fastsqrt()).npsaturate().acos();
        public static float fastangle (float2 from, float2 to) => (math.dot(from, to) / (from.lengthsq() * to.lengthsq()).fastsqrt()).npsaturate().acos();

        // another way of computing angles
        //public static float otherangle(float2 v1, float2 v2) => math.atan2(v1.x * v2.y - v2.x * v1.y, (v1 * v2).sum()) * (180 / math.PI);

        // https://gist.github.com/SaffronCR/b0802d102dd7f262118ac853cd5b4901#file-mathutil-cs-L24
        /// Determine the signed angle between two vectors, with normal 'n' as the rotation axis.

        /// straightforward formulae to compute the signed angle between two vectors
        public static float straightsignedangle (float3 f1, float3 f2, float3 n) => math.atan2 (math.dot (n, math.cross (f1, f2)), math.dot (f1, f2));
        public static double straightsignedangle (double3 f1, double3 f2, double3 n) => math.atan2 (math.dot (n, math.cross (f1, f2)), math.dot (f1, f2));

        public static float preciseangle (float3 v1, float3 v2) {
            var v3 = v1.normalized();
            var v4 = v2.normalized();
            return math.dot (v1, v2) < 0 ?
                math.PI - 2 * ((-v3 - v4).length() / 2).asin() :
                2 * ((v3 - v4).length() / 2).asin();
        }
        public static float preciseangle (float2 v1, float2 v2) {
            var v3 = v1.normalized();
            var v4 = v2.normalized();
            return math.dot (v3, v4) < 0 ?
                math.PI - 2 * ((-v3 - v4).length() / 2).asin() :
                2 * ((v3 - v4).length() / 2).asin();
        }

        /// Returns the signed angle between two vectors in radians using an axis of rotation
        public static float signedangle (float4 from, float4 to, float4 axis) => angle (from, to) * ((from.yzwx * to.zwxy - from.zwxy * to.yzwx) * axis).sum().sign();
        /// Returns the signed angle between two vectors in radians using an axis of rotation
        public static float signedangle (float3 from, float3 to, float3 axis) => angle (from, to) * ((from.yzx * to.zxy - from.zxy * to.yzx) * axis).sum().sign();
        /// Returns the signed angle between two vectors in radians;
        public static float signedangle (Vector2 from, Vector2 to) => angle (from, to) * (from.x * to.y - from.y * to.x).sign();

        //https://gist.github.com/voidqk/fc5a58b7d9fc020ecf7f2f5fc907dfa5
        //  Computes atan2(y,x), fast -->  max err: 0.071115
        public static float fastatan2 (float y, float x) {
            const float c1 = math.PI / 4;
            const float c2 = math.PI * 0.75f;
            if (y == 0 && x == 0) return 0;
            var abs_y = y.abs();
            float angle;
            if (x >= 0) angle = c1 - c1 * ((x - abs_y) / (x + abs_y));
            else angle = c2 - c1 * ((x + abs_y) / (abs_y - x));
            if (y < 0) return -angle;
            return angle;
        }

        /// Returns the result of rotating a vector by a unit quaternion
        public static float3 rotate (this float3 f, quaternion rotation) => math.rotate (rotation, f);
        /// Returns the result of transforming a vector by a quaternion
        public static float3 mulq (this float3 f, quaternion rotation) => math.mul (rotation, f);

    }
}