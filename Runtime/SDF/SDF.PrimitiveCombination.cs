#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using static Unity.Mathematics.mathx;

namespace Unity.Mathematics
{
    using static mathx;
    public static partial class SDF
    {
        // Primitive combinations -------------------------------------

        //Sometimes you cannot simply elongate, round or onion a primitive, and you need to combine,
        //carve or intersect basic primitives. Given the SDFs d1 and d2 of two primitives,
        //you can use the following operators to combine together.

        // These are the most basic combinations of pairs of primitives you can do. They correspond to the basic
        // boolean operations. Please note that only the Union of two SDFs returns a true SDF, not the Subtraction
        // or Intersection. To make it more subtle, this is only true the exterior of the SDF
        // (where distances are positive) and not the interior. You can learn more about this and how to work around
        // it the article "Interior Distances". Also note that opSubtraction() is not commutative and depending
        // on the order of the operand it will produce different results.


        // Smooth Union, Subtraction and Intersection - bound, bound, bound -----------------

        // Blending primitives is a really powerful tool - it allows to construct complex and organic shapes without
        // the geometrical seams that normal boolean operations produce. There are many flavors of such operations,
        // but the basic ones try to replace the min() and max() functions used the opUnion, opSubtraction and
        // opIntersection above with smooth versions. They all accept an extra parameter called k that defines the
        // size of the smooth transition between the two primitives. It is given actual distance units.

        /// The intersection of two shapes. (The minimum of the two distance functions)
        private static float opIntersection(this float d1, float d2) => d1.max(d2);

        /// Subtract a shape from another. This is not commutative, so the order of the operands matters.
        private static float opSubtraction(this float d1, float d2) => (-d1).max(d2);

        /// Adds two SDFs together. (The union of two SDFs is the minimum of the two)
        private static float opUnion(this float d1, float d2) => d1.min(d2);

        /// Smooth Union of two SDFs
        /// <param name="d1">Shape 1</param>
        /// <param name="d2">Shape 2</param>
        /// <param name="k">Size of the transition</param>
        /// <returns></returns>
        private static float opSmoothUnion(this float d1, float d2, float k) => k.smax(d1, d2);

        /// Smooth subtraction: This is not commutative, so the order of the operands matters.
        /// <param name="d1">Base Shape</param>
        /// <param name="d2">Shape to subtract from the base shape</param>
        /// <param name="k">The size of transition</param>
        private static float opSmoothSubtraction(this float d1, float d2, float k) => k.smin(d1, -d2); //Todo : Check correctness of this ... Seems odd

        /// Smooth intersection
        /// <param name="d1">Shape 1</param>
        /// <param name="d2">Shape 2</param>
        /// <param name="k">Size of the transition</param>
        /// <returns></returns>
        private static float opSmoothIntersection(float d1, float d2, float k) => k.smax(d1, d2);
    }
}