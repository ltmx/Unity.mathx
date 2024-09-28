#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public partial class mathx
    {

        // Move Sec To Here or move above to "Trigonometry)

        /// <inheritdoc cref="math.sinh(float4)"/>
        [MI(IL)] public static float4 sinh(this float4 f) => math.sinh(f);
        /// <inheritdoc cref="math.sinh(float3)"/>
        [MI(IL)] public static float3 sinh(this float3 f) => math.sinh(f);
        /// <inheritdoc cref="math.sinh(float2)"/>
        [MI(IL)] public static float2 sinh(this float2 f) => math.sinh(f);
        /// <inheritdoc cref="math.sinh(float)"/>
        [MI(IL)] public static float sinh(this float f) => math.sinh(f);

        /// <inheritdoc cref="math.cosh(float4)"/>
        [MI(IL)] public static float4 cosh(this float4 f) => math.cosh(f);
        /// <inheritdoc cref="math.cosh(float3)"/>
        [MI(IL)] public static float3 cosh(this float3 f) => math.cosh(f);
        /// <inheritdoc cref="math.cosh(float2)"/>
        [MI(IL)] public static float2 cosh(this float2 f) => math.cosh(f);
        /// <inheritdoc cref="math.cosh(float)"/>
        [MI(IL)] public static float cosh(this float f) => math.cosh(f);
        
        /// <inheritdoc cref="math.tanh(float4)"/>
        [MI(IL)] public static float4 tanh(this float4 f) => math.tanh(f);
        /// <inheritdoc cref="math.tanh(float3)"/>
        [MI(IL)] public static float3 tanh(this float3 f) => math.tanh(f);
        /// <inheritdoc cref="math.tanh(float2)"/>
        [MI(IL)] public static float2 tanh(this float2 f) => math.tanh(f);
        /// <inheritdoc cref="math.tanh(float)"/>
        [MI(IL)] public static float tanh(this float f) => math.tanh(f);


        /// Hyperbolic Secant
        [MI(IL)] public static float4 sech(this float4 f) => f.cosh().rcp();
        /// <inheritdoc cref="sech(float4)"/>
        [MI(IL)] public static float3 sech(this float3 f) => f.cosh().rcp();
        /// <inheritdoc cref="sech(float4)"/>
        [MI(IL)] public static float2 sech(this float2 f) => f.cosh().rcp();
        /// <inheritdoc cref="sech(float4)"/>
        [MI(IL)] public static float sech(this float f) => f.cosh().rcp();

        /// Hyperbolic Cotangent
        [MI(IL)] public static float4 coth(this float4 f) => f.tanh().rcp();
        /// <inheritdoc cref="coth(float4)"/>
        [MI(IL)] public static float3 coth(this float3 f) => f.tanh().rcp();
        /// <inheritdoc cref="coth(float4)"/>
        [MI(IL)] public static float2 coth(this float2 f) => f.tanh().rcp();
        /// <inheritdoc cref="coth(float4)"/>
        [MI(IL)] public static float coth(this float f) => f.tanh().rcp();
        
        /// Hyperbolic Cosecant
        [MI(IL)] public static float4 csch(this float4 f) => f.sinh().rcp();
        /// <inheritdoc cref="csch(float4)"/>
        [MI(IL)] public static float3 csch(this float3 f) => f.sinh().rcp();
        /// <inheritdoc cref="csch(float4)"/>
        [MI(IL)] public static float2 csch(this float2 f) => f.sinh().rcp();
        /// <inheritdoc cref="csch(float4)"/>
        [MI(IL)] public static float csch(this float f) => f.sinh().rcp();

        
        // Inverse Hyperbolic Arcs ---------------------------------------------------
        
        /// Hyperbolic Arccosine
        [MI(IL)] public static float4 acosh(this float4 f) => (f + (f.sq() - 1).sqrt()).ln();
        /// <inheritdoc cref="acosh(float4)"/>
        [MI(IL)] public static float3 acosh(this float3 f) => (f + (f.sq() - 1).sqrt()).ln();
        /// <inheritdoc cref="acosh(float4)"/>
        [MI(IL)] public static float2 acosh(this float2 f) => (f + (f.sq() - 1).sqrt()).ln();
        /// <inheritdoc cref="acosh(float4)"/>
        [MI(IL)] public static float acosh(this float f) => (f + (f.sq() - 1).sqrt()).ln();

        /// Hyperbolic Arcsine
        [MI(IL)] public static float4 asinh(this float4 f) => (f + (f.sq() + 1).sqrt()).ln();
        /// <inheritdoc cref="asinh(float4)"/>
        [MI(IL)] public static float3 asinh(this float3 f) => (f + (f.sq() + 1).sqrt()).ln();
        /// <inheritdoc cref="asinh(float4)"/>
        [MI(IL)] public static float2 asinh(this float2 f) => (f + (f.sq() + 1).sqrt()).ln();
        /// <inheritdoc cref="asinh(float4)"/>
        [MI(IL)] public static float asinh(this float f) => (f + (f.sq() + 1).sqrt()).ln();

        /// Hyperbolic Arctangent // Verified
        [MI(IL)] public static float4 atanh(this float4 f) => ((1 + f) / (1 - f)).ln() / 2;
        /// <inheritdoc cref="atanh(float4)"/>
        [MI(IL)] public static float3 atanh(this float3 f) => ((1 + f) / (1 - f)).ln() / 2;
        /// <inheritdoc cref="atanh(float4)"/>
        [MI(IL)] public static float2 atanh(this float2 f) => ((1 + f) / (1 - f)).ln() / 2;
        /// <inheritdoc cref="atanh(float4)"/>
        [MI(IL)] public static float atanh(this float f) => ((1 + f) / (1 - f)).ln() / 2;

        /// Hyperbolic Arccotangent // Verified
        [MI(IL)] public static float4 acoth(this float4 f) => ((f + 1) / (f - 1)).ln() / 2;
        /// <inheritdoc cref="acoth(float4)"/>
        [MI(IL)] public static float3 acoth(this float3 f) => ((f + 1) / (f - 1)).ln() / 2;
        /// <inheritdoc cref="acoth(float4)"/>
        [MI(IL)] public static float2 acoth(this float2 f) => ((f + 1) / (f - 1)).ln() / 2;
        /// <inheritdoc cref="acoth(float4)"/>
        [MI(IL)] public static float acoth(this float f) => ((f + 1) / (f - 1)).ln() / 2;

        /// Hyperbolic Arcsecant // Verified
        [MI(IL)] public static float4 asech(this float4 f) => f.rcp().acosh(); // Previous : ((1 + (1 - f.sqr().sqrt())) / f).ln();
        /// <inheritdoc cref="asech(float4)"/>
        [MI(IL)] public static float3 asech(this float3 f) => f.rcp().acosh();
        /// <inheritdoc cref="asech(float4)"/>
        [MI(IL)] public static float2 asech(this float2 f) => f.rcp().acosh();
        /// <inheritdoc cref="asech(float4)"/>
        [MI(IL)] public static float asech(this float f) => f.rcp().acosh();

        /// Hyperbolic Arccosecant // Verified
        [MI(IL)] public static float4 acsch(this float4 f) => f.rcp().asinh(); // Previous : ((1 + (1 + f.sqr().sqrt())) / f).ln();
        /// <inheritdoc cref="acsch(float4)"/>
        [MI(IL)] public static float3 acsch(this float3 f) => f.rcp().asinh();
        /// <inheritdoc cref="acsch(float4)"/>
        [MI(IL)] public static float2 acsch(this float2 f) => f.rcp().asinh();
        /// <inheritdoc cref="acsch(float4)"/>
        [MI(IL)] public static float acsch(this float f) => f.rcp().asinh();
        
    }
}