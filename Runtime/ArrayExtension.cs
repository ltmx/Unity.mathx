using UnityEngine;

namespace Unity.Mathematics
{
    public partial class Math
    {
        /// <summary> Returns a list containing individual components of this vector </summary>
        public static float[] Array(this float4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        public static float[] Array(this float3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        public static float[] Array(this float2 f) => new[]{f.x, f.y};
        
        /// <inheritdoc cref="List(float4)"/>
        public static float[] Array(this Vector4 f) => new[]{f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        public static float[] Array(this Vector3 f) => new[]{f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        public static float[] Array(this Vector2 f) => new[]{f.x, f.y};
    }
}
