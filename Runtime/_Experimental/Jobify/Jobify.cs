#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

#if MATHX_FUNCTION_POINTERS

using System;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics // Should be defined in the assembly definition // Jobify namespace
{
    /// A static class to convert functions to jobs using prebaked delegates.
    public static class Jobify
    {
        [BurstCompile(CompileSynchronously = true)]
        public struct Jobified : IJob
        {
            [ReadOnly] public readonly float Input;
            public float Output;
            public FunctionPointer<f1_f1> FunctionPointer;
            public void Execute() {
                Output = FunctionPointer.Invoke(Input);
            }

            public Jobified(FunctionPointer<f1_f1> functionPointer, float input)
            {
                FunctionPointer = functionPointer;
                Input = input;
                Output = 0;
            }
            
        }
        
        public static FunctionPointer<T> GetFunctionPointerDelegate<T>(T functionPointer) where T : Delegate => new(Marshal.GetFunctionPointerForDelegate(functionPointer));

        public static ActionJob ToActionJob(this Action action) => new(GetFunctionPointerDelegate(action));
        // Credits to https://github.com/GilbertoGojira/DOTS-Stackray/blob/master/Packages/com.stackray.jobs/ActionJob.cs
        
        // public static T ToJob<T>(this Delegate action) where T : struct, IJob => new T(GetFunctionPointerDelegate(action));
        
        public delegate void Action();

        /// This job will execute an action
        [BurstCompile]
        public struct ActionJob : IJob {

            public static JobHandle Schedule(Action action, JobHandle inputDeps) 
                => action.ToActionJob().Schedule(inputDeps);
            private FunctionPointer<Action> Action;
            public ActionJob(FunctionPointer<Action> action) {
                Action = action;
            }
            public void Execute() => Action.Invoke();
        }

    }
}

#endif