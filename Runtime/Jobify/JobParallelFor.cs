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
		public enum NoiseKind { Simplex2, Perlin2, Fbm2, Worley2 }

		[BurstCompile]
		public struct FloatUnaryJob : IJobParallelFor
		{
			[ReadOnly] public NativeArray<float> Input;
			[WriteOnly] public NativeArray<float> Output;
			public FunctionPointer<f1_f1> Function;

			public void Execute(int index) => Output[index] = Function.Invoke(Input[index]);
		}

		[BurstCompile]
		public struct FloatBinaryJob : IJobParallelFor
		{
			[ReadOnly] public NativeArray<float> InputA;
			[ReadOnly] public NativeArray<float> InputB;
			[WriteOnly] public NativeArray<float> Output;
			public FunctionPointer<f1x2_f1> Function;

			public void Execute(int index) => Output[index] = Function.Invoke(InputA[index], InputB[index]);
		}

		[BurstCompile]
		public struct FloatTernaryJob : IJobParallelFor
		{
			[ReadOnly] public NativeArray<float> InputA;
			[ReadOnly] public NativeArray<float> InputB;
			public float Param;
			[WriteOnly] public NativeArray<float> Output;
			public FunctionPointer<f1x3_f1> Function;

			public void Execute(int index) => Output[index] = Function.Invoke(InputA[index], InputB[index], Param);
		}

		[BurstCompile]
		public struct NoiseField2DJob : IJobParallelFor
		{
			public int Width;
			public float2 Origin;
			public float Spacing;
			public NoiseKind Kind;
			[WriteOnly] public NativeArray<float> Output;

			public void Execute(int index)
			{
				var x = index % Width;
				var y = index / Width;
				var pos = Origin + new float2(x, y) * Spacing;
				Output[index] = Kind switch
				{
					NoiseKind.Simplex2 => pos.simplex2(),
					NoiseKind.Perlin2 => pos.perlin2(),
					NoiseKind.Fbm2 => fbm2(pos, 4),
					NoiseKind.Worley2 => worley2(pos),
					_ => pos.simplex2()
				};
			}
		}

		public static JobHandle ScheduleFloatUnary(NativeArray<float> input, NativeArray<float> output, FunctionPointer<f1_f1> function, int batchSize = 64, JobHandle deps = default) =>
			new FloatUnaryJob { Input = input, Output = output, Function = function }.Schedule(input.Length, batchSize, deps);

		public static JobHandle ScheduleFloatBinary(NativeArray<float> inputA, NativeArray<float> inputB, NativeArray<float> output, FunctionPointer<f1x2_f1> function, int batchSize = 64, JobHandle deps = default) =>
			new FloatBinaryJob { InputA = inputA, InputB = inputB, Output = output, Function = function }.Schedule(inputA.Length, batchSize, deps);

		public static JobHandle ScheduleFloatTernary(NativeArray<float> inputA, NativeArray<float> inputB, NativeArray<float> output, float param, FunctionPointer<f1x3_f1> function, int batchSize = 64, JobHandle deps = default) =>
			new FloatTernaryJob { InputA = inputA, InputB = inputB, Output = output, Param = param, Function = function }.Schedule(inputA.Length, batchSize, deps);

		public static JobHandle ScheduleNoise2D(NativeArray<float> output, int2 size, float2 origin, float spacing, NoiseKind kind = NoiseKind.Simplex2, int batchSize = 64, JobHandle deps = default) =>
			new NoiseField2DJob { Width = size.x, Origin = origin, Spacing = spacing, Kind = kind, Output = output }.Schedule(size.x * size.y, batchSize, deps);
	}
}
