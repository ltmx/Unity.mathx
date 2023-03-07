#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System;
using AOT;
using Unity.Burst;
using static Unity.Burst.BurstCompiler;
using fx = Unity.Mathematics.float4;

namespace Unity.Mathematics
{
    // using process2 = mathx.process2;
    // using process3 = mathx.process3;
    // using FPprocess2 = FunctionPointer<mathx.process2>;
    // using FunctionPointer<process3> = FunctionPointer<mathx.process3>;
    [BurstCompile]
    public static partial class mathx
    {
        // Method Signatures
        public delegate float process(float t);
        public delegate float process2(float t1, float t2);
        public delegate float process3(float t1, float t2, float t3);
        public delegate float process4(float t1, float t2, float t3, float t4);
        // public delegate float process2<T, U>(T t, U u);
        // public delegate float process3<T, U, V>(T t, U u, V v);
        // public delegate float process4<T, U, V, W>(T t, U u, V v, W w);
        
        public delegate float processSignature(FunctionPointer<process> fp, float t);
        public delegate float process2Signature(FunctionPointer<process2> fp,float t1, float t2);
        public delegate float process3Signature(FunctionPointer<process3> fp,float t1, float t2, float t3);
        public delegate float process4Signature(FunctionPointer<process4> fp,float t1, float t2, float t3, float t4);
        
        
        
        //generic function pointer compiler
        // public static FunctionPointer<T> ToPointer<T>(T function) where T : Delegate => CompileFunctionPointer(function); // Inferred Type
        // public static FunctionPointer<process2> ToPointer(process2 function) => BurstCompiler.CompileFunctionPointer(function); // Inferred Type
        // public static FunctionPointer<process3> ToPointer(process3 function) => CompileFunctionPointer(function); // Inferred Type

        // Parallel operations
        [BurstCompile] [MonoPInvokeCallback(typeof(process2Signature))]
        public static float4 Parallel(this FunctionPointer<process2> func, float4 a, float4 b) => new(func.Invoke(a.x, b.x), func.Invoke(a.y, b.y), func.Invoke(a.z, b.z), func.Invoke(a.w, b.w));
        [BurstCompile] [MonoPInvokeCallback(typeof(process2Signature))]
        public static float3 Parallel(this FunctionPointer<process2> func, float3 a, float3 b) => new(func.Invoke(a.x, b.x), func.Invoke(a.y, b.y), func.Invoke(a.z, b.z));
        [BurstCompile] [MonoPInvokeCallback(typeof(process2Signature))]
        public static float2 Parallel(this FunctionPointer<process2> func, float2 a, float2 b) => new(func.Invoke(a.x, b.x), func.Invoke(a.y, b.y));
        [BurstCompile] [MonoPInvokeCallback(typeof(process2Signature))]
        public static float Parallel(this FunctionPointer<process2> func, float a, float b) => func.Invoke(a, b);
        
        
        // Parallel operations With Pointer Compilation
        // public static float4 Parallel(process2 func, float4 a, float4 b) => ToPointer(func).Parallel(a, b);
        // public static float3 Parallel(process2 func, float3 a, float3 b) => ToPointer(func).Parallel(a, b);
        // public static float2 Parallel(process2 func, float2 a, float2 b) => ToPointer(func).Parallel(a, b);
        // public static float Parallel(process2 func, float a, float b) => ToPointer(func).Parallel(a, b);

        // Parallel operations and float parameter
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float4 ParallelAndParam(this FunctionPointer<process3> func, float4 a, float4 b, float t) => new(func.Invoke(a.x, b.x, t), func.Invoke(a.y, b.y, t), func.Invoke(a.z, b.z, t), func.Invoke(a.w, b.w, t));
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float3 ParallelAndParam(this FunctionPointer<process3> func, float3 a, float3 b, float t) => new(func.Invoke(a.x, b.x, t), func.Invoke(a.y, b.y, t), func.Invoke(a.z, b.z, t));
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float2 ParallelAndParam(this FunctionPointer<process3> func, float2 a, float2 b, float t) => new(func.Invoke(a.x, b.x, t), func.Invoke(a.y, b.y, t));
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float ParallelAndParam(this FunctionPointer<process3> func, float a, float b, float t) => func.Invoke(a, b, t);
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float4 ParallelAndParam(this FunctionPointer<process3> func, float4 a, float4 b, float4 t) => new(func.Invoke(a.x, b.x, t.x), func.Invoke(a.y, b.y, t.y), func.Invoke(a.z, b.z, t.z), func.Invoke(a.w, b.w, t.w));
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float3 ParallelAndParam(this FunctionPointer<process3> func, float3 a, float3 b, float3 t) => new(func.Invoke(a.x, b.x, t.x), func.Invoke(a.y, b.y, t.y), func.Invoke(a.z, b.z, t.z));
        [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        public static float2 ParallelAndParam(this FunctionPointer<process3> func, float2 a, float2 b, float2 t) => new(func.Invoke(a.x, b.x, t.x), func.Invoke(a.y, b.y, t.y));
        
        // Parallel operations and float parameter With Pointer Compilation
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float4 ParallelAndParam(this process3 func, float4 a, float4 b, float t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float3 ParallelAndParam(this process3 func, float3 a, float3 b, float t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float2 ParallelAndParam(this process3 func, float2 a, float2 b, float t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float ParallelAndParam(this process3 func, float a, float b, float t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float4 ParallelAndParam(this process3 func, float4 a, float4 b, float4 t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float3 ParallelAndParam(this process3 func, float3 a, float3 b, float3 t) => ToPointer(func).ParallelAndParam(a, b, t);
        // [BurstCompile] [MonoPInvokeCallback(typeof(process3Signature))]
        // public static float2 ParallelAndParam(this process3 func, float2 a, float2 b, float2 t) => ToPointer(func).ParallelAndParam(a, b, t);
        
        // Summing operations (for example, for calculating a dot product)
        public static float SumOperations(process2 func, float4 a, float4 b) => func.Invoke(a.x, b.x) + func.Invoke(a.y, b.y) + func.Invoke(a.z, b.z) + func.Invoke(a.w, b.w);
        public static float SumOperations(process2 func, float3 a, float3 b) => func.Invoke(a.x, b.x) + func.Invoke(a.y, b.y) + func.Invoke(a.z, b.z);
        public static float SumOperations(process2 func, float2 a, float2 b) => func.Invoke(a.x, b.x) + func.Invoke(a.y, b.y);
        public static float SumOperations(process2 func, float a, float b) => func.Invoke(a, b);


        #region Experimental
        
        // public delegate object processDelegate(object[] args);
        // public static object DelegateOperation(this Delegate func, object[] args) => ToPointer<processDelegate>(func.DynamicInvoke).Invoke(args);
        // public static object DelegateOperation(this FunctionPointer<processDelegate> func, object[] args) => func.Invoke(args);
        // public static object DelegateOperation(this processDelegate func, object[] args) => ToPointer(func).DelegateOperation(args);
        // public static FunctionPointer<Delegate> ToPointer(Delegate function) => CompileFunctionPointer(function);


        // Now generic parallel operation using these method overloads
        // public static T ParallelOperation<T>(process2vectors<T> func, T a, T b) where T : struct
        // {
        //     if (typeof(T) == typeof(float4)) return (T)(object)ParallelOperation(func as process2floats, (float4)(object)a, (float4)(object)b);
        //     if (typeof(T) == typeof(float3)) return (T)(object)ParallelOperation(func as process2floats, (float3)(object)a, (float3)(object)b);
        //     if (typeof(T) == typeof(float2)) return (T)(object)ParallelOperation(func as process2floats, (float2)(object)a, (float2)(object)b);
        //     if (typeof(T) == typeof(float)) return (T)(object)ParallelOperation(func as process2floats, (float)(object)a, (float)(object)b);
        //     throw new NotImplementedException();
        // }
        
        // public static float SequentialOperation(process2floats func, float4 a) => func.Invoke(func.Invoke(func.Invoke(a.x, a.y), a.z), a.w);

        // public static float Seq<T>(this T value, FunctionPointer<process2floats> operation) where T : unmanaged
        // {
        //     float result = 0;
        //     int length = Unsafe.SizeOf<T>() / sizeof(float);
        //     for (int i = 0; i < length; i++)
        //     {
        //         float component = Unsafe.Add(ref Unsafe.As<T, float>(ref Unsafe.AsRef(in value)), i);
        //         result = operation.Invoke(result, component);
        //     }
        //     return result;
        // }

        // var staticMethod = type.GetMethod("StaticMethod");
        // staticMethod.Invoke(null, null);
        // Lookup the Type dynamically
        // // Alternatively use typeof(ExternalType);
        //         public static Type type = Type.GetType("mathx");
        // // Lookup the method
        //         public static MethodInfo myMethod = typeof(float4).GetMethod("MyMethod");
        //         
        //         public static float4 externalType = new float4();
        //         // Creates an instance of the specified type using that type's     // parameterless constructor
        //         public static float4 initiatedObject = (mathx.mul)Activator.CreateInstance(type);
        //         
        //         
        //         public static Type[] parameterTypes = { typeof(float4), typeof(float4) };
        //         public static MethodInfo myMethodwithParams = typeof(mathx).GetMethod("MyMethodWithParams", parameterTypes);
        // // Invoke
        //         public static object[] parameters = { "String", 5 };
        //         public static void dhit(){
        //             myMethodwithParams.invoke
        //         } 

        #endregion

        #region Deprecated
        
        // // [MonoPInvokeCallbackAttribute] attribute to the functions. You need to add this so that IL2CPP works with these functions.
        // // Todo: move these inside 
        // [BurstCompile] [MonoPInvokeCallback(typeof(process21))]
        // public static float mul(float a, float b) => a * b;
        // [BurstCompile] [MonoPInvokeCallback(typeof(process21))]
        // public static float sum(float a, float b) => a + b;
        //
        //  // [BurstCompile]
        // // [MonoPInvokeCallback(typeof(process2))]
        // // public static float mul(this float a, float b) => a * b;
        // //
        // // [BurstCompile]
        // // [MonoPInvokeCallback(typeof(process2))]
        // // public static float add(this float a, float b) => a + b;
        //
        // // A common interface for both MultiplyFloat and AddFloat methods
        //
        // // operation interfaces
        // /// Process 2 float values
        // public delegate float process21(float a, float b);
        //
        // /// Process 2 float values
        // public delegate float2 process22(float2 a, float2 b);
        //
        // /// Process 2 float3 values
        // public delegate float3 process23(float3 a, float3 b);
        //
        // /// Process 2 float4 values
        // public delegate float4 process24(float4 a, float4 b);
        //
        // public delegate T process2t<T>(T a, T b);
        //
        // public delegate T delfpt<T>(T a, T b, FunctionPointer<process21> func);
        //
        // // Delegates
        // private delegate float delf1(float a, float b, FunctionPointer<process21> function);
        //
        // private delegate float2 delf2(float2 a, float2 b, FunctionPointer<process21> function);
        //
        // private delegate float3 delf3(float3 a, float3 b, FunctionPointer<process21> function);
        //
        // private delegate float4 delf4(float4 a, float4 b, FunctionPointer<process21> function);
        //
        // // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float>))]
        // // static T OP<T>(T f1, T f2, FunctionPointer<process21> func) => funct<T>().Invoke(f1,f2, func);
        // // static FunctionPointer<delfpt<T>> funct<T>() => CompileFunctionPointer<delfpt<T>>(OP);
        //
        // // Operation Interfaces
        // [BurstCompile] [MonoPInvokeCallback(typeof(float))]
        // private static float OP(float f1, float f2, FunctionPointer<process21> func) => func.Invoke(f1, f2);
        // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float2>))]
        // private static float2 OP(float2 f1, float2 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y));
        // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float3>))]
        // private static float3 OP(float3 f1, float3 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z));
        // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float4>))]
        // private static float4 OP(float4 f1, float4 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z), func.Invoke(f1.w, f2.w));
        //
        // // Compiled function pointers
        // // static FunctionPointer<T> funct<T>() => Comp(OP);
        // private static FunctionPointer<delf1> funcf1 = Comp<delf1>(OP);
        // private static FunctionPointer<delf2> funcf2 = Comp<delf2>(OP);
        // private static FunctionPointer<delf3> funcf3 = Comp<delf3>(OP);
        //
        // private static FunctionPointer<delf4> funcf4 = Comp<delf4>(OP);
        // // static FunctionPointer<process22> funcF2OP = Comp<process22>(mul);
        //
        // private static FunctionPointer<process21> FP_mul = Comp<process21>(math.mul);
        // private static FunctionPointer<process21> FP_sum = Comp<process21>(mathx.sum);
        // private static FunctionPointer<process21> FP_max = Comp<process21>(math.max);
        //
        // private static FunctionPointer<process21> FP_min = Comp<process21>(math.min);
        // // Specify type in advance with method overload to simplify code
        // // static FunctionPointer<process21> Compile(process21 func) => Comp(func);
        // // static FunctionPointer<process22> Compile(process22 func) => Comp(func);
        // // static FunctionPointer<process23> Compile(process23 func) => Comp(func);
        // // static FunctionPointer<process24> Compile(process24 func) => Comp(func);
        //
        // private static FunctionPointer<process2t<T>> Compile<T>(process2t<T> func) => Comp(func);
        //
        // // public static float2 test = OP(1.0f, 2.0f, Compile(mathx.mul));
        // // public static float2 test2 = Process((float2)1.0f, 2.0f, mathx.mul);`
        // // public static float3 test3 = Process((float3)1.0f, 2.0f, mathx.mul);
        // // public static float4 test4 = Process((float4)1.0f, 2.0f, mathx.mul);
        // // public static float4 test5 = Process(1.0f, 2.0f, mathx.mul);
        //
        // // public static T Process<T>(T f1, T f2, process2t<T> func) where T : struct => funcf2.Invoke(f1, f2, Compile(func));
        // // public static float2 Process(float2 f1, float2 f2, process21 func) => funcf2.Invoke(f1, f2, Compile(func));
        // // public static float3 Process(float3 f1, float3 f2, process21 func) => funcf3.Invoke(f1, f2, Compile(func));
        // // public static float4 Process(float4 f1, float4 f2, process21 func) => funcf4.Invoke(f1, f2, Compile(func));
        // // //
        // // public static T Process<T>(T f1, T f2, delfpt<T> func) where T : struct => funct<T>().Invoke(f1, f2, func);
        // // public static T Process<T>(T f1, T f2, process21 func) where T : struct => funcf1.Invoke(f1, f2, Compile(func));
        // private static FunctionPointer<T> Comp<T>(T delegatMethod) where T : Delegate => CompileFunctionPointer(delegatMethod);
        //
        // // Testing dynamic invoking compiled funcion with burst
        // public delegate object dynainvokedelegate(object[] args);
        //
        // public static object DynamicInvokeNormal(this Delegate method, params object[] args) => method.DynamicInvoke(args);
        // public static FunctionPointer<dynainvokedelegate> DynamicInvokeCompiled(this Delegate method) => Comp<dynainvokedelegate>(method.DynamicInvoke);
        // public static FunctionPointer<T> DynamicCompile<T>(T method) where T : Delegate => CompileFunctionPointer(method);
        // public static object DynamicCompiledInvoke<T>(T method, object[] args) where T : Delegate => DynamicInvokeCompiled(method).Invoke(args);

        #endregion
    }
}