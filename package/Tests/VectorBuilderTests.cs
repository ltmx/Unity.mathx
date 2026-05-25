#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using NUnit.Framework;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	[TestFixture]
	public class VectorBuilderTests
	{
		[Test]
		public void Fmin_ScalarBound()
		{
			var result = new float2(1f, 4f).fmin(2f);
			Assert.AreEqual(1f, result.x, 1e-6f);
			Assert.AreEqual(2f, result.y, 1e-6f);
		}

		[Test]
		public void Clampfp_MatchesScalarClamp()
		{
			var value = new float3(-1f, 0.5f, 2f);
			var clamped = value.clampfp(0f, 1f);
			Assert.AreEqual(0f, clamped.x, 1e-6f);
			Assert.AreEqual(0.5f, clamped.y, 1e-6f);
			Assert.AreEqual(1f, clamped.z, 1e-6f);
		}

		[Test]
		public void Saturatefp_MatchesSaturate()
		{
			var value = new float2(-2f, 3f);
			var saturated = value.saturatefp();
			Assert.AreEqual(0f, saturated.x, 1e-6f);
			Assert.AreEqual(1f, saturated.y, 1e-6f);
		}
	}
}
