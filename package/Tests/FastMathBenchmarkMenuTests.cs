#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

#if UNITY_EDITOR

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEditor;
using Debug = UnityEngine.Debug;
using static Unity.Mathematics.math;
using static Unity.Mathematics.mathx;

namespace Unity.Mathematics.Tests
{
    public static class FastMathBenchmarkMenuTests
    {
        const int Samples = 64;
        const int Iterations = 1_000_000;
        const int Warmup = 10_000;

        static volatile float SinkF;
        static volatile int SinkI;

        struct Result
        {
            public string Name;
            public double FastMs;
            public double RefMs;
            public double Speedup;
        }

        [MenuItem("Tools/mathx/Benchmark Fast Math")]
        public static void RunFastMathBenchmarks()
        {
            var results = new List<Result>(18);

            Debug.Log($"[mathx FastMath Benchmark] Starting ({Iterations:N0} iterations per side, {Samples} rotating samples)…");

            var sqrtSamples = BuildPositiveRange(1e-4f, 1e4f);
            var angleSamples = BuildAngleRange();
            var expSamples = BuildRange(0f, 2f);
            var intSamples = BuildIntRange(1, 1 << 20);
            var vectors = BuildFloat3Samples();
            var sqrtPairs = BuildFloat2Samples(sqrtSamples);
            var sqrtQuadruples = BuildFloat4Samples(sqrtSamples);

            Add(results, "fsqrt", TimeFsqrtFast(sqrtSamples), TimeFsqrtRef(sqrtSamples));
            Add(results, "fsqrt(float2)", TimeFsqrt2Fast(sqrtPairs), TimeFsqrt2Ref(sqrtPairs));
            Add(results, "fastrcp", TimeFastrcpFast(sqrtSamples), TimeRcpRef(sqrtSamples));
            Add(results, "fastrcp(float2)", TimeFastrcp2Fast(sqrtPairs), TimeRcp2Ref(sqrtPairs));
            Add(results, "fastrcp(float4)", TimeFastrcp4Fast(sqrtQuadruples), TimeRcp4Ref(sqrtQuadruples));
            Add(results, "flength(float3)", TimeFlengthFast(vectors), TimeFlengthRef(vectors));
            Add(results, "fdistance(float3)", TimeFdistanceFast(vectors), TimeFdistanceRef(vectors));
            Add(results, "sfastsine", TimeSfastsineFast(angleSamples), TimeSinRef(angleSamples));
            Add(results, "fastsine", TimeFastsineFast(angleSamples), TimeSinRef(angleSamples));
            Add(results, "sfastcosine", TimeSfastcosineFast(angleSamples), TimeCosRef(angleSamples));
            Add(results, "fastcosine", TimeFastcosineFast(angleSamples), TimeCosRef(angleSamples));
            Add(results, "fexp", TimeFexpFast(expSamples), TimeFexpRef(expSamples));
            Add(results, "log2int", TimeLog2IntFast(intSamples), TimeLog2IntRef(intSamples));
            Add(results, "fastmodinv", TimeFastModInvFast(intSamples), TimeModRef(intSamples));

            results.Sort((a, b) => b.Speedup.CompareTo(a.Speedup));

            Debug.Log($"[mathx FastMath Benchmark] Sink check — float={SinkF:F4} int={SinkI} (prevents dead-code elimination)");
            Debug.Log("[mathx FastMath Benchmark] ── summary (fast vs reference) ──");
            foreach (var r in results)
                LogLine(r);

            Debug.Log("[mathx FastMath Benchmark] Done. Compare speedup ratios; absolute ms vary by Editor / backend / CPU.");
        }

        static void Add(List<Result> results, string name, double fastMs, double refMs)
        {
            var r = new Result { Name = name, FastMs = fastMs, RefMs = refMs, Speedup = refMs / System.Math.Max(fastMs, 1e-9) };
            results.Add(r);
            LogLine(r);
        }

        // --- fsqrt -----------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFsqrtFast(float[] xs)
        {
            var mask = xs.Length - 1;
            WarmupFsqrtFast(xs, mask);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].fsqrt();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFsqrtRef(float[] xs)
        {
            var mask = xs.Length - 1;
            WarmupFsqrtRef(xs, mask);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += sqrt(xs[i & mask]);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static void WarmupFsqrtFast(float[] xs, int mask)
        {
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].fsqrt();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static void WarmupFsqrtRef(float[] xs, int mask)
        {
            for (var i = 0; i < Warmup; i++)
                SinkF += sqrt(xs[i & mask]);
        }

        // --- fastrcp ---------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastrcpFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].fastrcp();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].fastrcp();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeRcpRef(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].rcp();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].rcp();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastrcp2Fast(float2[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(pairs[i & mask].fastrcp());
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(pairs[i & mask].fastrcp());
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeRcp2Ref(float2[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(pairs[i & mask].rcp());
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(pairs[i & mask].rcp());
            return ElapsedMs(t0);
        }
        
        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastrcp4Fast(float4[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(pairs[i & mask].fastrcp());
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(pairs[i & mask].fastrcp());
            return ElapsedMs(t0);
        }
        
        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeRcp4Ref(float4[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(pairs[i & mask].rcp());
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(pairs[i & mask].rcp());
            return ElapsedMs(t0);
        }

        // --- fsqrt(float2) ---------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFsqrt2Fast(float2[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(pairs[i & mask].fsqrt());
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(pairs[i & mask].fsqrt());
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFsqrt2Ref(float2[] pairs)
        {
            var mask = pairs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += csum(sqrt(pairs[i & mask]));
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += csum(sqrt(pairs[i & mask]));
            return ElapsedMs(t0);
        }

        // --- flength / fdistance ---------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFlengthFast(float3[] vs)
        {
            var mask = vs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += vs[i & mask].flength();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += vs[i & mask].flength();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFlengthRef(float3[] vs)
        {
            var mask = vs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += length(vs[i & mask]);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += length(vs[i & mask]);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFdistanceFast(float3[] vs)
        {
            var mask = vs.Length - 1;
            var zero = float3.zero;
            for (var i = 0; i < Warmup; i++)
                SinkF += fdistance(vs[i & mask], zero);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += fdistance(vs[i & mask], zero);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFdistanceRef(float3[] vs)
        {
            var mask = vs.Length - 1;
            var zero = float3.zero;
            for (var i = 0; i < Warmup; i++)
                SinkF += distance(vs[i & mask], zero);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += distance(vs[i & mask], zero);
            return ElapsedMs(t0);
        }

        // --- trig ------------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeSfastsineFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].sfastsine();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].sfastsine();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastsineFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].fastsine();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].fastsine();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeSfastcosineFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].sfastcosine();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].sfastcosine();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastcosineFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].fastcosine();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].fastcosine();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeSinRef(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += sin(xs[i & mask]);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += sin(xs[i & mask]);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeCosRef(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += cos(xs[i & mask]);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += cos(xs[i & mask]);
            return ElapsedMs(t0);
        }

        // --- fexp ------------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFexpFast(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += fexp(xs[i & mask]);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += fexp(xs[i & mask]);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFexpRef(float[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += exp(-xs[i & mask]);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += exp(-xs[i & mask]);
            return ElapsedMs(t0);
        }

        // --- log2int ---------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeLog2IntFast(int[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkI += xs[i & mask].log2int();
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkI += xs[i & mask].log2int();
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeLog2IntRef(int[] xs)
        {
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkI += (int)floor(log2(xs[i & mask]));
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkI += (int)floor(log2(xs[i & mask]));
            return ElapsedMs(t0);
        }

        // --- fastmodinv ------------------------------------------------------------

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeFastModInvFast(int[] xs)
        {
            const float mod = 7f;
            var invMod = 1f / mod;
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].fastmodinv(invMod, mod);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].fastmodinv(invMod, mod);
            return ElapsedMs(t0);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        static double TimeModRef(int[] xs)
        {
            const float mod = 7f;
            var mask = xs.Length - 1;
            for (var i = 0; i < Warmup; i++)
                SinkF += xs[i & mask].mod(mod);
            var t0 = Stopwatch.GetTimestamp();
            for (var i = 0; i < Iterations; i++)
                SinkF += xs[i & mask].mod(mod);
            return ElapsedMs(t0);
        }

        // --- helpers ---------------------------------------------------------------

        static double ElapsedMs(long startTimestamp) =>
            (Stopwatch.GetTimestamp() - startTimestamp) * 1000.0 / Stopwatch.Frequency;

        static void LogLine(Result r)
        {
            var fastNs = r.FastMs * 1e6 / Iterations;
            var refNs = r.RefMs * 1e6 / Iterations;
            Debug.Log($"[mathx FastMath Benchmark] {r.Name,-16} fast={r.FastMs,8:F2} ms ({fastNs,5:F1} ns/op)  ref={r.RefMs,8:F2} ms ({refNs,5:F1} ns/op)  speedup={r.Speedup,5:F2}x");
        }

        static float[] BuildPositiveRange(float min, float max)
        {
            var xs = new float[Samples];
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                xs[i] = min * pow(max / min, t);
            }
            return xs;
        }

        static float[] BuildRange(float min, float max)
        {
            var xs = new float[Samples];
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                xs[i] = lerp(min, max, t);
            }
            return xs;
        }

        static float[] BuildAngleRange()
        {
            var xs = new float[Samples];
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                xs[i] = lerp(-math.PI, math.PI, t);
            }
            return xs;
        }

        static int[] BuildIntRange(int min, int max)
        {
            var xs = new int[Samples];
            for (var i = 0; i < Samples; i++)
            {
                var t = i / (float)(Samples - 1);
                xs[i] = (int)lerp(min, max, t);
            }
            return xs;
        }

        static float3[] BuildFloat3Samples()
        {
            var vs = new float3[Samples];
            for (var i = 0; i < Samples; i++)
                vs[i] = new float3(i * 0.11f + 1f, i * 0.17f + 2f, i * 0.09f + 0.5f);
            return vs;
        }

        static float2[] BuildFloat2Samples(float[] xs)
        {
            var pairs = new float2[xs.Length];
            var mask = xs.Length - 1;
            for (var i = 0; i < xs.Length; i++)
                pairs[i] = new float2(xs[i], xs[(i * 7 + 3) & mask]);
            return pairs;
        }
        
        static float4[] BuildFloat4Samples(float[] xs)
        {
            var quads = new float4[xs.Length];
            var mask = xs.Length - 1;
            for (var i = 0; i < xs.Length; i++)
                quads[i] = new float4(xs[i], xs[(i * 7 + 3) & mask], xs[(i * 13 + 5) & mask], xs[(i * 17 + 11) & mask]);
            return quads;
        }
    }
}

#endif
