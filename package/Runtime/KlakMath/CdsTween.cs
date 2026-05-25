// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using UnityEngine;

#endregion

namespace Unity.Mathematics
{
	public static class CdsTween
	{
		#region float support

		public static (float x, float v) Step((float x, float v) state, float target, float speed) => Step(state, target, speed, Time.deltaTime);

		public static (float x, float v) Step((float x, float v) state, float target, float speed, float dt)
		{
			float n1 = state.v - (state.x - target) * (speed * speed * dt);
			float n2 = 1 + speed * dt;
			float nv = n1 / (n2 * n2);
			return (state.x + nv * dt, nv);
		}

		#endregion

		#region f2 support

		public static (float2 x, float2 v) Step((float2 x, float2 v) state, float2 target, float speed) => Step(state, target, speed, Time.deltaTime);

		public static (float2 x, float2 v) Step((float2 x, float2 v) state, float2 target, float speed, float dt)
		{
			float2 n1 = state.v - (state.x - target) * (speed * speed * dt);
			float n2 = 1 + speed * dt;
			float2 nv = n1 / (n2 * n2);
			return (state.x + nv * dt, nv);
		}

		#endregion

		#region f3 support

		public static (float3 x, float3 v) Step((float3 x, float3 v) state, float3 target, float speed) => Step(state, target, speed, Time.deltaTime);

		public static (float3 x, float3 v) Step((float3 x, float3 v) state, float3 target, float speed, float dt)
		{
			float3 n1 = state.v - (state.x - target) * (speed * speed * dt);
			float n2 = 1 + speed * dt;
			float3 nv = n1 / (n2 * n2);
			return (state.x + nv * dt, nv);
		}

		#endregion

		#region f4 support

		public static (float4 x, float4 v) Step((float4 x, float4 v) state, float4 target, float speed) => Step(state, target, speed, Time.deltaTime);

		public static (float4 x, float4 v) Step((float4 x, float4 v) state, float4 target, float speed, float dt)
		{
			float4 n1 = state.v - (state.x - target) * (speed * speed * dt);
			float n2 = 1 + speed * dt;
			float4 nv = n1 / (n2 * n2);
			return (state.x + nv * dt, nv);
		}

		#endregion

		#region quaternion support

		public static (quaternion x, float4 v) Step((quaternion x, float4 v) state, quaternion target, float speed) => Step(state, target, speed, Time.deltaTime);

		public static (quaternion x, float4 v) Step((quaternion x, float4 v) state, quaternion target, float speed, float dt)
		{
			// Closer pose from target or -target
			if (math.dot(state.x, target) < 0) target.value *= -1;
			(float4 x, float4 v) n = Step((state.x.value, state.v), target.value, speed, dt);
			return (math.normalize(math.quaternion(n.x)), n.v);
		}

		#endregion
	}
} // namespace Klak.Math