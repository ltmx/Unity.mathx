// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

using System;
using AOT;
using Unity.Burst;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		// Component-wise comparison --------------------------------------------------------------

		/// <inheritdoc cref="math.cmax(float4)"/>  
		[MI(IL)] public static float cmax(this float4 f) => math.cmax(f);

		/// <inheritdoc cref="math.cmax(float4)"/>
		[MI(IL)] public static float cmax(this float3 f) => math.cmax(f);

		/// <inheritdoc cref="math.cmax(float4)"/>
		[MI(IL)] public static float cmax(this float2 f) => math.cmax(f);

		/// <inheritdoc cref="math.cmin(float4)"/>
		[MI(IL)] public static float cmin(this float4 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(float4)"/>
		[MI(IL)] public static float cmin(this float3 f) => math.cmin(f);
		/// <inheritdoc cref="math.cmin(float4)"/>
		[MI(IL)] public static float cmin(this float2 f) => math.cmin(f);

		/// returns the greatest absolute value of the components
		[MI(IL)] public static float acmax(this float4 f) => f.abs().cmax();
		/// <inheritdoc cref="acmax(float4)"/>
		[MI(IL)] public static float acmax(this float3 f) => f.abs().cmax();
		/// <inheritdoc cref="acmax(float4)"/>
		[MI(IL)] public static float acmax(this float2 f) => f.abs().cmax();

		/// returns the smallest absolute value of the components
		[MI(IL)] public static float acmin(this float4 f) => f.abs().cmin();
		/// <inheritdoc cref="acmin(float4)"/>
		[MI(IL)] public static float acmin(this float3 f) => f.abs().cmin();
		/// <inheritdoc cref="acmin(float4)"/>
		[MI(IL)] public static float acmin(this float2 f) => f.abs().cmin();

		[MI(IL)]
		public static int fmax(int x, int y) => x ^ ((x ^ y) & -(x < y ? 1 : 0));

		[BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))]
		[MI(IL)] public static float fmax(this float x, float y) => x >= y ? x : y;

		[MI(IL)] public static float2 fmax(this float2 x, float y) => p_fmax.RunPerAxis(x, y);
		[MI(IL)] public static float3 fmax(this float3 x, float y) => p_fmax.RunPerAxis(x, y);
		[MI(IL)] public static float4 fmax(this float4 x, float y) => p_fmax.RunPerAxis(x, y);

		[MI(IL)] public static float2 fmax(this float2 x, float2 y) => p_fmax.RunPerAxis(x, y);
		[MI(IL)] public static float3 fmax(this float3 x, float3 y) => p_fmax.RunPerAxis(x, y);
		[MI(IL)] public static float4 fmax(this float4 x, float4 y) => p_fmax.RunPerAxis(x, y);

		[MI(IL)] public static float fcmax(this float2 x) => fmax(x.x, x.y);
		[MI(IL)] public static float fcmax(this float3 x) => p_fmax.RunNested(x);
		[MI(IL)] public static float fcmax(this float4 x) => p_fmax.RunNested(x);

		[BurstCompile, MonoPInvokeCallback(typeof(f1x2_f1))]
		[MI(IL)] public static float fmin(this float x, float y) => x <= y ? x : y;

		[MI(IL)] public static float2 fmin(this float2 x, float y) => p_fmin.RunPerAxis(x, y);
		[MI(IL)] public static float3 fmin(this float3 x, float y) => p_fmin.RunPerAxis(x, y);
		[MI(IL)] public static float4 fmin(this float4 x, float y) => p_fmin.RunPerAxis(x, y);

		[MI(IL)] public static float2 fmin(this float2 x, float2 y) => p_fmin.RunPerAxis(x, y);
		[MI(IL)] public static float3 fmin(this float3 x, float3 y) => p_fmin.RunPerAxis(x, y);
		[MI(IL)] public static float4 fmin(this float4 x, float4 y) => p_fmin.RunPerAxis(x, y);

		[MI(IL)] public static float fcmin(this float2 x) => x.x.fmin(x.y);
		[MI(IL)] public static float fcmin(this float3 x) => x.x.fmin(x.y).fmin(x.z);
		[MI(IL)] public static float fcmin(this float4 x) => fmin(x.x.fmin(x.y), x.z.fmin(x.w));
	}
}
