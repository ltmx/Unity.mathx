// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class FunctionPointers
	{
		public static readonly f1x2_f1 pFmax = compile<f1x2_f1>(mathx.fmax);
		public static readonly f1x2_f1 pFmin = compile<f1x2_f1>(mathx.fmin);
		public static readonly f1x3_f1 pClamp = compile<f1x3_f1>(mathx.clampfp);
		public static readonly f1_f1 pSaturate = compile<f1_f1>(mathx.saturatefp);
		public static readonly f1_f1 pAbs = compile<f1_f1>(mathx.absfp);
		public static readonly f1x3_f1 pLerp = compile<f1x3_f1>(mathx.lerptfp);
		public static readonly f1x3_f1 pSmaxExp = compile<f1x3_f1>(mathx.smax_expfp);
		public static readonly f1x3_f1 pSminExp = compile<f1x3_f1>(mathx.smin_expfp);

		public static readonly f1x2_f1 p_fmax = pFmax;
		public static readonly f1x2_f1 p_fmin = pFmin;
		public static readonly f1x3_f1 p_smax_exp = pSmaxExp;
	}
}
