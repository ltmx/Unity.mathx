#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
	public static class WipMenuTests
	{
		[MenuItem("Tools/mathx/Test WIP Roadmap (legacy menu)")]
		public static void RunWipTests()
		{
			Debug.Log("[mathx WIP] Prefer Window → General → Test Runner (Edit Mode). Running legacy smoke checks…");
			var passed = 0;
			var failed = 0;

			void Pass(string name) { passed++; Debug.Log($"[mathx WIP] PASS — {name}"); }
			void Fail(string name, string detail) { failed++; Debug.LogError($"[mathx WIP] FAIL — {name}: {detail}"); }
			void Assert(bool ok, string name, string fail) { if (ok) Pass(name); else Fail(name, fail); }

			// Hashing
			var h = 42u.xxhash32();
			Assert(h == 42u.xxhash32(), "xxhash32 deterministic", $"{h}");
			Assert(7u.hash01() >= 0f && 7u.hash01() <= 1f, "hash01 range", "out of [0,1]");
			Assert(any(new int2(1, 2).hashwide() != 0u), "int2 hashwide", "zero");

			// Noise
			var sx = float2.zero.simplex2();
			Assert(!float.IsNaN(sx), "simplex2 finite", sx.ToString());
			var px = new float2(1.3f, 2.7f).perlin2();
			Assert(!float.IsNaN(px), "perlin2 finite", px.ToString());
			var wx = worley2(float2(0.5f, 0.5f));
			Assert(wx >= 0f, "worley2 non-negative", wx.ToString());
			var vx = voronoi2(float2(0.5f, 0.5f));
			Assert(!float.IsNaN(vx), "voronoi2 finite", vx.ToString());
			var fb = fbm2(float2(1f, 2f), 3);
			Assert(!float.IsNaN(fb), "fbm2 finite", fb.ToString());

			// Iterators
			Assert(2f.apply(x => x * 2f, 3) == 16f, "apply cycles", "expected 16");
			var count = 0;
			forEach2D(new int2(3, 2), _ => count++);
			Assert(count == 6, "forEach2D", $"count={count}");

			// Vector builders
			var fm = new float2(1f, 4f).fmin(2f);
			Assert(fm.x == 1f && fm.y == 2f, "vector fmin", fm.ToString());

			Debug.Log($"[mathx WIP] Done — {passed} passed, {failed} failed.");
		}
	}
}

#endif
