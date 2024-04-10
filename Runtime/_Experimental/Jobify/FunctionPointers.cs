#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

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