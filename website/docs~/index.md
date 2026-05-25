<div class="mathx-hero" markdown="0">
  <img class="mathx-hero__banner" src="assets/branding/banner-thin.png" alt="Unity.mathx — extension library for Unity.Mathematics" />
  <div class="mathx-hero__body">
    <img class="mathx-hero__logo" src="assets/branding/logo-256.png" alt="mathx logo" />
    <p class="mathx-hero__tagline">
      Fluent, shader-like extensions for <strong>Unity.Mathematics</strong> — noise, SDFs, fast math, and Burst job helpers in one <code>using static</code>.
    </p>
    <div class="mathx-hero__actions">
      <a href="getting-started/" class="md-button md-button--primary">Get started</a>
      <a href="api/" class="md-button">API reference</a>
      <a href="https://github.com/ltmx/Unity.mathx" class="md-button">GitHub</a>
    </div>
    <span class="mathx-hero__package">com.ltmx.mathematics.mathx</span>
  </div>
</div>

## Quick start

```cs
using static Unity.Mathematics.mathx;

float3 v = new float3(1, 2, 3);
return v.length().clamp(0, 10).normalize();
```

Every method lives on the single `mathx` partial class — one import and you're done.

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
    ```

See the [Fluent chains guide](guides/fluent-chains.md) for `.set(out x)` and when to break a chain.

## Feature overview

<div class="grid cards mathx-feature-grid" markdown="1">

-   __[Interpolation](guides/interpolation.md)__

    ---

    `smoothstep`, easing, `smin` / `smax`

-   __[Noise](guides/noise.md)__

    ---

    Simplex, Perlin, FBM, Worley, Voronoi

-   __[SDF](guides/sdf.md)__

    ---

    Primitives and CSG-style combinations

-   __[Fast math](guides/fast-math.md)__

    ---

    `fsqrt`, `fastsine`, approximations vs `math.*`

-   __[Jobify](guides/jobify.md)__

    ---

    Function pointers, parallel jobs, noise fill

-   __[Hashing](guides/hashing.md)__

    ---

    `xxhash32`, `hash01`, gradient hashes

-   __[Structs](guides/structs.md)__

    ---

    `bounds`, `ray`, `color`, `byte*`

</div>

## Install

Available on [OpenUPM](https://openupm.com/packages/com.ltmx.mathematics.mathx/) and via Git URL — see [Getting started](getting-started.md).

## Roadmap

- ✅ Fast functions, constants, Mathf translations
- ✅ Random, component logic, interpolation, matrices
- ✅ Noise, SDF, Jobify, hashing, vector builders
- ✅ Generic jobs and function iterators
