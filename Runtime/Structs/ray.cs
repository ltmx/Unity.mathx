#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.mathx;
using UnityEngine;

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

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
        [MI(IL)]
        public ray(float3 origin, float3 direction)
        {
            m_Origin = origin;
            m_Direction = direction.normsafe();
        }

        /// <para>The origin point of the ray.</para>
        public float3 origin
        {
            [MI(IL)] get => m_Origin;
            [MI(IL)] set => m_Origin = value;
        }

        /// <para>The direction of the ray.</para>
        public float3 direction
        {
            [MI(IL)] get => m_Direction;
            [MI(IL)] set => m_Direction = value.normsafe();
        }

        /// <para>Returns a point at distance units along the ray.</para>
        /// <param name="distance"></param>
        [MI(IL)] public float3 GetPoint(float distance) => m_Origin + m_Direction * distance;

        /// <para>Returns a formatted string for this ray.</para>
        [MI(IL)] public override string ToString() => ToString(null, null);

        /// <para>Returns a formatted string for this ray.</para>
        /// <param name="format">A numeric format string.</param>
        [MI(IL)] public string ToString(string format) => ToString(format, null);

        /// <para>Returns a formatted string for this ray.</para>
        /// <param name="format">A numeric format string.</param>
        /// <param name="formatProvider">An object that specifies culture-specific formatting.</param>
        [MI(IL)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "F2";
            formatProvider ??= CultureInfo.InvariantCulture.NumberFormat;
            return $"Origin: {(object) m_Origin.ToString(format, formatProvider)}, Dir: {(object) m_Direction.ToString(format, formatProvider)}";
        }
        
        [MI(IL)] public static implicit operator ray(Ray r) => new(r.origin, r.direction);
        [MI(IL)] public static implicit operator Ray(ray r) => new(r.origin, r.direction);
    }
}