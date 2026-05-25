// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using AOT;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

using Unity.Burst;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.FunctionPointers.Signature;

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		[BurstCompile, MonoPInvokeCallback(typeof(f1x3_f1))]
		[MI(IL)] public static float clampfp(float value, float min, float max) => math.clamp(value, min, max);

		[BurstCompile, MonoPInvokeCallback(typeof(f1_f1))]
		[MI(IL)] public static float saturatefp(float value) => math.saturate(value);

		[BurstCompile, MonoPInvokeCallback(typeof(f1_f1))]
		[MI(IL)] public static float absfp(float value) => math.abs(value);

		[BurstCompile, MonoPInvokeCallback(typeof(f1x3_f1))]
		[MI(IL)] public static float lerptfp(float min, float max, float t) => math.lerp(min, max, t);

		[BurstCompile, MonoPInvokeCallback(typeof(f1x3_f1))]
		[MI(IL)] public static float smax_expfp(float a, float b, float t)
		{
			var o = (new float2(a - b, b - a) / t).exp();
			return new float2(a, b).dot(o) / o.csum();
		}

		[BurstCompile, MonoPInvokeCallback(typeof(f1x3_f1))]
		[MI(IL)] public static float smin_expfp(float a, float b, float t)
		{
			var res = (-t * a).exp2() + (-t * b).exp2();
			return -res.log2() / t;
		}

		[MI(IL)] public static float2 clampfp(this float2 f, float min, float max) => pClamp.RunPerAxis(f, min, max);
		[MI(IL)] public static float3 clampfp(this float3 f, float min, float max) => pClamp.RunPerAxis(f, min, max);
		[MI(IL)] public static float4 clampfp(this float4 f, float min, float max) => pClamp.RunPerAxis(f, min, max);
		[MI(IL)] public static float2 clampfp(this float2 f, float2 min, float2 max) => pClamp.RunPerAxis(f, min, max);
		[MI(IL)] public static float3 clampfp(this float3 f, float3 min, float3 max) => pClamp.RunPerAxis(f, min, max);
		[MI(IL)] public static float4 clampfp(this float4 f, float4 min, float4 max) => pClamp.RunPerAxis(f, min, max);

		[MI(IL)] public static float2 saturatefp(this float2 f) => pSaturate.RunPerAxis(f);
		[MI(IL)] public static float3 saturatefp(this float3 f) => pSaturate.RunPerAxis(f);
		[MI(IL)] public static float4 saturatefp(this float4 f) => pSaturate.RunPerAxis(f);

		[MI(IL)] public static float2 absfp(this float2 f) => pAbs.RunPerAxis(f);
		[MI(IL)] public static float3 absfp(this float3 f) => pAbs.RunPerAxis(f);
		[MI(IL)] public static float4 absfp(this float4 f) => pAbs.RunPerAxis(f);

		[MI(IL)] public static float2 lerptfp(this float2 t, float2 min, float2 max) => pLerp.RunPerAxis(min, max, t);
		[MI(IL)] public static float3 lerptfp(this float3 t, float3 min, float3 max) => pLerp.RunPerAxis(min, max, t);
		[MI(IL)] public static float4 lerptfp(this float4 t, float4 min, float4 max) => pLerp.RunPerAxis(min, max, t);

		[MI(IL)] public static float2 smax_expfp(this float2 t, float2 a, float2 b) => pSmaxExp.RunPerAxisWithParam(a, b, t);
		[MI(IL)] public static float3 smax_expfp(this float3 t, float3 a, float3 b) => pSmaxExp.RunPerAxisWithParam(a, b, t);
		[MI(IL)] public static float4 smax_expfp(this float4 t, float4 a, float4 b) => pSmaxExp.RunPerAxisWithParam(a, b, t);

		[MI(IL)] public static float2 smin_expfp(this float2 t, float2 a, float2 b) => pSminExp.RunPerAxisWithParam(a, b, t);
		[MI(IL)] public static float3 smin_expfp(this float3 t, float3 a, float3 b) => pSminExp.RunPerAxisWithParam(a, b, t);
		[MI(IL)] public static float4 smin_expfp(this float4 t, float4 a, float4 b) => pSminExp.RunPerAxisWithParam(a, b, t);
	}
}
