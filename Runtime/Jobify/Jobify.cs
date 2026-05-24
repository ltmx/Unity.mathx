// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	/// Converts Burst-compiled function pointers into Unity Jobs.
	public static class Jobify
	{
		[BurstCompile(CompileSynchronously = true)]
		public struct Jobified : IJob
		{
			[ReadOnly] public readonly float Input;
			public float Output;
			public FunctionPointer<f1_f1> FunctionPointer;

			public Jobified(FunctionPointer<f1_f1> functionPointer, float input)
			{
				FunctionPointer = functionPointer;
				Input = input;
				Output = 0;
			}

			public void Execute() => Output = FunctionPointer.Invoke(Input);
		}

		public static FunctionPointer<T> GetFunctionPointerDelegate<T>(T functionPointer) where T : Delegate =>
			new(Marshal.GetFunctionPointerForDelegate(functionPointer));

		public static ActionJob ToActionJob(this Action action) => new(GetFunctionPointerDelegate(action));

		public delegate void Action();

		[BurstCompile]
		public struct ActionJob : IJob
		{
			public static JobHandle Schedule(Action action, JobHandle inputDeps) =>
				action.ToActionJob().Schedule(inputDeps);

			FunctionPointer<Action> action;

			public ActionJob(FunctionPointer<Action> action) => this.action = action;

			public void Execute() => action.Invoke();
		}
	}
}
