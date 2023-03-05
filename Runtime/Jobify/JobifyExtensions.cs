#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using Unity.Burst;
using Unity.Jobs;
using static Unity.Mathematics.Jobify;
using static Unity.Mathematics.OperationInterface;

namespace Unity.Mathematics
{
    [BurstCompile]
    public static class JobifyExtensions
    {
        public static Jobified Jobify(FunctionPointer<FloatIO> d, float input)
        {
            return new(d, input);
        }
        
        public static void ExecuteAndComplete(this Jobified j)
        {
            j.Schedule().Complete();
        }
    }
}