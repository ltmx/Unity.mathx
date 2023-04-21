#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;
using State = System.ComponentModel.EditorBrowsableState;

namespace Unity.Mathematics
{
    [Serializable]
    public struct color : IEquatable<color>, IFormattable
    {
        public float x;
        public float y;
        public float z;
        public float w;
        public float r => x;
        public float g => y;
        public float b => z;
        public float a => w;
        public float2 rg => xy;
        public float2 rb => xz;
        public float2 gr => yx;
        public float2 gb => yz;
        public float2 br => zx;
        public float2 bg => zy;
        public float3 rgb => xyz;
        public float3 rbg => xzy;
        public float3 grb => yxz;
        public float3 gbr => yzx;
        public float3 brg => zxy;
        public float3 bgr => zyx;

        /// <summary>color zero value.</summary>
        public static readonly color zero = 0;

        private const int INLINE = 256;
        
        /// <summary>Constructs a color vector from four float values.</summary>
        [MethodImpl(INLINE)]
        public color(float x, float y, float z, float w) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        /// <summary>Constructs a color vector from two float values and a f2 vector.</summary>
        [MethodImpl(INLINE)] public color(float x, float y, float2 zw) {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        /// <summary>Constructs a color vector from a float value, a f2 vector and a float value.</summary>
        [MethodImpl(INLINE)] public color(float x, float2 yz, float w) {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        /// <summary>Constructs a color vector from a float value and a f3 vector.</summary>
        [MethodImpl(INLINE)] public color(float x, float3 yzw) {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        /// <summary>Constructs a color vector from a f2 vector and two float values.</summary>
        [MethodImpl(INLINE)] public color(float2 xy, float z, float w) {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        /// <summary>Constructs a color vector from two float2 vectors.</summary>
        [MethodImpl(INLINE)] public color(float2 xy, float2 zw) {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        /// <summary>Constructs a color vector from a f3 vector and a float value.</summary>
        [MethodImpl(INLINE)] public color(float3 xyz, float w) {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        /// <summary>Constructs a color vector from a color vector.</summary>
        [MethodImpl(INLINE)] public color(color xyzw) {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        /// <summary>Constructs a color vector from a single float value by assigning it to xyz components, and 1 in w.</summary>
        [MethodImpl(INLINE)] public color(float v) {
            x = v;
            y = v;
            z = v;
            w = 1;
        }
        /// <summary>
        ///     Constructs a color vector from a single bool value by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public color(bool v) {
            x = v ? 1 : 0;
            y = v ? 1 : 0;
            z = v ? 1 : 0;
            w = v ? 1 : 0;
        }
        /// <summary>Constructs a color vector from a bool4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(bool4 v) {
            x = v.x ? 1 : 0;
            y = v.y ? 1 : 0;
            z = v.z ? 1 : 0;
            w = v.w ? 1 : 0;
        }
        /// <summary>
        ///     Constructs a color vector from a single int value by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public color(int v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        /// <summary>Constructs a color vector from a int4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(int4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>
        ///     Constructs a color vector from a single uint value by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public color(uint v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        /// <summary>Constructs a color vector from a uint4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(uint4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>
        ///     Constructs a color vector from a single half value by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public color(half v) {
            x = v;
            y = v;
            z = v;
            w = v;
        }
        /// <summary>Constructs a color vector from a half4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(half4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>
        ///     Constructs a color vector from a single double value by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public color(double v) {
            x = (float)v;
            y = (float)v;
            z = (float)v;
            w = (float)v;
        }
        /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(double4 v) {
            x = (float)v.x;
            y = (float)v.y;
            z = (float)v.z;
            w = (float)v.w;
        }
        /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(Color v) {
            x = v.r;
            y = v.g;
            z = v.b;
            w = v.a;
        }
        /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(float4 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public color(float3 v) {
            x = v.x;
            y = v.y;
            z = v.z;
            w = 1;
        }

        // Additions -------------------------------
        /// <para>Constructs a new color with given r,g,b components and sets a to 1.</para>
        /// <param name="x">Red component.</param>
        /// <param name="y">Green component.</param>
        /// <param name="z">Blue component.</param>
        public color(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
            w = 1;
        }
        /// <para>Constructs a new color with x in r,g,b components and sets y to alpha.</para>
        /// <param name="x">Red component.</param>
        /// <param name="y">Green component.</param>
        public color(float x, float y) {
            this.x = x;
            this.y = x;
            z = x;
            w = y;
        }

        // End Additions -------------------------------
        /// <summary>Implicitly converts a single float value to a color by assigning it to every component.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(float v) => new(v);
        /// <summary>
        ///     Explicitly converts a single bool value to a color by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public static explicit operator color(bool v) => new(v);
        /// <summary>Explicitly converts a bool4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator color(bool4 v) => new(v);
        /// <summary>
        ///     Implicitly converts a single int value to a color by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public static implicit operator color(int v) => new(v);
        /// <summary>Implicitly converts a int4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(int4 v) => new(v);
        /// <summary>
        ///     Implicitly converts a single uint value to a color by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public static implicit operator color(uint v) => new(v);
        /// <summary>Implicitly converts a uint4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(uint4 v) => new(v);
        /// <summary>
        ///     Implicitly converts a single half value to a color by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public static implicit operator color(half v) => new(v);
        /// <summary>Implicitly converts a half4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(half4 v) => new(v);
        /// <summary>
        ///     Explicitly converts a single double value to a vector by converting it to float and assigning it to every
        ///     component.
        /// </summary>
        [MethodImpl(INLINE)] public static explicit operator color(double v) => new(v);
        /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator color(double4 v) => new(v);
        /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(float4 v) => new(v);
        /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(float3 v) => new(v);

        // Additions --------------------------------------------------------------
        /// <summary>Implicitly converts a color vector to a f4 by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator float4(color v) => new(v.x, v.y, v.z, v.w);
        /// <summary>Explicitly converts a color vector to a f3 by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator float3(color v) => new(v.x, v.y, v.z);
        /// <summary>Explicitly converts a color to a UnityEngine.Color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator Color(color b) => new(b.x, b.y, b.z, b.w);
        /// <summary>Implicitly converts a UnityEngine.Color to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(Color b) => new(b.r, b.g, b.b, b.a);
        /// <summary>Implicitly converts a UnityEngine.Color32 to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator color(Color32 b) => new(b.r, b.g, b.b, b.a);
        /// <summary>Implicitly converts a UnityEngine.Color32 to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static implicit operator Color32(color b) => new((byte)b.r, (byte)b.g, (byte)b.b, (byte)b.a);
        /// <summary>Explicitly converts a color to a Vector4 by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator Vector4(color c) => new(c.x, c.y, c.z, c.w);
        /// <summary>Explicitly converts a Vector4 to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator color(Vector4 v) => new(v.x, v.y, v.z, v.w);
        /// <summary>Explicitly converts a color to a Vector3 by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator Vector3(color c) => new(c.x, c.y, c.z);
        /// <summary>Explicitly converts a Vector3 to a color by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static explicit operator color(Vector3 v) => new(v.x, v.y, v.z, 1);

        // End Additions --------------------------------------------------------------
        /// <summary>Returns the result of a componentwise multiplication operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static color operator *(color lhs, color rhs) => new(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        /// <summary>Returns the result of a componentwise multiplication operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color operator *(color lhs, float rhs) => new(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator *(float lhs, color rhs) => new(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        /// <summary>Returns the result of a componentwise addition operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static color operator +(color lhs, color rhs) => new(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        /// <summary>Returns the result of a componentwise addition operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color operator +(color lhs, float rhs) => new(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        /// <summary>Returns the result of a componentwise addition operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator +(float lhs, color rhs) => new(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        /// <summary>Returns the result of a componentwise subtraction operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static color operator -(color lhs, color rhs) => new(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        /// <summary>Returns the result of a componentwise subtraction operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color operator -(color lhs, float rhs) => new(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator -(float lhs, color rhs) => new(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        /// <summary>Returns the result of a componentwise division operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static color operator /(color lhs, color rhs) => new(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        /// <summary>Returns the result of a componentwise division operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color operator /(color lhs, float rhs) => new(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        /// <summary>Returns the result of a componentwise division operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator /(float lhs, color rhs) => new(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        /// <summary>Returns the result of a componentwise modulus operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static color operator %(color lhs, color rhs) => new(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        /// <summary>Returns the result of a componentwise modulus operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color operator %(color lhs, float rhs) => new(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        /// <summary>Returns the result of a componentwise modulus operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator %(float lhs, color rhs) => new(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        /// <summary>Returns the result of a componentwise increment operation on a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator ++(color val) => new(++val.x, ++val.y, ++val.z, ++val.w);
        /// <summary>Returns the result of a componentwise decrement operation on a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator --(color val) => new(--val.x, --val.y, --val.z, --val.w);
        /// <summary>Returns the result of a componentwise less than operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <(color lhs, color rhs) => new(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        /// <summary>Returns the result of a componentwise less than operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <(color lhs, float rhs) => new(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        /// <summary>Returns the result of a componentwise less than operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <(float lhs, color rhs) => new(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        /// <summary>Returns the result of a componentwise less or equal operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <=(color lhs, color rhs) => new(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        /// <summary>Returns the result of a componentwise less or equal operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <=(color lhs, float rhs) => new(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator <=(float lhs, color rhs) => new(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        /// <summary>Returns the result of a componentwise greater than operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >(color lhs, color rhs) => new(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        /// <summary>Returns the result of a componentwise greater than operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >(color lhs, float rhs) => new(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        /// <summary>Returns the result of a componentwise greater than operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >(float lhs, color rhs) => new(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        /// <summary>Returns the result of a componentwise greater or equal operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >=(color lhs, color rhs) => new(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        /// <summary>Returns the result of a componentwise greater or equal operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >=(color lhs, float rhs) => new(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator >=(float lhs, color rhs) => new(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        /// <summary>Returns the result of a componentwise unary minus operation on a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator -(color val) => new(-val.x, -val.y, -val.z, -val.w);
        /// <summary>Returns the result of a componentwise unary plus operation on a color vector.</summary>
        [MethodImpl(INLINE)] public static color operator +(color val) => new(+val.x, +val.y, +val.z, +val.w);
        /// <summary>Returns the result of a componentwise equality operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator ==(color lhs, color rhs) => new(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        /// <summary>Returns the result of a componentwise equality operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator ==(color lhs, float rhs) => new(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        /// <summary>Returns the result of a componentwise equality operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator ==(float lhs, color rhs) => new(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        /// <summary>Returns the result of a componentwise not equal operation on two color vectors.</summary>
        [MethodImpl(INLINE)] public static bool4 operator !=(color lhs, color rhs) => new(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        /// <summary>Returns the result of a componentwise not equal operation on a color vector and a float value.</summary>
        [MethodImpl(INLINE)] public static bool4 operator !=(color lhs, float rhs) => new(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        /// <summary>Returns the result of a componentwise not equal operation on a float value and a color vector.</summary>
        [MethodImpl(INLINE)] public static bool4 operator !=(float lhs, color rhs) => new(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        [EditorBrowsable(State.Never)] public color xxxx { [MethodImpl(INLINE)] get => new(x, x, x, x); }
        [EditorBrowsable(State.Never)] public color xxxy { [MethodImpl(INLINE)] get => new(x, x, x, y); }
        [EditorBrowsable(State.Never)] public color xxxz { [MethodImpl(INLINE)] get => new(x, x, x, z); }
        [EditorBrowsable(State.Never)] public color xxxw { [MethodImpl(INLINE)] get => new(x, x, x, w); }
        [EditorBrowsable(State.Never)] public color xxyx { [MethodImpl(INLINE)] get => new(x, x, y, x); }
        [EditorBrowsable(State.Never)] public color xxyy { [MethodImpl(INLINE)] get => new(x, x, y, y); }
        [EditorBrowsable(State.Never)] public color xxyz { [MethodImpl(INLINE)] get => new(x, x, y, z); }
        [EditorBrowsable(State.Never)] public color xxyw { [MethodImpl(INLINE)] get => new(x, x, y, w); }
        [EditorBrowsable(State.Never)] public color xxzx { [MethodImpl(INLINE)] get => new(x, x, z, x); }
        [EditorBrowsable(State.Never)] public color xxzy { [MethodImpl(INLINE)] get => new(x, x, z, y); }
        [EditorBrowsable(State.Never)] public color xxzz { [MethodImpl(INLINE)] get => new(x, x, z, z); }
        [EditorBrowsable(State.Never)] public color xxzw { [MethodImpl(INLINE)] get => new(x, x, z, w); }
        [EditorBrowsable(State.Never)] public color xxwx { [MethodImpl(INLINE)] get => new(x, x, w, x); }
        [EditorBrowsable(State.Never)] public color xxwy { [MethodImpl(INLINE)] get => new(x, x, w, y); }
        [EditorBrowsable(State.Never)] public color xxwz { [MethodImpl(INLINE)] get => new(x, x, w, z); }
        [EditorBrowsable(State.Never)] public color xxww { [MethodImpl(INLINE)] get => new(x, x, w, w); }
        [EditorBrowsable(State.Never)] public color xyxx { [MethodImpl(INLINE)] get => new(x, y, x, x); }
        [EditorBrowsable(State.Never)] public color xyxy { [MethodImpl(INLINE)] get => new(x, y, x, y); }
        [EditorBrowsable(State.Never)] public color xyxz { [MethodImpl(INLINE)] get => new(x, y, x, z); }
        [EditorBrowsable(State.Never)] public color xyxw { [MethodImpl(INLINE)] get => new(x, y, x, w); }
        [EditorBrowsable(State.Never)] public color xyyx { [MethodImpl(INLINE)] get => new(x, y, y, x); }
        [EditorBrowsable(State.Never)] public color xyyy { [MethodImpl(INLINE)] get => new(x, y, y, y); }
        [EditorBrowsable(State.Never)] public color xyyz { [MethodImpl(INLINE)] get => new(x, y, y, z); }
        [EditorBrowsable(State.Never)] public color xyyw { [MethodImpl(INLINE)] get => new(x, y, y, w); }
        [EditorBrowsable(State.Never)] public color xyzx { [MethodImpl(INLINE)] get => new(x, y, z, x); }
        [EditorBrowsable(State.Never)] public color xyzy { [MethodImpl(INLINE)] get => new(x, y, z, y); }
        [EditorBrowsable(State.Never)] public color xyzz { [MethodImpl(INLINE)] get => new(x, y, z, z); }

        [EditorBrowsable(State.Never)] public color xyzw
        {
            [MethodImpl(INLINE)] get => new(x, y, z, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xywx { [MethodImpl(INLINE)] get => new(x, y, w, x); }
        [EditorBrowsable(State.Never)] public color xywy { [MethodImpl(INLINE)] get => new(x, y, w, y); }

        [EditorBrowsable(State.Never)] public color xywz
        {
            [MethodImpl(INLINE)] get => new(x, y, w, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xyww { [MethodImpl(INLINE)] get => new(x, y, w, w); }
        [EditorBrowsable(State.Never)] public color xzxx { [MethodImpl(INLINE)] get => new(x, z, x, x); }
        [EditorBrowsable(State.Never)] public color xzxy { [MethodImpl(INLINE)] get => new(x, z, x, y); }
        [EditorBrowsable(State.Never)] public color xzxz { [MethodImpl(INLINE)] get => new(x, z, x, z); }
        [EditorBrowsable(State.Never)] public color xzxw { [MethodImpl(INLINE)] get => new(x, z, x, w); }
        [EditorBrowsable(State.Never)] public color xzyx { [MethodImpl(INLINE)] get => new(x, z, y, x); }
        [EditorBrowsable(State.Never)] public color xzyy { [MethodImpl(INLINE)] get => new(x, z, y, y); }
        [EditorBrowsable(State.Never)] public color xzyz { [MethodImpl(INLINE)] get => new(x, z, y, z); }

        [EditorBrowsable(State.Never)] public color xzyw
        {
            [MethodImpl(INLINE)] get => new(x, z, y, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xzzx { [MethodImpl(INLINE)] get => new(x, z, z, x); }
        [EditorBrowsable(State.Never)] public color xzzy { [MethodImpl(INLINE)] get => new(x, z, z, y); }
        [EditorBrowsable(State.Never)] public color xzzz { [MethodImpl(INLINE)] get => new(x, z, z, z); }
        [EditorBrowsable(State.Never)] public color xzzw { [MethodImpl(INLINE)] get => new(x, z, z, w); }
        [EditorBrowsable(State.Never)] public color xzwx { [MethodImpl(INLINE)] get => new(x, z, w, x); }

        [EditorBrowsable(State.Never)] public color xzwy
        {
            [MethodImpl(INLINE)] get => new(x, z, w, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xzwz { [MethodImpl(INLINE)] get => new(x, z, w, z); }
        [EditorBrowsable(State.Never)] public color xzww { [MethodImpl(INLINE)] get => new(x, z, w, w); }
        [EditorBrowsable(State.Never)] public color xwxx { [MethodImpl(INLINE)] get => new(x, w, x, x); }
        [EditorBrowsable(State.Never)] public color xwxy { [MethodImpl(INLINE)] get => new(x, w, x, y); }
        [EditorBrowsable(State.Never)] public color xwxz { [MethodImpl(INLINE)] get => new(x, w, x, z); }
        [EditorBrowsable(State.Never)] public color xwxw { [MethodImpl(INLINE)] get => new(x, w, x, w); }
        [EditorBrowsable(State.Never)] public color xwyx { [MethodImpl(INLINE)] get => new(x, w, y, x); }
        [EditorBrowsable(State.Never)] public color xwyy { [MethodImpl(INLINE)] get => new(x, w, y, y); }

        [EditorBrowsable(State.Never)] public color xwyz
        {
            [MethodImpl(INLINE)] get => new(x, w, y, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xwyw { [MethodImpl(INLINE)] get => new(x, w, y, w); }
        [EditorBrowsable(State.Never)] public color xwzx { [MethodImpl(INLINE)] get => new(x, w, z, x); }

        [EditorBrowsable(State.Never)] public color xwzy
        {
            [MethodImpl(INLINE)] get => new(x, w, z, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color xwzz { [MethodImpl(INLINE)] get => new(x, w, z, z); }
        [EditorBrowsable(State.Never)] public color xwzw { [MethodImpl(INLINE)] get => new(x, w, z, w); }
        [EditorBrowsable(State.Never)] public color xwwx { [MethodImpl(INLINE)] get => new(x, w, w, x); }
        [EditorBrowsable(State.Never)] public color xwwy { [MethodImpl(INLINE)] get => new(x, w, w, y); }
        [EditorBrowsable(State.Never)] public color xwwz { [MethodImpl(INLINE)] get => new(x, w, w, z); }
        [EditorBrowsable(State.Never)] public color xwww { [MethodImpl(INLINE)] get => new(x, w, w, w); }
        [EditorBrowsable(State.Never)] public color yxxx { [MethodImpl(INLINE)] get => new(y, x, x, x); }
        [EditorBrowsable(State.Never)] public color yxxy { [MethodImpl(INLINE)] get => new(y, x, x, y); }
        [EditorBrowsable(State.Never)] public color yxxz { [MethodImpl(INLINE)] get => new(y, x, x, z); }
        [EditorBrowsable(State.Never)] public color yxxw { [MethodImpl(INLINE)] get => new(y, x, x, w); }
        [EditorBrowsable(State.Never)] public color yxyx { [MethodImpl(INLINE)] get => new(y, x, y, x); }
        [EditorBrowsable(State.Never)] public color yxyy { [MethodImpl(INLINE)] get => new(y, x, y, y); }
        [EditorBrowsable(State.Never)] public color yxyz { [MethodImpl(INLINE)] get => new(y, x, y, z); }
        [EditorBrowsable(State.Never)] public color yxyw { [MethodImpl(INLINE)] get => new(y, x, y, w); }
        [EditorBrowsable(State.Never)] public color yxzx { [MethodImpl(INLINE)] get => new(y, x, z, x); }
        [EditorBrowsable(State.Never)] public color yxzy { [MethodImpl(INLINE)] get => new(y, x, z, y); }
        [EditorBrowsable(State.Never)] public color yxzz { [MethodImpl(INLINE)] get => new(y, x, z, z); }

        [EditorBrowsable(State.Never)] public color yxzw
        {
            [MethodImpl(INLINE)] get => new(y, x, z, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color yxwx { [MethodImpl(INLINE)] get => new(y, x, w, x); }
        [EditorBrowsable(State.Never)] public color yxwy { [MethodImpl(INLINE)] get => new(y, x, w, y); }

        [EditorBrowsable(State.Never)] public color yxwz
        {
            [MethodImpl(INLINE)] get => new(y, x, w, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color yxww { [MethodImpl(INLINE)] get => new(y, x, w, w); }
        [EditorBrowsable(State.Never)] public color yyxx { [MethodImpl(INLINE)] get => new(y, y, x, x); }
        [EditorBrowsable(State.Never)] public color yyxy { [MethodImpl(INLINE)] get => new(y, y, x, y); }
        [EditorBrowsable(State.Never)] public color yyxz { [MethodImpl(INLINE)] get => new(y, y, x, z); }
        [EditorBrowsable(State.Never)] public color yyxw { [MethodImpl(INLINE)] get => new(y, y, x, w); }
        [EditorBrowsable(State.Never)] public color yyyx { [MethodImpl(INLINE)] get => new(y, y, y, x); }
        [EditorBrowsable(State.Never)] public color yyyy { [MethodImpl(INLINE)] get => new(y, y, y, y); }
        [EditorBrowsable(State.Never)] public color yyyz { [MethodImpl(INLINE)] get => new(y, y, y, z); }
        [EditorBrowsable(State.Never)] public color yyyw { [MethodImpl(INLINE)] get => new(y, y, y, w); }
        [EditorBrowsable(State.Never)] public color yyzx { [MethodImpl(INLINE)] get => new(y, y, z, x); }
        [EditorBrowsable(State.Never)] public color yyzy { [MethodImpl(INLINE)] get => new(y, y, z, y); }
        [EditorBrowsable(State.Never)] public color yyzz { [MethodImpl(INLINE)] get => new(y, y, z, z); }
        [EditorBrowsable(State.Never)] public color yyzw { [MethodImpl(INLINE)] get => new(y, y, z, w); }
        [EditorBrowsable(State.Never)] public color yywx { [MethodImpl(INLINE)] get => new(y, y, w, x); }
        [EditorBrowsable(State.Never)] public color yywy { [MethodImpl(INLINE)] get => new(y, y, w, y); }
        [EditorBrowsable(State.Never)] public color yywz { [MethodImpl(INLINE)] get => new(y, y, w, z); }
        [EditorBrowsable(State.Never)] public color yyww { [MethodImpl(INLINE)] get => new(y, y, w, w); }
        [EditorBrowsable(State.Never)] public color yzxx { [MethodImpl(INLINE)] get => new(y, z, x, x); }
        [EditorBrowsable(State.Never)] public color yzxy { [MethodImpl(INLINE)] get => new(y, z, x, y); }
        [EditorBrowsable(State.Never)] public color yzxz { [MethodImpl(INLINE)] get => new(y, z, x, z); }

        [EditorBrowsable(State.Never)] public color yzxw
        {
            [MethodImpl(INLINE)] get => new(y, z, x, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color yzyx { [MethodImpl(INLINE)] get => new(y, z, y, x); }
        [EditorBrowsable(State.Never)] public color yzyy { [MethodImpl(INLINE)] get => new(y, z, y, y); }
        [EditorBrowsable(State.Never)] public color yzyz { [MethodImpl(INLINE)] get => new(y, z, y, z); }
        [EditorBrowsable(State.Never)] public color yzyw { [MethodImpl(INLINE)] get => new(y, z, y, w); }
        [EditorBrowsable(State.Never)] public color yzzx { [MethodImpl(INLINE)] get => new(y, z, z, x); }
        [EditorBrowsable(State.Never)] public color yzzy { [MethodImpl(INLINE)] get => new(y, z, z, y); }
        [EditorBrowsable(State.Never)] public color yzzz { [MethodImpl(INLINE)] get => new(y, z, z, z); }
        [EditorBrowsable(State.Never)] public color yzzw { [MethodImpl(INLINE)] get => new(y, z, z, w); }

        [EditorBrowsable(State.Never)] public color yzwx
        {
            [MethodImpl(INLINE)] get => new(y, z, w, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color yzwy { [MethodImpl(INLINE)] get => new(y, z, w, y); }
        [EditorBrowsable(State.Never)] public color yzwz { [MethodImpl(INLINE)] get => new(y, z, w, z); }
        [EditorBrowsable(State.Never)] public color yzww { [MethodImpl(INLINE)] get => new(y, z, w, w); }
        [EditorBrowsable(State.Never)] public color ywxx { [MethodImpl(INLINE)] get => new(y, w, x, x); }
        [EditorBrowsable(State.Never)] public color ywxy { [MethodImpl(INLINE)] get => new(y, w, x, y); }

        [EditorBrowsable(State.Never)] public color ywxz
        {
            [MethodImpl(INLINE)] get => new(y, w, x, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color ywxw { [MethodImpl(INLINE)] get => new(y, w, x, w); }
        [EditorBrowsable(State.Never)] public color ywyx { [MethodImpl(INLINE)] get => new(y, w, y, x); }
        [EditorBrowsable(State.Never)] public color ywyy { [MethodImpl(INLINE)] get => new(y, w, y, y); }
        [EditorBrowsable(State.Never)] public color ywyz { [MethodImpl(INLINE)] get => new(y, w, y, z); }
        [EditorBrowsable(State.Never)] public color ywyw { [MethodImpl(INLINE)] get => new(y, w, y, w); }

        [EditorBrowsable(State.Never)] public color ywzx
        {
            [MethodImpl(INLINE)] get => new(y, w, z, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color ywzy { [MethodImpl(INLINE)] get => new(y, w, z, y); }
        [EditorBrowsable(State.Never)] public color ywzz { [MethodImpl(INLINE)] get => new(y, w, z, z); }
        [EditorBrowsable(State.Never)] public color ywzw { [MethodImpl(INLINE)] get => new(y, w, z, w); }
        [EditorBrowsable(State.Never)] public color ywwx { [MethodImpl(INLINE)] get => new(y, w, w, x); }
        [EditorBrowsable(State.Never)] public color ywwy { [MethodImpl(INLINE)] get => new(y, w, w, y); }
        [EditorBrowsable(State.Never)] public color ywwz { [MethodImpl(INLINE)] get => new(y, w, w, z); }
        [EditorBrowsable(State.Never)] public color ywww { [MethodImpl(INLINE)] get => new(y, w, w, w); }
        [EditorBrowsable(State.Never)] public color zxxx { [MethodImpl(INLINE)] get => new(z, x, x, x); }
        [EditorBrowsable(State.Never)] public color zxxy { [MethodImpl(INLINE)] get => new(z, x, x, y); }
        [EditorBrowsable(State.Never)] public color zxxz { [MethodImpl(INLINE)] get => new(z, x, x, z); }
        [EditorBrowsable(State.Never)] public color zxxw { [MethodImpl(INLINE)] get => new(z, x, x, w); }
        [EditorBrowsable(State.Never)] public color zxyx { [MethodImpl(INLINE)] get => new(z, x, y, x); }
        [EditorBrowsable(State.Never)] public color zxyy { [MethodImpl(INLINE)] get => new(z, x, y, y); }
        [EditorBrowsable(State.Never)] public color zxyz { [MethodImpl(INLINE)] get => new(z, x, y, z); }

        [EditorBrowsable(State.Never)] public color zxyw
        {
            [MethodImpl(INLINE)] get => new(z, x, y, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zxzx { [MethodImpl(INLINE)] get => new(z, x, z, x); }
        [EditorBrowsable(State.Never)] public color zxzy { [MethodImpl(INLINE)] get => new(z, x, z, y); }
        [EditorBrowsable(State.Never)] public color zxzz { [MethodImpl(INLINE)] get => new(z, x, z, z); }
        [EditorBrowsable(State.Never)] public color zxzw { [MethodImpl(INLINE)] get => new(z, x, z, w); }
        [EditorBrowsable(State.Never)] public color zxwx { [MethodImpl(INLINE)] get => new(z, x, w, x); }

        [EditorBrowsable(State.Never)] public color zxwy
        {
            [MethodImpl(INLINE)] get => new(z, x, w, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zxwz { [MethodImpl(INLINE)] get => new(z, x, w, z); }
        [EditorBrowsable(State.Never)] public color zxww { [MethodImpl(INLINE)] get => new(z, x, w, w); }
        [EditorBrowsable(State.Never)] public color zyxx { [MethodImpl(INLINE)] get => new(z, y, x, x); }
        [EditorBrowsable(State.Never)] public color zyxy { [MethodImpl(INLINE)] get => new(z, y, x, y); }
        [EditorBrowsable(State.Never)] public color zyxz { [MethodImpl(INLINE)] get => new(z, y, x, z); }

        [EditorBrowsable(State.Never)] public color zyxw
        {
            [MethodImpl(INLINE)] get => new(z, y, x, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zyyx { [MethodImpl(INLINE)] get => new(z, y, y, x); }
        [EditorBrowsable(State.Never)] public color zyyy { [MethodImpl(INLINE)] get => new(z, y, y, y); }
        [EditorBrowsable(State.Never)] public color zyyz { [MethodImpl(INLINE)] get => new(z, y, y, z); }
        [EditorBrowsable(State.Never)] public color zyyw { [MethodImpl(INLINE)] get => new(z, y, y, w); }
        [EditorBrowsable(State.Never)] public color zyzx { [MethodImpl(INLINE)] get => new(z, y, z, x); }
        [EditorBrowsable(State.Never)] public color zyzy { [MethodImpl(INLINE)] get => new(z, y, z, y); }
        [EditorBrowsable(State.Never)] public color zyzz { [MethodImpl(INLINE)] get => new(z, y, z, z); }
        [EditorBrowsable(State.Never)] public color zyzw { [MethodImpl(INLINE)] get => new(z, y, z, w); }

        [EditorBrowsable(State.Never)] public color zywx
        {
            [MethodImpl(INLINE)] get => new(z, y, w, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zywy { [MethodImpl(INLINE)] get => new(z, y, w, y); }
        [EditorBrowsable(State.Never)] public color zywz { [MethodImpl(INLINE)] get => new(z, y, w, z); }
        [EditorBrowsable(State.Never)] public color zyww { [MethodImpl(INLINE)] get => new(z, y, w, w); }
        [EditorBrowsable(State.Never)] public color zzxx { [MethodImpl(INLINE)] get => new(z, z, x, x); }
        [EditorBrowsable(State.Never)] public color zzxy { [MethodImpl(INLINE)] get => new(z, z, x, y); }
        [EditorBrowsable(State.Never)] public color zzxz { [MethodImpl(INLINE)] get => new(z, z, x, z); }
        [EditorBrowsable(State.Never)] public color zzxw { [MethodImpl(INLINE)] get => new(z, z, x, w); }
        [EditorBrowsable(State.Never)] public color zzyx { [MethodImpl(INLINE)] get => new(z, z, y, x); }
        [EditorBrowsable(State.Never)] public color zzyy { [MethodImpl(INLINE)] get => new(z, z, y, y); }
        [EditorBrowsable(State.Never)] public color zzyz { [MethodImpl(INLINE)] get => new(z, z, y, z); }
        [EditorBrowsable(State.Never)] public color zzyw { [MethodImpl(INLINE)] get => new(z, z, y, w); }
        [EditorBrowsable(State.Never)] public color zzzx { [MethodImpl(INLINE)] get => new(z, z, z, x); }
        [EditorBrowsable(State.Never)] public color zzzy { [MethodImpl(INLINE)] get => new(z, z, z, y); }
        [EditorBrowsable(State.Never)] public color zzzz { [MethodImpl(INLINE)] get => new(z, z, z, z); }
        [EditorBrowsable(State.Never)] public color zzzw { [MethodImpl(INLINE)] get => new(z, z, z, w); }
        [EditorBrowsable(State.Never)] public color zzwx { [MethodImpl(INLINE)] get => new(z, z, w, x); }
        [EditorBrowsable(State.Never)] public color zzwy { [MethodImpl(INLINE)] get => new(z, z, w, y); }
        [EditorBrowsable(State.Never)] public color zzwz { [MethodImpl(INLINE)] get => new(z, z, w, z); }
        [EditorBrowsable(State.Never)] public color zzww { [MethodImpl(INLINE)] get => new(z, z, w, w); }
        [EditorBrowsable(State.Never)] public color zwxx { [MethodImpl(INLINE)] get => new(z, w, x, x); }

        [EditorBrowsable(State.Never)] public color zwxy
        {
            [MethodImpl(INLINE)] get => new(z, w, x, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zwxz { [MethodImpl(INLINE)] get => new(z, w, x, z); }
        [EditorBrowsable(State.Never)] public color zwxw { [MethodImpl(INLINE)] get => new(z, w, x, w); }

        [EditorBrowsable(State.Never)] public color zwyx
        {
            [MethodImpl(INLINE)] get => new(z, w, y, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color zwyy { [MethodImpl(INLINE)] get => new(z, w, y, y); }
        [EditorBrowsable(State.Never)] public color zwyz { [MethodImpl(INLINE)] get => new(z, w, y, z); }
        [EditorBrowsable(State.Never)] public color zwyw { [MethodImpl(INLINE)] get => new(z, w, y, w); }
        [EditorBrowsable(State.Never)] public color zwzx { [MethodImpl(INLINE)] get => new(z, w, z, x); }
        [EditorBrowsable(State.Never)] public color zwzy { [MethodImpl(INLINE)] get => new(z, w, z, y); }
        [EditorBrowsable(State.Never)] public color zwzz { [MethodImpl(INLINE)] get => new(z, w, z, z); }
        [EditorBrowsable(State.Never)] public color zwzw { [MethodImpl(INLINE)] get => new(z, w, z, w); }
        [EditorBrowsable(State.Never)] public color zwwx { [MethodImpl(INLINE)] get => new(z, w, w, x); }
        [EditorBrowsable(State.Never)] public color zwwy { [MethodImpl(INLINE)] get => new(z, w, w, y); }
        [EditorBrowsable(State.Never)] public color zwwz { [MethodImpl(INLINE)] get => new(z, w, w, z); }
        [EditorBrowsable(State.Never)] public color zwww { [MethodImpl(INLINE)] get => new(z, w, w, w); }
        [EditorBrowsable(State.Never)] public color wxxx { [MethodImpl(INLINE)] get => new(w, x, x, x); }
        [EditorBrowsable(State.Never)] public color wxxy { [MethodImpl(INLINE)] get => new(w, x, x, y); }
        [EditorBrowsable(State.Never)] public color wxxz { [MethodImpl(INLINE)] get => new(w, x, x, z); }
        [EditorBrowsable(State.Never)] public color wxxw { [MethodImpl(INLINE)] get => new(w, x, x, w); }
        [EditorBrowsable(State.Never)] public color wxyx { [MethodImpl(INLINE)] get => new(w, x, y, x); }
        [EditorBrowsable(State.Never)] public color wxyy { [MethodImpl(INLINE)] get => new(w, x, y, y); }

        [EditorBrowsable(State.Never)] public color wxyz
        {
            [MethodImpl(INLINE)] get => new(w, x, y, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wxyw { [MethodImpl(INLINE)] get => new(w, x, y, w); }
        [EditorBrowsable(State.Never)] public color wxzx { [MethodImpl(INLINE)] get => new(w, x, z, x); }

        [EditorBrowsable(State.Never)] public color wxzy
        {
            [MethodImpl(INLINE)] get => new(w, x, z, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wxzz { [MethodImpl(INLINE)] get => new(w, x, z, z); }
        [EditorBrowsable(State.Never)] public color wxzw { [MethodImpl(INLINE)] get => new(w, x, z, w); }
        [EditorBrowsable(State.Never)] public color wxwx { [MethodImpl(INLINE)] get => new(w, x, w, x); }
        [EditorBrowsable(State.Never)] public color wxwy { [MethodImpl(INLINE)] get => new(w, x, w, y); }
        [EditorBrowsable(State.Never)] public color wxwz { [MethodImpl(INLINE)] get => new(w, x, w, z); }
        [EditorBrowsable(State.Never)] public color wxww { [MethodImpl(INLINE)] get => new(w, x, w, w); }
        [EditorBrowsable(State.Never)] public color wyxx { [MethodImpl(INLINE)] get => new(w, y, x, x); }
        [EditorBrowsable(State.Never)] public color wyxy { [MethodImpl(INLINE)] get => new(w, y, x, y); }

        [EditorBrowsable(State.Never)] public color wyxz
        {
            [MethodImpl(INLINE)] get => new(w, y, x, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wyxw { [MethodImpl(INLINE)] get => new(w, y, x, w); }
        [EditorBrowsable(State.Never)] public color wyyx { [MethodImpl(INLINE)] get => new(w, y, y, x); }
        [EditorBrowsable(State.Never)] public color wyyy { [MethodImpl(INLINE)] get => new(w, y, y, y); }
        [EditorBrowsable(State.Never)] public color wyyz { [MethodImpl(INLINE)] get => new(w, y, y, z); }
        [EditorBrowsable(State.Never)] public color wyyw { [MethodImpl(INLINE)] get => new(w, y, y, w); }

        [EditorBrowsable(State.Never)] public color wyzx
        {
            [MethodImpl(INLINE)] get => new(w, y, z, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wyzy { [MethodImpl(INLINE)] get => new(w, y, z, y); }
        [EditorBrowsable(State.Never)] public color wyzz { [MethodImpl(INLINE)] get => new(w, y, z, z); }
        [EditorBrowsable(State.Never)] public color wyzw { [MethodImpl(INLINE)] get => new(w, y, z, w); }
        [EditorBrowsable(State.Never)] public color wywx { [MethodImpl(INLINE)] get => new(w, y, w, x); }
        [EditorBrowsable(State.Never)] public color wywy { [MethodImpl(INLINE)] get => new(w, y, w, y); }
        [EditorBrowsable(State.Never)] public color wywz { [MethodImpl(INLINE)] get => new(w, y, w, z); }
        [EditorBrowsable(State.Never)] public color wyww { [MethodImpl(INLINE)] get => new(w, y, w, w); }
        [EditorBrowsable(State.Never)] public color wzxx { [MethodImpl(INLINE)] get => new(w, z, x, x); }

        [EditorBrowsable(State.Never)] public color wzxy
        {
            [MethodImpl(INLINE)] get => new(w, z, x, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wzxz { [MethodImpl(INLINE)] get => new(w, z, x, z); }
        [EditorBrowsable(State.Never)] public color wzxw { [MethodImpl(INLINE)] get => new(w, z, x, w); }

        [EditorBrowsable(State.Never)] public color wzyx
        {
            [MethodImpl(INLINE)] get => new(w, z, y, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

        [EditorBrowsable(State.Never)] public color wzyy { [MethodImpl(INLINE)] get => new(w, z, y, y); }
        [EditorBrowsable(State.Never)] public color wzyz { [MethodImpl(INLINE)] get => new(w, z, y, z); }
        [EditorBrowsable(State.Never)] public color wzyw { [MethodImpl(INLINE)] get => new(w, z, y, w); }
        [EditorBrowsable(State.Never)] public color wzzx { [MethodImpl(INLINE)] get => new(w, z, z, x); }
        [EditorBrowsable(State.Never)] public color wzzy { [MethodImpl(INLINE)] get => new(w, z, z, y); }
        [EditorBrowsable(State.Never)] public color wzzz { [MethodImpl(INLINE)] get => new(w, z, z, z); }
        [EditorBrowsable(State.Never)] public color wzzw { [MethodImpl(INLINE)] get => new(w, z, z, w); }
        [EditorBrowsable(State.Never)] public color wzwx { [MethodImpl(INLINE)] get => new(w, z, w, x); }
        [EditorBrowsable(State.Never)] public color wzwy { [MethodImpl(INLINE)] get => new(w, z, w, y); }
        [EditorBrowsable(State.Never)] public color wzwz { [MethodImpl(INLINE)] get => new(w, z, w, z); }
        [EditorBrowsable(State.Never)] public color wzww { [MethodImpl(INLINE)] get => new(w, z, w, w); }
        [EditorBrowsable(State.Never)] public color wwxx { [MethodImpl(INLINE)] get => new(w, w, x, x); }
        [EditorBrowsable(State.Never)] public color wwxy { [MethodImpl(INLINE)] get => new(w, w, x, y); }
        [EditorBrowsable(State.Never)] public color wwxz { [MethodImpl(INLINE)] get => new(w, w, x, z); }
        [EditorBrowsable(State.Never)] public color wwxw { [MethodImpl(INLINE)] get => new(w, w, x, w); }
        [EditorBrowsable(State.Never)] public color wwyx { [MethodImpl(INLINE)] get => new(w, w, y, x); }
        [EditorBrowsable(State.Never)] public color wwyy { [MethodImpl(INLINE)] get => new(w, w, y, y); }
        [EditorBrowsable(State.Never)] public color wwyz { [MethodImpl(INLINE)] get => new(w, w, y, z); }
        [EditorBrowsable(State.Never)] public color wwyw { [MethodImpl(INLINE)] get => new(w, w, y, w); }
        [EditorBrowsable(State.Never)] public color wwzx { [MethodImpl(INLINE)] get => new(w, w, z, x); }
        [EditorBrowsable(State.Never)] public color wwzy { [MethodImpl(INLINE)] get => new(w, w, z, y); }
        [EditorBrowsable(State.Never)] public color wwzz { [MethodImpl(INLINE)] get => new(w, w, z, z); }
        [EditorBrowsable(State.Never)] public color wwzw { [MethodImpl(INLINE)] get => new(w, w, z, w); }
        [EditorBrowsable(State.Never)] public color wwwx { [MethodImpl(INLINE)] get => new(w, w, w, x); }
        [EditorBrowsable(State.Never)] public color wwwy { [MethodImpl(INLINE)] get => new(w, w, w, y); }
        [EditorBrowsable(State.Never)] public color wwwz { [MethodImpl(INLINE)] get => new(w, w, w, z); }
        [EditorBrowsable(State.Never)] public color wwww { [MethodImpl(INLINE)] get => new(w, w, w, w); }
        [EditorBrowsable(State.Never)] public float3 xxx { [MethodImpl(INLINE)] get => new(x, x, x); }
        [EditorBrowsable(State.Never)] public float3 xxy { [MethodImpl(INLINE)] get => new(x, x, y); }
        [EditorBrowsable(State.Never)] public float3 xxz { [MethodImpl(INLINE)] get => new(x, x, z); }
        [EditorBrowsable(State.Never)] public float3 xxw { [MethodImpl(INLINE)] get => new(x, x, w); }
        [EditorBrowsable(State.Never)] public float3 xyx { [MethodImpl(INLINE)] get => new(x, y, x); }
        [EditorBrowsable(State.Never)] public float3 xyy { [MethodImpl(INLINE)] get => new(x, y, y); }

        [EditorBrowsable(State.Never)] public float3 xyz
        {
            [MethodImpl(INLINE)] get => new(x, y, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xyw
        {
            [MethodImpl(INLINE)] get => new(x, y, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xzx { [MethodImpl(INLINE)] get => new(x, z, x); }

        [EditorBrowsable(State.Never)] public float3 xzy
        {
            [MethodImpl(INLINE)] get => new(x, z, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xzz { [MethodImpl(INLINE)] get => new(x, z, z); }

        [EditorBrowsable(State.Never)] public float3 xzw
        {
            [MethodImpl(INLINE)] get => new(x, z, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xwx { [MethodImpl(INLINE)] get => new(x, w, x); }

        [EditorBrowsable(State.Never)] public float3 xwy
        {
            [MethodImpl(INLINE)] get => new(x, w, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xwz
        {
            [MethodImpl(INLINE)] get => new(x, w, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 xww { [MethodImpl(INLINE)] get => new(x, w, w); }
        [EditorBrowsable(State.Never)] public float3 yxx { [MethodImpl(INLINE)] get => new(y, x, x); }
        [EditorBrowsable(State.Never)] public float3 yxy { [MethodImpl(INLINE)] get => new(y, x, y); }

        [EditorBrowsable(State.Never)] public float3 yxz
        {
            [MethodImpl(INLINE)] get => new(y, x, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 yxw
        {
            [MethodImpl(INLINE)] get => new(y, x, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 yyx { [MethodImpl(INLINE)] get => new(y, y, x); }
        [EditorBrowsable(State.Never)] public float3 yyy { [MethodImpl(INLINE)] get => new(y, y, y); }
        [EditorBrowsable(State.Never)] public float3 yyz { [MethodImpl(INLINE)] get => new(y, y, z); }
        [EditorBrowsable(State.Never)] public float3 yyw { [MethodImpl(INLINE)] get => new(y, y, w); }

        [EditorBrowsable(State.Never)] public float3 yzx
        {
            [MethodImpl(INLINE)] get => new(y, z, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 yzy { [MethodImpl(INLINE)] get => new(y, z, y); }
        [EditorBrowsable(State.Never)] public float3 yzz { [MethodImpl(INLINE)] get => new(y, z, z); }

        [EditorBrowsable(State.Never)] public float3 yzw
        {
            [MethodImpl(INLINE)] get => new(y, z, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 ywx
        {
            [MethodImpl(INLINE)] get => new(y, w, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 ywy { [MethodImpl(INLINE)] get => new(y, w, y); }

        [EditorBrowsable(State.Never)] public float3 ywz
        {
            [MethodImpl(INLINE)] get => new(y, w, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 yww { [MethodImpl(INLINE)] get => new(y, w, w); }
        [EditorBrowsable(State.Never)] public float3 zxx { [MethodImpl(INLINE)] get => new(z, x, x); }

        [EditorBrowsable(State.Never)] public float3 zxy
        {
            [MethodImpl(INLINE)] get => new(z, x, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zxz { [MethodImpl(INLINE)] get => new(z, x, z); }

        [EditorBrowsable(State.Never)] public float3 zxw
        {
            [MethodImpl(INLINE)] get => new(z, x, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zyx
        {
            [MethodImpl(INLINE)] get => new(z, y, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zyy { [MethodImpl(INLINE)] get => new(z, y, y); }
        [EditorBrowsable(State.Never)] public float3 zyz { [MethodImpl(INLINE)] get => new(z, y, z); }

        [EditorBrowsable(State.Never)] public float3 zyw
        {
            [MethodImpl(INLINE)] get => new(z, y, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
                w = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zzx { [MethodImpl(INLINE)] get => new(z, z, x); }
        [EditorBrowsable(State.Never)] public float3 zzy { [MethodImpl(INLINE)] get => new(z, z, y); }
        [EditorBrowsable(State.Never)] public float3 zzz { [MethodImpl(INLINE)] get => new(z, z, z); }
        [EditorBrowsable(State.Never)] public float3 zzw { [MethodImpl(INLINE)] get => new(z, z, w); }

        [EditorBrowsable(State.Never)] public float3 zwx
        {
            [MethodImpl(INLINE)] get => new(z, w, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zwy
        {
            [MethodImpl(INLINE)] get => new(z, w, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 zwz { [MethodImpl(INLINE)] get => new(z, w, z); }
        [EditorBrowsable(State.Never)] public float3 zww { [MethodImpl(INLINE)] get => new(z, w, w); }
        [EditorBrowsable(State.Never)] public float3 wxx { [MethodImpl(INLINE)] get => new(w, x, x); }

        [EditorBrowsable(State.Never)] public float3 wxy
        {
            [MethodImpl(INLINE)] get => new(w, x, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wxz
        {
            [MethodImpl(INLINE)] get => new(w, x, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wxw { [MethodImpl(INLINE)] get => new(w, x, w); }

        [EditorBrowsable(State.Never)] public float3 wyx
        {
            [MethodImpl(INLINE)] get => new(w, y, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wyy { [MethodImpl(INLINE)] get => new(w, y, y); }

        [EditorBrowsable(State.Never)] public float3 wyz
        {
            [MethodImpl(INLINE)] get => new(w, y, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wyw { [MethodImpl(INLINE)] get => new(w, y, w); }

        [EditorBrowsable(State.Never)] public float3 wzx
        {
            [MethodImpl(INLINE)] get => new(w, z, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wzy
        {
            [MethodImpl(INLINE)] get => new(w, z, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }

        [EditorBrowsable(State.Never)] public float3 wzz { [MethodImpl(INLINE)] get => new(w, z, z); }
        [EditorBrowsable(State.Never)] public float3 wzw { [MethodImpl(INLINE)] get => new(w, z, w); }
        [EditorBrowsable(State.Never)] public float3 wwx { [MethodImpl(INLINE)] get => new(w, w, x); }
        [EditorBrowsable(State.Never)] public float3 wwy { [MethodImpl(INLINE)] get => new(w, w, y); }
        [EditorBrowsable(State.Never)] public float3 wwz { [MethodImpl(INLINE)] get => new(w, w, z); }
        [EditorBrowsable(State.Never)] public float3 www { [MethodImpl(INLINE)] get => new(w, w, w); }
        [EditorBrowsable(State.Never)] public float2 xx { [MethodImpl(INLINE)] get => new(x, x); }

        [EditorBrowsable(State.Never)] public float2 xy
        {
            [MethodImpl(INLINE)] get => new(x, y);
            [MethodImpl(INLINE)] set {
                x = value.x;
                y = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 xz
        {
            [MethodImpl(INLINE)] get => new(x, z);
            [MethodImpl(INLINE)] set {
                x = value.x;
                z = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 xw
        {
            [MethodImpl(INLINE)] get => new(x, w);
            [MethodImpl(INLINE)] set {
                x = value.x;
                w = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 yx
        {
            [MethodImpl(INLINE)] get => new(y, x);
            [MethodImpl(INLINE)] set {
                y = value.x;
                x = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 yy { [MethodImpl(INLINE)] get => new(y, y); }

        [EditorBrowsable(State.Never)] public float2 yz
        {
            [MethodImpl(INLINE)] get => new(y, z);
            [MethodImpl(INLINE)] set {
                y = value.x;
                z = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 yw
        {
            [MethodImpl(INLINE)] get => new(y, w);
            [MethodImpl(INLINE)] set {
                y = value.x;
                w = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 zx
        {
            [MethodImpl(INLINE)] get => new(z, x);
            [MethodImpl(INLINE)] set {
                z = value.x;
                x = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 zy
        {
            [MethodImpl(INLINE)] get => new(z, y);
            [MethodImpl(INLINE)] set {
                z = value.x;
                y = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 zz { [MethodImpl(INLINE)] get => new(z, z); }

        [EditorBrowsable(State.Never)] public float2 zw
        {
            [MethodImpl(INLINE)] get => new(z, w);
            [MethodImpl(INLINE)] set {
                z = value.x;
                w = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 wx
        {
            [MethodImpl(INLINE)] get => new(w, x);
            [MethodImpl(INLINE)] set {
                w = value.x;
                x = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 wy
        {
            [MethodImpl(INLINE)] get => new(w, y);
            [MethodImpl(INLINE)] set {
                w = value.x;
                y = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 wz
        {
            [MethodImpl(INLINE)] get => new(w, z);
            [MethodImpl(INLINE)] set {
                w = value.x;
                z = value.y;
            }
        }

        [EditorBrowsable(State.Never)] public float2 ww { [MethodImpl(INLINE)] get => new(w, w); }

//         /// <summary>Returns the float element at a specified index.</summary>
//         public unsafe float this[int index]
//         {
//             get
//             {
// #if ENABLE_UNITY_COLLECTIONS_CHECKS
//                 if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
// #endif
//                 fixed (color* array = &this) { return ((float*)array)[index]; }
//             }
//             set
//             {
// #if ENABLE_UNITY_COLLECTIONS_CHECKS
//                 if ((uint)index >= 4) throw new ArgumentException("index must be between[0...3]");
// #endif
//                 fixed (float* array = &x) { array[index] = value; }
//             }
//         }

        // Additions ---------------------------------------

        public float this[int index]
        {
            get => index switch
            {
                0 => x,
                1 => y,
                2 => z,
                3 => w,
                _ => throw new IndexOutOfRangeException("Invalid Color index(" + index + ")!")
            };
            set {
                switch (index) {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    case 2:
                        z = value;
                        break;
                    case 3:
                        w = value;
                        break;
                    default: throw new IndexOutOfRangeException("Invalid Color index(" + index + ")!");
                }
            }
        }

        public static void RGBToHSV(color rgbColor, out float H, out float S, out float V) {
            if (rgbColor.z > rgbColor.y && rgbColor.z > rgbColor.x) RGBToHSVHelper(4f, rgbColor.z, rgbColor.x, rgbColor.y, out H, out S, out V);
            else if (rgbColor.y > rgbColor.x) RGBToHSVHelper(2f, rgbColor.y, rgbColor.z, rgbColor.x, out H, out S, out V);
            else RGBToHSVHelper(0, rgbColor.x, rgbColor.y, rgbColor.z, out H, out S, out V);
        }
        private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V) {
            V = dominantcolor;
            if (V != 0.0) {
                var num1 = colorone <= colortwo ? colorone : colortwo;
                var num2 = V - num1;
                if (num2 != 0.0) {
                    S = num2 / V;
                    H = offset + (colorone - colortwo) / num2;
                }
                else {
                    S = 0;
                    H = offset + (colorone - colortwo);
                }

                H /= 6f;
                if (H >= 0.0) return;
                ++H;
            }
            else {
                S = 0;
                H = 0;
            }
        }
        /// <para>Creates an RGB colour from HSV input.</para>
        /// <param name="H">Hue [0..1].</param>
        /// <param name="S">Saturation [0..1].</param>
        /// <param name="V">Brightness value [0..1].</param>
        /// <returns>
        ///     <para>An opaque colour with HSV matching the input.</para>
        /// </returns>
        /// <inheritdoc cref="Color" />
        /// >
        public static color HSVToRGB(float H, float S, float V) => HSVToRGB(H, S, V, true);
        /// <para>Creates an RGB colour from HSV input.</para>
        /// <param name="H">Hue [0..1].</param>
        /// <param name="S">Saturation [0..1].</param>
        /// <param name="V">Brightness value [0..1].</param>
        /// <param name="hdr">Output HDR colours. If true, the returned colour will not be clamped to [0..1].</param>
        /// <returns>
        ///     <para>An opaque colour with HSV matching the input.</para>
        /// </returns>
        public static color HSVToRGB(float H, float S, float V, bool hdr) {
            var _white = white;
            if (S == 0) {
                _white.xyz = V;
            }
            else if (V == 0.0) {
                _white.xyz = 0;
            }
            else {
                _white.xyz = 0;
                var num1 = S;
                var num2 = V;
                var f = H * 6;
                var num3 = (int)f.floor();
                var num4 = f - num3;
                var num5 = num2 * (1 - num1);
                var num6 = num2 * (1 - num1 * num4);
                var num7 = num2 * (1 - num1 * (1 - num4));
                _white.xyz = num3 switch
                {
                    -1 => new(num2, num5, num6),
                    0 => new(num2, num7, num5),
                    1 => new(num6, num2, num5),
                    2 => new(num5, num2, num7),
                    3 => new(num5, num6, num2),
                    4 => new(num7, num5, num2),
                    5 => new(num2, num5, num6),
                    6 => new(num2, num7, num5),
                    _ => _white.xyz
                };
                if (!hdr) _white.xyz = _white.xyz.sat();
            }

            return _white;
        }
        /// <summary>Returns true if the color is equal to a given color, false otherwise.</summary>
        [MethodImpl(INLINE)] public bool Equals(color rhs) => x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w;
        /// <summary>Returns true if the color is equal to a given color, false otherwise.</summary>
        public override bool Equals(object o) => Equals((color)o);
        /// <summary>Returns a hash code for the color.</summary>
        [MethodImpl(INLINE)] public override int GetHashCode() => (int)math.hash(this);
        /// <summary>Returns a string representation of the color.</summary>
        [MethodImpl(INLINE)] public override string ToString() => $"color({x}f, {y}f, {z}f, {w}f)";
        /// <summary>Returns a string representation of the color using a specified format and culture-specific format information.</summary>
        [MethodImpl(INLINE)] public string ToString(string format, IFormatProvider formatProvider) => $"color({x.ToString(format, formatProvider)}f, {y.ToString(format, formatProvider)}f, {z.ToString(format, formatProvider)}f, {w.ToString(format, formatProvider)}f)";

        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public float z;
            public float w;
            public DebuggerProxy(color v) {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

        // Additions ---------------------
        public color RGBMultiplied(float multiplier) => new(x * multiplier, y * multiplier, z * multiplier, w);
        public color AlphaMultiplied(float multiplier) => new(x, y, z, w * multiplier);
        public color RGBMultiplied(color multiplier) => new(x * multiplier.x, y * multiplier.y, z * multiplier.z, w);

        /// <para>Solid red. RGBA is (1, 0, 0, 1).</para>
        public static color red => new(1, 0, 0);

        /// <para>Solid green. RGBA is (0, 1, 0, 1).</para>
        public static color green => new(0, 1, 0);

        /// <para>Solid blue. RGBA is (0, 0, 1, 1).</para>
        public static color blue => new(0, 0, 1);

        /// <para>Solid white. RGBA is (1, 1, 1, 1).</para>
        public static color white => new(1, 1, 1);

        /// <para>Solid black. RGBA is (0, 0, 0, 1).</para>
        public static color black => new(0, 0, 0);

        /// <para>Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!</para>
        public static color yellow => new(1, 0.9215686f, 0.01568628f);

        /// <para>Cyan. RGBA is (0, 1, 1, 1).</para>
        public static color cyan => new(0, 1, 1);

        /// <para>Magenta. RGBA is (1, 0, 1, 1).</para>
        public static color magenta => new(1, 0, 1);

        /// <para>Gray. RGBA is (0.5, 0.5, 0.5, 1).</para>
        public static color gray => new(0.5f);

        /// <para>English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1).</para>
        public static color grey => new(0.5f);

        /// <para>Completely transparent. RGBA is (0, 0, 0, 0).</para>
        public static color clear => new(0, 0, 0, 0);

        /// <para>Solid orange. RGBA is (1, 0.5f, 0, 1).</para>
        public static color orange => new(1, 0.5f, 0);

        /// <para>The grayscale value of the color. (Read Only)</para>
        // public float grayscale => (float) (0.29899999499321 * x + 0.587000012397766 * y + 57.0 / 500.0 * z);
        public float grayscale => math.dot(float3(0.29899999499321f, 0.587000012397766f, 57 / 500f), xyz);

        /// <para>A linear value of an sRGB color.</para>
        public color linear => xyzw.gammatolinear();

        /// <para>A version of the color that has had the gamma curve applied.</para>
        public color gamma => xyzw.lineartogama();

        /// <para>Returns the maximum color component value: Max(r,g,b).</para>
        public float maxcolorComponent => xyz.cmax();
    }

    public static partial class mathx
    {
        /// <summary>Returns a color vector constructed from four float values.</summary>
        [MethodImpl(INLINE)] public static color color(float x, float y, float z, float w) => new(x, y, z, w);
        /// <summary>Returns a color vector constructed from two float values and a float2 vector.</summary>
        [MethodImpl(INLINE)] public static color color(float x, float y, float2 zw) => new(x, y, zw);
        /// <summary>Returns a color vector constructed from a float value, a float2 vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color color(float x, float2 yz, float w) => new(x, yz, w);
        /// <summary>Returns a color vector constructed from a float value and a float3 vector.</summary>
        [MethodImpl(INLINE)] public static color color(float x, float3 yzw) => new(x, yzw);
        /// <summary>Returns a color vector constructed from a float2 vector and two float values.</summary>
        [MethodImpl(INLINE)] public static color color(float2 xy, float z, float w) => new(xy, z, w);
        /// <summary>Returns a color vector constructed from two float2 vectors.</summary>
        [MethodImpl(INLINE)] public static color color(float2 xy, float2 zw) => new(xy, zw);
        /// <summary>Returns a color vector constructed from a float3 vector and a float value.</summary>
        [MethodImpl(INLINE)] public static color color(float3 xyz, float w) => new(xyz, w);
        /// <summary>Returns a color vector constructed from a color vector.</summary>
        [MethodImpl(INLINE)] public static color color(color xyzw) => new(xyzw);
        /// <summary>Returns a color vector constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(INLINE)] public static color color(float v) => new(v);
        ///     Returns a color vector constructed from a single bool value by converting it to float and assigning it to every component.
        [MethodImpl(INLINE)] public static color color(bool v) => new(v);
        /// <summary>Return a color vector constructed from a bool4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static color color(bool4 v) => new(v);
        ///     Returns a color vector constructed from a single int value by converting it to float and assigning it to every component.
        [MethodImpl(INLINE)] public static color color(int v) => new(v);
        /// <summary>Return a color vector constructed from a int4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static color color(int4 v) => new(v);
        ///     Returns a color vector constructed from a single uint value by converting it to float and assigning it to every component.
        [MethodImpl(INLINE)] public static color color(uint v) => new(v);
        /// <summary>Return a color vector constructed from a uint4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static color color(uint4 v) => new(v);
        /// <summary>
        ///     Returns a color vector constructed from a single half value by converting it to float and assigning it to
        ///     every component.
        /// </summary>
        [MethodImpl(INLINE)] public static color color(half v) => new(v);
        /// <summary>Return a color vector constructed from a half4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static color color(half4 v) => new(v);
        ///     Returns a color vector constructed from a single double value by converting it to float and assigning it to every component.
        [MethodImpl(INLINE)] public static color color(double v) => new(v);
        /// <summary>Return a color vector constructed from a double4 vector by componentwise conversion.</summary>
        [MethodImpl(INLINE)] public static color color(double4 v) => new(v);
        /// <summary>Returns a uint hash code of a color vector.</summary>
        [MethodImpl(INLINE)] public static uint hash(color v) => math.csum(asuint(v) * new uint4(0xE69626FFu, 0xBD010EEBu, 0x9CEDE1D1u, 0x43BE0B51u)) + 0xAF836EE1u;
        /// <summary>
        ///     Returns a uint4 vector hash code of a color vector.
        ///     When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        ///     that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(INLINE)] public static uint4 hashwide(color v) => asuint(v) * new uint4(0xB130C137u, 0x54834775u, 0x7C022221u, 0xA2D00EDFu) + 0xA8977779u;
        /// <summary>Returns the result of specified shuffling of the components from two color vectors into a float value.</summary>
        [MethodImpl(INLINE)] public static float cycle(color a, color b, ShuffleComponent x) => select_shuffle_component(a, b, x);
        /// <summary>Returns the result of specified shuffling of the components from two color vectors into a f2 vector.</summary>
        [MethodImpl(INLINE)] public static float2 cycle(color a, color b, ShuffleComponent x, ShuffleComponent y) => f2(select_shuffle_component(a, b, x), select_shuffle_component(a, b, y));
        /// <summary>Returns the result of specified shuffling of the components from two color vectors into a f3 vector.</summary>
        [MethodImpl(INLINE)] public static float3 cycle(color a, color b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => f3(select_shuffle_component(a, b, x), select_shuffle_component(a, b, y), select_shuffle_component(a, b, z));
        /// <summary>Returns the result of specified shuffling of the components from two color vectors into a color vector.</summary>
        [MethodImpl(INLINE)] public static color cycle(color a, color b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => color(select_shuffle_component(a, b, x), select_shuffle_component(a, b, y), select_shuffle_component(a, b, z), select_shuffle_component(a, b, w));
        [MethodImpl(INLINE)] internal static float select_shuffle_component(color a, color b, ShuffleComponent component) {
            return component switch
            {
                ShuffleComponent.LeftX => a.x,
                ShuffleComponent.LeftY => a.y,
                ShuffleComponent.LeftZ => a.z,
                ShuffleComponent.LeftW => a.w,
                ShuffleComponent.RightX => b.x,
                ShuffleComponent.RightY => b.y,
                ShuffleComponent.RightZ => b.z,
                ShuffleComponent.RightW => b.w,
                _ => throw new ArgumentException("Invalid cycle component: " + component)
            };
        }
    }

    public static partial class mathx
    {
        // Additions --------------------- 
        [MethodImpl(INLINE)] public static color clamp(this color f, float min, float max) => new(f.x.clamp(min, max), f.y.clamp(min, max), f.z.clamp(min, max), f.w.clamp(min, max));
        [MethodImpl(INLINE)] public static color min(this color f, color m) => new(f.x.min(m.x), f.y.min(m.y), f.z.min(m.z), f.w.min(m.w));
        [MethodImpl(INLINE)] public static color max(this color f, color m) => new(f.x.max(m.x), f.y.max(m.y), f.z.max(m.z), f.w.max(m.w));
        [MethodImpl(INLINE)] public static color sat(this color f) => new(sat(f.x), sat(f.y), sat(f.z), sat(f.w));
        [MethodImpl(INLINE)] public static color sqrt(this color f) => new(sqrt(f.x), sqrt(f.y), sqrt(f.z), sqrt(f.w));
        [MethodImpl(INLINE)] public static color pow(this color f, float p) => new(f.x.pow(p), f.y.pow(p), f.z.pow(p), f.w.pow(p));
        [MethodImpl(INLINE)] public static color pow(this color f, float4 p) => new(f.x.pow(p.x), f.y.pow(p.y), f.z.pow(p.z), f.w.pow(p.w));
        [MethodImpl(INLINE)] public static color sq(this color f) => f * f;
        [MethodImpl(INLINE)] public static color cube(this color f) => f * f * f;
        [MethodImpl(INLINE)] public static color pow4(this color f) => f.sq().sq();
        [MethodImpl(INLINE)] public static color pow5(this color f) => f.pow4() * f;
        [MethodImpl(INLINE)] public static color frac(this color f) => new(f.x.frac(), f.y.frac(), f.z.frac(), f.w.frac());
        [MethodImpl(INLINE)] public static color sign(this color f) => new(f.x.sign(), f.y.sign(), f.z.sign(), f.w.sign());
        [MethodImpl(INLINE)] public static color abs(this color f) => new(f.x.abs(), f.y.abs(), f.z.abs(), f.w.abs());
        [MethodImpl(INLINE)] public static float csum(this color f) => f.x + f.y + f.z + f.w;
        [MethodImpl(INLINE)] public static float cmul(this color f) => f.x * f.y * f.z * f.w;
        [MethodImpl(INLINE)] public static color inv(this color f) => 1 - f;
        [MethodImpl(INLINE)] public static color neg(this color f) => -f;
        [MethodImpl(INLINE)] public static color rcp(this color f) => new(f.x.rcp(), f.y.rcp(), f.z.rcp(), f.w.rcp());
        [MethodImpl(INLINE)] public static color lerp(this float f, color a, color b) => a + f * (b - a);
        [MethodImpl(INLINE)] public static color unlerp(this float f, color min, color max) => (f - min) / (max - min);
        [MethodImpl(INLINE)] public static color unlerp(this color f, float min, float max) => (f - min) / (max - min);
        [MethodImpl(INLINE)] public static color unlerp(this color f, float2 minmax) => (f - minmax.x) / (minmax.y - minmax.y);
        [MethodImpl(INLINE)] public static color unlerp(color min, color max, float f) => (f - min) / (max - min);
        [MethodImpl(INLINE)] public static color remap(color a, float b, float c, float d, float x) => lerp(c, d, unlerp(a, b, x));
        [MethodImpl(INLINE)] public static float gammatolinear(this float c) => c.pow(2.2f);
        [MethodImpl(INLINE)] public static float lineartogama(this float c) => c.pow(1 / 2.2f);
        [MethodImpl(INLINE)] public static color gammatolinear(this color c) => new(c.x.gammatolinear(), c.y.gammatolinear(), c.z.gammatolinear(), c.w);
        [MethodImpl(INLINE)] public static color lineartogama(this color c) => new(c.x.lineartogama(), c.y.lineartogama(), c.z.lineartogama(), c.w);
    }
}