
namespace Unity.Mathematics
{
    public static partial class Math
    {
        public const float RAD = 0.0174532925f;
        public const float DEG = 57.295779513f;
        public const double RAD_D = 0.017453292519943296;
        public const double DEG_D = 57.29577951308232;

        public const float EPSILON = 1.401298E-45f;
        public const double EPSILON_D = 4.9406564584124654e-324;

        public const float PI = 3.14159265359f;
        public const double PI_D = 3.14159265358979323846;

        public const float PIOver2 = 1.57079632679f; // PI/2
        public const float HPI = PIOver2; // PI/2
        public const double PIo2_D = 1.57079632679489661923; // PI/2
        public const double HPI_D = 1.57079632679489661923; // PI/2


        public const double TAU_D = 6.283185307179586477;
        public const float TAU = 6.28318530718f;
        public const double PI2_D = 6.2831853071795864769; // same as TAU_D
        public const float PI2 = 6.28318530718f; // same as TAU
        
        public const double PHI_D = 1.6180339887498948482;
        public const float PHI = 1.61803398875f;

        /// Positive Infinity
        public const float PINF = float.PositiveInfinity;
        /// Negative Infinity
        public const float NINF = float.NegativeInfinity;
        /// Positive Infinity
        public const double PINF_D = double.PositiveInfinity;
        /// Negative Infinity
        public const double NINF_D = double.NegativeInfinity;

        public const double E_D = 2.71828182845904523536;
        public const float E = 2.71828182845f;

        // For Gamma Functions
        /// The number 2 * sqrt(e / pi)
        public const double TwoSqrtEOverPi = 1.8603827342052657173362492472666631120594218414085755;
        /// <summary>The number log[e](pi)</summary>
        public const double LnPi = 1.1447298858494001741434273513530587116472948129153d;
        /// The number log(2 * sqrt(e / pi))
        public const double LogTwoSqrtEOverPi = 0.6207822376352452223455184457816472122518527279025978;

        
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float SqrtHalf = math.SQRT2 / 2;
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float Sqrt2Over2 = math.SQRT2 / 2;


        // Translated from https://github.com/JJ/p6-math-constants/blob/master/lib/Math/Constants.pm6
        // Update physical constants from https://nist.gov/cuu/Constants -- CODATA 2018 recommendations

        // Physical Constants
        public const float plancks_h = 6.626_070_015e-34f; 
        public const float plancks_reduced_h = 1.054_571_817e-34f;
        public const float speed_of_light_vacuum = 299792458f;
        public const float standard_acceleration_gravity = 9.80665f;
        public const float gravitation = 6.67430e-11f;
        public const float gas = 8.314462618f;
        public const float faraday = 96485.33212f;
        public const float electron_mass = 9.1093837015e-31f;
        public const float proton_mass = 1.67262192369e-27f;
        public const float neutron_mass = 1.67492749804e-27f;
        public const float alpha_particle_mass = 6.6446573357e-27f;
        public const float quantum_ratio = 2.417989242e14f;
        public const float planck_mass = 2.176434e-8f;
        public const float planck_time = 5.391247e-44f;
        public const float planck_length = 1.616255e-35f;
        public const float planck_temperature = 1.416784e+32f;
        public const float kg_amu = 6.02214076e23f;
        public const float coulomb = 8.9875517887e9f;
        public const float fine_structure = 0.0072973525693f;
        public const float elementary_charge = 1.602176634e-19f;
        public const float vacuum_permittivity = 8.8541878128e-12f;
        public const float magnetic_permeability = 12.5663706212e-7f;
        public const float boltzmann = 1.380649e-23f; // was in eV, now in J K^-1
        public const float electron_volt = 1.602176634e-19f;
        public const float vacuum_permeability = 12.5663706212e-7f;

        // # Mathematical constants
        // # REF: https://en.wikipedia.org/wiki/Mathematical_constant

        public const float phi = 1.61803398874989e0f;
        public const float alpha_feigenbaum = 2.502907875095892822283e0f;
        public const float delta_feigenbaum = 4.669201609102990e0f;
        public const float apery = 1.2020569031595942853997381e0f;
        public const float conway = 1.303577269034e0f;
        public const float khinchin = 2.6854520010e0f;
        public const float glaisher_kinkelin = 1.2824271291e0f;
        public const float golomb_dickman = 0.62432998854355e0f;
        public const float catalan = 0.915965594177219015054603514e0f;
        public const float mill = 1.3063778838630806904686144e0f;
        public const float gauss = 0.8346268e0f;
        public const float euler_mascheroni_gamma = 0.57721566490153286060e0f;
        public const float sierpinski_gamma = 2.5849817595e0f;

        // Standard short names when available

        public const float A = glaisher_kinkelin;
        public const float c = speed_of_light_vacuum;
        public const float eV = electron_volt;
        public const float F = faraday;
        public const float G = gravitation;
        public const float g = standard_acceleration_gravity;
        public const float ℎ = plancks_h;
        public const float ℏ = plancks_reduced_h;
        public const float K0 = coulomb;
        public const float k0 = khinchin;
        public const float k = sierpinski_gamma;
        public const float L = kg_amu;
        public const float lp = planck_length;
        public const float mp = planck_mass;
        public const float q = elementary_charge;
        public const float Tp = planck_temperature;
        public const float tp = planck_time;
        public const float α = fine_structure;
        public const float γ = euler_mascheroni_gamma;
        public const float δ = delta_feigenbaum;
        public const float ε0 = vacuum_permittivity;
        public const float λ = conway;
        public const float μ0 = vacuum_permeability;
        public const float φ = phi;
        
        // Other constants
        public const int INLINE = 256; // Aggressive inlining
        
        
    }
}