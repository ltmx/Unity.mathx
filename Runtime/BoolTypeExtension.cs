namespace Unity.Mathematics
{
    public static class BoolTypeExtension
    {
        public static bool isAlwaysTrue(this bool4 b) => b.x && b.y && b.z && b.w;
        public static bool isAlwaysTrue(this bool3 b) => b.x && b.y && b.z;
        public static bool isAlwaysTrue(this bool2 b) => b.x && b.y;
    }
}