#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        public static class MethodSignatures
        {
            // Method Signatures
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1(float t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f2(float t1, float t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f3(float t1, float t2, float t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f4(float t1, float t2, float t3, float t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 f1x2(float2 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 f2x2(float2 t1, float2 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 f3x2(float2 t1, float2 t2, float2 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 f4x2(float2 t1, float2 t2, float2 t3, float2 t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 f1x3(float3 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 f2x3(float3 t1, float3 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 f3x3(float3 t1, float3 t2, float3 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 f4x3(float3 t1, float3 t2, float3 t3, float3 t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 f1x4(float4 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 f2x4(float4 t1, float4 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 f3x4(float4 t1, float4 t2, float4 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 f4x4(float4 t1, float4 t2, float4 t3, float4 t4);
            

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate U fxf<T, U>(T t1) where U : struct where T : struct;

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1_f1(float f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f2_f1(float2 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f3_f1(float3 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f4_f1(float4 f);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1x2_f1(float f, float f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f2x2_f1(float2 f, float2 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f3x2_f1(float3 f, float3 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f4x2_f1(float4 f, float4 f1);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1x3_f1(float f, float f1, float f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f2x3_f1(float2 f, float2 f1, float2 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f3x3_f1(float3 f, float3 f1, float3 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f4x3_f1(float4 f, float4 f1, float4 f2);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1x4_f1(float f, float f1, float f2, float f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f2x4_f1(float2 f, float2 f1, float2 f2, float2 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f3x4_f1(float3 f, float3 f1, float3 f2, float3 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f4x4_f1(float4 f, float4 f1, float4 f2, float4 f3);
            
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u1_f1(uint f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u2_f1(uint2 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u3_f1(uint3 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u4_f1(uint4 f);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u1x2_f1(uint f,  uint f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u2x2_f1(uint2 f, uint2 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u3x2_f1(uint3 f, uint3 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u4x2_f1(uint4 f, uint4 f1);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u1x3_f1(uint f,  uint f1,  uint f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u2x3_f1(uint2 f, uint2 f1, uint2 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u3x3_f1(uint3 f, uint3 f1, uint3 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u4x3_f1(uint4 f, uint4 f1, uint4 f2);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u1x4_f1(uint f,  uint f1,  uint f2,  uint f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u2x4_f1(uint2 f, uint2 f1, uint2 f2, uint2 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u3x4_f1(uint3 f, uint3 f1, uint3 f2, uint3 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float u4x4_f1(uint4 f, uint4 f1, uint4 f2, uint4 f3);
            
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i1_f1(int f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i2_f1(int2 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i3_f1(int3 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i4_f1(int4 f);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i1x2_f1(int f,  int f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i2x2_f1(int2 f, int2 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i3x2_f1(int3 f, int3 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i4x2_f1(int4 f, int4 f1);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i1x3_f1(int f,  int f1,  int f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i2x3_f1(int2 f, int2 f1, int2 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i3x3_f1(int3 f, int3 f1, int3 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i4x3_f1(int4 f, int4 f1, int4 f2);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i1x4_f1(int f,  int f1,  int f2,  int f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i2x4_f1(int2 f, int2 f1, int2 f2, int2 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i3x4_f1(int3 f, int3 f1, int3 f2, int3 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i4x4_f1(int4 f, int4 f1, int4 f2, int4 f3);
            
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int i1_i1(int f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int2 i2_i2(int2 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int3 i3_i3(int3 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int4 i4_i4(int4 f);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int i1x2_i1(int f,  int f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int2 i2x2_i2(int2 f, int2 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int3 i3x2_i3(int3 f, int3 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int4 i4x2_i4(int4 f, int4 f1);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int i1x3_i1(int f,  int f1,  int f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int2 i2x3_i2(int2 f, int2 f1, int2 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int3 i3x3_i3(int3 f, int3 f1, int3 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int4 i4x3_i4(int4 f, int4 f1, int4 f2);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int i1x4_i1(int f,  int f1,  int f2,  int f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int2 i2x4_i2(int2 f, int2 f1, int2 f2, int2 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int3 i3x4_i3(int3 f, int3 f1, int3 f2, int3 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate int4 i4x4_i4(int4 f, int4 f1, int4 f2, int4 f3);
            
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double d1_d1(double f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double2 d2_d2(double2 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double3 d3_d3(double3 f);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double4 d4_d4(double4 f);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double d1x2_d1(double f,  double f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double2 d2x2_d2(double2 f, double2 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double3 d3x2_d3(double3 f, double3 f1);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double4 d4x2_d4(double4 f, double4 f1);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double d1x3_d1(double f,  double f1,  double f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double2 d2x3_d2(double2 f, double2 f1, double2 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double3 d3x3_d3(double3 f, double3 f1, double3 f2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double4 d4x3_d4(double4 f, double4 f1, double4 f2);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double d1x4_d1(double f,  double f1,  double f2,  double f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double2 d2x4_d2(double2 f, double2 f1, double2 f2, double2 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double3 d3x4_d3(double3 f, double3 f1, double3 f2, double3 f3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate double4 d4x4_d4(double4 f, double4 f1, double4 f2, double4 f3);
            
            







            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float i1x2_f1(int f1, int f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 i2x2_f2(int2 f1, int2 f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 i3x2_f3(int3 f1, int3 f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 i4x2_f4(int4 f1, int4 f2);
            //
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float f1x2_f1(float f1, float f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 f2x2_f2(float2 f1, float2 f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 f3x2_f3(float3 f1, float3 f2);
            // [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 f4x2_f4(float4 f1, float4 f2);
            
            
            











        }
    }
}