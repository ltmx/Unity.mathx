// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class FunctionPointers
	{
		public static readonly f1x2_f1 p_fmax = compile<f1x2_f1>(mathx.fmax);
		public static readonly f1x2_f1 p_fmin = compile<f1x2_f1>(mathx.fmin);
		public static readonly f1x3_f1 p_smax_exp = compile<f1x3_f1>(mathx.smax_exp);
	}
}
