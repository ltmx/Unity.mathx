using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace Plugins.Mathematics_Extensions.Runtime
{
    public partial class UME
    {
        // Shorthands -----------------------------------------


        // float2

        public static readonly float2 f2one = new float2(1);

        /// Shorthand for new float2(0,0)
        public static readonly float2 f2zero = new float2(0);

        /// Shorthand for new float2(0,1)
        public static readonly float2 f2up = new float2(0, 1);

        /// Shorthand for new float2(0,-1)
        public static readonly float2 f2down = new float2(0, -1);

        /// Shorthand for new float2(1,0)
        public static readonly float2 f2right = new float2(1, 0);

        /// Shorthand for new float2(-1,0)
        public static readonly float2 f2left = new float2(-1, 0);


        // float3

        /// Shorthand for new float3(1,1,1)
        public static readonly float3 f3one = new float3(1);

        /// Shorthand for new float3(0,0,0)
        public static readonly float3 f3zero = new float3(0);

        /// Shorthand for new float3(0,1,0)
        public static readonly float3 f3up = new float3(0, 1, 0);

        /// Shorthand for new float3(1,0,0);
        public static readonly float3 f3right = new float3(1, 0, 0);

        /// Shorthand for new float3(0,0,1)
        public static readonly float3 f3forward = new float3(0, 0, 1);

        /// Shorthand for new new float3(0,-1,0)
        public static readonly float3 f3down = new float3(0, -1, 0);

        /// Shorthand for new float3(-1,0,0)
        public static readonly float3 f3left = new float3(-1, 0, 0);

        /// Shorthand for new float3(0,0,-1)
        public static readonly float3 f3back = new float3(0, 0, -1);


        // float4

        /// Shorthand for new float4(1,1,1,1)
        public static readonly float4 f4one = new float4(1);
        
        /// Shorthand for new float4(0,0,0,0)
        public static readonly float4 f4zero = new float4(0);
        
        // double2

        /// Shorthand for new double2(1,1)
        public static readonly double2 d2one = new double2(1);
        
        /// Shorthand for new double2(0,0)
        public static readonly double2 d2zero = new double2(0);
        
        /// Shorthand for new double2(0,1)
        public static readonly double2 d2up = new double2(0,1);
        
        /// Shorthand for new double2(0,-1)
        public static readonly double2 d2down = new double2(0,-1);
        
        /// Shorthand for new double2(1,0)
        public static readonly double2 d2right = new double2(1,0);
        
        /// Shorthand for new double2(-1,0)
        public static readonly double2 d2left = new double2(-1,0);

        
        // double3

        /// Shorthand for new double3(1,1,1)
        public static readonly double3 d3one = new double3(1);
        
        /// Shorthand for new double3(0,0,0)
        public static readonly double3 d3zero = new double3(0);
        
        /// Shorthand for new double3(0,1,0)
        public static readonly double3 d3up = new double3(0,1,0);
        
        /// Shorthand for new double3(1,0,0);
        public static readonly double3 d3right = new double3(1,0,0);
        
        /// Shorthand for new double3(0,0,1)
        public static readonly double3 d3forward = new double3(0,0,1);
        
        /// Shorthand for new new double3(0,-1,0)
        public static readonly double3 d3down = new double3(0,-1,0);
        
        /// Shorthand for new double3(-1,0,0)
        public static readonly double3 d3left = new double3(-1,0,0);
        
        /// Shorthand for new double3(0,0,-1)
        public static readonly double3 d3back = new double3(0,0,-1);
        
        
        //double4
        
        /// Shorthand for new double4(1,1,1,1)
        public static double4 d4one = new double4(1);
        
        /// Shorthand for new float4(0,0,0,0)
        public static double4 d4zero = new double4(0);
        
        
        // .xxxx shader syntax
        
        /// Shorthand for new float2(f)
        public static float2 xx(this float f) => new float2(f);
        /// Shorthand for new float3(f)
        public static float3 xxx(this float f) => new float3(f);
        /// Shorthand for new float4(f)
        public static float4 xxxx(this float f) => new float4(f);
        
        /// Shorthand for new double2(f)
        public static double2 xx(this double f) => new double2(f);
        /// Shorthand for new double3(f)
        public static double3 xxx(this double f) => new double3(f);
        /// Shorthand for new double4(f)
        public static double4 xxxx(this double f) => new double4(f);

        /// Shorthand for new int2(i)
        public static int2 xx(this int i) => new int2(i);
        /// Shorthand for new int3(i)
        public static int3 xxx(this int i) => new int3(i);
        /// Shorthand for new int4(i)
        public static int4 xxxx(this int i) => new int4(i);
        
        /// Shorthand for new bool2(i)
        public static bool2 xx(this bool b) => new bool2(b);
        /// Shorthand for new bool3(i)
        public static bool3 xxx(this bool b) => new bool3(b);
        /// Shorthand for new bool4(i)
        public static bool4 xxxx(this bool b) => new bool4(b);
        
    }
}