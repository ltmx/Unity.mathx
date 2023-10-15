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
        // packed data accessing ------------------------------------

        /// selects an element of an array using an int as index;
        [MethodImpl(INLINE)] public static T get<T>(this int id, T[] t) => t[id];
        /// selects an element of an array of arrays using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int2 id, T[][] t) => t[id.x][id.y];
        /// selects an element of an array of arrays using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int3 id, T[][][] t) => t[id.x][id.y][id.z];
        /// selects an element of an array using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int2 id, T[,] t) => t[id.x, id.y];
        /// selects an element of an array using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int3 id, T[,,] t) => t[id.x, id.y, id.z];
        /// selects an element of a multidimensional array of arrays using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int3 id, T[,][] t) => t[id.x, id.y][id.z];
        /// selects an element of an array of multidimensional arrays using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this int3 id, T[][,] t) => t[id.x][id.y, id.z];
        
        /// selects an element of an array using an int as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[] t, int id) => t[id];
        /// selects an element of an array of arrays using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[][] t, int2 id) => t[id.x][id.y];
        /// selects an element of an array of arrays using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[][][] t, int3 id) => t[id.x][id.y][id.z];
        /// selects an element of an array using an int2 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[,] t, int2 id) => t[id.x, id.y];
        /// selects an element of an array using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[,,] t, int3 id) => t[id.x, id.y, id.z];
        /// selects an element of a multidimensional array of arrays using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[,][] t, int3 id) => t[id.x, id.y][id.z];
        /// selects an element of an array of multidimensional arrays using an int3 as index;
        [MethodImpl(INLINE)] public static T get<T>(this T[][,] t, int3 id) => t[id.x][id.y, id.z];
        
        /// Returns a if s is true, b otherwise
        [MethodImpl(INLINE)] public static T select<T>(this bool s, T a, T b) => s ? a : b;
        /// Returns a if s is true, b otherwise
        [MethodImpl(INLINE)] public static T select<T>(this int s, T a, T b) => s.asbool() ? a : b;
    }
}