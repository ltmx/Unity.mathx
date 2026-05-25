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
		// Component-wise comparison --------------------------------------------------------------

		/// <inheritdoc cref="math.cmax(int4)"/>  
		[MI(IL)] public static int cmax(this int4 f) => math.cmax(f);
		/// <inheritdoc cref="math.cmax(int4)"/>
		[MI(IL)] public static int cmax(this int3 f) => math.cmax(f);
		/// <inheritdoc cref="math.cmax(int4)"/>
		[MI(IL)] public static int cmax(this int2 f) => math.cmax(f);

		/// <inheritdoc cref="math.cmin(int4)"/>
		[MI(IL)] public static int cmin(this int4 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(int4)"/>
		[MI(IL)] public static int cmin(this int3 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(int4)"/>
		[MI(IL)] public static int cmin(this int2 f) => math.cmin(f);

		/// returns the greatest absolute value of the components
		[MI(IL)] public static int acmax(this int4 f) => f.abs().cmax();
		/// <inheritdoc cref="acmax(int4)"/>
		[MI(IL)] public static int acmax(this int3 f) => f.abs().cmax();
		/// <inheritdoc cref="acmax(int4)"/>
		[MI(IL)] public static int acmax(this int2 f) => f.abs().cmax();

		/// returns the smallest absolute value of the components
		[MI(IL)] public static int acmin(this int4 f) => f.abs().cmin();
		/// <inheritdoc cref="acmin(int4)"/>
		[MI(IL)] public static int acmin(this int3 f) => f.abs().cmin();
		/// <inheritdoc cref="acmin(int4)"/>
		[MI(IL)] public static int acmin(this int2 f) => f.abs().cmin();
	}
}