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
        public static bool odd(this double a) => ((int)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool2 odd(this double2 a) => ((int2)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool3 odd(this double3 a) => ((int3)a & 1) != 0;
        /// Returns true if a is odd component-wise
        public static bool4 odd(this double4 a) => ((int4)a & 1) != 0;
        
        /// Returns true if a is even
        public static bool even(this double a) => ((int)a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool2 even(this double2 a) => ((int2)a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool3 even(this double3 a) => ((int3)a & 1) != 1;
        /// Returns true if a is even component-wise
        public static bool4 even(this double4 a) => ((int4)a & 1) != 1;
        
        /// <inheritdoc cref="math.isnan(double4)"/>
        public static bool4 isnan(this double4 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        public static bool3 isnan(this double3 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        public static bool2 isnan(this double2 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        public static bool isnan(this double f) => math.isnan(f);

        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this double4 f) => f.x.isnan() || f.y.isnan() || f.z.isnan() || f.w.isnan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this double3 f) => f.x.isnan() || f.y.isnan() || f.z.isnan();
        /// returns true if the any component is NAN, otherwise false
        public static bool anynan(this double2 f) => f.x.isnan() || f.y.isnan();
        
        /// <inheritdoc cref="math.isinf(double4)"/>
        public static bool4 isinf(this double4 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        public static bool3 isinf(this double3 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        public static bool2 isinf(this double2 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        public static bool isinf(this double f) => math.isinf(f);
        
        /// <inheritdoc cref="math.isfinite(double4)"/>
        public static bool4 isfinite(this double4 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        public static bool3 isfinite(this double3 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        public static bool2 isfinite(this double2 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        public static bool isfinite(this double f) => math.isfinite(f);

        /// returns true component-wise if the any component is greater to the other value, otherwise false
        public static bool4 greater(this double4 f, double value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool3 greater(this double3 f, double value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool2 greater(this double2 f, double value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool greater(this double f, double value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool4 greater(this double4 f, double4 value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool3 greater(this double3 f, double3 value) => (f > value);
        /// <inheritdoc cref="greater(double4,double)"/>
        public static bool2 greater(this double2 f, double2 value) => (f > value);
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        public static bool4 less(this double4 f, double value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool3 less(this double3 f, double value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool2 less(this double2 f, double value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool less(this double f, double value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool4 less(this double4 f, double4 value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool3 less(this double3 f, double3 value) => (f < value);
        /// <inheritdoc cref="less(double4,double)"/>
        public static bool2 less(this double2 f, double2 value) => (f < value);
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        public static bool4 lesseq(this double4 f, double value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool3 lesseq(this double3 f, double value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool2 lesseq(this double2 f, double value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool lesseq(this double f, double value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool4 lesseq(this double4 f, double4 value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool3 lesseq(this double3 f, double3 value) => (f <= value);
        /// <inheritdoc cref="lesseq(double4,double)"/>
        public static bool2 lesseq(this double2 f, double2 value) => (f <= value);
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        public static bool4 greatereq(this double4 f, double value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool3 greatereq(this double3 f, double value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool2 greatereq(this double2 f, double value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool greatereq(this double f, double value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool4 greatereq(this double4 f, double4 value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool3 greatereq(this double3 f, double3 value) => (f >= value);
        /// <inheritdoc cref="greatereq(double4,double)"/>
        public static bool2 greatereq(this double2 f, double2 value) => (f >= value);
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        public static bool4 eq(this double4 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool3 eq(this double3 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool2 eq(this double2 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool eq(this double f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool4 eq(this double4 f, double4 value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool3 eq(this double3 f, double3 value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        public static bool2 eq(this double2 f, double2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        public static bool4 neq(this double4 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool3 neq(this double3 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool2 neq(this double2 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool neq(this double f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool4 neq(this double4 f, double4 value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool3 neq(this double3 f, double3 value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        public static bool2 neq(this double2 f, double2 value) => f != value;
    }
}