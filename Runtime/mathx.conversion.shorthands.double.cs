#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;


namespace Unity.Mathematics
{
    public partial class mathx
    {
        #region Direction Shorthands
        
        /// Shorthand for new d2(0,1)
        public static readonly double2 upd2 = new(0, 1);
        /// Shorthand for new d2(0,-1)
        public static readonly double2 downd2 = new(0, -1);
        /// Shorthand for new d2(1,0)
        public static readonly double2 rightd2 = new(1, 0);
        /// Shorthand for new d2(-1,0)
        public static readonly double2 leftd2 = new(-1, 0);

        // d3 with implicit naming
        /// Shorthand for new d3(0,1,0)
        public static readonly double3 upd3 = new(0, 1, 0);
        /// Shorthand for new d3(1,0,0);
        public static readonly double3 rightd3 = new(1, 0, 0);
        /// Shorthand for new d3(0,0,1)
        public static readonly double3 forwardd3 = new(0, 0, 1);
        /// Shorthand for new new d3(0,-1,0)
        public static readonly double3 downd3 = new(0, -1, 0);
        /// Shorthand for new d3(-1,0,0)
        public static readonly double3 leftd3 = new(-1, 0, 0);
        /// Shorthand for new d3(0,0,-1)
        public static readonly double3 backd3 = new(0, 0, -1);
        
    
        // One and Zero -----------------------------------------------------
        
        /// Shorthand for new d2(1,1)
        public static readonly double2 oned2 = 1;
        /// Shorthand for new d2(0,0)
        public static readonly double2 zerod2 = 0;
        /// Shorthand for new d3(1,1,1)
        public static readonly double3 oned3 = 1;
        /// Shorthand for new d3(0,0,0)
        public static readonly double3 zerod3 = 0;
        /// Shorthand for new d4(1,1,1,1)
        public static readonly double4 oned4 = 1;
        /// Shorthand for new d4(0,0,0,0)
        public static readonly double4 zerod4 = 0;

        #endregion
        
        #region .xxxx Shader Syntax

        /// Shorthand for new d2(f)
        [MethodImpl(IL)] public static double2 xx(this double f) => new(f);
        /// Shorthand for new d3(f)
        [MethodImpl(IL)] public static double3 xxx(this double f) => new(f);
        /// Shorthand for new d4(f)
        [MethodImpl(IL)] public static double4 xxxx(this double f) => new(f);
        
        #endregion
        
        
        
    }
}