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

        /// <inheritdoc cref="math.cmax(int4)"/>  
        [MethodImpl(IL)] public static byte cmax(this byte4 f) => f.x.max(f.y).max(f.z).max(f.w);
        /// <inheritdoc cref="math.cmax(int3)"/>
        [MethodImpl(IL)] public static byte cmax(this byte3 f) => f.x.max(f.y).max(f.z);
        /// <inheritdoc cref="math.cmax(int2)"/>
        [MethodImpl(IL)] public static byte cmax(this byte2 f) => f.x.max(f.y);

        /// <inheritdoc cref="math.cmin(int4)"/>
        [MethodImpl(IL)] public static byte cmin(this byte4 f) => f.x.min(f.y).min(f.z).min(f.w);
        /// <inheritdoc cref="math.cmin(int3)"/>
        [MethodImpl(IL)] public static byte cmin(this byte3 f) => f.x.min(f.y).min(f.z);
        /// <inheritdoc cref="math.cmin(int2)"/>
        [MethodImpl(IL)] public static byte cmin(this byte2 f) => min(f.x, f.y);
    }
}