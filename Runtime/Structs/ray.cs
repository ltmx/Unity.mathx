#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    ///     <para>Representation of rays.</para>
    public struct ray : IFormattable
    {
        private float3 m_Origin;
        private float3 m_Direction;

        /// <para>Creates a ray starting at origin along direction.</para>
        /// <param name="origin"></param>
        /// <param name="direction"></param>
        [MethodImpl(256)] // MethodImplOptions.AggressiveInlining
        public ray(float3 origin, float3 direction)
        {
            m_Origin = origin;
            m_Direction = direction.normsafe();
        }

        /// <para>The origin point of the ray.</para>
        public float3 origin
        {
            [MethodImpl(256)] get => m_Origin;
            [MethodImpl(256)] set => m_Origin = value;
        }

        /// <para>The direction of the ray.</para>
        public float3 direction
        {
            [MethodImpl(256)] get => m_Direction;
            [MethodImpl(256)] set => m_Direction = value.normsafe();
        }

        /// <para>Returns a point at distance units along the ray.</para>
        /// <param name="distance"></param>
        [MethodImpl(256)]
        public float3 GetPoint(float distance) => m_Origin + m_Direction * distance;

        /// <para>Returns a formatted string for this ray.</para>
        [MethodImpl(256)]
        public override string ToString() => ToString(null, null);

        /// <para>Returns a formatted string for this ray.</para>
        /// <param name="format">A numeric format string.</param>
        [MethodImpl(256)]
        public string ToString(string format) => ToString(format, null);

        /// <para>Returns a formatted string for this ray.</para>
        /// <param name="format">A numeric format string.</param>
        /// <param name="formatProvider">An object that specifies culture-specific formatting.</param>
        [MethodImpl(256)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "F2";
            formatProvider ??= CultureInfo.InvariantCulture.NumberFormat;
            return $"Origin: {(object) m_Origin.ToString(format, formatProvider)}, Dir: {(object) m_Direction.ToString(format, formatProvider)}";
        }
        
        public static implicit operator ray(Ray r) => new(r.origin, r.direction);
        public static implicit operator Ray(ray r) => new(r.origin, r.direction);
    }
}