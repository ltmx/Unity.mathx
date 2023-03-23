#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Logic ----------------------------------------------------

        /// returns true if any of the components is true
        [MethodImpl(INLINE)] public static bool any(this bool4 s) => s.x || s.y || s.z || s.w;
        /// returns true in all components are true
        [MethodImpl(INLINE)] public static bool all(this bool4 s) => s is { x: true, y: true, z: true, w: true };
        
        /// <inheritdoc cref="any(bool4)"/>
        [MethodImpl(INLINE)] public static bool any(this bool3 s) => s.x || s.y || s.z;
        /// <inheritdoc cref="all(bool4)"/>
        [MethodImpl(INLINE)] public static bool all(this bool3 s) => s is { x: true, y: true, z: true };

        /// <inheritdoc cref="any(bool4)"/>
        [MethodImpl(INLINE)] public static bool any(this bool2 s) => s.x || s.y;
        /// <inheritdoc cref="all(bool4)"/>
        [MethodImpl(INLINE)] public static bool all(this bool2 s) => s is { x: true, y: true };
        


        // Select ---------------------------------------------------
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static float4 select(this bool4 s, float4 a, float4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static float3 select(this bool3 s, float3 a, float3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static float2 select(this bool2 s, float2 a, float2 b) => math.select(b, a, s);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static double4 select(this bool4 s, double4 a, double4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static double3 select(this bool3 s, double3 a, double3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static double2 select(this bool2 s, double2 a, double2 b) => math.select(b, a, s);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static int4 select(this bool4 s, int4 a, int4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static int3 select(this bool3 s, int3 a, int3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static int2 select(this bool2 s, int2 a, int2 b) => math.select(b, a, s);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static uint4 select(this bool4 s, uint4 a, uint4 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static uint3 select(this bool3 s, uint3 a, uint3 b) => math.select(b, a, s);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static uint2 select(this bool2 s, uint2 a, uint2 b) => math.select(b, a, s);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static half4 select(this bool4 c, half4 a, half4 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static half3 select(this bool3 c, half3 a, half3 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static half2 select(this bool2 c, half2 a, half2 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static byte4 select(this bool4 c, byte4 a, byte4 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static byte3 select(this bool3 c, byte3 a, byte3 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static byte2 select(this bool2 c, byte2 a, byte2 b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y);
        
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static color select(this bool4 c, color a, color b) => new(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
        /// Returns a component-wise selection of a or b using s (selector)
        [MethodImpl(INLINE)] public static quaternion select(this bool4 c, quaternion a, quaternion b) => new(c.x ? b.value.x : a.value.x, c.y ? b.value.y : a.value.y, c.z ? b.value.z : a.value.z, c.w ? b.value.w : a.value.w);

        

        // Approx ---------------------------------------------------
        
        /// Compares two floating point values and returns true if they are similar.
        [MethodImpl(INLINE)] public static bool approx(this float a, float b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        /// Compares two floating point values and returns true if they are similar.
        [MethodImpl(INLINE)] public static bool approx(this double a, double b) => (b - a).abs() < (1E-06f * a.abs().max(b.abs())).max(EPSILON * 8);
        
        // Odd & Even ----------------------------------------------
        

    }
}

