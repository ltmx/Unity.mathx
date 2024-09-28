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
    /// A 3 component vector of bytes.
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte3 : IEquatable<byte3>, IFormattable
    {
        /// x component of the vector.
        public byte x;

        /// y component of the vector.
        public byte y;

        /// z component of the vector.
        public byte z;

        /// byte3 zero value.
        public static readonly byte3 zero = 0;

        /// Constructs a byte3 vector from three byte values.
        // [MethodImpl(IL)] public byte3(byte x, byte y, byte z) { this.x = x; this.y = y; this.z = z; }
        [MethodImpl(IL)] public byte3(byte x, byte y, byte z) { this.x = x; this.y = y; this.z = z; }
        [MethodImpl(IL)] public byte3(ValueType x, ValueType y, ValueType z) { this.x = (byte)x; this.y = (byte)y; this.z = (byte)z; }
        
        
        /// Constructs a byte3 vector from a byte value and a byte2 vector.
        [MethodImpl(IL)] public byte3(byte x, byte2 yz) { this.x = x; y = yz.x; z = yz.y; }
        /// Constructs a byte3 vector from a byte2 vector and a byte value.
        [MethodImpl(IL)] public byte3(byte2 xy, byte z) { x = xy.x; y = xy.y; this.z = z; }

        /// Constructs a byte3 vector from a single byte value by assigning it to every component.
        [MethodImpl(IL)] public byte3(byte v) => x = y = z = v;

        /// Constructs a byte3 vector from a single double value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)]
        public byte3(ValueType v) => x = y = z = (byte)v;

        /// Constructs a byte3 vector from a f3 vector by componentwise conversion.
        [MethodImpl(IL)] public byte3(float3 v) { x = (byte)v.x; y = (byte)v.y; z = (byte)v.z; }
        /// Constructs a byte3 vector from a uint3 vector by componentwise conversion.
        [MethodImpl(IL)] public byte3(uint3 v) { x = (byte)v.x; y = (byte)v.y; z = (byte)v.z; }
        /// Constructs a byte3 vector from a int3 vector by componentwise conversion.
        [MethodImpl(IL)] public byte3(int3 v) { x = (byte)v.x; y = (byte)v.y; z = (byte)v.z; }
        /// Constructs a byte3 vector from a double3 vector by componentwise conversion.
        [MethodImpl(IL)] public byte3(double3 v) { x = (byte)v.x; y = (byte)v.y; z = (byte)v.z; }
        
        /// Implicitly converts a single byte value to a byte3 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte3(byte v) => new(v);
        /// Implicitly converts a single int value to a byte3 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte3(int v) => new((byte)v);
        /// Implicitly converts a single byte value to a byte3 vector by assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte3(uint v) => new((byte)v);
        /// Explicitly converts a single float value to a byte3 vector by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static implicit operator byte3(float v) => new((byte)v);
        
        // /// Explicitly converts a single double value to a byte3 vector by converting it to byte and assigning it to every component.
        // [MethodImpl(IL)] public static explicit operator byte3(double v) => new(v);
        
        /// Implicitly converts an int3 vector to a byte3 vector by componentwise conversion.
        [MethodImpl(IL)] public static implicit operator byte3(int3 v) => new(v);
        /// Implicitly converts an int3 vector to a byte3 vector by componentwise conversion.
        [MethodImpl(IL)] public static implicit operator byte3(uint3 v) => new(v);
        /// Explicitly converts a f3 vector to a byte3 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator byte3(float3 v) => new(v);
        /// Explicitly converts a double3 vector to a byte3 vector by componentwise conversion.
        [MethodImpl(IL)] public static explicit operator byte3(double3 v) => new(v);

        /// Returns the result of a componentwise equality operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator ==(byte3 a, byte3 b) => new(a.x == b.x, a.y == b.y, a.z == b.z);
        /// Returns the result of a componentwise equality operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator ==(byte3 a, byte b) => new(a.x == b, a.y == b, a.z == b);
        /// Returns the result of a componentwise equality operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator ==(byte a, byte3 b) => new(a == b.x, a == b.y, a == b.z);
        
        /// Returns the result of a componentwise not equal operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator !=(byte3 a, byte3 b) => new(a.x != b.x, a.y != b.y, a.z != b.z);
        /// Returns the result of a componentwise not equal operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator !=(byte3 a, byte b) => new(a.x != b, a.y != b, a.z != b);
        /// Returns the result of a componentwise not equal operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator !=(byte a, byte3 b) => new(a != b.x, a != b.y, a != b.z);
        
        /// Returns the result of a componentwise multiplication into an int3 vector.
        [MethodImpl(IL)] public static int3 operator *(byte3 a, byte3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
        /// <inheritdoc cref="operator *(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator *(byte3 a, byte b) => new(a.x * b, a.y * b, a.z * b);
        /// <inheritdoc cref="operator *(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator *(byte a, byte3 b) => new(a * b.x, a * b.y, a * b.z);
        
        /// Returns the result of a componentwise addition into an int3 vector.
        [MethodImpl(IL)] public static int3 operator +(byte3 a, byte3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <inheritdoc cref="operator +(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator +(byte3 a, byte b) => new(a.x + b, a.y + b, a.z + b);
        /// <inheritdoc cref="operator +(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator +(byte a, byte3 b) => new(a + b.x, a + b.y, a + b.z);
        
        /// Returns the result of a componentwise subtraction into an int3 vector.
        [MethodImpl(IL)] public static int3 operator -(byte3 a, byte3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <inheritdoc cref="operator -(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator -(byte3 a, byte b) => new(a.x - b, a.y - b, a.z - b);
        /// <inheritdoc cref="operator -(byte3, byte3)"/>
        [MethodImpl(IL)] public static int3 operator -(byte a, byte3 b) => new(a - b.x, a - b.y, a - b.z);
        
        /// Returns the result of a componentwise division into an f4 vector.
        [MethodImpl(IL)] public static float3 operator /(byte3 a, byte3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
        /// <inheritdoc cref="operator /(byte3, byte3)"/>
        [MethodImpl(IL)] public static float3 operator /(byte3 a, byte b) => new(a.x / b, a.y / b, a.z / b);
        /// <inheritdoc cref="operator /(byte3, byte3)"/>
        [MethodImpl(IL)] public static float3 operator /(byte a, byte3 b) => new(a / b.x, a / b.y, a / b.z);
        
        /// Returns the result of a componentwise modulus operation into an byte3 vector.
        [MethodImpl(IL)] public static byte3 operator %(byte3 a, byte3 b) => new(a.x % b.x, a.y % b.y, a.z % b.z);
        /// <inheritdoc cref="operator %(byte3, byte3)"/>
        [MethodImpl(IL)] public static byte3 operator %(byte3 a, byte b) => new(a.x % b, a.y % b, a.z % b);
        /// <inheritdoc cref="operator %(byte3, byte3)"/>
        [MethodImpl(IL)] public static byte3 operator %(byte a, byte3 b) => new(a % b.x, a % b.y, a % b.z);
        
        /// Adds one to each component of the byte3 vector.
        [MethodImpl(IL)] public static byte3 operator ++(byte3 v) => new(++v.x, ++v.y, ++v.z);
        ///Subtracts one from each component of the byte3 vector.
        [MethodImpl(IL)] public static byte3 operator --(byte3 v) => new(--v.x, --v.y, --v.z);
        
        /// Returns the result of a componentwise less than operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator <(byte3 a, byte3 b) => new(a.x < b.x, a.y < b.y, a.z < b.z);
        /// Returns the result of a componentwise less than operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator <(byte3 a, byte b) => new(a.x < b, a.y < b, a.z < b);
        /// Returns the result of a componentwise less than operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator <(byte a, byte3 b) => new(a < b.x, a < b.y, a < b.z);
        
        /// Returns the result of a componentwise less or equal operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator <=(byte3 a, byte3 b) => new(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        /// Returns the result of a componentwise less or equal operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator <=(byte3 a, byte b) => new(a.x <= b, a.y <= b, a.z <= b);
        /// Returns the result of a componentwise less or equal operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator <=(byte a, byte3 b) => new(a <= b.x, a <= b.y, a <= b.z);
      
        /// Returns the result of a componentwise greater than operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator >(byte3 a, byte3 b) => new(a.x > b.x, a.y > b.y, a.z > b.z);
        /// Returns the result of a componentwise greater than operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator >(byte3 a, byte b) => new(a.x > b, a.y > b, a.z > b);
        /// Returns the result of a componentwise greater than operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator >(byte a, byte3 b) => new(a > b.x, a > b.y, a > b.z);
        
        /// Returns the result of a componentwise greater or equal operation on two byte3 vectors.
        [MethodImpl(IL)] public static bool3 operator >=(byte3 a, byte3 b) => new(a.x >= b.x, a.y >= b.y, a.z >= b.z);
        /// Returns the result of a componentwise greater or equal operation on a byte3 vector and a byte value.
        [MethodImpl(IL)] public static bool3 operator >=(byte3 a, byte b) => new(a.x >= b, a.y >= b, a.z >= b);
        /// Returns the result of a componentwise greater or equal operation on a byte value and a byte3 vector.
        [MethodImpl(IL)] public static bool3 operator >=(byte a, byte3 b) => new(a >= b.x, a >= b.y, a >= b.z);
       
        /// Returns the result of a componentwise unary minus operation on a byte3 vector.
        [MethodImpl(IL)] public static byte3 operator -(byte3 v) => new(-v.x, -v.y, -v.z);
        /// Returns the result of a componentwise unary plus operation on a byte3 vector.
        [MethodImpl(IL)] public static byte3 operator +(byte3 v) => new(+v.x, +v.y, +v.z);
        
        
        /// <summary>Returns the result of a componentwise bitwise not operation on an byte3 vector.</summary>
        [MethodImpl(IL)]public static byte3 operator ~(byte3 val) => new(~val.x, ~val.y, ~val.z);
        
        /// <summary>Returns the result of a componentwise bitwise and operation on two byte3 vectors.</summary>
        [MethodImpl(IL)] public static byte3 operator &(byte3 a, byte3 b) => new(a.x & b.x, a.y & b.y, a.z & b.z);
        /// <summary>Returns the result of a componentwise bitwise and operation on an byte3 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte3 operator &(byte3 a, int b) => new(a.x & b, a.y & b, a.z & b);
        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an byte3 vector.</summary>
        [MethodImpl(IL)] public static byte3 operator &(int a, byte3 b) => new(a & b.x, a & b.y, a & b.z);

        /// <summary>Returns the result of a componentwise bitwise or operation on two byte3 vectors.</summary>
        [MethodImpl(IL)] public static byte3 operator |(byte3 a, byte3 b) => new(a.x | b.x, a.y | b.y, a.z | b.z);
        /// <summary>Returns the result of a componentwise bitwise or operation on an byte3 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte3 operator |(byte3 a, int b) => new(a.x | b, a.y | b, a.z | b);
        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an byte3 vector.</summary>
        [MethodImpl(IL)] public static byte3 operator |(int a, byte3 b) => new(a | b.x, a | b.y, a | b.z);

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two byte3 vectors.</summary>
        [MethodImpl(IL)] public static byte3 operator ^(byte3 a, byte3 b) => new(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an byte3 vector and an int value.</summary>
        [MethodImpl(IL)] public static byte3 operator ^(byte3 a, int b) => new(a.x ^ b, a.y ^ b, a.z ^ b);
        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an byte3 vector.</summary>
        [MethodImpl(IL)] public static byte3 operator ^(int a, byte3 b) => new(a ^ b.x, a ^ b.y, a ^ b.z);

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxx { [MethodImpl(IL)] get => new(x, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxy { [MethodImpl(IL)] get => new(x, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxxz { [MethodImpl(IL)] get => new(x, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyx { [MethodImpl(IL)] get => new(x, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyy { [MethodImpl(IL)] get => new(x, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxyz { [MethodImpl(IL)] get => new(x, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzx { [MethodImpl(IL)] get => new(x, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzy { [MethodImpl(IL)] get => new(x, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xxzz { [MethodImpl(IL)] get => new(x, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxx { [MethodImpl(IL)] get => new(x, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxy { [MethodImpl(IL)] get => new(x, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyxz { [MethodImpl(IL)] get => new(x, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyx { [MethodImpl(IL)] get => new(x, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyy { [MethodImpl(IL)] get => new(x, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyyz { [MethodImpl(IL)] get => new(x, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzx { [MethodImpl(IL)] get => new(x, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzy { [MethodImpl(IL)] get => new(x, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xyzz { [MethodImpl(IL)] get => new(x, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxx { [MethodImpl(IL)] get => new(x, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxy { [MethodImpl(IL)] get => new(x, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzxz { [MethodImpl(IL)] get => new(x, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyx { [MethodImpl(IL)] get => new(x, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyy { [MethodImpl(IL)] get => new(x, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzyz { [MethodImpl(IL)] get => new(x, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzx { [MethodImpl(IL)] get => new(x, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzy { [MethodImpl(IL)] get => new(x, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 xzzz { [MethodImpl(IL)] get => new(x, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxx { [MethodImpl(IL)] get => new(y, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxy { [MethodImpl(IL)] get => new(y, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxxz { [MethodImpl(IL)] get => new(y, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyx { [MethodImpl(IL)] get => new(y, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyy { [MethodImpl(IL)] get => new(y, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxyz { [MethodImpl(IL)] get => new(y, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzx { [MethodImpl(IL)] get => new(y, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzy { [MethodImpl(IL)] get => new(y, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yxzz { [MethodImpl(IL)] get => new(y, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxx { [MethodImpl(IL)] get => new(y, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxy { [MethodImpl(IL)] get => new(y, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyxz { [MethodImpl(IL)] get => new(y, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyx { [MethodImpl(IL)] get => new(y, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyy { [MethodImpl(IL)] get => new(y, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyyz { [MethodImpl(IL)] get => new(y, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzx { [MethodImpl(IL)] get => new(y, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzy { [MethodImpl(IL)] get => new(y, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yyzz { [MethodImpl(IL)] get => new(y, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxx { [MethodImpl(IL)] get => new(y, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxy { [MethodImpl(IL)] get => new(y, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzxz { [MethodImpl(IL)] get => new(y, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyx { [MethodImpl(IL)] get => new(y, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyy { [MethodImpl(IL)] get => new(y, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzyz { [MethodImpl(IL)] get => new(y, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzx { [MethodImpl(IL)] get => new(y, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzy { [MethodImpl(IL)] get => new(y, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 yzzz { [MethodImpl(IL)] get => new(y, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxx { [MethodImpl(IL)] get => new(z, x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxy { [MethodImpl(IL)] get => new(z, x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxxz { [MethodImpl(IL)] get => new(z, x, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyx { [MethodImpl(IL)] get => new(z, x, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyy { [MethodImpl(IL)] get => new(z, x, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxyz { [MethodImpl(IL)] get => new(z, x, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzx { [MethodImpl(IL)] get => new(z, x, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzy { [MethodImpl(IL)] get => new(z, x, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zxzz { [MethodImpl(IL)] get => new(z, x, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxx { [MethodImpl(IL)] get => new(z, y, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxy { [MethodImpl(IL)] get => new(z, y, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyxz { [MethodImpl(IL)] get => new(z, y, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyx { [MethodImpl(IL)] get => new(z, y, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyy { [MethodImpl(IL)] get => new(z, y, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyyz { [MethodImpl(IL)] get => new(z, y, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzx { [MethodImpl(IL)] get => new(z, y, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzy { [MethodImpl(IL)] get => new(z, y, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zyzz { [MethodImpl(IL)] get => new(z, y, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxx { [MethodImpl(IL)] get => new(z, z, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxy { [MethodImpl(IL)] get => new(z, z, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzxz { [MethodImpl(IL)] get => new(z, z, x, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyx { [MethodImpl(IL)] get => new(z, z, y, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyy { [MethodImpl(IL)] get => new(z, z, y, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzyz { [MethodImpl(IL)] get => new(z, z, y, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzx { [MethodImpl(IL)] get => new(z, z, z, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzy { [MethodImpl(IL)] get => new(z, z, z, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte4 zzzz { [MethodImpl(IL)] get => new(z, z, z, z); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxx { [MethodImpl(IL)] get => new(x, x, x); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxy { [MethodImpl(IL)] get => new(x, x, y); }

        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 xxz { [MethodImpl(IL)] get => new(x, x, z); }

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
        [EditorBrowsable(NEVER)] public byte3 yyx { [MethodImpl(IL)] get => new(y, y, x); }
        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyy { [MethodImpl(IL)] get => new(y, y, y); }
        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 yyz { [MethodImpl(IL)] get => new(y, y, z); }

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
        [EditorBrowsable(NEVER)] public byte3 zzx { [MethodImpl(IL)] get => new(z, z, x); }
        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzy { [MethodImpl(IL)] get => new(z, z, y); }
        /// Swizzles the vector.
        [EditorBrowsable(NEVER)] public byte3 zzz { [MethodImpl(IL)] get => new(z, z, z); }
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

        /// Returns the byte element at a specified index.
        public unsafe byte this[int index]
        {
            get {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3) throw new ArgumentException("index must be between[0...2]");
                #endif
                fixed (byte3* array = &this) {
                    return ((byte*)array)[index];
                }
            }
            set {
                #if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3) throw new ArgumentException("index must be between[0...2]");
                #endif
                fixed (byte* array = &x) {
                    array[index] = value;
                }
            }
        }

        /// Returns true if the byte3 is equal to a given byte3, false otherwise.
        /// <param name="b">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(IL)] public bool Equals(byte3 b) => x == b.x && y == b.y && z == b.z;

        /// Returns true if the byte3 is equal to a given byte3, false otherwise.
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte3 converted && Equals(converted);

        /// Returns a hash code for the byte3.
        /// <returns>The computed hash code.</returns>
        [MethodImpl(IL)] public override int GetHashCode() => (int)hash(this);

        /// Returns a string representation of the byte3.
        /// <returns>String representation of the value.</returns>
        [MethodImpl(IL)] public override string ToString() => $"byte3({x}, {y}, {z})";

        /// Returns a string representation of the byte3 using a specified format and culture-specific format information.
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(IL)] public string ToString(string format, IFormatProvider formatProvider) => $"byte3({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)}, {z.ToString(format, formatProvider)})";

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public byte z;

            public DebuggerProxy(byte3 v) { x = v.x; y = v.y; z = v.z; }
        }
    }

    public static partial class mathx
    {
        /// Returns a byte3 vector constructed from three byte values.
        [MethodImpl(IL)] public static byte3 byte3(byte x, byte y, byte z) => new(x, y, z);
        /// Returns a byte3 vector constructed from a byte value and a byte2 vector.
        [MethodImpl(IL)] public static byte3 byte3(byte x, byte2 yz) => new(x, yz);
        /// Returns a byte3 vector constructed from a byte2 vector and a byte value.
        [MethodImpl(IL)] public static byte3 byte3(byte2 xy, byte z) => new(xy, z);
        /// Returns a byte3 vector constructed from a single byte value by assigning it to every component.
        [MethodImpl(IL)] public static byte3 byte3(byte v) => new(v);
        /// Returns a byte3 vector constructed from a single int value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static byte3 byte3(int v) => new(v);
        /// Return a byte3 vector constructed from a int3 vector by componentwise conversion.
        [MethodImpl(IL)] public static byte3 byte3(int3 v) => new(v);
        /// Returns a byte3 vector constructed from a single uint value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static byte3 byte3(uint v) => new(v);
        /// Return a byte3 vector constructed from a uint3 vector by componentwise conversion.
        [MethodImpl(IL)] public static byte3 byte3(uint3 v) => new(v);
        /// Returns a byte3 vector constructed from a single float value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static byte3 byte3(float v) => new(v);
        /// Return a byte3 vector constructed from a f3 vector by componentwise conversion.
        [MethodImpl(IL)] public static byte3 byte3(float3 v) => new(v);
        /// Returns a byte3 vector constructed from a single double value by converting it to byte and assigning it to every component.
        [MethodImpl(IL)] public static byte3 byte3(double v) => new(v);
        /// Return a byte3 vector constructed from a double3 vector by componentwise conversion.
        [MethodImpl(IL)] public static byte3 byte3(double3 v) => new(v);
        
        /// Returns a uint hash code of a byte3 vector.
        [MethodImpl(IL)] public static uint hash(byte3 v) => math.csum(uint3(v.x, v.y, v.z) * uint3(0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        
        /// Returns a uint3 vector hash code of a byte3 vector.
        [MethodImpl(IL)] public static uint3 hashwide(byte3 v) => uint3(v.x, v.y, v.z) * uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u) + 0x94DDD769u;


        /// <inheritdoc cref="swapx(Unity.Mathematics.byte4, byte)"/>
        [MethodImpl(IL)] public static byte3 swapx(this byte3 f, byte x) => new(x, f.y, f.z);
        /// <inheritdoc cref="swapy(Unity.Mathematics.byte4, byte)"/>
        [MethodImpl(IL)] public static byte3 swapy(this byte3 f, byte y) => new(f.x, y, f.z);
        /// <inheritdoc cref="swapz(Unity.Mathematics.byte4, byte)"/>
        [MethodImpl(IL)] public static byte3 swapz(this byte3 f, byte z) => new(f.x, f.y, z);
    }
}