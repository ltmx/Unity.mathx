#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Collections.Generic;
using NUnit.Framework;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	[TestFixture]
	public class FastMathAccuracyTests
	{
		const int Samples = 64;
		const float FsqrtMaxRel = 0.07f;
		const float FrcpMaxRel = 0.02f;

		[Test]
		public void Fsqrt_MatchesReferenceWithinTolerance() =>
			CheckRel(z => z.fsqrt(), math.sqrt, FsqrtMaxRel, 1e-4f, PositiveRange(1e-4f, 1e4f));

		[Test]
		public void Fsqrt_Zero_IsExact() =>
			Assert.AreEqual(0f, 0f.fsqrt());

		[Test]
		public void Fastrcp_MatchesReferenceWithinTolerance() =>
			CheckRel(z => z.fastrcp(), math.rcp, FrcpMaxRel, 1e-4f, PositiveRange(1e-4f, 1e4f));

		[Test]
		public void Sfastsine_MatchesSinWithinTolerance() =>
			CheckAbs(Mathematics.mathx.sfastsine, math.sin, 0.08f, AngleRange());

		[Test]
		public void Fastsine_MatchesSinWithinTolerance() =>
			CheckAbs(Mathematics.mathx.fastsine, math.sin, 0.02f, AngleRange());

		[Test]
		public void Log2Int_MatchesFloorLog2()
		{
			var worst = 0;
			for (var i = 0; i <= 20; i++)
				worst = math.max(worst, math.abs((1 << i).log2int() - i));
			for (var v = 1; v <= (1 << 20); v = v * 3 + 1)
				worst = math.max(worst, math.abs(v.log2int() - (int)math.floor(math.log2(v))));
			Assert.LessOrEqual(worst, 1);
		}

		static void CheckAbs(Func<float, float> fast, Func<float, float> reference, float maxAllowed, IEnumerable<float> samples)
		{
			var worst = 0f;
			foreach (var x in samples)
				worst = math.max(worst, math.abs(fast(x) - reference(x)));
			Assert.LessOrEqual(worst, maxAllowed, $"max abs err = {worst:F6}");
		}

		static void CheckRel(Func<float, float> fast, Func<float, float> reference, float maxRel, float minDenom, IEnumerable<float> samples)
		{
			var worst = 0f;
			foreach (var x in samples)
			{
				var r = reference(x);
				var f = fast(x);
				worst = math.max(worst, math.abs(f - r) / math.max(math.abs(r), minDenom));
			}
			Assert.LessOrEqual(worst, maxRel, $"max rel err = {worst:P2}");
		}

		static IEnumerable<float> PositiveRange(float min, float max)
		{
			for (var i = 0; i < Samples; i++)
			{
				var t = i / (float)(Samples - 1);
				yield return min * math.pow(max / min, t);
			}
		}

		static IEnumerable<float> AngleRange()
		{
			for (var i = 0; i < Samples; i++)
			{
				var t = i / (float)(Samples - 1);
				yield return math.lerp(-math.PI, math.PI, t);
			}
		}
	}
}
