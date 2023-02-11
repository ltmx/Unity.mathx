// // Source : https://iquilezles.org/articles/distfunctions/
//
// using static Unity.Mathematics.math;
// using static Unity.Mathematics.Math;
// namespace Unity.Mathematics
// {
//     public static class SDF
//     {
//         static float sdSphere( float3 p, float s )
//         {
//             return length(p)-s;
//         }
//
//         static float sdBox( float3 p, float3 b )
//         {
//             float3 q = abs(p) - b;
//             return length(max(q,0)) + min(max(q.x,max(q.y,q.z)),0);
//         }
//
//         static float sdRoundBox( float3 p, float3 b, float r )
//         {
//             float3 q = abs(p) - b;
//             return length(max(q,0)) + min(max(q.x,max(q.y,q.z)),0) - r;
//         }
//
//         static float sdBoxFrame( float3 p, float3 b, float e )
//         {
//             p = abs(p  )-b;
//             float3 q = abs(p+e)-e;
//             return min(min(
//                     length(max(float3(p.x,q.y,q.z),0))+min(max(p.x,max(q.y,q.z)),0),
//                     length(max(float3(q.x,p.y,q.z),0))+min(max(q.x,max(p.y,q.z)),0)),
//                 length(max(float3(q.x,q.y,p.z),0))+min(max(q.x,max(q.y,p.z)),0));
//         }
//
//         static float sdTorus( float3 p, float2 t )
//         {
//             float2 q = float2(length(p.xz)-t.x,p.y);
//             return length(q)-t.y;
//         }
//
//         static float sdCappedTorus(in float3 p, in float2 sc, in float ra, in float rb)
//         {
//             p.x = abs(p.x);
//             float k = (sc.y*p.x>sc.x*p.y) ? dot(p.xy,sc) : length(p.xy);
//             return sqrt( dot(p,p) + ra*ra - 2*ra*k ) - rb;
//         }
//
//         static float sdLink( float3 p, float le, float r1, float r2 )
//         {
//             float3 q = float3( p.x, max(abs(p.y)-le,0), p.z );
//             return length(float2(length(q.xy)-r1,q.z)) - r2;
//         }
//         
//         //infinite cylinder
//         static float sdCylinder( float3 p, float3 c )
//         {
//             return length(p.xz-c.xy)-c.z;
//         }
//
//         static float sdCone( in float3 p, in float2 c, float h )
//         {
//             // c is the sin/cos of the angle, h is height
//             // Alternatively pass q instead of (c,h),
//             // which is the point at the base in 2D
//             float2 q = h*float2(c.x/c.y,-1);
//     
//             float2 w = float2( length(p.xz), p.y );
//             float2 a = w - q*clamp( dot(w,q)/dot(q,q), 0, 1);
//             float2 b = w - q*float2( clamp( w.x/q.x, 0, 1), 1);
//             float k = sign( q.y );
//             float d = min(dot( a, a ),dot(b, b));
//             float s = max( k*(w.x*q.y-w.y*q.x),k*(w.y-q.y)  );
//             return sqrt(d)*sign(s);
//         }
//         
//         // Cone - Bound Not Exact
//         static float sdConeBound( float3 p, float2 c, float h )
//         {
//             float q = length(p.xz);
//             return max(dot(c.xy,float2(q,p.y)),-h-p.y);
//         }
//         
//         //infinite cone
//         static float sdCone( float3 p, float2 c )
//         {
//             // c is the sin/cos of the angle
//             float2 q = float2( length(p.xz), -p.y );
//             float d = length(q-c*max(dot(q,c), 0));
//             return d * ((q.x*c.y-q.y*c.x<0)?-1:1);
//         }
//
//         static float sdPlane( float3 p, float3 n, float h )
//         {
//             // n must be normalized
//             return dot(p,n) + h;
//         }
//         
//         //Hexagonal Prism - exact
//         static float sdHexPrism( float3 p, float2 h )
//         {
//             const float3 k = float3(-0.8660254, 0.5, 0.57735);
//             p = abs(p);
//             p.xy -= 2*min(dot(k.xy, p.xy), 0)*k.xy;
//             float2 d = float2(
//                 length(p.xy-float2(clamp(p.x,-k.z*h.x,k.z*h.x), h.x))*sign(p.y-h.x),
//                 p.z-h.y );
//             return min(max(d.x,d.y),0) + length(max(d,0));
//         }
//
//         static float sdTriPrism( float3 p, float2 h )
//         {
//             float3 q = abs(p);
//             return max(q.z-h.y,max(q.x*0.866025f+p.y*0.5f,-p.y)-h.x*0.5f);
//         }
//
//         static float sdCapsule( float3 p, float3 a, float3 b, float r )
//         {
//             float3 pa = p - a, ba = b - a;
//             float h = clamp( dot(pa,ba)/dot(ba,ba), 0, 1);
//             return length( pa - ba*h ) - r;
//         }
//
//         static float sdVerticalCapsule( float3 p, float h, float r )
//         {
//             p.y -= clamp( p.y, 0, h );
//             return length( p ) - r;
//         }
//
//         static float sdCappedCylinder( float3 p, float h, float r )
//         {
//             float2 d = abs(float2(length(p.xz),p.y)) - float2(r,h);
//             return min(max(d.x,d.y),0) + length(max(d,0));
//         }
//         
//         //Arbitrary capped Cylinder
//         static float sdCappedCylinder(float3 p, float3 a, float3 b, float r)
//         {
//             float3  ba = b - a;
//             float3  pa = p - a;
//             float baba = dot(ba,ba);
//             float paba = dot(pa,ba);
//             float x = length(pa*baba-ba*paba) - r*baba;
//             float y = abs(paba-baba*0.5)-baba*0.5;
//             float x2 = x*x;
//             float y2 = y*y*baba;
//             float d = (max(x,y)<0)?-min(x2,y2):(((x>0)?x2:0)+((y>0)?y2:0));
//             return sign(d)*sqrt(abs(d))/baba;
//         }
//
//         static float sdRoundedCylinder( float3 p, float ra, float rb, float h )
//         {
//             float2 d = float2( length(p.xz)-2*ra+rb, abs(p.y) - h );
//             return min(max(d.x,d.y),0) + length(max(d,0)) - rb;
//         }
//         
//         // Vertical Version
//         static float sdCappedCone( float3 p, float h, float r1, float r2 )
//         {
//             float2 q = float2( length(p.xz), p.y );
//             float2 k1 = float2(r2,h);
//             float2 k2 = float2(r2-r1,2*h);
//             float2 ca = float2(q.x-min(q.x,(q.y<0)?r1:r2), abs(q.y)-h);
//             float2 cb = q - k1 + k2*clamp( dot(k1-q,k2)/lengthsq(k2), 0, 1);
//             float s = (cb.x<0 && ca.y<0) ? -1: 1;
//             return s*sqrt( min(lengthsq(ca),lengthsq(cb)) );
//         }
//
//         static float sdCappedCone(float3 p, float3 a, float3 b, float ra, float rb)
//         {
//             float rba  = rb-ra;
//             float baba = dot(b-a,b-a);
//             float papa = dot(p-a,p-a);
//             float paba = dot(p-a,b-a)/baba;
//             float x = sqrt( papa - paba*paba*baba );
//             float cax = max(0,x-((paba<0.5)?ra:rb));
//             float cay = abs(paba-0.5)-0.5;
//             float k = rba*rba + baba;
//             float f = clamp( (rba*(x-ra)+paba*baba)/k, 0, 1);
//             float cbx = x-ra - f*rba;
//             float cby = paba - f;
//             float s = (cbx<0 && cay<0) ? -1: 1;
//             return s*sqrt( min(cax*cax + cay*cay*baba,
//                 cbx*cbx + cby*cby*baba) );
//         }
//
//         static float sdSolidAngle(float3 p, float2 c, float ra)
//         {
//             // c is the sin/cos of the angle
//             float2 q = float2( length(p.xz), p.y );
//             float l = length(q) - ra;
//             float m = length(q - c*clamp(dot(q,c),0,ra) );
//             return max(l,m*sign(c.y*q.x-c.x*q.y));
//         }
//
//         static float sdCutSphere( float3 p, float r, float h )
//         {
//             // sampling independent computations (only depend on shape)
//             float w = sqrt(r*r-h*h);
//
//             // sampling dependant computations
//             float2 q = float2( length(p.xz), p.y );
//             float s = max( (h-r)*q.x*q.x+w*w*(h+r-2*q.y), h*q.x-w*q.y );
//             return (s<0) ? length(q)-r :
//                 (q.x<w) ? h - q.y     :
//                 length(q-float2(w,h));
//         }
//
//         static float sdCutHollowSphere( float3 p, float r, float h, float t )
//         {
//             // sampling independent computations (only depend on shape)
//             float w = sqrt(r*r-h*h);
//   
//             // sampling dependant computations
//             float2 q = float2( length(p.xz), p.y );
//             return ((h*q.x<w*q.y) ? length(q-float2(w,h)) : 
//                 abs(length(q)-r) ) - t;
//         }
//
//         static float sdDeathStar( in float3 p2, in float ra, float rb, in float d )
//         {
//             // sampling independent computations (only depend on shape)
//             float a = (ra*ra - rb*rb + d*d)/(2*d);
//             float b = sqrt(max(ra*ra-a*a,0));
// 	
//             // sampling dependant computations
//             float2 p = float2( p2.x, length(p2.yz) );
//             if( p.x*b-p.y*a > d*max(b-p.y,0) )
//                 return length(p-float2(a,b));
//             else
//                 return max( (length(p          )-ra),
//                     -(length(p-float2(d,0))-rb));
//         }
//
//         static float sdRoundCone( float3 p, float r1, float r2, float h )
//         {
//             // sampling independent computations (only depend on shape)
//             float b = (r1-r2)/h;
//             float a = sqrt(1-b*b);
//
//             // sampling dependant computations
//             float2 q = float2( length(p.xz), p.y );
//             float k = dot(q,float2(-b,a));
//             if( k<0 ) return length(q) - r1;
//             if( k>a*h ) return length(q-float2(0,h)) - r2;
//             return dot(q, float2(a,b) ) - r1;
//         }
//
//         static float sdRoundCone(float3 p, float3 a, float3 b, float r1, float r2)
//         {
//             // sampling independent computations (only depend on shape)
//             float3  ba = b - a;
//             float l2 = dot(ba,ba);
//             float rr = r1 - r2;
//             float a2 = l2 - rr*rr;
//             float il2 = 1/l2;
//     
//             // sampling dependant computations
//             float3 pa = p - a;
//             float y = dot(pa,ba);
//             float z = y - l2;
//             float x2 = lengthsq( pa*l2 - ba*y );
//             float y2 = y*y*l2;
//             float z2 = z*z*l2;
//
//             // single square root!
//             float k = sign(rr)*rr*rr*x2;
//             if( sign(z)*a2*z2>k ) return  sqrt(x2 + z2)        *il2 - r2;
//             if( sign(y)*a2*y2<k ) return  sqrt(x2 + y2)        *il2 - r1;
//             return (sqrt(x2*a2*il2)+y*rr)*il2 - r1;
//         }
//
//         static float sdEllipsoid( float3 p, float3 r )
//         {
//             float k0= length(p/r);
//             float k1 = length(p/(r*r));
//             return k0*(k0-1)/k1;
//         }
//
//         static float sdRhombus(float3 p, float la, float lb, float h, float ra)
//         {
//             p = abs(p);
//             float2 b = float2(la,lb);
//             float f = clamp( (ndot(b,b-2*p.xz))/dot(b,b), -1, 1);
//             float2 q = float2(length(p.xz-0.5*b*float2(1-f,1+f))*sign(p.x*b.y+p.z*b.x-b.x*b.y)-ra, p.y-h);
//             return min(max(q.x,q.y),0) + length(max(q,0));
//         }
//         
//         //Octahedron exact
//         static float sdOctahedron( float3 p, float s)
//         {
//             p = abs(p);
//             float m = p.x+p.y+p.z-s;
//             float3 q;
//             if( 3.0*p.x < m ) q = p.xyz;
//             else if( 3.0*p.y < m ) q = p.yzx;
//             else if( 3.0*p.z < m ) q = p.zxy;
//             else return m*0.57735027;
//     
//             float k = clamp(0.5*(q.z-q.y+s),0,s); 
//             return length(float3(q.x,q.y-s+k,q.z-k)); 
//         }
//         
//         //Octahedron-bound
//         static float sdOctahedron( float3 p, float s)
//         {
//             p = abs(p);
//             return (p.x+p.y+p.z-s)*0.57735027;
//         }
//
//         static float sdPyramid( float3 p, float h)
//         {
//             float m2 = h*h + 0.25;
//     
//             p.xz = abs(p.xz);
//             p.xz = (p.z>p.x) ? p.zx : p.xz;
//             p.xz -= 0.5;
//
//             float3 q = float3( p.z, h*p.y - 0.5*p.x, h*p.x + 0.5*p.y);
//    
//             float s = max(-q.x,0);
//             float t = clamp( (q.y-0.5*p.z)/(m2+0.25), 0, 1);
//     
//             float a = m2*(q.x+s)*(q.x+s) + q.y*q.y;
//             float b = m2*(q.x+0.5*t)*(q.x+0.5*t) + (q.y-m2*t)*(q.y-m2*t);
//     
//             float d2 = min(q.y,-q.x*m2-q.y*0.5) > 0 ? 0 : min(a,b);
//     
//             return sqrt( (d2+q.z*q.z)/m2 ) * sign(max(q.z,-p.y));
//         }
//
//         static float udTriangle( float3 p, float3 a, float3 b, float3 c )
//         {
//             float3 ba = b - a; float3 pa = p - a;
//             float3 cb = c - b; float3 pb = p - b;
//             float3 ac = a - c; float3 pc = p - c;
//             float3 nor = cross( ba, ac );
//
//             return sqrt(
//                 (sign(dot(cross(ba,nor),pa)) +
//                     sign(dot(cross(cb,nor),pb)) +
//                     sign(dot(cross(ac,nor),pc))<2)
//                     ?
//                     min( min(
//                             lengthsq(ba*clamp(dot(ba,pa)/lengthsq(ba),0,1)-pa),
//                             lengthsq(cb*clamp(dot(cb,pb)/lengthsq(cb),0,1)-pb) ),
//                         lengthsq(ac*clamp(dot(ac,pc)/lengthsq(ac),0,1)-pc) )
//                     :
//                     dot(nor,pa)*dot(nor,pa)/lengthsq(nor) );
//         }
//
//         static float udQuad( float3 p, float3 a, float3 b, float3 c, float3 d )
//         {
//             float3 ba = b - a; float3 pa = p - a;
//             float3 cb = c - b; float3 pb = p - b;
//             float3 dc = d - c; float3 pc = p - c;
//             float3 ad = a - d; float3 pd = p - d;
//             float3 nor = cross( ba, ad );
//
//             return sqrt(
//                 (sign(dot(cross(ba,nor),pa)) +
//                     sign(dot(cross(cb,nor),pb)) +
//                     sign(dot(cross(dc,nor),pc)) +
//                     sign(dot(cross(ad,nor),pd))<3.0)
//                     ?
//                     min( min( min(
//                                 lengthsq(ba*clamp(dot(ba,pa)/lengthsq(ba),0,1)-pa),
//                                 lengthsq(cb*clamp(dot(cb,pb)/lengthsq(cb),0,1)-pb) ),
//                             lengthsq(dc*clamp(dot(dc,pc)/lengthsq(dc),0,1)-pc) ),
//                         lengthsq(ad*clamp(dot(ad,pd)/lengthsq(ad),0,1)-pd) )
//                     :
//                     dot(nor,pa)*dot(nor,pa)/lengthsq(nor) );
//         }
//         
//
//         /// Elongating is a useful way to construct new shapes. It basically splits a primitive in two (four or eight),
//         /// moves the pieces apart and and connects them. It is a perfect distance preserving operation,
//         /// it does not introduce any artifacts in the SDF. Some of the basic primitives above use this technique.
//         /// For example,the Capsule is an elongated Sphere along an axis really.
//         static float opElongate( in sdf3d primitive, in float3 p, in float3 h )
//         {
//             float3 q = p - clamp( p, -h, h );
//             return primitive( q );
//         }
//
//         static float opElongate( in sdf3d primitive, in float3 p, in float3 h )
//         {
//             float3 q = abs(p)-h;
//             return primitive( max(q,0) ) + min(max(q.x,max(q.y,q.z)),0);
//         }
//         
//         ///Rounding a shape is as simple as subtracting some distance (jumping to a different isosurface).
//         ///The rounded box above is an example, but you can apply it to cones, hexagons or any other shape
//         ///like the cone in the image below. If you happen to be interested in preserving the overall volume
//         ///of the shape, most of the times it's pretty easy to shrink the source primitive by the same amount
//         ///we are rounding it by.
//         static float opRound( in sdf3d primitive, float rad )
//         {
//             return primitive(p) - rad;
//         }
//         
//
//         /// For carving interiors or giving thickness to primitives, without performing expensive boolean operations
//         /// (see below) and without distorting the distance field into a bound, one can use "onioning".
//         /// You can use it multiple times to create concentric layers in your SDF.
//         static float opOnion( in float sdf, in float thickness )
//         {
//             return abs(sdf)-thickness;
//         }
//         
//         /// Generating 3D volumes from 2D shapes has many advantages. Assuming the 2D shape defines exact distances,
//         /// the resulting 3D volume is exact and way often less intensive to evaluate than when produced from boolean
//         /// operations on other volumes. Two of the most simplest way to make volumes out of flat shapes is to use
//         /// extrusion and revolution (generalizations of these are easy to build, but we we'll keep simple here)
//         /// 
//         static float opExtrusion( in float3 p, in sdf2d primitive, in float h )
//         {
//             float d = primitive(p.xy);
//             float2 w = float2( d, abs(p.z) - h );
//             return min(max(w.x,w.y),0) + length(max(w,0));
//         }
//
//         static float opRevolution( in float3 p, in sdf2d primitive, float o )
//         {
//             float2 q = float2( length(p.xz) - o, p.y );
//             return primitive(q);
//         }
//         
//         /// Most of these functions can be modified to use other norms than the euclidean. By replacing length(p),
//         /// which computes (x2+y2+z2)1/2 by (xn+yn+zn)1/n one can get variations of the basic primitives that have
//         /// rounded edges rather than sharp ones. I do not recommend this technique though, since these primitives
//         /// require more raymarching steps until an intersection is found than euclidean primitives. Since they
//         /// only give a bound to the real SDF, this kind of primitive alteration also doesn't play well with shadows
//         /// and occlusion algorithms that rely on true SDFs for measuring distance to occluders.
//         static float length2( float3 p ) { p=p*p; return sqrt( p.x+p.y+p.z); }
//
//         static float length6( float3 p ) { p=p*p*p; p=p*p; return pow(p.x+p.y+p.z,1/6.0); }
//         static float length8( float3 p ) { p=p*p; p=p*p; p=p*p; return pow(p.x+p.y+p.z,1/8.0); }
//         
//         ///These are the most basic combinations of pairs of primitives you can do. They correspond to the basic
//         /// boolean operations. Please note that only the Union of two SDFs returns a true SDF, not the Subtraction
//         /// or Intersection. To make it more subtle, this is only true in the exterior of the SDF (where distances
//         /// are positive) and not in the interior. You can learn more about this and how to work around it in the
//         /// article "Interior Distances". Also note that opSubtraction() is not commutative and depending on the
//         /// order of the operand it will produce different results.
//         static float opUnion( float d1, float d2 ) { return min(d1,d2); }
//
//         static float opSubtraction( float d1, float d2 ) { return max(-d1,d2); }
//         static float opIntersection( float d1, float d2 ) { return max(d1,d2); }
//
//         ///Blending primitives is a really powerful tool - it allows to construct complex and organic shapes without
//         /// the geometrical semas that normal boolean operations produce. There are many flavors of such operations,
//         /// but the basic ones try to replace the min() and max() functions used in the opUnion, opSubstraction and
//         /// opIntersection above with smooth versions. They all accept an extra parameter called k that defines the
//         /// size of the smooth transition between the two primitives. It is given in actual distance units.
//         static float opSmoothUnion( float d1, float d2, float k ) {
//             float h = clamp( 0.5 + 0.5*(d2-d1)/k, 0, 1);
//             return mix( d2, d1, h ) - k*h*(1-h); }
//
//         static float opSmoothSubtraction( float d1, float d2, float k ) {
//             float h = clamp( 0.5 - 0.5*(d2+d1)/k, 0, 1);
//             return mix( d2, -d1, h ) + k*h*(1-h); }
//
//         static float opSmoothIntersection( float d1, float d2, float k ) {
//             float h = clamp( 0.5 - 0.5*(d2-d1)/k, 0, 1);
//             return mix( d2, d1, h ) + k*h*(1-h); }
//         
//         
//         // Positioning
//         
//         /// Since rotations and translation don't compress nor dilate space, all we need to do is simply to transform the point being sampled with the inverse of the transformation used to place an object in the scene. This code below assumes that transform encodes only a rotation and a translation (as a 3x4 matrix for example, or as a quaternion and a vector), and that it does not contain any scaling factors in it.
//         static float3 opTx( in float3 p, in transform t, in sdf3d primitive )
//         {
//             return primitive( invert(t)*p );
//         }
//         
//         /// Scaling an obect is slightly more tricky since that compresses/dilates spaces, so we have to take that into account on the resulting distance estimation. Still, it's not difficult to perform:
//         static float opScale( in float3 p, in float s, in sdf3d primitive )
//         {
//             return primitive(p/s)*s;
//         }
//         
//         /// Symmetry is useful, since many things around us are symmetric, from humans, animals, vehicles, instruments, furniture, ... Oftentimes, one can take shortcuts and only model half or a quarter of the desired shape, and get it duplicated automatically by using the absolute value of the domain coordinates before evaluation. For example, in the image below, there's a single object evaluation instead of two. This is a great savings in performance. You have to be aware however that the resuluting SDF might not be an exact SDF but a bound, if the object you are mirroring crosses the mirroring plane.
//         static float opSymX( in float3 p, in sdf3d primitive )
//         {
//             p.x = abs(p.x);
//             return primitive(p);
//         }
//
//         static float opSymXZ( in float3 p, in sdf3d primitive )
//         {
//             p.xz = abs(p.xz);
//             return primitive(p);
//         }
//         
//         // Infinite Repetition
//         /// Domain repetition is a very useful operator, since it allows you to create infinitely many primitives with a single object evaluator and without increasing the memory footprint of your application. The code below shows how to perform the operation in the simplest way:
//         static float opRep( in float3 p, in float3 c, in sdf3d primitive )
//         {
//             float3 q = mod(p+0.5*c,c)-0.5*c;
//             return primitive( q );
//         }
//         
//         // finite repetition
//         /// Infinite domain repetition is great, but sometimes you only need a few copies or instances of a given SDF, not infinite. A frequently seen but suboptimal solution is to generate infinite copies and then clip the unwanted areas away with a box SDF. This is not ideal because the resulting SDF is not a real SDF but just a bound, since clipping through max() only produces a bound. A much better approach is to clamp the indices of the instances instead of the SDF, and let a correct SDF emerge from the truncated/clamped indices.
//         static float3 opRepLim( in float3 p, in float c, in float3 l, in sdf3d primitive )
//         {
//             float3 q = p-c*clamp(round(p/c),-l,l);
//             return primitive( q );
//         }
//         
//         // displacement
//         /// The displacement example below is using sin(20*p.x)*sin(20*p.y)*sin(20*p.z) as displacement pattern, but you can of course use anything you might imagine.
//         static float opDisplace( in sdf3d primitive, in float3 p )
//         {
//             float d1 = primitive(p);
//             float d2 = displacement(p);
//             return d1+d2;
//         }
//         
//         // Twist
//         static float opTwist( in sdf3d primitive, in float3 p )
//         {
//             const float k = 10; // or some other amount
//             float c = cos(k*p.y);
//             float s = sin(k*p.y);
//             mat2  m = mat2(c,-s,s,c);
//             float3  q = float3(m*p.xz,p.y);
//             return primitive(q);
//         }
//         
//         // bend
//         static float opCheapBend( in sdf3d primitive, in float3 p )
//         {
//             const float k = 10; // or some other amount
//             float c = cos(k*p.x);
//             float s = sin(k*p.x);
//             mat2  m = mat2(c,-s,s,c);
//             float3  q = float3(m*p.xy,p.z);
//             return primitive(q);
//         }
//
//
//     }
// }