using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

[System.Serializable]
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
    public static readonly color zero;

    /// <summary>Constructs a color vector from four float values.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float x, float y, float z, float w){
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }

    /// <summary>Constructs a color vector from two float values and a float2 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float x, float y, float2 zw){
        this.x = x;
        this.y = y;
        this.z = zw.x;
        this.w = zw.y;
    }

    /// <summary>Constructs a color vector from a float value, a float2 vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float x, float2 yz, float w){
        this.x = x;
        this.y = yz.x;
        this.z = yz.y;
        this.w = w;
    }

    /// <summary>Constructs a color vector from a float value and a float3 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float x, float3 yzw){
        this.x = x;
        this.y = yzw.x;
        this.z = yzw.y;
        this.w = yzw.z;
    }

    /// <summary>Constructs a color vector from a float2 vector and two float values.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float2 xy, float z, float w){
        this.x = xy.x;
        this.y = xy.y;
        this.z = z;
        this.w = w;
    }

    /// <summary>Constructs a color vector from two float2 vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float2 xy, float2 zw){
        this.x = xy.x;
        this.y = xy.y;
        this.z = zw.x;
        this.w = zw.y;
    }

    /// <summary>Constructs a color vector from a float3 vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float3 xyz, float w){
        this.x = xyz.x;
        this.y = xyz.y;
        this.z = xyz.z;
        this.w = w;
    }

    /// <summary>Constructs a color vector from a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(color xyzw){
        this.x = xyzw.x;
        this.y = xyzw.y;
        this.z = xyzw.z;
        this.w = xyzw.w;
    }

    /// <summary>Constructs a color vector from a single float value by assigning it to xyz components, and 1 in w.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float v){
        this.x = v;
        this.y = v;
        this.z = v;
        this.w = 1;
    }

    /// <summary>Constructs a color vector from a single bool value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(bool v){
        this.x = v ? 1 : 0;
        this.y = v ? 1 : 0;
        this.z = v ? 1 : 0;
        this.w = v ? 1 : 0;
    }

    /// <summary>Constructs a color vector from a bool4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(bool4 v){
        this.x = v.x ? 1 : 0;
        this.y = v.y ? 1 : 0;
        this.z = v.z ? 1 : 0;
        this.w = v.w ? 1 : 0;
    }

    /// <summary>Constructs a color vector from a single int value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(int v){
        this.x = v;
        this.y = v;
        this.z = v;
        this.w = v;
    }

    /// <summary>Constructs a color vector from a int4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(int4 v){
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;
    }

    /// <summary>Constructs a color vector from a single uint value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(uint v){
        this.x = v;
        this.y = v;
        this.z = v;
        this.w = v;
    }

    /// <summary>Constructs a color vector from a uint4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(uint4 v){
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;
    }

    /// <summary>Constructs a color vector from a single half value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(half v){
        this.x = v;
        this.y = v;
        this.z = v;
        this.w = v;
    }

    /// <summary>Constructs a color vector from a half4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(half4 v){
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;
    }

    /// <summary>Constructs a color vector from a single double value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(double v){
        this.x = (float)v;
        this.y = (float)v;
        this.z = (float)v;
        this.w = (float)v;
    }

    /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(double4 v){
        this.x = (float)v.x;
        this.y = (float)v.y;
        this.z = (float)v.z;
        this.w = (float)v.w;
    }
        
    /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(Color v){
        this.x = v.r;
        this.y = v.g;
        this.z = v.b;
        this.w = v.a;
    }
        
    /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float4 v){
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = v.w;
    }
    /// <summary>Constructs a color vector from a double4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public color(float3 v){
        this.x = v.x;
        this.y = v.y;
        this.z = v.z;
        this.w = 1;
    }
        
    // Additions -------------------------------

    ///   <para>Constructs a new color with given r,g,b components and sets a to 1.</para>
    /// <param name="x">Red component.</param>
    /// <param name="y">Green component.</param>
    /// <param name="z">Blue component.</param>
    public color(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = 1;
    }
        
    ///   <para>Constructs a new color with x in r,g,b components and sets y to alpha.</para>
    /// <param name="x">Red component.</param>
    /// <param name="y">Green component.</param>
    /// <param name="z">Blue component.</param>
    public color(float x, float y) {
        this.x = x;
        this.y = x;
        this.z = x;
        this.w = y;
    }

    // End Additions -------------------------------


    /// <summary>Implicitly converts a single float value to a color by assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(float v) => new color(v);

    /// <summary>Explicitly converts a single bool value to a color by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(bool v) => new color(v);

    /// <summary>Explicitly converts a bool4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(bool4 v) => new color(v);

    /// <summary>Implicitly converts a single int value to a color by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(int v) => new color(v);

    /// <summary>Implicitly converts a int4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(int4 v) => new color(v);

    /// <summary>Implicitly converts a single uint value to a color by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(uint v) => new color(v);

    /// <summary>Implicitly converts a uint4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(uint4 v) => new color(v);

    /// <summary>Implicitly converts a single half value to a color by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(half v) => new color(v);

    /// <summary>Implicitly converts a half4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(half4 v) => new color(v);

    /// <summary>Explicitly converts a single double value to a vector by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(double v) => new color(v);

    /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(double4 v) => new color(v);

    /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(float4 v) => new color(v);

    /// <summary>Explicitly converts a double4 vector to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(float3 v) => new color(v);
        
    // Additions --------------------------------------------------------------

    /// <summary>Implicitly converts a color vector to a float4 by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator float4(color v) => new float4(v.x, v.y, v.z, v.w);

    /// <summary>Explicitly converts a color vector to a float3 by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator float3(color v) => new float3(v.x, v.y, v.z);
        
    /// <summary>Explicitly converts a color to a UnityEngine.Color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Color(color b) => new Color(b.x, b.y, b.z, b.w);
        
    /// <summary>Implicitly converts a UnityEngine.Color to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator color(Color b) => new color(b.r, b.g, b.b, b.a);
        
    /// <summary>Explicitly converts a color to a Vector4 by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector4(color c) => new Vector4(c.x, c.y, c.z, c.w);
        
    /// <summary>Explicitly converts a Vector4 to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(Vector4 v) => new color(v.x, v.y, v.z, v.w);
        
    /// <summary>Explicitly converts a color to a Vector3 by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Vector3(color c) => new Vector3(c.x, c.y, c.z);
        
    /// <summary>Explicitly converts a Vector3 to a color by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator color(Vector3 v) => new color(v.x, v.y, v.z, 1);
        

        
    // End Additions --------------------------------------------------------------

    /// <summary>Returns the result of a componentwise multiplication operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator *(color lhs, color rhs) => new color (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);

    /// <summary>Returns the result of a componentwise multiplication operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator * (color lhs, float rhs) => new color (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);

    /// <summary>Returns the result of a componentwise multiplication operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator * (float lhs, color rhs) => new color (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);


    /// <summary>Returns the result of a componentwise addition operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator + (color lhs, color rhs) => new color (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);

    /// <summary>Returns the result of a componentwise addition operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator + (color lhs, float rhs) => new color (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);

    /// <summary>Returns the result of a componentwise addition operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator + (float lhs, color rhs) => new color (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);


    /// <summary>Returns the result of a componentwise subtraction operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator - (color lhs, color rhs) => new color (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);

    /// <summary>Returns the result of a componentwise subtraction operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator - (color lhs, float rhs) => new color (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);

    /// <summary>Returns the result of a componentwise subtraction operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator - (float lhs, color rhs) => new color (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);


    /// <summary>Returns the result of a componentwise division operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator / (color lhs, color rhs) => new color (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);

    /// <summary>Returns the result of a componentwise division operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator / (color lhs, float rhs) => new color (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

    /// <summary>Returns the result of a componentwise division operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator / (float lhs, color rhs) => new color (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);


    /// <summary>Returns the result of a componentwise modulus operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator % (color lhs, color rhs) => new color (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);

    /// <summary>Returns the result of a componentwise modulus operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator % (color lhs, float rhs) => new color (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);

    /// <summary>Returns the result of a componentwise modulus operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator % (float lhs, color rhs) => new color (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);


    /// <summary>Returns the result of a componentwise increment operation on a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator ++ (color val) => new color (++val.x, ++val.y, ++val.z, ++val.w);


    /// <summary>Returns the result of a componentwise decrement operation on a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator -- (color val) => new color (--val.x, --val.y, --val.z, --val.w);


    /// <summary>Returns the result of a componentwise less than operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator < (color lhs, color rhs) => new bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);

    /// <summary>Returns the result of a componentwise less than operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator < (color lhs, float rhs) => new bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);

    /// <summary>Returns the result of a componentwise less than operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator < (float lhs, color rhs) => new bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);


    /// <summary>Returns the result of a componentwise less or equal operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator <= (color lhs, color rhs) => new bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);

    /// <summary>Returns the result of a componentwise less or equal operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator <= (color lhs, float rhs) => new bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);

    /// <summary>Returns the result of a componentwise less or equal operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator <= (float lhs, color rhs) => new bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);


    /// <summary>Returns the result of a componentwise greater than operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator > (color lhs, color rhs) => new bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);

    /// <summary>Returns the result of a componentwise greater than operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator > (color lhs, float rhs) => new bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);

    /// <summary>Returns the result of a componentwise greater than operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator > (float lhs, color rhs) => new bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);


    /// <summary>Returns the result of a componentwise greater or equal operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator >= (color lhs, color rhs) => new bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);

    /// <summary>Returns the result of a componentwise greater or equal operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator >= (color lhs, float rhs) => new bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);

    /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator >= (float lhs, color rhs) => new bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);


    /// <summary>Returns the result of a componentwise unary minus operation on a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator - (color val) => new color (-val.x, -val.y, -val.z, -val.w);


    /// <summary>Returns the result of a componentwise unary plus operation on a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color operator + (color val) => new color (+val.x, +val.y, +val.z, +val.w);


    /// <summary>Returns the result of a componentwise equality operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator == (color lhs, color rhs) => new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);

    /// <summary>Returns the result of a componentwise equality operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator == (color lhs, float rhs) => new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);

    /// <summary>Returns the result of a componentwise equality operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator == (float lhs, color rhs) => new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);


    /// <summary>Returns the result of a componentwise not equal operation on two color vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator != (color lhs, color rhs) => new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);

    /// <summary>Returns the result of a componentwise not equal operation on a color vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator != (color lhs, float rhs) => new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);

    /// <summary>Returns the result of a componentwise not equal operation on a float value and a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool4 operator != (float lhs, color rhs) => new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, x, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, x, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, x, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, y, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, y, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, y, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, y, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, z, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, z, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, z, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxzw {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, z, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, w, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, w, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, w, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xxww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, x, w, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, x, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, x, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, x, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, x, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, y, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, y, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, y, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, y, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, z, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, z, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, z, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, z, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; y = value.y; z = value.z; w = value.w; }
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xywx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, w, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xywy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, w, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xywz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, w, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; y = value.y; w = value.z; z = value.w; }
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xyww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, y, w, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, x, x);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, x, y);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, x, z);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, x, w);
    }
        
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, y, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; z = value.y; y = value.z; w = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, w, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; z = value.y; w = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xzww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, z, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, y, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; w = value.y; y = value.z; z = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, z, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; w = value.y; z = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color xwww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(x, w, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, z, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; x = value.y; z = value.z; w = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, w, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; x = value.y; w = value.z; z = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yxww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, x, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yywx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yywy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yywz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yyww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, y, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, x, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; z = value.y; x = value.z; w = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, w, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; z = value.y; w = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color yzww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, z, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, x, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; w = value.y; x = value.z; z = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, z, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; w = value.y; z = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color ywww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(y, w, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, y, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; x = value.y; y = value.z; w = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, w, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; x = value.y; w = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zxww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, x, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, x, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; y = value.y; x = value.z; w = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zywx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, w, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; y = value.y; w = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zywy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zywz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zyww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, y, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zzww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, z, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; w = value.y; x = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; w = value.y; y = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color zwww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(z, w, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, y, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; x = value.y; y = value.z; z = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, z, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; x = value.y; z = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wxww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, x, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, x, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; y = value.y; x = value.z; z = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, z, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; y = value.y; z = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wywx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wywy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wywz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wyww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, y, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; z = value.y; x = value.z; y = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; z = value.y; y = value.z; x = value.w; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wzww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, z, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public color wwww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new color(w, w, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, y, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; y = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, y, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; y = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, z, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; z = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, z, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; z = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, w, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; w = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, w, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; w = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 xww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(x, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, x, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, x, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; x = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, x, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; x = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, y, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, z, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; z = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, z, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; z = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 ywx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, w, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; w = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 ywy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 ywz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, w, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; w = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 yww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(y, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; x = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, x, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, x, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; x = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; y = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, y, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, y, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; y = value.y; w = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, z, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, z, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, w, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; w = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, w, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; w = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 zww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(z, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wxx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wxy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; x = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wxz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, x, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; x = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wxw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, x, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wyx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; y = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wyy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wyz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, y, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; y = value.y; z = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wyw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, y, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wzx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, z, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; z = value.y; x = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wzy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, z, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; z = value.y; y = value.z; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wzz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wzw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, z, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wwx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, w, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wwy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, w, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 wwz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, w, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float3 www{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float3(w, w, w);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 xx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(x, x);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 xy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(x, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; y = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 xz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(x, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; z = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 xw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(x, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { x = value.x; w = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 yx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(y, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; x = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 yy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(y, y);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 yz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(y, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; z = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 yw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(y, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { y = value.x; w = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 zx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(z, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; x = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 zy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(z, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; y = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 zz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(z, z);
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 zw{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(z, w);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { z = value.x; w = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 wx{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(w, x);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; x = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 wy{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(w, y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; y = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 wz{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(w, z);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { w = value.x; z = value.y; }
    }

    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public float2 ww{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => new float2(w, w);
    }



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

    public float this[int index]{
        get => index switch {
            0 => x,
            1 => y,
            2 => z,
            3 => w,
            _ => throw new IndexOutOfRangeException("Invalid Color index(" + index + ")!")
        };
        set {
            switch (index) {
                case 0: x = value;
                    break;
                case 1: y = value;
                    break;
                case 2: z = value;
                    break;
                case 3: w = value;
                    break;
                default: throw new IndexOutOfRangeException("Invalid Color index(" + index + ")!");
            }
        }
    }
        
    public static void RGBToHSV(color rgbColor, out float H, out float S, out float V){
        if (rgbColor.z > rgbColor.y && rgbColor.z > rgbColor.x)
            color.RGBToHSVHelper(4f, rgbColor.z, rgbColor.x, rgbColor.y, out H, out S, out V);
        else if (rgbColor.y > rgbColor.x)
            color.RGBToHSVHelper(2f, rgbColor.y, rgbColor.z, rgbColor.x, out H, out S, out V);
        else
            color.RGBToHSVHelper(0, rgbColor.x, rgbColor.y, rgbColor.z, out H, out S, out V);
    }

    private static void RGBToHSVHelper(
        float offset,
        float dominantcolor,
        float colorone,
        float colortwo,
        out float H,
        out float S,
        out float V){
        V = dominantcolor;
        if (V != 0.0)
        {
            float num1 = colorone <= colortwo ? colorone : colortwo;
            float num2 = V - num1;
            if (num2 != 0.0) {
                S = num2 / V;
                H = offset + (colorone - colortwo) / num2;
            } else {
                S = 0;
                H = offset + (colorone - colortwo);
            }
            H /= 6f;
            if (H >= 0.0)
                return;
            ++H;
        }else {
            S = 0;
            H = 0;
        }
    }
        

    ///   <para>Creates an RGB colour from HSV input.</para>
    /// <param name="H">Hue [0..1].</param>
    /// <param name="S">Saturation [0..1].</param>
    /// <param name="V">Brightness value [0..1].</param>
    /// <param name="hdr">Output HDR colours. If true, the returned colour will not be clamped to [0..1].</param>
    /// <returns>
    ///   <para>An opaque colour with HSV matching the input.</para>
    /// </returns>
    /// <inheritdoc cref="Color"/>>
    public static color HSVToRGB(float H, float S, float V) => color.HSVToRGB(H, S, V, true);
    
    ///   <para>Creates an RGB colour from HSV input.</para>
    /// <param name="H">Hue [0..1].</param>
    /// <param name="S">Saturation [0..1].</param>
    /// <param name="V">Brightness value [0..1].</param>
    /// <param name="hdr">Output HDR colours. If true, the returned colour will not be clamped to [0..1].</param>
    /// <returns>
    ///   <para>An opaque colour with HSV matching the input.</para>
    /// </returns>
    public static color HSVToRGB(float H, float S, float V, bool hdr)
    {
        var white = color.white;
        if (S == 0)
        {
            white.xyz = V;
        }
        else if (V == 0.0)
        {
            white.xyz = 0;
        }
        else
        {
            white.xyz = 0;
            float num1 = S;
            float num2 = V;
            float f = H * 6;
            int num3 = (int)f.floor();
            float num4 = f - num3;
            float num5 = num2 * (1 - num1);
            float num6 = num2 * (1 - num1 * num4);
            float num7 = num2 * (1 - num1 * (1 - num4));
            switch (num3){
                case -1: white.xyz = new float3(num2, num5, num6);
                    break;
                case 0: white.xyz = new float3(num2, num7, num5);
                    break;
                case 1: white.xyz = new float3(num6, num2, num5);
                    break;
                case 2: white.xyz = new float3(num5, num2, num7);
                    break;
                case 3: white.xyz = new float3(num5, num6, num2);
                    break;
                case 4: white.xyz = new float3(num7, num5, num2);
                    break;
                case 5: white.xyz = new float3(num2, num5, num6);
                    break;
                case 6: white.xyz = new float3(num2, num7, num5);
                    break;
            }
            if (!hdr) white.xyz = white.xyz.saturate();
        }
        return white;
    }
    
    /// <summary>Returns true if the color is equal to a given color, false otherwise.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Equals(color rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

    /// <summary>Returns true if the color is equal to a given color, false otherwise.</summary>
    public override bool Equals(object o) => Equals((color)o);


    /// <summary>Returns a hash code for the color.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode() => (int)math.hash(this);


    /// <summary>Returns a string representation of the color.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString() => $"color({x}f, {y}f, {z}f, {w}f)";

    /// <summary>Returns a string representation of the color using a specified format and culture-specific format information.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(string format, IFormatProvider formatProvider){
        return $"color({x.ToString(format, formatProvider)}f, {y.ToString(format, formatProvider)}f, {z.ToString(format, formatProvider)}f, {w.ToString(format, formatProvider)}f)";
    }

    internal sealed class DebuggerProxy{
        public float x;
        public float y;
        public float z;
        public float w;
        public DebuggerProxy(color v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
    }
    // Additions ---------------------
    public color RGBMultiplied(float multiplier) => new color(x * multiplier, y * multiplier, z * multiplier, w);
    public color AlphaMultiplied(float multiplier) => new color(x, y, z, w * multiplier);
    public color RGBMultiplied(color multiplier) => new color(x * multiplier.x, y * multiplier.y, z * multiplier.z, w);
        
    ///   <para>Solid red. RGBA is (1, 0, 0, 1).</para>
    public static color red => new color(1, 0, 0, 1);
    ///   <para>Solid green. RGBA is (0, 1, 0, 1).</para>
    public static color green => new color(0, 1, 0, 1);
    ///   <para>Solid blue. RGBA is (0, 0, 1, 1).</para>
    public static color blue => new color(0, 0, 1, 1);
    ///   <para>Solid white. RGBA is (1, 1, 1, 1).</para>
    public static color white => new color(1,1,1,1);
    ///   <para>Solid black. RGBA is (0, 0, 0, 1).</para>
    public static color black => new color(0, 0, 0, 1);
    ///   <para>Yellow. RGBA is (1, 0.92, 0.016, 1), but the color is nice to look at!</para>
    public static color yellow => new color(1, 0.9215686f, 0.01568628f, 1);
    ///   <para>Cyan. RGBA is (0, 1, 1, 1).</para>
    public static color cyan => new color(0, 1, 1, 1);
    ///   <para>Magenta. RGBA is (1, 0, 1, 1).</para>
    public static color magenta => new color(1, 0, 1, 1);
    ///   <para>Gray. RGBA is (0.5, 0.5, 0.5, 1).</para>
    public static color gray => new color(0.5f, 0.5f, 0.5f, 1);
    ///   <para>English spelling for gray. RGBA is the same (0.5, 0.5, 0.5, 1).</para>
    public static color grey => new color(0.5f, 0.5f, 0.5f, 1);
    ///   <para>Completely transparent. RGBA is (0, 0, 0, 0).</para>
    public static color clear => new color(0,0,0,0);
        
    ///   <para>The grayscale value of the color. (Read Only)</para>
    // public float grayscale => (float) (0.29899999499321 * x + 0.587000012397766 * y + 57.0 / 500.0 * z);
    public float grayscale => math.dot(new float3(0.29899999499321f, 0.587000012397766f, 57 / 500), xyz);
    ///   <para>A linear value of an sRGB color.</para>
    public color linear => new color(Mathf.GammaToLinearSpace(x), Mathf.GammaToLinearSpace(y), Mathf.GammaToLinearSpace(z), w);
    ///   <para>A version of the color that has had the gamma curve applied.</para>
    public color gamma => new color(Mathf.LinearToGammaSpace(x), Mathf.LinearToGammaSpace(y), Mathf.LinearToGammaSpace(z), w);
    ///   <para>Returns the maximum color component value: Max(r,g,b).</para>
    public float maxcolorComponent => xyz.cmax();
    
    ///   <para>Solid orange. RGBA is (1, 0.5f, 0, 1).</para>
    public static color orange => new color(1, 0.5f, 0, 1);
    
}
   
public static partial class UME
{
    /// <summary>Returns a color vector constructed from four float values.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float x, float y, float z, float w) => new color(x, y, z, w);

    /// <summary>Returns a color vector constructed from two float values and a float2 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float x, float y, float2 zw) => new color(x, y, zw);

    /// <summary>Returns a color vector constructed from a float value, a float2 vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float x, float2 yz, float w) => new color(x, yz, w);

    /// <summary>Returns a color vector constructed from a float value and a float3 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float x, float3 yzw) => new color(x, yzw);

    /// <summary>Returns a color vector constructed from a float2 vector and two float values.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float2 xy, float z, float w) => new color(xy, z, w);

    /// <summary>Returns a color vector constructed from two float2 vectors.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float2 xy, float2 zw) => new color(xy, zw);

    /// <summary>Returns a color vector constructed from a float3 vector and a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float3 xyz, float w) => new color(xyz, w);

    /// <summary>Returns a color vector constructed from a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(color xyzw) => new color(xyzw);

    /// <summary>Returns a color vector constructed from a single float value by assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(float v) => new color(v);

    /// <summary>Returns a color vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(bool v) => new color(v);

    /// <summary>Return a color vector constructed from a bool4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(bool4 v) => new color(v);

    /// <summary>Returns a color vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(int v) => new color(v);

    /// <summary>Return a color vector constructed from a int4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(int4 v) => new color(v);

    /// <summary>Returns a color vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(uint v) => new color(v);

    /// <summary>Return a color vector constructed from a uint4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(uint4 v) => new color(v);

    /// <summary>Returns a color vector constructed from a single half value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(half v) => new color(v);

    /// <summary>Return a color vector constructed from a half4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(half4 v) => new color(v);

    /// <summary>Returns a color vector constructed from a single double value by converting it to float and assigning it to every component.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(double v) => new color(v);

    /// <summary>Return a color vector constructed from a double4 vector by componentwise conversion.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color color(double4 v) => new color(v);

    /// <summary>Returns a uint hash code of a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint hash(color v){
        return math.csum(math.asuint(v) * new uint4(0xE69626FFu, 0xBD010EEBu, 0x9CEDE1D1u, 0x43BE0B51u)) + 0xAF836EE1u;
    }

    /// <summary>
    /// Returns a uint4 vector hash code of a color vector.
    /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
    /// that are only reduced to a narrow uint hash at the very end instead of at every step.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint4 hashwide(color v) {
        return (math.asuint(v) * new uint4(0xB130C137u, 0x54834775u, 0x7C022221u, 0xA2D00EDFu)) + 0xA8977779u;
    }

    /// <summary>Returns the result of specified shuffling of the components from two color vectors into a float value.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float shuffle(color a, color b, math.ShuffleComponent x) {
        return select_shuffle_component(a, b, x);
    }

    /// <summary>Returns the result of specified shuffling of the components from two color vectors into a float2 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float2 shuffle(color a, color b, math.ShuffleComponent x, math.ShuffleComponent y){
        return math.float2(
            select_shuffle_component(a, b, x),
            select_shuffle_component(a, b, y));
    }

    /// <summary>Returns the result of specified shuffling of the components from two color vectors into a float3 vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float3 shuffle(color a, color b, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z){
        return math.float3(
            select_shuffle_component(a, b, x),
            select_shuffle_component(a, b, y),
            select_shuffle_component(a, b, z));
    }

    /// <summary>Returns the result of specified shuffling of the components from two color vectors into a color vector.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static color shuffle(color a, color b, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w){
        return color(
            select_shuffle_component(a, b, x),
            select_shuffle_component(a, b, y),
            select_shuffle_component(a, b, z),
            select_shuffle_component(a, b, w));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static float select_shuffle_component(color a, color b, math.ShuffleComponent component) {
        return component switch {
            math.ShuffleComponent.LeftX => a.x,
            math.ShuffleComponent.LeftY => a.y,
            math.ShuffleComponent.LeftZ => a.z,
            math.ShuffleComponent.LeftW => a.w,
            math.ShuffleComponent.RightX => b.x,
            math.ShuffleComponent.RightY => b.y,
            math.ShuffleComponent.RightZ => b.z,
            math.ShuffleComponent.RightW => b.w,
            _ => throw new ArgumentException("Invalid shuffle component: " + component)
        };
    }
        
    // Additions --------------------- 
        
    public static color clamp(this color f, float min, float max) => math.clamp(f, min, max);
    public static color min(this color f, color m) => math.min(f, m);
    public static color max(this color f, color m) => math.max(f, m);
    public static color saturate(this color f) => math.saturate(f);
    public static color sqrt(this color f) => math.sqrt(f);
    public static color pow(this color f, float pow) => math.pow(f, pow);
    public static color pow(this color f, float4 min) => math.pow(f, min);
    public static color sqr(this color f) => f * f;
    public static color cube(this color f) => f * f * f;
    public static color quart(this color f) => f * f * f * f;
    public static color quint(this color f) => f * f * f * f * f;
    public static color frac(this color f) => math.frac(f);
    public static color sign(this color f) => math.sign(f);
    public static color abs(this color f) => math.abs(f); 
    public static float sum(this color f) => math.csum(f);
    public static float cmul(this color f) => f.x * f.y * f.z * f.w;
    public static color onem(this color f) => 1 - f;
    public static color neg(this color f) => - f;
    public static color rcp(this color f) => math.rcp(f);
    public static color lerp(color a, color b, float f) => math.lerp(a, b, f);
    public static color lerp(this float f, color a, color b) => math.lerp(a, b, f);
    public static color unlerp(this float f, color min, color max) => math.unlerp(min, max, f);
    public static color unlerp(color min, color max, float f) => math.unlerp(min, max, f);
}