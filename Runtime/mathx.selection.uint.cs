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

		/// <inheritdoc cref="math.cmax(uint4)"/>  
		[MI(IL)] public static uint cmax(this uint4 f) => math.cmax(f);
		/// <inheritdoc cref="math.cmax(uint4)"/>
		[MI(IL)] public static uint cmax(this uint3 f) => math.cmax(f);
		/// <inheritdoc cref="math.cmax(uint4)"/>
		[MI(IL)] public static uint cmax(this uint2 f) => math.cmax(f);

		/// <inheritdoc cref="math.cmin(uint4)"/>
		[MI(IL)] public static uint cmin(this uint4 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(uint4)"/>
		[MI(IL)] public static uint cmin(this uint3 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(uint4)"/>
		[MI(IL)] public static uint cmin(this uint2 f) => math.cmin(f);
	}
}