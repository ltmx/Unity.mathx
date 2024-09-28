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
        /// sets the value of x to f and returns f
        [MI(IL)] public static T set<T>(this T f, out T x) {
            x = f;
            return f;
        }
    }
}