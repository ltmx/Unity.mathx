#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

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
        [MethodImpl(IL)]
        public bounds(float3 center, float3 size)
        {
            Center = center;
            Extents = size * 0.5f;
        }

        [MethodImpl(IL)]
        public override int GetHashCode()
        {
            var c = center;
            var hashCode = c.GetHashCode();
            c = extents;
            var num = c.GetHashCode() << 2;
            return hashCode ^ num;
        }

        [MethodImpl(IL)]
        public override bool Equals(object other)
        {
            return other is bounds other1 && Equals(other1);
        }

        [MethodImpl(IL)]
        public bool Equals(bounds other)
        {
            return center.Equals(other.center) && extents.Equals(other.extents);
        }

        /// The center of the bounding box.
        public float3 center
        {
            [MethodImpl(IL)]
            get => Center;
            [MethodImpl(IL)]
            set => Center = value;
        }

        /// The total size of the box. This is always twice as large as the extents.
        public float3 size
        {
            [MethodImpl(IL)]
            get => Extents * 2;
            [MethodImpl(IL)]
            set => Extents = value * 0.5f;
        }

        /// The extents of the Bounding Box. This is always half of the size of the bounds.
        public float3 extents
        {
            [MethodImpl(IL)]
            get => Extents;
            [MethodImpl(IL)]
            set => Extents = value;
        }

        /// The minimal point of the box. This is always equal to center-extents.
        public float3 min
        {
            [MethodImpl(IL)]
            get => center - extents;
            [MethodImpl(IL)]
            set => SetMinMax(value, max);
        }

        /// The maximal point of the box. This is always equal to center+extents.
        public float3 max
        {
            [MethodImpl(IL)]
            get => center + extents;
            [MethodImpl(IL)]
            set => SetMinMax(min, value);
        }

        [MethodImpl(IL)]
        public static bool operator ==(bounds lhs, bounds rhs)
        {
            return lhs.center.Equals(rhs.center) && lhs.extents.Equals(rhs.extents);
        }

        [MethodImpl(IL)]
        public static bool operator !=(bounds lhs, bounds rhs)
        {
            return !(lhs == rhs);
        }

        /// Sets the bounds to the min and max value of the box.
        /// <param name="min"></param>
        /// <param name="max"></param>
        [MethodImpl(IL)]
        public void SetMinMax(float3 min, float3 max)
        {
            extents = (max - min) * 0.5f;
            center = min + extents;
        }

        /// Grows the bounds to include the point.
        /// <param name="point"></param>
        [MethodImpl(IL)]
        public void Encapsulate(float3 point)
        {
            SetMinMax(min.min(point), max.max(point));
        }

        /// Grow the bounds to encapsulate the bounds.
        [MethodImpl(IL)]
        public void Encapsulate(bounds bounds)
        {
            Encapsulate(bounds.center - bounds.extents);
            Encapsulate(bounds.center + bounds.extents);
        }

        /// Expand the bounds by increasing its size by amount along each side.
        public void Expand(float amount) => extents += amount * 0.5f;

        /// Expand the bounds by increasing its size by amount along each side.
        [MethodImpl(IL)]
        public void Expand(float3 amount) => extents += amount * 0.5f;

        /// Does another bounding box intersect with this bounding box?
        [MethodImpl(IL)]
        public bool Intersects(bounds bounds) => (min <= bounds.max & max >= bounds.min).all();

        /// Does ray intersect this bounding box?
        [MethodImpl(IL)]
        public bool IntersectRay(Ray ray) => IntersectRayAABB(ray, this, out var _);
        
        [MethodImpl(IL)]
        public bool IntersectRay(Ray ray, out float distance) => IntersectRayAABB(ray, this, out distance);

        /// Returns a formatted string for the bounds.
        [MethodImpl(IL)]
        public override string ToString() => ToString(null, null);

        /// Returns a formatted string for the bounds.
        /// <param name="format">A numeric format string.</param>
        [MethodImpl(IL)]
        public string ToString(string format) => ToString(format, null);

        /// Returns a formatted string for the bounds.
        /// <param name="format">A numeric format string.</param>
        /// <param name="formatProvider">An object that specifies culture-specific formatting.</param>
        [MethodImpl(IL)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "F2";
            formatProvider ??= CultureInfo.InvariantCulture.NumberFormat;
            return
                $"Center: {Center.ToString(format, formatProvider)}, Extents: {Extents.ToString(format, formatProvider)}";
        }
        
        /// Is point contained in the bounding box?
        [MethodImpl(IL)]
        public bool Contains(float3 point) => (point >= min & point <= max).all();
        
        /// Is point contained in the bounding box?
        [MethodImpl(IL)]
        public static bool IntersectRayAABB(ray ray, bounds bounds, out float distance)
        {
            distance = 0;
            var dirfrac = ray.direction.rcp();
            var t1 = (bounds.min - ray.origin) * dirfrac;
            var t2 = (bounds.max - ray.origin) * dirfrac;
            var t3 = min(t1, t2).cmax();
            var t4 = max(t1, t2).cmin();
            if (t3 >= t4) return false;
            distance = t3;
            return true;
        }

        /// The smallest squared distance between the point and this bounding box.
        [MethodImpl(IL)]
        public float SqrDistance(float3 point)
        {
            var v = point - center;
            var d = v - clamp(v, -extents, extents);
            return dot(d, d);
        }
        
        /// The closest point on the bounding box.
        /// <param name="point">Arbitrary point.</param>
        /// <returns>The point on the bounding box or inside the bounding box.</returns>
        [MethodImpl(IL)] public float3 ClosestPoint(float3 point) => center + clamp((point - center), -extents, extents);

        // Conversions ---------------------------------------------------------------------
        [MethodImpl(IL)] public static implicit operator Bounds(bounds b) => new(b.center, b.size);
        [MethodImpl(IL)] public static implicit operator bounds(Bounds b) => new(b.center, b.size);


        /// <summary>
        ///     Finds the world-space positions of a world axis aligned bounding box's eight corners.
        ///     Order:
        ///     <list type="bullet">
        ///         <item> 0: Left-Bottom-Back (-x, -y, -z) </item>
        ///         <item> 1: Left-Bottom-Front (-x, -y, z) </item>
        ///         <item> 2: Left-Top-Back (-x, y, -z) </item>
        ///         <item> 3: Left-Top-Front (-x, y, z) </item>
        ///         <item> 4: Right-Bottom-Back (x, -y, -z) </item>
        ///         <item> 5: Right-Bottom-Front (x, -y, z) </item>
        ///         <item> 6: Right-Top-Back (x, y, -z) </item>
        ///         <item> 7: Right-Top-Front (x, y, z) </item>
        ///     </list>
        /// </summary>
        [MethodImpl(IL)]
        public List<float3> Corners() => new()
        {
            float3(min.x, min.y, min.z),
            float3(min.x, min.y, max.z),
            float3(min.x, max.y, min.z),
            float3(min.x, max.y, max.z),
            float3(max.x, min.y, min.z),
            float3(max.x, min.y, max.z),
            float3(max.x, max.y, min.z),
            float3(max.x, max.y, max.z)
        };

        /// <summary>
        ///     Find world-space position of the center of each face of a world axis aligned bounding box.
        ///     Order:
        ///     <list type="bullet">
        ///         <item> 0: Left		(-x, 0, 0) </item>
        ///         <item> 1: Right		(x, 0, 0) </item>
        ///         <item> 2: Bottom	(0, -y, 0) </item>
        ///         <item> 3: Top		(0, y, 0) </item>
        ///         <item> 4: Back		(0, 0, -z) </item>
        ///         <item> 5: Front		(0, 0, z) </item>
        ///     </list>
        /// </summary>
        [MethodImpl(IL)]
        public List<float3> FaceCenters() => new()
        {
	        center - float3(extents.x, 0, 0),
	        center + float3(extents.x, 0, 0),
            center - float3(0, extents.y, 0),
	        center + float3(0, extents.y, 0),
            center - float3(0, 0, extents.z),
	        center + float3(0, 0, extents.z)
        };

        /// <summary>
        ///     Find world-space positions of the eight corners.
        ///     Order:
        ///     <list type="bullet">
        ///         <item> 0: Left-Bottom-Back (-x, -y, -z) </item>
        ///         <item> 1: Left-Bottom-Front (-x, -y, z) </item>
        ///         <item> 2: Left-Top-Back (-x, y, -z) </item>
        ///         <item> 3: Left-Top-Front (-x, y, z) </item>
        ///         <item> 4: Right-Bottom-Back (x, -y, -z) </item>
        ///         <item> 5: Right-Bottom-Front (x, -y, z) </item>
        ///         <item> 6: Right-Top-Back (x, y, -z) </item>
        ///         <item> 7: Right-Top-Front (x, y, z) </item>
        ///     </list>
        /// </summary>
        /// <param name="localTo">The transform the bounds are local to</param>
        [MethodImpl(IL)]
        public List<float3> Corners(Transform localTo) {
	        var matrix = (float4x4)localTo.localToWorldMatrix;

	        return new List<float3>
	        {
		        matrix.mul(min),
		        matrix.mul(min.xy.append(max.z)),
                matrix.mul(float3(min.x, max.y, min.z)),
		        matrix.mul(float3(min.x, max.yz)),
                matrix.mul(max.x.append(min.yz)),
		        matrix.mul(float3(max.x, min.y, max.z)),
                matrix.mul(max.xy.append(min.z)),
		        matrix.mul(max)
	        };
        }

        /// <summary>
        ///     Find world-space positions of the six face centers.
        ///     Order:
        ///     <list type="bullet">
        ///         <item> 0: Left		(-x, 0, 0) </item>
        ///         <item> 1: Right		(x, 0, 0) </item>
        ///         <item> 2: Bottom	(0, -y, 0) </item>
        ///         <item> 3: Top		(0, y, 0) </item>
        ///         <item> 4: Back		(0, 0, -z) </item>
        ///         <item> 5: Front		(0, 0, z) </item>
        ///     </list>
        /// </summary>
        /// <param name="localTo">The transform the bounds are local to</param>
        [MethodImpl(IL)]
        public List<float3> FaceCenters(Transform localTo) {
	        var matrix = (float4x4)localTo.localToWorldMatrix;
            return new List<float3> {
		        matrix.mul(center - float3(extents.x, 0, 0)),
		        matrix.mul(center + float3(extents.x, 0, 0)),
                matrix.mul(center - float3(0, extents.y, 0)),
		        matrix.mul(center + float3(0, extents.y, 0)),
                matrix.mul(center - float3(0, 0, extents.z)),
		        matrix.mul(center + float3(0, 0, extents.z))
	        };
        }
    }
}