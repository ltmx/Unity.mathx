using Unity.Mathematics;
using UnityEngine;

namespace UME
{
    public static  partial class UnityMathematicsExtensions
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


        // Hyperbolic Sine
        
        public static float4 sinh(this float4 f) => math.sinh(f);
        public static float3 sinh(this float3 f) => math.sinh(f);
        public static float2 sinh(this float2 f) => math.sinh(f);
        public static float sinh(this float f) => math.sinh(f);
        public static float sinh(this int f) => math.sinh(f);
        
        public static float4 sinh(this Vector4 f) => math.sinh(f);
        public static float3 sinh(this Vector3 f) => math.sinh(f);
        public static float2 sinh(this Vector2 f) => math.sinh(f);
        
        public static double4 sinh(this double4 f) => math.sinh(f);
        public static double3 sinh(this double3 f) => math.sinh(f);
        public static double2 sinh(this double2 f) => math.sinh(f);
        public static double sinh(this double f) => math.sinh(f);
        
        // Hyperbolic Cosine
        public static float4 cosh(this float4 f) => math.cosh(f);
        public static float3 cosh(this float3 f) => math.cosh(f);
        public static float2 cosh(this float2 f) => math.cosh(f);
        public static float cosh(this float f) => math.cosh(f);
        public static float cosh(this int f) => math.cosh(f);
        
        public static float4 cosh(this Vector4 f) => math.cosh(f);
        public static float3 cosh(this Vector3 f) => math.cosh(f);
        public static float2 cosh(this Vector2 f) => math.cosh(f);
        
        public static double4 cosh(this double4 f) => math.cosh(f);
        public static double3 cosh(this double3 f) => math.cosh(f);
        public static double2 cosh(this double2 f) => math.cosh(f);
        public static double cosh(this double f) => math.cosh(f);
        
        // Hyperbolic Tangent
        
        public static float4 tanh(this float4 f) => math.tanh(f);
        public static float3 tanh(this float3 f) => math.tanh(f);
        public static float2 tanh(this float2 f) => math.tanh(f);
        public static float tanh(this float f) => math.tanh(f);
        public static float tanh(this int f) => math.tanh(f);
        
        public static float4 tanh(this Vector4 f) => math.tanh(f);
        public static float3 tanh(this Vector3 f) => math.tanh(f);
        public static float2 tanh(this Vector2 f) => math.tanh(f);
        
        public static double4 tanh(this double4 f) => math.tanh(f);
        public static double3 tanh(this double3 f) => math.tanh(f);
        public static double2 tanh(this double2 f) => math.tanh(f);
        public static double tanh(this double f) => math.tanh(f);
        
        // Hyperbolic Secant ?
        

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
        
        // Arcsecant ?
        
        // Secant
        
        public static float4 sec(this float4 f) => f.cosh().rcp();
        public static float3 sec(this float3 f) => f.cosh().rcp();
        public static float2 sec(this float2 f) => f.cosh().rcp();
        public static float sec(this float f) => f.cosh().rcp();
        public static float sec(this int f) => f.cosh().rcp();
        
        public static float4 sec(this Vector4 f) => f.cosh().rcp();
        public static float3 sec(this Vector3 f) => f.cosh().rcp();
        public static float2 sec(this Vector2 f) => f.cosh().rcp();
        
        public static double4 sec(this double4 f) => f.cosh().rcp();
        public static double3 sec(this double3 f) => f.cosh().rcp();
        public static double2 sec(this double2 f) => f.cosh().rcp();
        public static double sec(this double f) => f.cosh().rcp();


        // Sine²
        
        public static float4 sin2(this float4 f) => (1 - f.cos()) / 2;
        public static float3 sin2(this float3 f) => (1 - f.cos()) / 2;
        public static float2 sin2(this float2 f) => (1 - f.cos()) / 2;
        public static float sin2(this float f) => (1 - f.cos()) / 2;
        public static float sin2(this int f) => (1 - f.cos()) / 2;
        
        public static float4 sin2(this Vector4 f) => (1 - f.cos()) / 2;
        public static float3 sin2(this Vector3 f) => (1 - f.cos()) / 2;
        public static float2 sin2(this Vector2 f) => (1 - f.cos()) / 2;
        
        public static double4 sin2(this double4 f) => (1 - f.cos()) / 2;
        public static double3 sin2(this double3 f) => (1 - f.cos()) / 2;
        public static double2 sin2(this double2 f) => (1 - f.cos()) / 2;
        public static double sin2(this double f) => (1 - f.cos()) / 2;
        
        // Cosine²
        
        public static float4 cos2(this float4 f) => (1 + f.cos()) / 2;
        public static float3 cos2(this float3 f) => (1 + f.cos()) / 2;
        public static float2 cos2(this float2 f) => (1 + f.cos()) / 2;
        public static float cos2(this float f) => (1 + f.cos()) / 2;
        public static float cos2(this int f) => (1 + f.cos()) / 2;
        
        public static float4 cos2(this Vector4 f) => (1 + f.cos()) / 2;
        public static float3 cos2(this Vector3 f) => (1 + f.cos()) / 2;
        public static float2 cos2(this Vector2 f) => (1 + f.cos()) / 2;
        
        public static double4 cos2(this double4 f) => (1 + f.cos()) / 2;
        public static double3 cos2(this double3 f) => (1 + f.cos()) / 2;
        public static double2 cos2(this double2 f) => (1 + f.cos()) / 2;
        public static double cos2(this double f) => (1 + f.cos()) / 2;

        // Tangent²
        
        public static float4 tan2(this float4 f) => f.sec2() - 1;
        public static float3 tan2(this float3 f) => f.sec2() - 1;
        public static float2 tan2(this float2 f) => f.sec2() - 1;
        public static float tan2(this float f) => f.sec2() - 1;
        public static float tan2(this int f) => f.sec2() - 1;
        
        public static float4 tan2(this Vector4 f) => f.sec2() - 1;
        public static float3 tan2(this Vector3 f) => f.sec2() - 1;
        public static float2 tan2(this Vector2 f) => f.sec2() - 1;
        
        public static double4 tan2(this double4 f) => f.sec2() - 1;
        public static double3 tan2(this double3 f) => f.sec2() - 1;
        public static double2 tan2(this double2 f) => f.sec2() - 1;
        public static double tan2(this double f) => f.sec2() - 1;
        
        // Secant²
        
        public static float4 sec2(this float4 f) => f.cosh().sqr().rcp();
        public static float3 sec2(this float3 f) => f.cosh().sqr().rcp();
        public static float2 sec2(this float2 f) => f.cosh().sqr().rcp();
        public static float sec2(this float f) => f.cosh().sqr().rcp();
        public static float sec2(this int f) => f.cosh().sqr().rcp();
        
        public static float4 sec2(this Vector4 f) => f.cosh().sqr().rcp();
        public static float3 sec2(this Vector3 f) => f.cosh().sqr().rcp();
        public static float2 sec2(this Vector2 f) => f.cosh().sqr().rcp();
        
        public static double4 sec2(this double4 f) => f.cosh().sqr().rcp();
        public static double3 sec2(this double3 f) => f.cosh().sqr().rcp();
        public static double2 sec2(this double2 f) => f.cosh().sqr().rcp();
        public static double sec2(this double f) => f.cosh().sqr().rcp();
        
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

        // Inverse Hyperbolic Arcs ---------------------------------------------------
        
        // Hyperbolic Arccosine

        public static float4 acosh(this float4 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float3 acosh(this float3 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float2 acosh(this float2 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float acosh(this float f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float acosh(this int f) => (f + (f.sqr() - 1).sqrt()).ln();
        
        public static float4 acosh(this Vector4 f) => (f.asfloat() + (f.sqr() - 1).sqrt()).ln();
        public static float3 acosh(this Vector3 f) => (f.asfloat() + (f.sqr() - 1).sqrt()).ln();
        public static float2 acosh(this Vector2 f) => (f.asfloat() + (f.sqr() - 1).sqrt()).ln();
        
        public static double4 acosh(this double4 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double3 acosh(this double3 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double2 acosh(this double2 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double acosh(this double f) => (f + (f.sqr() - 1).sqrt()).ln();
        
        // Hyperbolic Arcsine
        
        public static float4 asinh(this float4 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float3 asinh(this float3 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float2 asinh(this float2 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float asinh(this float f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float asinh(this int f) => (f + (f.sqr() + 1).sqrt()).ln();
        
        public static float4 asinh(this Vector4 f) => (f.asfloat() + (f.sqr() + 1).sqrt()).ln();
        public static float3 asinh(this Vector3 f) => (f.asfloat() + (f.sqr() + 1).sqrt()).ln();
        public static float2 asinh(this Vector2 f) => (f.asfloat() + (f.sqr() + 1).sqrt()).ln();
        
        public static double4 asinh(this double4 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double3 asinh(this double3 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double2 asinh(this double2 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double asinh(this double f) => (f + (f.sqr() + 1).sqrt()).ln();
        
        // Hyperbolic Arctangent

        public static float4 atanh(this float4 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float3 atanh(this float3 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float2 atanh(this float2 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float atanh(this float f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float atanh(this int f) => ((1 + f) / (1 - f)).ln() / 2;
        
        public static float4 atanh(this Vector4 f) => ((1 + f.asfloat()) / (1 - f.asfloat())).ln() / 2;
        public static float3 atanh(this Vector3 f) => ((1 + f.asfloat()) / (1 - f.asfloat())).ln() / 2;
        public static float2 atanh(this Vector2 f) => ((1 + f.asfloat()) / (1 - f.asfloat())).ln() / 2;
        
        public static double4 atanh(this double4 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double3 atanh(this double3 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double2 atanh(this double2 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double atanh(this double f) => ((1 + f) / (1 - f)).ln() / 2;
        
        // Hyperbolic Arccotangent
        
        public static float4 acoth(this float4 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float3 acoth(this float3 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float2 acoth(this float2 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float acoth(this float f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float acoth(this int f) => ((f + 1) / (f - 1)).ln() / 2;
        
        public static float4 acoth(this Vector4 f) => ((f.asfloat() + 1) / (f.asfloat() - 1)).ln() / 2;
        public static float3 acoth(this Vector3 f) => ((f.asfloat() + 1) / (f.asfloat() - 1)).ln() / 2;
        public static float2 acoth(this Vector2 f) => ((f.asfloat() + 1) / (f.asfloat() - 1)).ln() / 2;
        
        public static double4 acoth(this double4 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double3 acoth(this double3 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double2 acoth(this double2 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double acoth(this double f) => ((f + 1) / (f - 1)).ln() / 2;
        
        // Hyperbolic Arcsecant

        public static float4 asech(this float4 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float3 asech(this float3 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float2 asech(this float2 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float asech(this float f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float asech(this int f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        
        public static float4 asech(this Vector4 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float3 asech(this Vector3 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static float2 asech(this Vector2 f) => ((1 + (1 - f.sqr().sqrt())) / f.asfloat()).ln();
        
        public static double4 asech(this double4 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static double3 asech(this double3 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static double2 asech(this double2 f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        public static double asech(this double f) => ((1 + (1 - f.sqr().sqrt())) / f).ln();
        
        // Hyperbolic Arccosecant

        public static float4 acsch(this float4 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float3 acsch(this float3 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float2 acsch(this float2 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float acsch(this float f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float acsch(this int f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        
        public static float4 acsch(this Vector4 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float3 acsch(this Vector3 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static float2 acsch(this Vector2 f) => ((1 + (1 + f.sqr().sqrt())) / f.asfloat()).ln();
        
        public static double4 acsch(this double4 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static double3 acsch(this double3 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static double2 acsch(this double2 f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        public static double acsch(this double f) => ((1 + (1 + f.sqr().sqrt())) / f).ln();
        
        
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