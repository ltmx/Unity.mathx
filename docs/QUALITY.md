# Quality phase

## Automated tests

Edit Mode tests live in `Tests/` and run via the Unity Test Framework (NUnit).

| Suite | File | Coverage |
|-------|------|----------|
| Golden hash | `GoldenHashTests.cs` | `xxhash32`, `hash01`, `hashnp01` exact values |
| Golden noise | `GoldenNoiseTests.cs` | `simplex2`, `fbm2` regression + finiteness |
| Iteration | `IterationTests.cs` | `apply`, `forEach2D`, `applyfp` |
| Vector builders | `VectorBuilderTests.cs` | `fmin`, `clampfp`, `saturatefp` |
| Fast math | `FastMathAccuracyTests.cs` | tolerance vs `Unity.Mathematics` reference |
| Burst jobs | `BurstJobTests.cs` | function pointers + parallel jobs |

### Run locally

1. Add this package to a Unity project (or open `.ci/TestProject` after adding the local package reference).
2. Open **Window → General → Test Runner**.
3. Run **Edit Mode** tests for assembly `Mathematics.Mathx.Tests`.

Legacy menu shortcuts remain under **Tools → mathx** for quick manual smoke checks.

### Regenerate noise golden values

```bash
python .ci/scripts/golden_noise.py
```

Update expected values in `Tests/GoldenNoiseTests.cs` when the noise implementation intentionally changes.

## CI

Workflow: [`.github/workflows/tests.yml`](.github/workflows/tests.yml)

Uses [GameCI](https://game.ci/) with project path `.ci/TestProject`, which references the repo root package via `file:../../`.

### Required GitHub secrets

| Secret | Purpose |
|--------|---------|
| `UNITY_LICENSE` | Unity `.ulf` license file contents (personal license) |
| `UNITY_EMAIL` | Unity account email |
| `UNITY_PASSWORD` | Unity account password |

For Unity Pro, use `UNITY_SERIAL` instead of `UNITY_LICENSE` — see [GameCI activation docs](https://game.ci/docs/github/activation).

## IL2CPP and device validation (manual)

Automated CI runs Edit Mode tests and Burst compilation in the Editor. Before a release, validate on a target device:

1. Create or use a project with **Scripting Backend: IL2CPP** and **Burst** enabled.
2. Build a player for the target platform (Android, iOS, or standalone).
3. Exercise code paths that use:
   - `FunctionPointers` / `JobParallelFor` jobs
   - Noise field jobs (`FillNoise2D`)
   - Hash APIs used in runtime gameplay
4. Confirm no Burst discard warnings in the Editor console for shipped APIs.
5. Run **Tools → mathx → Test WIP Roadmap** once on the target Editor version before tagging.

Document any platform-specific issues in GitHub Issues before publishing to OpenUPM.
