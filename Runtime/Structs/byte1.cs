#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;

using MI = System.Runtime.CompilerServices.MethodImplAttribute;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics
{
    /// A 8-bit struct for Unity.Mathematics interoperability
    [Serializable]
    public struct byte1 : IEquatable<byte1>, IEquatable<byte>, IFormattable
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
        
        // Constructors
        [MI(IL)] public byte1(byte1 x) => value = x.value;
        [MI(IL)] public byte1(byte x) => value = x;
        [MI(IL)] public byte1(int x) => value = (byte)x;
        [MI(IL)] public byte1(float v) => value = (byte)v;
        [MI(IL)] public byte1(double v) => value = (byte)v;
        
        // Implicit Casts
        [MI(IL)] public static implicit operator byte1(byte v) => new(v);
        [MI(IL)] public static implicit operator byte1(float v) => new(v);
        [MI(IL)] public static implicit operator byte1(double v) => new(v);
        [MI(IL)] public static implicit operator byte1(int d) => (byte)d;
        [MI(IL)] public static implicit operator byte1(half d) => (byte)d;
        [MI(IL)] public static implicit operator byte(byte1 v) => v.value;
        // Explicit casts
        [MI(IL)] public static explicit operator float(byte1 d) => d;
        [MI(IL)] public static explicit operator double(byte1 d) => d;
        [MI(IL)] public static explicit operator int(byte1 d) => d;
        [MI(IL)] public static explicit operator uint(byte1 d) => d;
        [MI(IL)] public static explicit operator short(byte1 d) => d;
        [MI(IL)] public static explicit operator ushort(byte1 d) => d;
        [MI(IL)] public static explicit operator half(byte1 d) => (half)d.value;

        // /// <summary>Returns the bit pattern of a float as an int.</summary>
        // /// <param name="x">The float bits to copy.</param>
        // /// <returns>The byte with the same bit pattern as the input.</returns>
        // [MI(IL)]
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
        [MI(IL)] public static bool operator ==(byte1 a, byte1 b) => a.value == b.value;
        /// Returns whether two byte values are not bitwise equivalent.
        [MI(IL)] public static bool operator !=(byte1 a, byte1 b) => a.value != b.value;
        /// Returns True if the two byte values are not bitwise equivalent, false otherwise.
        [MI(IL)] public static bool operator <(byte1 a, byte1 b) => a.value < b.value;
        /// Returns True if the two byte values are not bitwise equivalent, false otherwise.
        [MI(IL)] public static bool operator > (byte1 a, byte1 b) => a.value > b.value;
        /// Returns True if the a is less or equal than the b, false otherwise.
        [MI(IL)] public static bool operator <= (byte1 a, byte1 b) => a.value <= b.value;
        /// <returns>True if the a is greater or equal than the b, false otherwise.</returns>
        [MI(IL)] public static bool operator >= (byte1 a, byte1 b) => a.value >= b.value; 
        
        
        /// Returns the result of a modulation of two byte1 vectors into a byte1
        [MI(IL)] public static byte1 operator %(byte1 a, byte1 b) => a.value % b.value;
        /// Returns the result of a division of two byte1 vectors into a float
        [MI(IL)] public static float operator /(byte1 a, byte1 b) => a.value / (float)b.value;
        /// Returns the result of a multiplication of two byte1 vectors into a byte1
        [MI(IL)] public static int operator *(byte1 a, byte1 b) => a.value * b.value;


        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MI(IL)] public static int operator +(byte1 a, byte1 b) => a.value + b.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MI(IL)] public static int operator -(byte1 a, byte1 b) => a.value - b.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MI(IL)] public static byte1 operator --(byte1 a) => --a.value;
        /// Returns the result of a bitwise NOT of a byte1 vector into a byte1
        [MI(IL)] public static byte1 operator ++(byte1 a) => ++a.value;
        
        /// <summary>Returns the result of a componentwise bitwise not operation on an byte1 vector.</summary>
        [MI(IL)]public static int operator ~(byte1 val) => ~val.value;
        
        /// Returns the result of a bitwise AND of two byte1 vectors into a byte1
        [MI(IL)] public static int operator &(byte1 a, byte1 b) => a.value & b.value;
        /// <summary>Returns the result of a componentwise bitwise and operation on an byte1 vector and an int value.</summary>
        [MI(IL)] public static int operator &(byte1 a, int b) => a.value & b;
        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an byte1 vector.</summary>
        [MI(IL)] public static int operator &(int a, byte1 b) => a & b.value;

        /// Returns the result of a bitwise OR of two byte1 vectors into a byte1
        [MI(IL)] public static int operator |(byte1 a, byte1 b) => a.value | b.value;
        /// <summary>Returns the result of a componentwise bitwise or operation on an byte1 vector and an int value.</summary>
        [MI(IL)] public static int operator |(byte1 a, int b) => a.value | b;
        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an byte1 vector.</summary>
        [MI(IL)] public static int operator |(int a, byte1 b) => a | b.value;

        /// Returns the result of a bitwise XOR of two byte1 vectors into a byte1
        [MI(IL)] public static int operator ^(byte1 a, byte1 b) => a.value ^ b.value;
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an byte1 vector and an int value.</summary>
        [MI(IL)] public static int operator ^(byte1 a, int b) => a.value ^ b;
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an byte1 vector.</summary>
        [MI(IL)] public static int operator ^(int a, byte1 b) => a ^ b.value;
        

        /// Returns true if the byte is bitwise equivalent to a given half, false otherwise.
        /// <returns>True if the byte value is bitwise equivalent to the input, false otherwise.</returns>
        [MI(IL)]
        public bool Equals(byte1 b) => value == b.value;

        public bool Equals(byte b) => value == b;

        /// Returns true if the byte is equal to a given half, false otherwise.
        /// <param name="o">Right hand side object to use in comparison.</param>
        /// <returns>True if the object is of type byte and is bitwise equivalent, false otherwise.</returns>
        [MI(IL)] public override bool Equals(object o) => o is byte1 converted && Equals(converted);
        
        /// Returns a hash code for the byte.
        /// <returns>The computed hash code of the byte.</returns>
        [MI(IL)] public override int GetHashCode() => value.GetHashCode();
        
        /// Returns a string representation of the byte.
        /// <returns>The string representation of the byte.</returns>
        [MI(IL)] public override string ToString() => value.ToString();


        /// Returns a string representation of the byte using a specified format and culture-specific format information.
        /// <param name="format">The format string to use during string formatting.</param>
        /// <param name="formatProvider">The format provider to use during string formatting.</param>
        /// <returns>The string representation of the byte.</returns>
        [MI(IL)] public string ToString(string format, IFormatProvider formatProvider) => value.ToString(format, formatProvider);
    }

    public static partial class mathx
    {
        /// Returns a byte value constructed from a byte values.
        [MI(IL)] public static byte1 byte1(byte1 x) => new(x);
        /// Returns a byte value constructed from a float value.
        [MI(IL)] public static byte1 byte1(float v) => new(v);
        /// Returns a byte value constructed from a double value.
        [MI(IL)] public static byte1 byte1(double v) => new(v);
        
        /// Returns a uint hash code of a byte value.
        [MI(IL)] public static uint hash(this byte1 v) => v.value * 0x745ED837u + 0x816EFB5Du;
    }
}