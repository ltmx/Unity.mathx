using Unity.Burst;
using Unity.Jobs;

namespace Unity.Mathematics // Should be defined in the assembly definition // Jobify namespace
{
    /// A static class to convert functions to jobs using prebaked delegates.
    public static class Jobify
    {
        [BurstCompile]
        public struct Jobified : IJob
        {
            public float Input;
            public float Output;
            public FunctionPointer<OperationInterface.FloatInOut> Method;
            public void Execute() {
                Output = Method.Invoke(Input);
            }

            public Jobified(OperationInterface.FloatInOut method, float input) {
                Method = BurstCompiler.CompileFunctionPointer(method);
                Input = input;
                Output = 0;
            }
            
        }

    } // Jobify class
}// Namespace