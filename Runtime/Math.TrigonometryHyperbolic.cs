using UnityEngine;

namespace Unity.Mathematics
{
    public partial class mathx
    {

        // Move Sec To Here or move above to "Trigonometry)

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
        
                
        // Hyperbolic Secant
        
        public static float4 sech(this float4 f) => f.cosh().rcp();
        public static float3 sech(this float3 f) => f.cosh().rcp();
        public static float2 sech(this float2 f) => f.cosh().rcp();
        public static float sech(this float f) => f.cosh().rcp();
        public static float sech(this int f) => f.cosh().rcp();
        
        public static float4 sech(this Vector4 f) => f.cosh().rcp();
        public static float3 sech(this Vector3 f) => f.cosh().rcp();
        public static float2 sech(this Vector2 f) => f.cosh().rcp();
        
        public static double4 sech(this double4 f) => f.cosh().rcp();
        public static double3 sech(this double3 f) => f.cosh().rcp();
        public static double2 sech(this double2 f) => f.cosh().rcp();
        public static double sech(this double f) => f.cosh().rcp();
        
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
        
        public static float4 coth(this Vector4 f) => f.tanh().rcp();
        public static float3 coth(this Vector3 f) => f.tanh().rcp();
        public static float2 coth(this Vector2 f) => f.tanh().rcp();
        
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
        
        public static float4 csch(this Vector4 f) => f.sinh().rcp();
        public static float3 csch(this Vector3 f) => f.sinh().rcp();
        public static float2 csch(this Vector2 f) => f.sinh().rcp();
        
               // Inverse Hyperbolic Arcs ---------------------------------------------------
        
        // Hyperbolic Arccosine

        public static float4 acosh(this float4 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static float3 acosh(this float3 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static float2 acosh(this float2 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static float acosh(this float f) => (f + (f.sq() - 1).sqrt()).ln();
        public static float acosh(this int f) => (f + (f.sq() - 1).sqrt()).ln();
        
        public static float4 acosh(this Vector4 f) => f.asfloat().acosh();
        public static float3 acosh(this Vector3 f) => f.asfloat().acosh();
        public static float2 acosh(this Vector2 f) => f.asfloat().acosh();
        
        public static double4 acosh(this double4 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static double3 acosh(this double3 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static double2 acosh(this double2 f) => (f + (f.sq() - 1).sqrt()).ln();
        public static double acosh(this double f) => (f + (f.sq() - 1).sqrt()).ln();
        
        // Hyperbolic Arcsine
        
        public static float4 asinh(this float4 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static float3 asinh(this float3 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static float2 asinh(this float2 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static float asinh(this float f) => (f + (f.sq() + 1).sqrt()).ln();
        public static float asinh(this int f) => (f + (f.sq() + 1).sqrt()).ln();
        
        public static float4 asinh(this Vector4 f) => f.asfloat().asinh();
        public static float3 asinh(this Vector3 f) => f.asfloat().asinh();
        public static float2 asinh(this Vector2 f) => f.asfloat().asinh();
        
        public static double4 asinh(this double4 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static double3 asinh(this double3 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static double2 asinh(this double2 f) => (f + (f.sq() + 1).sqrt()).ln();
        public static double asinh(this double f) => (f + (f.sq() + 1).sqrt()).ln();
        
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