#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using NUnit.Framework;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	[TestFixture]
	public class GoldenHashTests
	{
		[TestCase(0u, 0x0A1E68DAu)]
		[TestCase(1u, 0x78F40330u)]
		[TestCase(7u, 0x842C7FB3u)]
		[TestCase(42u, 0xDF7E0099u)]
		[TestCase(123456789u, 0xEE8C8296u)]
		public void XxHash32_MatchesGolden(uint seed, uint expected) =>
			Assert.AreEqual(expected, seed.xxhash32());

		[TestCase(0u, 0.03952651332121494f)]
		[TestCase(1u, 0.47247333463106150f)]
		[TestCase(7u, 0.51630399830553309f)]
		[TestCase(42u, 0.87301639324822844f)]
		public void Hash01_MatchesGolden(uint seed, float expected) =>
			Assert.AreEqual(expected, seed.hash01(), 1e-6f);

		[TestCase(7u, 0.03260799661106617f)]
		[TestCase(42u, 0.74603278649645688f)]
		public void Hashnp01_MatchesGolden(uint seed, float expected) =>
			Assert.AreEqual(expected, seed.hashnp01(), 1e-6f);

		[Test]
		public void Int2Hashwide_IsNonZero() =>
			Assert.AreNotEqual(0u, new int2(1, 2).hashwide().x);
	}
}
