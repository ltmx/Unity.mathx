using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

namespace UME
{
    public partial class Math
    {
        //cotangent
        public static float4 cot(this float4 f) => f.tan().rcp();
        public static float3 cot(this float3 f) => f.tan().rcp();
        public static float2 cot(this float2 f) => f.tan().rcp();
        public static float cot(this float f) => f.tan().rcp();
        public static float cot(this int f) => f.tan().rcp();
        
        public static double4 cot(this double4 f) => f.tan().rcp();
        public static double3 cot(this double3 f) => f.tan().rcp();
        public static double2 cot(this double2 f) => f.tan().rcp();
        
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
        
        // Move Sec To Here or move above to "Trigonometry)

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
        
        public static Vector4 acot(this Vector4 f) => f.rcp().atan();
        public static Vector3 acot(this Vector3 f) => f.rcp().atan();
        public static Vector2 acot(this Vector2 f) => f.rcp().atan();
        
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
        
        public static Vector4 asec(this Vector4 f) => f.rcp().acos();
        public static Vector3 asec(this Vector3 f) => f.rcp().acos();
        public static Vector2 asec(this Vector2 f) => f.rcp().acos();
        
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
        
        public static Vector4 acsc(this Vector4 f) => f.rcp().asin();
        public static Vector3 acsc(this Vector3 f) => f.rcp().asin();
        public static Vector2 acsc(this Vector2 f) => f.rcp().asin();
        
        // Hyperbolic Cotangent
        public static float4 coth(this float4 f) => f.tanh().rcp();
        public static float3 coth(this float3 f) => f.tanh().rcp();
        public static float2 coth(this float2 f) => f.tanh().rcp();
        public static float coth(this float f) => f.tanh().rcp();
        public static float coth(this int f) => f.tanh().rcp();
        
        public static double4 coth(this double4 f) => f.tanh().rcp();
        public static double3 coth(this double3 f) => f.tanh().rcp();
        public static double2 coth(this double2 f) => f.tanh().rcp();
        public static double coth(this double f) => f.tanh().rcp();
        
        public static Vector4 coth(this Vector4 f) => f.tanh().rcp();
        public static Vector3 coth(this Vector3 f) => f.tanh().rcp();
        public static Vector2 coth(this Vector2 f) => f.tanh().rcp();
        
        // sech already implemented
        
        // Hyperbolic Cosecant
        public static float4 csch(this float4 f) => f.sinh().rcp();
        public static float3 csch(this float3 f) => f.sinh().rcp();
        public static float2 csch(this float2 f) => f.sinh().rcp();
        public static float csch(this float f) => f.sinh().rcp();
        public static float csch(this int f) => f.sinh().rcp();
        
        public static double4 csch(this double4 f) => f.sinh().rcp();
        public static double3 csch(this double3 f) => f.sinh().rcp();
        public static double2 csch(this double2 f) => f.sinh().rcp();
        public static double csch(this double f) => f.sinh().rcp();
        
        public static Vector4 csch(this Vector4 f) => f.sinh().rcp();
        public static Vector3 csch(this Vector3 f) => f.sinh().rcp();
        public static Vector2 csch(this Vector2 f) => f.sinh().rcp();
        
        // asech already implemented
        
        // acsch already implemented
        
               // Inverse Hyperbolic Arcs ---------------------------------------------------
        
        // Hyperbolic Arccosine // Verified

        public static float4 acosh(this float4 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float3 acosh(this float3 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float2 acosh(this float2 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float acosh(this float f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static float acosh(this int f) => (f + (f.sqr() - 1).sqrt()).ln();
        
        public static float4 acosh(this Vector4 f) => f.asfloat().acosh();
        public static float3 acosh(this Vector3 f) => f.asfloat().acosh();
        public static float2 acosh(this Vector2 f) => f.asfloat().acosh();
        
        public static double4 acosh(this double4 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double3 acosh(this double3 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double2 acosh(this double2 f) => (f + (f.sqr() - 1).sqrt()).ln();
        public static double acosh(this double f) => (f + (f.sqr() - 1).sqrt()).ln();
        
        // Hyperbolic Arcsine // Verified
        
        public static float4 asinh(this float4 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float3 asinh(this float3 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float2 asinh(this float2 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float asinh(this float f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static float asinh(this int f) => (f + (f.sqr() + 1).sqrt()).ln();
        
        public static float4 asinh(this Vector4 f) => f.asfloat().asinh();
        public static float3 asinh(this Vector3 f) => f.asfloat().asinh();
        public static float2 asinh(this Vector2 f) => f.asfloat().asinh();
        
        public static double4 asinh(this double4 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double3 asinh(this double3 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double2 asinh(this double2 f) => (f + (f.sqr() + 1).sqrt()).ln();
        public static double asinh(this double f) => (f + (f.sqr() + 1).sqrt()).ln();
        
        // Hyperbolic Arctangent // Verified

        public static float4 atanh(this float4 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float3 atanh(this float3 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float2 atanh(this float2 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float atanh(this float f) => ((1 + f) / (1 - f)).ln() / 2;
        public static float atanh(this int f) => ((1 + f) / (1 - f)).ln() / 2;
        
        public static float4 atanh(this Vector4 f) => f.asfloat().atanh();
        public static float3 atanh(this Vector3 f) => f.asfloat().atanh();
        public static float2 atanh(this Vector2 f) => f.asfloat().atanh();
        
        public static double4 atanh(this double4 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double3 atanh(this double3 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double2 atanh(this double2 f) => ((1 + f) / (1 - f)).ln() / 2;
        public static double atanh(this double f) => ((1 + f) / (1 - f)).ln() / 2;
        
        // Hyperbolic Arccotangent // Verified
        
        public static float4 acoth(this float4 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float3 acoth(this float3 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float2 acoth(this float2 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float acoth(this float f) => ((f + 1) / (f - 1)).ln() / 2;
        public static float acoth(this int f) => ((f + 1) / (f - 1)).ln() / 2;

        public static float4 acoth(this Vector4 f) => f.asfloat().acoth();
        public static float3 acoth(this Vector3 f) => f.asfloat().acoth();
        public static float2 acoth(this Vector2 f) => f.asfloat().acoth();
        
        public static double4 acoth(this double4 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double3 acoth(this double3 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double2 acoth(this double2 f) => ((f + 1) / (f - 1)).ln() / 2;
        public static double acoth(this double f) => ((f + 1) / (f - 1)).ln() / 2;
        
        // Hyperbolic Arcsecant // Verified

        public static float4 asech(this float4 f) => f.rcp().acosh();
        public static float3 asech(this float3 f) => f.rcp().acosh();
        public static float2 asech(this float2 f) => f.rcp().acosh();
        public static float asech(this float f) => f.rcp().acosh();
        public static float asech(this int f) => f.rcp().acosh();// Previous : ((1 + (1 - f.sqr().sqrt())) / f).ln();
        
        public static float4 asech(this Vector4 f) => f.rcp().acosh();
        public static float3 asech(this Vector3 f) => f.rcp().acosh();
        public static float2 asech(this Vector2 f) => f.rcp().acosh();
        
        public static double4 asech(this double4 f) => f.rcp().acosh();
        public static double3 asech(this double3 f) => f.rcp().acosh();
        public static double2 asech(this double2 f) => f.rcp().acosh();
        public static double asech(this double f) => f.rcp().acosh();
        
        // Hyperbolic Arccosecant // Verified

        public static float4 acsch(this float4 f) => f.rcp().asinh();
        public static float3 acsch(this float3 f) => f.rcp().asinh();
        public static float2 acsch(this float2 f) => f.rcp().asinh();
        public static float acsch(this float f) => f.rcp().asinh();
        public static float acsch(this int f) => f.rcp().asinh(); // Previous : ((1 + (1 + f.sqr().sqrt())) / f).ln();
        
        public static float4 acsch(this Vector4 f) => f.rcp().asinh();
        public static float3 acsch(this Vector3 f) => f.rcp().asinh();
        public static float2 acsch(this Vector2 f) => f.rcp().asinh();
        
        public static double4 acsch(this double4 f) => f.rcp().asinh();
        public static double3 acsch(this double3 f) => f.rcp().asinh();
        public static double2 acsch(this double2 f) => f.rcp().asinh();
        public static double acsch(this double f) => f.rcp().asinh();
        
        

    }
}