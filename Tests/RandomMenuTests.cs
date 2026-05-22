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
    public static class RandomMenuTests
    {
        const float Seed = 42.137f;

        [MenuItem("Tools/mathx/Test Random")]
        public static void RunRandomTests()
        {
            var passed = 0;
            var failed = 0;

            void Pass(string name, string detail = null)
            {
                passed++;
                Debug.Log($"[mathx Random] PASS — {name}" + (detail != null ? $": {detail}" : ""));
            }

            void Fail(string name, string detail)
            {
                failed++;
                Debug.LogError($"[mathx Random] FAIL — {name}: {detail}");
            }

            void Assert(bool condition, string name, string passDetail, string failDetail)
            {
                if (condition) Pass(name, passDetail);
                else Fail(name, failDetail);
            }

            Debug.Log("[mathx Random] Starting random API checks…");

            // --- Global stream advances -------------------------------------------------
            var g0 = randf();
            var g1 = randf();
            var g2 = randf();
            Assert(g0 != g1 || g1 != g2, "globalRng advances",
                $"samples = {g0:F6}, {g1:F6}, {g2:F6}",
                $"three consecutive randf() values were identical ({g0}, {g1}, {g2})");

            Assert(g0 >= 0f && g0 < 1f && g1 >= 0f && g1 < 1f,
                "randf range [0,1)",
                $"g0={g0:F6}, g1={g1:F6}",
                $"out of range: g0={g0}, g1={g1}");

            var rf2 = randf2();
            var rf3 = randf3();
            var rf4 = randf4();
            Pass("randf2/3/4", $"{rf2}, {rf3}, {rf4}");

            // --- seedrand deterministic -------------------------------------------------
            var s1 = Seed.seedrand();
            var s2 = Seed.seedrand();
            Assert(math.abs(s1 - s2) < 1e-6f, "seedrand deterministic",
                $"seed {Seed} -> {s1:F6}",
                $"same seed gave {s1} vs {s2}");

            var seed2 = new float2(1f, 2f);
            var s2a = seed2.seedrand2();
            var s2b = seed2.seedrand2();
            Assert(all(abs(s2a - s2b) < 1e-6f), "seedrand2 deterministic",
                s2a.ToString(),
                $"{s2a} vs {s2b}");

            // --- ref setseed mutates local Random ---------------------------------------
            var local = new Random(1u);
            local.setseed(Seed);
            var refA = local.NextFloat();
            local.setseed(Seed);
            var refB = local.NextFloat();
            Assert(math.abs(refA - refB) < 1e-6f, "ref setseed + NextFloat",
                $"both = {refA:F6}",
                $"{refA} vs {refB}");

            // --- by-value setseed returns seeded copy (unchanged API) -------------------
            var copy = new Random(999u);
            var seeded = copy.setseed(Seed);
            var copyA = seeded.NextFloat();
            var copyB = copy.setseed(Seed).NextFloat();
            Assert(math.abs(copyA - copyB) < 1e-6f, "value setseed chain",
                $"both = {copyA:F6}",
                $"{copyA} vs {copyB}");

            // --- rand / randmax / randomint bounds --------------------------------------
            for (var i = 0; i < 32; i++)
            {
                var v = rand(2f, 5f);
                if (v < 2f || v >= 5f)
                {
                    Fail("rand(min,max) bounds", $"sample {i} = {v}");
                    goto RandBoundsDone;
                }
            }
            Pass("rand(min,max) bounds", "32 samples in [2, 5)");

            RandBoundsDone:
            var rm = 10f.randmax();
            Assert(rm >= 0f && rm < 10f, "randmax", rm.ToString("F6"), rm.ToString());

            var ri = randomint(3, 9);
            Assert(ri >= 3 && ri < 9, "randomint", ri.ToString(), ri.ToString());

            // --- addrand / varyrand -----------------------------------------------------
            var ar = 2f.addrand(3f);
            Assert(ar >= 2f && ar < 5f, "addrand", ar.ToString("F6"), ar.ToString());

            var vr = 1f.varyrand(0f, 1f);
            Assert(vr >= 1f && vr < 2f, "varyrand", vr.ToString("F6"), vr.ToString());

            // --- directions / rotation --------------------------------------------------
            var dir3 = randomDir3D();
            var dir3Len = length(dir3);
            Assert(math.abs(dir3Len - 1f) < 1e-4f, "randomDir3D unit length",
                $"length = {dir3Len:F6}, value = {dir3}",
                $"length = {dir3Len}");
            

            var dir2 = randomDir2D();
            var dir2Len = length(dir2);
            Assert(math.abs(dir2Len - 1f) < 1e-4f, "randomDir2D unit length",
                $"length = {dir2Len:F6}, value = {dir2}",
                $"length = {dir2Len}");

            var inCircle = randomInCircle(2f);
            Assert(length(inCircle) <= 2f + 1e-4f, "randomInCircle radius",
                $"|v| = {length(inCircle):F6}",
                $"|v| = {length(inCircle)}");

            var rot = randomrotation();
            Pass("randomrotation", rot.value.ToString());

            // --- hash / hashwide --------------------------------------------------------
            var h = Seed.hash();
            var h2 = Seed.hash();
            Assert(h == h2, "hash deterministic", h.ToString(), $"{h} vs {h2}");

            var hw = new float3(1f, 2f, 3f).hashwide();
            Assert(any(hw != 0u), "hashwide non-zero", hw.ToString(), "all components zero");

            Debug.Log($"[mathx Random] Done — {passed} passed, {failed} failed.");
            if (failed == 0)
                Debug.Log("[mathx Random] All checks passed.");
        }
    }
}

#endif
