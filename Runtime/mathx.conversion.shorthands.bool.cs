// // ** Copyright (C) 2026 @ltmx. All rights reserved.
// // ** GitHub Profile: https://github.com/ltmx
// // ** Repository : https://github.com/ltmx/Unity.mathx

#region

using MI = System.Runtime.CompilerServices.MethodImplAttribute;

#endregion

namespace Unity.Mathematics
{
	public partial class mathx
	{
		#region .xxxx Shader Syntax

		/// Shorthand for new bool2(i)
		[MI(IL)] public static bool2 xx(this bool b) => new(b);
		/// Shorthand for new bool3(i)
		[MI(IL)] public static bool3 xxx(this bool b) => new(b);
		/// Shorthand for new bool4(i)
		[MI(IL)] public static bool4 xxxx(this bool b) => new(b);

		#endregion
	}
}