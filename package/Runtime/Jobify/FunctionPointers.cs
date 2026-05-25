// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using Unity.Burst;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class FunctionPointers
	{
		public static readonly FunctionPointer<f1x2_f1> pFmaxPtr = compilePtr(mathx.fmax);
		public static readonly f1x2_f1 pFmax = pFmaxPtr.Invoke;

		public static readonly FunctionPointer<f1x2_f1> pFminPtr = compilePtr(mathx.fmin);
		public static readonly f1x2_f1 pFmin = pFminPtr.Invoke;

		public static readonly FunctionPointer<f1x3_f1> pClampPtr = compilePtr(mathx.clampfp);
		public static readonly f1x3_f1 pClamp = pClampPtr.Invoke;

		public static readonly FunctionPointer<f1_f1> pSaturatePtr = compilePtr(mathx.saturatefp);
		public static readonly f1_f1 pSaturate = pSaturatePtr.Invoke;

		public static readonly FunctionPointer<f1_f1> pAbsPtr = compilePtr(mathx.absfp);
		public static readonly f1_f1 pAbs = pAbsPtr.Invoke;

		public static readonly FunctionPointer<f1x3_f1> pLerpPtr = compilePtr(mathx.lerptfp);
		public static readonly f1x3_f1 pLerp = pLerpPtr.Invoke;

		public static readonly FunctionPointer<f1x3_f1> pSmaxExpPtr = compilePtr(mathx.smax_expfp);
		public static readonly f1x3_f1 pSmaxExp = pSmaxExpPtr.Invoke;

		public static readonly FunctionPointer<f1x3_f1> pSminExpPtr = compilePtr(mathx.smin_expfp);
		public static readonly f1x3_f1 pSminExp = pSminExpPtr.Invoke;

		public static readonly f1x2_f1 p_fmax = pFmax;
		public static readonly f1x2_f1 p_fmin = pFmin;
		public static readonly f1x3_f1 p_smax_exp = pSmaxExp;
	}
}
