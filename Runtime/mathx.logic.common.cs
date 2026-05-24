// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using System;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		[MI(IL)] public static bool ispow2(this short x) => x != 0 && (x & x - 1) == 0;

		[MI(IL)] public static bool ispow2(this ushort x) => x != 0 && (x & x - 1) == 0;

		[MI(IL)] public static bool ispow2(this int x) => x != 0 && (x & x - 1) == 0;

		[MI(IL)] public static bool ispow2(this uint x) => x != 0 && (x & x - 1) == 0;

		[MI(IL)] public static bool ispow2(this float x)
		{
			if (x <= 0) return false;

			int bits = BitConverter.SingleToInt32Bits(x);
			int exponent = bits >> 23 & 0xFF;
			int mantissa = bits & 0x007FFFFF;
			return mantissa == 0 && exponent != 0 && exponent != 0xFF;
		}
	}
}