// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

using System;
using System.Runtime.InteropServices;
using static Unity.Burst.BurstCompiler;
using UFP = System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute;

namespace Unity.Mathematics
{
	public static partial class FunctionPointers
	{
		public static T compile<T>(T m) where T : class => CompileFunctionPointer(m).Invoke;

		public static f1_f1 compile(f1_f1 m) => CompileFunctionPointer(m).Invoke;
		public static f1_i1 compile(f1_i1 m) => CompileFunctionPointer(m).Invoke;
		public static f1x2_f1 compile(f1x2_f1 m) => CompileFunctionPointer(m).Invoke;
		public static f1x3_f1 compile(f1x3_f1 m) => CompileFunctionPointer(m).Invoke;
		public static f1x4_f1 compile(f1x4_f1 m) => CompileFunctionPointer(m).Invoke;

		public class Signature
		{
			const CallingConvention C = CallingConvention.Cdecl;

			[UFP(C)] public delegate float f1_f1(float f);
			[UFP(C)] public delegate float f1x2_f1(float f, float f1);
			[UFP(C)] public delegate float f1x3_f1(float f, float f1, float f2);
			[UFP(C)] public delegate float f1x4_f1(float f, float f1, float f2, float f3);

			[UFP(C)] public delegate float u1_f1(uint f);
			[UFP(C)] public delegate float u1x2_f1(uint f, uint f1);
			[UFP(C)] public delegate float u1x3_f1(uint f, uint f1, uint f2);
			[UFP(C)] public delegate float u1x4_f1(uint f, uint f1, uint f2, uint f3);

			[UFP(C)] public delegate float i1_f1(int f);
			[UFP(C)] public delegate int f1_i1(float f);
			[UFP(C)] public delegate float i1x2_f1(int f, int f1);
			[UFP(C)] public delegate float i1x3_f1(int f, int f1, int f2);
			[UFP(C)] public delegate float i1x4_f1(int f, int f1, int f2, int f3);

			[UFP(C)] public delegate int i1_i1(int f);
			[UFP(C)] public delegate int i1x2_i1(int f, int f1);
			[UFP(C)] public delegate int i1x3_i1(int f, int f1, int f2);
			[UFP(C)] public delegate int i1x4_i1(int f, int f1, int f2, int f3);

			[UFP(C)] public delegate double d1_d1(double f);
			[UFP(C)] public delegate double d1x2_d1(double f, double f1);
			[UFP(C)] public delegate double d1x3_d1(double f, double f1, double f2);
			[UFP(C)] public delegate double d1x4_d1(double f, double f1, double f2, double f3);
		}
	}
}
