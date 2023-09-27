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
        
        #region .xxxx Shader Syntax
        
        /// Shorthand for new bool2(i)
        [MethodImpl(IL)] public static bool2 xx(this bool b) => new(b);
        /// Shorthand for new bool3(i)
        [MethodImpl(IL)] public static bool3 xxx(this bool b) => new(b);
        /// Shorthand for new bool4(i)
        [MethodImpl(IL)] public static bool4 xxxx(this bool b) => new(b);

        #endregion
        
        
        
    }
}