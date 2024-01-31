#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

// <contribution>
//    Cephes Math Library, Stephen L. Moshier
//    ALGLIB 2.0.1, Sergey Bochkanov
// </contribution>

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// The order of the
        /// <see cref="GammaLn" />
        /// approximation.
        private const int GammaN = 10;

        /// Auxiliary variable when evaluating the
        /// <see cref="GammaLn" />
        /// function.
        private const double GammaR = 10.900511;

        /// Polynomial coefficients for the
        /// <see cref="GammaLn" />
        /// approximation.
        private static readonly double[] GammaDk =
        {
            2.48574089138753565546e-5,
            1.05142378581721974210,
            -3.45687097222016235469,
            4.51227709466894823700,
            -2.98285225323576655721,
            1.05639711577126713077,
            -1.95428773191645869583e-1,
            1.70970543404441224307e-2,
            -5.71926117404305781283e-4,
            4.63399473359905636708e-6,
            -2.71994908488607703910e-9
        };

        /// <summary>
        ///     Computes the logarithm of the Gamma function.
        /// </summary>
        /// <param name="z">The argument of the gamma function.</param>
        /// <returns>The logarithm of the gamma function.</returns>
        /// <remarks>
        ///     <para>
        ///         This implementation of the computation of the gamma and logarithm of the gamma function follows the derivation
        ///         in
        ///         "An Analysis Of The Lanczos Gamma Approximation", Glendon Ralph Pugh, 2004.
        ///         We use the implementation listed on real. 116 which achieves an accuracy of 16 floating point digits. Although 16
        ///         digit accuracy
        ///         should be sufficient for double values, improving accuracy is possible (see real. 126 in Pugh).
        ///     </para>
        ///     <para>Our unit tests suggest that the accuracy of the Gamma function is correct up to 14 floating point digits.</para>
        /// </remarks>
        public static double GammaLn(double z)
        {
            if (z < 0.5)
            {
                var s = GammaDk[0];
                for (var i = 1; i <= GammaN; i++) s += GammaDk[i] / (i - z);

                return LnPI
                       - (PI * z).sin().ln()
                       - s.ln()
                       - LogTwoSqrtEOverPI
                       - (0.5 - z) * ((0.5 - z + GammaR) / E).ln();
            }
            else
            {
                var s = GammaDk[0];
                for (var i = 1; i <= GammaN; i++) s += GammaDk[i] / (z + i - 1.0);

                return s.ln()
                       + LogTwoSqrtEOverPI
                       + (z - 0.5) * ((z - 0.5 + GammaR) / E).ln();
            }
        }

        /// Computes the Gamma function.
        /// <param name="z">The argument of the gamma function.</param>
        /// <returns>The logarithm of the gamma function.</returns>
        /// <remarks>
        ///     <para>
        ///         This implementation of the computation of the gamma and logarithm of the gamma function follows the derivation
        ///         in
        ///         "An Analysis Of The Lanczos Gamma Approximation", Glendon Ralph Pugh, 2004.
        ///         We use the implementation listed on real. 116 which should achieve an accuracy of 16 floating point digits.
        ///         Although 16 digit accuracy
        ///         should be sufficient for double values, improving accuracy is possible (see real. 126 in Pugh).
        ///     </para>
        ///     <para>Our unit tests suggest that the accuracy of the Gamma function is correct up to 13 floating point digits.</para>
        /// </remarks>
        public static double Gamma(double z)
        {
            if (z < 0.5)
            {
                var s = GammaDk[0];
                for (var i = 1; i <= GammaN; i++) s += GammaDk[i] / (i - z);

                return PI / ((PI * z).sin()
                             * s
                             * TwoSqrtEOverPI
                             * ((0.5 - z + GammaR) / E).pow(0.5 - z));
            }
            else
            {
                var s = GammaDk[0];
                for (var i = 1; i <= GammaN; i++) s += GammaDk[i] / (z + i - 1.0);

                return s * TwoSqrtEOverPI * ((z - 0.5 + GammaR) / E).pow(z - 0.5);
            }
        }

        ///     Computes the Digamma function which is mathematically defined as the derivative of the logarithm of the gamma
        ///     function.
        ///     This implementation is based on
        ///     Jose Bernardo
        ///     Algorithm AS 103:
        ///     Psi ( Digamma ) Function,
        ///     Applied Statistics,
        ///     Volume 25, Number 3, 1976, pages 315-317.
        ///     Using the modifications as in Tom Minka's lightspeed toolbox.
        /// <param name="x">The argument of the digamma function.</param>
        /// <returns>The value of the DiGamma function at <paramref name="x" />.</returns>
        public static double DiGamma(double x)
        {
            const double c = 12;
            const double d1 = -0.57721566490153286;
            const double d2 = 1.6449340668482264365;
            const double s = 1e-6;
            const double s3 = 1 / 12.0;
            const double s4 = 1 / 120.0;
            const double s5 = 1 / 252.0;
            const double s6 = 1 / 240.0;
            const double s7 = 1 / 132.0;

            if (double.IsNegativeInfinity(x) || double.IsNaN(x)) return double.NaN;

            // Handle special cases.
            if (x <= 0 && x.floor() == x) return double.NegativeInfinity;

            // Use inversion formula for negative numbers.
            if (x < 0) return DiGamma(1 - x) + PI / (-PI * x).tan();

            if (x <= s) return d1 - 1 / x + d2 * x;

            double result = 0;
            while (x < c)
            {
                result -= 1 / x;
                x++;
            }

            if (x < c) return result;
            var r = 1 / x;
            result += x.ln() - 0.5 * r;
            r *= r;

            result -= r * (s3 - r * (s4 - r * (s5 - r * (s6 - r * s7))));

            return result;
        }

        /// <summary>
        ///     <para>
        ///         Computes the inverse Digamma function: this is the inverse of the logarithm of the gamma function. This
        ///         function will
        ///         only return solutions that are positive.
        ///     </para>
        ///     <para>This implementation is based on the bisection method.</para>
        /// </summary>
        /// <param name="p">The argument of the inverse digamma function.</param>
        /// <returns>The positive solution to the inverse DiGamma function at <paramref name="p" />.</returns>
        public static double DiGammaInv(double p)
        {
            if (double.IsNaN(p)) return double.NaN;
            if (double.IsNegativeInfinity(p)) return 0;
            if (double.IsPositiveInfinity(p)) return double.PositiveInfinity;

            var x = p.exp();
            for (var d = 1; d > 1.0e-15; d /= 2) x += d * (p - DiGamma(x)).sign();

            return x;
        }
    }
}