#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        #region Direction Shorthands
        
        /// Shorthand for new float2(0,1)
        public static readonly float2 f2up = new(0, 1);
        /// Shorthand for new float2(0,-1)
        public static readonly float2 f2down = new(0, -1);
        /// Shorthand for new float2(1,0)
        public static readonly float2 f2right = new(1, 0);
        /// Shorthand for new float2(-1,0)
        public static readonly float2 f2left = new(-1, 0);

        /// Shorthand for new float3(0,1,0)
        public static readonly float3 f3up = new(0, 1, 0);
        /// Shorthand for new float3(1,0,0);
        public static readonly float3 f3right = new(1, 0, 0);
        /// Shorthand for new float3(0,0,1)
        public static readonly float3 f3forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 f3down = new(0, -1, 0);
        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 f3left = new(-1, 0, 0);
        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 f3back = new(0, 0, -1);

        // float3 with implicit naming
        /// Shorthand for new float3(0,1,0)
        public static readonly float3 up3 = new(0, 1, 0);
        /// Shorthand for new float3(1,0,0);
        public static readonly float3 right3 = new(1, 0, 0);
        /// Shorthand for new float3(0,0,1)
        public static readonly float3 forward3 = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 down3 = new(0, -1, 0);
        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 left3 = new(-1, 0, 0);
        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 back3 = new(0, 0, -1);
        
        /// Shorthand for new int3(0,1,0)
        public static readonly int3 i3up = new(0, 1, 0);
        /// Shorthand for new int3(1,0,0);
        public static readonly int3 i3right = new(1, 0, 0);
        /// Shorthand for new int3(0,0,1)
        public static readonly int3 i3forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly int3 i3down = new(0, -1, 0);
        /// Shorthand for new int3(-1,0,0)
        public static readonly int3 i3left = new(-1, 0, 0);
        /// Shorthand for new int3(0,0,-1)
        public static readonly int3 i3back = new(0, 0, -1);

        /// Shorthand for new double2(0,1)
        public static readonly double2 d2up = new(0, 1);
        /// Shorthand for new double2(0,-1)
        public static readonly double2 d2down = new(0, -1);
        /// Shorthand for new double2(1,0)
        public static readonly double2 d2right = new(1, 0);
        /// Shorthand for new double2(-1,0)
        public static readonly double2 leftd2 = new(-1, 0);
        
        /// Shorthand for new double3(0,1,0)
        public static readonly double3 d3up = new(0, 1, 0);
        /// Shorthand for new double3(1,0,0);
        public static readonly double3 d3right = new(1, 0, 0);
        /// Shorthand for new double3(0,0,1)
        public static readonly double3 d3forward = new(0, 0, 1);
        /// Shorthand for new new double3(0,-1,0)
        public static readonly double3 d3down = new(0, -1, 0);
        /// Shorthand for new double3(-1,0,0)
        public static readonly double3 d3left = new(-1, 0, 0);
        /// Shorthand for new double3(0,0,-1)
        public static readonly double3 d3back = new(0, 0, -1);
    
        // One and Zero -----------------------------------------------------
        
        /// Shorthand for new float2(1,1)
        public static readonly float2 f2one = 1;
        /// Shorthand for new float2(0,0)
        public static readonly float2 f2zero = 0;
        /// Shorthand for new float3(1,1,1)
        public static readonly float3 f3one = 1;
        /// Shorthand for new float3(0,0,0)
        public static readonly float3 f3zero = 0;
        /// Shorthand for new float4(1,1,1,1)
        public static readonly float4 f4one = 1;
        /// Shorthand for new float4(0,0,0,0)
        public static readonly float4 f4zero = 0;
        /// Shorthand for new int3(1,1,1)
        public static readonly int3 i3one = 1;
        /// Shorthand for new int3(0,0,0)
        public static readonly int3 i3zero = 0;
        /// Shorthand for new double2(1,1)
        public static readonly double2 d2one = 1;
        /// Shorthand for new double2(0,0)
        public static readonly double2 d2zero = 0;
        /// Shorthand for new double3(1,1,1)
        public static readonly double3 d3one = 1;
        /// Shorthand for new double3(0,0,0)
        public static readonly double3 d3zero = 0;
        /// Shorthand for new double4(1,1,1,1)
        public static readonly double4 d4one = 1;
        /// Shorthand for new float4(0,0,0,0)
        public static readonly double4 d4zero = 0;

        #endregion
        
        #region .xxxx Shader Syntax

        /// Shorthand for new float2(f)
        [MethodImpl(IL)] public static float2 xx(this float f) => new(f);
        /// Shorthand for new float3(f)
        [MethodImpl(IL)] public static float3 xxx(this float f) => new(f);
        /// Shorthand for new float4(f)
        [MethodImpl(IL)] public static float4 xxxx(this float f) => new(f);
        
        /// Shorthand for new double2(f)
        [MethodImpl(IL)] public static double2 xx(this double f) => new(f);
        /// Shorthand for new double3(f)
        [MethodImpl(IL)] public static double3 xxx(this double f) => new(f);
        /// Shorthand for new double4(f)
        [MethodImpl(IL)] public static double4 xxxx(this double f) => new(f);

        /// Shorthand for new int2(i)
        [MethodImpl(IL)] public static int2 xx(this int i) => new(i);
        /// Shorthand for new int3(i)
        [MethodImpl(IL)] public static int3 xxx(this int i) => new(i);
        /// Shorthand for new int4(i)
        [MethodImpl(IL)] public static int4 xxxx(this int i) => new(i);
        
        /// Shorthand for new bool2(i)
        [MethodImpl(IL)] public static bool2 xx(this bool b) => new(b);
        /// Shorthand for new bool3(i)
        [MethodImpl(IL)] public static bool3 xxx(this bool b) => new(b);
        /// Shorthand for new bool4(i)
        [MethodImpl(IL)] public static bool4 xxxx(this bool b) => new(b);

        #endregion
        
        #region Appending

        /// appends a float to a float to create a float2
        [MethodImpl(IL)] public static float2 append(this float x, float y) => new(x, y);
        /// appends a float to a float2 to create a float3
        [MethodImpl(IL)] public static float3 append(this float2 xy, float z) => new(xy, z);
        /// appends a float2 to a float to create a float3
        [MethodImpl(IL)] public static float3 append(this float x, float2 yz) => new(x, yz);
        /// appends a float to a float3 to create a float4
        [MethodImpl(IL)] public static float4 append(this float3 xyz, float w) => new(xyz, w);
        /// appends a float2 to a float2 to create a float4
        [MethodImpl(IL)] public static float4 append(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a float3 to a float to create a float4
        [MethodImpl(IL)] public static float4 append(this float x, float3 yzw) => new(x, yzw);
        
        /// appends a float to a float to create a float2
        [MethodImpl(IL)] public static float2 xy(this float x, float y) => new(x, y);
        /// appends a float to a float2 to create a float3
        [MethodImpl(IL)] public static float3 xyz(this float2 xy, float z) => new(xy, z);
        /// appends a float2 to a float to create a float3
        [MethodImpl(IL)] public static float3 xyz(this float x, float2 yz) => new(x, yz);
        /// appends a float to a float3 to create a float4
        [MethodImpl(IL)] public static float4 xyzw(this float3 xyz, float w) => new(xyz, w);
        /// appends a float2 to a float2 to create a float4
        [MethodImpl(IL)] public static float4 xyzw(this float2 xy, float2 zw) => new(xy, zw);
        /// appends a float3 to a float to create a float4
        [MethodImpl(IL)] public static float4 xyzw(this float x, float3 yzw) => new(x, yzw);
        
        public static float2x3 append(this float2x2 m, float2 c) => new(m.c0, m.c1, c);
        public static float2x4 append(this float2x3 m, float2 c) => new(m.c0, m.c1, m.c2, c);
        public static float3x3 append(this float3x2 m, float3 c) => new(m.c0, m.c1, c);
        public static float3x4 append(this float3x3 m, float3 c) => new(m.c0, m.c1, m.c2, c);
        public static float4x3 append(this float4x2 m, float4 c) => new(m.c0, m.c1, c);
        public static float4x4 append(this float4x3 m, float4 c) => new(m.c0, m.c1, m.c2, c);
        public static float2x2 f2x2(this float2 c1, float2 c2) => new(c1, c2);
        public static float3x2 f3x2(this float3 c1, float3 c2) => new(c1, c2);
        public static float4x2 f4x2(this float4 c1, float4 c2) => new(c1, c2);

        #endregion
        
        #region Matrix Shorthands

        /// Creates a matrix with the same value in every row
        [MethodImpl(IL)] public static float4x4 f4x4(this float4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(this float4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(this float3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float2 f) => new(f, f);

        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool4x4 b4x4(this bool4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool4x3 b4x3(this bool4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool4x2 b4x2(this bool4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool3x4 b3x4(this bool3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool3x3 b3x3(this bool3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool3x2 b3x2(this bool3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool2x4 b2x4(this bool2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool2x3 b2x3(this bool2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static bool2x2 b2x2(this bool2 f) => new(f, f);

        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int4x4 i4x4(this int4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int4x3 i4x3(this int4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int4x2 i4x2(this int4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int3x4 i3x4(this int3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int3x3 i3x3(this int3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int3x2 i3x2(this int3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int2x4 i2x4(this int2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int2x3 i2x3(this int2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static int2x2 i2x2(this int2 f) => new(f, f);
        
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint4x4 u4x4(this uint4 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint4x3 u4x3(this uint4 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint4x2 u4x2(this uint4 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint3x4 u3x4(this uint3 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint3x3 u3x3(this uint3 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint3x2 u3x2(this uint3 f) => new(f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint2x4 u2x4(this uint2 f) => new(f, f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint2x3 u2x3(this uint2 f) => new(f, f, f);
        ///<inheritdoc cref="f4x4(float4)"/>
        [MethodImpl(IL)] public static uint2x2 u2x2(this uint2 f) => new(f, f);



        #region Matrix Truncation

        /// Truncates the matrix to the specified size
        [MethodImpl(IL)] public static float2x2 f2x2(this float2x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float3x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float4x3 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float2x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float3x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x2 f2x2(this float4x4 m) => new(m.c0.xy, m.c1.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float3x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float4x3 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x3 f2x3(this float4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float3x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float2x4 f2x4(this float4x4 m) => new(m.c0.xy, m.c1.xy, m.c2.xy, m.c3.xy);
        
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float4x3 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float3x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x2 f3x2(this float4x4 m) => new(m.c0.xyz, m.c1.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float4x3 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float3x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x3 f3x3(this float4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float3x4 f3x4(this float4x4 m) => new(m.c0.xyz, m.c1.xyz, m.c2.xyz, m.c3.xyz);
        
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4x3 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x2 f4x2(this float4x4 m) => new(m.c0, m.c1);
        /// <inheritdoc cref="f2x2(float2x3)"/>
        [MethodImpl(IL)] public static float4x3 f4x3(this float4x4 m) => new(m.c0, m.c1, m.c2);

        #endregion



        #endregion
    }
}