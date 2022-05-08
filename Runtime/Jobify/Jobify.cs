using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using static Unity.Mathematics.OperationInterface;

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
            public FunctionPointer<FloatIO> FunctionPointer;
            public void Execute() {
                Output = FunctionPointer.Invoke(Input);
            }

            public Jobified(FunctionPointer<FloatIO> functionPointer, float input)
            {
                FunctionPointer = functionPointer;
                Input = input;
                Output = 0;
            }
            
        }

    } // Jobify class
}// Namespace