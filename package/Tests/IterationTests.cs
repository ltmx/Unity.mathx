#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using NUnit.Framework;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	[TestFixture]
	public class IterationTests
	{
		[Test]
		public void Apply_ScalarCycles() =>
			Assert.AreEqual(16f, 2f.apply(x => x * 2f, 3), 1e-6f);

		[Test]
		public void ForEach2D_CountsCells()
		{
			var count = 0;
			forEach2D(new int2(3, 2), _ => count++);
			Assert.AreEqual(6, count);
		}

		[Test]
		public void Applyfp_AbsCycles()
		{
			var input = new float2(-1f, 2f);
			var result = input.applyfp(pAbsPtr, 1);
			Assert.AreEqual(1f, result.x, 1e-6f);
			Assert.AreEqual(2f, result.y, 1e-6f);
		}
	}
}
