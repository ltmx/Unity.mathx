#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

namespace Unity.Mathematics
{
    public static partial class Constants
    {
        // Translated from https://github.com/JJ/p6-math-constants/blob/master/lib/Math/Constants.pm6
        // Physical Constants
        public const float PlancksH = 6.626_070_015e-34f;
        public const float PlancksReducedH = 1.054_571_817e-34f;
        public const float SpeedOfLightVacuum = 299792458f;
        public const float StandardAccelerationGravity = 9.80665f;
        public const float Gravitation = 6.67430e-11f;
        public const float Gas = 8.314462618f;
        public const float Faraday = 96485.33212f;
        public const float ElectronMass = 9.1093837015e-31f;
        public const float ProtonMass = 1.67262192369e-27f;
        public const float NeutronMass = 1.67492749804e-27f;
        public const float AlphaParticleMass = 6.6446573357e-27f;
        public const float QuantumRatio = 2.417989242e14f;
        public const float PlanckMass = 2.176434e-8f;
        public const float planck_time = 5.391247e-44f;
        public const float PlanckLength = 1.616255e-35f;
        public const float planck_temperature = 1.416784e+32f;
        public const float KgAmu = 6.02214076e23f;
        public const float Coulomb = 8.9875517887e9f;
        public const float FineStructure = 0.0072973525693f;
        public const float ElementaryCharge = 1.602176634e-19f;
        public const float VacuumPermittivity = 8.8541878128e-12f;
        public const float MagneticPermeability = 12.5663706212e-7f;
        public const float Boltzmann = 1.380649e-23f; // was in eV, now in J K^-1
        public const float ElectronVolt = 1.602176634e-19f;
        public const float VacuumPermeability = 12.5663706212e-7f;
    }
}