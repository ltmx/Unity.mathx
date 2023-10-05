#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    /// A 8-bit byte for Unity.Mathematics interoperability
    [Serializable]
    public struct byte1 :
        IEquatable<byte1>, 
        IEquatable<byte>, 
        IFormattable
    {
        /// The raw 8 bit value of the byte.
        internal byte value;

        /// byte zero value.
        public static readonly byte1 zero = 0;

        /// The maximum finite byte value as a single precision float.
        public const float MaxValue = 255;
        /// The minimum finite byte value as a single precision float.
        public const float MinValue = 0;
        
        /// The maximum finite byte value as a byte.
        public static readonly byte1 MaxValueAsByte1 = new(MaxValue) ;
        /// The minimum finite byte value as a byte.
        public static readonly byte1 MinValueAsByte1 = new(MinValue) ;
        
        private const MethodImplOptions INLINE = MethodImplOptions.AggressiveInlining;
        
        // Constructors
        [MethodImpl(INLINE)] public byte1(byte1 x) => value = x.value;
        [MethodImpl(INLINE)] public byte1(byte x) => value = x;
        [MethodImpl(INLINE)] public byte1(int x) => value = (byte)x;
        [MethodImpl(INLINE)] public byte1(float v) => value = (byte)v;
        [MethodImpl(INLINE)] public byte1(double v) => value = (byte)v;
        
        // Implicit Casts
        [MethodImpl(INLINE)] public static implicit operator byte1(byte v) => new(v);
        [MethodImpl(INLINE)] public static implicit operator byte1(float v) => new(v);
        [MethodImpl(INLINE)] public static implicit operator byte1(double v) => new(v);
        [MethodImpl(INLINE)] public static implicit operator byte1(int d) => (byte)d;
        [MethodImpl(INLINE)] public static implicit operator byte1(half d) => (byte)d;
        [MethodImpl(INLINE)] public static implicit operator byte(byte1 v) => v.value;
        // Explicit casts
        [MethodImpl(INLINE)] public static explicit operator float(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator double(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator int(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator uint(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator short(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator ushort(byte1 d) => d;
        [MethodImpl(INLINE)] public static explicit operator half(byte1 d) => (half)d.value;

        // /// <summary>Returns the bit pattern of a float as an int.</summary>
        // /// <param name="x">The float bits to copy.</param>
        // /// <returns>The byte with the same bit pattern as the input.</returns>
        // [MethodImpl(INLINE)]
        // public static int asbyte(float x) {
        //     ByteFloatUnion u;
        //     u.byteValue = 0;
        //     u.floatValue = x;
        //     return u.byteValue;
        // }
        //
        // [StructLayout(LayoutKind.Explicit)]
        // internal struct ByteFloatUnion
        // {
        //     [FieldOffset(0)] public byte byteValue;
        //     [FieldOffset(0)] public float floatValue;
        // }
        
        /// Returns whether two byte values are bitwise equivalent.
        /// Returns True if the two byte values are bitwise equivalent, false otherwise.
        [MethodImpl(INLINE)] public static bool operator ==(byte1 lhs, byte1 rhs) => lhs.value == rhs.value;
        /// Returns whether two byte values are not bitwise equivalent.
        [MethodImpl(INLINE)] public static bool operator !=(byte1 lhs, byte1 rhs) => lhs.value != rhs.value;
        /// Returns True if the two byte values are not bitwise equivalent, false otherwise.
        [MethodImpl(INLINE)] public static bool operator <(byte1 lhs, byte1 rhs) => lhs.value < rhs.value;
        /// Returns True if the two byte values are not bitwise equivalent, false otherwise.
        [MethodImpl(INLINE)] public static bool operator > (byte1 lhs, byte1 rhs) => lhs.value > rhs.value;
        /// Returns True if the lhs is less or equal than the rhs, false otherwise.
        [MethodImpl(INLINE)] public static bool operator <= (byte1 lhs, byte1 rhs) => lhs.value <= rhs.value;
        /// <returns>True if the lhs is greater or equal than the rhs, false otherwise.</returns>
        [MethodImpl(INLINE)] public static bool operator >= (byte1 lhs, byte1 rhs) => lhs.value >= rhs.value; 
        
        
        /// Returns the result of a modulation of two byte1 vectors into a byte1
        [MethodImpl(INLINE)] public static byte1 operator %(byte1 lhs, byte1 rhs) => lhs.value % rhs.value;
        /// Returns the result of a division of two byte1 vectors into a float
        [MethodImpl(INLINE)] public static float operator /(byte1 lhs, byte1 rhs) => lhs.value / (float)rhs.value;
        /// Returns the result of a multiplication of two byte1 vectors into a byte1
        [MethodImpl(INLINE)] public static int operator *(byte1 lhs, byte1 rhs) => lhs.value * rhs.value;
        /// Returns the result of a bitwise XOR of two byte1 vectors into a byte1
        [MethodImpl(INLINE)] public static int operator ^(byte1 lhs, byte1 rhs) => lhs.value ^ rhs.value;
        /// Returns the result of a bitwise AND of two byte1 vectors into a byte1
        [MethodImpl(INLINE)] public static int operator &(byte1 lhs, byte1 rhs) => lhs.value & rhs.value;
        /// Returns the result of a bitwise OR of two byte1 vectors into a byte1
        [MethodImpl(INLINE)] public static int operator |(byte1 lhs, byte1 rhs) => lhs.value | rhs.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MethodImpl(INLINE)] public static int operator +(byte1 lhs, byte1 rhs) => lhs.value + rhs.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MethodImpl(INLINE)] public static int operator -(byte1 lhs, byte1 rhs) => lhs.value - rhs.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MethodImpl(INLINE)] public static byte1 operator --(byte1 lhs) => --lhs.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MethodImpl(INLINE)] public static byte1 operator ++(byte1 lhs) => ++lhs.value;
        

        /// Returns true if the byte is bitwise equivalent to a given half, false otherwise.
        /// <returns>True if the byte value is bitwise equivalent to the input, false otherwise.</returns>
        [MethodImpl(INLINE)]
        public bool Equals(byte1 rhs) => value == rhs.value;

        public bool Equals(byte rhs) => value == rhs;

        /// Returns true if the byte is equal to a given half, false otherwise.
        /// <param name="o">Right hand side object to use in comparison.</param>
        /// <returns>True if the object is of type byte and is bitwise equivalent, false otherwise.</returns>
        [MethodImpl(INLINE)] public override bool Equals(object o) => o is byte1 converted && Equals(converted);
        
        /// Returns a hash code for the byte.
        /// <returns>The computed hash code of the byte.</returns>
        [MethodImpl(INLINE)] public override int GetHashCode() => value.GetHashCode();
        
        /// Returns a string representation of the byte.
        /// <returns>The string representation of the byte.</returns>
        [MethodImpl(INLINE)] public override string ToString() => value.ToString();


        /// Returns a string representation of the byte using a specified format and culture-specific format information.
        /// <param name="format">The format string to use during string formatting.</param>
        /// <param name="formatProvider">The format provider to use during string formatting.</param>
        /// <returns>The string representation of the byte.</returns>
        [MethodImpl(INLINE)] public string ToString(string format, IFormatProvider formatProvider) => value.ToString(format, formatProvider);
    }

    public static partial class mathx
    {
        /// Returns a byte value constructed from a byte values.
        [MethodImpl(INLINE)] public static byte1 byte1(byte1 x) => new(x);
        /// Returns a byte value constructed from a float value.
        [MethodImpl(INLINE)] public static byte1 byte1(float v) => new(v);
        /// Returns a byte value constructed from a double value.
        [MethodImpl(INLINE)] public static byte1 byte1(double v) => new(v);
        
        /// Returns a uint hash code of a byte value.
        [MethodImpl(INLINE)] public static uint hash(this byte1 v) => v.value * 0x745ED837u + 0x816EFB5Du;
    }
}