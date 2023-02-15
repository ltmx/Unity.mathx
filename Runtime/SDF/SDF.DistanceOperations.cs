namespace Unity.Mathematics
{
    public static partial class SDF
    {
        /// Rounding a shape is as simple as subtracting some distance (jumping to a different isosurface).
        /// The rounded box above is an example, but you can apply it to cones, hexagons or any other shape
        /// like the cone the image below. If you happen to be interested preserving the overall volume
        /// of the shape, most of the times it's pretty easy to shrink the source primitive by the same amount
        /// we are rounding it by.
        public static float opRound(float sdf, float rad) => sdf - rad;

        /// For carving interiors or giving thickness to primitives, without performing expensive boolean operations
        /// (see below) and without distorting the distance field into a bound, one can use "onioning".
        /// You can use it multiple times to create concentric layers your SDF.
        public static float opOnion(float sdf, float thickness) => sdf.abs() - thickness;
    }
}