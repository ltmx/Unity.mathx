#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System.Runtime.InteropServices;

namespace Unity.Mathematics
{
    public static partial class FunctionPointers
    {
        public static class MethodSignatures
        {
            // Method Signatures
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float p1(float t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float p2(float t1, float t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float p3(float t1, float t2, float t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float p4(float t1, float t2, float t3, float t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 p1x2(float2 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 p2x2(float2 t1, float2 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 p3x2(float2 t1, float2 t2, float2 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float2 p4x2(float2 t1, float2 t2, float2 t3, float2 t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 p1x3(float3 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 p2x3(float3 t1, float3 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 p3x3(float3 t1, float3 t2, float3 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float3 p4x3(float3 t1, float3 t2, float3 t3, float3 t4);
            
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 p1x4(float4 t);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 p2x4(float4 t1, float4 t2);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 p3x4(float4 t1, float4 t2, float4 t3);
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate float4 p4x4(float4 t1, float4 t2, float4 t3, float4 t4);
        }
    }
}