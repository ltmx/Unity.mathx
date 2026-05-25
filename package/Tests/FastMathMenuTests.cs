#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

#if UNITY_EDITOR

using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static Unity.Mathematics.mathx;
using Unity.Mathematics;

namespace Unity.Mathematics.Tests
{
    public static class FastMathMenuTests
    {
        const int Samples = 64;
        /// fsqrt / flength / fdistance — fast inverse-sqrt hack, ~5–6% relative error typical.
        const float FsqrtMaxRel = 0.07f;
        /// fastrcp — magic seed + one Newton step, ~1–2% relative error typical.
        const float FrcpMaxRel = 0.02f;

        [MenuItem("Tools/mathx/Test Fast Math")]
        public static void RunFastMathAccuracyTests()
        {
            var passed = 0;
            var failed = 0;

            Debug.Log("[mathx FastMath] Starting accuracy checks (vs Unity.Mathematics reference)…");

            // --- fsqrt ----------------------------------------------------------------
            CheckRel("fsqrt", z => z.fsqrt(), math.sqrt, FsqrtMaxRel, 1e-4f, PositiveRange(1e-4f, 1e4f), ref passed, ref failed);
            CheckExact("fsqrt(0)", () => 0f.fsqrt(), 0f, ref passed, ref failed);

            var f2 = new float2(2f, 9f);
            var f2Ref = math.sqrt(f2);
            var f2Fast = f2.fsqrt();
            var f2RelErr = math.cmax(math.abs(f2Fast - f2Ref) / math.max(math.abs(f2Ref), 1e-4f));
            if (f2RelErr <= FsqrtMaxRel)
                Pass(ref passed, "fsqrt(float2)", $"max rel err {f2RelErr:P2} — fast={f2Fast}, ref={f2Ref}");
            else
                Fail(ref failed, "fsqrt(float2)", $"max rel err {f2RelErr:P2} — fast={f2Fast}, ref={f2Ref}");

            // --- fastrcp ----------------------------------------------------------------
            CheckRel("fastrcp", z => z.fastrcp(), math.rcp, FrcpMaxRel, 1e-4f, PositiveRange(1e-4f, 1e4f), ref passed, ref failed);
            CheckExact("fastrcp(0)", () => 0f.fastrcp(), 0f, ref passed, ref failed);

            var rcp2 = new float2(2f, 9f);
            var rcp2Ref = math.rcp(rcp2);
            var rcp2Fast = rcp2.fastrcp();
            var rcp2RelErr = math.cmax(math.abs(rcp2Fast - rcp2Ref) / math.max(math.abs(rcp2Ref), 1e-4f));
            if (rcp2RelErr <= FrcpMaxRel)
                Pass(ref passed, "fastrcp(float2)", $"max rel err {rcp2RelErr:P2} — fast={rcp2Fast}, ref={rcp2Ref}");
            else
                Fail(ref failed, "fastrcp(float2)", $"max rel err {rcp2RelErr:P2} — fast={rcp2Fast}, ref={rcp2Ref}");

            // --- flength / fdistance (fsqrt of lengthsq) ----------------------------
            var a3 = new float3(3f, 4f, 0f);
            CheckRel("flength(float3)", _ => a3.flength(), _ => math.length(a3), FsqrtMaxRel, 1e-3f, new[] { 0f }, ref passed, ref failed);
            CheckRel("fdistance(float3)", _ => fdistance(a3, float3.zero), _ => math.distance(a3, float3.zero), FsqrtMaxRel, 1e-3f, new[] { 0f }, ref passed, ref failed);

            // --- trig (wrapped to [-PI, PI]) -------------------------------------------
            CheckAbs("sfastsine", Mathematics.mathx.sfastsine, math.sin, 0.08f, AngleRange(), ref passed, ref failed);
            CheckAbs("fastsine", Mathematics.mathx.fastsine, math.sin, 0.02f, AngleRange(), ref passed, ref failed);
            CheckAbs("sfastcosine", Mathematics.mathx.sfastcosine, math.cos, 0.08f, AngleRange(), ref passed, ref failed);
            CheckAbs("fastcosine", Mathematics.mathx.fastcosine, math.cos, 0.02f, AngleRange(), ref passed, ref failed);

            // --- fexp: rational approx of exp(-x), valid for x >= 0 (accuracy degrades above ~2) ---
            CheckRel("fexp vs exp(-x)", fexp, x => math.exp(-x), 0.15f, 1e-3f, Range(0f, 2f), ref passed, ref failed);

            // --- log2int --------------------------------------------------------------
            CheckLog2Int(ref passed, ref failed);

            // --- fastmodinv -----------------------------------------------------------
            CheckFastModInv(ref passed, ref failed);

            Debug.Log($"[mathx FastMath] Done — {passed} passed, {failed} failed.");
            if (failed == 0)
                Debug.Log("[mathx FastMath] All accuracy checks within tolerance.");
        }

        static void Pass(ref int passed, string name, string detail)
        {
            passed++;
            Debug.Log($"[mathx FastMath] PASS — {name}: {detail}");
        }

        static void Fail(ref int failed, string name, string detail)
        {
            failed++;
            Debug.LogError($"[mathx FastMath] FAIL — {name}: {detail}");
        }

        static void CheckAbs(string name, Func<float, float> fast, Func<float, float> reference, float maxAllowed,
            IEnumerable<float> samples, ref int passed, ref int failed)
        {
            var worst = 0f;
            var worstX = 0f;
            var worstRef = 0f;
            var worstFast = 0f;

            foreach (var x in samples)
            {
                var r = reference(x);
                var f = fast(x);
                var err = math.abs(f - r);
                if (err > worst)
                {
                    worst = err;
                    worstX = x;
                    worstRef = r;
                    worstFast = f;
                }
            }

            var detail = $"max abs err = {worst:F6} at x={worstX:F4} (fast={worstFast:F6}, ref={worstRef:F6})";
            if (worst <= maxAllowed) Pass(ref passed, name, detail);
            else Fail(ref failed, name, $"{detail} — tolerance {maxAllowed:F4}");
        }

        static void CheckRel(string name, Func<float, float> fast, Func<float, float> reference, float maxRel, float minDenom,
            IEnumerable<float> samples, ref int passed, ref int failed)
        {
            var worst = 0f;
            var worstX = 0f;

            foreach (var x in samples)
            {
                var r = reference(x);
                var f = fast(x);
                var denom = math.max(math.abs(r), minDenom);
                var err = math.abs(f - r) / denom;
                if (err > worst) { worst = err; worstX = x; }
            }

            var detail = $"max rel err = {worst:P2} at x={worstX:F4}";
            if (worst <= maxRel) Pass(ref passed, name, detail);
            else Fail(ref failed, name, $"{detail} — tolerance {maxRel:P0}");
        }

        static void CheckExact(string name, Func<float> fast, float expected, ref int passed, ref int failed)
        {
            var f = fast();
            if (f == expected) Pass(ref passed, name, f.ToString());
            else Fail(ref failed, name, $"got {f}, expected {expected}");
        }

        static void CheckLog2Int(ref int passed, ref int failed)
        {
            var worst = 0;
            var worstV = 0;

            // Powers of two
            for (var i = 0; i <= 20; i++)
                Compare(1 << i);

            // Sparse multiplicative spread (terminates once v exceeds 2^20)
            for (var v = 1; v <= (1 << 20); v = v * 3 + 1)
                Compare(v);

            // Linear stride across full range
            const int max = 1 << 20;
            for (var v = 1; v <= max; v += max / 128)
                Compare(v);

            var detail = $"max err = {worst} at v={worstV} (expected floor(log2))";
            if (worst <= 1) Pass(ref passed, "log2int", detail);
            else Fail(ref failed, "log2int", detail);

            void Compare(int v)
            {
                var expected = (int)math.floor(math.log2(v));
                var got = v.log2int();
                var err = math.abs(got - expected);
                if (err > worst) { worst = err; worstV = v; }
            }
        }

        static void CheckFastModInv(ref int passed, ref int failed)
        {
            const float mod = 7f;
            var invMod = 1f / mod;
            var worst = 0f;
            var worstI = 0;

            // fastmodinv(i, 1/mod, mod) == i.mod(mod) — not C# integer i % (int)mod for negatives.
            void Compare(int i)
            {
                var expected = i.mod(mod);
                var got = i.fastmodinv(invMod, mod);
                var err = math.abs(got - expected);
                if (err > worst) { worst = err; worstI = i; }
            }

            for (var i = 0; i < 1000; i++)
                Compare(i);
            for (var i = -200; i < 0; i++)
                Compare(i);
            foreach (var i in new[] { 1 << 10, 1 << 16, 1 << 20, 917_687, int.MaxValue / 2 })
                Compare(i);

            var detail = $"max abs err = {worst:F6} at i={worstI} (vs i.mod({mod}g), invMod=1/mod)";
            if (worst <= 1e-4f) Pass(ref passed, "fastmodinv", detail);
            else Fail(ref failed, "fastmodinv", detail);
        }

        static IEnumerable<float> PositiveRange(float min, float max)
        {
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                yield return min * math.pow(max / min, t);
            }
        }

        static IEnumerable<float> Range(float min, float max)
        {
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                yield return math.lerp(min, max, t);
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

#endif
