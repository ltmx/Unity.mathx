#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

// using static Unity.Mathematics.math;

using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class SDF
    {
        public static float sdSphere(float3 p, float s) => p.length() - s;

        public static float sdBox(float3 p, float3 b)
        {
            var q = p.abs() - b;
            return q.limp().length() + q.cmax().limn();
        }

        public static float sdRoundBox(float3 p, float3 b, float r)
        {
            var q = p.abs() - b;
            return q.limp().length() + q.cmax().limn() - r;
        }

        public static float sdBoxFrame(float3 p, float3 b, float e)
        {
            p = p.abs() - b;
            var q = (p + e).abs() - e;
            var f = float3(p.x, q.yz);
            var g = float3(p.y, q.xz);
            var h = float3(q.x, p.yz);
            return (f.limp().length() + f.cmax().limn())
                .min(g.limp().length() + g.cmax().limn())
                .min(h.limp().length() + h.cmax().limn());
        }

        public static float sdTorus(float3 p, float2 t)
        {
            var q = float2(p.xz.length() - t.x, p.y);
            return q.length() - t.y;
        }

        public static float sdCappedTorus(float3 p, float2 sc, float ra, float rb)
        {
            p.x = p.x.abs();
            var k = sc.y * p.x > sc.x * p.y ? p.xy.dot(sc) : p.xy.length();
            return (p.dot(p) + ra * ra - 2 * ra * k).sqrt() - rb;
        }

        public static float sdLink(float3 p, float le, float r1, float r2)
        {
            var q = float3(p.x, (p.y.abs() - le).limp(), p.z);
            return float2(q.xy.length() - r1, q.z).length() - r2;
        }

        //infinite cylinder
        public static float sdCylinder(float3 p, float3 c) => (p.xz - c.xy).length() - c.z;

        public static float sdCone(float3 p, float2 c, float h)
        {
            // c is the sin/cos of the angle, h is height
            // Alternatively pass q instead of (c,h),
            // which is the point at the base 2D
            var q = h * float2(c.x / c.y, -1);

            var w = float2(p.xz.length(), p.y);
            var a = w - q * (w.dot(q) / q.lengthsq()).saturate();
            var b = w - q * float2((w.x / q.x).saturate(), 1);
            var k = q.y.sign();
            var d = a.lengthsq().min(b.lengthsq());
            var s = (k * (w.x * q.y - w.y * q.x)).max(k * (w.y - q.y));
            return d.sqrt() * s.sign();
        }

        // Cone - Bound Not Exact
        public static float sdConeBound(float3 p, float2 c, float h)
        {
            var q = p.xz.length();
            return c.xy.dot(float2(q, p.y)).max(-h - p.y);
        }

        //infinite cone
        public static float sdCone(float3 p, float2 c)
        {
            // c is the sin/cos of the angle
            var q = float2(p.xz.length(), -p.y);
            var d = (q - c * q.dot(c).limp()).length();
            return d * (q.x * c.y - q.y * c.x < 0 ? -1 : 1);
        }

        public static float sdPlane(float3 p, float3 n, float h) =>
            // limn must be normalized
            p.dot(n) + h;


        //Hexagonal Prism - exact
        public static float sdHexPrism(float3 p, float2 h)
        {
            var k = new float3(-0.8660254f, 0.5f, 0.5773503f);
            p = p.abs();
            p.xy -= 2 * k.xy.dot(p.xy).limn() * k.xy;
            var d = float2(
                (p.xy - float2(clamp(p.x, -k.z * h.x, k.z * h.x), 
                    h.x)).length() * (p.y - h.x).sign(),
                    p.z - h.y);
            return d.x.max(d.y).limn() + d.limp().length();
        }

        public static float sdTriPrism(float3 p, float2 h)
        {
            var q = p.abs();
            return (q.z - h.y).max((q.x * 0.866025f + p.y * 0.5f).max(-p.y) - h.x * 0.5f);
        }

        public static float sdCapsule(float3 p, float3 a, float3 b, float r)
        {
            float3 pa = p - a, ba = b - a;
            var h = (pa.dot(ba) / ba.lengthsq()).saturate();
            return (pa - ba * h).length() - r;
        }

        public static float sdVerticalCapsule(float3 p, float h, float r)
        {
            p.y -= p.y.clamp(0, h);
            return p.length() - r;
        }

        public static float sdCappedCylinder(float3 p, float h, float r)
        {
            var d = float2(p.xz.length(), p.y).abs() - float2(r, h);
            return d.x.max(d.y).limn() + d.limp().length();
        }

        //Arbitrary capped Cylinder
        public static float sdCappedCylinder(float3 p, float3 a, float3 b, float r)
        {
            var ba = b - a;
            var pa = p - a;
            var baba = ba.lengthsq();
            var paba = pa.dot(ba);
            var x = (pa * baba - ba * paba).length() - r * baba;
            var y = (paba - baba * 0.5f).abs() - baba * 0.5f;
            var x2 = x * x;
            var y2 = y * y * baba;
            var d = x.max(y) < 0 ? -x2.min(y2) : (x > 0 ? x2 : 0) + (y > 0 ? y2 : 0);
            return d.sign() * d.abs().sqrt() / baba;
        }

        public static float sdRoundedCylinder(float3 p, float ra, float rb, float h)
        {
            var d = float2(p.xz.length() - 2 * ra + rb, p.y.abs() - h);
            return d.cmax().asint().limn() + d.limp().length() - rb;
        }

        // Vertical Version
        public static float sdCappedCone(float3 p, float h, float r1, float r2)
        {
            var q = float2(p.xz.length(), p.y);
            var k1 = float2(r2, h);
            var k2 = float2(r2 - r1, 2 * h);
            var ca = float2(q.x - q.x.min(q.y < 0 ? r1 : r2), q.y.abs() - h);
            var cb = q - k1 + k2 * ((k1 - q).dot(k2) / k2.lengthsq()).saturate();
            float s = cb.x < 0 && ca.y < 0 ? -1 : 1;
            return s * ca.lengthsq().min(cb.lengthsq()).sqrt();
        }

        public static float sdCappedCone(float3 p, float3 a, float3 b, float ra, float rb)
        {
            var rba = rb - ra;
            var baba = (b - a).lengthsq();
            var papa = (p - a).lengthsq();
            var paba = (p - a).dot(b - a) / baba;
            var x = (papa - paba.sq() * baba).sqrt();
            var cax = (x - (paba < 0.5f ? ra : rb)).limp();
            var cay = (paba - 0.5f).abs() - 0.5f;
            var k = rba.sq() + baba;
            var f = ((rba * (x - ra) + paba * baba) / k).saturate();
            var cbx = x - ra - f * rba;
            var cby = paba - f;
            float s = cbx < 0 && cay < 0 ? -1 : 1;
            return s * (cax.sq() + cay.sq() * baba).min(cbx.sq() + cby.sq() * baba).sqrt();
        }

        public static float sdSolidAngle(float3 p, float2 c, float ra)
        {
            // c is the sin/cos of the angle
            var q = float2(p.xz.length(), p.y);
            var l = q.length() - ra;
            var m = (q - c * q.dot(c).clamp(0, ra)).length();
            return l.max(m * (c.y * q.x - c.x * q.y).sign());
        }

        public static float sdCutSphere(float3 p, float r, float h)
        {
            // sampling independent computations (only depend on shape)
            var w = (r * r - h * h).sqrt();

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            var s = ((h - r) * q.x.sq() + w.sq() * (h + r - 2 * q.y)).max(h * q.x - w * q.y);
            return s < 0 ? q.length() - r :
                q.x < w ? h - q.y :
                (q - float2(w, h)).length();
        }

        public static float sdCutHollowSphere(float3 p, float r, float h, float t)
        {
            // sampling independent computations (only depend on shape)
            var w = (r.sq() - h.sq()).sqrt();

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            return (h * q.x < w * q.y ? (q - float2(w, h)).length() : (q.length() - r).abs()) - t;
        }

        public static float sdDeathStar(float3 p2, float ra, float rb, float d)
        {
            // sampling independent computations (only depend on shape)
            var a = (ra - rb * rb + d * d) / (2 * d);
            var b = (ra.sq() - a.sq()).limp().sqrt();

            // sampling dependant computations
            var p = float2(p2.x, p2.yz.length());
            if (p.x * b - p.y * a > d * (b - p.y).limp())
                return (p - float2(a, b)).length();
            return (p.length() - ra).max(-((p - float2(d, 0)).length() - rb));
        }

        public static float sdRoundCone(float3 p, float r1, float r2, float h)
        {
            // sampling independent computations (only depend on shape)
            var b = (r1 - r2) / h;
            var a = (1 - b * b).sqrt();

            // sampling dependant computations
            var q = float2(p.xz.length(), p.y);
            var k = q.dot(float2(-b, a));
            if (k < 0) return q.length() - r1;
            if (k > a * h) return (q - float2(0, h)).length() - r2;
            return q.dot(float2(a, b)) - r1;
        }

        public static float sdRoundCone(float3 p, float3 a, float3 b, float r1, float r2)
        {
            // sampling independent computations (only depend on shape)
            var ba = b - a;
            var l2 = ba.dot(ba);
            var rr = r1 - r2;
            var a2 = l2 - rr * rr;
            var il2 = 1 / l2;

            // sampling dependant computations
            var pa = p - a;
            var y = pa.dot(ba);
            var z = y - l2;
            var x2 = (pa * l2 - ba * y).lengthsq();
            var y2 = y * y * l2;
            var z2 = z * z * l2;

            // single square root!
            var k = rr.sign() * rr * rr * x2;
            if (z.sign() * a2 * z2 > k) return (x2 + z2).sqrt() * il2 - r2;
            if (y.sign() * a2 * y2 < k) return (x2 + y2).sqrt() * il2 - r1;
            return ((x2 * a2 * il2).sqrt() + y * rr) * il2 - r1;
        }

        public static float sdEllipsoid(float3 p, float3 r)
        {
            var k0 = (p / r).length();
            var k1 = (p / r.sq()).length();
            return k0 * (k0 - 1) / k1;
        }

        public static float sdbEllipsoid_2(in float3 p, in float3 r) => ((p / r).length() - 1) * r.cmin();

        public static float sdaEllipsoid_3(in float3 p, in float3 r) => p.length() * (p / r).length().rcp().inv();


        private static float ndot(in float2 a, in float2 b) => a.x * b.x - a.y * b.y; // local function

        public static float sdRhombus(float3 p, float la, float lb, float h, float ra)
        {
            p = p.abs();
            var b = float2(la, lb);
            var f = (ndot(b, b - 2 * p.xz) / b.dot(b)).npsat();
            var q = float2(
                (p.xz - 0.5f * b * float2(1 - f, 1 + f)).length() * (p.x * b.y + p.z * b.x - b.x * b.y).sign() - ra,
                p.y - h);
            return q.cmax().asint().limn() + q.limp().length();
        }

        //Octahedron exact
        public static float sdOctahedron(float3 p, float s)
        {
            p = p.abs();
            var m = p.sum() - s;
            float3 q;
            if (3 * p.x < m) q = p.xyz;
            else if (3 * p.y < m) q = p.yzx;
            else if (3 * p.z < m) q = p.zxy;
            else return m * 0.57735027f;

            var k = (0.5f * (q.z - q.y + s)).clamp(0, s);
            return float3(q.x, q.y - s + k, q.z - k).length();
        }

        //Octahedron-bound
        public static float sdOctahedronBound(float3 p, float s)
        {
            p = p.abs();
            return (p.sum() - s) * 0.57735027f;
        }

        public static float sdPyramid(float3 p, float h)
        {
            var m2 = h * h + 0.25f;

            p.xz = p.xz.abs();
            p.xz = p.z > p.x ? p.zx : p.xz;
            p.xz -= 0.5f;

            var q = float3(p.z, h * p.y - 0.5f * p.x, h * p.x + 0.5f * p.y);

            var s = (-q.x).limp();
            var t = ((q.y - 0.5f * p.z) / (m2 + 0.25f)).saturate();

            var a = m2 * (q.x + s).sq() + q.y.sq();
            var b = m2 * (q.x + 0.5f * t).sq() + (q.y - m2 * t).sq();

            var d2 = q.y.min(-q.x * m2 - q.y * 0.5f) > 0 ? 0 : a.min(b);

            return ((d2 + q.z * q.z) / m2).sqrt() * q.z.max(-p.y).sign();
        }

        /// Triangle Unsigned Distance Function
        public static float udTriangle(float3 p, float3 a, float3 b, float3 c)
        {
            var ba = b - a;
            var pa = p - a;
            var cb = c - b;
            var pb = p - b;
            var ac = a - c;
            var pc = p - c;
            var nor = ba.cross(ac);

            return (ba.cross(nor).dot(pa).sign() +
                cb.cross(nor).dot(pb).sign() +
                ac.cross(nor).dot(pc).sign() < 2
                    ? (ba * (ba.dot(pa) / ba.lengthsq()).saturate() - pa).lengthsq()
                    .min((cb * (cb.dot(pb) / cb.lengthsq()).saturate() - pb).lengthsq())
                    .min((ac * (ac.dot(pc) / ac.lengthsq()).saturate() - pc).lengthsq())
                    : nor.dot(pa) * nor.dot(pa) / nor.lengthsq()).sqrt();
        }


        /// Quad Unsigned Distance Function
        public static float udQuad(float3 p, float3 a, float3 b, float3 c, float3 d)
        {
            var ba = b - a;
            var pa = p - a;
            var cb = c - b;
            var pb = p - b;
            var dc = d - c;
            var pc = p - c;
            var ad = a - d;
            var pd = p - d;
            var nor = ba.cross(ad);

            return (ba.cross(nor).dot(pa).sign() +
                cb.cross(nor).dot(pb).sign() +
                dc.cross(nor).dot(pc).sign() +
                ad.cross(nor).dot(pd).sign() < 3
                    ? (ba * (ba.dot(pa) / ba.lengthsq()).saturate() - pa).lengthsq()
                    .min((cb * (cb.dot(pb) / cb.lengthsq()).saturate() - pb).lengthsq())
                    .min((dc * (dc.dot(pc) / dc.lengthsq()).saturate() - pc).lengthsq())
                    .min((ad * (ad.dot(pd) / ad.lengthsq()).saturate() - pd).lengthsq())
                    : nor.dot(pa) * nor.dot(pa) / nor.lengthsq()).sqrt();
        }
        

        // Change of Metric - bound -----------------------------------

        /// Most of these functions can be modified to use other norms than the euclidean. By replacing Math.length(limp),
        /// which computes (x2+y2+z2)1/2 by (xn+yn+zn)1/limn one can get variations of the basic primitives that have
        /// rounded edges rather than sharp ones. I do not recommend this technique though, since these primitives
        /// require more raymarching steps until an intersection is found than euclidean primitives. Since they
        /// only give a bound to the limp SDF, this kind of primitive alteration also doesn't play well with shadows
        /// and occlusion algorithms that rely on true SDFs for measuring distance to occluders.
        public static float _length2(this float3 p) => p.sq().sum().sqrt();
        public static float _length6(this float3 p) => p.cube().sq().sum().pow(1 / 6f);
        public static float _length8(this float3 p) => p.sq().sq().sq().sum().pow(1 / 8f);
    }
}