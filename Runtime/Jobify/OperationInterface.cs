using AOT;
using Unity.Burst;

namespace Unity.Mathematics
{
    [BurstCompile] // Instruct Burst to look for static methods with [BurstCompile] attribute
    public static class OperationInterface
    {
        // Interface
        public delegate float FloatInOut(float a);
        

        [BurstCompile] 
        [MonoPInvokeCallback(typeof(FloatInOut))] // Necessary for IL2CPP
        public static float MultiplyFloat(float a) => a * 2;
        // // Compiled
        // public static FunctionPointer<FloatInOut> mulFunctionPointer = BurstCompiler.CompileFunctionPointer<FloatInOut>(MultiplyFloat);

        
        
        [BurstCompile]
        [MonoPInvokeCallback(typeof(FloatInOut))]
        public static float AddFloat(float a) => a + 2;
        // // Compiled
        // public static FunctionPointer<FloatInOut> addFunctionPointer = BurstCompiler.CompileFunctionPointer<FloatInOut>(AddFloat);
    }
}