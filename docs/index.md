# Unity.mathx

![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

Extension library for [Unity.Mathematics](https://github.com/Unity-Technologies/Unity.Mathematics) with fluent, shader-like syntax, noise, SDFs, fast math, and Burst job helpers.

[:octicons-download-24: Install](getting-started.md){ .md-button }
[:octicons-code-24: API Reference](api/index.html){ .md-button .md-button--primary }
[:octicons-mark-github-24: GitHub](https://github.com/LTMX/Unity.mathx){ .md-button }

## Package

```ruby
com.ltmx.mathematics.mathx
```

Available on [OpenUPM](https://openupm.com/packages/com.ltmx.mathematics.mathx/) and [GitHub](https://github.com/LTMX/Unity.mathx).

## Quick start

```cs
using static Unity.Mathematics.mathx;

float3 v = new float3(1, 2, 3);
return v.length().clamp(0, 10).normalize();
```

Every method lives on the single `mathx` partial class — one `using static` and you're done.

## Fluent chains

=== "mathx"

    ```cs
    return anyVector
        .length().clamp(0, 10).cos().sq()
        .rotate(anyQuaternion).div(3.2f).rcp().mul(3.2f).sum();
    ```

=== "Verbose"

    ```cs
    anyVector = math.clamp(math.length(anyVector), 0, 10);
    anyVector = math.cos(anyVector);
    anyVector = anyVector * anyVector;
    anyVector = math.mul(math.rotate(anyQuaternion, anyVector), 1f / 3.2f);
    // ...
    ```

See the [Fluent chains guide](guides/fluent-chains.md) for `.set(out x)` and when to break a chain.

## Feature overview

| Area | Highlights |
|------|------------|
| [Interpolation](guides/interpolation.md) | `smoothstep`, easing, `smin` / `smax` |
| [Noise](guides/noise.md) | Simplex, Perlin, FBM, Worley, Voronoi |
| [SDF](guides/sdf.md) | Primitives, CSG-style combinations |
| [Fast math](guides/fast-math.md) | `fsqrt`, `fastsine`, approximations vs `math.*` |
| [Jobify](guides/jobify.md) | Function pointers, parallel jobs, noise fill |
| [Hashing](guides/hashing.md) | `xxhash32`, `hash01`, gradient hashes |
| [Structs](guides/structs.md) | `bounds`, `ray`, `color`, `byte*` |

## Roadmap

- [x] Fast functions, constants, Mathf translations
- [x] Random, component logic, interpolation, matrices
- [x] Noise, SDF, Jobify, hashing, vector builders
- [x] Generic jobs and function iterators

## Links

- [Getting started](getting-started.md)
- [Quality & testing](QUALITY.md)
- [Contributing](contributing.md)
- [API reference](api/index.html)
