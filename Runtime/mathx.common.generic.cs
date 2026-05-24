// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		/// sets the value of x to f and returns f
		[MI(IL)] public static T set<T>(this T f, out T x)
		{
			x = f;
			return f;
		}
	}
}