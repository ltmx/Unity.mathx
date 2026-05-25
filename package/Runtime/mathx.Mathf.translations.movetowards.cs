// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

namespace Unity.Mathematics
{
	public partial class mathx
	{
		/// Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta
		[MI(IL)] public static float4 movetowards(this float4 current, float4 target, float4 maxDistanceDelta)
		{
			float4 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}

		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float4)"/>
		[MI(IL)] public static float4 movetowards(this float4 current, float4 target, float maxDistanceDelta)
		{
			float4 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}
		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
		[MI(IL)] public static float3 movetowards(this float3 current, float3 target, float3 maxDistanceDelta)
		{
			float3 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}
		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
		[MI(IL)] public static float3 movetowards(this float3 current, float3 target, float maxDistanceDelta)
		{
			float3 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}
		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
		[MI(IL)] public static float2 movetowards(this float2 current, float2 target, float2 maxDistanceDelta)
		{
			float2 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}
		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
		[MI(IL)] public static float2 movetowards(this float2 current, float2 target, float maxDistanceDelta)
		{
			float2 delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}
		/// <inheritdoc cref="movetowards(Mathematics.float4,Mathematics.float4,float)"/>
		[MI(IL)] public static float movetowards(this float current, float target, float maxDistanceDelta)
		{
			float delta = target - current;
			return math.mad(min(abs(delta), maxDistanceDelta), sign(delta), current);
		}

		// For Reference
		// float3 MoveTowards(float3 current, float3 target, float maxDistanceDelta)
		// {
		//     float3 delta = target - current;
		//     float invDeltaLength = math.rsqrt(math.lengthsq(delta)); // Reciprocal square root
		//     return current + (delta * invDeltaLength) * maxDistanceDelta;
		// }
	}
}