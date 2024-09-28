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
    /// A 4 component vector of bytes.
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte4 : IEquatable<byte4>, IFormattable
    {
        /// x component of the vector.
        public byte x;

        /// y component of the vector.
        public byte y;

        /// z component of the vector.
        public byte z;

        /// w component of the vector.
        public byte w;

        /// byte4 zero value.
        public static readonly byte4 zero = 0;

        /// Constructs a byte4 vector from four byte values.
        [MethodImpl(IL)] public byte4(byte x, byte y, byte z, byte w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// Constructs a byte4 vector from four byte values.
        [MethodImpl(IL)] public byte4(ValueType x, ValueType y, ValueType z, ValueType w) {
            this.x = (byte)x;
            this.y = (byte)y;
            this.z = (byte)z;
            this.w = (byte)w;
        }
        
        /// Constructs a byte4 vector from two byte values and a byte2 vector.
        [MethodImpl(IL)] public byte4(byte x, byte y, byte2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        /// Constructs a byte4 vector from a byte value, a byte2 vector and a byte value.
        [MethodImpl(IL)] public byte4(byte x, byte2 yz, byte w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        /// Constructs a byte4 vector from a byte value and a byte3 vector.
        [MethodImpl(IL)] public byte4(byte x, byte3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        /// Constructs a byte4 vector from a byte2 vector and two byte values.
        [MethodImpl(IL)] public byte4(byte2 xy, byte z, byte w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        /// Constructs a byte4 vector from two byte2 vectors.
        [MethodImpl(IL)] public byte4(byte2 xy, byte2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        /// Constructs a byte4 vector from a byte3 vector and a byte value.
        [MethodImpl(IL)] public byte4(byte3 xyz, byte w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        
        /// Constructs a byte4 vector from a single byte value by assigning it to every component.
        [MethodImpl(IL)] public byte4(byte v) => x = y = z = w = v;

        ///     Constructs a byte4 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        [MethodImpl(IL)] public byte4(ValueType v) => x = y = z = w = (byte)v;


        /// Constructs a byte4 vector from a f4 vector by componentwise conversion.
        [MethodImpl(IL)] public byte4(float4 v) {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
            w = (byte)v.w;
        }

        /// Constructs a byte4 vector from a double4 vector by componentwise conversion.
        [MethodImpl(IL)] public byte4(double4 v) {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
            w = (byte)v.w;
        }
        
        /// Implicitly converts a single byte value to a byte4 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte4(byte v) => new(v);
        /// Implicitly converts a single int value to a byte4 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte4(int v) => new((byte)v);
        /// Implicitly converts a single byte value to a byte4 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte4(uint v) => new((byte)v);
        /// Explicitly converts a single float value to a byte4 vector by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static explicit operator byte4(float v) => new((byte)v);
        /// Explicitly converts a single double value to a byte4 vector by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static explicit operator byte4(double v) => new(v);
        
        //Todo finish implementing explicit casts to other byte vectors
        /// Explicitly converts a byte4 vector to a float4 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator float4(byte4 v) => new(v);
        /// Explicitly converts a byte4 vector to a double4 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator double4(byte4 v) => new(v);

        /// Explicitly converts a byte4 vector to a int4 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator int4(byte4 v) => new(v);
        
        //implicit
        /// Explicitly converts a byte4 vector to a uint4 vector by componentwise conversion.
        [MethodImpl(IL)] public static implicit operator uint4(byte4 v) => new(v.x, v.y, v.z, v.w);
        
        
        /// Explicitly converts a f4 vector to a byte4 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator byte4(float4 v) => new(v);
        /// Explicitly converts a double4 vector to a byte4 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator byte4(double4 v) => new(v);


        /// Returns the result of a componentwise equality operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator ==(byte4 a, byte4 b) => new(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        /// Returns the result of a componentwise equality operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator ==(byte4 a, byte b) => new(a.x == b, a.y == b, a.z == b, a.w == b);
        /// Returns the result of a componentwise equality operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator ==(byte a, byte4 b) => new(a == b.x, a == b.y, a == b.z, a == b.w);
        
        /// Returns the result of a componentwise not equal operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator !=(byte4 a, byte4 b) => new(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        /// Returns the result of a componentwise not equal operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator !=(byte4 a, byte b) => new(a.x != b, a.y != b, a.z != b, a.w != b);
        /// Returns the result of a componentwise not equal operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator !=(byte a, byte4 b) => new(a != b.x, a != b.y, a != b.z, a != b.w);
        

        /// Returns the result of a componentwise multiplication into an int4 vector.
        [MethodImpl(IL)] public static int4 operator *(byte4 a, byte4 b) => new(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        /// <inheritdoc cref="operator *(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator *(byte4 a, byte b) => new(a.x * b, a.y * b, a.z * b, a.w * b);
        /// <inheritdoc cref="operator *(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator *(byte a, byte4 b) => new(a * b.x, a * b.y, a * b.z, a * b.w);
        
        /// Returns the result of a componentwise addition into an int4 vector.
        [MethodImpl(IL)] public static int4 operator +(byte4 a, byte4 b) => new(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        /// <inheritdoc cref="operator +(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator +(byte4 a, byte b) => new(a.x + b, a.y + b, a.z + b, a.w + b);
        /// <inheritdoc cref="operator +(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator +(byte a, byte4 b) => new(a + b.x, a + b.y, a + b.z, a + b.w);
        
        /// Returns the result of a componentwise subtraction into an int4 vector.
        [MethodImpl(IL)] public static int4 operator -(byte4 a, byte4 b) => new(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        /// <inheritdoc cref="operator -(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator -(byte4 a, byte b) => new(a.x - b, a.y - b, a.z - b, a.w - b);
        /// <inheritdoc cref="operator -(byte4, byte4)"/>
        [MethodImpl(IL)] public static int4 operator -(byte a, byte4 b) => new(a - b.x, a - b.y, a - b.z, a - b.w);
        
        /// Returns the result of a componentwise division into an f4 vector.
        [MethodImpl(IL)] public static float4 operator /(byte4 a, byte4 b) => new(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        /// <inheritdoc cref="operator /(byte4, byte4)"/>
        [MethodImpl(IL)] public static float4 operator /(byte4 a, byte b) => new(a.x / b, a.y / b, a.z / b, a.w / b);
        /// <inheritdoc cref="operator /(byte4, byte4)"/>
        [MethodImpl(IL)] public static float4 operator /(byte a, byte4 b) => new(a / b.x, a / b.y, a / b.z, a / b.w);
        
        /// Returns the result of a componentwise modulus operation into an byte4 vector.
        [MethodImpl(IL)] public static byte4 operator %(byte4 a, byte4 b) => new(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w);
        /// <inheritdoc cref="operator %(byte4, byte4)"/>
        [MethodImpl(IL)] public static byte4 operator %(byte4 a, byte b) => new(a.x % b, a.y % b, a.z % b, a.w % b);
        /// <inheritdoc cref="operator %(byte4, byte4)"/>
        [MethodImpl(IL)] public static byte4 operator %(byte a, byte4 b) => new(a % b.x, a % b.y, a % b.z, a % b.w);
        
        /// Adds one to each component of the byte4 vector.
        [MethodImpl(IL)] public static byte4 operator ++(byte4 v) => new(++v.x, ++v.y, ++v.z, ++v.w);
        ///Subtracts one from each component of the byte4 vector.
        [MethodImpl(IL)] public static byte4 operator --(byte4 v) => new(--v.x, --v.y, --v.z, --v.w);
        
        /// Returns the result of a componentwise less than operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator <(byte4 a, byte4 b) => new(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        /// Returns the result of a componentwise less than operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator <(byte4 a, byte b) => new(a.x < b, a.y < b, a.z < b, a.w < b);
        /// Returns the result of a componentwise less than operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator <(byte a, byte4 b) => new(a < b.x, a < b.y, a < b.z, a < b.w);
        
        /// Returns the result of a componentwise less or equal operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator <=(byte4 a, byte4 b) => new(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        /// Returns the result of a componentwise less or equal operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator <=(byte4 a, byte b) => new(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        /// Returns the result of a componentwise less or equal operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator <=(byte a, byte4 b) => new(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
      
        /// Returns the result of a componentwise greater than operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator >(byte4 a, byte4 b) => new(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        /// Returns the result of a componentwise greater than operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator >(byte4 a, byte b) => new(a.x > b, a.y > b, a.z > b, a.w > b);
        /// Returns the result of a componentwise greater than operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator >(byte a, byte4 b) => new(a > b.x, a > b.y, a > b.z, a > b.w);
        
        /// Returns the result of a componentwise greater or equal operation on two byte4 vectors.
        [MethodImpl(IL)] public static bool4 operator >=(byte4 a, byte4 b) => new(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);
        /// Returns the result of a componentwise greater or equal operation on a byte4 vector and a byte value.
        [MethodImpl(IL)] public static bool4 operator >=(byte4 a, byte b) => new(a.x >= b, a.y >= b, a.z >= b, a.w >= b);
        /// Returns the result of a componentwise greater or equal operation on a byte value and a byte4 vector.
        [MethodImpl(IL)] public static bool4 operator >=(byte a, byte4 b) => new(a >= b.x, a >= b.y, a >= b.z, a >= b.w);
       
        /// Returns the result of a componentwise unary minus operation on a byte4 vector.
        [MethodImpl(IL)] public static byte4 operator -(byte4 v) => new(-v.x, -v.y, -v.z, -v.w);
        /// Returns the result of a componentwise unary plus operation on a byte4 vector.
        [MethodImpl(IL)] public static byte4 operator +(byte4 v) => new(+v.x, +v.y, +v.z, +v.w);

        
        /// <summary>Returns the result of a componentwise bitwise not operation on an byte4 vector.</summary>
        [MethodImpl(IL)]public static byte4 operator ~(byte4 v) => new(~v.x, ~v.y, ~v.z, ~v.w);
        
        /// <summary>Returns the result of a componentwise bitwise and operation on two byte4 vectors.</summary>
        [MethodImpl(IL)] public static byte4 operator &(byte4 a, byte4 b) => new(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
        /// <summary>Returns the result of a componentwise bitwise and operation on an byte4 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte4 operator &(byte4 a, int b) => new(a.x & b, a.y & b, a.z & b, a.w & b);
        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an byte4 vector.</summary>
        [MethodImpl(IL)] public static byte4 operator &(int a, byte4 b) => new(a & b.x, a & b.y, a & b.z, a & b.w);

        /// <summary>Returns the result of a componentwise bitwise or operation on two byte4 vectors.</summary>
        [MethodImpl(IL)] public static byte4 operator |(byte4 a, byte4 b) => new(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
        /// <summary>Returns the result of a componentwise bitwise or operation on an byte4 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte4 operator |(byte4 a, int b) => new(a.x | b, a.y | b, a.z | b, a.w | b);
        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an byte4 vector.</summary>
        [MethodImpl(IL)] public static byte4 operator |(int a, byte4 b) => new(a | b.x, a | b.y, a | b.z, a | b.w);

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two byte4 vectors.</summary>
        [MethodImpl(IL)] public static byte4 operator ^(byte4 a, byte4 b) => new(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an byte4 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte4 operator ^(byte4 a, int b) => new(a.x ^ b, a.y ^ b, a.z ^ b, a.w ^ b);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an byte4 vector.</summary>
        [MethodImpl(IL)] public static byte4 operator ^(int a, byte4 b) => new(a ^ b.x, a ^ b.y, a ^ b.z, a ^ b.w);
       
        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxx { [MethodImpl(IL)] get => new(x, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxy { [MethodImpl(IL)] get => new(x, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxz { [MethodImpl(IL)] get => new(x, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxw { [MethodImpl(IL)] get => new(x, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyx { [MethodImpl(IL)] get => new(x, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyy { [MethodImpl(IL)] get => new(x, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyz { [MethodImpl(IL)] get => new(x, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyw { [MethodImpl(IL)] get => new(x, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzx { [MethodImpl(IL)] get => new(x, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzy { [MethodImpl(IL)] get => new(x, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzz { [MethodImpl(IL)] get => new(x, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzw { [MethodImpl(IL)] get => new(x, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwx { [MethodImpl(IL)] get => new(x, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwy { [MethodImpl(IL)] get => new(x, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxwz { [MethodImpl(IL)] get => new(x, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxww { [MethodImpl(IL)] get => new(x, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxx { [MethodImpl(IL)] get => new(x, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxy { [MethodImpl(IL)] get => new(x, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxz { [MethodImpl(IL)] get => new(x, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxw { [MethodImpl(IL)] get => new(x, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyx { [MethodImpl(IL)] get => new(x, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyy { [MethodImpl(IL)] get => new(x, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyz { [MethodImpl(IL)] get => new(x, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyw { [MethodImpl(IL)] get => new(x, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzx { [MethodImpl(IL)] get => new(x, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzy { [MethodImpl(IL)] get => new(x, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzz { [MethodImpl(IL)] get => new(x, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzw
        {
            [MethodImpl(IL)] get => new(x, y, z, w);
            [MethodImpl(IL)] set {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywx { [MethodImpl(IL)] get => new(x, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywy { [MethodImpl(IL)] get => new(x, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xywz
        {
            [MethodImpl(IL)] get => new(x, y, w, z);
            [MethodImpl(IL)] set {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyww { [MethodImpl(IL)] get => new(x, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxx { [MethodImpl(IL)] get => new(x, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxy { [MethodImpl(IL)] get => new(x, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxz { [MethodImpl(IL)] get => new(x, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxw { [MethodImpl(IL)] get => new(x, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyx { [MethodImpl(IL)] get => new(x, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyy { [MethodImpl(IL)] get => new(x, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyz { [MethodImpl(IL)] get => new(x, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyw
        {
            [MethodImpl(IL)] get => new(x, z, y, w);
            [MethodImpl(IL)] set {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzx { [MethodImpl(IL)] get => new(x, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzy { [MethodImpl(IL)] get => new(x, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzz { [MethodImpl(IL)] get => new(x, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzw { [MethodImpl(IL)] get => new(x, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwx { [MethodImpl(IL)] get => new(x, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwy
        {
            [MethodImpl(IL)] get => new(x, z, w, y);
            [MethodImpl(IL)] set {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzwz { [MethodImpl(IL)] get => new(x, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzww { [MethodImpl(IL)] get => new(x, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxx { [MethodImpl(IL)] get => new(x, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxy { [MethodImpl(IL)] get => new(x, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxz { [MethodImpl(IL)] get => new(x, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwxw { [MethodImpl(IL)] get => new(x, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyx { [MethodImpl(IL)] get => new(x, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyy { [MethodImpl(IL)] get => new(x, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyz
        {
            [MethodImpl(IL)] get => new(x, w, y, z);
            [MethodImpl(IL)] set {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwyw { [MethodImpl(IL)] get => new(x, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzx { [MethodImpl(IL)] get => new(x, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzy
        {
            [MethodImpl(IL)] get => new(x, w, z, y);
            [MethodImpl(IL)] set {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzz { [MethodImpl(IL)] get => new(x, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwzw { [MethodImpl(IL)] get => new(x, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwx { [MethodImpl(IL)] get => new(x, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwy { [MethodImpl(IL)] get => new(x, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwwz { [MethodImpl(IL)] get => new(x, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xwww { [MethodImpl(IL)] get => new(x, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxx { [MethodImpl(IL)] get => new(y, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxy { [MethodImpl(IL)] get => new(y, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxz { [MethodImpl(IL)] get => new(y, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxw { [MethodImpl(IL)] get => new(y, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyx { [MethodImpl(IL)] get => new(y, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyy { [MethodImpl(IL)] get => new(y, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyz { [MethodImpl(IL)] get => new(y, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyw { [MethodImpl(IL)] get => new(y, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzx { [MethodImpl(IL)] get => new(y, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzy { [MethodImpl(IL)] get => new(y, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzz { [MethodImpl(IL)] get => new(y, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzw
        {
            [MethodImpl(IL)] get => new(y, x, z, w);
            [MethodImpl(IL)] set {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwx { [MethodImpl(IL)] get => new(y, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwy { [MethodImpl(IL)] get => new(y, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxwz
        {
            [MethodImpl(IL)] get => new(y, x, w, z);
            [MethodImpl(IL)] set {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxww { [MethodImpl(IL)] get => new(y, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxx { [MethodImpl(IL)] get => new(y, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxy { [MethodImpl(IL)] get => new(y, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxz { [MethodImpl(IL)] get => new(y, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxw { [MethodImpl(IL)] get => new(y, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyx { [MethodImpl(IL)] get => new(y, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyy { [MethodImpl(IL)] get => new(y, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyz { [MethodImpl(IL)] get => new(y, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyw { [MethodImpl(IL)] get => new(y, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzx { [MethodImpl(IL)] get => new(y, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzy { [MethodImpl(IL)] get => new(y, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzz { [MethodImpl(IL)] get => new(y, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzw { [MethodImpl(IL)] get => new(y, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywx { [MethodImpl(IL)] get => new(y, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywy { [MethodImpl(IL)] get => new(y, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yywz { [MethodImpl(IL)] get => new(y, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyww { [MethodImpl(IL)] get => new(y, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxx { [MethodImpl(IL)] get => new(y, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxy { [MethodImpl(IL)] get => new(y, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxz { [MethodImpl(IL)] get => new(y, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxw
        {
            [MethodImpl(IL)] get => new(y, z, x, w);
            [MethodImpl(IL)] set {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyx { [MethodImpl(IL)] get => new(y, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyy { [MethodImpl(IL)] get => new(y, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyz { [MethodImpl(IL)] get => new(y, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyw { [MethodImpl(IL)] get => new(y, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzx { [MethodImpl(IL)] get => new(y, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzy { [MethodImpl(IL)] get => new(y, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzz { [MethodImpl(IL)] get => new(y, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzw { [MethodImpl(IL)] get => new(y, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwx
        {
            [MethodImpl(IL)] get => new(y, z, w, x);
            [MethodImpl(IL)] set {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwy { [MethodImpl(IL)] get => new(y, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzwz { [MethodImpl(IL)] get => new(y, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzww { [MethodImpl(IL)] get => new(y, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxx { [MethodImpl(IL)] get => new(y, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxy { [MethodImpl(IL)] get => new(y, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxz
        {
            [MethodImpl(IL)] get => new(y, w, x, z);
            [MethodImpl(IL)] set {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywxw { [MethodImpl(IL)] get => new(y, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyx { [MethodImpl(IL)] get => new(y, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyy { [MethodImpl(IL)] get => new(y, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyz { [MethodImpl(IL)] get => new(y, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywyw { [MethodImpl(IL)] get => new(y, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzx
        {
            [MethodImpl(IL)] get => new(y, w, z, x);
            [MethodImpl(IL)] set {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzy { [MethodImpl(IL)] get => new(y, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzz { [MethodImpl(IL)] get => new(y, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywzw { [MethodImpl(IL)] get => new(y, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwx { [MethodImpl(IL)] get => new(y, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwy { [MethodImpl(IL)] get => new(y, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywwz { [MethodImpl(IL)] get => new(y, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 ywww { [MethodImpl(IL)] get => new(y, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxx { [MethodImpl(IL)] get => new(z, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxy { [MethodImpl(IL)] get => new(z, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxz { [MethodImpl(IL)] get => new(z, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxw { [MethodImpl(IL)] get => new(z, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyx { [MethodImpl(IL)] get => new(z, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyy { [MethodImpl(IL)] get => new(z, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyz { [MethodImpl(IL)] get => new(z, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyw
        {
            [MethodImpl(IL)] get => new(z, x, y, w);
            [MethodImpl(IL)] set {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzx { [MethodImpl(IL)] get => new(z, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzy { [MethodImpl(IL)] get => new(z, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzz { [MethodImpl(IL)] get => new(z, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzw { [MethodImpl(IL)] get => new(z, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwx { [MethodImpl(IL)] get => new(z, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwy
        {
            [MethodImpl(IL)] get => new(z, x, w, y);
            [MethodImpl(IL)] set {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxwz { [MethodImpl(IL)] get => new(z, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxww { [MethodImpl(IL)] get => new(z, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxx { [MethodImpl(IL)] get => new(z, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxy { [MethodImpl(IL)] get => new(z, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxz { [MethodImpl(IL)] get => new(z, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxw
        {
            [MethodImpl(IL)] get => new(z, y, x, w);
            [MethodImpl(IL)] set {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyx { [MethodImpl(IL)] get => new(z, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyy { [MethodImpl(IL)] get => new(z, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyz { [MethodImpl(IL)] get => new(z, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyw { [MethodImpl(IL)] get => new(z, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzx { [MethodImpl(IL)] get => new(z, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzy { [MethodImpl(IL)] get => new(z, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzz { [MethodImpl(IL)] get => new(z, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzw { [MethodImpl(IL)] get => new(z, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywx
        {
            [MethodImpl(IL)] get => new(z, y, w, x);
            [MethodImpl(IL)] set {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywy { [MethodImpl(IL)] get => new(z, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zywz { [MethodImpl(IL)] get => new(z, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyww { [MethodImpl(IL)] get => new(z, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxx { [MethodImpl(IL)] get => new(z, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxy { [MethodImpl(IL)] get => new(z, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxz { [MethodImpl(IL)] get => new(z, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxw { [MethodImpl(IL)] get => new(z, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyx { [MethodImpl(IL)] get => new(z, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyy { [MethodImpl(IL)] get => new(z, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyz { [MethodImpl(IL)] get => new(z, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyw { [MethodImpl(IL)] get => new(z, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzx { [MethodImpl(IL)] get => new(z, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzy { [MethodImpl(IL)] get => new(z, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzz { [MethodImpl(IL)] get => new(z, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzw { [MethodImpl(IL)] get => new(z, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwx { [MethodImpl(IL)] get => new(z, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwy { [MethodImpl(IL)] get => new(z, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzwz { [MethodImpl(IL)] get => new(z, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzww { [MethodImpl(IL)] get => new(z, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxx { [MethodImpl(IL)] get => new(z, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxy
        {
            [MethodImpl(IL)] get => new(z, w, x, y);
            [MethodImpl(IL)] set {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxz { [MethodImpl(IL)] get => new(z, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwxw { [MethodImpl(IL)] get => new(z, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyx
        {
            [MethodImpl(IL)] get => new(z, w, y, x);
            [MethodImpl(IL)] set {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyy { [MethodImpl(IL)] get => new(z, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyz { [MethodImpl(IL)] get => new(z, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwyw { [MethodImpl(IL)] get => new(z, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzx { [MethodImpl(IL)] get => new(z, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzy { [MethodImpl(IL)] get => new(z, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzz { [MethodImpl(IL)] get => new(z, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwzw { [MethodImpl(IL)] get => new(z, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwx { [MethodImpl(IL)] get => new(z, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwy { [MethodImpl(IL)] get => new(z, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwwz { [MethodImpl(IL)] get => new(z, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zwww { [MethodImpl(IL)] get => new(z, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxx { [MethodImpl(IL)] get => new(w, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxy { [MethodImpl(IL)] get => new(w, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxz { [MethodImpl(IL)] get => new(w, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxxw { [MethodImpl(IL)] get => new(w, x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyx { [MethodImpl(IL)] get => new(w, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyy { [MethodImpl(IL)] get => new(w, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyz
        {
            [MethodImpl(IL)] get => new(w, x, y, z);
            [MethodImpl(IL)] set {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxyw { [MethodImpl(IL)] get => new(w, x, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzx { [MethodImpl(IL)] get => new(w, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzy
        {
            [MethodImpl(IL)] get => new(w, x, z, y);
            [MethodImpl(IL)] set {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzz { [MethodImpl(IL)] get => new(w, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxzw { [MethodImpl(IL)] get => new(w, x, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwx { [MethodImpl(IL)] get => new(w, x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwy { [MethodImpl(IL)] get => new(w, x, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxwz { [MethodImpl(IL)] get => new(w, x, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wxww { [MethodImpl(IL)] get => new(w, x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxx { [MethodImpl(IL)] get => new(w, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxy { [MethodImpl(IL)] get => new(w, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxz
        {
            [MethodImpl(IL)] get => new(w, y, x, z);
            [MethodImpl(IL)] set {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyxw { [MethodImpl(IL)] get => new(w, y, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyx { [MethodImpl(IL)] get => new(w, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyy { [MethodImpl(IL)] get => new(w, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyz { [MethodImpl(IL)] get => new(w, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyyw { [MethodImpl(IL)] get => new(w, y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzx
        {
            [MethodImpl(IL)] get => new(w, y, z, x);
            [MethodImpl(IL)] set {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzy { [MethodImpl(IL)] get => new(w, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzz { [MethodImpl(IL)] get => new(w, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyzw { [MethodImpl(IL)] get => new(w, y, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywx { [MethodImpl(IL)] get => new(w, y, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywy { [MethodImpl(IL)] get => new(w, y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wywz { [MethodImpl(IL)] get => new(w, y, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wyww { [MethodImpl(IL)] get => new(w, y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxx { [MethodImpl(IL)] get => new(w, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxy
        {
            [MethodImpl(IL)] get => new(w, z, x, y);
            [MethodImpl(IL)] set {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxz { [MethodImpl(IL)] get => new(w, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzxw { [MethodImpl(IL)] get => new(w, z, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyx
        {
            [MethodImpl(IL)] get => new(w, z, y, x);
            [MethodImpl(IL)] set {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyy { [MethodImpl(IL)] get => new(w, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyz { [MethodImpl(IL)] get => new(w, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzyw { [MethodImpl(IL)] get => new(w, z, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzx { [MethodImpl(IL)] get => new(w, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzy { [MethodImpl(IL)] get => new(w, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzz { [MethodImpl(IL)] get => new(w, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzzw { [MethodImpl(IL)] get => new(w, z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwx { [MethodImpl(IL)] get => new(w, z, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwy { [MethodImpl(IL)] get => new(w, z, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzwz { [MethodImpl(IL)] get => new(w, z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wzww { [MethodImpl(IL)] get => new(w, z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxx { [MethodImpl(IL)] get => new(w, w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxy { [MethodImpl(IL)] get => new(w, w, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxz { [MethodImpl(IL)] get => new(w, w, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwxw { [MethodImpl(IL)] get => new(w, w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyx { [MethodImpl(IL)] get => new(w, w, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyy { [MethodImpl(IL)] get => new(w, w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyz { [MethodImpl(IL)] get => new(w, w, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwyw { [MethodImpl(IL)] get => new(w, w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzx { [MethodImpl(IL)] get => new(w, w, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzy { [MethodImpl(IL)] get => new(w, w, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzz { [MethodImpl(IL)] get => new(w, w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwzw { [MethodImpl(IL)] get => new(w, w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwx { [MethodImpl(IL)] get => new(w, w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwy { [MethodImpl(IL)] get => new(w, w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwwz { [MethodImpl(IL)] get => new(w, w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 wwww { [MethodImpl(IL)] get => new(w, w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxx { [MethodImpl(IL)] get => new(x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxy { [MethodImpl(IL)] get => new(x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxz { [MethodImpl(IL)] get => new(x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxw { [MethodImpl(IL)] get => new(x, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyx { [MethodImpl(IL)] get => new(x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyy { [MethodImpl(IL)] get => new(x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyz
        {
            [MethodImpl(IL)] get => new(x, y, z);
            [MethodImpl(IL)] set {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xyw
        {
            [MethodImpl(IL)] get => new(x, y, w);
            [MethodImpl(IL)] set {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzx { [MethodImpl(IL)] get => new(x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzy
        {
            [MethodImpl(IL)] get => new(x, z, y);
            [MethodImpl(IL)] set {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzz { [MethodImpl(IL)] get => new(x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xzw
        {
            [MethodImpl(IL)] get => new(x, z, w);
            [MethodImpl(IL)] set {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwx { [MethodImpl(IL)] get => new(x, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwy
        {
            [MethodImpl(IL)] get => new(x, w, y);
            [MethodImpl(IL)] set {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xwz
        {
            [MethodImpl(IL)] get => new(x, w, z);
            [MethodImpl(IL)] set {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xww { [MethodImpl(IL)] get => new(x, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxx { [MethodImpl(IL)] get => new(y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxy { [MethodImpl(IL)] get => new(y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxz
        {
            [MethodImpl(IL)] get => new(y, x, z);
            [MethodImpl(IL)] set {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yxw
        {
            [MethodImpl(IL)] get => new(y, x, w);
            [MethodImpl(IL)] set {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyx { [MethodImpl(IL)] get => new(y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyy { [MethodImpl(IL)] get => new(y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyz { [MethodImpl(IL)] get => new(y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyw { [MethodImpl(IL)] get => new(y, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzx
        {
            [MethodImpl(IL)] get => new(y, z, x);
            [MethodImpl(IL)] set {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzy { [MethodImpl(IL)] get => new(y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzz { [MethodImpl(IL)] get => new(y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yzw
        {
            [MethodImpl(IL)] get => new(y, z, w);
            [MethodImpl(IL)] set {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywx
        {
            [MethodImpl(IL)] get => new(y, w, x);
            [MethodImpl(IL)] set {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywy { [MethodImpl(IL)] get => new(y, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 ywz
        {
            [MethodImpl(IL)] get => new(y, w, z);
            [MethodImpl(IL)] set {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yww { [MethodImpl(IL)] get => new(y, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxx { [MethodImpl(IL)] get => new(z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxy
        {
            [MethodImpl(IL)] get => new(z, x, y);
            [MethodImpl(IL)] set {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxz { [MethodImpl(IL)] get => new(z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zxw
        {
            [MethodImpl(IL)] get => new(z, x, w);
            [MethodImpl(IL)] set {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyx
        {
            [MethodImpl(IL)] get => new(z, y, x);
            [MethodImpl(IL)] set {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyy { [MethodImpl(IL)] get => new(z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyz { [MethodImpl(IL)] get => new(z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zyw
        {
            [MethodImpl(IL)] get => new(z, y, w);
            [MethodImpl(IL)] set {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzx { [MethodImpl(IL)] get => new(z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzy { [MethodImpl(IL)] get => new(z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzz { [MethodImpl(IL)] get => new(z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzw { [MethodImpl(IL)] get => new(z, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwx
        {
            [MethodImpl(IL)] get => new(z, w, x);
            [MethodImpl(IL)] set {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwy
        {
            [MethodImpl(IL)] get => new(z, w, y);
            [MethodImpl(IL)] set {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zwz { [MethodImpl(IL)] get => new(z, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zww { [MethodImpl(IL)] get => new(z, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxx { [MethodImpl(IL)] get => new(w, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxy
        {
            [MethodImpl(IL)] get => new(w, x, y);
            [MethodImpl(IL)] set {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxz
        {
            [MethodImpl(IL)] get => new(w, x, z);
            [MethodImpl(IL)] set {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wxw { [MethodImpl(IL)] get => new(w, x, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyx
        {
            [MethodImpl(IL)] get => new(w, y, x);
            [MethodImpl(IL)] set {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyy { [MethodImpl(IL)] get => new(w, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyz
        {
            [MethodImpl(IL)] get => new(w, y, z);
            [MethodImpl(IL)] set {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wyw { [MethodImpl(IL)] get => new(w, y, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzx
        {
            [MethodImpl(IL)] get => new(w, z, x);
            [MethodImpl(IL)] set {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzy
        {
            [MethodImpl(IL)] get => new(w, z, y);
            [MethodImpl(IL)] set {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzz { [MethodImpl(IL)] get => new(w, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wzw { [MethodImpl(IL)] get => new(w, z, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwx { [MethodImpl(IL)] get => new(w, w, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwy { [MethodImpl(IL)] get => new(w, w, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 wwz { [MethodImpl(IL)] get => new(w, w, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 www { [MethodImpl(IL)] get => new(w, w, w); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xx { [MethodImpl(IL)] get => new(x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xy
        {
            [MethodImpl(IL)] get => new(x, y);
            [MethodImpl(IL)] set {
                x = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xz
        {
            [MethodImpl(IL)] get => new(x, z);
            [MethodImpl(IL)] set {
                x = value.x;
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 xw
        {
            [MethodImpl(IL)] get => new(x, w);
            [MethodImpl(IL)] set {
                x = value.x;
                w = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yx
        {
            [MethodImpl(IL)] get => new(y, x);
            [MethodImpl(IL)] set {
                y = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yy { [MethodImpl(IL)] get => new(y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yz
        {
            [MethodImpl(IL)] get => new(y, z);
            [MethodImpl(IL)] set {
                y = value.x; 
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 yw
        {
            [MethodImpl(IL)] get => new(y, w);
            [MethodImpl(IL)] set {
                y = value.x; 
                w = value.y; 
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zx
        {
            [MethodImpl(IL)] get => new(z, x);
            [MethodImpl(IL)] set {
                z = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zy
        {
            [MethodImpl(IL)] get => new(z, y);
            [MethodImpl(IL)] set {
                z = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zz { [MethodImpl(IL)] get => new(z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 zw
        {
            [MethodImpl(IL)] get => new(z, w);
            [MethodImpl(IL)] set {
                z = value.x;
                w = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wx
        {
            [MethodImpl(IL)] get => new(w, x);
            [MethodImpl(IL)] set {
                w = value.x;
                x = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wy
        {
            [MethodImpl(IL)] get => new(w, y);
            [MethodImpl(IL)] set {
                w = value.x;
                y = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 wz
        {
            [MethodImpl(IL)] get => new(w, z);
            [MethodImpl(IL)] set {
                w = value.x;
                z = value.y;
            }
        }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte2 ww { [MethodImpl(IL)] get => new(w, w); }

        /// Returns the byte element at a specified index.
        public unsafe byte this[int index]
        {
            get {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
                #endif
                fixed (byte4* array = &this) {
                    return ((byte*)array)[index];
                }
            }
            set {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
                #endif
                fixed (byte* array = &x) {
                    array[index] = value;
                }
            }
        }

        /// Returns true if the byte4 is equal to a given byte4, false otherwise.
        /// <param name="b">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(IL)] public bool Equals(byte4 b) => x == b.x && y == b.y && z == b.z && w == b.w;
        /// Returns true if the byte4 is equal to a given byte4, false otherwise.
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte4 converted && Equals(converted);
        /// Returns a hash code for the byte4.
        /// <returns>The computed hash code.</returns>
        [MethodImpl(IL)] public override int GetHashCode() => (int)hash(this);
        /// Returns a string representation of the byte4.
        /// <returns>String representation of the value.</returns>
        [MethodImpl(IL)] public override string ToString() => $"byte4({x}, {y}, {z}, {w})";
        /// Returns a string representation of the byte4 using a specified format and culture-specific format information.
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(IL)] public string ToString(string format, IFormatProvider formatProvider) => $"byte4({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)}, {z.ToString(format, formatProvider)}, {w.ToString(format, formatProvider)})";

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public byte z;
            public byte w;
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
        /// Returns a byte4 vector constructed from four byte values.
        [MethodImpl(IL)] public static byte4 byte4(byte x, byte y, byte z, byte w) => new(x, y, z, w);
        /// <returns>byte4 constructed from arguments.</returns>
        [MethodImpl(IL)] public static byte4 byte4(ValueType x, ValueType y, ValueType z, ValueType w) => new(x, y, z, w);
        /// Returns a byte4 vector constructed from two byte values and a byte2 vector.
        [MethodImpl(IL)] public static byte4 byte4(byte x, byte y, byte2 zw) => new(x, y, zw);
        /// Returns a byte4 vector constructed from a byte value, a byte2 vector and a byte value.
        [MethodImpl(IL)] public static byte4 byte4(byte x, byte2 yz, byte w) => new(x, yz, w);
        /// Returns a byte4 vector constructed from a byte value and a byte3 vector.
        [MethodImpl(IL)] public static byte4 byte4(byte x, byte3 yzw) => new(x, yzw);
        /// Returns a byte4 vector constructed from a byte2 vector and two byte values.
        [MethodImpl(IL)] public static byte4 byte4(byte2 xy, byte z, byte w) => new(xy, z, w);
        /// Returns a byte4 vector constructed from two byte2 vectors.
        [MethodImpl(IL)] public static byte4 byte4(byte2 xy, byte2 zw) => new(xy, zw);
        /// Returns a byte4 vector constructed from a byte3 vector and a byte value.
        [MethodImpl(IL)] public static byte4 byte4(byte3 xyz, byte w) => new(xyz, w);
        /// Returns a byte4 vector constructed from a byte4 vector.
        [MethodImpl(IL)] public static byte4 byte4(byte4 xyzw) => new(xyzw);
        
        
        /// Returns a byte4 vector constructed from a single byte value by assigning it to every component.
        [MethodImpl(IL)] public static byte4 byte4(byte v) => new(v);
        
        /// Returns a byte4 vector constructed from a single float value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static byte4 byte4(ValueType v) => new((byte)v);
        
        /// Return a byte4 vector constructed from a f4 vector by componentwise conversion.
        /// <param name="v">f4 to convert to byte4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(IL)] public static byte4 byte4(float4 v) => new(v);
        
        /// Return a byte4 vector constructed from a double4 vector by componentwise conversion.
        [MethodImpl(IL)] public static byte4 byte4(double4 v) => new(v);
        /// Returns a uint hash code of a byte4 vector.
        [MethodImpl(IL)] public static uint hash(byte4 v) => math.csum(uint4(v.x, v.y, v.z, v.w) * uint4(0x745ED837u, 0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu)) + 0x68EEE0F5u;
        /// Returns a uint4 vector hash code of a byte4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        [MethodImpl(IL)] public static uint4 hashwide(byte4 v) => v * uint4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u) + 0xFC104C3Bu;


        /// substitutes the component x
        [MethodImpl(IL)] public static byte4 swapx(this byte4 f, byte x) => new(x, f.y, f.z, f.w);
        /// substitutes the component y
        [MethodImpl(IL)] public static byte4 swapy(this byte4 f, byte y) => new(f.x, y, f.z, f.w);
        /// substitutes the component z
        [MethodImpl(IL)] public static byte4 swapz(this byte4 f, byte z) => new(f.x, f.y, z, f.w);
        /// substitutes the component w
        [MethodImpl(IL)] public static byte4 swapw(this byte4 f, byte w) => new(f.x, f.y, f.z, w);
    }
}