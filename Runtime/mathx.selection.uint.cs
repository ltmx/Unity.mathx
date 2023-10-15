#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Component-wise comparison --------------------------------------------------------------

        /// <inheritdoc cref="math.cmax(uint4)"/>  
        [MethodImpl(IL)] public static uint cmax(this uint4 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(uint4)"/>
        [MethodImpl(IL)] public static uint cmax(this uint3 f) => math.cmax(f);
        /// <inheritdoc cref="math.cmax(uint4)"/>
        [MethodImpl(IL)] public static uint cmax(this uint2 f) => math.cmax(f);
        
        /// <inheritdoc cref="math.cmin(uint4)"/>
        [MethodImpl(IL)] public static uint cmin(this uint4 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(uint4)"/>
        [MethodImpl(IL)] public static uint cmin(this uint3 f) => math.cmin(f);
        /// <inheritdoc cref="math.cmin(uint4)"/>
        [MethodImpl(IL)] public static uint cmin(this uint2 f) => math.cmin(f);
    }
}