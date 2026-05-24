// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#if MATHX_FUNCTION_POINTERS
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        // ** Very important to cache the function pointer for performance reasons
        public static readonly f1x3_f1 p_smax_exp = compile<f1x3_f1>(mathx.smax_exp);
    }
}
#endif