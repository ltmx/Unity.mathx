 // Source : https://iquilezles.org/articles/distfunctions/

// using static Unity.Mathematics.math;
using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static class SDF
    {
        private static float sdSphere(float3 p, float s) => p.length() - s;

        private static float sdBox(float3 p, float3 b)
        {
            var q = p.abs() - b;
            return q.max(0).length() + q.x.max(q.y.max(q.z)).min(0);
        }

        private static float sdRoundBox(float3 p, float3 b, float r)
        {
            var q = p.abs() - b;
            return q.max(0).length() + q.x.max(q.y.max(q.z)).min(0) - r;
        }

        public static float sdBoxFrame(float3 p, float3 b, float e)
        {
            p = p.abs() - b;
            var q = (p + e).abs() - e;
            var f = float3(p.x, q.yz);
            var g = float3(p.y, q.xz);
            var h = float3(q.x, p.yz);
            return (f.over0().length() + f.cmax().under0())
                .min(g.over0().length() + g.cmax().under0())
                .min(h.over0().length() + h.cmax().under0());
        }

        private static float sdTorus(float3 p, float2 t)
        {
            var q = float2(p.xz.length() - t.x, p.y);
            return q.length() - t.y;
        }

        private static float sdCappedTorus(float3 p, float2 sc, float ra, float rb)
        {
            p.x = p.x.abs();
            var k = sc.y * p.x > sc.x * p.y ? dot(p.xy, sc) : p.xy.length();
            return sqrt(dot(p, p) + ra * ra - 2 * ra * k) - rb;
        }

        private static float sdLink(float3 p, float le, float r1, float r2)
        {
            var q = float3(p.x, (p.y.abs() - le).max(0), p.z);
            return float2(q.xy.length() - r1, q.z).length() - r2;
        }

        //infinite cylinder
        private static float sdCylinder(float3 p, float3 c) => (p.xz - c.xy).length() - c.z;

        private static float sdCone(float3 p, float2 c, float h)
        {
            // c is the sin/cos of the angle, h is height
            // Alternatively pass q instead of (c,h),
            // which is the point at the base 2D
            var q = h * float2(c.x / c.y, -1);

            var w = float2(p.xz.length(), p.y);
            var a = w - q * clamp(dot(w, q) / dot(q, q), 0, 1);
            var b = w - q * float2(clamp(w.x / q.x, 0, 1), 1);
            var k = sign(q.y);
            var d = dot(a, a).min(dot(b, b));
            var s = (k * (w.x * q.y - w.y * q.x)).max(k * (w.y - q.y));
            return sqrt(d) * sign(s);
        }

        // Cone - Bound Not Exact
        private static float sdConeBound(float3 p, float2 c, float h)
        {
            var q = p.xz.length();
            return dot(c.xy, float2(q, p.y)).max(-h - p.y);
        }

        //infinite cone
        private static float sdCone(float3 p, float2 c)
        {
            // c is the sin/cos of the angle
            var q = float2(p.xz.length(), -p.y);
            var d = (q - c * dot(q, c).max(0)).length();
            return d * (q.x * c.y - q.y * c.x < 0 ? -1 : 1);
        }

        private static float sdPlane(float3 p, float3 n, float h) =>
            // n must be normalized
            dot(p, n) + h;

        private static float3 k = float3(-0.8660254f, 0.5f, 0.57735f);

        //Hexagonal Prism - exact
        private static float sdHexPrism(float3 p, float2 h)
        {
            p = p.abs();
            p.xy -= 2 * dot(k.xy, p.xy).min(0) * k.xy;
            var d = float2(
                (p.xy - float2(clamp(p.x, -k.z * h.x, k.z * h.x), h.x)).length() * sign(p.y - h.x),
                p.z - h.y);
            return d.x.max(d.y).min(0) + d.max(0).length();
        }

        private static float sdTriPrism(float3 p, float2 h)
        {
            var q = p.abs();
            return (q.z - h.y).max((q.x * 0.866025f + p.y * 0.5f).max(-p.y) - h.x * 0.5f);
        }

        private static float sdCapsule(float3 p, float3 a, float3 b, float r)
        {
            float3 pa = p - a, ba = b - a;
            var h = clamp(dot(pa, ba) / dot(ba, ba), 0, 1);
            return (pa - ba * h).length() - r;
        }

        private static float sdVerticalCapsule(float3 p, float h, float r)
        {
            p.y -= clamp(p.y, 0, h);
            return p.length() - r;
        }

        private static float sdCappedCylinder(float3 p, float h, float r)
        {
            var d = float2(p.xz.length(), p.y).abs() - float2(r, h);
            return d.x.max(d.y).min(0) + d.max(0).length();
        }

        //Arbitrary capped Cylinder
        private static float sdCappedCylinder(float3 p, float3 a, float3 b, float r)
        {
            var ba = b - a;
            var pa = p - a;
            var baba = dot(ba, ba);
            var paba = dot(pa, ba);
            var x = (pa * baba - ba * paba).length() - r * baba;
            var y = (paba - baba * 0.5f).abs() - baba * 0.5f;
            var x2 = x * x;
            var y2 = y * y * baba;
            var d = x.max(y) < 0 ? -x2.min(y2) : (x > 0 ? x2 : 0) + (y > 0 ? y2 : 0);
            return sign(d) * sqrt(d.abs()) / baba;
        }

        private static float sdRoundedCylinder(float3 p, float ra, float rb, float h)
        {
            var d = float2(p.xz.length() - 2 * ra + rb, p.y.abs() - h);
            return ((int)d.x.max(d.y)).min(0) + d.max(0).length() - rb;
        }

        // Vertical Version
        private static float sdCappedCone(float3 p, float h, float r1, float r2)
        {
            var q = float2(p.xz.length(), p.y);
            var k1 = float2(r2, h);
            var k2 = float2(r2 - r1, 2 * h);
            var ca = float2(q.x - q.x.min(q.y < 0 ? r1 : r2), q.y.abs() - h);
            var cb = q - k1 + k2 * clamp(dot(k1 - q, k2) / k2.lengthsq(), 0, 1);
            float s = cb.x < 0 && ca.y < 0 ? -1 : 1;
            return s * sqrt(ca.lengthsq().min(cb.lengthsq()));
        }

        private static float sdCappedCone(float3 p, float3 a, float3 b, float ra, float rb)
        {
            var rba = rb - ra;
            var baba = dot(b - a, b - a);
            var papa = dot(p - a, p - a);
            var paba = dot(p - a, b - a) / baba;
            var x = sqrt(papa - paba * paba * baba);
            var cax = 0.max(x - (paba < 0.5f ? ra : rb));
            var cay = (paba - 0.5f).abs() - 0.5f;
            var k = rba * rba + baba;
            var f = clamp((rba * (x - ra) + paba * baba) / k, 0, 1);
            var cbx = x - ra - f * rba;
            var cby = paba - f;
            float s = cbx < 0 && cay < 0 ? -1 : 1;
            return s * sqrt((cax * cax + cay * cay * baba).min(cbx * cbx + cby * cby * baba));
        }

        private static float sdSolidAngle(float3 p, float2 c, float ra)
        {
            // c is the sin/cos of the angle
            var q = float2(p.xz.length(), p.y);
            var l = q.length() - ra;
            var m = (q - c * clamp(dot(q, c), 0, ra)).length();
            return l.max(m * sign(c.y * q.x - c.x * q.y));
        }

        private static float sdCutSphere(float3 p, float r, float h)
        {
            // sampling independent computations (only depend on shape)
            var w = sqrt(r * r - h * h);

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            var s = ((h - r) * q.x * q.x + w * w * (h + r - 2 * q.y)).max(h * q.x - w * q.y);
            return s < 0 ? q.length() - r :
                q.x < w ? h - q.y :
                (q - float2(w, h)).length();
        }

        private static float sdCutHollowSphere(float3 p, float r, float h, float t)
        {
            // sampling independent computations (only depend on shape)
            var w = sqrt(r * r - h * h);

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            return (h * q.x < w * q.y ? (q - float2(w, h)).length() : (q.length() - r).abs()) - t;
        }

        private static float sdDeathStar(float3 p2, float ra, float rb, float d)
        {
            // sampling independent computations (only depend on shape)
            var a = (ra * ra - rb * rb + d * d) / (2 * d);
            var b = sqrt((ra * ra - a * a).max(0));

            // sampling dependant computations
            var p = float2(p2.x, p2.yz.length());
            if (p.x * b - p.y * a > d * (b - p.y).max(0))
                return (p - float2(a, b)).length();
            return (p.length() - ra).max(-((p - float2(d, 0)).length() - rb));
        }

        private static float sdRoundCone(float3 p, float r1, float r2, float h)
        {
            // sampling independent computations (only depend on shape)
            var b = (r1 - r2) / h;
            var a = sqrt(1 - b * b);

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            var k = dot(q, float2(-b, a));
            if (k < 0) return q.length() - r1;
            if (k > a * h) return (q - float2(0, h)).length() - r2;
            return dot(q, float2(a, b)) - r1;
        }

        private static float sdRoundCone(float3 p, float3 a, float3 b, float r1, float r2)
        {
            // sampling independent computations (only depend on shape)
            var ba = b - a;
            var l2 = dot(ba, ba);
            var rr = r1 - r2;
            var a2 = l2 - rr * rr;
            var il2 = 1 / l2;

            // sampling dependant computations
            var pa = p - a;
            var y = dot(pa, ba);
            var z = y - l2;
            var x2 = (pa * l2 - ba * y).lengthsq();
            var y2 = y * y * l2;
            var z2 = z * z * l2;

            // single square root!
            var k = sign(rr) * rr * rr * x2;
            if (sign(z) * a2 * z2 > k) return sqrt(x2 + z2) * il2 - r2;
            if (sign(y) * a2 * y2 < k) return sqrt(x2 + y2) * il2 - r1;
            return (sqrt(x2 * a2 * il2) + y * rr) * il2 - r1;
        }

        private static float sdEllipsoid(float3 p, float3 r)
        {
            var k0 = (p / r).length();
            var k1 = (p / (r * r)).length();
            return k0 * (k0 - 1) / k1;
        }

        private static float ndot(in float2 a, in float2 b) => a.x * b.x - a.y * b.y;

        private static float sdRhombus(float3 p, float la, float lb, float h, float ra)
        {
            p = p.abs();
            var b = float2(la, lb);
            var f = clamp(ndot(b, b - 2 * p.xz) / dot(b, b), -1, 1);
            var q = float2(
                (p.xz - 0.5f * b * float2(1 - f, 1 + f)).length() * sign(p.x * b.y + p.z * b.x - b.x * b.y) - ra,
                p.y - h);
            return ((int)q.x.max(q.y)).min(0) + q.max(0).length();
        }

        //Octahedron exact
        private static float sdOctahedron(float3 p, float s)
        {
            p = p.abs();
            var m = p.x + p.y + p.z - s;
            float3 q;
            if (3 * p.x < m) q = p.xyz;
            else if (3 * p.y < m) q = p.yzx;
            else if (3 * p.z < m) q = p.zxy;
            else return m * 0.57735027f;

            var k = clamp(0.5f * (q.z - q.y + s), 0, s);
            return float3(q.x, q.y - s + k, q.z - k).length();
        }

        //Octahedron-bound
        private static float sdOctahedronBound(float3 p, float s)
        {
            p = p.abs();
            return (p.x + p.y + p.z - s) * 0.57735027f;
        }

        private static float sdPyramid(float3 p, float h)
        {
            var m2 = h * h + 0.25f;

            p.xz = p.xz.abs();
            p.xz = p.z > p.x ? p.zx : p.xz;
            p.xz -= 0.5f;

            var q = float3(p.z, h * p.y - 0.5f * p.x, h * p.x + 0.5f * p.y);

            var s = (-q.x).max(0);
            var t = clamp((q.y - 0.5f * p.z) / (m2 + 0.25f), 0, 1);

            var a = m2 * (q.x + s) * (q.x + s) + q.y * q.y;
            var b = m2 * (q.x + 0.5f * t) * (q.x + 0.5f * t) + (q.y - m2 * t) * (q.y - m2 * t);

            var d2 = Math.min(q.y, -q.x * m2 - q.y * 0.5) > 0 ? 0 : a.min(b);

            return sqrt((d2 + q.z * q.z) / m2) * sign(q.z.max(-p.y));
        }

        private static float udTriangle(float3 p, float3 a, float3 b, float3 c)
        {
            var ba = b - a;
            var pa = p - a;
            var cb = c - b;
            var pb = p - b;
            var ac = a - c;
            var pc = p - c;
            var nor = cross(ba, ac);

            return sqrt(
                sign(dot(cross(ba, nor), pa)) +
                sign(dot(cross(cb, nor), pb)) +
                sign(dot(cross(ac, nor), pc)) < 2
                    ? (ba * clamp(dot(ba, pa) / ba.lengthsq(), 0, 1) - pa).lengthsq()
                    .min((cb * clamp(dot(cb, pb) / cb.lengthsq(), 0, 1) - pb).lengthsq())
                    .min((ac * clamp(dot(ac, pc) / ac.lengthsq(), 0, 1) - pc).lengthsq())
                    : dot(nor, pa) * dot(nor, pa) / nor.lengthsq());
        }

        private static float udQuad(float3 p, float3 a, float3 b, float3 c, float3 d)
        {
            var ba = b - a;
            var pa = p - a;
            var cb = c - b;
            var pb = p - b;
            var dc = d - c;
            var pc = p - c;
            var ad = a - d;
            var pd = p - d;
            var nor = cross(ba, ad);

            return sqrt(
                sign(dot(cross(ba, nor), pa)) +
                sign(dot(cross(cb, nor), pb)) +
                sign(dot(cross(dc, nor), pc)) +
                sign(dot(cross(ad, nor), pd)) < 3
                    ? (ba * clamp(dot(ba, pa) / ba.lengthsq(), 0, 1) - pa).lengthsq()
                    .min((cb * clamp(dot(cb, pb) / cb.lengthsq(), 0, 1) - pb).lengthsq())
                    .min((dc * clamp(dot(dc, pc) / dc.lengthsq(), 0, 1) - pc).lengthsq())
                    .min((ad * clamp(dot(ad, pd) / ad.lengthsq(), 0, 1) - pd).lengthsq())
                    : dot(nor, pa) * dot(nor, pa) / nor.lengthsq());
        }


        /// Elongating is a useful way to construct new shapes. It basically splits a primitive two (four or eight),
        /// moves the pieces apart and and connects them. It is a perfect distance preserving operation,
        /// it does not introduce any artifacts the SDF. Some of the basic primitives above use this technique.
        /// For example,the Capsule is an elongated Sphere along an axis really.
        private static float opElongate(Func<float3, float> primitive, float3 p, float3 h)
        {
            var q = p - clamp(p, -h, h);
            return primitive(q);
        }

        /// The reason I provide to implementations is the following. For 1D elongations, the first function
        /// works perfectly and gives exact exterior and interior distances. However, the first implementation
        /// produces a small core of zero distances inside the volume for 2D and 3D elongations.
        /// Depending on your application that might be a problem. One way to create exact interior distances
        /// all the way to the very elongated core of the volume, is the following, which is in languages like GLSL
        /// that don't have function pointers or lambdas need to be implemented a bit differently
        private static float opElongateAlternate(Func<float3, float> primitive, float3 p, float3 h)
        {
            var q = p.abs() - h;
            return primitive(q.max(0)) + q.x.max(q.y.max(q.z)).min(0);
        }

        /// Rounding a shape is as simple as subtracting some distance (jumping to a different isosurface).
        /// The rounded box above is an example, but you can apply it to cones, hexagons or any other shape
        /// like the cone the image below. If you happen to be interested preserving the overall volume
        /// of the shape, most of the times it's pretty easy to shrink the source primitive by the same amount
        /// we are rounding it by.
        private static float opRound(float3 p, Func<float3, float> primitive, float rad) => primitive(p) - rad;


        /// For carving interiors or giving thickness to primitives, without perforMath.ming expensive boolean operations
        /// (see below) and without distorting the distance field into a bound, one can use "onioning".
        /// You can use it multiple times to create concentric layers your SDF.
        private static float opOnion(float sdf, float thickness) => sdf.abs() - thickness;

        /// Generating 3D volumes from 2D shapes has many advantages. AssuMath.ming the 2D shape defines exact distances,
        /// the resulting 3D volume is exact and way often less intensive to evaluate than when produced from boolean
        /// operations on other volumes. Two of the most simplest way to make volumes out of flat shapes is to use
        /// extrusion and revolution (generalizations of these are easy to build, but we we'll keep simple here)
        private static float opExtrusion(float3 p, Func<float2, float> primitive, float h)
        {
            var d = primitive(p.xy);
            var w = float2(d, p.z.abs() - h);
            return w.x.max(w.y).min(0) + w.max(0).length();
        }

        private static float opRevolution(float3 p, Func<float2, float> primitive, float o)
        {
            var q = float2(p.xz.length() - o, p.y);
            return primitive(q);
        }

        /// Most of these functions can be modified to use other norms than the euclidean. By replacing Math.length(p),
        /// which computes (x2+y2+z2)1/2 by (xn+yn+zn)1/n one can get variations of the basic primitives that have
        /// rounded edges rather than sharp ones. I do not recommend this technique though, since these primitives
        /// require more raymarching steps until an intersection is found than euclidean primitives. Since they
        /// only give a bound to the real SDF, this kind of primitive alteration also doesn't play well with shadows
        /// and occlusion algorithms that rely on true SDFs for measuring distance to occluders.
        private static float _length2(float3 p) => p.sq().sum().sqrt();

        private static float _length6(float3 p) => p.cube().sq().sum().pow(1 / 6f);
        private static float _length8(float3 p) => p.sq().sq().sq().sum().pow(1 / 8f);


        /// These are the most basic combinations of pairs of primitives you can do. They correspond to the basic
        /// boolean operations. Please note that only the Union of two SDFs returns a true SDF, not the Subtraction
        /// or Intersection. To make it more subtle, this is only true the exterior of the SDF
        /// (where distances are positive) and not the interior. You can learn more about this and how to work around
        /// it the article "Interior Distances". Also note that opSubtraction() is not commutative and depending
        /// on the order of the operand it will produce different results.
        private static float opUnion(float d1, float d2) => d1.min(d2);

        private static float opSubtraction(float d1, float d2) => (-d1).max(d2);
        private static float opIntersection(float d1, float d2) => d1.max(d2);

        /// Blending primitives is a really powerful tool - it allows to construct complex and organic shapes without
        /// the geometrical semas that normal boolean operations produce. There are many flavors of such operations,
        /// but the basic ones try to replace the Math.min() and Math.max() functions used the opUnion, opSubstraction and
        /// opIntersection above with smooth versions. They all accept an extra parameter called k that defines the
        /// size of the smooth transition between the two primitives. It is given actual distance units.
        private static float opSmoothUnion(float d1, float d2, float k)
        {
            var h = saturate(0.5f + 0.5f * (d2 - d1) / k);
            return lerp(d2, d1, h) - k * h * (1 - h);
        }

        private static float opSmoothSubtraction(float d1, float d2, float k)
        {
            var h = saturate(0.5f - 0.5f * (d2 + d1) / k);
            return lerp(d2, -d1, h) + k * h * (1 - h);
        }

        private static float opSmoothIntersection(float d1, float d2, float k)
        {
            var h = saturate(0.5f - 0.5f * (d2 - d1) / k);
            return lerp(d2, d1, h) + k * h * (1 - h);
        }


        // Positioning

        /// Since rotations and translation don't compress nor dilate space, all we need to do is simply to transform
        /// the point being sampled with the inverse of the transformation used to place an object the scene.
        /// This code below assumes that transform encodes only a rotation and a translation
        /// (as a 3x4 matrix for example, or as a quaternion and a vector), and that it does not contain
        /// scaling factors it.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 inversematrix(this RigidTransform m)
        {
            var r = float3x3(m.rot);
            var t = m.pos;
            return float3x4(r, t.rotate(-r));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 matrix(this RigidTransform m)
        {
            var r = float3x3(m.rot);
            return float3x4(r, m.pos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 inverse(this float3x4 m) => float3x4(m.rotation(), m[3].rotate(-m.rotation()));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float3x3 r, float3 t) => math.float3x4(r.c0, r.c1, r.c2, t);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 f3x3(this float3x4 m) => float3x3(m[0], m[1], m[2]);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 rotation(this float3x4 m) => m.f3x3();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 translation(this float3x4 m) => m[3];


        // public static float opTransform( float3x4 transform, float3 p, Func<float3, float> primitive )
        // {
        //     return primitive( math.mul(transform.inverse(), p) );
        // }


        private static float3 opTx(this float3 p, float3x4 t) => p.mul(t.inverse()).xyz;

        /// Scaling an obect is slightly more tricky since that compresses/dilates spaces, so we have to
        /// take that into account on the resulting distance estimation. Still, it's not difficult to perform:
        private static float opScale(float3 p, float s, Func<float3, float> primitive) => primitive(p / s) * s;

        /// Symmetry is useful, since many things around us are symmetric, from humans, animals, vehicles, instruments,
        /// furniture, ... Oftentimes, one can take shortcuts and only model half or a quarter of the desired shape,
        /// and get it duplicated automatically by using the Math.absolute value of the domacoordinates before evaluation.
        /// For example, the image below, there's a single object evaluation instead of two. This is a great savings
        /// performance. You have to be aware however that the resulting SDF might not be an exact SDF but a bound,
        /// if the object you are mirroring crosses the mirroring plane.
        private static float opSymX(float3 p, Func<float3, float> primitive)
        {
            p.x = p.x.abs();
            return primitive(p);
        }

        private static float opSymXZ(float3 p, Func<float3, float> primitive)
        {
            p.xz = p.xz.abs();
            return primitive(p);
        }

        // Infinite Repetition
        /// Domarepetition is a very useful operator, since it allows you to create infinitely many primitives with a single object evaluator and without increasing the memory footprint of your application. The code below shows how to perform the operation the simplest way:
        private static float opRep(float3 p, float3 c, Func<float3, float> primitive)
        {
            var q = (p + 0.5f * c).fastmod3(c) - 0.5f * c;
            return primitive(q);
        }

        // finite repetition
        /// Infinite domarepetition is great, but sometimes you only need a few copies or instances of a given SDF, not infinite. A frequently seen but suboptimal solution is to generate infinite copies and then clip the unwanted areas away with a box SDF. This is not ideal because the resulting SDF is not a real SDF but just a bound, since clipping through Math.max() only produces a bound. A much better approach is to clamp the indices of the instances instead of the SDF, and let a correct SDF emerge from the truncated/clamped indices.
        private static float3 opRepLim(float3 p, float c, float3 l, Func<float3, float> primitive)
        {
            var q = p - c * clamp(round(p / c), -l, l);
            return primitive(q);
        }

        // displacement
        /// The displacement example below is using sin(20*p.x)*sin(20*p.y)*sin(20*p.z) as displacement pattern, but you can of course use anything you might imagine.
        private static float opDisplace(Func<float3, float> primitive, Func<float3, float> displacement, float3 p)
        {
            var d1 = primitive(p);
            var d2 = displacement(p);
            return d1 + d2;
        }

        // Twist
        private static float opTwist(Func<float3, float> primitive, float3 p)
        {
            const float k = 10; // or some other amount
            var c = cos(k * p.y);
            var s = sin(k * p.y);
            var m = float2x2(c, -s, s, c);
            var q = float3(mul(m, p.xz), p.y);
            return primitive(q);
        }

        // bend
        private static float opCheapBend(Func<float3, float> primitive, float3 p)
        {
            const float k = 10; // or some other amount
            var c = cos(k * p.x);
            var s = sin(k * p.x);
            var m = float2x2(c, -s, s, c);
            var q = float3(mul(m, p.xy), p.z);
            return primitive(q);
        }
    }
}