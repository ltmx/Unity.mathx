#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.Collections.Generic;
using UnityEngine;

namespace Unity.Mathematics
{
    public partial class mathx
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