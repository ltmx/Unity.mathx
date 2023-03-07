#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using Unity.Collections;
using UnityEngine;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        /// <summary> Returns a list containing individual components of this vector </summary>
        public static float[] Array(this float4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        public static float[] Array(this float3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(float4)"/>
        public static float[] Array(this float2 f) => new[]{f.x, f.y};
        
        /// <inheritdoc cref="Array(float4)"/>
        public static float[] Array(this Vector4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="Array(float4)"/>
        public static float[] Array(this Vector3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="Array(float4)"/>
        public static float[] Array(this Vector2 f) => new[]{f.x, f.y};

        /// <summary> Returns a NativeArray containing individual components of this vector </summary>
        public static void CopyFrom(this NativeArray<float> na, float4 f) => na.CopyFrom(new[] { f.x, f.y, f.z, f.w });
        /// <inheritdoc cref="CopyFrom(NativeArray{float}, float4)"/>
        public static void CopyFrom(this NativeArray<float> na, float3 f) => na.CopyFrom(new[] { f.x, f.y, f.z });
        /// <inheritdoc cref="CopyFrom(NativeArray{float}, float4)"/>
        public static void CopyFrom(this NativeArray<float> na, float2 f) => na.CopyFrom(new[] { f.x, f.y });
        
    }
}
