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
        /// Returns true if a is odd
        [MethodImpl(INLINE)] public static bool odd(this byte a) => (a & 1) != 0; // 12% faster than a % 2 == 1
        /// Returns true if a is odd component-wise
        [MethodImpl(INLINE)] public static bool2 odd(this byte2 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MethodImpl(INLINE)] public static bool3 odd(this byte3 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MethodImpl(INLINE)] public static bool4 odd(this byte4 a) => (a & 1) != 0;
        
        /// Returns true if a is even
        [MethodImpl(INLINE)] public static bool even(this byte a) => (a & 1) != 1; // 12% faster than a % 2 == 0
        /// Returns true if a is even component-wise
        [MethodImpl(INLINE)] public static bool2 even(this byte2 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        [MethodImpl(INLINE)] public static bool3 even(this byte3 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        [MethodImpl(INLINE)] public static bool4 even(this byte4 a) => (a & 1) != 1;
        
        
        // Node : Bytes are never NAN, and Never Infinite... these methods are reserved to floating point numbers


        /// returns true component-wise if the any component is greater to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 greater(this byte4 f, byte value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 greater(this byte3 f, byte value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 greater(this byte2 f, byte value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool greater(this byte f, byte value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 greater(this byte4 f, byte4 value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 greater(this byte3 f, byte3 value) => f > value;
        /// <inheritdoc cref="greater(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 greater(this byte2 f, byte2 value) => f > value;
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 less(this byte4 f, byte value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 less(this byte3 f, byte value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 less(this byte2 f, byte value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool less(this byte f, byte value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 less(this byte4 f, byte4 value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 less(this byte3 f, byte3 value) => f < value;
        /// <inheritdoc cref="less(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 less(this byte2 f, byte2 value) => f < value;
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 lesseq(this byte4 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 lesseq(this byte3 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 lesseq(this byte2 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool lesseq(this byte f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 lesseq(this byte4 f, byte4 value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 lesseq(this byte3 f, byte3 value) => f <= value;
        /// <inheritdoc cref="lesseq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 lesseq(this byte2 f, byte2 value) => f <= value;
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 greatereq(this byte4 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 greatereq(this byte3 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 greatereq(this byte2 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool greatereq(this byte f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 greatereq(this byte4 f, byte4 value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 greatereq(this byte3 f, byte3 value) => f >= value;
        /// <inheritdoc cref="greatereq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 greatereq(this byte2 f, byte2 value) => f >= value;
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 eq(this byte4 f, byte value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 eq(this byte3 f, byte value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 eq(this byte2 f, byte value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool eq(this byte f, byte value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 eq(this byte4 f, byte4 value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 eq(this byte3 f, byte3 value) => f == value;
        /// <inheritdoc cref="eq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 eq(this byte2 f, byte2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        [MethodImpl(INLINE)] public static bool4 neq(this byte4 f, byte value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 neq(this byte3 f, byte value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 neq(this byte2 f, byte value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool neq(this byte f, byte value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool4 neq(this byte4 f, byte4 value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool3 neq(this byte3 f, byte3 value) => f != value;
        /// <inheritdoc cref="neq(byte4,byte)"/>
        [MethodImpl(INLINE)] public static bool2 neq(this byte2 f, byte2 value) => f != value;
    }
}