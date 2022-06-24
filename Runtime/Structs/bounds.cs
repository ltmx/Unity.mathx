using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace Unity.Mathematics
{
    // TODO Implement original extern methods in this class
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
        /// <param name="bounds"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(bounds bounds)
        {
            Encapsulate(bounds.center - bounds.extents);
            Encapsulate(bounds.center + bounds.extents);
        }

        /// Expand the bounds by increasing its size by amount along each side.
        /// <param name="amount"></param>
        public void Expand(float amount) => extents += amount * 0.5f;

        /// Expand the bounds by increasing its size by amount along each side.
        /// <param name="amount"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Expand(float3 amount) => extents += amount * 0.5f;

        /// Does another bounding box intersect with this bounding box?
        /// <param name="bounds"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(bounds bounds) => (min <= bounds.max & max >= bounds.min).all();

        // /// Does ray intersect this bounding box?
        // /// <param name="ray"></param>
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // public bool IntersectRay(Ray ray) => IntersectRayAABB(ray, this, out var _);
        //
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // public bool IntersectRay(Ray ray, out float distance) => IntersectRayAABB(ray, this, out distance);

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


        // /// Is point contained in the bounding box?
        // /// <param name="point"></param>
        // public bool Contains(float3 point) => Contains_Injected(ref this, ref point);
        //
        // /// The smallest squared distance between the point and this bounding box.
        // /// <param name="point"></param>
        // public float SqrDistance(float3 point) => SqrDistance_Injected(ref this, ref point);
        //
        // private static bool IntersectRayAABB(Ray ray, bounds bounds, out float dist)
        // {
        //     return IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
        // }
        //
        // /// The closest point on the bounding box.
        // /// <param name="point">Arbitrary point.</param>
        // /// <returns>
        // /// The point on the bounding box or inside the bounding box.
        // /// </returns>
        // public float3 ClosestPoint(float3 point)
        // {
        //     ClosestPoint_Injected(ref this, ref point, out var ret);
        //     return ret;
        // }

        // [MethodImpl(MethodImplOptions.InternalCall)]
        // private static extern bool Contains_Injected(ref bounds self, ref float3 point);
        //
        // [MethodImpl(MethodImplOptions.InternalCall)]
        // private static extern float SqrDistance_Injected(ref bounds self, ref float3 point);
        //
        // [MethodImpl(MethodImplOptions.InternalCall)]
        // private static extern bool IntersectRayAABB_Injected(
        //     ref Ray ray,
        //     ref bounds bounds,
        //     out float dist
        // );
        //
        // [MethodImpl(MethodImplOptions.InternalCall)]
        // private static extern void ClosestPoint_Injected(
        //     ref bounds self,
        //     ref float3 point,
        //     out float3 ret
        // );
        
        public static implicit operator bounds(Bounds b) => new(b.center, b.size);
        public static implicit operator Bounds(bounds b) => new(b.center, b.size);
    }
}