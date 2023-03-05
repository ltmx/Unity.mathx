#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;

namespace Unity.Mathematics
{
    using static mathx;
    using static math;
    public static partial class SDF
    {
        
        /// Elongating is a useful way to construct new shapes. It basically splits a primitive two (four or eight),
        /// moves the pieces apart and and connects them. It is a perfect distance preserving operation,
        /// it does not introduce any artifacts the SDF. Some of the basic primitives above use this technique.
        /// For example,the Capsule is an elongated Sphere along an axis really.
        public static float3 opElongate(float3 p, float3 h) => p - p.clamp(-h, h);

        /// The reason I provide to implementations is the following. For 1D elongations, the first function
        /// works perfectly and gives exact exterior and interior distances. However, the first implementation
        /// produces a small core of zero distances inside the volume for 2D and 3D elongations.
        /// Depending on your application that might be a problem. One way to create exact interior distances
        /// all the way to the very elongated core of the volume, is the following, which is in languages like GLSL
        /// that don't have function pointers or lambdas need to be implemented a bit differently
        public static float3 opElongateAlternate(float3 p, float3 h)
        {
            var q = p.abs() - h;
            return q.p() + q.x.max(q.y.max(q.z)).n();
        }
        
        
        // Positioning -----------------------------------------------------------------------------------------------
        
        // Rotation/Translation - exact
        
        /// Since rotations and translation don't compress nor dilate space, all we need to do is simply to transform
        /// the point being sampled with the inverse of the transformation used to place an object the scene.
        /// This code below assumes that transform encodes only a rotation and a translation
        /// (as a 3x4 matrix for example, or as a quaternion and a vector), and that it does not contain
        /// scaling factors it.

        private static float3 opTransformx(this float3 p, float3x4 t) => p.mul(t.inverse()).xyz;
        
        
        // Scale -----------------------------------------------------------------------------------------------
        
        /// Scale Operation
        private static float3 opScale(this float3 p, float s) => p * s;
        
        
        // Symmetry - bound and exact ---------------------------------------------------------------------

        // Symmetry is useful, since many things around us are symmetric, from humans, animals, vehicles, instruments,
        // furniture, ... Oftentimes, one can take shortcuts and only model half or a quarter of the desired shape,
        // and get it duplicated automatically by using the Math.absolute value of the domain-coordinates before
        // evaluation. For example, the image below, there's a single object evaluation instead of two.
        // This is a great savings performance.
        // You have to be aware however that the resulting SDF might not be an exact SDF but a bound,
        // if the object you are mirroring crosses the mirroring plane.
        /// Symmetry in Y axis
        private static float3 opSymX(this float3 p) => float3(p.x.abs(), p.yz);
        /// Symmetry on Y axis
        private static float3 opSymY(this float3 p) => float3(p.x, p.y.abs(), p.z);
        /// Symmetry on Z axis
        private static float3 opSymZ(this float3 p) => float3(p.xy, p.z.abs());
        /// Symmetry on X and Y axis
        private static float3 opSymXY(this float3 p) => float3(p.xy.abs(), p.z);
        /// Symmetry on X and Z axis
        private static float3 opSymYZ(this float3 p) => float3(p.x, p.yz.abs());
        /// Symmetry on X and Z axis
        private static float3 opSymXZ(this float3 p) => float3(p.x.abs(), p.y, p.z.abs());

        
        // Infinite Repetition ----------------------------------------------------------------------

        /// Domain-repetition is a very useful operator, since it allows you to create infinitely many primitives
        /// with a single object evaluator and without increasing the memory footprint of your application.
        /// The code below shows how to perform the operation the simplest way
        private static float3 opRep(this float3 p, float3 c) => (p + 0.5f * c).mod(c) - 0.5f * c;

        
        // Finite Repetition ----------------------------------------------------------------------
        
        /// Infinite domain-repetition is great, but sometimes you only need a few copies or instances of a given SDF,
        /// not infinite. A frequently seen but suboptimal solution is to generate infinite copies
        /// and then clip the unwanted areas away with a box SDF. This is not ideal because the resulting SDF
        /// is not a real SDF but just a bound, since clipping through Math.max() only produces a bound.
        /// A much better approach is to clamp the indices of the instances instead of the SDF,
        /// and let a correct SDF emerge from the truncated/clamped indices.
        private static float3 opRepLim(this float3 p, float c, float3 l) => p - c * clamp(round(p / c), -l, l);

        // Deformations and distortions ----------------------------------------------------------------------

        // Deformations and distortions allow to enhance the shape of primitives or even fuse different primitives together.
        // The operations usually distort the distance field and make it non euclidean anymore, so one must be
        // careful when raymarching them, you will probably need to decrease your step size, if you are using a
        // raymarcher to sample this. In principle one can compute the factor by which the step size needs to be
        // reduced (inversely proportional to the compression of the space, which is given by the jacobian of
        // the deformation function). But even with dual numbers or automatic differentiation, it's usually just easier
        // to find the constant by hand for a given primitive.
        // I'd say that while it is tempting to use a distortion or displacement to achieve a given shape, and I
        // often use them myself of course, it is sometimes better to get as close to the desired shape with actual
        // exact euclidean primitive operations(elongation, rounding, onioning, union) or tight bounded functions
        // (intersection, subtraction) and then only apply as small of a distortion or displacement as possible.
        // That way the field stays as close as possible to an actual distance field,
        // and the raymarcher will be faster.

        // Displacement --------------------------------------------------------------------------------
        
        /// The displacement example below is using sin(20*p.x)*sin(20*p.y)*sin(20*p.z) as displacement pattern,
        /// ut you can of course use anything you might imagine.
        private static float3 opDisplace(this float3 p, float3 displacement) => p + displacement;

        // Twist --------------------------------------------------------------------------------------

        // todo : add params such as the axis of twist
        private static float3 opTwist(float3 p, float twist)
        {
            sincos(twist * p.y, out float s, out float c);
            var m = float2x2(c, -s, s, c);
            var q = float3(mul(m, p.xz), p.y);
            return q;
        }
        
        // Bend ---------------------------------------------------------------------------------------

        private static float3 opCheapBend(this float3 p, float bend)
        {
            sincos(bend * p.x, out float s, out float c);
            var m = float2x2(c, -s, s, c);
            var q = float3(mul(m, p.xy), p.z);
            return q;
        }
        
        // Revolution and extrusion from -----------------

        /// Generating 3D volumes from 2D shapes has many advantages. Assuming the 2D shape defines exact distances,
        /// the resulting 3D volume is exact and way often less intensive to evaluate than when produced from boolean
        /// operations on other volumes. Two of the most simplest way to make volumes out of flat shapes is to use
        /// extrusion and revolution (generalizations of these are easy to build, but we we'll keep simple here)

        
        public static float3 revolveY(this float3 p)
        {
            var c = float2(p.xz.length(), p.y);
            var a = atan2(p.z, p.x);
            sincos(a, out var sin, out var cos);
            return float3(c.x * cos, c.y, c.x * sin);
        }
        
        public static float3 extrudeZ(this float3 p, float h) => float3(p.xy, p.z.abs() - h);

    }
}