#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        [MethodImpl(INLINE)] public static bool ispow2(this short x) => x != 0 && (x & (x - 1)) == 0;

        [MethodImpl(INLINE)] public static bool ispow2(this ushort x) => x != 0 && (x & (x - 1)) == 0;

        [MethodImpl(INLINE)] public static bool ispow2(this int x) => x != 0 && (x & (x - 1)) == 0;

        [MethodImpl(INLINE)] public static bool ispow2(this uint x) => x != 0 && (x & (x - 1)) == 0;
        
        [MethodImpl(INLINE)] 
        public static bool ispow2(this float x)
        {
            if (x <= 0) return false;

            var bits = BitConverter.SingleToInt32Bits(x);
            var exponent = (bits >> 23) & 0xFF;
            var mantissa = bits & 0x007FFFFF;
            return mantissa == 0 && exponent != 0 && exponent != 0xFF;
        }
    }
}