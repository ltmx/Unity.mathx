using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

namespace UME
{
    public partial class Math
    {
        /// <summary> Returns a list containing individual components of this vector </summary>
        public static List<float> List(this float4 f) => new() {f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        public static List<float> List(this float3 f) => new() {f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        public static List<float> List(this float2 f) => new() {f.x, f.y};
        
        /// <inheritdoc cref="List(float4)"/>
        public static List<float> List(this Vector4 f) => new() {f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        public static List<float> List(this Vector3 f) => new() {f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        public static List<float> List(this Vector2 f) => new() {f.x, f.y};
    }
}
