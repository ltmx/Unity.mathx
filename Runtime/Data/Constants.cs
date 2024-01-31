#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.ComponentModel;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        
        /// 1/3 double precision
        private const double THIRD_DBL = 0.333333333333333333333;
        /// 1/3
        private const float THIRD = 0.3333333333f;
        
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
        
        /// 4 PI
        public const float FourPI = 4 * PI;
        /// 4 PI Double Precision
        public const double FourPI_DBL = 4 * PI_DBL;
        
        /// PI/4 float
        public const float TAU = 6.28318530718f;
        /// PI/4 Double
        public const double TAU_DBL = 6.283185307179586477;
        
        /// 2 * PI float : same as TAU
        public const float TwoPI = 6.28318530718f;
        /// 2 * PI double : same as TAU
        public const double TwoPI_DBL = 6.2831853071795864769; 
        
        /// PI
        public const float PI = 3.14159265359f;
        /// PI Double Precision
        public const double PI_DBL = 3.14159265358979323846;

        /// PI/2
        public const float HalfPI = 1.57079632679f;
        /// PI/2
        public const float HPI = HalfPI;
        /// PI/2 Double Precision
        public const double HalfPI_DBL = 1.57079632679489661923;
        /// PI/2 Double Precision
        public const double HPId = HalfPI_DBL;
        
        
        /// PHI Double Precision
        public const double PHI_DBL = 1.6180339887498948482;
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
        public const double TwoSqrtEOverPI = 1.8603827342052657173362492472666631120594218414085755;
        /// The number log[e](pi)
        public const double LnPI = 1.1447298858494001741434273513530587116472948129153d;
        /// The number log(2 * sqrt(e / pi))
        public const double LogTwoSqrtEOverPI = 0.6207822376352452223455184457816472122518527279025978;
        
        
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float HalfSQRT2 = math.SQRT2 / 2;
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float HSQRT = math.SQRT2 / 2;
        /// sqrt(2)/2 or sqrt(0.5f)
        public const float SQRT3 = 1.73205080757f;
        /// sqrt(3)/2
        public const float HalfSQRT3 = SQRT3 / 2;
        /// sqrt(3)/2
        public const float HSQRT3 = SQRT3 / 2;
        
        /// 1/sqrt(2)
        public const float InvSQRT2 = 0.70710678118f;
        /// 1/sqrt(2)
        public const float RSQRT2 = 0.70710678118f;
        
        private static readonly int[] POWERS_OF_10 =
            { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000 };

        private static readonly int[] POWERS_OF_2 =
        {
            1, 
            2, 4, 8, 16, 32, 
            64, 128, 256, 512, 1024, 
            2048, 4096, 8192, 16384, 32768, 
            65536, 131072, 262144, 524288, 1048576
        };
        // Utility Constants ----------------------------------------------------
        
        ///MethodImplOptions.AggressiveInlining
        public const int INLINE = 256; // MethodImpl.AggressiveInlining
        public const int IL = 256; // MethodImpl.AggressiveInlining
        public const EditorBrowsableState NEVER = EditorBrowsableState.Never; // EditorBrowsableState.Never
    }
}