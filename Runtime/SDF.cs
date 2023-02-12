// Source : https://iquilezles.org/articles/distfunctions/

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.Burst;
// using static Unity.Mathematics.math;
using Unity.Mathematics;
using static Unity.Mathematics.math;
using static Unity.Mathematics.Math;
namespace Unity.Mathematics
{
    public static class SDF
    {
        static float sdSphere( float3 p, float s ) => p.Math.length()-s;

        static float sdBox( float3 p, float3 b )
        {
            float3 q = Math.abs(p) - b;
            return Math.length(Math.max(q,0)) + Math.min(Math.max(q.x,Math.max(q.y,q.z)),0);
        }

        static float sdRoundBox( float3 p, float3 b, float r )
        {
            float3 q = Math.abs(p) - b;
            return Math.length(Math.max(q,0)) + Math.min(Math.max(q.x,Math.max(q.y,q.z)),0) - r;
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

        static float sdTorus( float3 p, float2 t )
        {
            float2 q = float2(p.xz.length()-t.x,p.y);
            return q.length()-t.y;
        }

        static float sdCappedTorus(float3 p, float2 sc, float ra, float rb)
        {
            p.x = Math.abs(p.x);
            float k = (sc.y*p.x>sc.x*p.y) ? dot(p.xy,sc) : Math.length(p.xy);
            return sqrt( dot(p,p) + ra*ra - 2*ra*k ) - rb;
        }

        static float sdLink( float3 p, float le, float r1, float r2 )
        {
            float3 q = float3( p.x, Math.max(Math.abs(p.y)-le,0), p.z );
            return Math.length(float2(Math.length(q.xy)-r1,q.z)) - r2;
        }
        
        //infinite cylinder
        static float sdCylinder( float3 p, float3 c ) => Math.length(p.xz-c.xy)-c.z;

        static float sdCone( float3 p, float2 c, float h )
        {
            // c is the sin/cos of the angle, h is height
            // Alternatively pass q instead of (c,h),
            // which is the point at the base 2D
            float2 q = h*float2(c.x/c.y,-1);
    
            float2 w = float2( Math.length(p.xz), p.y );
            float2 a = w - q*clamp( dot(w,q)/dot(q,q), 0, 1);
            float2 b = w - q*float2( clamp( w.x/q.x, 0, 1), 1);
            float k = sign( q.y );
            float d = Math.min(dot( a, a ),dot(b, b));
            float s = Math.max( k*(w.x*q.y-w.y*q.x),k*(w.y-q.y)  );
            return sqrt(d)*sign(s);
        }
        
        // Cone - Bound Not Exact
        static float sdConeBound( float3 p, float2 c, float h )
        {
            float q = Math.length(p.xz);
            return Math.max(dot(c.xy,float2(q,p.y)),-h-p.y);
        }
        
        //infinite cone
        static float sdCone( float3 p, float2 c )
        {
            // c is the sin/cos of the angle
            float2 q = float2( Math.length(p.xz), -p.y );
            float d = Math.length(q-c*Math.max(dot(q,c), 0));
            return d * ((q.x*c.y-q.y*c.x<0)?-1:1);
        }

        static float sdPlane( float3 p, float3 n, float h )
        {
            // n must be normalized
            return dot(p,n) + h;
        }
        
        private static float3 k = float3(-0.8660254f, 0.5f, 0.57735f);
        //Hexagonal Prism - exact
        static float sdHexPrism( float3 p, float2 h )
        {
            p = Math.abs(p);
            p.xy -= 2*Math.min(dot(k.xy, p.xy), 0)*k.xy;
            float2 d = float2(
                Math.length(p.xy-float2(clamp(p.x,-k.z*h.x,k.z*h.x), h.x))*sign(p.y-h.x),
                p.z-h.y );
            return Math.min(Math.max(d.x,d.y),0) + Math.length(Math.max(d,0));
        }

        static float sdTriPrism( float3 p, float2 h )
        {
            float3 q = Math.abs(p);
            return Math.max(q.z-h.y,Math.max(q.x*0.866025f+p.y*0.5f,-p.y)-h.x*0.5f);
        }

        static float sdCapsule( float3 p, float3 a, float3 b, float r )
        {
            float3 pa = p - a, ba = b - a;
            float h = clamp( dot(pa,ba)/dot(ba,ba), 0, 1);
            return Math.length( pa - ba*h ) - r;
        }

        static float sdVerticalCapsule( float3 p, float h, float r )
        {
            p.y -= clamp( p.y, 0, h );
            return Math.length( p ) - r;
        }

        static float sdCappedCylinder( float3 p, float h, float r )
        {
            float2 d = Math.abs(float2(Math.length(p.xz), p.y)) - float2(r, h);
            return Math.min(Math.max(d.x, d.y), 0) + Math.length(Math.max(d, 0));
        }
        
        //Arbitrary capped Cylinder
        static float sdCappedCylinder(float3 p, float3 a, float3 b, float r)
        {
            float3  ba = b - a;
            float3  pa = p - a;
            float baba = dot(ba,ba);
            float paba = dot(pa,ba);
            float x = Math.length(pa*baba-ba*paba) - r*baba;
            float y = Math.abs(paba - baba * 0.5f) - baba * 0.5f;
            float x2 = x*x;
            float y2 = y*y*baba;
            float d = (Math.max(x, y) < 0) ? -Math.min(x2, y2) : (((x > 0) ? x2 : 0) + ((y > 0) ? y2 : 0));
            return sign(d) * sqrt(Math.abs(d)) / baba;
        }

        static float sdRoundedCylinder( float3 p, float ra, float rb, float h)
        {
            var d = float2(Math.length(p.xz) - 2 * ra + rb, Math.abs(p.y) - h);
            return Math.min((int)Math.max(d.x, d.y), 0) + Math.length(Math.max(d, 0)) - rb;
        }
        
        // Vertical Version
        static float sdCappedCone( float3 p, float h, float r1, float r2 )
        {
            float2 q = float2( Math.length(p.xz), p.y );
            float2 k1 = float2(r2,h);
            float2 k2 = float2(r2-r1,2*h);
            float2 ca = float2(q.x-Math.min(q.x,(q.y<0)?r1:r2), Math.abs(q.y)-h);
            float2 cb = q - k1 + k2*clamp( dot(k1-q,k2)/Math.lengthsq(k2), 0, 1);
            float s = (cb.x<0 && ca.y<0) ? -1: 1;
            return s*sqrt( Math.min(Math.lengthsq(ca),Math.lengthsq(cb)) );
        }

        static float sdCappedCone(float3 p, float3 a, float3 b, float ra, float rb)
        {
            float rba  = rb-ra;
            float baba = dot(b-a,b-a);
            float papa = dot(p-a,p-a);
            float paba = dot(p-a,b-a)/baba;
            float x = sqrt( papa - paba*paba*baba );
            float cax = Math.max(0,x-((paba<0.5f)?ra:rb));
            float cay = Math.abs(paba-0.5f)-0.5f;
            float k = rba*rba + baba;
            float f = clamp( (rba*(x-ra)+paba*baba)/k, 0, 1);
            float cbx = x-ra - f*rba;
            float cby = paba - f;
            float s = (cbx<0 && cay<0) ? -1: 1;
            return s*sqrt( Math.min(cax*cax + cay*cay*baba,
                cbx*cbx + cby*cby*baba) );
        }

        static float sdSolidAngle(float3 p, float2 c, float ra)
        {
            // c is the sin/cos of the angle
            float2 q = float2( Math.length(p.xz), p.y );
            float l = Math.length(q) - ra;
            float m = Math.length(q - c*clamp(dot(q,c),0,ra) );
            return Math.max(l,m*sign(c.y*q.x-c.x*q.y));
        }

        static float sdCutSphere( float3 p, float r, float h )
        {
            // sampling independent computations (only depend on shape)
            float w = sqrt(r*r-h*h);

            // sampling dependant computations
            float2 q = float2( Math.length(p.xz), p.y );
            float s = Math.max( (h-r)*q.x*q.x+w*w*(h+r-2*q.y), h*q.x-w*q.y );
            return (s<0) ? Math.length(q)-r :
                (q.x<w) ? h - q.y     :
                Math.length(q-float2(w,h));
        }

        static float sdCutHollowSphere( float3 p, float r, float h, float t )
        {
            // sampling independent computations (only depend on shape)
            float w = sqrt(r*r-h*h);
  
            // sampling dependant computations
            float2 q = float2( Math.length(p.xz), p.y );
            return ((h*q.x<w*q.y) ? Math.length(q-float2(w,h)) : 
                Math.abs(Math.length(q)-r) ) - t;
        }

        static float sdDeathStar( float3 p2, float ra, float rb, float d )
        {
            // sampling independent computations (only depend on shape)
            float a = (ra*ra - rb*rb + d*d)/(2*d);
            float b = sqrt(Math.max(ra*ra-a*a,0));
	
            // sampling dependant computations
            float2 p = float2( p2.x, Math.length(p2.yz) );
            if( p.x*b-p.y*a > d*Math.max(b-p.y,0) )
                return Math.length(p-float2(a,b));
            else
                return Math.max( (Math.length(p          )-ra),
                    -(Math.length(p-float2(d,0))-rb));
        }

        static float sdRoundCone( float3 p, float r1, float r2, float h )
        {
            // sampling independent computations (only depend on shape)
            float b = (r1-r2)/h;
            float a = sqrt(1-b*b);

            // sampling dependant computations
            float2 q = float2( Math.length(p.xz), p.y );
            float k = dot(q,float2(-b,a));
            if( k<0 ) return Math.length(q) - r1;
            if( k>a*h ) return Math.length(q-float2(0,h)) - r2;
            return dot(q, float2(a,b) ) - r1;
        }

        static float sdRoundCone(float3 p, float3 a, float3 b, float r1, float r2)
        {
            // sampling independent computations (only depend on shape)
            float3  ba = b - a;
            float l2 = dot(ba,ba);
            float rr = r1 - r2;
            float a2 = l2 - rr*rr;
            float il2 = 1/l2;
    
            // sampling dependant computations
            float3 pa = p - a;
            float y = dot(pa,ba);
            float z = y - l2;
            float x2 = Math.lengthsq( pa*l2 - ba*y );
            float y2 = y*y*l2;
            float z2 = z*z*l2;

            // single square root!
            float k = sign(rr)*rr*rr*x2;
            if( sign(z)*a2*z2>k ) return  sqrt(x2 + z2)        *il2 - r2;
            if( sign(y)*a2*y2<k ) return  sqrt(x2 + y2)        *il2 - r1;
            return (sqrt(x2*a2*il2)+y*rr)*il2 - r1;
        }

        static float sdEllipsoid( float3 p, float3 r )
        {
            float k0= Math.length(p/r);
            float k1 = Math.length(p/(r*r));
            return k0*(k0-1)/k1;
        }

        private static float ndot(in float2 a, in float2 b) => a.x * b.x - a.y * b.y;

        static float sdRhombus(float3 p, float la, float lb, float h, float ra)
        {
            p = Math.abs(p);
            var b = float2(la, lb);
            var f = clamp(ndot(b, b - 2 * p.xz) / dot(b, b), -1, 1);
            var q = float2(Math.length(p.xz - 0.5f * b * float2(1 - f, 1 + f)) * sign(p.x * b.y + p.z * b.x - b.x * b.y) - ra, p.y - h);
            return Math.min((int)Math.max(q.x, q.y), 0) + Math.length(Math.max(q, 0));
        }
        
        //Octahedron exact
        static float sdOctahedron( float3 p, float s)
        {
            p = Math.abs(p);
            float m = p.x+p.y+p.z-s;
            float3 q;
            if( 3*p.x < m ) q = p.xyz;
            else if( 3*p.y < m ) q = p.yzx;
            else if( 3*p.z < m ) q = p.zxy;
            else return m*0.57735027f;
    
            float k = clamp(0.5f*(q.z-q.y+s),0,s); 
            return Math.length(float3(q.x,q.y-s+k,q.z-k)); 
        }
        
        //Octahedron-bound
        static float sdOctahedronBound( float3 p, float s)
        {
            p = Math.abs(p);
            return (p.x+p.y+p.z-s)*0.57735027f;
        }

        static float sdPyramid(float3 p, float h)
        {
            var m2 = h * h + 0.25f;

            p.xz = Math.abs(p.xz);
            p.xz = p.z > p.x ? p.zx : p.xz;
            p.xz -= 0.5f;

            float3 q = float3(p.z, h * p.y - 0.5f * p.x, h * p.x + 0.5f * p.y);

            float s = Math.max(-q.x, 0);
            float t = clamp((q.y - 0.5f * p.z) / (m2 + 0.25f), 0, 1);

            float a = m2 * (q.x + s) * (q.x + s) + q.y * q.y;
            float b = m2 * (q.x + 0.5f * t) * (q.x + 0.5f * t) + (q.y - m2 * t) * (q.y - m2 * t);

            float d2 = Math.min(q.y, -q.x * m2 - q.y * 0.5) > 0 ? 0 : Math.min(a, b);

            return sqrt((d2 + q.z * q.z) / m2) * sign(Math.Math.max(q.z, -p.y));
        }

        static float udTriangle( float3 p, float3 a, float3 b, float3 c )
        {
            float3 ba = b - a; float3 pa = p - a;
            float3 cb = c - b; float3 pb = p - b;
            float3 ac = a - c; float3 pc = p - c;
            float3 nor = cross( ba, ac );

            return sqrt(
                sign(dot(cross(ba, nor), pa)) +
                sign(dot(cross(cb, nor), pb)) +
                sign(dot(cross(ac, nor), pc)) < 2
                    ? Math.min(Math.min(
                            Math.lengthsq(ba * clamp(dot(ba, pa) / Math.lengthsq(ba), 0, 1) - pa),
                            Math.lengthsq(cb * clamp(dot(cb, pb) / Math.lengthsq(cb), 0, 1) - pb)),
                        Math.lengthsq(ac * clamp(dot(ac, pc) / Math.lengthsq(ac), 0, 1) - pc))
                    : dot(nor, pa) * dot(nor, pa) / Math.lengthsq(nor));
        }

        static float udQuad( float3 p, float3 a, float3 b, float3 c, float3 d )
        {
            float3 ba = b - a; float3 pa = p - a;
            float3 cb = c - b; float3 pb = p - b;
            float3 dc = d - c; float3 pc = p - c;
            float3 ad = a - d; float3 pd = p - d;
            float3 nor = cross( ba, ad );

            return sqrt(
                sign(dot(cross(ba, nor), pa)) +
                sign(dot(cross(cb, nor), pb)) +
                sign(dot(cross(dc, nor), pc)) +
                sign(dot(cross(ad, nor), pd)) < 3
                    ? Math.min(Math.min(Math.min(
                                Math.lengthsq(ba * clamp(dot(ba, pa) / Math.lengthsq(ba), 0, 1) - pa),
                                Math.lengthsq(cb * clamp(dot(cb, pb) / Math.lengthsq(cb), 0, 1) - pb)),
                            Math.lengthsq(dc * clamp(dot(dc, pc) / Math.lengthsq(dc), 0, 1) - pc)),
                        Math.lengthsq(ad * clamp(dot(ad, pd) / Math.lengthsq(ad), 0, 1) - pd))
                    : dot(nor, pa) * dot(nor, pa) / Math.lengthsq(nor));
        }
        

        /// Elongating is a useful way to construct new shapes. It basically splits a primitive two (four or eight),
        /// moves the pieces apart and and connects them. It is a perfect distance preserving operation,
        /// it does not introduce any artifacts the SDF. Some of the basic primitives above use this technique.
        /// For example,the Capsule is an elongated Sphere along an axis really.
        static float opElongate( Func<float3, float> primitive, float3 p, float3 h )
        {
            float3 q = p - clamp( p, -h, h );
            return primitive( q );
        }
        
        /// The reason I provide to implementations is the following. For 1D elongations, the first function
        /// works perfectly and gives exact exterior and interior distances. However, the first implementation
        /// produces a small core of zero distances inside the volume for 2D and 3D elongations.
        /// Depending on your application that might be a problem. One way to create exact interior distances
        /// all the way to the very elongated core of the volume, is the following, which is in languages like GLSL
        /// that don't have function pointers or lambdas need to be implemented a bit differently
        static float opElongateAlternate( Func<float3, float> primitive, float3 p, float3 h )
        {
            float3 q = Math.abs(p)-h;
            return primitive( Math.max(q,0) ) + Math.min(Math.max(q.x,Math.max(q.y,q.z)),0);
        }
        
        ///Rounding a shape is as simple as subtracting some distance (jumping to a different isosurface).
        ///The rounded box above is an example, but you can apply it to cones, hexagons or any other shape
        ///like the cone the image below. If you happen to be interested preserving the overall volume
        ///of the shape, most of the times it's pretty easy to shrink the source primitive by the same amount
        ///we are rounding it by.
        static float opRound(float3 p, Func<float3, float> primitive, float rad )
        {
            return primitive(p) - rad;
        }
        

        /// For carving interiors or giving thickness to primitives, without perforMath.ming expensive boolean operations
        /// (see below) and without distorting the distance field into a bound, one can use "onioning".
        /// You can use it multiple times to create concentric layers your SDF.
        static float opOnion( float sdf, float thickness )
        {
            return Math.abs(sdf)-thickness;
        }
        
        /// Generating 3D volumes from 2D shapes has many advantages. AssuMath.ming the 2D shape defines exact distances,
        /// the resulting 3D volume is exact and way often less intensive to evaluate than when produced from boolean
        /// operations on other volumes. Two of the most simplest way to make volumes out of flat shapes is to use
        /// extrusion and revolution (generalizations of these are easy to build, but we we'll keep simple here)
        /// 
        static float opExtrusion( float3 p, Func<float2, float> primitive, float h )
        {
            float d = primitive(p.xy);
            float2 w = float2( d, Math.abs(p.z) - h );
            return Math.min(Math.max(w.x,w.y),0) + Math.length(Math.max(w,0));
        }

        static float opRevolution( float3 p, Func<float2, float> primitive, float o )
        {
            float2 q = float2( Math.length(p.xz) - o, p.y );
            return primitive(q);
        }
        
        /// Most of these functions can be modified to use other norms than the euclidean. By replacing Math.length(p),
        /// which computes (x2+y2+z2)1/2 by (xn+yn+zn)1/n one can get variations of the basic primitives that have
        /// rounded edges rather than sharp ones. I do not recommend this technique though, since these primitives
        /// require more raymarching steps until an intersection is found than euclidean primitives. Since they
        /// only give a bound to the real SDF, this kind of primitive alteration also doesn't play well with shadows
        /// and occlusion algorithms that rely on true SDFs for measuring distance to occluders.
        private static float _length2(float3 p) => p.sq().sum().sqrt();
        private static float _length6(float3 p) => p.cube().sq().sum().pow(1/6f);
        private static float _length8(float3 p) => p.sq().sq().sq().sum().pow(1/8f);
        

        ///These are the most basic combinations of pairs of primitives you can do. They correspond to the basic
        /// boolean operations. Please note that only the Union of two SDFs returns a true SDF, not the Subtraction
        /// or Intersection. To make it more subtle, this is only true the exterior of the SDF
        /// (where distances are positive) and not the interior. You can learn more about this and how to work around
        /// it the article "Interior Distances". Also note that opSubtraction() is not commutative and depending
        /// on the order of the operand it will produce different results.
        static float opUnion( float d1, float d2 ) => d1.min(d2);

        static float opSubtraction( float d1, float d2 ) => (-d1).max(d2);
        static float opIntersection( float d1, float d2 ) => d1.max(d2);

        ///Blending primitives is a really powerful tool - it allows to construct complex and organic shapes without
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
            float3x3 r = float3x3(m.rot);
            float3 t = m.pos;
            return float3x4( r, t.rotate(-r));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 matrix(this RigidTransform m)
        {
            float3x3 r = float3x3(m.rot);
            return float3x4( r, m.pos );
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 inverse(this float3x4 m) => float3x4( m.rotation(), m[3].rotate(-m.rotation()) );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float3x3 r, float3 t) => math.float3x4( r.c0, r.c1, r.c2, t );

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

        // public static float3 mul(this float3x4 m, float3 p) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];
        // public static float3 mul(this float3 p, float3x4 m) => m[0] * p.x + m[1] * p.y + m[2] * p.z + m[3];


        static float3 opTx(this float3 p, float3x4 t )
        {
            return mul(p, t.inverse()).xyz;
        }
        
        /// Scaling an obect is slightly more tricky since that compresses/dilates spaces, so we have to
        /// take that into account on the resulting distance estimation. Still, it's not difficult to perform:
        static float opScale( float3 p, float s, Func<float3, float> primitive ) => primitive(p/s)*s;

        /// Symmetry is useful, since many things around us are symmetric, from humans, animals, vehicles, instruments,
        /// furniture, ... Oftentimes, one can take shortcuts and only model half or a quarter of the desired shape,
        /// and get it duplicated automatically by using the Math.absolute value of the domacoordinates before evaluation.
        /// For example, the image below, there's a single object evaluation instead of two. This is a great savings
        /// performance. You have to be aware however that the resulting SDF might not be an exact SDF but a bound,
        /// if the object you are mirroring crosses the mirroring plane.
        static float opSymX( float3 p, Func<float3, float> primitive )
        {
            p.x = Math.abs(p.x);
            return primitive(p);
        }

        static float opSymXZ( float3 p, Func<float3, float> primitive )
        {
            p.xz = Math.abs(p.xz);
            return primitive(p);
        }
        
        // Infinite Repetition
        /// Domarepetition is a very useful operator, since it allows you to create infinitely many primitives with a single object evaluator and without increasing the memory footprint of your application. The code below shows how to perform the operation the simplest way:
        static float opRep( float3 p, float3 c, Func<float3, float> primitive )
        {
            float3 q = mod(p+0.5f*c,c)-0.5f*c;
            return primitive( q );
        }
        
        // finite repetition
        /// Infinite domarepetition is great, but sometimes you only need a few copies or instances of a given SDF, not infinite. A frequently seen but suboptimal solution is to generate infinite copies and then clip the unwanted areas away with a box SDF. This is not ideal because the resulting SDF is not a real SDF but just a bound, since clipping through Math.max() only produces a bound. A much better approach is to clamp the indices of the instances instead of the SDF, and let a correct SDF emerge from the truncated/clamped indices.
        static float3 opRepLim( float3 p, float c, float3 l, Func<float3, float> primitive )
        {
            float3 q = p-c*clamp(round(p/c),-l,l);
            return primitive( q );
        }
        
        // displacement
        /// The displacement example below is using sin(20*p.x)*sin(20*p.y)*sin(20*p.z) as displacement pattern, but you can of course use anything you might imagine.
        static float opDisplace( Func<float3, float> primitive, Func<float3, float> displacement , float3 p )
        {
            float d1 = primitive(p);
            float d2 = displacement(p);
            return d1+d2;
        }
        
        // Twist
        static float opTwist( Func<float3, float> primitive, float3 p )
        {
            const float k = 10; // or some other amount
            float c = cos(k*p.y);
            float s = sin(k*p.y);
            float2x2  m = float2x2(c,-s,s,c);
            float3  q = float3(mul(m, p.xz),p.y);
            return primitive(q);
        }
        
        // bend
        static float opCheapBend( Func<float3, float> primitive, float3 p )
        {
            const float k = 10; // or some other amount
            float c = cos(k*p.x);
            float s = sin(k*p.x);
            float2x2  m = float2x2(c,-s,s,c);
            float3  q = float3(mul(m, p.xy),p.z);
            return primitive(q);
        }


    }
}