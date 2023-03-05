#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
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
    /// <summary>A 2 component vector of bytes.</summary>
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public partial struct byte2 : IEquatable<byte2>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public byte x;

        /// <summary>y component of the vector.</summary>
        public byte y;

        /// <summary>byte2 zero value.</summary>
        public static readonly byte2 zero = 0;

        /// <summary>Constructs a byte2 vector from two byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte2(byte x, byte y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a byte2 vector from a byte2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte2(byte2 xy)
        {
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a byte2 vector from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        [MethodImpl(INLINE)]
        public byte2(byte v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>
        ///     Constructs a byte2 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte2</param>
        [MethodImpl(INLINE)]
        public byte2(float v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        [MethodImpl(INLINE)]
        public byte2(float2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }

        /// <summary>
        ///     Constructs a byte2 vector from a single double value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte2</param>
        [MethodImpl(INLINE)]
        public byte2(double v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        [MethodImpl(INLINE)]
        public byte2(double2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }

        /// <summary>Implicitly converts a single byte value to a byte2 vector by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static implicit operator byte2(byte v)
        {
            return new byte2(v);
        }

        /// <summary>
        ///     Explicitly converts a single float value to a byte2 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte2(float v)
        {
            return new byte2(v);
        }

        /// <summary>Explicitly converts a float2 vector to a byte2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte2(float2 v)
        {
            return new byte2(v);
        }

        /// <summary>
        ///     Explicitly converts a single double value to a byte2 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte2(double v)
        {
            return new byte2(v);
        }

        /// <summary>Explicitly converts a double2 vector to a byte2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte2(double2 v)
        {
            return new byte2(v);
        }

        /// <summary>Returns the result of a componentwise equality operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator ==(byte2 lhs, byte2 rhs) => new(lhs.x == rhs.x, lhs.y == rhs.y);

        /// <summary>Returns the result of a componentwise equality operation on a byte2 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator ==(byte2 lhs, byte rhs) => new(lhs.x == rhs, lhs.y == rhs);

        /// <summary>Returns the result of a componentwise equality operation on a byte value and a byte2 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator ==(byte lhs, byte2 rhs) => new(lhs == rhs.x, lhs == rhs.y);

        /// <summary>Returns the result of a componentwise not equal operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator !=(byte2 lhs, byte2 rhs)
        {
            return new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a byte2 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator !=(byte2 lhs, byte rhs)
        {
            return new bool2(lhs.x != rhs, lhs.y != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a byte value and a byte2 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool2 operator !=(byte lhs, byte2 rhs) => new bool2(lhs != rhs.x, lhs != rhs.y);

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxxx
        {
            [MethodImpl(INLINE)] get => new(x, x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxxy
        {
            [MethodImpl(INLINE)] get => new(x, x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyx
        {
            [MethodImpl(INLINE)] get => new(x, x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyy
        {
            [MethodImpl(INLINE)] get => new byte4(x, x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyxx
        {
            [MethodImpl(INLINE)] get => new(x, y, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyxy
        {
            [MethodImpl(INLINE)] get => new(x, y, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyyx
        {
            [MethodImpl(INLINE)] get => new(x, y, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyyy
        {
            [MethodImpl(INLINE)] get => new(x, y, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxxx
        {
            [MethodImpl(INLINE)] get => new(y, x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxxy
        {
            [MethodImpl(INLINE)] get => new(y, x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxyx
        {
            [MethodImpl(INLINE)] get => new(y, x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxyy
        {
            [MethodImpl(INLINE)] get => new(y, x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyxx
        {
            [MethodImpl(INLINE)] get => new(y, y, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyxy
        {
            [MethodImpl(INLINE)] get => new(y, y, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyyx
        {
            [MethodImpl(INLINE)] get => new(y, y, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyyy
        {
            [MethodImpl(INLINE)] get => new(y, y, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxx
        {
            [MethodImpl(INLINE)] get => new byte3(x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxy
        {
            [MethodImpl(INLINE)] get => new(x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xyx
        {
            [MethodImpl(INLINE)] get => new(x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xyy
        {
            [MethodImpl(INLINE)] get => new(x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yxx
        {
            [MethodImpl(INLINE)] get => new(y, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yxy
        {
            [MethodImpl(INLINE)] get => new(y, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yyx
        {
            [MethodImpl(INLINE)] get => new(y, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yyy
        {
            [MethodImpl(INLINE)] get => new(y, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 xx
        {
            [MethodImpl(INLINE)] get => new(x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 xy
        {
            [MethodImpl(INLINE)] get => new(x, y);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                y = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 yx
        {
            [MethodImpl(INLINE)] get => new(y, x);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                x = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 yy
        {
            [MethodImpl(INLINE)] get => new(y, y);
        }

        /// <summary>Returns the byte element at a specified index.</summary>
        unsafe public byte this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2) throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (byte2* array = &this)
                {
                    return ((byte*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2) throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (byte* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the byte2 is equal to a given byte2, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(INLINE)]
        public bool Equals(byte2 rhs) => x == rhs.x && y == rhs.y;

        /// <summary>Returns true if the byte2 is equal to a given byte2, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte2 converted && Equals(converted);

        /// <summary>Returns a hash code for the byte2.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(INLINE)]
        public override int GetHashCode() => (int)mathx.hash(this);

        /// <summary>Returns a string representation of the byte2.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public override string ToString() => $"byte2({x}, {y})";

        /// <summary>Returns a string representation of the byte2 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public string ToString(string format, IFormatProvider formatProvider) => $"byte2({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)})";

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;

            public DebuggerProxy(byte2 v)
            {
                x = v.x;
                y = v.y;
            }
        }
    }

    public static partial class mathx
    {
        /// <summary>Returns a byte2 vector constructed from two byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <returns>byte2 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(byte x, byte y) => new(x, y);

        /// <summary>Returns a byte2 vector constructed from a byte2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <returns>byte2 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(byte2 xy) => new(xy);

        /// <summary>Returns a byte2 vector constructed from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(byte v) => new(v);

        /// <summary>
        ///     Returns a byte2 vector constructed from a single float value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">float to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(float v) => new(v);

        /// <summary>Return a byte2 vector constructed from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(float2 v) => new(v);

        /// <summary>
        ///     Returns a byte2 vector constructed from a single double value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">double to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(double v) => new(v);

        /// <summary>Return a byte2 vector constructed from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte2 byte2(double2 v) => new(v);

        /// <summary>Returns a uint hash code of a byte2 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint hash(byte2 v) => csum(uint2(v.x, v.y) * uint2(0x6E624EB7u, 0x7383ED49u)) + 0xDD49C23Bu;

        /// <summary>
        ///     Returns a uint2 vector hash code of a byte2 vector.
        ///     When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        ///     that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint2 hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint2 hashwide(byte2 v)
        {
            return (uint2(v.x, v.y) * uint2(0xEBD0D005u, 0x91475DF7u)) + 0x55E84827u;
        }
    }
}