#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;
using AOT;
using Unity.Burst;
using static Unity.Burst.BurstCompiler;
using static Unity.Mathematics.Operations;


namespace Unity.Mathematics
{
    
    public static class Operations {
        // [BurstCompile]
        // [MonoPInvokeCallback(typeof(p2f))]
        // public static float mul(this float a, float b) => a * b;
        //
        // [BurstCompile]
        // [MonoPInvokeCallback(typeof(p2f))]
        // public static float add(this float a, float b) => a + b;

        // A common interface for both MultiplyFloat and AddFloat methods
        
        
        // operation interfaces
        /// Process 2 float values
        public delegate float p2f1(float a, float b);
        /// Process 2 float values
        public delegate float2 p2f2(float2 a, float2 b);
        /// Process 2 float3 values
        public delegate float3 p2f3(float3 a, float3 b);
        /// Process 2 float4 values
        public delegate float4 p2f4(float4 a, float4 b);
        
        public delegate T p2ft<T>(T a, T b);
        public delegate T delfpt<T>(T a, T b, FunctionPointer<p2f1> func);
        
        // Delegates
        delegate float delf1(float a, float b, FunctionPointer<p2f1> function);
        // delegate float2 delf2(float2 a, float2 b, FunctionPointer<p2f1> function);
        // delegate float3 delf3(float3 a, float3 b, FunctionPointer<p2f1> function);
        // delegate float4 delf4(float4 a, float4 b, FunctionPointer<p2f1> function);
        
        [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float>))]
        static T OP<T>(T f1, T f2, FunctionPointer<p2f1> func) => funct<T>().Invoke(f1,f2, func);
        static FunctionPointer<delfpt<T>> funct<T>() => CompileFunctionPointer<delfpt<T>>(OP);
        
        // Operation Interfaces
        [BurstCompile] [MonoPInvokeCallback(typeof(float))]
        static float OP(float f1, float f2, FunctionPointer<p2f1> func) => func.Invoke(f1, f2);
        [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float2>))]
        static float2 OP(float2 f1, float2 f2, FunctionPointer<p2f1> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y));
        [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float3>))]
        static float3 OP(float3 f1, float3 f2, FunctionPointer<p2f1> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z));
        [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float4>))]
        static float4 OP(float4 f1, float4 f2, FunctionPointer<p2f1> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z), func.Invoke(f1.w, f2.w));
        
        

        // Compiled function pointers
        // static FunctionPointer<T> funct<T>() => Comp(OP);
        // static FunctionPointer<delf1> funcf1 = Comp<delf1>(OP);
        // static FunctionPointer<delf2> funcf2 = Comp<delf2>(OP);
        // static FunctionPointer<delf3> funcf3 = Comp<delf3>(OP);
        // static FunctionPointer<delf4> funcf4 = Comp<delf4>(OP);
        // static FunctionPointer<p2f2> funcF2OP = Comp<p2f2>(mul);
            
        static FunctionPointer<p2f1> FP_mul = Comp<p2f1>(math.mul);
        static FunctionPointer<p2f1> FP_sum = Comp<p2f1>(mathx.sum);
        static FunctionPointer<p2f1> FP_max = Comp<p2f1>(math.max);
        static FunctionPointer<p2f1> FP_min = Comp<p2f1>(math.min);
        // Specify type in advance with method overload to simplify code
        // static FunctionPointer<p2f1> Compile(p2f1 func) => Comp(func);
        // static FunctionPointer<p2f2> Compile(p2f2 func) => Comp(func);
        // static FunctionPointer<p2f3> Compile(p2f3 func) => Comp(func);
        // static FunctionPointer<p2f4> Compile(p2f4 func) => Comp(func);
        
        static FunctionPointer<p2ft<T>> Compile<T>(p2ft<T> func) => Comp(func);


        // public static float2 test = OP(1.0f, 2.0f, Compile(mathx.mul));
        // public static float2 test2 = Process((float2)1.0f, 2.0f, mathx.mul);
        // public static float3 test3 = Process((float3)1.0f, 2.0f, mathx.mul);
        // public static float4 test4 = Process((float4)1.0f, 2.0f, mathx.mul);
        // public static float4 test5 = Process(1.0f, 2.0f, mathx.mul);
        
        // public static T Process<T>(T f1, T f2, p2ft<T> func) where T : struct => funcf2.Invoke(f1, f2, Compile(func));
        // public static float2 Process(float2 f1, float2 f2, p2f1 func) => funcf2.Invoke(f1, f2, Compile(func));
        // public static float3 Process(float3 f1, float3 f2, p2f1 func) => funcf3.Invoke(f1, f2, Compile(func));
        // public static float4 Process(float4 f1, float4 f2, p2f1 func) => funcf4.Invoke(f1, f2, Compile(func));
        //
        // public static T Process<T>(T f1, T f2, delfpt<T> func) where T : struct => funct<T>().Invoke(f1, f2, func);
        // public static T Process<T>(T f1, T f2, p2f1 func) where T : struct => funcf1.Invoke(f1, f2, Compile(func));


        private static FunctionPointer<T> Comp<T>(T delegatMethod) where T : Delegate => CompileFunctionPointer(delegatMethod);
        
        // Testing dynamic invoking compiled funciton with burst
        public delegate object dynainvokedelegate(object[] args);
        
        public static object DynamicInvokeNormal(this Delegate method, params object[] args) => method.DynamicInvoke(args);
        public static FunctionPointer<dynainvokedelegate> DynamicInvokeCompiled(this Delegate method) => Comp<dynainvokedelegate>(method.DynamicInvoke);
        
        public static FunctionPointer<T> DynamicCompile<T>(T method) where T : Delegate => CompileFunctionPointer(method);
        public static object DynamicCompiledInvoke<T>(T method, object[] args) where T : Delegate => DynamicInvokeCompiled(method).Invoke(args);
    }
    public static partial class mathx
    {
        // [MonoPInvokeCallbackAttribute] attribute to the functions. You need to add this so that IL2CPP works with these functions.
        // Todo: move these inside 
        [BurstCompile, MonoPInvokeCallback(typeof(p2f1))] public static float mul(float a, float b) => a * b;
        [BurstCompile, MonoPInvokeCallback(typeof(p2f1))] public static float sum(float a, float b) => a + b;
        // [BurstCompile, MonoPInvokeCallback(typeof(p2f))] static float max(float a, float b) => math.max(a, b);
        // [BurstCompile, MonoPInvokeCallback(typeof(p2f))] static float min(float a, float b) => math.min(a, b);
    }
}
