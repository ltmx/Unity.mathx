#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    ///A 2 component vector of bytes.
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte2 : IEquatable<byte2>, IFormattable
    {
        ///x component of the vector.
        public byte x;
        ///y component of the vector.
        public byte y;

        ///byte2 zero value.
        public static readonly byte2 zero = 0;

        ///Constructs a byte2 from two byte values.
        [MethodImpl(INLINE)] public byte2(byte x, byte y) { this.x = x; this.y = y; }
        
        [MethodImpl(INLINE)] public byte2(ValueType a, ValueType b)
        {
            x = (byte)a; 
            y = (byte)b;
        }
        
        
        
        ///Constructs a byte2 vector from a single byte value by assigning it to every component.
        [MethodImpl(INLINE)] public byte2(byte v) { x = y = v; }
        [MethodImpl(INLINE)] public byte2(ValueType v) { x = y = (byte)v; }
        
        ///Constructs a byte2 from a f2
        [MethodImpl(INLINE)] public byte2(float2 v) { x = (byte)v.x; y = (byte)v.y; }
        /// Constructs a byte2 from a int2
        [MethodImpl(INLINE)] public byte2(int2 v) { x = (byte)v.x; y = (byte)v.y; }
        /// Constructs a byte2 from a uint2
        [MethodImpl(INLINE)] public byte2(uint2 v) { x = (byte)v.x; y = (byte)v.y; }
        /// Constructs a byte2 from a half2
        [MethodImpl(INLINE)] public byte2(half2 v) { x = (byte)v.x; y = (byte)v.y; }
        /// Constructs a byte2 from a double2
        [MethodImpl(INLINE)] public byte2(double2 v) { x = (byte)v.x; y = (byte)v.y; }

        /// Implicitly converts a single byte value to a byte2 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte2(byte v) => new(v);
        /// Implicitly converts a single int value to a byte2 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte2(int v) => new((byte)v);
        /// Implicitly converts a single uint value to a byte2 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte2(uint v) => new((byte)v);
        /// Explicitly converts a single float value to a byte2 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static explicit operator byte2(float v) => new((byte)v);
        /// Explicitly converts a single double value to a byte2 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static explicit operator byte2(double v) => new((byte)v);
        
        /// Implicitly converts an int2 vector to a byte2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static implicit operator byte2(int2 v) => new(v);
        /// Implicitly converts an int2 vector to a byte2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static implicit operator byte2(uint2 v) => new(v);
        /// Explicitly converts a f2 vector to a byte2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static explicit operator byte2(float2 v) => new(v);
        /// Explicitly converts a double2 vector to a byte2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static explicit operator byte2(double2 v) => new(v);

        ///Returns the result of a componentwise equality operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator ==(byte2 a, byte2 b) => new(a.x == b.x, a.y == b.y);
        ///Returns the result of a componentwise equality operation on a byte2 vector and a byte value.
        [MethodImpl(INLINE)] public static bool2 operator ==(byte2 a, byte b) => new(a.x == b, a.y == b);
        ///Returns the result of a componentwise equality operation on a byte value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator ==(byte a, byte2 b) => new(a == b.x, a == b.y);

        ///Returns the result of a componentwise not equal operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator !=(byte2 a, byte2 b) => new(a.x != b.x, a.y != b.y);
        ///Returns the result of a componentwise not equal operation on a byte2 vector and a byte value.
        [MethodImpl(INLINE)] public static bool2 operator !=(byte2 a, byte b) => new(a.x != b, a.y != b);
        ///Returns the result of a componentwise not equal operation on a byte value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator !=(byte a, byte2 b) => new(a != b.x, a != b.y);


        ///Returns the result of a componentwise multiplication operation on two f2 vectors.
        [MethodImpl(INLINE)] public static int2 operator *(byte2 a, byte2 b) => new(a.x * b.x, a.y * b.y);
        ///Returns the result of a componentwise multiplication operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static int2 operator *(byte2 a, byte b) => new(a.x * b, a.y * b);
        ///Returns the result of a componentwise multiplication operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static int2 operator *(byte a, byte2 b) => new(a * b.x, a * b.y);
        
        ///Returns the result of a componentwise addition operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static int2 operator +(byte2 a, byte2 b) => new(a.x + b.x, a.y + b.y);
        ///Returns the result of a componentwise addition operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static int2 operator +(byte2 a, byte b) => new(a.x + b, a.y + b);
        ///Returns the result of a componentwise addition operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static int2 operator +(byte a, byte2 b) => new(a + b.x, a + b.y);
        
        ///Returns the result of a componentwise subtraction operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static int2 operator -(byte2 a, byte2 b) => new(a.x - b.x, a.y - b.y);
        ///Returns the result of a componentwise subtraction operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static int2 operator -(byte2 a, byte b) => new(a.x - b, a.y - b);
        ///Returns the result of a componentwise subtraction operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static int2 operator -(byte a, byte2 b) => new(a - b.x, a - b.y);
        
        ///Returns the result of a componentwise division operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static float2 operator /(byte2 a, byte2 b) => new(a.x / b.x, a.y / b.y);
        ///Returns the result of a componentwise division operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static float2 operator /(byte2 a, byte b) => new(a.x / b, a.y / b);
        ///Returns the result of a componentwise division operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static float2 operator /(byte a, byte2 b) => new(a / b.x, a / b.y);


        ///Returns the result of a componentwise modulus operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static byte2 operator %(byte2 a, byte2 b) => new(a.x % b.x, a.y % b.y);
        ///Returns the result of a componentwise modulus operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static byte2 operator %(byte2 a, byte b) => new(a.x % b, a.y % b);
        ///Returns the result of a componentwise modulus operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static byte2 operator %(byte a, byte2 b) => new(a % b.x, a % b.y);

        ///Returns the result of a componentwise increment operation on a byte2 vector.
        [MethodImpl(INLINE)] public static byte2 operator ++(byte2 v) => new(++v.x, ++v.y);
        ///Returns the result of a componentwise decrement operation on a byte2 vector.
        [MethodImpl(INLINE)] public static byte2 operator --(byte2 v) => new(--v.x, --v.y);

        ///Returns the result of a componentwise less than operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator <(byte2 a, byte2 b) => new(a.x < b.x, a.y < b.y);
        ///Returns the result of a componentwise less than operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static bool2 operator <(byte2 a, byte b) => new(a.x < b, a.y < b);
        ///Returns the result of a componentwise less than operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator <(byte a, byte2 b) => new(a < b.x, a < b.y);
        
        ///Returns the result of a componentwise less or equal operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator <=(byte2 a, byte2 b) => new(a.x <= b.x, a.y <= b.y);
        ///Returns the result of a componentwise less or equal operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static bool2 operator <=(byte2 a, byte b) => new(a.x <= b, a.y <= b);
        ///Returns the result of a componentwise less or equal operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator <=(byte a, byte2 b) => new(a <= b.x, a <= b.y);
        
        ///Returns the result of a componentwise greater than operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator >(byte2 a, byte2 b) => new(a.x > b.x, a.y > b.y);
        ///Returns the result of a componentwise greater than operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static bool2 operator >(byte2 a, byte b) => new(a.x > b, a.y > b);
        ///Returns the result of a componentwise greater than operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator >(byte a, byte2 b) => new(a > b.x, a > b.y);

        ///Returns the result of a componentwise greater or equal operation on two byte2 vectors.
        [MethodImpl(INLINE)] public static bool2 operator >=(byte2 a, byte2 b) => new(a.x >= b.x, a.y >= b.y);
        ///Returns the result of a componentwise greater or equal operation on a byte2 vector and a float value.
        [MethodImpl(INLINE)] public static bool2 operator >=(byte2 a, byte b) => new(a.x >= b, a.y >= b);
        ///Returns the result of a componentwise greater or equal operation on a float value and a byte2 vector.
        [MethodImpl(INLINE)] public static bool2 operator >=(byte a, byte2 b) => new(a >= b.x, a >= b.y);

        ///Returns the result of a componentwise unary minus operation on a byte2 vector.
        [MethodImpl(INLINE)] public static byte2 operator -(byte2 v) => new(-v.x, -v.y);
        ///Returns the result of a componentwise unary plus operation on a byte2 vector.
        [MethodImpl(INLINE)] public static byte2 operator +(byte2 v) => new(+v.x, +v.y);
        
        
        /// <summary>Returns the result of a componentwise bitwise not operation on an byte2 vector.</summary>
        [MethodImpl(INLINE)]public static byte2 operator ~(byte2 val) => new(~val.x, ~val.y);
        
        /// <summary>Returns the result of a componentwise bitwise and operation on two byte2 vectors.</summary>
        [MethodImpl(INLINE)] public static byte2 operator &(byte2 a, byte2 b) => new(a.x & b.x, a.y & b.y);
        /// <summary>Returns the result of a componentwise bitwise and operation on an byte2 vector and an int value.</summary>
        [MethodImpl(INLINE)] public static byte2 operator &(byte2 a, int b) => new(a.x & b, a.y & b);
        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an byte2 vector.</summary>
        [MethodImpl(INLINE)] public static byte2 operator &(int a, byte2 b) => new(a & b.x, a & b.y);

        /// <summary>Returns the result of a componentwise bitwise or operation on two byte2 vectors.</summary>
        [MethodImpl(INLINE)] public static byte2 operator |(byte2 a, byte2 b) => new(a.x | b.x, a.y | b.y);
        /// <summary>Returns the result of a componentwise bitwise or operation on an byte2 vector and an int value.</summary>
        [MethodImpl(INLINE)] public static byte2 operator |(byte2 a, int b) => new(a.x | b, a.y | b);
        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an byte2 vector.</summary>
        [MethodImpl(INLINE)] public static byte2 operator |(int a, byte2 b) => new(a | b.x, a | b.y);

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two byte2 vectors.</summary>
        [MethodImpl(INLINE)] public static byte2 operator ^(byte2 a, byte2 b) => new(a.x ^ b.x, a.y ^ b.y);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an byte2 vector and an int value.</summary>
        [MethodImpl(INLINE)] public static byte2 operator ^(byte2 a, int b) => new(a.x ^ b, a.y ^ b);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an byte2 vector.</summary>
        [MethodImpl(INLINE)] public static byte2 operator ^(int a, byte2 b) => new(a ^ b.x, a ^ b.y);
        


        ///Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xx { [MethodImpl(INLINE)] get => new(x, x); }

        ///Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xy
        {
            [MethodImpl(INLINE)] get => new(x, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
            }
        }

        ///Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yx
        {
            [MethodImpl(INLINE)] get => new(y, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
            }
        }

        ///Returns the byte element at a specified index.
        public unsafe byte this[int index]
        {
            get {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2) throw new ArgumentException("index must be between[0...1]");
                #endif
                fixed (byte2* array = &this) {
                    return ((byte*)array)[index];
                }
            }
            set {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2) throw new ArgumentException("index must be between[0...1]");
                #endif
                fixed (byte* array = &x) {
                    array[index] = value;
                }
            }
        }

        ///Returns true if the byte2 is equal to a given byte2, false otherwise.
        /// <param name="b">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(INLINE)] public bool Equals(byte2 b) => x == b.x && y == b.y;

        ///Returns true if the byte2 is equal to a given byte2, false otherwise.
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte2 converted && Equals(converted);

        ///Returns a hash code for the byte2.
        /// <returns>The computed hash code.</returns>
        [MethodImpl(INLINE)] public override int GetHashCode() => (int)hash(this);

        ///Returns a string representation of the byte2.
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)] public override string ToString() => $"byte2({x}, {y})";

        ///Returns a string representation of the byte2 using a specified format and culture-specific format information.
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)] public string ToString(string format, IFormatProvider formatProvider) => $"byte2({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)})";

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;

            public DebuggerProxy(byte2 v) {
                x = v.x;
                y = v.y;
            }
        }
    }

    public static partial class mathx
    {
        ///Returns a byte2 vector constructed from a single byte value by assigning it to every component.
        [MethodImpl(INLINE)] public static byte2 byte2(byte v) => new(v);
        ///Returns a byte2 vector constructed from a single byte value by assigning it to every component.
        [MethodImpl(INLINE)] public static byte2 byte2(ValueType v) => new(v);
        
        ///Returns a byte2 vector constructed from two byte values.
        [MethodImpl(INLINE)] public static byte2 byte2(byte x, byte y) => new(x, y);

        ///Return a byte2 vector constructed from a f2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static byte2 byte2(float2 v) => new(v);
        ///Return a byte2 vector constructed from a double2 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static byte2 byte2(double2 v) => new(v);

        ///Returns a uint hash code of a byte2 vector.
        [MethodImpl(INLINE)] public static uint hash(byte2 v) => math.csum(uint2(v.x, v.y) * uint2(0x6E624EB7u, 0x7383ED49u)) + 0xDD49C23Bu;

        /// Returns a uint2 vector hash code of a byte2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        [MethodImpl(INLINE)] public static uint2 hashwide(byte2 v) => uint2(v.x, v.y) * uint2(0xEBD0D005u, 0x91475DF7u) + 0x55E84827u;


        /// <inheritdoc cref="subx(byte4, byte)"/>
        [MethodImpl(IL)] public static byte2 subx(this byte2 f, byte x) => new(x, f.y);
        /// <inheritdoc cref="suby(byte4, byte)"/>
        [MethodImpl(IL)] public static byte2 suby(this byte2 f, byte y) => new(f.x, y);
    }
}