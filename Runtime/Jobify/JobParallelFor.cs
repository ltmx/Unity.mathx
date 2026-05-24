// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	/// Parallel-for jobs applying Burst function pointers to native arrays.
	public static class JobParallelFor
	{
		[BurstCompile]
		public struct FloatUnaryJob : IJobParallelFor
		{
			[ReadOnly] public NativeArray<float> Input;
			[WriteOnly] public NativeArray<float> Output;
			public FunctionPointer<f1_f1> Function;

			public void Execute(int index) => Output[index] = Function.Invoke(Input[index]);
		}

		public static JobHandle ScheduleFloatUnary(NativeArray<float> input, NativeArray<float> output, FunctionPointer<f1_f1> function, int batchSize = 64, JobHandle deps = default) =>
			new FloatUnaryJob { Input = input, Output = output, Function = function }.Schedule(input.Length, batchSize, deps);
	}
}
