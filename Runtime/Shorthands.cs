
namespace Unity.Mathematics
{
    public partial class Math
    {
        // Shorthands -----------------------------------------
    
        // float2
        public static readonly float2 onef2 = new(1);
        /// Shorthand for new float2(0,0)
        public static readonly float2 zerof2 = new(0);
        /// Shorthand for new float2(0,1)
        public static readonly float2 upf2 = new(0, 1);
        /// Shorthand for new float2(0,-1)
        public static readonly float2 downf2 = new(0, -1);
        /// Shorthand for new float2(1,0)
        public static readonly float2 rightf2 = new(1, 0);
        /// Shorthand for new float2(-1,0)
        public static readonly float2 leftf2 = new(-1, 0);
    
        // float3
        /// Shorthand for new float3(1,1,1)
        public static readonly float3 f3one = new(1);
        /// Shorthand for new float3(0,0,0)
        public static readonly float3 f3zero = new(0);
        /// Shorthand for new float3(0,1,0)
        public static readonly float3 up = new(0, 1, 0);
        /// Shorthand for new float3(1,0,0);
        public static readonly float3 right = new(1, 0, 0);
        /// Shorthand for new float3(0,0,1)
        public static readonly float3 f3forward = new(0, 0, 1);
        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 down = new(0, -1, 0);
        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 left = new(-1, 0, 0);
        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 back = new(0, 0, -1);

        // float4
        /// Shorthand for new float4(1,1,1,1)
        public static readonly float4 onef4 = new(1);
        /// Shorthand for new float4(0,0,0,0)
        public static readonly float4 zerof4 = new(0);
        
        // double2
        /// Shorthand for new double2(1,1)
        public static readonly double2 oned2 = new(1);
        /// Shorthand for new double2(0,0)
        public static readonly double2 zerod2 = new(0);
        /// Shorthand for new double2(0,1)
        public static readonly double2 upd2 = new(0,1);
        /// Shorthand for new double2(0,-1)
        public static readonly double2 downd2 = new(0,-1);
        /// Shorthand for new double2(1,0)
        public static readonly double2 rightd2 = new(1,0);
        /// Shorthand for new double2(-1,0)
        public static readonly double2 leftd2 = new(-1,0);

        // double3
        /// Shorthand for new double3(1,1,1)
        public static readonly double3 oned3 = new(1);
        /// Shorthand for new double3(0,0,0)
        public static readonly double3 zerod3 = new(0);
        /// Shorthand for new double3(0,1,0)
        public static readonly double3 upd3 = new(0,1,0);
        /// Shorthand for new double3(1,0,0);
        public static readonly double3 rightd3 = new(1,0,0);
        /// Shorthand for new double3(0,0,1)
        public static readonly double3 forward3 = new(0,0,1);
        /// Shorthand for new new double3(0,-1,0)
        public static readonly double3 downd3 = new(0,-1,0);
        /// Shorthand for new double3(-1,0,0)
        public static readonly double3 leftd3 = new(-1,0,0);
        /// Shorthand for new double3(0,0,-1)
        public static readonly double3 backd3 = new(0,0,-1);
    
        //double4
        /// Shorthand for new double4(1,1,1,1)
        public static double4 oned4 = new(1);
        /// Shorthand for new float4(0,0,0,0)
        public static double4 zerod4 = new(0);

        // .xxxx shader syntax
        
        /// Shorthand for new float2(f)
        public static float2 xx(this float f) => new(f);
        /// Shorthand for new float3(f)
        public static float3 xxx(this float f) => new(f);
        /// Shorthand for new float4(f)
        public static float4 xxxx(this float f) => new(f);
        
        /// Shorthand for new double2(f)
        public static double2 xx(this double f) => new(f);
        /// Shorthand for new double3(f)
        public static double3 xxx(this double f) => new(f);
        /// Shorthand for new double4(f)
        public static double4 xxxx(this double f) => new(f);

        /// Shorthand for new int2(i)
        public static int2 xx(this int i) => new(i);
        /// Shorthand for new int3(i)
        public static int3 xxx(this int i) => new(i);
        /// Shorthand for new int4(i)
        public static int4 xxxx(this int i) => new(i);
        
        /// Shorthand for new bool2(i)
        public static bool2 xx(this bool b) => new(b);
        /// Shorthand for new bool3(i)
        public static bool3 xxx(this bool b) => new(b);
        /// Shorthand for new bool4(i)
        public static bool4 xxxx(this bool b) => new(b);
        
    }
}