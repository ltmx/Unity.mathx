# Quality & testing

## Automated tests

Edit Mode tests live in `package/Tests/` and run via the Unity Test Framework (NUnit).

| Suite | File | Coverage |
|-------|------|----------|
| Golden hash | `GoldenHashTests.cs` | `xxhash32`, `hash01`, `hashnp01` exact values |
| Golden noise | `GoldenNoiseTests.cs` | `simplex2`, `fbm2` regression + finiteness |
| Iteration | `IterationTests.cs` | `apply`, `forEach2D`, `applyfp` |
| Vector builders | `VectorBuilderTests.cs` | `fmin`, `clampfp`, `saturatefp` |
| Fast math | `FastMathAccuracyTests.cs` | tolerance vs `Unity.Mathematics` reference |
| Burst jobs | `BurstJobTests.cs` | function pointers + parallel jobs |

### Run locally

Unity does **not** auto-discover tests inside UPM packages. In your **host project** `Packages/manifest.json`, add:

```json
{
  "dependencies": {
    "com.unity.test-framework": "1.4.5",
    "com.ltmx.mathematics.mathx": "…"
  },
  "testables": [
    "com.ltmx.mathematics.mathx"
  ]
}
```

1. Add this package to a Unity project with `testables` configured.
2. Open **Window → General → Test Runner**.
3. Run **Edit Mode** tests for assembly `Mathematics.Mathx.Tests`.

Legacy menu shortcuts remain under **Tools → mathx** for quick manual smoke checks.

### Regenerate noise golden values

```bash
python package/.ci/scripts/golden_noise.py
```

Update expected values in `package/Tests/GoldenNoiseTests.cs` when the noise implementation intentionally changes.

## IL2CPP and device validation (manual)

Before a release, validate on a target device:

1. Create or use a project with **Scripting Backend: IL2CPP** and **Burst** enabled.
2. Build a player for the target platform.
3. Exercise code paths that use function pointers, parallel jobs, and noise fill jobs.
4. Confirm no Burst discard warnings in the Editor console for shipped APIs.

Document platform-specific issues in GitHub Issues before publishing to OpenUPM.
