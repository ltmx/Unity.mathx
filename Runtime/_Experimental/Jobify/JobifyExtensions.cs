#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

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