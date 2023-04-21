#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions

#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// Returns true if a is odd
        [MethodImpl(IL)] public static bool odd(this float a) => ((int)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MethodImpl(IL)] public static bool2 odd(this float2 a) => ((int2)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MethodImpl(IL)] public static bool3 odd(this float3 a) => ((int3)a & 1) != 0;
        /// Returns true if a is odd component-wise
        [MethodImpl(IL)] public static bool4 odd(this float4 a) => ((int4)a & 1) != 0;
        
        /// Returns true if a is even
        [MethodImpl(IL)] public static bool even(this float a) => ((int)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MethodImpl(IL)] public static bool2 even(this float2 a) => ((int2)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MethodImpl(IL)] public static bool3 even(this float3 a) => ((int3)a & 1) != 1;
        /// Returns true if a is even component-wise
        [MethodImpl(IL)] public static bool4 even(this float4 a) => ((int4)a & 1) != 1;
        
        /// <inheritdoc cref="math.isnan(float4)"/>
        [MethodImpl(IL)] public static bool4 isnan(this float4 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(float4)"/>
        [MethodImpl(IL)] public static bool3 isnan(this float3 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(float4)"/>
        [MethodImpl(IL)] public static bool2 isnan(this float2 f) => math.isnan(f);
        /// <inheritdoc cref="math.isnan(float4)"/>
        [MethodImpl(IL)] public static bool isnan(this float f) => math.isnan(f);

        /// returns true if the any component is NAN, otherwise false
        [MethodImpl(IL)] public static bool anynan(this float4 f) => f.x.isnan() || f.y.isnan() || f.z.isnan() || f.w.isnan();
        /// returns true if the any component is NAN, otherwise false
        [MethodImpl(IL)] public static bool anynan(this float3 f) => f.x.isnan() || f.y.isnan() || f.z.isnan();
        /// returns true if the any component is NAN, otherwise false
        [MethodImpl(IL)] public static bool anynan(this float2 f) => f.x.isnan() || f.y.isnan();
        
        /// <inheritdoc cref="math.isinf(float4)"/>
        [MethodImpl(IL)] public static bool4 isinf(this float4 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(float4)"/>
        [MethodImpl(IL)] public static bool3 isinf(this float3 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(float4)"/>
        [MethodImpl(IL)] public static bool2 isinf(this float2 f) => math.isinf(f);
        /// <inheritdoc cref="math.isinf(float4)"/>
        [MethodImpl(IL)] public static bool isinf(this float f) => math.isinf(f);
        
        /// <inheritdoc cref="math.isfinite(float4)"/>
        [MethodImpl(IL)] public static bool4 isfinite(this float4 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(float4)"/>
        [MethodImpl(IL)] public static bool3 isfinite(this float3 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(float4)"/>
        [MethodImpl(IL)] public static bool2 isfinite(this float2 f) => math.isfinite(f);
        /// <inheritdoc cref="math.isfinite(float4)"/>
        [MethodImpl(IL)] public static bool isfinite(this float f) => math.isfinite(f);

        /// returns true component-wise if the any component is greater to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 greater(this float4 f, float value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool3 greater(this float3 f, float value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool2 greater(this float2 f, float value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool greater(this float f, float value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool4 greater(this float4 f, float4 value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool3 greater(this float3 f, float3 value) => (f > value);
        /// <inheritdoc cref="greater(float4,float)"/>
        [MethodImpl(IL)] public static bool2 greater(this float2 f, float2 value) => (f > value);
        
        /// returns true component-wise if the any component is less to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 less(this float4 f, float value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool3 less(this float3 f, float value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool2 less(this float2 f, float value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool less(this float f, float value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool4 less(this float4 f, float4 value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool3 less(this float3 f, float3 value) => (f < value);
        /// <inheritdoc cref="less(float4,float)"/>
        [MethodImpl(IL)] public static bool2 less(this float2 f, float2 value) => (f < value);
        
        /// returns true component-wise if the any component is less or equal to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 lesseq(this float4 f, float value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 lesseq(this float3 f, float value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 lesseq(this float2 f, float value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool lesseq(this float f, float value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool4 lesseq(this float4 f, float4 value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 lesseq(this float3 f, float3 value) => (f <= value);
        /// <inheritdoc cref="lesseq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 lesseq(this float2 f, float2 value) => (f <= value);
        
        /// returns true component-wise if the any component is greater or equal to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 greatereq(this float4 f, float value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 greatereq(this float3 f, float value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 greatereq(this float2 f, float value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool greatereq(this float f, float value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool4 greatereq(this float4 f, float4 value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 greatereq(this float3 f, float3 value) => (f >= value);
        /// <inheritdoc cref="greatereq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 greatereq(this float2 f, float2 value) => (f >= value);
        
        /// returns true component-wise if the any component is equal to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 eq(this float4 f, float value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 eq(this float3 f, float value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 eq(this float2 f, float value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool eq(this float f, float value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool4 eq(this float4 f, float4 value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 eq(this float3 f, float3 value) => f == value;
        /// <inheritdoc cref="eq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 eq(this float2 f, float2 value) => f == value;
        
        /// returns true component-wise if the any component is not equal to the other value, otherwise false
        [MethodImpl(IL)] public static bool4 neq(this float4 f, float value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 neq(this float3 f, float value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 neq(this float2 f, float value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool neq(this float f, float value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool4 neq(this float4 f, float4 value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool3 neq(this float3 f, float3 value) => f != value;
        /// <inheritdoc cref="neq(float4,float)"/>
        [MethodImpl(IL)] public static bool2 neq(this float2 f, float2 value) => f != value;
        
        /// Returns 1 inside the longest(s) axis(es) and 0 in the others
        [MethodImpl(IL)] public static bool4 isgreatest(this float4 f) => f == f.cmax();
        /// <inheritdoc cref="isgreatest(float4)"/>
        [MethodImpl(IL)] public static bool3 isgreatest(this float3 f) => f == f.cmax();
        /// <inheritdoc cref="isgreatest(float4)"/>
        [MethodImpl(IL)] public static bool2 isgreatest(this float2 f) => f == f.cmax();

        /// Returns true inside the shortest axes
        [MethodImpl(IL)] public static bool4 isshortest(this float4 f)  => f == f.cmin();
        /// <inheritdoc cref="isshortest(float4)"/>
        [MethodImpl(IL)] public static bool3 isshortest(this float3 f) => f == f.cmin();
        /// <inheritdoc cref="isshortest(float4)"/>
        [MethodImpl(IL)] public static bool2 isshortest(this float2 f) => f == f.cmin();
    }
}