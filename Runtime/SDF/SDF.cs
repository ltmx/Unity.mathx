// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

// using static Unity.Mathematics.math;

#region

using static Unity.Mathematics.math;

#endregion

namespace Unity.Mathematics
{
	public static partial class mathx
	{
		public static float sdSphere(float3 p, float s) => p.length() - s;

		public static float sdBox(float3 p, float3 b)
		{
			float3 q = p.abs() - b;
			return q.limp().length() + q.cmax().limn();
		}

		public static float sdRoundBox(float3 p, float3 b, float r)
		{
			float3 q = p.abs() - b;
			return q.limp().length() + q.cmax().limn() - r;
		}

		public static float sdBoxFrame(float3 p, float3 b, float e)
		{
			p = p.abs() - b;
			float3 q = (p + e).abs() - e;
			float3 f = float3(p.x, q.yz);
			float3 g = float3(p.y, q.xz);
			float3 h = float3(q.x, p.yz);
			return (f.limp().length() + f.cmax().limn()).min(g.limp().length() + g.cmax().limn()).min(h.limp().length() + h.cmax().limn());
		}

		public static float sdTorus(float3 p, float2 t)
		{
			float2 q = float2(p.xz.length() - t.x, p.y);
			return q.length() - t.y;
		}

		public static float sdCappedTorus(float3 p, float2 sc, float ra, float rb)
		{
			p.x = p.x.abs();
			float k = sc.y * p.x > sc.x * p.y ? p.xy.dot(sc) : p.xy.length();
			return (p.dot(p) + ra * ra - 2 * ra * k).sqrt() - rb;
		}

		public static float sdLink(float3 p, float le, float r1, float r2)
		{
			float3 q = float3(p.x, (p.y.abs() - le).limp(), p.z);
			return float2(q.xy.length() - r1, q.z).length() - r2;
		}

		//infinite cylinder
		public static float sdCylinder(float3 p, float3 c) => (p.xz - c.xy).length() - c.z;

		public static float sdCone(float3 p, float2 c, float h)
		{
			// c is the sin/cos of the angle, h is height
			// Alternatively pass q instead of (c,h),
			// which is the point at the base 2D
			float2 q = h * float2(c.x / c.y, -1);

			float2 w = float2(p.xz.length(), p.y);
			float2 a = w - q * (w.dot(q) / q.lengthsq()).sat();
			float2 b = w - q * float2((w.x / q.x).sat(), 1);
			float k = q.y.sign();
			float d = a.lengthsq().min(b.lengthsq());
			float s = (k * (w.x * q.y - w.y * q.x)).max(k * (w.y - q.y));
			return d.sqrt() * s.sign();
		}

		// Cone - Bound Not Exact
		public static float sdConeBound(float3 p, float2 c, float h)
		{
			float q = p.xz.length();
			return c.xy.dot(float2(q, p.y)).max(-h - p.y);
		}

		//infinite cone
		public static float sdCone(float3 p, float2 c)
		{
			// c is the sin/cos of the angle
			float2 q = float2(p.xz.length(), -p.y);
			float d = (q - c * q.dot(c).limp()).length();
			return d * (q.x * c.y - q.y * c.x < 0 ? -1 : 1);
		}

		public static float sdPlane(float3 p, float3 n, float h) =>
			// limn must be normalized
			p.dot(n) + h;

		//Hexagonal Prism - exact
		public static float sdHexPrism(float3 p, float2 h)
		{
			var k = new float3(-0.8660254f, 0.5f, 0.5773503f);
			p    =  p.abs();
			p.xy -= 2 * k.xy.dot(p.xy).limn() * k.xy;
			float2 d = float2((p.xy - float2(p.x.clamp(-k.z * h.x, k.z * h.x), h.x)).length() * (p.y - h.x).sign(), p.z - h.y);
			return d.x.max(d.y).limn() + d.limp().length();
		}

		public static float sdTriPrism(float3 p, float2 h)
		{
			float3 q = p.abs();
			return (q.z - h.y).max((q.x * 0.866025f + p.y * 0.5f).max(-p.y) - h.x * 0.5f);
		}

		public static float sdCapsule(float3 p, float3 a, float3 b, float r)
		{
			float3 pa = p - a, ba = b - a;
			float h = (pa.dot(ba) / ba.lengthsq()).sat();
			return (pa - ba * h).length() - r;
		}

		public static float sdVerticalCapsule(float3 p, float h, float r)
		{
			p.y -= p.y.clamp(0, h);
			return p.length() - r;
		}

		public static float sdCappedCylinder(float3 p, float h, float r)
		{
			float2 d = float2(p.xz.length(), p.y).abs() - float2(r, h);
			return d.x.max(d.y).limn() + d.limp().length();
		}

		//Arbitrary capped Cylinder
		public static float sdCappedCylinder(float3 p, float3 a, float3 b, float r)
		{
			float3 ba = b - a;
			float3 pa = p - a;
			float baba = ba.lengthsq();
			float paba = pa.dot(ba);
			float x = (pa * baba - ba * paba).length() - r * baba;
			float y = (paba - baba * 0.5f).abs() - baba * 0.5f;
			float x2 = x * x;
			float y2 = y * y * baba;
			float d = x.max(y) < 0 ? -x2.min(y2) : (x > 0 ? x2 : 0) + (y > 0 ? y2 : 0);
			return d.sign() * d.abs().sqrt() / baba;
		}

		public static float sdRoundedCylinder(float3 p, float ra, float rb, float h)
		{
			float2 d = float2(p.xz.length() - 2 * ra + rb, p.y.abs() - h);
			return d.cmax().toint().limn() + d.limp().length() - rb;
		}

		// Vertical Version
		public static float sdCappedCone(float3 p, float h, float r1, float r2)
		{
			float2 q = float2(p.xz.length(), p.y);
			float2 k1 = float2(r2, h);
			float2 k2 = float2(r2 - r1, 2 * h);
			float2 ca = float2(q.x - q.x.min(q.y < 0 ? r1 : r2), q.y.abs() - h);
			float2 cb = q - k1 + k2 * ((k1 - q).dot(k2) / k2.lengthsq()).sat();
			float s = cb.x < 0 && ca.y < 0 ? -1 : 1;
			return s * ca.lengthsq().min(cb.lengthsq()).sqrt();
		}

		public static float sdCappedCone(float3 p, float3 a, float3 b, float ra, float rb)
		{
			float rba = rb - ra;
			float baba = (b - a).lengthsq();
			float papa = (p - a).lengthsq();
			float paba = (p - a).dot(b - a) / baba;
			float x = (papa - paba.sq() * baba).sqrt();
			float cax = (x - (paba < 0.5f ? ra : rb)).limp();
			float cay = (paba - 0.5f).abs() - 0.5f;
			float k = rba.sq() + baba;
			float f = ((rba * (x - ra) + paba * baba) / k).sat();
			float cbx = x - ra - f * rba;
			float cby = paba - f;
			float s = cbx < 0 && cay < 0 ? -1 : 1;
			return s * (cax.sq() + cay.sq() * baba).min(cbx.sq() + cby.sq() * baba).sqrt();
		}

		public static float sdSolidAngle(float3 p, float2 c, float ra)
		{
			// c is the sin/cos of the angle
			float2 q = float2(p.xz.length(), p.y);
			float l = q.length() - ra;
			float m = (q - c * q.dot(c).clamp(0, ra)).length();
			return l.max(m * (c.y * q.x - c.x * q.y).sign());
		}

		public static float sdCutSphere(float3 p, float r, float h)
		{
			// sampling independent computations (only depend on shape)
			float w = (r * r - h * h).sqrt();

			// sampling dependant computations
			float2 q = float2(p.xz.length(), p.y);
			float s = ((h - r) * q.x.sq() + w.sq() * (h + r - 2 * q.y)).max(h * q.x - w * q.y);
			return s < 0 ? q.length() - r : q.x < w ? h - q.y : (q - float2(w, h)).length();
		}

		public static float sdCutHollowSphere(float3 p, float r, float h, float t)
		{
			// sampling independent computations (only depend on shape)
			float w = (r.sq() - h.sq()).sqrt();

			// sampling dependant computations
			float2 q = float2(p.xz.length(), p.y);
			return (h * q.x < w * q.y ? (q - float2(w, h)).length() : (q.length() - r).abs()) - t;
		}

		public static float sdDeathStar(float3 p2, float ra, float rb, float d)
		{
			// sampling independent computations (only depend on shape)
			float a = (ra - rb * rb + d * d) / (2 * d);
			float b = (ra.sq() - a.sq()).limp().sqrt();

			// sampling dependant computations
			float2 p = float2(p2.x, p2.yz.length());
			return p.x * b - p.y * a > d * (b - p.y).limp() ? (p - float2(a, b)).length() : (p.length() - ra).max(-((p - float2(d, 0)).length() - rb));
		}

		public static float sdRoundCone(float3 p, float r1, float r2, float h)
		{
			// sampling independent computations (only depend on shape)
			float b = (r1 - r2) / h;
			float a = (1 - b * b).sqrt();

			// sampling dependant computations
			float2 q = float2(p.xz.length(), p.y);
			float k = q.dot(float2(-b, a));
			if (k < 0) return q.length() - r1;
			if (k > a * h) return (q - float2(0, h)).length() - r2;
			return q.dot(float2(a, b)) - r1;
		}

		public static float sdRoundCone(float3 p, float3 a, float3 b, float r1, float r2)
		{
			// sampling independent computations (only depend on shape)
			float3 ba = b - a;
			float l2 = ba.dot(ba);
			float rr = r1 - r2;
			float a2 = l2 - rr * rr;
			float il2 = 1 / l2;

			// sampling dependant computations
			float3 pa = p - a;
			float y = pa.dot(ba);
			float z = y - l2;
			float x2 = (pa * l2 - ba * y).lengthsq();
			float y2 = y * y * l2;
			float z2 = z * z * l2;

			// single square root!
			float k = rr.sign() * rr * rr * x2;
			if (z.sign() * a2 * z2 > k) return (x2 + z2).sqrt() * il2 - r2;
			if (y.sign() * a2 * y2 < k) return (x2 + y2).sqrt() * il2 - r1;
			return ((x2 * a2 * il2).sqrt() + y * rr) * il2 - r1;
		}

		public static float sdEllipsoid(float3 p, float3 r)
		{
			float k0 = (p / r).length();
			float k1 = (p / r.sq()).length();
			return k0 * (k0 - 1) / k1;
		}

		public static float sdbEllipsoid_2(in float3 p, in float3 r) => ((p / r).length() - 1) * r.cmin();

		public static float sdaEllipsoid_3(in float3 p, in float3 r) => p.length() * (p / r).length().rcp().inv();

		static float ndot(in float2 a, in float2 b) => a.x * b.x - a.y * b.y; // local function

		public static float sdRhombus(float3 p, float la, float lb, float h, float ra)
		{
			p = p.abs();
			float2 b = float2(la, lb);
			float f = (ndot(b, b - 2 * p.xz) / b.dot(b)).satsigned();
			float2 q = float2((p.xz - 0.5f * b * float2(1 - f, 1 + f)).length() * (p.x * b.y + p.z * b.x - b.x * b.y).sign() - ra, p.y - h);
			return q.cmax().toint().limn() + q.limp().length();
		}

		//Octahedron exact
		public static float sdOctahedron(float3 p, float s)
		{
			p = p.abs();
			float m = p.csum() - s;
			float3 q;
			if (3 * p.x < m) q      = p.xyz;
			else if (3 * p.y < m) q = p.yzx;
			else if (3 * p.z < m) q = p.zxy;
			else return m * 0.57735027f;

			float k = (0.5f * (q.z - q.y + s)).clamp(0, s);
			return float3(q.x, q.y - s + k, q.z - k).length();
		}

		//Octahedron-bound
		public static float sdOctahedronBound(float3 p, float s)
		{
			p = p.abs();
			return (p.csum() - s) * 0.57735027f;
		}

		public static float sdPyramid(float3 p, float h)
		{
			float m2 = h * h + 0.25f;

			p.xz =  p.xz.abs();
			p.xz =  p.z > p.x ? p.zx : p.xz;
			p.xz -= 0.5f;

			float3 q = float3(p.z, h * p.y - 0.5f * p.x, h * p.x + 0.5f * p.y);

			float s = (-q.x).limp();
			float t = ((q.y - 0.5f * p.z) / (m2 + 0.25f)).sat();

			float a = m2 * (q.x + s).sq() + q.y.sq();
			float b = m2 * (q.x + 0.5f * t).sq() + (q.y - m2 * t).sq();

			float d2 = q.y.min(-q.x * m2 - q.y * 0.5f) > 0 ? 0 : a.min(b);

			return ((d2 + q.z * q.z) / m2).sqrt() * q.z.max(-p.y).sign();
		}

		/// Triangle Unsigned Distance Function
		public static float udTriangle(float3 p, float3 a, float3 b, float3 c)
		{
			float3 ba = b - a;
			float3 pa = p - a;
			float3 cb = c - b;
			float3 pb = p - b;
			float3 ac = a - c;
			float3 pc = p - c;
			float3 nor = ba.cross(ac);

			return (ba.cross(nor).dot(pa).sign() + cb.cross(nor).dot(pb).sign() + ac.cross(nor).dot(pc).sign() < 2
				? (ba * (ba.dot(pa) / ba.lengthsq()).sat() - pa).lengthsq().min((cb * (cb.dot(pb) / cb.lengthsq()).sat() - pb).lengthsq()).min((ac * (ac.dot(pc) / ac.lengthsq()).sat() - pc).lengthsq())
				: nor.dot(pa) * nor.dot(pa) / nor.lengthsq()).sqrt();
		}

		/// Quad Unsigned Distance Function
		public static float udQuad(float3 p, float3 a, float3 b, float3 c, float3 d)
		{
			float3 ba = b - a;
			float3 pa = p - a;
			float3 cb = c - b;
			float3 pb = p - b;
			float3 dc = d - c;
			float3 pc = p - c;
			float3 ad = a - d;
			float3 pd = p - d;
			float3 nor = ba.cross(ad);

			return (ba.cross(nor).dot(pa).sign() + cb.cross(nor).dot(pb).sign() + dc.cross(nor).dot(pc).sign() + ad.cross(nor).dot(pd).sign() < 3
				? (ba * (ba.dot(pa) / ba.lengthsq()).sat() - pa).lengthsq()
				.min((cb * (cb.dot(pb) / cb.lengthsq()).sat() - pb).lengthsq())
				.min((dc * (dc.dot(pc) / dc.lengthsq()).sat() - pc).lengthsq())
				.min((ad * (ad.dot(pd) / ad.lengthsq()).sat() - pd).lengthsq())
				: nor.dot(pa) * nor.dot(pa) / nor.lengthsq()).sqrt();
		}

		// Change of Metric - bound -----------------------------------

		/// Most of these functions can be modified to use other norms than the euclidean. By replacing Math.length(limp),
		/// which computes (x2+y2+z2)1/2 by (xn+yn+zn)1/limn one can get variations of the basic primitives that have
		/// rounded edges rather than sharp ones. I do not recommend this technique though, since these primitives
		/// require more raymarching steps until an intersection is found than euclidean primitives. Since they
		/// only give a bound to the limp SDF, this kind of primitive alteration also doesn't play well with shadows
		/// and occlusion algorithms that rely on true SDFs for measuring distance to occluders.
		public static float _length2(this float3 p) => p.sq().csum().sqrt();
		public static float _length6(this float3 p) => p.cube().sq().csum().pow(1 / 6f);
		public static float _length8(this float3 p) => p.sq().sq().sq().csum().pow(1 / 8f);
	}
}