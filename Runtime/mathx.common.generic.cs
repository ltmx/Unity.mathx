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
        /// sets the value of x to f and returns f
        [MethodImpl(IL)] public static T set<T>(this T f, out T x) {
            x = f;
            return f;
        }
    }
}