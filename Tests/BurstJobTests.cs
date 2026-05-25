#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using NUnit.Framework;
using Unity.Collections;
using static Unity.Mathematics.FunctionPointers;
using static Unity.Mathematics.JobifyExtensions;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	[TestFixture]
	public class BurstJobTests
	{
		[Test]
		public void MapAbsJob_MatchesReference()
		{
			using var input = new NativeArray<float>(new[] { -1f, 0f, 2f }, Allocator.TempJob);
			using var output = new NativeArray<float>(3, Allocator.TempJob);
			input.MapAbs(output).Complete();
			Assert.AreEqual(1f, output[0], 1e-6f);
			Assert.AreEqual(0f, output[1], 1e-6f);
			Assert.AreEqual(2f, output[2], 1e-6f);
		}

		[Test]
		public void MapFmaxJob_MatchesReference()
		{
			using var inputA = new NativeArray<float>(new[] { 1f, 5f, 2f }, Allocator.TempJob);
			using var inputB = new NativeArray<float>(new[] { 3f, 1f, 2f }, Allocator.TempJob);
			using var output = new NativeArray<float>(3, Allocator.TempJob);
			inputA.MapFmax(inputB, output).Complete();
			Assert.AreEqual(3f, output[0], 1e-6f);
			Assert.AreEqual(5f, output[1], 1e-6f);
			Assert.AreEqual(2f, output[2], 1e-6f);
		}

		[Test]
		public void FillNoise2DJob_ProducesFiniteValues()
		{
			const int width = 4;
			const int height = 3;
			using var output = new NativeArray<float>(width * height, Allocator.TempJob);
			output.FillNoise2D(new int2(width, height), float2.zero, 0.25f).Complete();
			for (var i = 0; i < output.Length; i++)
			{
				Assert.IsFalse(float.IsNaN(output[i]), $"index {i}");
				Assert.IsFalse(float.IsInfinity(output[i]), $"index {i}");
			}
		}

		[Test]
		public void BurstFunctionPointerAbs_MatchesReference() =>
			Assert.AreEqual(4.2f, pAbsPtr.Invoke(-4.2f), 1e-6f);
	}
}
