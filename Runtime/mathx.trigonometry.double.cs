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
        public static double4 sin(this double4 f) => math.sin(f);
        /// <inheritdoc cref="sin(double4)"/>
        public static double3 sin(this double3 f) => math.sin(f);
        /// <inheritdoc cref="sin(double4)"/>
        public static double2 sin(this double2 f) => math.sin(f);
        /// <inheritdoc cref="sin(double4)"/>
        public static double sin(this double f) => math.sin(f);

        /// Cosine
        public static double4 cos(this double4 f) => math.cos(f);
        /// <inheritdoc cref="cos(double4)"/>
        public static double3 cos(this double3 f) => math.cos(f);
        /// <inheritdoc cref="cos(double4)"/>
        public static double2 cos(this double2 f) => math.cos(f);
        /// <inheritdoc cref="cos(double4)"/>
        public static double cos(this double f) => math.cos(f);

        /// Tangent
        public static double4 tan(this double4 f) => math.tan(f);
        /// <inheritdoc cref="tan(double4)"/>
        public static double3 tan(this double3 f) => math.tan(f);
        /// <inheritdoc cref="tan(double4)"/>
        public static double2 tan(this double2 f) => math.tan(f);
        /// <inheritdoc cref="tan(double4)"/>
        public static double tan(this double f) => math.tan(f);

        /// Secant
        public static double4 sec(this double4 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(double4)"/>
        public static double3 sec(this double3 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(double4)"/>
        public static double2 sec(this double2 f) => f.rcp().cos();
        /// <inheritdoc cref="sec(double4)"/>
        public static double sec(this double f) => f.rcp().cos();

        /// Cotangent
        public static double4 cot(this double4 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(double4)"/>
        public static double3 cot(this double3 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(double4)"/>
        public static double2 cot(this double2 f) => f.tan().rcp();
        /// <inheritdoc cref="cot(double4)"/>
        public static double cot(this double f) => f.tan().rcp();
        
        
        /// Cosecant
        public static double4 csc(this double4 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(double4)"/>
        public static double3 csc(this double3 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(double4)"/>
        public static double2 csc(this double2 f) => f.sin().rcp();
        /// <inheritdoc cref="csc(double4)"/>
        public static double csc(this double f) => f.sin().rcp();
        
        /// Arcsine
        public static double4 asin(this double4 f) => math.asin(f);
        /// <inheritdoc cref="asin(double4)"/>
        public static double3 asin(this double3 f) => math.asin(f);
        /// <inheritdoc cref="asin(double4)"/>
        public static double2 asin(this double2 f) => math.asin(f);
        /// <inheritdoc cref="asin(double4)"/>
        public static double asin(this double f) => math.asin(f);
        
        /// Arccosine
        public static double4 acos(this double4 f) => math.acos(f);
        /// <inheritdoc cref="acos(double4)"/>
        public static double3 acos(this double3 f) => math.acos(f);
        /// <inheritdoc cref="acos(double4)"/>
        public static double2 acos(this double2 f) => math.acos(f);
        /// <inheritdoc cref="acos(double4)"/>
        public static double acos(this double f) => math.acos(f);

        /// Arctangent
        public static double4 atan(this double4 f) => math.atan(f);
        /// <inheritdoc cref="atan(double4)"/>
        public static double3 atan(this double3 f) => math.atan(f);
        /// <inheritdoc cref="atan(double4)"/>
        public static double2 atan(this double2 f) => math.atan(f);
        /// <inheritdoc cref="atan(double4)"/>
        public static double atan(this double f) => math.atan(f);
        
        /// Arctangent2
        public static double4 atan2(this double4 f, double4 double2) => math.atan2(f, double2);
        /// <inheritdoc cref="atan2(double4, double4)"/>
        public static double3 atan2(this double3 f, double3 double2) => math.atan2(f, double2);
        /// <inheritdoc cref="atan2(double4, double4)"/>
        public static double2 atan2(this double2 f, double2 double2) => math.atan2(f, double2);
        /// <inheritdoc cref="atan2(double4, double4)"/>
        public static double atan2(this double f, double double2) => math.atan2(f, double2);

        /// Arc cotangent
        public static double4 acot(this double4 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(double4)"/>
        public static double3 acot(this double3 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(double4)"/>
        public static double2 acot(this double2 f) => f.rcp().atan();
        /// <inheritdoc cref="acot(double4)"/>
        public static double acot(this double f) => f.rcp().atan();
        
        /// Arc secant
        public static double4 asec(this double4 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(double4)"/>
        public static double3 asec(this double3 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(double4)"/>
        public static double2 asec(this double2 f) => f.rcp().acos();
        /// <inheritdoc cref="asec(double4)"/>
        public static double asec(this double f) => f.rcp().acos();
        
        
        /// Arc cosecant
        public static double4 acsc(this double4 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(double4)"/>
        public static double3 acsc(this double3 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(double4)"/>
        public static double2 acsc(this double2 f) => f.rcp().asin();
        /// <inheritdoc cref="acsc(double4)"/>
        public static double acsc(this double f) => f.rcp().asin();


        /// Returns the Sine²
        public static double4 sin2(this double4 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(double4)"/>
        public static double3 sin2(this double3 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(double4)"/>
        public static double2 sin2(this double2 f) => cos(2 * f).inv() * 0.5f;
        /// <inheritdoc cref="sin2(double4)"/>
        public static double sin2(this double f) => cos(2 * f).inv() * 0.5f;
        
        /// Returns the Cosine²
        public static double4 cos2(this double4 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(double4)"/>
        public static double3 cos2(this double3 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(double4)"/>
        public static double2 cos2(this double2 f) => (1 + cos(2 * f)) * 0.5f;
        /// <inheritdoc cref="cos2(double4)"/>
        public static double cos2(this double f) => (1 + cos(2 * f)) * 0.5f;

        /// Tangent²
        public static double4 tan2(this double4 f)
        {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(double4)"/>
        public static double3 tan2(this double3 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(double4)"/>
        public static double2 tan2(this double2 f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }
        /// <inheritdoc cref="tan2(double4)"/>
        public static double tan2(this double f) {
            var a = cos(f * 2);
            return (1 - a) / (1 + a);
        }

        /// Secant²
        public static double4 sec2(this double4 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(double4)"/>
        public static double3 sec2(this double3 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(double4)"/>
        public static double2 sec2(this double2 f) => f.cos2().rcp();
        /// <inheritdoc cref="sec2(double4)"/>
        public static double sec2(this double f) => f.cos2().rcp();

        
        /// Radians to Degrees
        public static double4 deg(this double4 f) => math.degrees(f);
        /// <inheritdoc cref="deg(double4)"/>
        public static double3 deg(this double3 f) => math.degrees(f);
        /// <inheritdoc cref="deg(double4)"/>
        public static double2 deg(this double2 f) => math.degrees(f);
        /// <inheritdoc cref="deg(double4)"/>
        public static double deg(this double f) => math.degrees(f);


        /// Degrees To Radians
        public static double4 rad(this double4 f) => math.radians(f);
        /// <inheritdoc cref="rad(double4)"/>
        public static double3 rad(this double3 f) => math.radians(f);
        /// <inheritdoc cref="rad(double4)"/>
        public static double2 rad(this double2 f) => math.radians(f);
        /// <inheritdoc cref="rad(double4)"/>
        public static double rad(this double f) => math.radians(f);
        
        /// Cosine-Sine combined
        public static double2 cossin(this double f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(double4)"/>
        public static double2x2 cossin(this double2 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(double4)"/>
        public static double3x2 cossin(this double3 f) => new(f.cos(), f.sin());
        /// <inheritdoc cref="cossin(double4)"/>
        public static double4x2 cossin(this double4 f) => new(f.cos(), f.sin());
        
        
        /// Sine-Cosine combined
        public static double2 sincos(this double f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(double)"/>
        public static double2x2 sincos(this double2 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(double)"/>
        public static double3x2 sincos(this double3 f) => new(f.sin(), f.cos());
        /// <inheritdoc cref="sincos(double)"/>
        public static double4x2 sincos(this double4 f) => new(f.sin(), f.cos());

        
        /// Cosine-Sine combined - non allocating
        public static void cossin(this double2 double2, double f) => math.sincos(f, out double2.y, out double2.x);
        /// <inheritdoc cref="cossin(double2, double)"/>
        public static void cossin(this double2x2 double2, double2 f) => math.sincos(f, out double2.c1, out double2.c0);
        /// <inheritdoc cref="cossin(double2, double)"/>
        public static void cossin(this double3x2 double2,double3 f) => math.sincos(f, out double2.c1, out double2.c0);
        /// <inheritdoc cref="cossin(double2, double)"/>
        public static void cossin(this double4x2 double2, double4 f) => math.sincos(f, out double2.c1, out double2.c0);

        /// Sine-Cosine combined - non allocating
        public static void sincos(this double2 double2, double f) => math.sincos(f, out double2.x, out double2.y);
        /// <inheritdoc cref="sincos(double2, double)"/>
        public static void sincos(this double2 double2, int f) => math.sincos(f, out double2.x, out double2.y);
        /// <inheritdoc cref="sincos(double2, double)"/>
        public static void sincos(this double2x2 double2, double2 f) => math.sincos(f, out double2.c0, out double2.c1);
        /// <inheritdoc cref="sincos(double2, double)"/>
        public static void sincos(this double3x2 double2, double3 f) => math.sincos(f, out double2.c0, out double2.c1);
        /// <inheritdoc cref="sincos(double2, double)"/>
        public static void sincos(this double4x2 double2, double4 f) => math.sincos(f, out double2.c0, out double2.c1);

        public static double4 mod360(this double4 angles) => angles = new double4(angles.x.mod360(), angles.y.mod360(), angles.z.mod360(), angles.w.mod360());
        public static double3 mod360(this double3 angles) => angles = new double3(angles.x.mod360(), angles.y.mod360(), angles.z.mod360());
        public static double2 mod360(this double2 angles) => angles = new double2(angles.x.mod360(), angles.y.mod360());
        public static double mod360(this double angle) => angle.mod(360);
        
        public static double4 mod2PI(this double4 angles) => angles = new double4(angles.x.mod2PI(), angles.y.mod2PI(), angles.z.mod2PI(), angles.w.mod2PI());
        public static double3 mod2PI(this double3 angles) => angles = new double3(angles.x.mod2PI(), angles.y.mod2PI(), angles.z.mod2PI());
        public static double2 mod2PI(this double2 angles) => angles = new double2(angles.x.mod2PI(), angles.y.mod2PI());
        public static double mod2PI(this double angle) => angle.mod(TAU);
    }
}