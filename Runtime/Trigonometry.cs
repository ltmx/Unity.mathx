using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class Math
    {
        // Trigonometry ----------------------------------------------------------------------------------

        // Sine
        public static float4 sin(this float4 f) => math.sin(f);
        public static float3 sin(this float3 f) => math.sin(f);
        public static float2 sin(this float2 f) => math.sin(f);
        public static float sin(this float f) => math.sin(f);
        public static float sin(this int f) => math.sin(f);
        
        public static float4 sin(this Vector4 f) => math.sin(f);
        public static float3 sin(this Vector3 f) => math.sin(f);
        public static float2 sin(this Vector2 f) => math.sin(f);
        
        public static double4 sin(this double4 f) => math.sin(f);
        public static double3 sin(this double3 f) => math.sin(f);
        public static double2 sin(this double2 f) => math.sin(f);
        public static double sin(this double f) => math.sin(f);
        
        // Cosine
        public static float4 cos(this float4 f) => math.cos(f);
        public static float3 cos(this float3 f) => math.cos(f);
        public static float2 cos(this float2 f) => math.cos(f);
        public static float cos(this float f) => math.cos(f);
        public static float cos(this int f) => math.cos(f);
        
        public static float4 cos(this Vector4 f) => math.cos(f);
        public static float3 cos(this Vector3 f) => math.cos(f);
        public static float2 cos(this Vector2 f) => math.cos(f);
        
        public static double4 cos(this double4 f) => math.cos(f);
        public static double3 cos(this double3 f) => math.cos(f);
        public static double2 cos(this double2 f) => math.cos(f);
        public static double cos(this double f) => math.cos(f);

        // Tangent
        public static float4 tan(this float4 f) => math.tan(f);
        public static float3 tan(this float3 f) => math.tan(f);
        public static float2 tan(this float2 f) => math.tan(f);
        public static float tan(this float f) => math.tan(f);
        public static float tan(this int f) => math.tan(f);
        
        public static float4 tan(this Vector4 f) => math.tan(f);
        public static float3 tan(this Vector3 f) => math.tan(f);
        public static float2 tan(this Vector2 f) => math.tan(f);
        
        public static double4 tan(this double4 f) => math.tan(f);
        public static double3 tan(this double3 f) => math.tan(f);
        public static double2 tan(this double2 f) => math.tan(f);
        public static double tan(this double f) => math.tan(f);
        
        // Secant
        public static float4 sec(this float4 f) => f.rcp().cos();
        public static float3 sec(this float3 f) => f.rcp().cos();
        public static float2 sec(this float2 f) => f.rcp().cos();
        public static float sec(this float f) => f.rcp().cos();
        public static float sec(this int f) => f.rcp().cos();
        public static float4 sec(this Vector4 f) => f.rcp().cos();
        public static float3 sec(this Vector3 f) => f.rcp().cos();
        public static float2 sec(this Vector2 f) => f.rcp().cos();
        
        public static double4 sec(this double4 f) => f.rcp().cos();
        public static double3 sec(this double3 f) => f.rcp().cos();
        public static double2 sec(this double2 f) => f.rcp().cos();
        public static double sec(this double f) => f.rcp().cos();
        
        // Cotangent
        public static float4 cot(this float4 f) => f.tan().rcp();
        public static float3 cot(this float3 f) => f.tan().rcp();
        public static float2 cot(this float2 f) => f.tan().rcp();
        public static float cot(this float f) => f.tan().rcp();
        public static float cot(this int f) => f.tan().rcp();
        
        public static double4 cot(this double4 f) => f.tan().rcp();
        public static double3 cot(this double3 f) => f.tan().rcp();
        public static double2 cot(this double2 f) => f.tan().rcp();
        public static double cot(this double f) => f.tan().rcp();
        
        public static Vector4 cot(this Vector4 f) => f.tan().rcp();
        public static Vector3 cot(this Vector3 f) => f.tan().rcp();
        public static Vector2 cot(this Vector2 f) => f.tan().rcp();
        
        // Cosecant
        public static float4 csc(this float4 f) => f.sin().rcp();
        public static float3 csc(this float3 f) => f.sin().rcp();
        public static float2 csc(this float2 f) => f.sin().rcp();
        public static float csc(this float f) => f.sin().rcp();
        public static float csc(this int f) => f.sin().rcp();
        
        public static double4 csc(this double4 f) => f.sin().rcp();
        public static double3 csc(this double3 f) => f.sin().rcp();
        public static double2 csc(this double2 f) => f.sin().rcp();
        public static double csc(this double f) => f.sin().rcp();
        
        public static Vector4 csc(this Vector4 f) => f.sin().rcp();
        public static Vector3 csc(this Vector3 f) => f.sin().rcp();
        public static Vector2 csc(this Vector2 f) => f.sin().rcp();
        
        // Arcsine
        public static float4 asin(this float4 f) => math.asin(f);
        public static float3 asin(this float3 f) => math.asin(f);
        public static float2 asin(this float2 f) => math.asin(f);
        public static float asin(this float f) => math.asin(f);
        public static float asin(this int f) => math.asin(f);
        
        public static float4 asin(this Vector4 f) => math.asin(f);
        public static float3 asin(this Vector3 f) => math.asin(f);
        public static float2 asin(this Vector2 f) => math.asin(f);
        
        public static double4 asin(this double4 f) => math.asin(f);
        public static double3 asin(this double3 f) => math.asin(f);
        public static double2 asin(this double2 f) => math.asin(f);
        public static double asin(this double f) => math.asin(f);
        
        // Arccosine
        public static float4 acos(this float4 f) => math.acos(f);
        public static float3 acos(this float3 f) => math.acos(f);
        public static float2 acos(this float2 f) => math.acos(f);
        public static float acos(this float f) => math.acos(f);
        public static float acos(this int f) => math.acos(f);
        
        public static float4 acos(this Vector4 f) => math.acos(f);
        public static float3 acos(this Vector3 f) => math.acos(f);
        public static float2 acos(this Vector2 f) => math.acos(f);
        
        public static double4 acos(this double4 f) => math.acos(f);
        public static double3 acos(this double3 f) => math.acos(f);
        public static double2 acos(this double2 f) => math.acos(f);
        public static double acos(this double f) => math.acos(f);

        // Arctangent
        public static float4 atan(this float4 f) => math.atan(f);
        public static float3 atan(this float3 f) => math.atan(f);
        public static float2 atan(this float2 f) => math.atan(f);
        public static float atan(this float f) => math.atan(f);
        public static float atan(this int f) => math.atan(f);
        
        public static float4 atan(this Vector4 f) => math.atan(f);
        public static float3 atan(this Vector3 f) => math.atan(f);
        public static float2 atan(this Vector2 f) => math.atan(f);
        
        public static double4 atan(this double4 f) => math.atan(f);
        public static double3 atan(this double3 f) => math.atan(f);
        public static double2 atan(this double2 f) => math.atan(f);
        public static double atan(this double f) => math.atan(f);
        
        // Arccotangent
        public static float4 acot(this float4 f) => f.rcp().atan();
        public static float3 acot(this float3 f) => f.rcp().atan();
        public static float2 acot(this float2 f) => f.rcp().atan();
        public static float acot(this float f) => f.rcp().atan();
        public static float acot(this int f) => f.rcp().atan();
        
        public static double4 acot(this double4 f) => f.rcp().atan();
        public static double3 acot(this double3 f) => f.rcp().atan();
        public static double2 acot(this double2 f) => f.rcp().atan();
        public static double acot(this double f) => f.rcp().atan();
        
        public static float4 acot(this Vector4 f) => f.rcp().atan();
        public static float3 acot(this Vector3 f) => f.rcp().atan();
        public static float2 acot(this Vector2 f) => f.rcp().atan();
        
        // Arcsecant
        public static float4 asec(this float4 f) => f.rcp().acos();
        public static float3 asec(this float3 f) => f.rcp().acos();
        public static float2 asec(this float2 f) => f.rcp().acos();
        public static float asec(this float f) => f.rcp().acos();
        public static float asec(this int f) => f.rcp().acos();
        
        public static double4 asec(this double4 f) => f.rcp().acos();
        public static double3 asec(this double3 f) => f.rcp().acos();
        public static double2 asec(this double2 f) => f.rcp().acos();
        public static double asec(this double f) => f.rcp().acos();
        
        public static float4 asec(this Vector4 f) => f.rcp().acos();
        public static float3 asec(this Vector3 f) => f.rcp().acos();
        public static float2 asec(this Vector2 f) => f.rcp().acos();
        
        // Arccosecant
        public static float4 acsc(this float4 f) => f.rcp().asin();
        public static float3 acsc(this float3 f) => f.rcp().asin();
        public static float2 acsc(this float2 f) => f.rcp().asin();
        public static float acsc(this float f) => f.rcp().asin();
        public static float acsc(this int f) => f.rcp().asin();
        
        public static double4 acsc(this double4 f) => f.rcp().asin();
        public static double3 acsc(this double3 f) => f.rcp().asin();
        public static double2 acsc(this double2 f) => f.rcp().asin();
        public static double acsc(this double f) => f.rcp().asin();
        
        public static float4 acsc(this Vector4 f) => f.rcp().asin();
        public static float3 acsc(this Vector3 f) => f.rcp().asin();
        public static float2 acsc(this Vector2 f) => f.rcp().asin();


        // Sine²
        
        public static float4 sin2(this float4 f) => (1 - cos(f*2)) / 2;
        public static float3 sin2(this float3 f) => (1 - cos(f*2)) / 2;
        public static float2 sin2(this float2 f) => (1 - cos(f*2)) / 2;
        public static float sin2(this float f) => (1 - cos(f*2)) / 2;
        public static float sin2(this int f) => (1 - cos(f*2)) / 2;
        
        public static float4 sin2(this Vector4 f) => (1 - cos(f*2)) / 2;
        public static float3 sin2(this Vector3 f) => (1 - cos(f*2)) / 2;
        public static float2 sin2(this Vector2 f) => (1 - cos(f*2)) / 2;
        
        public static double4 sin2(this double4 f) => (1 - cos(f*2)) / 2;
        public static double3 sin2(this double3 f) => (1 - cos(f*2)) / 2;
        public static double2 sin2(this double2 f) => (1 - cos(f*2)) / 2;
        public static double sin2(this double f) => (1 - cos(f*2)) / 2;
        
        // Cosine²
        public static float4 cos2(this float4 f) => (1 + cos(f*2)) / 2;
        public static float3 cos2(this float3 f) => (1 + cos(f*2)) / 2;
        public static float2 cos2(this float2 f) => (1 + cos(f*2)) / 2;
        public static float cos2(this float f) => (1 + cos(f*2)) / 2;
        public static float cos2(this int f) => (1 + cos(f*2)) / 2;
        
        public static float4 cos2(this Vector4 f) => (1 + cos(f*2)) / 2;
        public static float3 cos2(this Vector3 f) => (1 + cos(f*2)) / 2;
        public static float2 cos2(this Vector2 f) => (1 + cos(f*2)) / 2;
        
        public static double4 cos2(this double4 f) => (1 + cos(f*2)) / 2;
        public static double3 cos2(this double3 f) => (1 + cos(f*2)) / 2;
        public static double2 cos2(this double2 f) => (1 + cos(f*2)) / 2;
        public static double cos2(this double f) => (1 + cos(f*2)) / 2;

        // Tangent²
        public static float4 tan2(this float4 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float3 tan2(this float3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float2 tan2(this float2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float tan2(this float f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float tan2(this int f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        
        public static float4 tan2(this Vector4 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float3 tan2(this Vector3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static float2 tan2(this Vector2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        
        public static double4 tan2(this double4 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static double3 tan2(this double3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static double2 tan2(this double2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        public static double tan2(this double f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        
        // Secant²
        public static float4 sec2(this float4 f) => f.cos2().rcp();
        public static float3 sec2(this float3 f) => f.cos2().rcp();
        public static float2 sec2(this float2 f) => f.cos2().rcp();
        public static float sec2(this float f) => f.cos2().rcp();
        public static float sec2(this int f) => f.cos2().rcp();
        
        public static float4 sec2(this Vector4 f) => f.cos2().rcp();
        public static float3 sec2(this Vector3 f) => f.cos2().rcp();
        public static float2 sec2(this Vector2 f) => f.cos2().rcp();
        
        public static double4 sec2(this double4 f) => f.cos2().rcp();
        public static double3 sec2(this double3 f) => f.cos2().rcp();
        public static double2 sec2(this double2 f) => f.cos2().rcp();
        public static double sec2(this double f) => f.cos2().rcp();
        
        
        
        
        // Radians to Degrees
        public static float4 degrees(this float4 f) => math.degrees(f);
        public static float3 degrees(this float3 f) => math.degrees(f);
        public static float2 degrees(this float2 f) => math.degrees(f);
        public static float degrees(this float f) => math.degrees(f);
        public static float degrees(this int f) => math.degrees(f);
        
        public static float4 degrees(this Vector4 f) => math.degrees(f);
        public static float3 degrees(this Vector3 f) => math.degrees(f);
        public static float2 degrees(this Vector2 f) => math.degrees(f);
        
        public static double4 degrees(this double4 f) => math.degrees(f);
        public static double3 degrees(this double3 f) => math.degrees(f);
        public static double2 degrees(this double2 f) => math.degrees(f);
        public static double degrees(this double f) => math.degrees(f);
        
        // Degrees To Radians
        public static float4 radians(this float4 f) => math.radians(f);
        public static float3 radians(this float3 f) => math.radians(f);
        public static float2 radians(this float2 f) => math.radians(f);
        public static float radians(this float f) => math.radians(f);
        public static float radians(this int f) => math.radians(f);
        
        public static float4 radians(this Vector4 f) => math.radians(f);
        public static float3 radians(this Vector3 f) => math.radians(f);
        public static float2 radians(this Vector2 f) => math.radians(f);
        
        public static double4 radians(this double4 f) => math.radians(f);
        public static double3 radians(this double3 f) => math.radians(f);
        public static double2 radians(this double2 f) => math.radians(f);
        public static double radians(this double f) => math.radians(f);
        
        // Sine-Cosine combined
        public static float4x2 sincos(this float4 f4) {
            var f = new float4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static float3x2 sincos(this float3 f3) {
            var f = new float3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static float2x2 sincos(this float2 f2) {
            var f = new float2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }
        public static float2 sincos(this float f) {
            var f2 = new float2();
            math.sincos(f,out f2.x, out f2.y);
            return f2;
        }
        public static float4x2 sincos(this Vector4 f4) {
            var f = new float4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static float3x2 sincos(this Vector3 f3) {
            var f = new float3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static float2x2 sincos(this Vector2 f2) {
            var f = new float2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }

        public static double4x2 sincos(this double4 f4) {
            var f = new double4x2();
            math.sincos(f4,out f.c0, out f.c1);
            return f;
        }
        public static double3x2 sincos(this double3 f3) {
            var f = new double3x2();
            math.sincos(f3,out f.c0, out f.c1);
            return f;
        }
        public static double2x2 sincos(this double2 f2) {
            var f = new double2x2();
            math.sincos(f2,out f.c0, out f.c1);
            return f;
        }
        public static double2 sincos(this double f) {
            var f2 = new double2();
            math.sincos(f,out f2.x, out f2.y);
            return f2;
        }
        
    }
}