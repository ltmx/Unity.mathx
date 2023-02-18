using UnityEngine;
using ma = Unity.Mathematics.math;
using f4 = Unity.Mathematics.float4;
using f3 = Unity.Mathematics.float3;
using f2 = Unity.Mathematics.float2;
using f1 = System.Single;
using d4 = Unity.Mathematics.double4;
using d3 = Unity.Mathematics.double3;
using d2 = Unity.Mathematics.double2;
using d1 = System.Double;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        // Trigonometry ----------------------------------------------------------------------------------

        // Sine
        public static f4 sin(this f4 f) => ma.sin(f);
        public static f3 sin(this f3 f) => ma.sin(f);
        public static f2 sin(this f2 f) => ma.sin(f);
        public static f1 sin(this f1 f) => ma.sin(f);
        public static f1 sin(this int f) => ma.sin(f);
        
        public static f4 sin(this Vector4 f) => ma.sin(f);
        public static f3 sin(this Vector3 f) => ma.sin(f);
        public static f2 sin(this Vector2 f) => ma.sin(f);
        
        public static d4 sin(this d4 f) => ma.sin(f);
        public static d3 sin(this d3 f) => ma.sin(f);
        public static d2 sin(this d2 f) => ma.sin(f);
        public static d1 sin(this d1 f) => ma.sin(f);
        
        // Cosine
        public static f4 cos(this f4 f) => ma.cos(f);
        public static f3 cos(this f3 f) => ma.cos(f);
        public static f2 cos(this f2 f) => ma.cos(f);
        public static f1 cos(this f1 f) => ma.cos(f);
        public static f1 cos(this int f) => ma.cos(f);
        
        public static f4 cos(this Vector4 f) => ma.cos(f);
        public static f3 cos(this Vector3 f) => ma.cos(f);
        public static f2 cos(this Vector2 f) => ma.cos(f);
        
        public static d4 cos(this d4 f) => ma.cos(f);
        public static d3 cos(this d3 f) => ma.cos(f);
        public static d2 cos(this d2 f) => ma.cos(f);
        public static d1 cos(this d1 f) => ma.cos(f);

        // Tangent
        public static f4 tan(this f4 f) => ma.tan(f);
        public static f3 tan(this f3 f) => ma.tan(f);
        public static f2 tan(this f2 f) => ma.tan(f);
        public static f1 tan(this f1 f) => ma.tan(f);
        public static f1 tan(this int f) => ma.tan(f);
        
        public static f4 tan(this Vector4 f) => ma.tan(f);
        public static f3 tan(this Vector3 f) => ma.tan(f);
        public static f2 tan(this Vector2 f) => ma.tan(f);
        
        public static d4 tan(this d4 f) => ma.tan(f);
        public static d3 tan(this d3 f) => ma.tan(f);
        public static d2 tan(this d2 f) => ma.tan(f);
        public static d1 tan(this d1 f) => ma.tan(f);
        
        // Secant
        public static f4 sec(this f4 f) => f.rcp().cos();
        public static f3 sec(this f3 f) => f.rcp().cos();
        public static f2 sec(this f2 f) => f.rcp().cos();
        public static f1 sec(this f1 f) => f.rcp().cos();
        public static f1 sec(this int f) => f.rcp().cos();
        public static f4 sec(this Vector4 f) => f.rcp().cos();
        public static f3 sec(this Vector3 f) => f.rcp().cos();
        public static f2 sec(this Vector2 f) => f.rcp().cos();
        
        public static d4 sec(this d4 f) => f.rcp().cos();
        public static d3 sec(this d3 f) => f.rcp().cos();
        public static d2 sec(this d2 f) => f.rcp().cos();
        public static d1 sec(this d1 f) => f.rcp().cos();
        
        // Cotangent
        public static f4 cot(this f4 f) => f.tan().rcp();
        public static f3 cot(this f3 f) => f.tan().rcp();
        public static f2 cot(this f2 f) => f.tan().rcp();
        public static f1 cot(this f1 f) => f.tan().rcp();
        public static f1 cot(this int f) => f.tan().rcp();
        
        public static d4 cot(this d4 f) => f.tan().rcp();
        public static d3 cot(this d3 f) => f.tan().rcp();
        public static d2 cot(this d2 f) => f.tan().rcp();
        public static d1 cot(this d1 f) => f.tan().rcp();
        
        public static Vector4 cot(this Vector4 f) => f.tan().rcp();
        public static Vector3 cot(this Vector3 f) => f.tan().rcp();
        public static Vector2 cot(this Vector2 f) => f.tan().rcp();
        
        // Cosecant
        public static f4 csc(this f4 f) => f.sin().rcp();
        public static f3 csc(this f3 f) => f.sin().rcp();
        public static f2 csc(this f2 f) => f.sin().rcp();
        public static f1 csc(this f1 f) => f.sin().rcp();
        public static f1 csc(this int f) => f.sin().rcp();
        
        public static d4 csc(this d4 f) => f.sin().rcp();
        public static d3 csc(this d3 f) => f.sin().rcp();
        public static d2 csc(this d2 f) => f.sin().rcp();
        public static d1 csc(this d1 f) => f.sin().rcp();
        
        public static Vector4 csc(this Vector4 f) => f.sin().rcp();
        public static Vector3 csc(this Vector3 f) => f.sin().rcp();
        public static Vector2 csc(this Vector2 f) => f.sin().rcp();
        
        // Arcsine
        public static f4 asin(this f4 f) => ma.asin(f);
        public static f3 asin(this f3 f) => ma.asin(f);
        public static f2 asin(this f2 f) => ma.asin(f);
        public static f1 asin(this f1 f) => ma.asin(f);
        public static f1 asin(this int f) => ma.asin(f);
        
        public static f4 asin(this Vector4 f) => ma.asin(f);
        public static f3 asin(this Vector3 f) => ma.asin(f);
        public static f2 asin(this Vector2 f) => ma.asin(f);
        
        public static d4 asin(this d4 f) => ma.asin(f);
        public static d3 asin(this d3 f) => ma.asin(f);
        public static d2 asin(this d2 f) => ma.asin(f);
        public static d1 asin(this d1 f) => ma.asin(f);
        
        // Arccosine
        public static f4 acos(this f4 f) => ma.acos(f);
        public static f3 acos(this f3 f) => ma.acos(f);
        public static f2 acos(this f2 f) => ma.acos(f);
        public static f1 acos(this f1 f) => ma.acos(f);
        public static f1 acos(this int f) => ma.acos(f);
        
        public static f4 acos(this Vector4 f) => ma.acos(f);
        public static f3 acos(this Vector3 f) => ma.acos(f);
        public static f2 acos(this Vector2 f) => ma.acos(f);
        
        public static d4 acos(this d4 f) => ma.acos(f);
        public static d3 acos(this d3 f) => ma.acos(f);
        public static d2 acos(this d2 f) => ma.acos(f);
        public static d1 acos(this d1 f) => ma.acos(f);

        // Arctangent
        public static f4 atan(this f4 f) => ma.atan(f);
        public static f3 atan(this f3 f) => ma.atan(f);
        public static f2 atan(this f2 f) => ma.atan(f);
        public static f1 atan(this f1 f) => ma.atan(f);
        public static f1 atan(this int f) => ma.atan(f);
        
        public static f4 atan(this Vector4 f) => ma.atan(f);
        public static f3 atan(this Vector3 f) => ma.atan(f);
        public static f2 atan(this Vector2 f) => ma.atan(f);
        
        public static d4 atan(this d4 f) => ma.atan(f);
        public static d3 atan(this d3 f) => ma.atan(f);
        public static d2 atan(this d2 f) => ma.atan(f);
        public static d1 atan(this d1 f) => ma.atan(f);
        
        // Arctangent2
        public static f4 atan2(this f4 f, f4 f2) => ma.atan2(f, f2);
        public static f3 atan2(this f3 f, f3 f2) => ma.atan2(f, f2);
        public static f2 atan2(this f2 f, f2 f2) => ma.atan2(f, f2);
        public static f1 atan2(this f1 f, f1 f2) => ma.atan2(f, f2);
        public static f1 atan2(this int f, int f2) => ma.atan2(f, f2);
        
        public static f4 atan2(this Vector4 f, Vector4 f2) => ma.atan2(f, f2);
        public static f3 atan2(this Vector3 f, Vector3 f2) => ma.atan2(f, f2);
        public static f2 atan2(this Vector2 f, Vector2 f2) => ma.atan2(f, f2);
        
        public static d4 atan2(this d4 f, d4 f2) => ma.atan2(f, f2);
        public static d3 atan2(this d3 f, d3 f2) => ma.atan2(f, f2);
        public static d2 atan2(this d2 f, d2 f2) => ma.atan2(f, f2);
        public static d1 atan2(this d1 f, d1 f2) => ma.atan2(f, f2);
        
        
        /// Arc cotangent
        public static f4 acot(this f4 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f3 acot(this f3 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f2 acot(this f2 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f1 acot(this f1 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f1 acot(this int f) => f.rcp().atan();
        
        /// <inheritdoc cref="acot(f4)"/>
        public static d4 acot(this d4 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static d3 acot(this d3 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static d2 acot(this d2 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static d1 acot(this d1 f) => f.rcp().atan();
        
        /// <inheritdoc cref="acot(f4)"/>
        public static f4 acot(this Vector4 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f3 acot(this Vector3 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(f4)"/>
        public static f2 acot(this Vector2 f) => f.rcp().atan();
        
        /// Arc secant
        public static f4 asec(this f4 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f3 asec(this f3 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f2 asec(this f2 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f1 asec(this f1 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f1 asec(this int f) => f.rcp().acos();
        
        /// <inheritdoc cref="asec(f4)"/>
        public static d4 asec(this d4 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static d3 asec(this d3 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static d2 asec(this d2 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static d1 asec(this d1 f) => f.rcp().acos();
        
        /// <inheritdoc cref="asec(f4)"/>
        public static f4 asec(this Vector4 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f3 asec(this Vector3 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(f4)"/>
        public static f2 asec(this Vector2 f) => f.rcp().acos();
        
        /// Arc cosecant
        public static f4 acsc(this f4 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f3 acsc(this f3 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f2 acsc(this f2 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f1 acsc(this f1 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f1 acsc(this int f) => f.rcp().asin();
        
        /// <inheritdoc cref="acsc(f4)"/>
        public static d4 acsc(this d4 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static d3 acsc(this d3 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static d2 acsc(this d2 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static d1 acsc(this d1 f) => f.rcp().asin();
        
        /// <inheritdoc cref="acsc(f4)"/>
        public static f4 acsc(this Vector4 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f3 acsc(this Vector3 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(f4)"/>
        public static f2 acsc(this Vector2 f) => f.rcp().asin();


        // Sine²
        
        public static f4 sin2(this f4 f) => cos(2 * f).inv() * 0.5f;
        public static f3 sin2(this f3 f) => cos(2 * f).inv() * 0.5f;
        public static f2 sin2(this f2 f) => cos(2 * f).inv() * 0.5f;
        public static f1 sin2(this f1 f) => cos(2 * f).inv() * 0.5f;
        public static f1 sin2(this int f) => cos(2 * f).inv() * 0.5f;
        
        public static f4 sin2(this Vector4 f) => cos(2 * f).inv() * 0.5f;
        public static f3 sin2(this Vector3 f) => cos(2 * f).inv() * 0.5f;
        public static f2 sin2(this Vector2 f) => cos(2 * f).inv() * 0.5f;
        
        public static d4 sin2(this d4 f) => cos(2 * f).inv() * 0.5f;
        public static d3 sin2(this d3 f) => cos(2 * f).inv() * 0.5f;
        public static d2 sin2(this d2 f) => cos(2 * f).inv() * 0.5f;
        public static d1 sin2(this d1 f) => cos(2 * f).inv() * 0.5f;
        
        // Cosine²
        public static f4 cos2(this f4 f) => (1 + cos(2 * f)) * 0.5f;
        public static f3 cos2(this f3 f) => (1 + cos(2 * f)) * 0.5f;
        public static f2 cos2(this f2 f) => (1 + cos(2 * f)) * 0.5f;
        public static f1 cos2(this f1 f) => (1 + cos(2 * f)) * 0.5f;
        public static f1 cos2(this int f) => (1 + cos(2 * f)) * 0.5f;
        
        public static f4 cos2(this Vector4 f) => (1 + cos(2 * f)) * 0.5f;
        public static f3 cos2(this Vector3 f) => (1 + cos(2 * f)) * 0.5f;
        public static f2 cos2(this Vector2 f) => (1 + cos(2 * f)) * 0.5f;
        
        public static d4 cos2(this d4 f) => (1 + cos(2 * f)) * 0.5f;
        public static d3 cos2(this d3 f) => (1 + cos(2 * f)) * 0.5f;
        public static d2 cos2(this d2 f) => (1 + cos(2 * f)) * 0.5f;
        public static d1 cos2(this d1 f) => (1 + cos(2 * f)) * 0.5f;

        /// Tangent²
        public static f4 tan2(this f4 f)
        {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f3 tan2(this f3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f2 tan2(this f2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f1 tan2(this f1 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f1 tan2(this int f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        
        /// <inheritdoc cref="tan2(f4)"/>
        public static f4 tan2(this Vector4 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f3 tan2(this Vector3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static f2 tan2(this Vector2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static d4 tan2(this d4 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static d3 tan2(this d3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static d2 tan2(this d2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(f4)"/>
        public static d1 tan2(this d1 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        
        /// Secant²
        public static f4 sec2(this f4 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f3 sec2(this f3 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f2 sec2(this f2 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f1 sec2(this f1 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f1 sec2(this int f) => f.cos2().rcp();
        
        /// <inheritdoc cref="sec2(f4)"/>
        public static f4 sec2(this Vector4 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f3 sec2(this Vector3 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static f2 sec2(this Vector2 f) => f.cos2().rcp();
        
        /// <inheritdoc cref="sec2(f4)"/>
        public static d4 sec2(this d4 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static d3 sec2(this d3 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static d2 sec2(this d2 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(f4)"/>
        public static d1 sec2(this d1 f) => f.cos2().rcp();
        
        
        /// Radians to Degrees
        public static f4 deg(this f4 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f3 deg(this f3 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f2 deg(this f2 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f1 deg(this f1 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f1 deg(this int f) => ma.degrees(f);
        
        /// <inheritdoc cref="deg(f4)"/>
        public static f4 deg(this Vector4 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f3 deg(this Vector3 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static f2 deg(this Vector2 f) => ma.degrees(f);
        
        /// <inheritdoc cref="deg(f4)"/>
        public static d4 deg(this d4 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static d3 deg(this d3 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static d2 deg(this d2 f) => ma.degrees(f);
        /// <inheritdoc cref="deg(f4)"/>
        public static d1 deg(this d1 f) => ma.degrees(f);
        
        
        // Degrees To Radians
        public static f4 rad(this f4 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f3 rad(this f3 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f2 rad(this f2 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f1 rad(this f1 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f1 rad(this int f) => ma.radians(f);
        
        /// <inheritdoc cref="rad(f4)"/>
        public static f4 rad(this Vector4 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f3 rad(this Vector3 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static f2 rad(this Vector2 f) => ma.radians(f);
        
        /// <inheritdoc cref="rad(f4)"/>
        public static d4 rad(this d4 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static d3 rad(this d3 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static d2 rad(this d2 f) => ma.radians(f);
        /// <inheritdoc cref="rad(f4)"/>
        public static d1 rad(this d1 f) => ma.radians(f);
        
        
        /// Cosine-Sine combined
        public static float2 cossin(this float f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(f4)"/>
        public static float2 cossin(this int f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(f4)"/>
        public static float2x2 cossin(this float2 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(f4)"/>
        public static float3x2 cossin(this float3 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(f4)"/>
        public static float4x2 cossin(this float4 f) => new(f.cos(), f.sin());
        
        
        /// Sine-Cosine combined
        public static float2 sincos(this float f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float2 sincos(this int f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float2x2 sincos(this float2 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float3x2 sincos(this float3 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float4x2 sincos(this float4 f) => new(f.sin(), f.cos());

        
        /// Cosine-Sine combined - non allocating
        public static void cossin(this float2 f2, float f) => math.sincos(f, out f2.y, out f2.x);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float2 f2, int f) => math.sincos(f, out f2.y, out f2.x);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float2x2 f2, float2 f) => math.sincos(f, out f2.c1, out f2.c0);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float3x2 f2,float3 f) => math.sincos(f, out f2.c1, out f2.c0);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float4x2 f2, float4 f) => math.sincos(f, out f2.c1, out f2.c0);

        
        /// Sine-Cosine combined - non allocating
        public static void sincos(this float2 f2, float f) => math.sincos(f, out f2.x, out f2.y);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float2 f2, int f) => math.sincos(f, out f2.x, out f2.y);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float2x2 f2, float2 f) => math.sincos(f, out f2.c0, out f2.c1);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float3x2 f2, float3 f) => math.sincos(f, out f2.c0, out f2.c1);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float4x2 f2, float4 f) => math.sincos(f, out f2.c0, out f2.c1);

    }
}