// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

namespace Unity.Mathematics
{
	public static class Rotation
	{
		public static quaternion FromTo(float3 v1, float3 v2)
		{
			float3 a = math.cross(v1, v2);
			float v1v2 = math.dot(v1, v1) * math.dot(v2, v2);
			float w = math.sqrt(v1v2) + math.dot(v1, v2);
			return math.normalizesafe(math.quaternion(math.float4(a, w)));
		}
	}
} // namespace Klak.Math