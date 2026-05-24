// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#if MATHX_FUNCTION_POINTERS
using Unity.Burst;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers.Signature;
using static Unity.Mathematics.Jobify;

namespace Unity.Mathematics
{
    [BurstCompile]
    public static class JobifyExtensions
    {
        public static Jobified Jobify(FunctionPointer<f1_f1> d, float input) => new(d, input);

        public static void ExecuteAndComplete(this Jobified j)
        {
            j.Schedule().Complete();
        }
    }
}

#endif