#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        #region Direction Shorthands
        
        /// Shorthand for new f2(0,1)
        public static readonly float2 upf2 = new(0, 1);
        /// Shorthand for new f2(0,-1)
        public static readonly float2 downf2 = new(0, -1);
        /// Shorthand for new f2(1,0)
        public static readonly float2 rightf2 = new(1, 0);
        /// Shorthand for new f2(-1,0)
        public static readonly float2 leftf2 = new(-1, 0);

        // f3 with implicit naming
        /// Shorthand for new f3(0,1,0)
        public static readonly float3 upf3 = new(0, 1, 0);
        /// Shorthand for new f3(1,0,0);
        public static readonly float3 rightf3 = new(1, 0, 0);
        /// Shorthand for new f3(0,0,1)
        public static readonly float3 forwardf3 = new(0, 0, 1);
        /// Shorthand for new new f3(0,-1,0)
        public static readonly float3 downf3 = new(0, -1, 0);
        /// Shorthand for new f3(-1,0,0)
        public static readonly float3 leftf3 = new(-1, 0, 0);
        /// Shorthand for new f3(0,0,-1)
        public static readonly float3 backf3 = new(0, 0, -1);
        
    
        // One and Zero -----------------------------------------------------
        
        /// Shorthand for new f2(1,1)
        public static readonly float2 onef2 = 1;
        /// Shorthand for new f2(0,0)
        public static readonly float2 zerof2 = 0;
        /// Shorthand for new f3(1,1,1)
        public static readonly float3 onef3 = 1;
        /// Shorthand for new f3(0,0,0)
        public static readonly float3 zerof3 = 0;
        /// Shorthand for new f4(1,1,1,1)
        public static readonly float4 onef4 = 1;
        /// Shorthand for new f4(0,0,0,0)
        public static readonly float4 zerof4 = 0;

        #endregion
        
        #region .xxxx Shader Syntax

        /// Shorthand for new f2(f)
        [MI(IL)] public static float2 xx(this float f) => new(f);
        /// Shorthand for new f3(f)
        [MI(IL)] public static float3 xxx(this float f) => new(f);
        /// Shorthand for new f4(f)
        [MI(IL)] public static float4 xxxx(this float f) => new(f);
        
        #endregion
        
        
        
    }
}