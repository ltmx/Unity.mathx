// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using System;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		/// Projects a vector onto a plane defined by a normal orthogonal to the plane.
		[MI(IL)] public static float3 projectplane(this float3 f, float3 planeNormal) => f - project(f, planeNormal);

		/// Apply a function to a value a number of times.
		[MI(IL)] public static T apply<T>(this T input, Func<T, T> function, int cycles)
		{
			for (var i = 0; i < cycles; i++)
				input = function(input);
			return input;
		}

		[MI(IL)] public static float apply(this float input, FunctionPointer<f1_f1> function, int cycles)
		{
			for (var i = 0; i < cycles; i++)
				input = function.Invoke(input);
			return input;
		}

		[MI(IL)] public static float2 applyfp(this float2 input, FunctionPointer<f1_f1> function, int cycles)
		{
			for (var i = 0; i < cycles; i++)
				input = function.RunPerAxis(input);
			return input;
		}

		[MI(IL)] public static float3 applyfp(this float3 input, FunctionPointer<f1_f1> function, int cycles)
		{
			for (var i = 0; i < cycles; i++)
				input = function.RunPerAxis(input);
			return input;
		}

		[MI(IL)] public static float4 applyfp(this float4 input, FunctionPointer<f1_f1> function, int cycles)
		{
			for (var i = 0; i < cycles; i++)
				input = function.RunPerAxis(input);
			return input;
		}

		[MI(IL)] public static void forEach2D(int2 size, Action<int2> body)
		{
			for (var y = 0; y < size.y; y++)
			for (var x = 0; x < size.x; x++)
				body(new int2(x, y));
		}

		[MI(IL)] public static void forEach3D(int3 size, Action<int3> body)
		{
			for (var z = 0; z < size.z; z++)
			for (var y = 0; y < size.y; y++)
			for (var x = 0; x < size.x; x++)
				body(new int3(x, y, z));
		}

		[MI(IL)] public static JobHandle forEach2DBurst(int2 size, NativeArray<float> output, float2 origin, float spacing, JobParallelFor.NoiseKind kind = JobParallelFor.NoiseKind.Simplex2, int batchSize = 64, JobHandle deps = default) =>
			output.FillNoise2D(size, origin, spacing, kind, batchSize, deps);
	}
}
