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
    /// A 4 component vector of bytes.
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte4 : IEquatable<byte4>, IFormattable
    {
        /// x component of the vector.
        public byte1 x;

        /// y component of the vector.
        public byte1 y;

        /// z component of the vector.
        public byte1 z;

        /// w component of the vector.
        public byte1 w;

        /// byte4 zero value.
        public static readonly byte4 zero = 0;

        /// Constructs a byte4 vector from four byte1 values.
        [MethodImpl(INLINE)] public byte4(byte1 x, byte1 y, byte1 z, byte1 w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// Constructs a byte4 vector from four byte1 values.
        [MethodImpl(INLINE)] public byte4(int x, int y, int z, int w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// Constructs a byte4 vector from two byte1 values and a byte2 vector.
        [MethodImpl(INLINE)] public byte4(byte1 x, byte1 y, byte2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        /// Constructs a byte4 vector from a byte1 value, a byte2 vector and a byte1 value.
        [MethodImpl(INLINE)] public byte4(byte1 x, byte2 yz, byte1 w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        /// Constructs a byte4 vector from a byte1 value and a byte3 vector.
        [MethodImpl(INLINE)] public byte4(byte1 x, byte3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        /// Constructs a byte4 vector from a byte2 vector and two byte1 values.
        [MethodImpl(INLINE)] public byte4(byte2 xy, byte1 z, byte1 w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        /// Constructs a byte4 vector from two byte2 vectors.
        [MethodImpl(INLINE)] public byte4(byte2 xy, byte2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        /// Constructs a byte4 vector from a byte3 vector and a byte1 value.
        [MethodImpl(INLINE)] public byte4(byte3 xyz, byte1 w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        /// Constructs a byte4 vector from a byte4 vector.
        [MethodImpl(INLINE)] public byte4(byte4 xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        /// Constructs a byte4 vector from a single byte1 value by assigning it to every component.
        [MethodImpl(INLINE)] public byte4(byte1 v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        ///     Constructs a byte4 vector from a single float value by converting it to byte1 and assigning it to every
        ///     component.
        [MethodImpl(INLINE)] public byte4(float v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        ///     Constructs a byte4 vector from a single float value by converting it to byte1 and assigning it to every
        ///     component.
        [MethodImpl(INLINE)] public byte4(int v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        ///     Constructs a byte4 vector from a single float value by converting it to byte1 and assigning it to every
        ///     component.
        [MethodImpl(INLINE)] public byte4(uint v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        /// Constructs a byte4 vector from a f4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public byte4(float4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        ///     Constructs a byte4 vector from a single double value by converting it to byte1 and assigning it to every
        ///     component.
        [MethodImpl(INLINE)] public byte4(double v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        /// Constructs a byte4 vector from a double4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public byte4(double4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        
        /// Implicitly converts a single byte1 value to a byte4 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte4(byte1 v) => new(v);
        /// Implicitly converts a single int value to a byte4 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte4(int v) => new(v);
        /// Implicitly converts a single byte1 value to a byte4 vector by assigning it to every component.
        [MethodImpl(INLINE)] public static implicit operator byte4(uint v) => new(v);
        
        /// Explicitly converts a single float value to a byte4 vector by converting it to byte1 and assigning it to every component.
        [MethodImpl(INLINE)] public static explicit operator byte4(float v) => new(v);
        /// Explicitly converts a f4 vector to a byte4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static explicit operator byte4(float4 v) => new(v);
        /// Explicitly converts a single double value to a byte4 vector by converting it to byte1 and assigning it to every component.
        [MethodImpl(INLINE)] public static explicit operator byte4(double v) => new(v);
        /// Explicitly converts a double4 vector to a byte4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static explicit operator byte4(double4 v) => new(v);
        /// Explicitly converts a double4 vector to a byte4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static implicit operator uint4(byte4 v) => new(v.x, v.y, v.z, v.w);


        /// Returns the result of a componentwise equality operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator ==(byte4 lhs, byte4 rhs) => new(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        /// Returns the result of a componentwise equality operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator ==(byte4 lhs, byte1 rhs) => new(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        /// Returns the result of a componentwise equality operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator ==(byte1 lhs, byte4 rhs) => new(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// Returns the result of a componentwise not equal operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator !=(byte4 lhs, byte4 rhs) => new(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        /// Returns the result of a componentwise not equal operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator !=(byte4 lhs, byte1 rhs) => new(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        /// Returns the result of a componentwise not equal operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator !=(byte1 lhs, byte4 rhs) => new(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        

        /// Returns the result of a componentwise multiplication into an int4 vector.
        [MethodImpl(INLINE)] public static int4 operator *(byte4 lhs, byte4 rhs) => new(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        /// <inheritdoc cref="operator *(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator *(byte4 lhs, byte1 rhs) => new(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        /// <inheritdoc cref="operator *(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator *(byte1 lhs, byte4 rhs) => new(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// Returns the result of a componentwise addition into an int4 vector.
        [MethodImpl(INLINE)] public static int4 operator +(byte4 lhs, byte4 rhs) => new(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        /// <inheritdoc cref="operator +(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator +(byte4 lhs, byte1 rhs) => new(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        /// <inheritdoc cref="operator +(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator +(byte1 lhs, byte4 rhs) => new(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// Returns the result of a componentwise subtraction into an int4 vector.
        [MethodImpl(INLINE)] public static int4 operator -(byte4 lhs, byte4 rhs) => new(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        /// <inheritdoc cref="operator -(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator -(byte4 lhs, byte1 rhs) => new(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        /// <inheritdoc cref="operator -(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static int4 operator -(byte1 lhs, byte4 rhs) => new(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// Returns the result of a componentwise division into an f4 vector.
        [MethodImpl(INLINE)] public static float4 operator /(byte4 lhs, byte4 rhs) => new(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        /// <inheritdoc cref="operator /(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static float4 operator /(byte4 lhs, byte1 rhs) => new(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        /// <inheritdoc cref="operator /(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static float4 operator /(byte1 lhs, byte4 rhs) => new(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// Returns the result of a componentwise modulus operation into an byte4 vector.
        [MethodImpl(INLINE)] public static byte4 operator %(byte4 lhs, byte4 rhs) => new(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        /// <inheritdoc cref="operator %(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static byte4 operator %(byte4 lhs, byte1 rhs) => new(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        /// <inheritdoc cref="operator %(byte4, byte4)"/>
        [MethodImpl(INLINE)] public static byte4 operator %(byte1 lhs, byte4 rhs) => new(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// Adds one to each component of the byte4 vector.
        [MethodImpl(INLINE)] public static byte4 operator ++(byte4 val) => new(++val.x, ++val.y, ++val.z, ++val.w);
        ///Subtracts one from each component of the byte4 vector.
        [MethodImpl(INLINE)] public static byte4 operator --(byte4 val) => new(--val.x, --val.y, --val.z, --val.w);
        
        /// Returns the result of a componentwise less than operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator <(byte4 lhs, byte4 rhs) => new(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        /// Returns the result of a componentwise less than operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator <(byte4 lhs, byte1 rhs) => new(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        /// Returns the result of a componentwise less than operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator <(byte1 lhs, byte4 rhs) => new(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// Returns the result of a componentwise less or equal operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator <=(byte4 lhs, byte4 rhs) => new(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        /// Returns the result of a componentwise less or equal operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator <=(byte4 lhs, byte1 rhs) => new(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        /// Returns the result of a componentwise less or equal operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator <=(byte1 lhs, byte4 rhs) => new(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
      
        /// Returns the result of a componentwise greater than operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator >(byte4 lhs, byte4 rhs) => new(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        /// Returns the result of a componentwise greater than operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator >(byte4 lhs, byte1 rhs) => new(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        /// Returns the result of a componentwise greater than operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator >(byte1 lhs, byte4 rhs) => new(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// Returns the result of a componentwise greater or equal operation on two byte4 vectors.
        [MethodImpl(INLINE)] public static bool4 operator >=(byte4 lhs, byte4 rhs) => new(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        /// Returns the result of a componentwise greater or equal operation on a byte4 vector and a byte1 value.
        [MethodImpl(INLINE)] public static bool4 operator >=(byte4 lhs, byte1 rhs) => new(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        /// Returns the result of a componentwise greater or equal operation on a byte1 value and a byte4 vector.
        [MethodImpl(INLINE)] public static bool4 operator >=(byte1 lhs, byte4 rhs) => new(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
       
        /// Returns the result of a componentwise unary minus operation on a byte4 vector.
        [MethodImpl(INLINE)] public static byte4 operator -(byte4 v) => new(-v.x, -v.y, -v.z, -v.w);
        /// Returns the result of a componentwise unary plus operation on a byte4 vector.
        [MethodImpl(INLINE)] public static byte4 operator +(byte4 v) => new(+v.x, +v.y, +v.z, +v.w);

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxx { [MethodImpl(INLINE)] get => new(x, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxy { [MethodImpl(INLINE)] get => new(x, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxz { [MethodImpl(INLINE)] get => new(x, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxw { [MethodImpl(INLINE)] get => new(x, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyx { [MethodImpl(INLINE)] get => new(x, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyy { [MethodImpl(INLINE)] get => new(x, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyz { [MethodImpl(INLINE)] get => new(x, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyw { [MethodImpl(INLINE)] get => new(x, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzx { [MethodImpl(INLINE)] get => new(x, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzy { [MethodImpl(INLINE)] get => new(x, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzz { [MethodImpl(INLINE)] get => new(x, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzw { [MethodImpl(INLINE)] get => new(x, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwx { [MethodImpl(INLINE)] get => new(x, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwy { [MethodImpl(INLINE)] get => new(x, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwz { [MethodImpl(INLINE)] get => new(x, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxww { [MethodImpl(INLINE)] get => new(x, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxx { [MethodImpl(INLINE)] get => new(x, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxy { [MethodImpl(INLINE)] get => new(x, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxz { [MethodImpl(INLINE)] get => new(x, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxw { [MethodImpl(INLINE)] get => new(x, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyx { [MethodImpl(INLINE)] get => new(x, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyy { [MethodImpl(INLINE)] get => new(x, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyz { [MethodImpl(INLINE)] get => new(x, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyw { [MethodImpl(INLINE)] get => new(x, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzx { [MethodImpl(INLINE)] get => new(x, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzy { [MethodImpl(INLINE)] get => new(x, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzz { [MethodImpl(INLINE)] get => new(x, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzw
        {
            [MethodImpl(INLINE)] get => new(x, y, z, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywx { [MethodImpl(INLINE)] get => new(x, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywy { [MethodImpl(INLINE)] get => new(x, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywz
        {
            [MethodImpl(INLINE)] get => new(x, y, w, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyww { [MethodImpl(INLINE)] get => new(x, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxx { [MethodImpl(INLINE)] get => new(x, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxy { [MethodImpl(INLINE)] get => new(x, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxz { [MethodImpl(INLINE)] get => new(x, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxw { [MethodImpl(INLINE)] get => new(x, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyx { [MethodImpl(INLINE)] get => new(x, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyy { [MethodImpl(INLINE)] get => new(x, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyz { [MethodImpl(INLINE)] get => new(x, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyw
        {
            [MethodImpl(INLINE)] get => new(x, z, y, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzx { [MethodImpl(INLINE)] get => new(x, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzy { [MethodImpl(INLINE)] get => new(x, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzz { [MethodImpl(INLINE)] get => new(x, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzw { [MethodImpl(INLINE)] get => new(x, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwx { [MethodImpl(INLINE)] get => new(x, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwy
        {
            [MethodImpl(INLINE)] get => new(x, z, w, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwz { [MethodImpl(INLINE)] get => new(x, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzww { [MethodImpl(INLINE)] get => new(x, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxx { [MethodImpl(INLINE)] get => new(x, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxy { [MethodImpl(INLINE)] get => new(x, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxz { [MethodImpl(INLINE)] get => new(x, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxw { [MethodImpl(INLINE)] get => new(x, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyx { [MethodImpl(INLINE)] get => new(x, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyy { [MethodImpl(INLINE)] get => new(x, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyz
        {
            [MethodImpl(INLINE)] get => new(x, w, y, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyw { [MethodImpl(INLINE)] get => new(x, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzx { [MethodImpl(INLINE)] get => new(x, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzy
        {
            [MethodImpl(INLINE)] get => new(x, w, z, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzz { [MethodImpl(INLINE)] get => new(x, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzw { [MethodImpl(INLINE)] get => new(x, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwx { [MethodImpl(INLINE)] get => new(x, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwy { [MethodImpl(INLINE)] get => new(x, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwz { [MethodImpl(INLINE)] get => new(x, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwww { [MethodImpl(INLINE)] get => new(x, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxx { [MethodImpl(INLINE)] get => new(y, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxy { [MethodImpl(INLINE)] get => new(y, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxz { [MethodImpl(INLINE)] get => new(y, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxw { [MethodImpl(INLINE)] get => new(y, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyx { [MethodImpl(INLINE)] get => new(y, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyy { [MethodImpl(INLINE)] get => new(y, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyz { [MethodImpl(INLINE)] get => new(y, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyw { [MethodImpl(INLINE)] get => new(y, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzx { [MethodImpl(INLINE)] get => new(y, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzy { [MethodImpl(INLINE)] get => new(y, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzz { [MethodImpl(INLINE)] get => new(y, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzw
        {
            [MethodImpl(INLINE)] get => new(y, x, z, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwx { [MethodImpl(INLINE)] get => new(y, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwy { [MethodImpl(INLINE)] get => new(y, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwz
        {
            [MethodImpl(INLINE)] get => new(y, x, w, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxww { [MethodImpl(INLINE)] get => new(y, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxx { [MethodImpl(INLINE)] get => new(y, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxy { [MethodImpl(INLINE)] get => new(y, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxz { [MethodImpl(INLINE)] get => new(y, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxw { [MethodImpl(INLINE)] get => new(y, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyx { [MethodImpl(INLINE)] get => new(y, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyy { [MethodImpl(INLINE)] get => new(y, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyz { [MethodImpl(INLINE)] get => new(y, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyw { [MethodImpl(INLINE)] get => new(y, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzx { [MethodImpl(INLINE)] get => new(y, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzy { [MethodImpl(INLINE)] get => new(y, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzz { [MethodImpl(INLINE)] get => new(y, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzw { [MethodImpl(INLINE)] get => new(y, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywx { [MethodImpl(INLINE)] get => new(y, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywy { [MethodImpl(INLINE)] get => new(y, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywz { [MethodImpl(INLINE)] get => new(y, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyww { [MethodImpl(INLINE)] get => new(y, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxx { [MethodImpl(INLINE)] get => new(y, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxy { [MethodImpl(INLINE)] get => new(y, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxz { [MethodImpl(INLINE)] get => new(y, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxw
        {
            [MethodImpl(INLINE)] get => new(y, z, x, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyx { [MethodImpl(INLINE)] get => new(y, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyy { [MethodImpl(INLINE)] get => new(y, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyz { [MethodImpl(INLINE)] get => new(y, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyw { [MethodImpl(INLINE)] get => new(y, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzx { [MethodImpl(INLINE)] get => new(y, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzy { [MethodImpl(INLINE)] get => new(y, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzz { [MethodImpl(INLINE)] get => new(y, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzw { [MethodImpl(INLINE)] get => new(y, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwx
        {
            [MethodImpl(INLINE)] get => new(y, z, w, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwy { [MethodImpl(INLINE)] get => new(y, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwz { [MethodImpl(INLINE)] get => new(y, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzww { [MethodImpl(INLINE)] get => new(y, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxx { [MethodImpl(INLINE)] get => new(y, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxy { [MethodImpl(INLINE)] get => new(y, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxz
        {
            [MethodImpl(INLINE)] get => new(y, w, x, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxw { [MethodImpl(INLINE)] get => new(y, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyx { [MethodImpl(INLINE)] get => new(y, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyy { [MethodImpl(INLINE)] get => new(y, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyz { [MethodImpl(INLINE)] get => new(y, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyw { [MethodImpl(INLINE)] get => new(y, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzx
        {
            [MethodImpl(INLINE)] get => new(y, w, z, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzy { [MethodImpl(INLINE)] get => new(y, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzz { [MethodImpl(INLINE)] get => new(y, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzw { [MethodImpl(INLINE)] get => new(y, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwx { [MethodImpl(INLINE)] get => new(y, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwy { [MethodImpl(INLINE)] get => new(y, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwz { [MethodImpl(INLINE)] get => new(y, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywww { [MethodImpl(INLINE)] get => new(y, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxx { [MethodImpl(INLINE)] get => new(z, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxy { [MethodImpl(INLINE)] get => new(z, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxz { [MethodImpl(INLINE)] get => new(z, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxw { [MethodImpl(INLINE)] get => new(z, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyx { [MethodImpl(INLINE)] get => new(z, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyy { [MethodImpl(INLINE)] get => new(z, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyz { [MethodImpl(INLINE)] get => new(z, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyw
        {
            [MethodImpl(INLINE)] get => new(z, x, y, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzx { [MethodImpl(INLINE)] get => new(z, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzy { [MethodImpl(INLINE)] get => new(z, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzz { [MethodImpl(INLINE)] get => new(z, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzw { [MethodImpl(INLINE)] get => new(z, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwx { [MethodImpl(INLINE)] get => new(z, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwy
        {
            [MethodImpl(INLINE)] get => new(z, x, w, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwz { [MethodImpl(INLINE)] get => new(z, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxww { [MethodImpl(INLINE)] get => new(z, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxx { [MethodImpl(INLINE)] get => new(z, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxy { [MethodImpl(INLINE)] get => new(z, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxz { [MethodImpl(INLINE)] get => new(z, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxw
        {
            [MethodImpl(INLINE)] get => new(z, y, x, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyx { [MethodImpl(INLINE)] get => new(z, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyy { [MethodImpl(INLINE)] get => new(z, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyz { [MethodImpl(INLINE)] get => new(z, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyw { [MethodImpl(INLINE)] get => new(z, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzx { [MethodImpl(INLINE)] get => new(z, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzy { [MethodImpl(INLINE)] get => new(z, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzz { [MethodImpl(INLINE)] get => new(z, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzw { [MethodImpl(INLINE)] get => new(z, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywx
        {
            [MethodImpl(INLINE)] get => new(z, y, w, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywy { [MethodImpl(INLINE)] get => new(z, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywz { [MethodImpl(INLINE)] get => new(z, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyww { [MethodImpl(INLINE)] get => new(z, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxx { [MethodImpl(INLINE)] get => new(z, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxy { [MethodImpl(INLINE)] get => new(z, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxz { [MethodImpl(INLINE)] get => new(z, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxw { [MethodImpl(INLINE)] get => new(z, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyx { [MethodImpl(INLINE)] get => new(z, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyy { [MethodImpl(INLINE)] get => new(z, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyz { [MethodImpl(INLINE)] get => new(z, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyw { [MethodImpl(INLINE)] get => new(z, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzx { [MethodImpl(INLINE)] get => new(z, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzy { [MethodImpl(INLINE)] get => new(z, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzz { [MethodImpl(INLINE)] get => new(z, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzw { [MethodImpl(INLINE)] get => new(z, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwx { [MethodImpl(INLINE)] get => new(z, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwy { [MethodImpl(INLINE)] get => new(z, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwz { [MethodImpl(INLINE)] get => new(z, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzww { [MethodImpl(INLINE)] get => new(z, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxx { [MethodImpl(INLINE)] get => new(z, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxy
        {
            [MethodImpl(INLINE)] get => new(z, w, x, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxz { [MethodImpl(INLINE)] get => new(z, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxw { [MethodImpl(INLINE)] get => new(z, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyx
        {
            [MethodImpl(INLINE)] get => new(z, w, y, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyy { [MethodImpl(INLINE)] get => new(z, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyz { [MethodImpl(INLINE)] get => new(z, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyw { [MethodImpl(INLINE)] get => new(z, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzx { [MethodImpl(INLINE)] get => new(z, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzy { [MethodImpl(INLINE)] get => new(z, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzz { [MethodImpl(INLINE)] get => new(z, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzw { [MethodImpl(INLINE)] get => new(z, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwx { [MethodImpl(INLINE)] get => new(z, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwy { [MethodImpl(INLINE)] get => new(z, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwz { [MethodImpl(INLINE)] get => new(z, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwww { [MethodImpl(INLINE)] get => new(z, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxx { [MethodImpl(INLINE)] get => new(w, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxy { [MethodImpl(INLINE)] get => new(w, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxz { [MethodImpl(INLINE)] get => new(w, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxw { [MethodImpl(INLINE)] get => new(w, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyx { [MethodImpl(INLINE)] get => new(w, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyy { [MethodImpl(INLINE)] get => new(w, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyz
        {
            [MethodImpl(INLINE)] get => new(w, x, y, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyw { [MethodImpl(INLINE)] get => new(w, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzx { [MethodImpl(INLINE)] get => new(w, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzy
        {
            [MethodImpl(INLINE)] get => new(w, x, z, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzz { [MethodImpl(INLINE)] get => new(w, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzw { [MethodImpl(INLINE)] get => new(w, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwx { [MethodImpl(INLINE)] get => new(w, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwy { [MethodImpl(INLINE)] get => new(w, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwz { [MethodImpl(INLINE)] get => new(w, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxww { [MethodImpl(INLINE)] get => new(w, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxx { [MethodImpl(INLINE)] get => new(w, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxy { [MethodImpl(INLINE)] get => new(w, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxz
        {
            [MethodImpl(INLINE)] get => new(w, y, x, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxw { [MethodImpl(INLINE)] get => new(w, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyx { [MethodImpl(INLINE)] get => new(w, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyy { [MethodImpl(INLINE)] get => new(w, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyz { [MethodImpl(INLINE)] get => new(w, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyw { [MethodImpl(INLINE)] get => new(w, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzx
        {
            [MethodImpl(INLINE)] get => new(w, y, z, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzy { [MethodImpl(INLINE)] get => new(w, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzz { [MethodImpl(INLINE)] get => new(w, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzw { [MethodImpl(INLINE)] get => new(w, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywx { [MethodImpl(INLINE)] get => new(w, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywy { [MethodImpl(INLINE)] get => new(w, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywz { [MethodImpl(INLINE)] get => new(w, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyww { [MethodImpl(INLINE)] get => new(w, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxx { [MethodImpl(INLINE)] get => new(w, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxy
        {
            [MethodImpl(INLINE)] get => new(w, z, x, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxz { [MethodImpl(INLINE)] get => new(w, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxw { [MethodImpl(INLINE)] get => new(w, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyx
        {
            [MethodImpl(INLINE)] get => new(w, z, y, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyy { [MethodImpl(INLINE)] get => new(w, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyz { [MethodImpl(INLINE)] get => new(w, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyw { [MethodImpl(INLINE)] get => new(w, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzx { [MethodImpl(INLINE)] get => new(w, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzy { [MethodImpl(INLINE)] get => new(w, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzz { [MethodImpl(INLINE)] get => new(w, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzw { [MethodImpl(INLINE)] get => new(w, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwx { [MethodImpl(INLINE)] get => new(w, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwy { [MethodImpl(INLINE)] get => new(w, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwz { [MethodImpl(INLINE)] get => new(w, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzww { [MethodImpl(INLINE)] get => new(w, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxx { [MethodImpl(INLINE)] get => new(w, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxy { [MethodImpl(INLINE)] get => new(w, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxz { [MethodImpl(INLINE)] get => new(w, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxw { [MethodImpl(INLINE)] get => new(w, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyx { [MethodImpl(INLINE)] get => new(w, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyy { [MethodImpl(INLINE)] get => new(w, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyz { [MethodImpl(INLINE)] get => new(w, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyw { [MethodImpl(INLINE)] get => new(w, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzx { [MethodImpl(INLINE)] get => new(w, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzy { [MethodImpl(INLINE)] get => new(w, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzz { [MethodImpl(INLINE)] get => new(w, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzw { [MethodImpl(INLINE)] get => new(w, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwx { [MethodImpl(INLINE)] get => new(w, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwy { [MethodImpl(INLINE)] get => new(w, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwz { [MethodImpl(INLINE)] get => new(w, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwww { [MethodImpl(INLINE)] get => new(w, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxx { [MethodImpl(INLINE)] get => new(x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxy { [MethodImpl(INLINE)] get => new(x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxz { [MethodImpl(INLINE)] get => new(x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxw { [MethodImpl(INLINE)] get => new(x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyx { [MethodImpl(INLINE)] get => new(x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyy { [MethodImpl(INLINE)] get => new(x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyz
        {
            [MethodImpl(INLINE)] get => new(x, y, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyw
        {
            [MethodImpl(INLINE)] get => new(x, y, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzx { [MethodImpl(INLINE)] get => new(x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzy
        {
            [MethodImpl(INLINE)] get => new(x, z, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzz { [MethodImpl(INLINE)] get => new(x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzw
        {
            [MethodImpl(INLINE)] get => new(x, z, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwx { [MethodImpl(INLINE)] get => new(x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwy
        {
            [MethodImpl(INLINE)] get => new(x, w, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwz
        {
            [MethodImpl(INLINE)] get => new(x, w, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xww { [MethodImpl(INLINE)] get => new(x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxx { [MethodImpl(INLINE)] get => new(y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxy { [MethodImpl(INLINE)] get => new(y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxz
        {
            [MethodImpl(INLINE)] get => new(y, x, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxw
        {
            [MethodImpl(INLINE)] get => new(y, x, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyx { [MethodImpl(INLINE)] get => new(y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyy { [MethodImpl(INLINE)] get => new(y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyz { [MethodImpl(INLINE)] get => new(y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyw { [MethodImpl(INLINE)] get => new(y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzx
        {
            [MethodImpl(INLINE)] get => new(y, z, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzy { [MethodImpl(INLINE)] get => new(y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzz { [MethodImpl(INLINE)] get => new(y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzw
        {
            [MethodImpl(INLINE)] get => new(y, z, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywx
        {
            [MethodImpl(INLINE)] get => new(y, w, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywy { [MethodImpl(INLINE)] get => new(y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywz
        {
            [MethodImpl(INLINE)] get => new(y, w, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yww { [MethodImpl(INLINE)] get => new(y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxx { [MethodImpl(INLINE)] get => new(z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxy
        {
            [MethodImpl(INLINE)] get => new(z, x, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxz { [MethodImpl(INLINE)] get => new(z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxw
        {
            [MethodImpl(INLINE)] get => new(z, x, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyx
        {
            [MethodImpl(INLINE)] get => new(z, y, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyy { [MethodImpl(INLINE)] get => new(z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyz { [MethodImpl(INLINE)] get => new(z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyw
        {
            [MethodImpl(INLINE)] get => new(z, y, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzx { [MethodImpl(INLINE)] get => new(z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzy { [MethodImpl(INLINE)] get => new(z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzz { [MethodImpl(INLINE)] get => new(z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzw { [MethodImpl(INLINE)] get => new(z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwx
        {
            [MethodImpl(INLINE)] get => new(z, w, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwy
        {
            [MethodImpl(INLINE)] get => new(z, w, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwz { [MethodImpl(INLINE)] get => new(z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zww { [MethodImpl(INLINE)] get => new(z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxx { [MethodImpl(INLINE)] get => new(w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxy
        {
            [MethodImpl(INLINE)] get => new(w, x, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxz
        {
            [MethodImpl(INLINE)] get => new(w, x, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxw { [MethodImpl(INLINE)] get => new(w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyx
        {
            [MethodImpl(INLINE)] get => new(w, y, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyy { [MethodImpl(INLINE)] get => new(w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyz
        {
            [MethodImpl(INLINE)] get => new(w, y, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyw { [MethodImpl(INLINE)] get => new(w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzx
        {
            [MethodImpl(INLINE)] get => new(w, z, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzy
        {
            [MethodImpl(INLINE)] get => new(w, z, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzz { [MethodImpl(INLINE)] get => new(w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzw { [MethodImpl(INLINE)] get => new(w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwx { [MethodImpl(INLINE)] get => new(w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwy { [MethodImpl(INLINE)] get => new(w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwz { [MethodImpl(INLINE)] get => new(w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 www { [MethodImpl(INLINE)] get => new(w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xx { [MethodImpl(INLINE)] get => new(x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xy
        {
            [MethodImpl(INLINE)] get => new(x, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xz
        {
            [MethodImpl(INLINE)] get => new(x, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xw
        {
            [MethodImpl(INLINE)] get => new(x, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yx
        {
            [MethodImpl(INLINE)] get => new(y, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yy { [MethodImpl(INLINE)] get => new(y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yz
        {
            [MethodImpl(INLINE)] get => new(y, z);
            [MethodImpl(INLINE)] set {
                y = value.x; 
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yw
        {
            [MethodImpl(INLINE)] get => new(y, w);
            [MethodImpl(INLINE)] set {
                y = value.x; 
                w = value.y; 
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zx
        {
            [MethodImpl(INLINE)] get => new(z, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zy
        {
            [MethodImpl(INLINE)] get => new(z, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zz { [MethodImpl(INLINE)] get => new(z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zw
        {
            [MethodImpl(INLINE)] get => new(z, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wx
        {
            [MethodImpl(INLINE)] get => new(w, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wy
        {
            [MethodImpl(INLINE)] get => new(w, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wz
        {
            [MethodImpl(INLINE)] get => new(w, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 ww { [MethodImpl(INLINE)] get => new(w, w); }

        /// Returns the byte1 element at a specified index.
        public unsafe byte1 this[int index]
        {
            get {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
                #endif
                fixed (byte4* array = &this) {
                    return ((byte1*)array)[index];
                }
            }
            set {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
                #endif
                fixed (byte1* array = &x) {
                    array[index] = value;
                }
            }
        }

        /// Returns true if the byte4 is equal to a given byte4, false otherwise.
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(INLINE)] public bool Equals(byte4 rhs) => x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w;
        /// Returns true if the byte4 is equal to a given byte4, false otherwise.
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte4 converted && Equals(converted);
        /// Returns a hash code for the byte4.
        /// <returns>The computed hash code.</returns>
        [MethodImpl(INLINE)] public override int GetHashCode() => (int)hash(this);
        /// Returns a string representation of the byte4.
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)] public override string ToString() => string.Format("byte4({0}, {1}, {2}, {3})", x, y, z, w);
        /// Returns a string representation of the byte4 using a specified format and culture-specific format information.
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)] public string ToString(string format, IFormatProvider formatProvider) => string.Format("byte4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));

        internal sealed class DebuggerProxy
        {
            public byte1 x;
            public byte1 y;
            public byte1 z;
            public byte1 w;
            public DebuggerProxy(byte4 v) {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }
    }

    public static partial class mathx
    {
        /// Returns a byte4 vector constructed from four byte1 values.
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(INLINE)] public static byte4 byte4(byte1 x, byte1 y, byte1 z, byte1 w) => new(x, y, z, w);
        /// Returns a byte4 vector constructed from two byte1 values and a byte2 vector.
        [MethodImpl(INLINE)] public static byte4 byte4(byte1 x, byte1 y, byte2 zw) => new(x, y, zw);
        /// Returns a byte4 vector constructed from a byte1 value, a byte2 vector and a byte1 value.
        [MethodImpl(INLINE)] public static byte4 byte4(byte1 x, byte2 yz, byte1 w) => new(x, yz, w);
        /// Returns a byte4 vector constructed from a byte1 value and a byte3 vector.
        [MethodImpl(INLINE)] public static byte4 byte4(byte1 x, byte3 yzw) => new(x, yzw);
        /// Returns a byte4 vector constructed from a byte2 vector and two byte1 values.
        [MethodImpl(INLINE)] public static byte4 byte4(byte2 xy, byte1 z, byte1 w) => new(xy, z, w);
        /// Returns a byte4 vector constructed from two byte2 vectors.
        [MethodImpl(INLINE)] public static byte4 byte4(byte2 xy, byte2 zw) => new(xy, zw);
        /// Returns a byte4 vector constructed from a byte3 vector and a byte1 value.
        [MethodImpl(INLINE)] public static byte4 byte4(byte3 xyz, byte1 w) => new(xyz, w);
        /// Returns a byte4 vector constructed from a byte4 vector.
        [MethodImpl(INLINE)] public static byte4 byte4(byte4 xyzw) => new(xyzw);
        /// Returns a byte4 vector constructed from a single byte1 value by assigning it to every component.
        [MethodImpl(INLINE)] public static byte4 byte4(byte1 v) => new(v);
        /// Returns a byte4 vector constructed from a single float value by converting it to byte1 and assigning it to every component.
        [MethodImpl(INLINE)] public static byte4 byte4(float v) => new(v);
        /// Return a byte4 vector constructed from a f4 vector by componentwise conversion.
        /// <param name="v">f4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)] public static byte4 byte4(float4 v) => new(v);
        /// Returns a byte4 vector constructed from a single double value by converting it to byte1 and assigning it to
        /// every component.
        [MethodImpl(INLINE)] public static byte4 byte4(double v) => new(v);
        /// Return a byte4 vector constructed from a double4 vector by componentwise conversion.
        [MethodImpl(INLINE)] public static byte4 byte4(double4 v) => new(v);
        /// Returns a uint hash code of a byte4 vector.
        [MethodImpl(INLINE)] public static uint hash(byte4 v) => math.csum(uint4(v.x, v.y, v.z, v.w) * uint4(0x745ED837u, 0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu)) + 0x68EEE0F5u;
        /// Returns a uint4 vector hash code of a byte4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        [MethodImpl(INLINE)] public static uint4 hashwide(byte4 v) => v * uint4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u) + 0xFC104C3Bu;
    }
}