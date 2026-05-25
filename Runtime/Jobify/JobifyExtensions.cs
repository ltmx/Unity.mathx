// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.Signature;
using static Unity.Mathematics.Jobify;

namespace Unity.Mathematics
{
	[BurstCompile]
	public static class JobifyExtensions
	{
		public static Jobified Jobify(FunctionPointer<f1_f1> d, float input) => new(d, input);

		public static void ExecuteAndComplete(this Jobified j) => j.Schedule().Complete();

		public static JobHandle Map(this NativeArray<float> input, NativeArray<float> output, FunctionPointer<f1_f1> function, int batchSize = 64, JobHandle deps = default) =>
			JobParallelFor.ScheduleFloatUnary(input, output, function, batchSize, deps);

		public static JobHandle Map(this NativeArray<float> inputA, NativeArray<float> inputB, NativeArray<float> output, FunctionPointer<f1x2_f1> function, int batchSize = 64, JobHandle deps = default) =>
			JobParallelFor.ScheduleFloatBinary(inputA, inputB, output, function, batchSize, deps);

		public static JobHandle FillNoise2D(this NativeArray<float> output, int2 size, float2 origin, float spacing, JobParallelFor.NoiseKind kind = JobParallelFor.NoiseKind.Simplex2, int batchSize = 64, JobHandle deps = default) =>
			JobParallelFor.ScheduleNoise2D(output, size, origin, spacing, kind, batchSize, deps);

		public static JobHandle MapAbs(this NativeArray<float> input, NativeArray<float> output, JobHandle deps = default) =>
			input.Map(output, pAbs, 64, deps);

		public static JobHandle MapFmax(this NativeArray<float> inputA, NativeArray<float> inputB, NativeArray<float> output, JobHandle deps = default) =>
			inputA.Map(inputB, output, pFmax, 64, deps);
	}
}
