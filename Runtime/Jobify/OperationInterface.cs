using System;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;

namespace Unity.Mathematics
{
    [BurstCompile] // Instruct Burst to look for static methods with [BurstCompile] attribute
    public static class OperationInterface
    {
        
        // Interface
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float FloatIO(float f); // float in-out
        // Interface
        public delegate float2 Float2IO(float2 f);
        // Interface
        public delegate float3 Float3IO(float3 f);
        // Interface
        public delegate float4 Float4IO(float4 f);
        
        
        // Interface
        public delegate float FloatIFloatO(float f); // float in-out
        // Interface
        public delegate float2 F2X2InF2Out(float2 f, float2 f2);
        // Interface
        public delegate float3 Float3IFloatO(float3 f);
        // Interface
        public delegate float4 Float4IFloatO(float4 f);

        public delegate T In1Out1<T>(T f) where T : struct;

        public delegate T In2Out1<T>(T f, T f1) where T : struct;


        [BurstCompile, MonoPInvokeCallback(typeof(FloatIO))]
        public static float mulx2(float a) => a * 2;
        public static FunctionPointer<FloatIO> mulx2Pointer = CompileFP<FloatIO>(mulx2);

        [BurstCompile, MonoPInvokeCallback(typeof(FloatIO))]
        public static float mul(float a, float b) => a * b;


        [BurstCompile, MonoPInvokeCallback(typeof(FloatIO))]
        public static float AddFloat(float a) => a + 2;

        public static FunctionPointer<T> CompileFP<T>(T d) where T : class
        {
            return BurstCompiler.CompileFunctionPointer(d);
        }
    }
}