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

        ///<inheritdoc cref="math.int4(int)"/>
        public static int4 i4(this int f) => math.int4(f);
        /// Returns a i4 with the first two components set to i, and the last two set to 0
        public static int4 i4(this int2 f) => math.int4(f, 0, 0);
        /// Returns a i4 with the first three components set to i, and the last one set to 0
        public static int4 i4(this int3 f) => math.int4(f, 0);
        /// <inheritdoc cref="math.int4(int, int, int, int)"/>
        public static int4 i4(int a, int b, int c, int d) => math.int4(a, b, c, d);
        /// <inheritdoc cref="math.int4(Mathematics.int2, Mathematics.int2)"/>
        public static int4 i4(int2 a, int2 b) => math.int4(a, b);
        /// <inheritdoc cref="math.int4(Mathematics.int3, int)"/>
        public static int4 i4(int3 a, int b) => math.int4(a, b);
        /// <inheritdoc cref="math.int4(int, Mathematics.int3)"/>
        public static int4 i4(int a, int3 b) => math.int4(a, b);
        /// <inheritdoc cref="math.int4(int, int, Mathematics.int2)"/>
        public static int4 i4(int a, int2 b, int c) => math.int4(a, b, c);
        /// <inheritdoc cref="math.int4(int, int, int, int)"/>
        public static int4 i4(int a, int b, int2 c) => math.int4(a, b, c);
        /// <inheritdoc cref="math.int4(int, int, int, int)"/>
        public static int4 i4(int2 a, int b, int c) => math.int4(a, b, c);
        /// <inheritdoc cref="math.int3(int, int, int)"/>
        public static int3 i3(int a, int b, int c) => math.int3(a, b, c);
        /// <inheritdoc cref="math.int3(Mathematics.int2, int)"/>
        public static int3 i3(int2 a, int b) => math.int3(a, b);
        /// <inheritdoc cref="math.int3(int, Mathematics.int2)"/>
        public static int3 i3(int a, int2 b) => math.int3(a, b);
        /// <inheritdoc cref="math.int3(int)"/>
        public static int3 i3(this int f) => math.int3(f);
        /// <inheritdoc cref="math.int3(Mathematics.int2, int)"/>
        public static int3 i3(this int2 f) => math.int3(f, 0);
        /// Returns a i3 with containing the first three components of a i4
        public static int3 i3(this int4 f) => math.int3(f.xyz); // crop w
        /// <inheritdoc cref="math.int2(int, int)"/>
        public static int2 i2(int a, int b) => math.int2(a, b);
        /// <inheritdoc cref="math.int2(int)"/>
        public static int2 i2(this int f) => math.int2(f);
        /// Returns a i2 with containing the first two components of a i3
        public static int2 i2(this int3 f) => math.int2(f.xy); // crop z
        /// Returns a i2 with containing the first two components of a i4
        public static int2 i2(this int4 f) => math.int2(f.xy); // crop zw

        #endregion


        #region Appending

        /// appends a int to a int to create a i2
        [MethodImpl(IL)] public static int2 append(this int x, int y) => new(x, y);
        /// appends a int to a i2 to create a i3
        [MethodImpl(IL)] public static int3 append(this int2 xy, int z) => new(xy, z);
        /// appends a i2 to a int to create a i3
        [MethodImpl(IL)] public static int3 append(this int x, int2 yz) => new(x, yz);
        /// appends a int to a i3 to create a i4
        [MethodImpl(IL)] public static int4 append(this int3 xyz, int w) => new(xyz, w);
        /// appends a i2 to a i2 to create a i4
        [MethodImpl(IL)] public static int4 append(this int2 xy, int2 zw) => new(xy, zw);
        /// appends a i3 to a int to create a i4
        [MethodImpl(IL)] public static int4 append(this int x, int3 yzw) => new(x, yzw);
        
        
        /// appends a int to a int2x2 to create a int2x3
        [MethodImpl(IL)] public static int2x3 append(this int2x2 m, int2 c) => new(m.c0, m.c1, c);
        /// appends a i2 to a int2x3 to create a int2x4
        [MethodImpl(IL)] public static int2x4 append(this int2x3 m, int2 c) => new(m.c0, m.c1, m.c2, c);
        /// appends a i3 to a int3x2 to create a int3x3
        [MethodImpl(IL)] public static int3x3 append(this int3x2 m, int3 c) => new(m.c0, m.c1, c);
        /// appends a i3 to a int3x3 to create a int3x4
        [MethodImpl(IL)] public static int3x4 append(this int3x3 m, int3 c) => new(m.c0, m.c1, m.c2, c);
        /// appends a i4 to a int4x2 to create a int4x3
        [MethodImpl(IL)] public static int4x3 append(this int4x2 m, int4 c) => new(m.c0, m.c1, c);
        /// appends a i4 to a int4x3 to create a int4x4
        [MethodImpl(IL)] public static int4x4 append(this int4x3 m, int4 c) => new(m.c0, m.c1, m.c2, c);
        
        
        /// appends a int to a int to create a i2
        [MethodImpl(IL)] public static int2 y(this int x, int y) => new(x, y);
        /// appends a int to a i2 to create a i3
        [MethodImpl(IL)] public static int3 z(this int2 xy, int z) => new(xy, z);
        /// appends a i2 to a int to create a i3
        [MethodImpl(IL)] public static int3 yz(this int x, int2 yz) => new(x, yz);
        /// appends a int to a i3 to create a i4
        [MethodImpl(IL)] public static int4 w(this int3 xyz, int w) => new(xyz, w);
        /// appends a i2 to a i2 to create a i4
        [MethodImpl(IL)] public static int4 zw(this int2 xy, int2 zw) => new(xy, zw);
        /// appends a i3 to a int to create a i4
        [MethodImpl(IL)] public static int4 yzw(this int x, int3 yzw) => new(x, yzw);

        #endregion
        
    }
}