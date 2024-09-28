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
        
        /// Shorthand for new i2(0,1)
        public static readonly int2 upi2 = new(0, 1);
        /// Shorthand for new i2(0,-1)
        public static readonly int2 downi2 = new(0, -1);
        /// Shorthand for new i2(1,0)
        public static readonly int2 righti2 = new(1, 0);
        /// Shorthand for new i2(-1,0)
        public static readonly int2 lefti2 = new(-1, 0);

        // i3 with implicit naming
        /// Shorthand for new i3(0,1,0)
        public static readonly int3 upi3 = new(0, 1, 0);
        /// Shorthand for new i3(1,0,0);
        public static readonly int3 righti3 = new(1, 0, 0);
        /// Shorthand for new i3(0,0,1)
        public static readonly int3 forwardi3 = new(0, 0, 1);
        /// Shorthand for new new i3(0,-1,0)
        public static readonly int3 downi3 = new(0, -1, 0);
        /// Shorthand for new i3(-1,0,0)
        public static readonly int3 lefti3 = new(-1, 0, 0);
        /// Shorthand for new i3(0,0,-1)
        public static readonly int3 backi3 = new(0, 0, -1);
        
    
        // One and Zero -----------------------------------------------------
        
        /// Shorthand for new i2(1,1)
        public static readonly int2 onei2 = 1;
        /// Shorthand for new i2(0,0)
        public static readonly int2 zeroi2 = 0;
        /// Shorthand for new i3(1,1,1)
        public static readonly int3 onei3 = 1;
        /// Shorthand for new i3(0,0,0)
        public static readonly int3 zeroi3 = 0;
        /// Shorthand for new i4(1,1,1,1)
        public static readonly int4 onei4 = 1;
        /// Shorthand for new i4(0,0,0,0)
        public static readonly int4 zeroi4 = 0;

        #endregion
        
        #region .xxxx Shader Syntax

        /// Shorthand for new i2(f)
        [MI(IL)] public static int2 xx(this int f) => new(f);
        /// Shorthand for new i3(f)
        [MI(IL)] public static int3 xxx(this int f) => new(f);
        /// Shorthand for new i4(f)
        [MI(IL)] public static int4 xxxx(this int f) => new(f);
        
        #endregion
    }
}