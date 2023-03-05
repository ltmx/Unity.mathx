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
using static UnityEditor.Build.Il2CppCodeGeneration;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    /// <summary>A 3 component vector of bytes.</summary>
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    // [Il2CppEagerStaticClassConstruction]
    public struct byte3 : IEquatable<byte3>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public byte x;

        /// <summary>y component of the vector.</summary>
        public byte y;

        /// <summary>z component of the vector.</summary>
        public byte z;

        /// <summary>byte3 zero value.</summary>
        public static readonly byte3 zero = 0;

        /// <summary>Constructs a byte3 vector from three byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte3(byte x, byte y, byte z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a byte3 vector from a byte value and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte3(byte x, byte2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        /// <summary>Constructs a byte3 vector from a byte2 vector and a byte value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte3(byte2 xy, byte z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a byte3 vector from a byte3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        [MethodImpl(INLINE)]
        public byte3(byte3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        /// <summary>Constructs a byte3 vector from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        [MethodImpl(INLINE)]
        public byte3(byte v)
        {
            x = v;
            y = v;
            z = v;
        }

        /// <summary>
        ///     Constructs a byte3 vector from a single float value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte3</param>
        [MethodImpl(INLINE)]
        public byte3(float v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        [MethodImpl(INLINE)]
        public byte3(float3 v)
        {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
        }

        /// <summary>
        ///     Constructs a byte3 vector from a single double value by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte3</param>
        [MethodImpl(INLINE)]
        public byte3(double v)
        {
            x = (byte)v;
            y = (byte)v;
            z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        [MethodImpl(INLINE)]
        public byte3(double3 v)
        {
            x = (byte)v.x;
            y = (byte)v.y;
            z = (byte)v.z;
        }

        /// <summary>Implicitly converts a single byte value to a byte3 vector by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static implicit operator byte3(byte v) => new(v);

        /// <summary>
        ///     Explicitly converts a single float value to a byte3 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">float to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte3(float v) => new(v);

        /// <summary>Explicitly converts a float3 vector to a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte3(float3 v) => new(v);

        /// <summary>
        ///     Explicitly converts a single double value to a byte3 vector by converting it to byte and assigning it to every
        ///     component.
        /// </summary>
        /// <param name="v">double to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte3(double v) => new(v);

        /// <summary>Explicitly converts a double3 vector to a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static explicit operator byte3(double3 v) => new(v);

        /// <summary>Returns the result of a componentwise equality operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator ==(byte3 lhs, byte3 rhs) => new(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);

        /// <summary>Returns the result of a componentwise equality operation on a byte3 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator ==(byte3 lhs, byte rhs) => new(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);

        /// <summary>Returns the result of a componentwise equality operation on a byte value and a byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator ==(byte lhs, byte3 rhs) => new(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);

        /// <summary>Returns the result of a componentwise not equal operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator !=(byte3 lhs, byte3 rhs) => new(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);

        /// <summary>Returns the result of a componentwise not equal operation on a byte3 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator !=(byte3 lhs, byte rhs) => new(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);

        /// <summary>Returns the result of a componentwise not equal operation on a byte value and a byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(INLINE)]
        public static bool3 operator !=(byte lhs, byte3 rhs) => new(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);

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

        /// <summary>Returns the byte element at a specified index.</summary>
        public unsafe byte this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3) throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (byte3* array = &this)
                {
                    return ((byte*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3) throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (byte* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the byte3 is equal to a given byte3, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(INLINE)]
        public bool Equals(byte3 rhs) => x == rhs.x && y == rhs.y && z == rhs.z;

        /// <summary>Returns true if the byte3 is equal to a given byte3, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) => o is byte3 converted && Equals(converted);

        /// <summary>Returns a hash code for the byte3.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(INLINE)]
        public override int GetHashCode() => (int)mathx.hash(this);

        /// <summary>Returns a string representation of the byte3.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public override string ToString() => $"byte3({x}, {y}, {z})";

        /// <summary>Returns a string representation of the byte3 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(INLINE)]
        public string ToString(string format, IFormatProvider formatProvider) => $"byte3({x.ToString(format, formatProvider)}, {y.ToString(format, formatProvider)}, {z.ToString(format, formatProvider)})";

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public byte z;

            public DebuggerProxy(byte3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }
    }

    public static partial class mathx
    {
        /// <summary>Returns a byte3 vector constructed from three byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(byte x, byte y, byte z) => new(x, y, z);

        /// <summary>Returns a byte3 vector constructed from a byte value and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(byte x, byte2 yz) => new(x, yz);

        /// <summary>Returns a byte3 vector constructed from a byte2 vector and a byte value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(byte2 xy, byte z) => new(xy, z);

        /// <summary>Returns a byte3 vector constructed from a byte3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(byte3 xyz) => new(xyz);

        /// <summary>Returns a byte3 vector constructed from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(byte v) => new(v);

        /// <summary>
        ///     Returns a byte3 vector constructed from a single float value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">float to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(float v) => new(v);

        /// <summary>Return a byte3 vector constructed from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(float3 v) => new(v);

        /// <summary>
        ///     Returns a byte3 vector constructed from a single double value by converting it to byte and assigning it to
        ///     every component.
        /// </summary>
        /// <param name="v">double to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(double v) => new(v);

        /// <summary>Return a byte3 vector constructed from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(INLINE)]
        public static byte3 byte3(double3 v) => new(v);

        /// <summary>Returns a uint hash code of a byte3 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint hash(byte3 v) => csum(uint3(v.x, v.y, v.z) * uint3(0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;

        /// <summary>
        ///     Returns a uint3 vector hash code of a byte3 vector.
        ///     When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        ///     that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(INLINE)]
        public static uint3 hashwide(byte3 v) => uint3(v.x, v.y, v.z) * uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u) + 0x94DDD769u;
    }
}