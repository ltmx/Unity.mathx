using System;
using System.Runtime.Serialization;


namespace Unity.Mathematics
{
    /// A single-variable polynomial with real-valued coefficients and non-negative exponents.
    [Serializable]
    public class Polynomial
    {
        ///     The coefficients of the polynomial in a
        public double[] coefficients { get; private set; }

        ///     Evaluate a polynomial at point x.
        ///     Coefficients are ordered ascending by power with power k at index k.
        ///     Example: coefficients [3,-1,2] represent y=2x^2-x+3.
        /// <param name="z">The location where to evaluate the polynomial at.</param>
        /// <param name="coefficients">The coefficients of the polynomial, coefficient for power k at index k.</param>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="coefficients" /> is a null reference.
        /// </exception>
        public static double Evaluate(double z, params double[] coefficients)
        {
            // 2020-10-07 jbialogrodzki #730 Since this is public API we should probably
            // handle null arguments? It doesn't seem to have been done consistently in this class though.
            if (coefficients == null) throw new ArgumentNullException(nameof(coefficients));

            // 2020-10-07 jbialogrodzki #730 Zero polynomials need explicit handling.
            // Without this check, we attempted to peek coefficients at negative indices!
            var n = coefficients.Length;
            if (n == 0) return 0;

            var sum = coefficients[n - 1];
            for (var i = n - 2; i >= 0; --i)
            {
                sum *= z;
                sum += coefficients[i];
            }
            return sum;
        }

        /// Evaluate a polynomial at point x.
        /// <param name="z">Thet location where to evaluate the polynomial a.</param>
        public double Evaluate(double z) => Evaluate(z, coefficients);
    }
}
