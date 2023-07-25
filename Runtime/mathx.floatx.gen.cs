#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        #region Type Building

        ///<inheritdoc cref="math.float4(float)"/>
        public static float4 f4(this float f) => math.float4(f);
        /// Returns a f4 with the first two components set to f, and the last two set to 0
        public static float4 f4(this float2 f) => math.float4(f, 0, 0);
        /// Returns a f4 with the first three components set to f, and the last one set to 0
        public static float4 f4(this float3 f) => math.float4(f, 0);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 f4(float a, float b, float c, float d) => math.float4(a, b, c, d);
        /// <inheritdoc cref="math.float4(Mathematics.float2, Mathematics.float2)"/>
        public static float4 f4(float2 a, float2 b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(Mathematics.float3, float)"/>
        public static float4 f4(float3 a, float b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(float, Mathematics.float3)"/>
        public static float4 f4(float a, float3 b) => math.float4(a, b);
        /// <inheritdoc cref="math.float4(float, float, Mathematics.float2)"/>
        public static float4 f4(float a, float2 b, float c) => math.float4(a, b, c);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 f4(float a, float b, float2 c) => math.float4(a, b, c);
        /// <inheritdoc cref="math.float4(float, float, float, float)"/>
        public static float4 f4(float2 a, float b, float c) => math.float4(a, b, c);
        /// <inheritdoc cref="math.float3(float, float, float)"/>
        public static float3 f3(float a, float b, float c) => math.float3(a, b, c);
        /// <inheritdoc cref="math.float3(Mathematics.float2, float)"/>
        public static float3 f3(float2 a, float b) => math.float3(a, b);
        /// <inheritdoc cref="math.float3(float, Mathematics.float2)"/>
        public static float3 f3(float a, float2 b) => math.float3(a, b);
        /// <inheritdoc cref="math.float3(float)"/>
        public static float3 f3(this float f) => math.float3(f);
        /// <inheritdoc cref="math.float3(Mathematics.float2, float)"/>
        public static float3 f3(this float2 f) => math.float3(f, 0);
        /// Returns a f3 with containing the first three components of a f4
        public static float3 f3(this float4 f) => math.float3(f.xyz); // crop w
        /// <inheritdoc cref="math.float2(float, float)"/>
        public static float2 f2(float a, float b) => math.float2(a, b);
        /// <inheritdoc cref="math.float2(float)"/>
        public static float2 f2(this float f) => math.float2(f);
        /// Returns a f2 with containing the first two components of a f3
        public static float2 f2(this float3 f) => math.float2(f.xy); // crop z
        /// Returns a f2 with containing the first two components of a f4
        public static float2 f2(this float4 f) => math.float2(f.xy); // crop zw
        /// Returns the xyzw components of the quaternion as a f4
        [MethodImpl(IL)] public static float4 f4(this quaternion q) => new(q.value);

        #endregion
        
        
        #region Appending

        /// appends a float to a float to create a f2
        [MethodImpl(IL)] public static float2 append(this float x, float y) => new(x, y);
        /// appends a float to a f2 to create a f3
        [MethodImpl(IL)] public static float3 append(this float2 xy, float z) => new(xy, z);
        /// appends a f2 to a float to create a f3
        [MethodImpl(IL)] public static float3 append(this float x, float2 yz) => new(x, yz);
        /// appends a float to a f3 to create a f4
        [MethodImpl(IL)] public static float4 append(this float3 xyz, float w) => new(xyz, w);
        /// appends a f2 to a f2 to create a f4
        [MethodImpl(IL)] public static float4 append(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a f3 to a float to create a f4
        [MethodImpl(IL)] public static float4 append(this float x, float3 yzw) => new(x, yzw);
        
        
        /// appends a float to a float2x2 to create a float2x3
        [MethodImpl(IL)] public static float2x3 append(this float2x2 m, float2 c) => new(m.c0, m.c1, c);
        /// appends a f2 to a float2x3 to create a float2x4
        [MethodImpl(IL)] public static float2x4 append(this float2x3 m, float2 c) => new(m.c0, m.c1, m.c2, c);
        /// appends a f3 to a float3x2 to create a float3x3
        [MethodImpl(IL)] public static float3x3 append(this float3x2 m, float3 c) => new(m.c0, m.c1, c);
        /// appends a f3 to a float3x3 to create a float3x4
        [MethodImpl(IL)] public static float3x4 append(this float3x3 m, float3 c) => new(m.c0, m.c1, m.c2, c);
        /// appends a f4 to a float4x2 to create a float4x3
        [MethodImpl(IL)] public static float4x3 append(this float4x2 m, float4 c) => new(m.c0, m.c1, c);
        /// appends a f4 to a float4x3 to create a float4x4
        [MethodImpl(IL)] public static float4x4 append(this float4x3 m, float4 c) => new(m.c0, m.c1, m.c2, c);
        
        
        /// appends a float to a float to create a f2
        [MethodImpl(IL)] public static float2 y(this float x, float y) => new(x, y);
        /// appends a float to a f2 to create a f3
        [MethodImpl(IL)] public static float3 z(this float2 xy, float z) => new(xy, z);
        /// appends a f2 to a float to create a f3
        [MethodImpl(IL)] public static float3 yz(this float x, float2 yz) => new(x, yz);
        /// appends a float to a f3 to create a f4
        [MethodImpl(IL)] public static float4 w(this float3 xyz, float w) => new(xyz, w);
        /// appends a f2 to a f2 to create a f4
        [MethodImpl(IL)] public static float4 zw(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a f3 to a float to create a f4
        [MethodImpl(IL)] public static float4 yzw(this float x, float3 yzw) => new(x, yzw);
        
        // quaternion components
        /// Returns the xyzw components of the quaternion as a f4
        [MethodImpl(IL)] public static float4 xyzw(this quaternion q) => new(q.value);
        /// Returns the xyz components of the quaternion as a f3
        [MethodImpl(IL)] public static float3 xyz(this quaternion q) => new(q.value.xyz);
        /// Returns the xy components of the quaternion as a f2
        [MethodImpl(IL)] public static float2 xy(this quaternion q) => new(q.value.xy);
        /// Returns the x component of the quaternion as a float
        [MethodImpl(IL)] public static float x(this quaternion q) => q.value.x;
        /// Returns the y component of the quaternion as a float
        [MethodImpl(IL)] public static float y(this quaternion q) => q.value.y;
        /// Returns the z component of the quaternion as a float
        [MethodImpl(IL)] public static float z(this quaternion q) => q.value.z;
        /// Returns the w component of the quaternion as a float
        [MethodImpl(IL)] public static float w(this quaternion q) => q.value.w;

        #endregion
        
    }
}