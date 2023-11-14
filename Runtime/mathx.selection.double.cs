#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        /// <inheritdoc cref="math.cmax(double4)"/>  
        [MethodImpl(IL)] public static double cmax(this double4 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(double4)"/>
        [MethodImpl(IL)] public static double cmax(this double3 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(double4)"/>
        [MethodImpl(IL)] public static double cmax(this double2 f) => math.cmax(f);
        
        /// <inheritdoc cref="math.cmin(double4)"/>
        [MethodImpl(IL)] public static double cmin(this double4 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(double4)"/>
        [MethodImpl(IL)] public static double cmin(this double3 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(double4)"/>
        [MethodImpl(IL)] public static double cmin(this double2 f) => math.cmin(f);
        
        /// returns the greatest absolute value of the components
        [MethodImpl(IL)] public static double acmax(this double4 f) => f.abs().cmax();
        /// <inheritdoc cref="acmax(double4)"/>
        [MethodImpl(IL)] public static double acmax(this double3 f) => f.abs().cmax();
        /// <inheritdoc cref="acmax(double4)"/>
        [MethodImpl(IL)] public static double acmax(this double2 f) => f.abs().cmax();
        
        /// returns the smallest absolute value of the components
        [MethodImpl(IL)] public static double acmin(this double4 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(double4)"/>
        [MethodImpl(IL)] public static double acmin(this double3 f) => f.abs().cmin();
        /// <inheritdoc cref="acmin(double4)"/>
        [MethodImpl(IL)] public static double acmin(this double2 f) => f.abs().cmin();
    }
}