#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // See : https://rosettacode.org/wiki/Gamma_function#C.23
        // Factorial Gamma Function - Lanczos Interpolated -------------------------------------------------

        // private static readonly double[] Table = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
        //     771.32342877765313, -176.61502916214059, 12.507343278686905,
        //     -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};

        // Returns the factorial componentwise Lanczos-interpolated value (gamma function)
        // <inheritdoc cref="fct(float)"/>>
        // public static double fct(this double f)
        // {
        //     if (f == 0 || f == 1) return 1;
        //     if (f < 0.5) return math.PI_DBL / ((math.PI_DBL * f).sin() * fct(1 - f));
        //
        //     var f2 = f - 1;
        //     var x = Table[0];
        //     for (var i = 1; i < 9; i++) x += Table[i] / (f2 + i);
        //     
        //     var t = f2 + 7.5;
        //     return (2 * math.PI_DBL).sqrt() * t.pow(f2 + 0.5) * (-t).exp() * x;
        // }
        //
        // public static float fct(this float f)
        // {
        //     if (f == 0 || f == 1) return 1;
        //     if (f < 0.5f) return math.PI / ((math.PI * f).sin() * fct(1 - f));
        //
        //     var f2 = f - 1;
        //     var x = (float)Table[0];
        //     for (var i = 1; i < 9; i++) x += (float)Table[i] / (f2 + i);
        //     
        //     var t = f2 + 7.5f;
        //     return TAU.sqrt() * t.pow(f2 + 0.5f) * exp(-t) * x;
        // }
        //
        // /// <inheritdoc cref="fct(float)"/>>
        // public static Complex fct(this Complex z)
        // {
        //     // Reflection formula
        //     if (z.Real < 0.5) return math.PI_DBL / (Complex.Sin( math.PI_DBL * z) * fct(1 - z));
        //     
        //     z -= 1;
        //     Complex x = Table[0];
        //     for (var i = 1; i < 9; i++) x += Table[i]/(z+i);
        //     
        //     var t = z + 7.5;
        //     return Complex.Sqrt(2 * math.PI_DBL) * Complex.Pow(t, z + 0.5) * Complex.Exp(-t) * x;
        // }
        //
        // /// <inheritdoc cref="fct(float)"/>>
        // public static f4 fct(this f4 f) => new f4(f.xy.fct(), f.zw.fct());
        // /// <inheritdoc cref="fct(float)"/>>
        // public static f3 fct(this f3 f) => new f3(f.xy.fct(), f.z.fct());
        // /// <inheritdoc cref="fct(float)"/>>
        // public static f2 fct(this f2 f) => new f2(f.x.fct(), f.y.fct());
        // /// <inheritdoc cref="fct(float)"/>>
        //
        // public static f4 fct(this Vector4 f) => f.asfloat().fct();
        // /// <inheritdoc cref="fct(float)"/>>
        // public static f3 fct(this Vector3 f) => f.asfloat().fct();
        // /// <inheritdoc cref="fct(float)"/>>
        // public static f2 fct(this Vector2 f) => f.asfloat().fct();
        //
        // /// <inheritdoc cref="fct(float)"/>>
        // public static double4 fct(this double4 f) => new double4(f.xy.fct(), f.zw.fct());
        // /// <inheritdoc cref="fct(float)"/>>
        // public static double3 fct(this double3 f) => new double3(f.xy.fct(), f.z.fct());
        // /// <inheritdoc cref="fct(float)"/>> ///
        // public static double2 fct(this double2 f) => new double2(f.x.fct(), f.y.fct());
        
    }
}