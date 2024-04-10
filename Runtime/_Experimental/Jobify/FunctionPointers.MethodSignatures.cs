#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

#if MATHX_FUNCTION_POINTERS

using System;
using System.Runtime.InteropServices;
using static Unity.Burst.BurstCompiler;
using static Unity.Mathematics.FunctionPointers.Signature;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;
using CC = System.Runtime.InteropServices.CallingConvention;
using l = System.Single;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        // public static T Comp<T>(T delegateMethod) where T : class => CompileFunctionPointer(delegateMethod).Invoke;
        
        public static T compile<T>(T m) where T : class => CompileFunctionPointer(m).Invoke;
        
        // public static f2x1_f2 pointerf2x1_f2(f2x1_f2 m) => CompileFunctionPointer(m).Invoke;
       
        // public static f2x2_f2 pointer(f2x2_f2 m) => CompileFunctionPointer(m).Invoke;
        // public static f2x3_f2 pointer(f2x3_f2 m) => CompileFunctionPointer(m).Invoke;
        // public static f2x4_f2 pointer(f2x4_f2 m) => CompileFunctionPointer(m).Invoke;
        
        // public static f3x1_f3 pointer(f3x1_f3 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x2_f3 pointer(f3x2_f3 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x3_f3 pointer(f3x3_f3 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x4_f3 pointer(f3x4_f3 m) => CompileFunctionPointer(m).Invoke;
        
        // public static f4x1_f4 pointer(f4x1_f4 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x2_f4 pointer(f4x2_f4 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x3_f4 pointer(f4x3_f4 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x4_f4 pointer(f4x4_f4 m) => CompileFunctionPointer(m).Invoke;
        
        
        public static f1_f1 compile(f1_f1 m) => CompileFunctionPointer(m).Invoke;
        public static f1_i1 compile(f1_i1 m) => CompileFunctionPointer(m).Invoke;
        // public static f2_f1 pointer(f2_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f3_f1 pointer(f3_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f4_f1 pointer(f4_f1 m) => CompileFunctionPointer(m).Invoke;
        
        public static f1x2_f1 compile(f1x2_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f2x2_f1 pointer(f2x2_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x2_f1 pointer(f3x2_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x2_f1 pointer(f4x2_f1 m) => CompileFunctionPointer(m).Invoke;
        
        public static f1x3_f1 compile(f1x3_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f2x3_f1 pointer(f2x3_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x3_f1 pointer(f3x3_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x3_f1 pointer(f4x3_f1 m) => CompileFunctionPointer(m).Invoke;
        
        public static f1x4_f1 compile(f1x4_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f2x4_f1 pointer(f2x4_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f3x4_f1 pointer(f3x4_f1 m) => CompileFunctionPointer(m).Invoke;
        // public static f4x4_f1 pointer(f4x4_f1 m) => CompileFunctionPointer(m).Invoke;
            
        public class Signature
        {
            private const CallingConvention C = CallingConvention.Cdecl;
            
            // Method Signatures
            // [UFP(C)] public delegate float f1(float t);
            //
            // [UFP(C)] public delegate float f2(float t1, float t2);
            // [UFP(C)] public delegate float f3(float t1, float t2, float t3);
            // [UFP(C)] public delegate float f4(float t1, float t2, float t3, float t4);
            //
            // [UFP(C)] public delegate float2 f2x1_f2(float2 t);
            // [UFP(C)] public delegate float2 f2x2_f2(float2 t1, float2 t2);
            // [UFP(C)] public delegate float2 f2x3_f2(float2 t1, float2 t2, float2 t3);
            // [UFP(C)] public delegate float2 f2x4_f2(float2 t1, float2 t2, float2 t3, float2 t4);
            //
            // [UFP(C)] public delegate float3 f3x1_f3(float3 t);
            // [UFP(C)] public delegate float3 f3x2_f3(float3 t1, float3 t2);
            // [UFP(C)] public delegate float3 f3x3_f3(float3 t1, float3 t2, float3 t3);
            // [UFP(C)] public delegate float3 f3x4_f3(float3 t1, float3 t2, float3 t3, float3 t4);
            //
            // [UFP(C)] public delegate float4 f4x1_f4(float4 t);
            // [UFP(C)] public delegate float4 f4x2_f4(float4 t1, float4 t2);
            // [UFP(C)] public delegate float4 f4x3_f4(float4 t1, float4 t2, float4 t3);
            // [UFP(C)] public delegate float4 f4x4_f4(float4 t1, float4 t2, float4 t3, float4 t4);
            
            
            [UFP(C)] public delegate float f1_f1(float f);
            // [UFP(C)] public delegate float f2_f1(float2 f);
            // [UFP(C)] public delegate float f3_f1(float3 f);
            // [UFP(C)] public delegate float f4_f1(float4 f);
            
            [UFP(C)] public delegate float f1x2_f1(float f, float f1);
            // [UFP(C)] public delegate float f2x2_f1(float2 f, float2 f1);
            // [UFP(C)] public delegate float f3x2_f1(float3 f, float3 f1);
            // [UFP(C)] public delegate float f4x2_f1(float4 f, float4 f1);
            
            [UFP(C)] public delegate float f1x3_f1(float f, float f1, float f2);
            // [UFP(C)] public delegate float f2x3_f1(float2 f, float2 f1, float2 f2);
            // [UFP(C)] public delegate float f3x3_f1(float3 f, float3 f1, float3 f2);
            // [UFP(C)] public delegate float f4x3_f1(float4 f, float4 f1, float4 f2);
            
            [UFP(C)] public delegate float f1x4_f1(float f, float f1, float f2, float f3);
            // [UFP(C)] public delegate float f2x4_f1(float2 f, float2 f1, float2 f2, float2 f3);
            // [UFP(C)] public delegate float f3x4_f1(float3 f, float3 f1, float3 f2, float3 f3);
            // [UFP(C)] public delegate float f4x4_f1(float4 f, float4 f1, float4 f2, float4 f3);
            
            
            [UFP(C)] public delegate float u1_f1(uint f);
            // [UFP(C)] public delegate float u2_f1(uint2 f);
            // [UFP(C)] public delegate float u3_f1(uint3 f);
            // [UFP(C)] public delegate float u4_f1(uint4 f);
            
            [UFP(C)] public delegate float u1x2_f1(uint f,  uint f1);
            // [UFP(C)] public delegate float u2x2_f1(uint2 f, uint2 f1);
            // [UFP(C)] public delegate float u3x2_f1(uint3 f, uint3 f1);
            // [UFP(C)] public delegate float u4x2_f1(uint4 f, uint4 f1);
            
            [UFP(C)] public delegate float u1x3_f1(uint f,  uint f1,  uint f2);
            // [UFP(C)] public delegate float u2x3_f1(uint2 f, uint2 f1, uint2 f2);
            // [UFP(C)] public delegate float u3x3_f1(uint3 f, uint3 f1, uint3 f2);
            // [UFP(C)] public delegate float u4x3_f1(uint4 f, uint4 f1, uint4 f2);
            
            [UFP(C)] public delegate float u1x4_f1(uint f,  uint f1,  uint f2,  uint f3);
            // [UFP(C)] public delegate float u2x4_f1(uint2 f, uint2 f1, uint2 f2, uint2 f3);
            // [UFP(C)] public delegate float u3x4_f1(uint3 f, uint3 f1, uint3 f2, uint3 f3);
            // [UFP(C)] public delegate float u4x4_f1(uint4 f, uint4 f1, uint4 f2, uint4 f3);
            
            
            [UFP(C)] public delegate float i1_f1(int f);
            [UFP(C)] public delegate int f1_i1(float f);
            // [UFP(C)] public delegate float i2_f1(int2 f);
            // [UFP(C)] public delegate float i3_f1(int3 f);
            // [UFP(C)] public delegate float i4_f1(int4 f);
            //
            [UFP(C)] public delegate float i1x2_f1(int f,  int f1);
            // [UFP(C)] public delegate float i2x2_f1(int2 f, int2 f1);
            // [UFP(C)] public delegate float i3x2_f1(int3 f, int3 f1);
            // [UFP(C)] public delegate float i4x2_f1(int4 f, int4 f1);
            //
            [UFP(C)] public delegate float i1x3_f1(int f,  int f1,  int f2);
            // [UFP(C)] public delegate float i2x3_f1(int2 f, int2 f1, int2 f2);
            // [UFP(C)] public delegate float i3x3_f1(int3 f, int3 f1, int3 f2);
            // [UFP(C)] public delegate float i4x3_f1(int4 f, int4 f1, int4 f2);
            
            [UFP(C)] public delegate float i1x4_f1(int f,  int f1,  int f2,  int f3);
            // [UFP(C)] public delegate float i2x4_f1(int2 f, int2 f1, int2 f2, int2 f3);
            // [UFP(C)] public delegate float i3x4_f1(int3 f, int3 f1, int3 f2, int3 f3);
            // [UFP(C)] public delegate float i4x4_f1(int4 f, int4 f1, int4 f2, int4 f3);
            //
            //
            [UFP(C)] public delegate int i1_i1(int f);
            // [UFP(C)] public delegate int2 i2_i2(int2 f);
            // [UFP(C)] public delegate int3 i3_i3(int3 f);
            // [UFP(C)] public delegate int4 i4_i4(int4 f);
            //
            [UFP(C)] public delegate int i1x2_i1(int f,  int f1);
            // [UFP(C)] public delegate int2 i2x2_i2(int2 f, int2 f1);
            // [UFP(C)] public delegate int3 i3x2_i3(int3 f, int3 f1);
            // [UFP(C)] public delegate int4 i4x2_i4(int4 f, int4 f1);
            //
            [UFP(C)] public delegate int i1x3_i1(int f,  int f1,  int f2);
            // [UFP(C)] public delegate int2 i2x3_i2(int2 f, int2 f1, int2 f2);
            // [UFP(C)] public delegate int3 i3x3_i3(int3 f, int3 f1, int3 f2);
            // [UFP(C)] public delegate int4 i4x3_i4(int4 f, int4 f1, int4 f2);
            //
            [UFP(C)] public delegate int i1x4_i1(int f,  int f1,  int f2,  int f3);
            // [UFP(C)] public delegate int2 i2x4_i2(int2 f, int2 f1, int2 f2, int2 f3);
            // [UFP(C)] public delegate int3 i3x4_i3(int3 f, int3 f1, int3 f2, int3 f3);
            // [UFP(C)] public delegate int4 i4x4_i4(int4 f, int4 f1, int4 f2, int4 f3);
            
            
            [UFP(C)] public delegate double d1_d1(double f);
            // [UFP(C)] public delegate double2 d2_d2(double2 f);
            // [UFP(C)] public delegate double3 d3_d3(double3 f);
            // [UFP(C)] public delegate double4 d4_d4(double4 f);
            
            [UFP(C)] public delegate double d1x2_d1(double f,  double f1);
            // [UFP(C)] public delegate double2 d2x2_d2(double2 f, double2 f1);
            // [UFP(C)] public delegate double3 d3x2_d3(double3 f, double3 f1);
            // [UFP(C)] public delegate double4 d4x2_d4(double4 f, double4 f1);
            
            [UFP(C)] public delegate double d1x3_d1(double f,  double f1,  double f2);
            // [UFP(C)] public delegate double2 d2x3_d2(double2 f, double2 f1, double2 f2);
            // [UFP(C)] public delegate double3 d3x3_d3(double3 f, double3 f1, double3 f2);
            // [UFP(C)] public delegate double4 d4x3_d4(double4 f, double4 f1, double4 f2);
            
            [UFP(C)] public delegate double d1x4_d1(double f,  double f1,  double f2,  double f3);
            // [UFP(C)] public delegate double2 d2x4_d2(double2 f, double2 f1, double2 f2, double2 f3);
            // [UFP(C)] public delegate double3 d3x4_d3(double3 f, double3 f1, double3 f2, double3 f3);
            // [UFP(C)] public delegate double4 d4x4_d4(double4 f, double4 f1, double4 f2, double4 f3);
        }
    }
}

#endif