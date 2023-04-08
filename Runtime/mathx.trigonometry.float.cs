#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Sine
        public static float4 sin(this float4 f) => math.sin(f);
        /// <inheritdoc cref="sin(float4)"/>
        public static float3 sin(this float3 f) => math.sin(f);
        /// <inheritdoc cref="sin(float4)"/>
        public static float2 sin(this float2 f) => math.sin(f);
        /// <inheritdoc cref="sin(float4)"/>
        public static float sin(this float f) => math.sin(f);

        /// Cosine
        public static float4 cos(this float4 f) => math.cos(f);
        /// <inheritdoc cref="cos(float4)"/>
        public static float3 cos(this float3 f) => math.cos(f);
        /// <inheritdoc cref="cos(float4)"/>
        public static float2 cos(this float2 f) => math.cos(f);
        /// <inheritdoc cref="cos(float4)"/>
        public static float cos(this float f) => math.cos(f);

        /// Tangent
        public static float4 tan(this float4 f) => math.tan(f);
        /// <inheritdoc cref="tan(float4)"/>
        public static float3 tan(this float3 f) => math.tan(f);
        /// <inheritdoc cref="tan(float4)"/>
        public static float2 tan(this float2 f) => math.tan(f);
        /// <inheritdoc cref="tan(float4)"/>
        public static float tan(this float f) => math.tan(f);

        /// Secant
        public static float4 sec(this float4 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(float4)"/>
        public static float3 sec(this float3 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(float4)"/>
        public static float2 sec(this float2 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(float4)"/>
        public static float sec(this float f) => f.rcp().cos();

        /// Cotangent
        public static float4 cot(this float4 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(float4)"/>
        public static float3 cot(this float3 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(float4)"/>
        public static float2 cot(this float2 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(float4)"/>
        public static float cot(this float f) => f.tan().rcp();
        
        
        /// Cosecant
        public static float4 csc(this float4 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(float4)"/>
        public static float3 csc(this float3 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(float4)"/>
        public static float2 csc(this float2 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(float4)"/>
        public static float csc(this float f) => f.sin().rcp();
        
        /// Arcsine
        public static float4 asin(this float4 f) => math.asin(f);
        /// <inheritdoc cref="asin(float4)"/>
        public static float3 asin(this float3 f) => math.asin(f);
        /// <inheritdoc cref="asin(float4)"/>
        public static float2 asin(this float2 f) => math.asin(f);
        /// <inheritdoc cref="asin(float4)"/>
        public static float asin(this float f) => math.asin(f);
        
        /// Arccosine
        public static float4 acos(this float4 f) => math.acos(f);
        /// <inheritdoc cref="acos(float4)"/>
        public static float3 acos(this float3 f) => math.acos(f);
        /// <inheritdoc cref="acos(float4)"/>
        public static float2 acos(this float2 f) => math.acos(f);
        /// <inheritdoc cref="acos(float4)"/>
        public static float acos(this float f) => math.acos(f);

        /// Arctangent
        public static float4 atan(this float4 f) => math.atan(f);
        /// <inheritdoc cref="atan(float4)"/>
        public static float3 atan(this float3 f) => math.atan(f);
        /// <inheritdoc cref="atan(float4)"/>
        public static float2 atan(this float2 f) => math.atan(f);
        /// <inheritdoc cref="atan(float4)"/>
        public static float atan(this float f) => math.atan(f);
        
        /// Arctangent2
        public static float4 atan2(this float4 f, float4 float2) => math.atan2(f, float2);
        /// <inheritdoc cref="atan2(float4, float4)"/>
        public static float3 atan2(this float3 f, float3 float2) => math.atan2(f, float2);
        /// <inheritdoc cref="atan2(float4, float4)"/>
        public static float2 atan2(this float2 f, float2 float2) => math.atan2(f, float2);
        /// <inheritdoc cref="atan2(float4, float4)"/>
        public static float atan2(this float f, float float2) => math.atan2(f, float2);

        /// Arc cotangent
        public static float4 acot(this float4 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(float4)"/>
        public static float3 acot(this float3 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(float4)"/>
        public static float2 acot(this float2 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(float4)"/>
        public static float acot(this float f) => f.rcp().atan();
        
        /// Arc secant
        public static float4 asec(this float4 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(float4)"/>
        public static float3 asec(this float3 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(float4)"/>
        public static float2 asec(this float2 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(float4)"/>
        public static float asec(this float f) => f.rcp().acos();
        
        
        /// Arc cosecant
        public static float4 acsc(this float4 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(float4)"/>
        public static float3 acsc(this float3 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(float4)"/>
        public static float2 acsc(this float2 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(float4)"/>
        public static float acsc(this float f) => f.rcp().asin();


        /// Returns the Sine²
        public static float4 sin2(this float4 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(float4)"/>
        public static float3 sin2(this float3 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(float4)"/>
        public static float2 sin2(this float2 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(float4)"/>
        public static float sin2(this float f) => cos(2 * f).inv() * 0.5f;
        
        /// Returns the Cosine²
        public static float4 cos2(this float4 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(float4)"/>
        public static float3 cos2(this float3 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(float4)"/>
        public static float2 cos2(this float2 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(float4)"/>
        public static float cos2(this float f) => (1 + cos(2 * f)) * 0.5f;

        /// Tangent²
        public static float4 tan2(this float4 f)
        {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(float4)"/>
        public static float3 tan2(this float3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(float4)"/>
        public static float2 tan2(this float2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(float4)"/>
        public static float tan2(this float f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }

        /// Secant²
        public static float4 sec2(this float4 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(float4)"/>
        public static float3 sec2(this float3 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(float4)"/>
        public static float2 sec2(this float2 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(float4)"/>
        public static float sec2(this float f) => f.cos2().rcp();

        
        /// Radians to Degrees
        public static float4 deg(this float4 f) => math.degrees(f);
        /// <inheritdoc cref="deg(float4)"/>
        public static float3 deg(this float3 f) => math.degrees(f);
        /// <inheritdoc cref="deg(float4)"/>
        public static float2 deg(this float2 f) => math.degrees(f);
        /// <inheritdoc cref="deg(float4)"/>
        public static float deg(this float f) => math.degrees(f);


        /// Degrees To Radians
        public static float4 rad(this float4 f) => math.radians(f);
        /// <inheritdoc cref="rad(float4)"/>
        public static float3 rad(this float3 f) => math.radians(f);
        /// <inheritdoc cref="rad(float4)"/>
        public static float2 rad(this float2 f) => math.radians(f);
        /// <inheritdoc cref="rad(float4)"/>
        public static float rad(this float f) => math.radians(f);
        
        /// Cosine-Sine combined
        public static float2 cossin(this float f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(float4)"/>
        public static float2x2 cossin(this float2 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(float4)"/>
        public static float3x2 cossin(this float3 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(float4)"/>
        public static float4x2 cossin(this float4 f) => new(f.cos(), f.sin());
        
        
        /// Sine-Cosine combined
        public static float2 sincos(this float f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float2x2 sincos(this float2 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float3x2 sincos(this float3 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(float)"/>
        public static float4x2 sincos(this float4 f) => new(f.sin(), f.cos());

        
        /// Cosine-Sine combined - non allocating
        public static void cossin(this float2 float2, float f) => math.sincos(f, out float2.y, out float2.x);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float2x2 float2, float2 f) => math.sincos(f, out float2.c1, out float2.c0);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float3x2 float2,float3 f) => math.sincos(f, out float2.c1, out float2.c0);
        /// <inheritdoc cref="cossin(float2, float)"/>
        public static void cossin(this float4x2 float2, float4 f) => math.sincos(f, out float2.c1, out float2.c0);

        /// Sine-Cosine combined - non allocating
        public static void sincos(this float2 float2, float f) => math.sincos(f, out float2.x, out float2.y);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float2 float2, int f) => math.sincos(f, out float2.x, out float2.y);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float2x2 float2, float2 f) => math.sincos(f, out float2.c0, out float2.c1);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float3x2 float2, float3 f) => math.sincos(f, out float2.c0, out float2.c1);
        /// <inheritdoc cref="sincos(float2, float)"/>
        public static void sincos(this float4x2 float2, float4 f) => math.sincos(f, out float2.c0, out float2.c1);

        public static float4 mod360(this float4 angles) => angles = new float4(angles.x.mod360(), angles.y.mod360(), angles.z.mod360(), angles.w.mod360());
        public static float3 mod360(this float3 angles) => angles = new float3(angles.x.mod360(), angles.y.mod360(), angles.z.mod360());
        public static float2 mod360(this float2 angles) => angles = new float2(angles.x.mod360(), angles.y.mod360());
        public static float mod360(this float angle) => angle.mod(360);
        
        public static float4 mod2PI(this float4 angles) => angles = new float4(angles.x.mod2PI(), angles.y.mod2PI(), angles.z.mod2PI(), angles.w.mod2PI());
        public static float3 mod2PI(this float3 angles) => angles = new float3(angles.x.mod2PI(), angles.y.mod2PI(), angles.z.mod2PI());
        public static float2 mod2PI(this float2 angles) => angles = new float2(angles.x.mod2PI(), angles.y.mod2PI());
        public static float mod2PI(this float angle) => angle.mod(TAU);
    }
}