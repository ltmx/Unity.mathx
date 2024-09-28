#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion


using MI = System.Runtime.CompilerServices.MethodImplAttribute;


namespace Unity.Mathematics
{
    
    public static partial class mathx
    {
        
        /// Returns true if a is odd
        [MI(IL)] public static bool odd(this byte a) => (a & 1) != 0; // 12% faster than a % 2 == 1
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool2 odd(this byte2 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool3 odd(this byte3 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool4 odd(this byte4 a) => (a & 1) != 0;
        
        /// Returns true if a is even
        [MI(IL)] public static bool even(this byte a) => (a & 1) != 1; // 12% faster than a % 2 == 0
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool2 even(this byte2 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool3 even(this byte3 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool4 even(this byte4 a) => (a & 1) != 1;
        
        
        // Node : Bytes are never NAN, and Never Infinite... these methods are reserved to floating point numbers


        /// returns true component-wise if the any component is greater to the other value, otherwise false
        [MI(IL)] public static bool4 greater(this byte4 f, byte value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 greater(this byte3 f, byte value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 greater(this byte2 f, byte value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool greater(this byte f, byte value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 greater(this byte4 f, byte4 value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 greater(this byte3 f, byte3 value) => f > value;
        /// <inheritdoc cref="greater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 greater(this byte2 f, byte2 value) => f > value;
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        [MI(IL)] public static bool4 less(this byte4 f, byte value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 less(this byte3 f, byte value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 less(this byte2 f, byte value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool less(this byte f, byte value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 less(this byte4 f, byte4 value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 less(this byte3 f, byte3 value) => f < value;
        /// <inheritdoc cref="less(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 less(this byte2 f, byte2 value) => f < value;
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        [MI(IL)] public static bool4 lesseq(this byte4 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 lesseq(this byte3 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 lesseq(this byte2 f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool lesseq(this byte f, byte value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 lesseq(this byte4 f, byte4 value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 lesseq(this byte3 f, byte3 value) => f <= value;
        /// <inheritdoc cref="lesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 lesseq(this byte2 f, byte2 value) => f <= value;
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        [MI(IL)] public static bool4 greatereq(this byte4 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 greatereq(this byte3 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 greatereq(this byte2 f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool greatereq(this byte f, byte value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 greatereq(this byte4 f, byte4 value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 greatereq(this byte3 f, byte3 value) => f >= value;
        /// <inheritdoc cref="greatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 greatereq(this byte2 f, byte2 value) => f >= value;
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        [MI(IL)] public static bool4 eq(this byte4 f, byte value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 eq(this byte3 f, byte value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 eq(this byte2 f, byte value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool eq(this byte f, byte value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 eq(this byte4 f, byte4 value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 eq(this byte3 f, byte3 value) => f == value;
        /// <inheritdoc cref="eq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 eq(this byte2 f, byte2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        [MI(IL)] public static bool4 neq(this byte4 f, byte value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 neq(this byte3 f, byte value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 neq(this byte2 f, byte value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool neq(this byte f, byte value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool4 neq(this byte4 f, byte4 value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool3 neq(this byte3 f, byte3 value) => f != value;
        /// <inheritdoc cref="neq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool2 neq(this byte2 f, byte2 value) => f != value;
        
        
                /// returns true if the any component is greater to the other value, otherwise false
        [MI(IL)] public static bool anygreater(this byte4 f, byte v) => f.x > v || f.y > v || f.z > v || f.w > v;
        /// <inheritdoc cref="anygreater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreater(this byte3 f, byte v) => f.x > v || f.y > v || f.z > v;
        /// <inheritdoc cref="anygreater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreater(this byte2 f, byte v) => f.x > v || f.y > v;
        /// <inheritdoc cref="anygreater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreater(this byte4 f, byte4 v) => f.x > v.x || f.y > v.y || f.z > v.z || f.z > v.z || f.w > v.w;
        /// <inheritdoc cref="anygreater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreater(this byte3 f, byte3 v) => f.x > v.x || f.y > v.y || f.z > v.z || f.z > v.z;
        /// <inheritdoc cref="anygreater(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreater(this byte2 f, byte2 v) => f.x > v.x || f.y > v.y;
        
        /// returns true if the any component is greater or equal to the other value, otherwise false
        [MI(IL)] public static bool anygreatereq(this byte4 f, byte v) => f.x >= v || f.y >= v || f.z >= v || f.w >= v;
        /// <inheritdoc cref="anygreatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreatereq(this byte3 f, byte v) => f.x >= v || f.y >= v || f.z >= v;
        /// <inheritdoc cref="anygreatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreatereq(this byte2 f, byte v) => f.x >= v || f.y >= v;
        /// <inheritdoc cref="anygreatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreatereq(this byte4 f, byte4 v) => f.x >= v.x || f.y >= v.y || f.z >= v.z || f.w >= v.w;
        /// <inheritdoc cref="anygreatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreatereq(this byte3 f, byte3 v) => f.x >= v.x || f.y >= v.y || f.z >= v.z;
        /// <inheritdoc cref="anygreatereq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anygreatereq(this byte2 f, byte2 v) => f.x >= v.x || f.y >= v.y;
                
        /// returns true if the any component is less to the other value, otherwise false
        [MI(IL)] public static bool anyless(this byte4 f, byte v) => f.x < v || f.y < v || f.z < v || f.w < v;
        /// <inheritdoc cref="anyless(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyless(this byte3 f, byte v) => f.x < v || f.y < v || f.z < v;
        /// <inheritdoc cref="anyless(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyless(this byte2 f, byte v) => f.x < v || f.y < v;
        /// <inheritdoc cref="anyless(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyless(this byte4 f, byte4 v) => f.x < v.x || f.y < v.y || f.z < v.z || f.w < v.w;
        /// <inheritdoc cref="anyless(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyless(this byte3 f, byte3 v) => f.x < v.x || f.y < v.y || f.z < v.z;
        /// <inheritdoc cref="anyless(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyless(this byte2 f, byte2 v) => f.x < v.x || f.y < v.y;
        
        /// returns true if the any component is less or equal to the other value, otherwise false
        [MI(IL)] public static bool anylesseq(this byte4 f, byte v) => f.x <= v || f.y <= v || f.z <= v || f.w <= v;
        /// <inheritdoc cref="anylesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anylesseq(this byte3 f, byte v) => f.x <= v || f.y <= v || f.z <= v;
        /// <inheritdoc cref="anylesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anylesseq(this byte2 f, byte v) => f.x <= v || f.y <= v;
        /// <inheritdoc cref="anylesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anylesseq(this byte4 f, byte4 v) => f.x <= v.x || f.y <= v.y || f.z <= v.z || f.w <= v.w;
        /// <inheritdoc cref="anylesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anylesseq(this byte3 f, byte3 v) => f.x <= v.x || f.y <= v.y || f.z <= v.z;
        /// <inheritdoc cref="anylesseq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anylesseq(this byte2 f, byte2 v) => f.x <= v.x || f.y <= v.y;
        
        
        /// returns true if the any component is equal to the other value, otherwise false
        [MI(IL)] public static bool anyeq(this byte4 f, byte v) => f.x == v || f.y == v || f.z == v || f.w == v;
        /// <inheritdoc cref="anyeq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyeq(this byte3 f, byte v) => f.x == v || f.y == v || f.z == v;
        /// <inheritdoc cref="anyeq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyeq(this byte2 f, byte v) => f.x == v || f.y == v;
        /// <inheritdoc cref="anyeq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyeq(this byte4 f, byte4 v) => f.x == v.x || f.y == v.y || f.z == v.z || f.w == v.w;
        /// <inheritdoc cref="anyeq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyeq(this byte3 f, byte3 v) => f.x == v.x || f.y == v.y || f.z == v.z;
        /// <inheritdoc cref="anyeq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyeq(this byte2 f, byte2 v) => f.x == v.x || f.y == v.y;
        
        
        /// returns true if the any component is not equal to the other value, otherwise false
        [MI(IL)] public static bool anyneq(this byte4 f, byte v) => f.x != v || f.y != v || f.z != v || f.w != v;
        /// <inheritdoc cref="anyneq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyneq(this byte3 f, byte v) => f.x != v || f.y != v || f.z != v;
        /// <inheritdoc cref="anyneq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyneq(this byte2 f, byte v) => f.x != v || f.y != v;
        /// <inheritdoc cref="anyneq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyneq(this byte4 f, byte4 v) => f.x != v.x || f.y != v.y || f.z != v.z || f.w != v.w;
        /// <inheritdoc cref="anyneq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyneq(this byte3 f, byte3 v) => f.x != v.x || f.y != v.y || f.z != v.z;
        /// <inheritdoc cref="anyneq(Mathematics.byte4,byte)"/>
        [MI(IL)] public static bool anyneq(this byte2 f, byte2 v) => f.x != v.x || f.y != v.y;
        
        
        /// Returns 1 inside the longest(s) axis(es) and 0 in the others
        [MI(IL)] public static bool4 isgreatest(this byte4 f) => f == f.cmax();
        /// <inheritdoc cref="isgreatest(Mathematics.byte4)"/>
        [MI(IL)] public static bool3 isgreatest(this byte3 f) => f == f.cmax();
        /// <inheritdoc cref="isgreatest(Mathematics.byte4)"/>
        [MI(IL)] public static bool2 isgreatest(this byte2 f) => f == f.cmax();

        /// Returns true inside the shortest axes
        [MI(IL)] public static bool4 isshortest(this byte4 f)  => f == f.cmin();
        /// <inheritdoc cref="isshortest(Mathematics.byte4)"/>
        [MI(IL)] public static bool3 isshortest(this byte3 f) => f == f.cmin();
        /// <inheritdoc cref="isshortest(Mathematics.byte4)"/>
        [MI(IL)] public static bool2 isshortest(this byte2 f) => f == f.cmin();
    }
}