using Unity.Mathematics;

namespace UME
{
    public partial class UnityMathematicsExtensions
    {
        // Shorthands -----------------------------------------

        
        // float2

        public static readonly float2 f2one = new float2(1,1);

        /// Shorthand for writing new float2(0,0)
        public static readonly float2 f2zero = new float2(0,0);
        
        /// Shorthand for writing new float2(0,1)
        public static readonly float2 f2up = new float2(0,1);
        
        /// Shorthand for writing new float2(0,-1)
        public static readonly float2 f2down = new float2(0,-1);
        
        /// Shorthand for writing new float2(1,0)
        public static readonly float2 f2right = new float2(1,0);
        
        /// Shorthand for writing new float2(-1,0)
        public static readonly float2 f2left = new float2(-1,0);

        
        // float3

        /// Shorthand for writing new float3(1,1,1)
        public static readonly float3 f3one = new float3(1,1,1);
        
        /// Shorthand for writing new float3(0,0,0)
        public static readonly float3 f3zero = new float3(0,0,0);
        
        /// Shorthand for writing new float3(0,1,0)
        public static readonly float3 f3up = new float3(0,1,0);
        
        /// Shorthand for writing new float3(1,0,0);
        public static readonly float3 f3right = new float3(1,0,0);
        
        /// Shorthand for writing new float3(0,0,1)
        public static readonly float3 f3forward = new float3(0,0,1);
        
        /// Shorthand for writing new new float3(0,-1,0)
        public static readonly float3 f3down = new float3(0,-1,0);
        
        /// Shorthand for writing new float3(-1,0,0)
        public static readonly float3 f3left = new float3(-1,0,0);
        
        /// Shorthand for writing new float3(0,0,-1)
        public static readonly float3 f3back = new float3(0,0,-1);
        
        
        // float4
        
        /// Shorthand for writing new float4(1,1,1,1)
        public static readonly float4 f4one = new float4(1,1,1,1);
        
        /// Shorthand for writing new float4(0,0,0,0)
        public static readonly float4 f4zero = new float4(0,0,0,0);
        
        // double2

        /// Shorthand for writing new double2(1,1)
        public static readonly double2 d2one = new double2(1,1);
        
        /// Shorthand for writing new double2(0,0)
        public static readonly double2 d2zero = new double2(0,0);
        
        /// Shorthand for writing new double2(0,1)
        public static readonly double2 d2up = new double2(0,1);
        
        /// Shorthand for writing new double2(0,-1)
        public static readonly double2 d2down = new double2(0,-1);
        
        /// Shorthand for writing new double2(1,0)
        public static readonly double2 d2right = new double2(1,0);
        
        /// Shorthand for writing new double2(-1,0)
        public static readonly double2 d2left = new double2(-1,0);

        
        // double3

        /// Shorthand for writing new double3(1,1,1)
        public static readonly double3 d3one = new double3(1,1,1);
        
        /// Shorthand for writing new double3(0,0,0)
        public static readonly double3 d3zero = new double3(0,0,0);
        
        /// Shorthand for writing new double3(0,1,0)
        public static readonly double3 d3up = new double3(0,1,0);
        
        /// Shorthand for writing new double3(1,0,0);
        public static readonly double3 d3right = new double3(1,0,0);
        
        /// Shorthand for writing new double3(0,0,1)
        public static readonly double3 d3forward = new double3(0,0,1);
        
        /// Shorthand for writing new new double3(0,-1,0)
        public static readonly double3 d3down = new double3(0,-1,0);
        
        /// Shorthand for writing new double3(-1,0,0)
        public static readonly double3 d3left = new double3(-1,0,0);
        
        /// Shorthand for writing new double3(0,0,-1)
        public static readonly double3 d3back = new double3(0,0,-1);
        
        
        //double4
        
        /// Shorthand for writing new double4(1,1,1,1)
        public static double4 d4one = new double4(1,1,1,1);
        
        /// Shorthand for writing new float4(0,0,0,0)
        public static double4 d4zero = new double4(0,0,0,0);
    }
}