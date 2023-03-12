#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.ComponentModel;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Degrees to Radians
        public const float RAD = 0.0174532925f;
        /// Radians to Degrees
        public const float DEG = 57.295779513f;
        /// Degrees to Radians
        public const double RAD_DBL = 0.017453292519943296;
        /// Radians to Degrees
        public const double DEG_DBL = 57.29577951308232;
        
        /// Smallest positive value that can be represented by a float
        public const float EPSILON = 1.401298E-45f;
        /// Smallest positive value that can be represented by a double
        public const double EPSILON_DBL = 4.9406564584124654e-324;
        
        public const float PI = 3.14159265359f;
        public const double PI_DBL = 3.14159265358979323846;

        /// PI/2
        public const float PI_2 = 1.57079632679f;
        /// PI/2
        public const float HPI = PI_2;
        /// PI/2 Double Precision
        public const double PI_2_DBL = 1.57079632679489661923;
        /// PI/2 Double Precision
        public const double HPId = PI_2_DBL;


        /// PI/4 Double
        public const double TAU_DBL = 6.283185307179586477;
        /// PI/4 float
        public const float TAU = 6.28318530718f;
        /// 2 * PI double : same as TAU
        public const double PI2_DBL = 6.2831853071795864769; 
        /// 2 * PI float : same as TAU
        public const float PI2 = 6.28318530718f;
        
        /// PHI Double Precision
        public const double PHId = 1.6180339887498948482;
        /// PHI 
        public const float PHI = 1.61803398874989e0f;

        ///  float.PositiveInfinity
        public const float PINF = float.PositiveInfinity;
        /// float.NegativeInfinity
        public const float NINF = float.NegativeInfinity;
        /// double.PositiveInfinity
        public const double PINF_DBL = double.PositiveInfinity;
        /// double.NegativeInfinity
        public const double NINF_DBL = double.NegativeInfinity;

        /// Exponential base
        public const double E_DBL = 2.71828182845904523536;
        /// Exponential base
        public const float E = 2.71828182845f;

        // For Gamma Functions
        /// The number 2 * sqrt(e / pi)
        public const double TwoSqrtEOverPi = 1.8603827342052657173362492472666631120594218414085755;
        /// The number log[e](pi)
        public const double LnPi = 1.1447298858494001741434273513530587116472948129153d;
        /// The number log(2 * sqrt(e / pi))
        public const double LogTwoSqrtEOverPi = 0.6207822376352452223455184457816472122518527279025978;
        
        
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float SQRT2_2 = math.SQRT2 / 2;
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float SQRT3 = 1.73205080757f;
        /// sqrt(3)/2
        public const float SQRT3_2 = 0.86602540378f;

        // Utility Constants ----------------------------------------------------
        
        ///MethodImplOptions.AggressiveInlining
        public const int INLINE = 256; // MethodImpl.AggressiveInlining
        public const int IL = 256; // MethodImpl.AggressiveInlining
        public const EditorBrowsableState NEVER = EditorBrowsableState.Never; // EditorBrowsableState.Never
    }
}