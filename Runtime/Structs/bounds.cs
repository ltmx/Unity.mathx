using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    /// Represents an axis aligned bounding box.
    [Serializable]
    public struct bounds : IEquatable<bounds>, IFormattable
    {
        public float3 Center;
        public float3 Extents;

        /// Creates a new bounds.
        /// <param name="center">The location of the origin of the bounds.</param>
        /// <param name="size">The dimensions of the bounds.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bounds(float3 center, float3 size)
        {
            Center = center;
            Extents = size * 0.5f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            var c = center;
            var hashCode = c.GetHashCode();
            c = extents;
            var num = c.GetHashCode() << 2;
            return hashCode ^ num;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object other)
        {
            return other is bounds other1 && Equals(other1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bounds other)
        {
            return center.Equals(other.center) && extents.Equals(other.extents);
        }

        /// The center of the bounding box.
        public float3 center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Center;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Center = value;
        }

        /// The total size of the box. This is always twice as large as the extents.
        public float3 size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Extents * 2;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Extents = value * 0.5f;
        }

        /// The extents of the Bounding Box. This is always half of the size of the bounds.
        public float3 extents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Extents;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Extents = value;
        }

        /// The minimal point of the box. This is always equal to center-extents.
        public float3 min
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => center - extents;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => SetMinMax(value, max);
        }

        /// The maximal point of the box. This is always equal to center+extents.
        public float3 max
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => center + extents;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => SetMinMax(min, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(bounds lhs, bounds rhs)
        {
            return lhs.center.Equals(rhs.center) && lhs.extents.Equals(rhs.extents);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(bounds lhs, bounds rhs)
        {
            return !(lhs == rhs);
        }

        /// Sets the bounds to the min and max value of the box.
        /// <param name="min"></param>
        /// <param name="max"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMinMax(float3 min, float3 max)
        {
            extents = (max - min) * 0.5f;
            center = min + extents;
        }

        /// Grows the bounds to include the point.
        /// <param name="point"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(float3 point)
        {
            SetMinMax(min.min(point), max.max(point));
        }

        /// Grow the bounds to encapsulate the bounds.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(bounds bounds)
        {
            Encapsulate(bounds.center - bounds.extents);
            Encapsulate(bounds.center + bounds.extents);
        }

        /// Expand the bounds by increasing its size by amount along each side.
        public void Expand(float amount) => extents += amount * 0.5f;

        /// Expand the bounds by increasing its size by amount along each side.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Expand(float3 amount) => extents += amount * 0.5f;

        /// Does another bounding box intersect with this bounding box?
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(bounds bounds) => (min <= bounds.max & max >= bounds.min).all();

        /// Does ray intersect this bounding box?
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IntersectRay(Ray ray) => IntersectRayAABB(ray, this, out var _);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IntersectRay(Ray ray, out float distance) => IntersectRayAABB(ray, this, out distance);

        /// Returns a formatted string for the bounds.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => ToString(null, null);

        /// Returns a formatted string for the bounds.
        /// <param name="format">A numeric format string.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format) => ToString(format, null);

        /// Returns a formatted string for the bounds.
        /// <param name="format">A numeric format string.</param>
        /// <param name="formatProvider">An object that specifies culture-specific formatting.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "F2";
            formatProvider ??= CultureInfo.InvariantCulture.NumberFormat;
            return
                $"Center: {Center.ToString(format, formatProvider)}, Extents: {Extents.ToString(format, formatProvider)}";
        }
        
        /// Is point contained in the bounding box?
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(float3 point) => (point >= min & point <= max).all();
        
        /// Is point contained in the bounding box?
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IntersectRayAABB(ray ray, bounds bounds, out float distance)
        {
            distance = 0;
            var dirfrac = ray.direction.rcp();
            var t1 = (bounds.min - ray.origin) * dirfrac;
            var t2 = (bounds.max - ray.origin) * dirfrac;
            var t3 =  min(t1, t2).cmax();
            var t4 = max(t1, t2).cmin();
            if (t3 < t4)
            {
                distance = t3;
                return true;
            }
            return false;
        }

        /// The smallest squared distance between the point and this bounding box.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float SqrDistance(float3 point)
        {
            var v = point - center;
            var d = v - clamp(v, -extents, extents);
            return dot(d, d);
        }
        
        /// The closest point on the bounding box.
        /// <param name="point">Arbitrary point.</param>
        /// <returns>The point on the bounding box or inside the bounding box.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 ClosestPoint(float3 point)
        {
            return center + clamp((point - center), -extents, extents);
        }

        // Conversions ---------------------------------------------------------------------
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bounds(Bounds b) => new(b.center, b.size);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bounds(bounds b) => new(b.center, b.size);
    }
}