#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Returns true if a is odd
        public static bool odd(this int a) => (a & 1) != 0; // 12% faster than a % 2 == 1
        /// Returns true if a is odd component-wise
        public static bool2 odd(this int2 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool3 odd(this int3 a) => (a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool4 odd(this int4 a) => (a & 1) != 0;
        
        /// Returns true if a is even
        public static bool even(this int a) => (a & 1) != 1; // 12% faster than a % 2 == 0
        /// Returns true if a is even component-wise
        public static bool2 even(this int2 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool3 even(this int3 a) => (a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool4 even(this int4 a) => (a & 1) != 1;
        
        /// <inheritdoc cref="math.isnan(int4)"/>
        public static bool4 isnan(this int4 f) => math.isnan(f.x);
        /// <inheritdoc cref="math.isnan(int4)"/>
        public static bool3 isnan(this int3 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(int4)"/>
        public static bool2 isnan(this int2 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(int4)"/>
        public static bool isnan(this int f) => math.isnan(f);

        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this int4 f) => f.x.isnan() || f.y.isnan() || f.z.isnan() || f.w.isnan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this int3 f) => f.x.isnan() || f.y.isnan() || f.z.isnan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this int2 f) => f.x.isnan() || f.y.isnan();
        
        /// <inheritdoc cref="math.isinf(int4)"/>
        public static bool4 isinf(this int4 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(int4)"/>
        public static bool3 isinf(this int3 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(int4)"/>
        public static bool2 isinf(this int2 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(int4)"/>
        public static bool isinf(this int f) => math.isinf(f);
        
        /// <inheritdoc cref="math.isfinite(int4)"/>
        public static bool4 isfinite(this int4 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(int4)"/>
        public static bool3 isfinite(this int3 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(int4)"/>
        public static bool2 isfinite(this int2 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(int4)"/>
        public static bool isfinite(this int f) => math.isfinite(f);

        /// returns true component-wise if the any component is greater to the other value, otherwise false
        public static bool4 greater(this int4 f, int value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool3 greater(this int3 f, int value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool2 greater(this int2 f, int value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool greater(this int f, int value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool4 greater(this int4 f, int4 value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool3 greater(this int3 f, int3 value) => (f > value);
        /// <inheritdoc cref="greater(int4,int)"/>
        public static bool2 greater(this int2 f, int2 value) => (f > value);
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        public static bool4 less(this int4 f, int value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool3 less(this int3 f, int value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool2 less(this int2 f, int value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool less(this int f, int value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool4 less(this int4 f, int4 value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool3 less(this int3 f, int3 value) => (f < value);
        /// <inheritdoc cref="less(int4,int)"/>
        public static bool2 less(this int2 f, int2 value) => (f < value);
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        public static bool4 lesseq(this int4 f, int value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool3 lesseq(this int3 f, int value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool2 lesseq(this int2 f, int value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool lesseq(this int f, int value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool4 lesseq(this int4 f, int4 value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool3 lesseq(this int3 f, int3 value) => (f <= value);
        /// <inheritdoc cref="lesseq(int4,int)"/>
        public static bool2 lesseq(this int2 f, int2 value) => (f <= value);
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        public static bool4 greatereq(this int4 f, int value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool3 greatereq(this int3 f, int value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool2 greatereq(this int2 f, int value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool greatereq(this int f, int value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool4 greatereq(this int4 f, int4 value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool3 greatereq(this int3 f, int3 value) => (f >= value);
        /// <inheritdoc cref="greatereq(int4,int)"/>
        public static bool2 greatereq(this int2 f, int2 value) => (f >= value);
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        public static bool4 eq(this int4 f, int value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool3 eq(this int3 f, int value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool2 eq(this int2 f, int value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool eq(this int f, int value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool4 eq(this int4 f, int4 value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool3 eq(this int3 f, int3 value) => f == value;
        /// <inheritdoc cref="eq(int4,int)"/>
        public static bool2 eq(this int2 f, int2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        public static bool4 neq(this int4 f, int value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool3 neq(this int3 f, int value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool2 neq(this int2 f, int value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool neq(this int f, int value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool4 neq(this int4 f, int4 value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool3 neq(this int3 f, int3 value) => f != value;
        /// <inheritdoc cref="neq(int4,int)"/>
        public static bool2 neq(this int2 f, int2 value) => f != value;
    }
}