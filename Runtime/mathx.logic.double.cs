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
        [MI(IL)] public static bool odd(this double a) => ((int)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool2 odd(this double2 a) => ((int2)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool3 odd(this double3 a) => ((int3)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MI(IL)] public static bool4 odd(this double4 a) => ((int4)a & 1) != 0;
        
        /// Returns true if a is even
        [MI(IL)] public static bool even(this double a) => ((int)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool2 even(this double2 a) => ((int2)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool3 even(this double3 a) => ((int3)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MI(IL)] public static bool4 even(this double4 a) => ((int4)a & 1) != 1;
        
        /// <inheritdoc cref="math.isnan(double4)"/>
        [MI(IL)] public static bool4 isnan(this double4 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        [MI(IL)] public static bool3 isnan(this double3 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        [MI(IL)] public static bool2 isnan(this double2 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(double4)"/>
        [MI(IL)] public static bool isnan(this double f) => math.isnan(f);

        /// returns true if the any component is NAN, otherwise false
        [MI(IL)] public static bool anynan(this double4 f) => f.x.isnan() || f.y.isnan() || f.z.isnan() || f.w.isnan();
        /// returns true if the any component is NAN, otherwise false
        [MI(IL)] public static bool anynan(this double3 f) => f.x.isnan() || f.y.isnan() || f.z.isnan();
        /// returns true if the any component is NAN, otherwise false
        [MI(IL)] public static bool anynan(this double2 f) => f.x.isnan() || f.y.isnan();
        
        /// <inheritdoc cref="math.isinf(double4)"/>
        [MI(IL)] public static bool4 isinf(this double4 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        [MI(IL)] public static bool3 isinf(this double3 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        [MI(IL)] public static bool2 isinf(this double2 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(double4)"/>
        [MI(IL)] public static bool isinf(this double f) => math.isinf(f);
        
        /// <inheritdoc cref="math.isfinite(double4)"/>
        [MI(IL)] public static bool4 isfinite(this double4 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        [MI(IL)] public static bool3 isfinite(this double3 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        [MI(IL)] public static bool2 isfinite(this double2 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(double4)"/>
        [MI(IL)] public static bool isfinite(this double f) => math.isfinite(f);

        /// returns true component-wise if the any component is greater to the other value, otherwise false
        [MI(IL)] public static bool4 greater(this double4 f, double value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool3 greater(this double3 f, double value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool2 greater(this double2 f, double value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool greater(this double f, double value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool4 greater(this double4 f, double4 value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool3 greater(this double3 f, double3 value) => f > value;
        /// <inheritdoc cref="greater(double4,double)"/>
        [MI(IL)] public static bool2 greater(this double2 f, double2 value) => f > value;
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        [MI(IL)] public static bool4 less(this double4 f, double value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool3 less(this double3 f, double value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool2 less(this double2 f, double value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool less(this double f, double value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool4 less(this double4 f, double4 value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool3 less(this double3 f, double3 value) => f < value;
        /// <inheritdoc cref="less(double4,double)"/>
        [MI(IL)] public static bool2 less(this double2 f, double2 value) => f < value;
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        [MI(IL)] public static bool4 lesseq(this double4 f, double value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool3 lesseq(this double3 f, double value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool2 lesseq(this double2 f, double value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool lesseq(this double f, double value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool4 lesseq(this double4 f, double4 value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool3 lesseq(this double3 f, double3 value) => f <= value;
        /// <inheritdoc cref="lesseq(double4,double)"/>
        [MI(IL)] public static bool2 lesseq(this double2 f, double2 value) => f <= value;
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        [MI(IL)] public static bool4 greatereq(this double4 f, double value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool3 greatereq(this double3 f, double value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool2 greatereq(this double2 f, double value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool greatereq(this double f, double value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool4 greatereq(this double4 f, double4 value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool3 greatereq(this double3 f, double3 value) => f >= value;
        /// <inheritdoc cref="greatereq(double4,double)"/>
        [MI(IL)] public static bool2 greatereq(this double2 f, double2 value) => f >= value;
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        [MI(IL)] public static bool4 eq(this double4 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool3 eq(this double3 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool2 eq(this double2 f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool eq(this double f, double value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool4 eq(this double4 f, double4 value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool3 eq(this double3 f, double3 value) => f == value;
        /// <inheritdoc cref="eq(double4,double)"/>
        [MI(IL)] public static bool2 eq(this double2 f, double2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        [MI(IL)] public static bool4 neq(this double4 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool3 neq(this double3 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool2 neq(this double2 f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool neq(this double f, double value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool4 neq(this double4 f, double4 value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool3 neq(this double3 f, double3 value) => f != value;
        /// <inheritdoc cref="neq(double4,double)"/>
        [MI(IL)] public static bool2 neq(this double2 f, double2 value) => f != value;
        
        
        
        /// returns true if the any component is greater to the other value, otherwise false
        [MI(IL)] public static bool anygreater(this double4 f, double v) => f.x > v || f.y > v || f.z > v || f.w > v;
        /// <inheritdoc cref="anygreater(double4,double)"/>
        [MI(IL)] public static bool anygreater(this double3 f, double v) => f.x > v || f.y > v || f.z > v;
        /// <inheritdoc cref="anygreater(double4,double)"/>
        [MI(IL)] public static bool anygreater(this double2 f, double v) => f.x > v || f.y > v;
        /// <inheritdoc cref="anygreater(double4,double)"/>
        [MI(IL)] public static bool anygreater(this double4 f, double4 v) => f.x > v.x || f.y > v.y || f.z > v.z || f.z > v.z || f.w > v.w;
        /// <inheritdoc cref="anygreater(double4,double)"/>
        [MI(IL)] public static bool anygreater(this double3 f, double3 v) => f.x > v.x || f.y > v.y || f.z > v.z || f.z > v.z;
        /// <inheritdoc cref="anygreater(double4,double)"/>
        [MI(IL)] public static bool anygreater(this double2 f, double2 v) => f.x > v.x || f.y > v.y;
        
        /// returns true if the any component is greater or equal to the other value, otherwise false
        [MI(IL)] public static bool anygreatereq(this double4 f, double v) => f.x >= v || f.y >= v || f.z >= v || f.w >= v;
        /// <inheritdoc cref="anygreatereq(double4,double)"/>
        [MI(IL)] public static bool anygreatereq(this double3 f, double v) => f.x >= v || f.y >= v || f.z >= v;
        /// <inheritdoc cref="anygreatereq(double4,double)"/>
        [MI(IL)] public static bool anygreatereq(this double2 f, double v) => f.x >= v || f.y >= v;
        /// <inheritdoc cref="anygreatereq(double4,double)"/>
        [MI(IL)] public static bool anygreatereq(this double4 f, double4 v) => f.x >= v.x || f.y >= v.y || f.z >= v.z || f.w >= v.w;
        /// <inheritdoc cref="anygreatereq(double4,double)"/>
        [MI(IL)] public static bool anygreatereq(this double3 f, double3 v) => f.x >= v.x || f.y >= v.y || f.z >= v.z;
        /// <inheritdoc cref="anygreatereq(double4,double)"/>
        [MI(IL)] public static bool anygreatereq(this double2 f, double2 v) => f.x >= v.x || f.y >= v.y;
                
        /// returns true if the any component is less to the other value, otherwise false
        [MI(IL)] public static bool anyless(this double4 f, double v) => f.x < v || f.y < v || f.z < v || f.w < v;
        /// <inheritdoc cref="anyless(double4,double)"/>
        [MI(IL)] public static bool anyless(this double3 f, double v) => f.x < v || f.y < v || f.z < v;
        /// <inheritdoc cref="anyless(double4,double)"/>
        [MI(IL)] public static bool anyless(this double2 f, double v) => f.x < v || f.y < v;
        /// <inheritdoc cref="anyless(double4,double)"/>
        [MI(IL)] public static bool anyless(this double4 f, double4 v) => f.x < v.x || f.y < v.y || f.z < v.z || f.w < v.w;
        /// <inheritdoc cref="anyless(double4,double)"/>
        [MI(IL)] public static bool anyless(this double3 f, double3 v) => f.x < v.x || f.y < v.y || f.z < v.z;
        /// <inheritdoc cref="anyless(double4,double)"/>
        [MI(IL)] public static bool anyless(this double2 f, double2 v) => f.x < v.x || f.y < v.y;
        
        /// returns true if the any component is less or equal to the other value, otherwise false
        [MI(IL)] public static bool anylesseq(this double4 f, double v) => f.x <= v || f.y <= v || f.z <= v || f.w <= v;
        /// <inheritdoc cref="anylesseq(double4,double)"/>
        [MI(IL)] public static bool anylesseq(this double3 f, double v) => f.x <= v || f.y <= v || f.z <= v;
        /// <inheritdoc cref="anylesseq(double4,double)"/>
        [MI(IL)] public static bool anylesseq(this double2 f, double v) => f.x <= v || f.y <= v;
        /// <inheritdoc cref="anylesseq(double4,double)"/>
        [MI(IL)] public static bool anylesseq(this double4 f, double4 v) => f.x <= v.x || f.y <= v.y || f.z <= v.z || f.w <= v.w;
        /// <inheritdoc cref="anylesseq(double4,double)"/>
        [MI(IL)] public static bool anylesseq(this double3 f, double3 v) => f.x <= v.x || f.y <= v.y || f.z <= v.z;
        /// <inheritdoc cref="anylesseq(double4,double)"/>
        [MI(IL)] public static bool anylesseq(this double2 f, double2 v) => f.x <= v.x || f.y <= v.y;
        
        
        /// returns true if the any component is equal to the other value, otherwise false
        [MI(IL)] public static bool anyeq(this double4 f, double v) => f.x == v || f.y == v || f.z == v || f.w == v;
        /// <inheritdoc cref="anyeq(double4,double)"/>
        [MI(IL)] public static bool anyeq(this double3 f, double v) => f.x == v || f.y == v || f.z == v;
        /// <inheritdoc cref="anyeq(double4,double)"/>
        [MI(IL)] public static bool anyeq(this double2 f, double v) => f.x == v || f.y == v;
        /// <inheritdoc cref="anyeq(double4,double)"/>
        [MI(IL)] public static bool anyeq(this double4 f, double4 v) => f.x == v.x || f.y == v.y || f.z == v.z || f.w == v.w;
        /// <inheritdoc cref="anyeq(double4,double)"/>
        [MI(IL)] public static bool anyeq(this double3 f, double3 v) => f.x == v.x || f.y == v.y || f.z == v.z;
        /// <inheritdoc cref="anyeq(double4,double)"/>
        [MI(IL)] public static bool anyeq(this double2 f, double2 v) => f.x == v.x || f.y == v.y;
        
        
        /// returns true if the any component is not equal to the other value, otherwise false
        [MI(IL)] public static bool anyneq(this double4 f, double v) => f.x != v || f.y != v || f.z != v || f.w != v;
        /// <inheritdoc cref="anyneq(double4,double)"/>
        [MI(IL)] public static bool anyneq(this double3 f, double v) => f.x != v || f.y != v || f.z != v;
        /// <inheritdoc cref="anyneq(double4,double)"/>
        [MI(IL)] public static bool anyneq(this double2 f, double v) => f.x != v || f.y != v;
        /// <inheritdoc cref="anyneq(double4,double)"/>
        [MI(IL)] public static bool anyneq(this double4 f, double4 v) => f.x != v.x || f.y != v.y || f.z != v.z || f.w != v.w;
        /// <inheritdoc cref="anyneq(double4,double)"/>
        [MI(IL)] public static bool anyneq(this double3 f, double3 v) => f.x != v.x || f.y != v.y || f.z != v.z;
        /// <inheritdoc cref="anyneq(double4,double)"/>
        [MI(IL)] public static bool anyneq(this double2 f, double2 v) => f.x != v.x || f.y != v.y;
    }
}