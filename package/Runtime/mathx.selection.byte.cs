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
		[MI(IL)] public static byte cmax(this byte4 f) => f.x.max(f.y).max(f.z).max(f.w);
		/// <inheritdoc cref="math.cmax(int3)"/>
		[MI(IL)] public static byte cmax(this byte3 f) => f.x.max(f.y).max(f.z);
		/// <inheritdoc cref="math.cmax(int2)"/>
		[MI(IL)] public static byte cmax(this byte2 f) => f.x.max(f.y);

		/// <inheritdoc cref="math.cmin(int4)"/>
		[MI(IL)] public static byte cmin(this byte4 f) => f.x.min(f.y).min(f.z).min(f.w);
		/// <inheritdoc cref="math.cmin(int3)"/>
		[MI(IL)] public static byte cmin(this byte3 f) => f.x.min(f.y).min(f.z);
		/// <inheritdoc cref="math.cmin(int2)"/>
		[MI(IL)] public static byte cmin(this byte2 f) => min(f.x, f.y);
	}
}