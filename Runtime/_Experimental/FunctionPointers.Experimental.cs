#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

namespace Unity.Mathematics
{
    public class FunctionPointers_Experimental
    {
        #region Experimental

        #region Tests : No Benefits

        // public delegate float process2f2(f2 t1, f2 t2);
        // public delegate float process3f2(f2 t1, f2 t2, f2 t3);
        // public delegate float process4f2(f2 t1, f2 t2, f2 t3, f2 t4);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process2<T>(T t, T u) where T : struct;
        //
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process3<T>(T t, T u, T v) where T : struct;
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process4<T>(T t, T u, T v, T w) where T : struct;
        //
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process2<T, U>(T t, U u);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process3<T, U, V>(T t, U u, V v);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process3<T, U>(T t,  T u, U v);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process4<T, U>(T t, T u, T v, U w);
        //
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float processSignature(FunctionPointer<process> fp, float t);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process2Signature(FunctionPointer<process2> fp,float t1, float t2);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process3Signature(FunctionPointer<process3> fp,float t1, float t2, float t3);
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate float process4Signature(FunctionPointer<process4> fp,float t1, float t2, float t3, float t4);
        
        // [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        // public delegate f2 process3SignatureFloat2(FunctionPointer<process3f2> fp,f2 t1, f2 t2, f2 t3);
        
        // // Parallel operations With Pointer Compilation // Deprecated (slower)
        // public static f4 InvokeParallel(process2 func, f4 a, f4 b) => ToPointerInvoke(func).Parallel(a, b);
        // public static f3 InvokeParallel(process2 func, f3 a, f3 b) => ToPointerInvoke(func).Parallel(a, b);
        // public static f2 InvokeParallel(process2 func, f2 a, f2 b) => ToPointerInvoke(func).Parallel(a, b);
        // public static float  InvokeParallel(process2 func, float a, float b) => ToPointerInvoke(func).Parallel(a, b);
        
        // Parallel operations and float parameter With Pointer Compilation
        // public static f4 ParallelAndParam(this process3 func, f4 a, f4 b, float t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static f3 ParallelAndParam(this process3 func, f3 a, f3 b, float t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static f2 ParallelAndParam(this process3 func, f2 a, f2 b, float t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static float ParallelAndParam(this process3 func, float a, float b, float t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static f4 ParallelAndParam(this process3 func, f4 a, f4 b, f4 t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static f3 ParallelAndParam(this process3 func, f3 a, f3 b, f3 t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);
        // public static f2 InvokeParallelAndParam(this process3 func, f2 a, f2 b, f2 t) => ToPointerInvoke(func).ParallelAndParam(a, b, t);

        #endregion
        
        #region Deprecated
                
            // // [MonoPInvokeCallbackAttribute] attribute to the functions. You need to add this so that IL2CPP works with these functions.
            // // Todo: move these inside 
            // [BurstCompile] [MonoPInvokeCallback(typeof(process21))]
            // public static float mul(float a, float b) => a * b;
            // [BurstCompile] [MonoPInvokeCallback(typeof(process21))]
            // public static float csum(float a, float b) => a + b;
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
            // public delegate f2 process22(f2 a, f2 b);
            //
            // /// Process 2 f3 values
            // public delegate f3 process23(f3 a, f3 b);
            //
            // /// Process 2 f4 values
            // public delegate f4 process24(f4 a, f4 b);
            //
            // public delegate T process2t<T>(T a, T b);
            //
            // public delegate T delfpt<T>(T a, T b, FunctionPointer<process21> func);
            //
            // // Delegates
            // private delegate float delf1(float a, float b, FunctionPointer<process21> function);
            //
            // private delegate f2 delf2(f2 a, f2 b, FunctionPointer<process21> function);
            //
            // private delegate f3 delf3(f3 a, f3 b, FunctionPointer<process21> function);
            //
            // private delegate f4 delf4(f4 a, f4 b, FunctionPointer<process21> function);
            //
            // // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<float>))]
            // // static T OP<T>(T f1, T f2, FunctionPointer<process21> func) => funct<T>().Invoke(f1,f2, func);
            // // static FunctionPointer<delfpt<T>> funct<T>() => CompileFunctionPointer<delfpt<T>>(OP);
            //
            // // Operation Interfaces
            // [BurstCompile] [MonoPInvokeCallback(typeof(float))]
            // private static float OP(float f1, float f2, FunctionPointer<process21> func) => func.Invoke(f1, f2);
            // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<f2>))]
            // private static f2 OP(f2 f1, f2 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y));
            // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<f3>))]
            // private static f3 OP(f3 f1, f3 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z));
            // [BurstCompile] [MonoPInvokeCallback(typeof(delfpt<f4>))]
            // private static f4 OP(f4 f1, f4 f2, FunctionPointer<process21> func) => new(func.Invoke(f1.x, f2.x), func.Invoke(f1.y, f2.y), func.Invoke(f1.z, f2.z), func.Invoke(f1.w, f2.w));
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
            // private static FunctionPointer<process21> FP_sum = Comp<process21>(mathx.csum);
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
            // // public static f2 test = OP(1.0f, 2.0f, Compile(mathx.mul));
            // // public static f2 test2 = Process((f2)1.0f, 2.0f, mathx.mul);`
            // // public static f3 test3 = Process((f3)1.0f, 2.0f, mathx.mul);
            // // public static f4 test4 = Process((f4)1.0f, 2.0f, mathx.mul);
            // // public static f4 test5 = Process(1.0f, 2.0f, mathx.mul);
            //
            // // public static T Process<T>(T f1, T f2, process2t<T> func) where T : struct => funcf2.Invoke(f1, f2, Compile(func));
            // // public static f2 Process(f2 f1, f2 f2, process21 func) => funcf2.Invoke(f1, f2, Compile(func));
            // // public static f3 Process(f3 f1, f3 f2, process21 func) => funcf3.Invoke(f1, f2, Compile(func));
            // // public static f4 Process(f4 f1, f4 f2, process21 func) => funcf4.Invoke(f1, f2, Compile(func));
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

        // public delegate object processDelegate(object[] args);
        // public static object DelegateOperation(this Delegate func, object[] args) => ToPointer<processDelegate>(func.DynamicInvoke).Invoke(args);
        // public static object DelegateOperation(this FunctionPointer<processDelegate> func, object[] args) => func.Invoke(args);
        // public static object DelegateOperation(this processDelegate func, object[] args) => ToPointer(func).DelegateOperation(args);
        // public static FunctionPointer<Delegate> ToPointer(Delegate function) => CompileFunctionPointer(function);


        // Now generic parallel operation using these method overloads
        // public static T ParallelOperation<T>(process2vectors<T> func, T a, T b) where T : struct
        // {
        //     if (typeof(T) == typeof(f4)) return (T)(object)ParallelOperation(func as process2floats, (f4)(object)a, (f4)(object)b);
        //     if (typeof(T) == typeof(f3)) return (T)(object)ParallelOperation(func as process2floats, (f3)(object)a, (f3)(object)b);
        //     if (typeof(T) == typeof(f2)) return (T)(object)ParallelOperation(func as process2floats, (f2)(object)a, (f2)(object)b);
        //     if (typeof(T) == typeof(float)) return (T)(object)ParallelOperation(func as process2floats, (float)(object)a, (float)(object)b);
        //     throw new NotImplementedException();
        // }
        
        // public static float SequentialOperation(process2floats func, f4 a) => func.Invoke(func.Invoke(func.Invoke(a.x, a.y), a.z), a.w);

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
        //         public static MethodInfo myMethod = typeof(f4).GetMethod("MyMethod");
        //         
        //         public static f4 externalType = new f4();
        //         // Creates an instance of the specified type using that type's     // parameterless constructor
        //         public static f4 initiatedObject = (mathx.mul)Activator.CreateInstance(type);
        //         
        //         
        //         public static Type[] parameterTypes = { typeof(f4), typeof(f4) };
        //         public static MethodInfo myMethodwithParams = typeof(mathx).GetMethod("MyMethodWithParams", parameterTypes);
        // // Invoke
        //         public static object[] parameters = { "String", 5 };
        //         public static void dhit(){
        //             myMethodwithParams.invoke
        //         } 
        

        
        #endregion
    }
}