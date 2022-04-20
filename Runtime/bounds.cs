using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    /// <summary>
    ///     <para>Represents an axis aligned bounding box.</para>
    /// </summary>
    [Serializable]
    public struct bounds : IEquatable<bounds>, IFormattable
    {
        public float3 Center;
        public float3 Extents;

        /// <summary>
        ///     <para>Creates a new bounds.</para>
        /// </summary>
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

        /// <summary>
        ///     <para>The center of the bounding box.</para>
        /// </summary>
        public float3 center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Center;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Center = value;
        }

        /// <summary>
        ///     <para>The total size of the box. This is always twice as large as the extents.</para>
        /// </summary>
        public float3 size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Extents * 2;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Extents = value * 0.5f;
        }

        /// <summary>
        ///     <para>The extents of the Bounding Box. This is always half of the size of the bounds.</para>
        /// </summary>
        public float3 extents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Extents;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => Extents = value;
        }

        /// <summary>
        ///     <para>The minimal point of the box. This is always equal to center-extents.</para>
        /// </summary>
        public float3 min
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => center - extents;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => SetMinMax(value, max);
        }

        /// <summary>
        ///     <para>The maximal point of the box. This is always equal to center+extents.</para>
        /// </summary>
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

        /// <summary>
        ///     <para>Sets the bounds to the min and max value of the box.</para>
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMinMax(float3 min, float3 max)
        {
            extents = (max - min) * 0.5f;
            center = min + extents;
        }

        /// <summary>
        ///     <para>Grows the bounds to include the point.</para>
        /// </summary>
        /// <param name="point"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(float3 point)
        {
            SetMinMax(min.min(point), max.max(point));
        }

        /// <summary>
        ///     <para>Grow the bounds to encapsulate the bounds.</para>
        /// </summary>
        /// <param name="bounds"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encapsulate(bounds bounds)
        {
            Encapsulate(bounds.center - bounds.extents);
            Encapsulate(bounds.center + bounds.extents);
        }

        /// <summary>
        ///     <para>Expand the bounds by increasing its size by amount along each side.</para>
        /// </summary>
        /// <param name="amount"></param>
        public void Expand(float amount)
        {
            amount *= 0.5f;
            extents += amount;
        }

        /// <summary>
        ///     <para>Expand the bounds by increasing its size by amount along each side.</para>
        /// </summary>
        /// <param name="amount"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Expand(float3 amount)
        {
            extents += amount * 0.5f;
        }

        /// <summary>
        ///     <para>Does another bounding box intersect with this bounding box?</para>
        /// </summary>
        /// <param name="bounds"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Intersects(bounds bounds)
        {
            var b = min <= bounds.max & max >= bounds.min;
            return b.isAlwaysTrue();
            // return min.x <= (double) bounds.max.x && max.x >= (double) bounds.min.x &&
            //        min.y <= (double) bounds.max.y && max.y >= (double) bounds.min.y &&
            //        min.z <= (double) bounds.max.z && max.z >= (double) bounds.min.z;
        }

        /// <summary>
        ///     <para>Does ray intersect this bounding box?</para>
        /// </summary>
        /// <param name="ray"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IntersectRay(Ray ray)
        {
            return IntersectRayAABB(ray, this, out var _);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IntersectRay(Ray ray, out float distance)
        {
            return IntersectRayAABB(ray, this, out distance);
        }

        /// <summary>
        ///     <para>Returns a formatted string for the bounds.</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return ToString(null, null);
        }

        /// <summary>
        ///     <para>Returns a formatted string for the bounds.</para>
        /// </summary>
        /// <param name="format">A numeric format string.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format)
        {
            return ToString(format, null);
        }

        /// <summary>
        ///     <para>Returns a formatted string for the bounds.</para>
        /// </summary>
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

        /// <summary>
        ///     <para>Is point contained in the bounding box?</para>
        /// </summary>
        /// <param name="point"></param>
        public bool Contains(float3 point) => Contains_Injected(ref this, ref point);

        /// <summary>
        ///     <para>The smallest squared distance between the point and this bounding box.</para>
        /// </summary>
        /// <param name="point"></param>
        public float SqrDistance(float3 point)
        {
            return SqrDistance_Injected(ref this, ref point);
        }

        private static bool IntersectRayAABB(Ray ray, bounds bounds, out float dist)
        {
            return IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
        }

        /// <summary>
        ///     <para>The closest point on the bounding box.</para>
        /// </summary>
        /// <param name="point">Arbitrary point.</param>
        /// <returns>
        ///     <para>The point on the bounding box or inside the bounding box.</para>
        /// </returns>
        public float3 ClosestPoint(float3 point)
        {
            ClosestPoint_Injected(ref this, ref point, out var ret);
            return ret;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern bool Contains_Injected(ref bounds self, ref float3 point);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern float SqrDistance_Injected(ref bounds self, ref float3 point);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern bool IntersectRayAABB_Injected(
            ref Ray ray,
            ref bounds bounds,
            out float dist);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void ClosestPoint_Injected(
            ref bounds self,
            ref float3 point,
            out float3 ret);
    }
}