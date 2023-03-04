using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    /// <summary>A 4 component vector of bytes.</summary>
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte4 : IEquatable<byte4>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public byte x;

        /// <summary>y component of the vector.</summary>
        public byte y;

        /// <summary>z component of the vector.</summary>
        public byte z;

        /// <summary>w component of the vector.</summary>
        public byte w;

        /// <summary>byte4 zero value.</summary>
        public static readonly byte4 zero = 0;

        /// <summary>Constructs a byte4 vector from four byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte x, byte y, byte z, byte w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a byte4 vector from two byte values and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte x, byte y, byte2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a byte4 vector from a byte value, a byte2 vector and a byte value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte x, byte2 yz, byte w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a byte4 vector from a byte value and a byte3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte x, byte3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>Constructs a byte4 vector from a byte2 vector and two byte values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte2 xy, byte z, byte w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a byte4 vector from two byte2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte2 xy, byte2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a byte4 vector from a byte3 vector and a byte value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte3 xyz, byte w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a byte4 vector from a byte4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte4(byte4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        /// <summary>Constructs a byte4 vector from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(byte v)
        {
            x = v;
            y = v;
            z = v;
            w = v;
        }

        /// <summary>
        ///     Constructs a byte4 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(float v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
            w = (byte)v;
        }

        /// <summary>
        ///     Constructs a byte4 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(int v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
            w = (byte)v;
        }

        /// <summary>
        ///     Constructs a byte4 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(uint v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
            w = (byte)v;
        }

        /// <summary>Constructs a byte4 vector from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(float4 v)
        {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
            w = (byte)v.w;
        }

        /// <summary>
        ///     Constructs a byte4 vector from a single double value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(double v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
            w = (byte)v;
        }

        /// <summary>Constructs a byte4 vector from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to byte4</param>
        [MethodImpl(INLINE)]
        public byte4(double4 v)
        {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
            w = (byte)v.w;
        }

        /// <summary>Implicitly converts a single byte value to a byte4 vector by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static implicit operator byte4(byte v) => new(v);

        /// <summary>
        ///     Explicitly converts a single float value to a byte4 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte4(float v) => new(v);

        /// <summary>Explicitly converts a float4 vector to a byte4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte4(float4 v) => new(v);

        /// <summary>
        ///     Explicitly converts a single double value to a byte4 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte4(double v) => new(v);

        /// <summary>Explicitly converts a double4 vector to a byte4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte4(double4 v) => new(v);

        /// <summary>Returns the result of a componentwise equality operation on two byte4 vectors.</summary>
        /// <param name="lhs">Left hand side byte4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator ==(byte4 lhs, byte4 rhs) => new(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);

        /// <summary>Returns the result of a componentwise equality operation on a byte4 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator ==(byte4 lhs, byte rhs) => new(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);

        /// <summary>Returns the result of a componentwise equality operation on a byte value and a byte4 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator ==(byte lhs, byte4 rhs) => new(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);

        /// <summary>Returns the result of a componentwise not equal operation on two byte4 vectors.</summary>
        /// <param name="lhs">Left hand side byte4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator !=(byte4 lhs, byte4 rhs) => new(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);

        /// <summary>Returns the result of a componentwise not equal operation on a byte4 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator !=(byte4 lhs, byte rhs) => new(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);

        /// <summary>Returns the result of a componentwise not equal operation on a byte value and a byte4 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool4 operator !=(byte lhs, byte4 rhs) => new(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);

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
        [EditorBrowsable(NEVER)] public byte4 xxxz
        {
            [MethodImpl(INLINE)] get => new(x, x, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxxw
        {
            [MethodImpl(INLINE)] get => new(x, x, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyx
        {
            [MethodImpl(INLINE)] get => new(x, x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyy
        {
            [MethodImpl(INLINE)] get => new(x, x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyz
        {
            [MethodImpl(INLINE)] get => new(x, x, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxyw
        {
            [MethodImpl(INLINE)] get => new(x, x, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxzx
        {
            [MethodImpl(INLINE)] get => new(x, x, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxzy
        {
            [MethodImpl(INLINE)] get => new(x, x, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxzz
        {
            [MethodImpl(INLINE)] get => new(x, x, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxzw
        {
            [MethodImpl(INLINE)] get => new(x, x, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxwx
        {
            [MethodImpl(INLINE)] get => new(x, x, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxwy
        {
            [MethodImpl(INLINE)] get => new(x, x, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxwz
        {
            [MethodImpl(INLINE)] get => new(x, x, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xxww
        {
            [MethodImpl(INLINE)] get => new(x, x, w, w);
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
        [EditorBrowsable(NEVER)] public byte4 xyxz
        {
            [MethodImpl(INLINE)] get => new(x, y, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyxw
        {
            [MethodImpl(INLINE)] get => new(x, y, x, w);
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
        [EditorBrowsable(NEVER)] public byte4 xyyz
        {
            [MethodImpl(INLINE)] get => new(x, y, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyyw
        {
            [MethodImpl(INLINE)] get => new(x, y, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyzx
        {
            [MethodImpl(INLINE)] get => new(x, y, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyzy
        {
            [MethodImpl(INLINE)] get => new(x, y, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyzz
        {
            [MethodImpl(INLINE)] get => new(x, y, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyzw
        {
            [MethodImpl(INLINE)] get => new(x, y, z, w);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xywx
        {
            [MethodImpl(INLINE)] get => new(x, y, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xywy
        {
            [MethodImpl(INLINE)] get => new(x, y, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xywz
        {
            [MethodImpl(INLINE)] get => new(x, y, w, z);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xyww
        {
            [MethodImpl(INLINE)] get => new(x, y, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzxx
        {
            [MethodImpl(INLINE)] get => new(x, z, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzxy
        {
            [MethodImpl(INLINE)] get => new(x, z, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzxz
        {
            [MethodImpl(INLINE)] get => new(x, z, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzxw
        {
            [MethodImpl(INLINE)] get => new(x, z, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzyx
        {
            [MethodImpl(INLINE)] get => new(x, z, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzyy
        {
            [MethodImpl(INLINE)] get => new(x, z, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzyz
        {
            [MethodImpl(INLINE)] get => new(x, z, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzyw
        {
            [MethodImpl(INLINE)] get => new(x, z, y, w);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzzx
        {
            [MethodImpl(INLINE)] get => new(x, z, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzzy
        {
            [MethodImpl(INLINE)] get => new(x, z, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzzz
        {
            [MethodImpl(INLINE)] get => new(x, z, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzzw
        {
            [MethodImpl(INLINE)] get => new(x, z, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzwx
        {
            [MethodImpl(INLINE)] get => new(x, z, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzwy
        {
            [MethodImpl(INLINE)] get => new(x, z, w, y);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzwz
        {
            [MethodImpl(INLINE)] get => new(x, z, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xzww
        {
            [MethodImpl(INLINE)] get => new(x, z, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwxx
        {
            [MethodImpl(INLINE)] get => new(x, w, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwxy
        {
            [MethodImpl(INLINE)] get => new(x, w, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwxz
        {
            [MethodImpl(INLINE)] get => new(x, w, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwxw
        {
            [MethodImpl(INLINE)] get => new(x, w, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwyx
        {
            [MethodImpl(INLINE)] get => new(x, w, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwyy
        {
            [MethodImpl(INLINE)] get => new(x, w, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwyz
        {
            [MethodImpl(INLINE)] get => new(x, w, y, z);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwyw
        {
            [MethodImpl(INLINE)] get => new(x, w, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwzx
        {
            [MethodImpl(INLINE)] get => new(x, w, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwzy
        {
            [MethodImpl(INLINE)] get => new(x, w, z, y);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwzz
        {
            [MethodImpl(INLINE)] get => new(x, w, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwzw
        {
            [MethodImpl(INLINE)] get => new(x, w, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwwx
        {
            [MethodImpl(INLINE)] get => new(x, w, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwwy
        {
            [MethodImpl(INLINE)] get => new(x, w, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwwz
        {
            [MethodImpl(INLINE)] get => new(x, w, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 xwww
        {
            [MethodImpl(INLINE)] get => new(x, w, w, w);
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
        [EditorBrowsable(NEVER)] public byte4 yxxz
        {
            [MethodImpl(INLINE)] get => new(y, x, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxxw
        {
            [MethodImpl(INLINE)] get => new(y, x, x, w);
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
        [EditorBrowsable(NEVER)] public byte4 yxyz
        {
            [MethodImpl(INLINE)] get => new(y, x, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxyw
        {
            [MethodImpl(INLINE)] get => new(y, x, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxzx
        {
            [MethodImpl(INLINE)] get => new(y, x, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxzy
        {
            [MethodImpl(INLINE)] get => new(y, x, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxzz
        {
            [MethodImpl(INLINE)] get => new(y, x, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxzw
        {
            [MethodImpl(INLINE)] get => new(y, x, z, w);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxwx
        {
            [MethodImpl(INLINE)] get => new(y, x, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxwy
        {
            [MethodImpl(INLINE)] get => new(y, x, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxwz
        {
            [MethodImpl(INLINE)] get => new(y, x, w, z);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yxww
        {
            [MethodImpl(INLINE)] get => new(y, x, w, w);
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
        [EditorBrowsable(NEVER)] public byte4 yyxz
        {
            [MethodImpl(INLINE)] get => new(y, y, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyxw
        {
            [MethodImpl(INLINE)] get => new(y, y, x, w);
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
        [EditorBrowsable(NEVER)] public byte4 yyyz
        {
            [MethodImpl(INLINE)] get => new(y, y, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyyw
        {
            [MethodImpl(INLINE)] get => new(y, y, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyzx
        {
            [MethodImpl(INLINE)] get => new(y, y, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyzy
        {
            [MethodImpl(INLINE)] get => new(y, y, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyzz
        {
            [MethodImpl(INLINE)] get => new(y, y, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyzw
        {
            [MethodImpl(INLINE)] get => new(y, y, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yywx
        {
            [MethodImpl(INLINE)] get => new(y, y, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yywy
        {
            [MethodImpl(INLINE)] get => new(y, y, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yywz
        {
            [MethodImpl(INLINE)] get => new(y, y, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yyww
        {
            [MethodImpl(INLINE)] get => new(y, y, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzxx
        {
            [MethodImpl(INLINE)] get => new(y, z, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzxy
        {
            [MethodImpl(INLINE)] get => new(y, z, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzxz
        {
            [MethodImpl(INLINE)] get => new(y, z, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzxw
        {
            [MethodImpl(INLINE)] get => new(y, z, x, w);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzyx
        {
            [MethodImpl(INLINE)] get => new(y, z, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzyy
        {
            [MethodImpl(INLINE)] get => new(y, z, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzyz
        {
            [MethodImpl(INLINE)] get => new(y, z, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzyw
        {
            [MethodImpl(INLINE)] get => new(y, z, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzzx
        {
            [MethodImpl(INLINE)] get => new(y, z, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzzy
        {
            [MethodImpl(INLINE)] get => new(y, z, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzzz
        {
            [MethodImpl(INLINE)] get => new(y, z, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzzw
        {
            [MethodImpl(INLINE)] get => new(y, z, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzwx
        {
            [MethodImpl(INLINE)] get => new(y, z, w, x);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzwy
        {
            [MethodImpl(INLINE)] get => new(y, z, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzwz
        {
            [MethodImpl(INLINE)] get => new(y, z, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 yzww
        {
            [MethodImpl(INLINE)] get => new(y, z, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywxx
        {
            [MethodImpl(INLINE)] get => new(y, w, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywxy
        {
            [MethodImpl(INLINE)] get => new(y, w, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywxz
        {
            [MethodImpl(INLINE)] get => new(y, w, x, z);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywxw
        {
            [MethodImpl(INLINE)] get => new(y, w, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywyx
        {
            [MethodImpl(INLINE)] get => new(y, w, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywyy
        {
            [MethodImpl(INLINE)] get => new(y, w, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywyz
        {
            [MethodImpl(INLINE)] get => new(y, w, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywyw
        {
            [MethodImpl(INLINE)] get => new(y, w, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywzx
        {
            [MethodImpl(INLINE)] get => new(y, w, z, x);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywzy
        {
            [MethodImpl(INLINE)] get => new(y, w, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywzz
        {
            [MethodImpl(INLINE)] get => new(y, w, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywzw
        {
            [MethodImpl(INLINE)] get => new(y, w, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywwx
        {
            [MethodImpl(INLINE)] get => new(y, w, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywwy
        {
            [MethodImpl(INLINE)] get => new(y, w, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywwz
        {
            [MethodImpl(INLINE)] get => new(y, w, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 ywww
        {
            [MethodImpl(INLINE)] get => new(y, w, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxxx
        {
            [MethodImpl(INLINE)] get => new(z, x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxxy
        {
            [MethodImpl(INLINE)] get => new(z, x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxxz
        {
            [MethodImpl(INLINE)] get => new(z, x, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxxw
        {
            [MethodImpl(INLINE)] get => new(z, x, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxyx
        {
            [MethodImpl(INLINE)] get => new(z, x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxyy
        {
            [MethodImpl(INLINE)] get => new(z, x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxyz
        {
            [MethodImpl(INLINE)] get => new(z, x, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxyw
        {
            [MethodImpl(INLINE)] get => new(z, x, y, w);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxzx
        {
            [MethodImpl(INLINE)] get => new(z, x, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxzy
        {
            [MethodImpl(INLINE)] get => new(z, x, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxzz
        {
            [MethodImpl(INLINE)] get => new(z, x, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxzw
        {
            [MethodImpl(INLINE)] get => new(z, x, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxwx
        {
            [MethodImpl(INLINE)] get => new(z, x, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxwy
        {
            [MethodImpl(INLINE)] get => new(z, x, w, y);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxwz
        {
            [MethodImpl(INLINE)] get => new(z, x, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zxww
        {
            [MethodImpl(INLINE)] get => new(z, x, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyxx
        {
            [MethodImpl(INLINE)] get => new(z, y, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyxy
        {
            [MethodImpl(INLINE)] get => new(z, y, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyxz
        {
            [MethodImpl(INLINE)] get => new(z, y, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyxw
        {
            [MethodImpl(INLINE)] get => new(z, y, x, w);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyyx
        {
            [MethodImpl(INLINE)] get => new(z, y, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyyy
        {
            [MethodImpl(INLINE)] get => new(z, y, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyyz
        {
            [MethodImpl(INLINE)] get => new(z, y, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyyw
        {
            [MethodImpl(INLINE)] get => new(z, y, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyzx
        {
            [MethodImpl(INLINE)] get => new(z, y, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyzy
        {
            [MethodImpl(INLINE)] get => new(z, y, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyzz
        {
            [MethodImpl(INLINE)] get => new(z, y, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyzw
        {
            [MethodImpl(INLINE)] get => new(z, y, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zywx
        {
            [MethodImpl(INLINE)] get => new(z, y, w, x);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zywy
        {
            [MethodImpl(INLINE)] get => new(z, y, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zywz
        {
            [MethodImpl(INLINE)] get => new(z, y, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zyww
        {
            [MethodImpl(INLINE)] get => new(z, y, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzxx
        {
            [MethodImpl(INLINE)] get => new(z, z, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzxy
        {
            [MethodImpl(INLINE)] get => new(z, z, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzxz
        {
            [MethodImpl(INLINE)] get => new(z, z, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzxw
        {
            [MethodImpl(INLINE)] get => new(z, z, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzyx
        {
            [MethodImpl(INLINE)] get => new(z, z, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzyy
        {
            [MethodImpl(INLINE)] get => new(z, z, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzyz
        {
            [MethodImpl(INLINE)] get => new(z, z, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzyw
        {
            [MethodImpl(INLINE)] get => new(z, z, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzzx
        {
            [MethodImpl(INLINE)] get => new(z, z, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzzy
        {
            [MethodImpl(INLINE)] get => new(z, z, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzzz
        {
            [MethodImpl(INLINE)] get => new(z, z, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzzw
        {
            [MethodImpl(INLINE)] get => new(z, z, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzwx
        {
            [MethodImpl(INLINE)] get => new(z, z, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzwy
        {
            [MethodImpl(INLINE)] get => new(z, z, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzwz
        {
            [MethodImpl(INLINE)] get => new(z, z, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zzww
        {
            [MethodImpl(INLINE)] get => new(z, z, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwxx
        {
            [MethodImpl(INLINE)] get => new(z, w, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwxy
        {
            [MethodImpl(INLINE)] get => new(z, w, x, y);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwxz
        {
            [MethodImpl(INLINE)] get => new(z, w, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwxw
        {
            [MethodImpl(INLINE)] get => new(z, w, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwyx
        {
            [MethodImpl(INLINE)] get => new(z, w, y, x);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwyy
        {
            [MethodImpl(INLINE)] get => new(z, w, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwyz
        {
            [MethodImpl(INLINE)] get => new(z, w, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwyw
        {
            [MethodImpl(INLINE)] get => new(z, w, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwzx
        {
            [MethodImpl(INLINE)] get => new(z, w, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwzy
        {
            [MethodImpl(INLINE)] get => new(z, w, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwzz
        {
            [MethodImpl(INLINE)] get => new(z, w, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwzw
        {
            [MethodImpl(INLINE)] get => new(z, w, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwwx
        {
            [MethodImpl(INLINE)] get => new(z, w, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwwy
        {
            [MethodImpl(INLINE)] get => new(z, w, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwwz
        {
            [MethodImpl(INLINE)] get => new(z, w, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 zwww
        {
            [MethodImpl(INLINE)] get => new(z, w, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxxx
        {
            [MethodImpl(INLINE)] get => new(w, x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxxy
        {
            [MethodImpl(INLINE)] get => new(w, x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxxz
        {
            [MethodImpl(INLINE)] get => new(w, x, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxxw
        {
            [MethodImpl(INLINE)] get => new(w, x, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxyx
        {
            [MethodImpl(INLINE)] get => new(w, x, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxyy
        {
            [MethodImpl(INLINE)] get => new(w, x, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxyz
        {
            [MethodImpl(INLINE)] get => new(w, x, y, z);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxyw
        {
            [MethodImpl(INLINE)] get => new(w, x, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxzx
        {
            [MethodImpl(INLINE)] get => new(w, x, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxzy
        {
            [MethodImpl(INLINE)] get => new(w, x, z, y);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxzz
        {
            [MethodImpl(INLINE)] get => new(w, x, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxzw
        {
            [MethodImpl(INLINE)] get => new(w, x, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxwx
        {
            [MethodImpl(INLINE)] get => new(w, x, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxwy
        {
            [MethodImpl(INLINE)] get => new(w, x, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxwz
        {
            [MethodImpl(INLINE)] get => new(w, x, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wxww
        {
            [MethodImpl(INLINE)] get => new(w, x, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyxx
        {
            [MethodImpl(INLINE)] get => new(w, y, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyxy
        {
            [MethodImpl(INLINE)] get => new(w, y, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyxz
        {
            [MethodImpl(INLINE)] get => new(w, y, x, z);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyxw
        {
            [MethodImpl(INLINE)] get => new(w, y, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyyx
        {
            [MethodImpl(INLINE)] get => new(w, y, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyyy
        {
            [MethodImpl(INLINE)] get => new(w, y, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyyz
        {
            [MethodImpl(INLINE)] get => new(w, y, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyyw
        {
            [MethodImpl(INLINE)] get => new(w, y, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyzx
        {
            [MethodImpl(INLINE)] get => new(w, y, z, x);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyzy
        {
            [MethodImpl(INLINE)] get => new(w, y, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyzz
        {
            [MethodImpl(INLINE)] get => new(w, y, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyzw
        {
            [MethodImpl(INLINE)] get => new(w, y, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wywx
        {
            [MethodImpl(INLINE)] get => new(w, y, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wywy
        {
            [MethodImpl(INLINE)] get => new(w, y, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wywz
        {
            [MethodImpl(INLINE)] get => new(w, y, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wyww
        {
            [MethodImpl(INLINE)] get => new(w, y, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzxx
        {
            [MethodImpl(INLINE)] get => new(w, z, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzxy
        {
            [MethodImpl(INLINE)] get => new(w, z, x, y);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzxz
        {
            [MethodImpl(INLINE)] get => new(w, z, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzxw
        {
            [MethodImpl(INLINE)] get => new(w, z, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzyx
        {
            [MethodImpl(INLINE)] get => new(w, z, y, x);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzyy
        {
            [MethodImpl(INLINE)] get => new(w, z, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzyz
        {
            [MethodImpl(INLINE)] get => new(w, z, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzyw
        {
            [MethodImpl(INLINE)] get => new(w, z, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzzx
        {
            [MethodImpl(INLINE)] get => new(w, z, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzzy
        {
            [MethodImpl(INLINE)] get => new(w, z, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzzz
        {
            [MethodImpl(INLINE)] get => new(w, z, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzzw
        {
            [MethodImpl(INLINE)] get => new(w, z, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzwx
        {
            [MethodImpl(INLINE)] get => new(w, z, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzwy
        {
            [MethodImpl(INLINE)] get => new(w, z, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzwz
        {
            [MethodImpl(INLINE)] get => new(w, z, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wzww
        {
            [MethodImpl(INLINE)] get => new(w, z, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwxx
        {
            [MethodImpl(INLINE)] get => new(w, w, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwxy
        {
            [MethodImpl(INLINE)] get => new(w, w, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwxz
        {
            [MethodImpl(INLINE)] get => new(w, w, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwxw
        {
            [MethodImpl(INLINE)] get => new(w, w, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwyx
        {
            [MethodImpl(INLINE)] get => new(w, w, y, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwyy
        {
            [MethodImpl(INLINE)] get => new(w, w, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwyz
        {
            [MethodImpl(INLINE)] get => new(w, w, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwyw
        {
            [MethodImpl(INLINE)] get => new(w, w, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwzx
        {
            [MethodImpl(INLINE)] get => new(w, w, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwzy
        {
            [MethodImpl(INLINE)] get => new(w, w, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwzz
        {
            [MethodImpl(INLINE)] get => new(w, w, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwzw
        {
            [MethodImpl(INLINE)] get => new(w, w, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwwx
        {
            [MethodImpl(INLINE)] get => new(w, w, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwwy
        {
            [MethodImpl(INLINE)] get => new(w, w, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwwz
        {
            [MethodImpl(INLINE)] get => new(w, w, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte4 wwww
        {
            [MethodImpl(INLINE)] get => new(w, w, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxx
        {
            [MethodImpl(INLINE)] get => new(x, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxy
        {
            [MethodImpl(INLINE)] get => new(x, x, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxz
        {
            [MethodImpl(INLINE)] get => new(x, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xxw
        {
            [MethodImpl(INLINE)] get => new(x, x, w);
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
        [EditorBrowsable(NEVER)] public byte3 xyz
        {
            [MethodImpl(INLINE)] get => new(x, y, z);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xyw
        {
            [MethodImpl(INLINE)] get => new(x, y, w);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xzx
        {
            [MethodImpl(INLINE)] get => new(x, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xzy
        {
            [MethodImpl(INLINE)] get => new(x, z, y);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xzz
        {
            [MethodImpl(INLINE)] get => new(x, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xzw
        {
            [MethodImpl(INLINE)] get => new(x, z, w);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xwx
        {
            [MethodImpl(INLINE)] get => new(x, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xwy
        {
            [MethodImpl(INLINE)] get => new(x, w, y);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xwz
        {
            [MethodImpl(INLINE)] get => new(x, w, z);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 xww
        {
            [MethodImpl(INLINE)] get => new(x, w, w);
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
        [EditorBrowsable(NEVER)] public byte3 yxz
        {
            [MethodImpl(INLINE)] get => new(y, x, z);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yxw
        {
            [MethodImpl(INLINE)] get => new(y, x, w);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                x = value.y;
                w = value.z;
            }
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
        [EditorBrowsable(NEVER)] public byte3 yyz
        {
            [MethodImpl(INLINE)] get => new(y, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yyw
        {
            [MethodImpl(INLINE)] get => new(y, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yzx
        {
            [MethodImpl(INLINE)] get => new(y, z, x);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yzy
        {
            [MethodImpl(INLINE)] get => new(y, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yzz
        {
            [MethodImpl(INLINE)] get => new(y, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yzw
        {
            [MethodImpl(INLINE)] get => new(y, z, w);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 ywx
        {
            [MethodImpl(INLINE)] get => new(y, w, x);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 ywy
        {
            [MethodImpl(INLINE)] get => new(y, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 ywz
        {
            [MethodImpl(INLINE)] get => new(y, w, z);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 yww
        {
            [MethodImpl(INLINE)] get => new(y, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zxx
        {
            [MethodImpl(INLINE)] get => new(z, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zxy
        {
            [MethodImpl(INLINE)] get => new(z, x, y);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zxz
        {
            [MethodImpl(INLINE)] get => new(z, x, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zxw
        {
            [MethodImpl(INLINE)] get => new(z, x, w);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zyx
        {
            [MethodImpl(INLINE)] get => new(z, y, x);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zyy
        {
            [MethodImpl(INLINE)] get => new(z, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zyz
        {
            [MethodImpl(INLINE)] get => new(z, y, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zyw
        {
            [MethodImpl(INLINE)] get => new(z, y, w);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zzx
        {
            [MethodImpl(INLINE)] get => new(z, z, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zzy
        {
            [MethodImpl(INLINE)] get => new(z, z, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zzz
        {
            [MethodImpl(INLINE)] get => new(z, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zzw
        {
            [MethodImpl(INLINE)] get => new(z, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zwx
        {
            [MethodImpl(INLINE)] get => new(z, w, x);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zwy
        {
            [MethodImpl(INLINE)] get => new(z, w, y);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zwz
        {
            [MethodImpl(INLINE)] get => new(z, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 zww
        {
            [MethodImpl(INLINE)] get => new(z, w, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wxx
        {
            [MethodImpl(INLINE)] get => new(w, x, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wxy
        {
            [MethodImpl(INLINE)] get => new(w, x, y);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wxz
        {
            [MethodImpl(INLINE)] get => new(w, x, z);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wxw
        {
            [MethodImpl(INLINE)] get => new(w, x, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wyx
        {
            [MethodImpl(INLINE)] get => new(w, y, x);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wyy
        {
            [MethodImpl(INLINE)] get => new(w, y, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wyz
        {
            [MethodImpl(INLINE)] get => new(w, y, z);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wyw
        {
            [MethodImpl(INLINE)] get => new(w, y, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wzx
        {
            [MethodImpl(INLINE)] get => new(w, z, x);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wzy
        {
            [MethodImpl(INLINE)] get => new(w, z, y);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wzz
        {
            [MethodImpl(INLINE)] get => new(w, z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wzw
        {
            [MethodImpl(INLINE)] get => new(w, z, w);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wwx
        {
            [MethodImpl(INLINE)] get => new(w, w, x);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wwy
        {
            [MethodImpl(INLINE)] get => new(w, w, y);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 wwz
        {
            [MethodImpl(INLINE)] get => new(w, w, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte3 www
        {
            [MethodImpl(INLINE)] get => new(w, w, w);
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
        [EditorBrowsable(NEVER)] public byte2 xz
        {
            [MethodImpl(INLINE)] get => new(x, z);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                z = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 xw
        {
            [MethodImpl(INLINE)] get => new(x, w);
            [MethodImpl(INLINE)] set
            {
                x = value.x;
                w = value.y;
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

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 yz
        {
            [MethodImpl(INLINE)] get => new(y, z);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                z = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 yw
        {
            [MethodImpl(INLINE)] get => new(y, w);
            [MethodImpl(INLINE)] set
            {
                y = value.x;
                w = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 zx
        {
            [MethodImpl(INLINE)] get => new(z, x);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                x = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 zy
        {
            [MethodImpl(INLINE)] get => new(z, y);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                y = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 zz
        {
            [MethodImpl(INLINE)] get => new(z, z);
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 zw
        {
            [MethodImpl(INLINE)] get => new(z, w);
            [MethodImpl(INLINE)] set
            {
                z = value.x;
                w = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 wx
        {
            [MethodImpl(INLINE)] get => new(w, x);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                x = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 wy
        {
            [MethodImpl(INLINE)] get => new(w, y);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                y = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 wz
        {
            [MethodImpl(INLINE)] get => new(w, z);
            [MethodImpl(INLINE)] set
            {
                w = value.x;
                z = value.y;
            }
        }

        /// <summary>Swizzles the vector.</summary>
        [EditorBrowsable(NEVER)] public byte2 ww
        {
            [MethodImpl(INLINE)] get => new(w, w);
        }

        /// <summary>Returns the byte element at a specified index.</summary>
        public unsafe byte this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (byte4* array = &this)
                {
                    return ((byte*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (byte* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the byte4 is equal to a given byte4, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(INLINE)]
        public bool Equals(byte4 rhs) => x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w;

        /// <summary>Returns true if the byte4 is equal to a given byte4, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte4 converted && Equals(converted);

        /// <summary>Returns a hash code for the byte4.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(INLINE)]
        public override int GetHashCode() => (int)hash(this);

        /// <summary>Returns a string representation of the byte4.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public override string ToString() => string.Format("byte4({0}, {1}, {2}, {3})", x, y, z, w);

        /// <summary>Returns a string representation of the byte4 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public string ToString(string format, IFormatProvider formatProvider) => string.Format("byte4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public byte z;
            public byte w;

            public DebuggerProxy(byte4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }
    }

    public static partial class mathx
    {
        /// <summary>Returns a byte4 vector constructed from four byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte x, byte y, byte z, byte w) => new(x, y, z, w);

        /// <summary>Returns a byte4 vector constructed from two byte values and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte x, byte y, byte2 zw) => new(x, y, zw);

        /// <summary>Returns a byte4 vector constructed from a byte value, a byte2 vector and a byte value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte x, byte2 yz, byte w) => new(x, yz, w);

        /// <summary>Returns a byte4 vector constructed from a byte value and a byte3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte x, byte3 yzw) => new(x, yzw);

        /// <summary>Returns a byte4 vector constructed from a byte2 vector and two byte values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte2 xy, byte z, byte w) => new(xy, z, w);

        /// <summary>Returns a byte4 vector constructed from two byte2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte2 xy, byte2 zw) => new(xy, zw);

        /// <summary>Returns a byte4 vector constructed from a byte3 vector and a byte value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte3 xyz, byte w) => new(xyz, w);

        /// <summary>Returns a byte4 vector constructed from a byte4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte4 xyzw) => new(xyzw);

        /// <summary>Returns a byte4 vector constructed from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(byte v) => new(v);

        /// <summary>
        ///     Returns a byte4 vector constructed from a single float value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">float to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(float v) => new(v);

        /// <summary>Return a byte4 vector constructed from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(float4 v) => new(v);

        /// <summary>
        ///     Returns a byte4 vector constructed from a single double value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">double to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(double v) => new(v);

        /// <summary>Return a byte4 vector constructed from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte4 byte4(double4 v) => new(v);

        /// <summary>Returns a uint hash code of a byte4 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint hash(byte4 v) => csum(uint4(v.x, v.y, v.z, v.w) * uint4(0x745ED837u, 0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu)) + 0x68EEE0F5u;

        /// <summary>
        ///     Returns a uint4 vector hash code of a byte4 vector.
        ///     When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        ///     that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint4 hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint4 hashwide(byte4 v) => uint4(v.x, v.y, v.z, v.w) * uint4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u) + 0xFC104C3Bu;
    }
}