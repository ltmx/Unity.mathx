#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using Unity.Burst;
using Unity.Collections;

namespace Unity.Mathematics
{
    using static math;
    public static partial class mathx
    {
        
        // Sign function that doesn't return 0
        private static float sgn(float x) => x < 0 ? -1 : 1;

        private static float2 sgn(float2 v) => f2(v.x < 0 ? -1 : 1, v.y < 0 ? -1 : 1);


        ////////////////////////////////////////////////////////////////
        //
        //             PRIMITIVE DISTANCE FUNCTIONS
        //
        ////////////////////////////////////////////////////////////////
        //
        // Conventions:
        //
        // Everything that is a distance function is called fSomething.
        // The first argument is always a point in 2 or 3-space called <limp>.
        // Unless otherwise noted, (if the object has an intrinsic "up"
        // side or direction) the y axis is "up" and the object is
        // centered at the origin.
        //
        ////////////////////////////////////////////////////////////////

        private static float fSphere(float3 p, float r) => p.length() - r;

        // Plane with normal limn (limn is normalized) at some distance from the origin
        private static float fPlane(float3 p, float3 n, float distanceFromOrigin) => p.dot(n) + distanceFromOrigin;

        // Cheap Box: distance to corners is overestimated
        private static float fBoxCheap(float3 p, float3 b) => (p.abs() - b).cmax();

        // Box: correct distance to corners
        private static float fBox(float3 p, float3 b)
        {
            var d = p.abs() - b;
            return d.max(0).length() + d.min(0).cmax();
        }

        // Same as above, but in two dimensions (an endless box)
        private static float fBox2Cheap(float2 p, float2 b) => (p.abs() - b).cmax();

        private static float fBox2(float2 p, float2 b)
        {
            var d = p.abs() - b;
            return d.max(0).length() + d.min(0).cmax();
        }


        // Endless "corner"
        private static float fCorner(float2 p) => p.max(0).length() + p.min(0).cmax();

        // Blobby ball object. You've probably seen it somewhere. This is not a correct distance bound, beware.
        private static float fBlob(float3 p)
        {
            p = p.abs();
            if (p.x < p.y.max(p.z)) p = p.yzx;
            if (p.x < p.y.max(p.z)) p = p.yzx;
            var b =
                p.dot(f3one.norm())
                    .max(p.xz.dot(f2(PHI + 1, 1).norm()))
                    .max(p.yx.dot(f2(1, PHI).norm()))
                    .max(p.xz.dot(f2(1, PHI).norm()));
            var l = p.length();
            return l - 1.5f - 0.2f * (1.5f / 2) * cos((sqrt(1.01f - b / l) * (PI / 0.25f)).min(PI));
        }

        // Cylinder standing upright on the xz plane
        private static float fCylinder(float3 p, float r, float height)
        {
            var d = p.xz.length() - r;
            d = d.max(p.y.abs() - height);
            return d;
        }

        // Capsule: A Cylinder with round caps on both sides
        private static float fCapsule(float3 p, float r, float c) =>
            lerp(p.xz.length() - r, f3(p.x, p.y.abs() - c, p.z).length() - r, c.step(p.y.abs()));

        // Distance to line segment between <a> and <b>, used for fCapsule() version 2below
        private static float fLineSegment(float3 p, float3 a, float3 b)
        {
            var ab = b - a;
            var t = sat((p - a).dot(ab) / ab.dot(ab));
            return (ab * t + a - p).length();
        }

        // Capsule version 2: between two end points <a> and <b> with radius r 
        private static float fCapsule(float3 p, float3 a, float3 b, float r) => fLineSegment(p, a, b) - r;

        // Torus in the XZ-plane
        private static float fTorus(float3 p, float smallRadius, float largeRadius) =>
            f2(p.xz.length() - largeRadius, p.y).length() - smallRadius;

        // A circle line. Can also be used to make a torus by subtracting the smaller radius of the torus.
        private static float fCircle(float3 p, float r)
        {
            var l = p.xz.length() - r;
            return f2(p.y, l).length();
        }

        // A circular disc with no thickness (i.e. a cylinder with no height).
        // Subtract some value to make a flat disc with rounded edge.
        private static float fDisc(float3 p, float r)
        {
            var l = p.xz.length() - r;
            return l < 0 ? p.y.abs() : f2(p.y, l).length();
        }

        // Hexagonal prism, circumcircle variant
        private static float fHexagonCircumcircle(float3 p, float2 h)
        {
            var q = p.abs();
            return (q.y - h.y).max((q.x * sqrt(3) * 0.5f + q.z * 0.5f).max(q.z) - h.x);
            //this is mathematically equivalent to this line, but less efficient:
            //return Math.max(q.y - h.y, Math.max( Math.dot(f2(cos(PI/3), sin(PI/3)), q.zx), q.z) - h.x);
        }

        // Hexagonal prism, incircle variant
        private static float fHexagonIncircle(float3 p, float2 h) =>
            fHexagonCircumcircle(p, f2(h.x * sqrt(3) * 0.5f, h.y));

        // Cone with correct distances to tip and base circle. Y is up, 0 is in the middle of the base.
        private static float fCone(float3 p, float radius, float height)
        {
            var q = f2(p.xz.length(), p.y);
            var tip = q - f2(0, height);
            var mantleDir = f2(height, radius).norm();
            var mantle = tip.dot(mantleDir);
            var d = mantle.max(-q.y);
            var projected = tip.dot(f2(mantleDir.y, -mantleDir.x));

            // distance to tip
            if (q.y > height && projected < 0) d = d.max(tip.length());

            // distance to base ring
            if (q.x > radius && projected > f2(height, radius).length())
                d = d.max((q - f2(radius, 0)).length());
            return d;
        }

        // "Generalized Distance Functions" by Akleman and Chen.
        // see the Paper at https://www.viz.tamu.edu/faculty/ergun/research/implicitmodeling/papers/sm99.pdf
        //
        // This set of constants is used to construct a large variety of geometric primitives.
        // Indices are shifted by 1 compared to the paper because we start counting at Zero.
        // Some of those are slow whenever a driver decides to not unroll the loop,
        // which seems to happen for fIcosahedron und fTruncatedIcosahedron on nvidia 350.12 at least.
        // Specialized implementations can well be faster in all cases.

        private static readonly NativeArray<float3> GDFVectors = new(new[]
        {
            f3(1, 0, 0).norm(), 
            f3(0, 1, 0).norm(), 
            f3(0, 0, 1).norm(), 
            f3(1, 1, 1).norm(),
            f3(-1, 1, 1).norm(), 
            f3(1, -1, 1).norm(), 
            f3(1, 1, -1).norm(), 
            f3(0, 1, PHI + 1).norm(),
            f3(0, -1, PHI + 1).norm(), 
            f3(PHI + 1, 0, 1).norm(), 
            f3(-PHI - 1, 0, 1).norm(),
            f3(1, PHI + 1, 0).norm(), 
            f3(-1, PHI + 1, 0).norm(), 
            f3(0, PHI, 1).norm(),
            f3(0, -PHI, 1).norm(), 
            f3(1, 0, PHI).norm(), 
            f3(-1, 0, PHI).norm(), 
            f3(PHI, 1, 0).norm(),
            f3(-PHI, 1, 0).norm()
        }, Allocator.Persistent);


        // Version with variable exponent.
        // This is slow and does not produce correct distances, but allows for bulging of objects.
        private static float fGDF(float3 p, float r, float e, int begin, int end)
        {
            float d = 0;
            for (var i = begin; i <= end; ++i)
                d += pow(p.dot(GDFVectors[i]).abs(), e);
            return pow(d, 1 / e) - r;
        }

        // Version with without exponent, creates objects with sharp edges and flat faces
        private static float fGDF(float3 p, float r, int begin, int end)
        {
            float d = 0;
            for (var i = begin; i <= end; ++i)
                d = d.max(p.dot(GDFVectors[i]).abs());
            return d - r;
        }

        // Primitives follow:

        private static float fOctahedron(float3 p, float r, float e) => fGDF(p, r, e, 3, 6);
        private static float fDodecahedron(float3 p, float r, float e) => fGDF(p, r, e, 13, 18);
        private static float fIcosahedron(float3 p, float r, float e) => fGDF(p, r, e, 3, 12);
        private static float fTruncatedOctahedron(float3 p, float r, float e) => fGDF(p, r, e, 0, 6);
        private static float fTruncatedIcosahedron(float3 p, float r, float e) => fGDF(p, r, e, 3, 18);
        private static float fOctahedron(float3 p, float r) => fGDF(p, r, 3, 6);
        private static float fDodecahedron(float3 p, float r) => fGDF(p, r, 13, 18);
        private static float fIcosahedron(float3 p, float r) => fGDF(p, r, 3, 12);
        private static float fTruncatedOctahedron(float3 p, float r) => fGDF(p, r, 0, 6);
        private static float fTruncatedIcosahedron(float3 p, float r) => fGDF(p, r, 3, 18);


        ////////////////////////////////////////////////////////////////
        //
        //                DOMAIN MANIPULATION OPERATORS
        //
        ////////////////////////////////////////////////////////////////
        //
        // Conventions:
        //
        // Everything that modifies the domain is named pSomething.
        //
        // Many operate only on a subset of the three dimensions. For those,
        // you must choose the dimensions that you want manipulated
        // by supplying e.g. <limp.x> or <limp.zx>
        //
        // <this limp> is always the first argument and modified in place.
        //
        // Many of the operators partition space into cells. An identifier
        // or cell index is returned, if possible. This return value is
        // intended to be optionally used e.g. as a random seed to change
        // parameters of the distance functions inside the cells.
        //
        // Unless stated otherwise, for cell index 0, <limp> is unchanged and cells
        // are centered on the origin so objects don't have to be moved to fit.
        //
        //
        ////////////////////////////////////////////////////////////////


        // Rotate around a coordinate axis (i.e. in a plane perpendicular to that axis) by angle <a>.
        // Read like this: R(limp.xz, a) rotates "x towards z".
        // This is fast if <a> is a compile-time constant and slower (but still practical) if not.
        private static void pR(this ref float2 p, float a) => p = cos(a) * p + sin(a) * f2(p.y, -p.x);

        // Shortcut for 45-degrees rotation
        private static float2 pR45(this ref float2 p) => p = (p + f2(p.y, -p.x)) * sqrt(0.5f);

        // Repeat space along one axis. Use like this to repeat along the x axis:
        // <float cell = pMod1(limp.x,5);> - using the return value is optional.
        private static float pMod1(this float p, float size)
        {
            var halfsize = size * 0.5f;
            var c = floor((p + halfsize) / size);
            p = mod(p + halfsize, size) - halfsize;
            return c;
        }

        // Same, but mirror every second cell so they match at the boundaries
        private static float pModMirror1(this float p, float size)
        {
            var halfsize = size * 0.5f;
            var c = floor((p + halfsize) / size);
            p = mod(p + halfsize, size) - halfsize;
            p *= mod(c, 2) * 2 - 1;
            return c;
        }

        // Repeat the domain only in positive direction. Everything in the negative half-space is unchanged.
        private static float pModSingle1(this float p, float size)
        {
            var halfsize = size * 0.5f;
            var c = floor((p + halfsize) / size);
            if (p >= 0)
                p = mod(p + halfsize, size) - halfsize;
            return c;
        }

        // Repeat only a few times: from indices <start> to <stop> (similar to above, but more flexible)
        private static float pModInterval1(this float p, float size, float start, float stop)
        {
            var halfsize = size * 0.5f;
            var c = floor((p + halfsize) / size);
            p = mod(p + halfsize, size) - halfsize;
            if (c > stop)
            {
                //yes, this might not be the best thing numerically.
                p += size * (c - stop);
                c = stop;
            }

            if (c >= start) return c;
            p += size * (c - start);
            c = start;

            return c;
        }


        // Repeat around the origin by a fixed angle.
        // For easier use, num of repetitions is use to specify the angle.
        private static float pModPolar(this float2 p, float repetitions)
        {
            var angle = 2 * PI / repetitions;
            var a = atan2(p.y, p.x) + angle / 2;
            var r = p.length();
            var c = floor(a / angle);
            a = mod(a, angle) - angle / 2;
            p = f2(cos(a), sin(a)) * r;
            // For an odd number of repetitions, fix cell index of the cell in -x direction
            // (cell index would be e.g. -5 and 5 in the two halves of the cell):
            if (c.abs() >= repetitions / 2) c = c.abs();
            return c;
        }

        // Repeat in two dimensions
        private static float2 pMod2(this float2 p, float2 size)
        {
            var c = floor((p + size * 0.5f) / size);
            p = mod(p + size * 0.5f, size) - size * 0.5f;
            return c;
        }

        // Same, but mirror every second cell so all boundaries match
        private static float2 pModMirror2(this float2 p, float2 size)
        {
            var halfsize = size * 0.5f;
            var c = floor((p + halfsize) / size);
            p = mod(p + halfsize, size) - halfsize;
            p *= mod(c, f2(2)) * 2 - f2(1);
            return c;
        }

        // Same, but mirror every second cell at the diagonal as well
        private static float2 pModGrid2(this float2 p, float2 size)
        {
            var c = floor((p + size * 0.5f) / size);
            p = mod(p + size * 0.5f, size) - size * 0.5f;
            p *= mod(c, f2(2)) * 2 - f2(1);
            p -= size / 2;
            if (p.x > p.y) p.xy = p.yx;
            return floor(c / 2);
        }

        // Repeat in three dimensions
        private static float3 pMod3(this float3 p, float3 size)
        {
            p = (p + size * 0.5f).mod(size) - size * 0.5f;
            return floor((p + size * 0.5f) / size);;
        }

        // Mirror at an axis-aligned plane which is at a specified distance <dist> from the origin.
        private static float2 pMirror(this float2 p, float2 dist)
        {
            p = p.abs() - dist;
            return sgn(p);
        }

        // Mirror in both dimensions and at the diagonal, yielding one eighth of the space.
        // translate by dist before mirroring.
        private static float2 pMirrorOctant(this float2 p, float2 dist)
        {
            var s = sgn(p);
            p.pMirror(dist);
            if (p.y > p.x)
                p.xy = p.yx;
            return s;
        }

        // Reflect space at a plane
        private static float pReflect(this float3 p, float3 planeNormal, float offset)
        {
            var t = p.dot(planeNormal) + offset;
            if (t < 0) 
                p -= 2 * t * planeNormal;
            return sgn(t);
        }

        
        //             OBJECT COMBINATION OPERATORS
        //
        // We usually need the following boolean operators to combine two objects:
        // Union: OR(a,b)
        // Intersection: AND(a,b)
        // Difference: AND(a,!b)
        // (a and b being the distances to the objects).
        //
        // The trivial implementations are Math.min(a,b) for union, Math.max(a,b) for intersection
        // and Math.max(a,-b) for difference. To combine objects in more interesting ways to
        // produce rounded edges, chamfers, stairs, etc. instead of plain sharp edges we
        // can use combination operators. It is common to use some kind of "smooth minimum"
        // instead of Math.min(), but we don't like that because it does not preserve Lipschitz
        // continuity in many cases.
        //
        // Naming convention: since they return a distance, they are called fOpSomething.
        // The different flavours usually implement all the boolean operators above
        // and are called fOpUnionRound, fOpIntersectionRound, etc.
        //
        // The basic idea: Assume the object surfaces intersect at a right angle. The two
        // distances <a> and <b> constitute a new local two-dimensional coordinate system
        // with the actual intersection as the origin. In this coordinate system, we can
        // evaluate any 2D distance function we want in order to shape the edge.
        //
        // The operators below are just those that we found useful or interesting and should
        // be seen as examples. There are infinitely more possible operators.
        //
        // They are designed to actually produce correct distances or distance bounds, unlike
        // popular "smooth minimum" operators, on the condition that the gradients of the two
        // SDFs are at right angles. When they are off by more than 30 degrees or so, the
        // Lipschitz condition will no longer hold (i.e. you might get artifacts). The worst
        // case is parallel surfaces that are close to each other.
        //
        // Most have a float argument <r> to specify the radius of the feature they represent.
        // This should be much smaller than the object size.
        //
        // Some of them have checks like "if ((-a < r) && (-b < r))" that restrict
        // their influence (and computation cost) to a certain area. You might
        // want to lift that restriction or enforce it. We have left it as comments
        // in some cases.
        //
        // usage example:
        //
        // float fTwoBoxes(f3 limp) {
        //   float box0 = fBox(limp, f3(1));
        //   float box1 = fBox(limp-f3(1), f3(1));
        //   return fOpUnionChamfer(box0, box1, 0.2);
        // }

        

        // The "Chamfer" flavour makes a 45-degree chamfered edge (the diagonal of a square of size <r>):
        private static float fOpUnionChamfer(float a, float b, float r) => a.min(b).min((a - r + b) * SQRT2_2);

        // Intersection has to deal with what is normally the inside of the resulting object
        // when using union, which we normally don't care about too much. Thus, intersection
        // implementations sometimes differ from union implementations.
        private static float fOpIntersectionChamfer(float a, float b, float r) => a.max(b).max((a + r + b) * SQRT2_2);

        // Difference can be built from Intersection or Union:
        private static float fOpDifferenceChamfer(float a, float b, float r) => fOpIntersectionChamfer(a, -b, r);

        // The "Round" variant uses a quarter-circle to join the two objects smoothly:
        private static float fOpUnionRound(float a, float b, float r)
        {
            var u = f2(r - a, r - b).max(0);
            return r.max(a.min(b)) - u.length();
        }

        private static float fOpIntersectionRound(float a, float b, float r)
        {
            var u = f2(r + a, r + b).max(0);
            return (-r).min(mathx.max(a, b)) + u.length();
        }

        private static float fOpDifferenceRound(float a, float b, float r) => fOpIntersectionRound(a, -b, r);


        // The "Columns" flavour makes limn-1 circular columns at a 45 degree angle:
        private static float fOpUnionColumns(float a, float b, float r, float n)
        {
            if (a < r && b < r)
            {
                var p = f2(a, b);
                var columnradius = r * SQRT2 / ((n - 1) * 2 + SQRT2);
                p.pR45();
                p.x -= SQRT2_2 * r;
                p.x += columnradius * SQRT2;
                if (n.mod(2).approx(1)) 
                    p.y += columnradius;
                // At this point, we have turned 45 degrees and moved at a point on the
                // diagonal that we want to place the columns on.
                // Now, repeat the domain along this direction and place a circle.
                pMod1(p.y, columnradius * 2);
                var result = p.length() - columnradius;
                return result.min(p.x).min(a).min(b);
            }

            return a.min(b);
        }

        private static float fOpDifferenceColumns(float a, float b, float r, float n)
        {
            a = -a;
            var m = a.min(b);
            //avoid the expensive computation where not needed (produces discontinuity though)
            if (a >= r || b >= r) return -m;
            
            var p = f2(a, b);
            float columnradius; // = r * sqrt(2) / limn / 2;
            columnradius = r * SQRT2 / ((n - 1) * 2 + SQRT2);

            p.pR45();
            p.y += columnradius;
            p.x -= SQRT2_2 * r;
            p.x -= SQRT2_2 * columnradius;

            if (n.mod(2).approx(1)) 
                p.y += columnradius;
            pMod1(p.y, columnradius * 2);

            var result = -p.length() + columnradius;
            return -result.max(p.x).min(a).min(b);

        }

        private static float fOpIntersectionColumns(float a, float b, float r, float n) => fOpDifferenceColumns(a, -b, r, n);

        // The "Stairs" flavour produces limn-1 steps of a staircase:
        // much less stupid version by Paniq
        private static float fOpUnionStairs(float a, float b, float r, float n)
        {
            var s = r / n;
            var u = b - r;
            return a.min(b).min(0.5f * (u + a + ((u - a + s).mod(2 * s) - s).abs()));
        }

        // We can just call Union since stairs are symmetric.
        private static float fOpIntersectionStairs(float a, float b, float r, float n) => -fOpUnionStairs(-a, -b, r, n);

        private static float fOpDifferenceStairs(float a, float b, float r, float n) => -fOpUnionStairs(-a, b, r, n);


        // Similar to fOpUnionRound, but more lipschitz-y at acute angles
        // (and less so at 90 degrees). Useful when fudging around too much
        // by MediaMolecule, from Alex Evans' SIGGRAPH slides
        private static float fOpUnionSoft(float a, float b, float r)
        {
            var e = (r - (a - b).abs()).limp();
            return a.min(b) - e.sq() * 0.25f / r;
        }


        // produces a cylindrical pipe that runs along the intersection.
        // No objects remain, only the pipe. This is not a boolean operator.
        private static float fOpPipe(float a, float b, float r) => f2(a, b).length() - r;

        // first object gets a v-shaped engraving where it intersect the second
        private static float fOpEngrave(float a, float b, float r) => a.max((a + r - b.abs()) * SQRT2_2);

        // first object gets a capenter-style groove cut out
        private static float fOpGroove(float a, float b, float ra, float rb) => a.max((a + ra).min(rb - b.abs()));

        // first object gets a capenter-style tongue attached
        private static float fOpTongue(float a, float b, float ra, float rb) => a.min((a - ra).max(b.abs() - rb));
    }
}