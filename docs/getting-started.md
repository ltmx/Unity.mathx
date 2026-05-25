# Getting started

<div class="mathx-page-header" markdown="1">
<img src="assets/branding/logo-128.png" alt="mathx" />
<div>

Install **Unity.mathx** in a few minutes. Requires Unity.Mathematics and Burst for job helpers.

</div>
</div>

## Requirements

- Unity 2020.3+ (LTS recommended)
- [com.unity.mathematics](https://docs.unity3d.com/Packages/com.unity.mathematics@latest) (declared in `package.json`)
- [com.unity.burst](https://docs.unity3d.com/Packages/com.unity.burst@latest) for Jobify and fast paths

## Install

### Git URL (recommended)

1. Copy: `https://github.com/LTMX/Unity.mathx.git`
2. Unity: **Window → Package Manager → + → Add package from git URL**

### OpenUPM

```bash
openupm add com.ltmx.mathematics.mathx
```

### Local disk

Download a [release](https://github.com/LTMX/Unity.mathx/releases) zip, then **Add package from disk** and select `package.json`.

## Usage

Add one import at the top of your file:

```cs
using static Unity.Mathematics.mathx;
```

All extension methods chain off `float`, `float2`, `float3`, `float4`, matrices, and the custom structs.

```cs
using Unity.Mathematics;
using static Unity.Mathematics.mathx;

public float Example(float3 position, quaternion rotation)
{
    return position.rotate(rotation).lengthsq().sqrt().saturate();
}
```

## Burst & jobs

Many APIs are Burst-friendly. For parallel workloads, see [Jobify & jobs](guides/jobify.md).

!!! tip "Test in your project"
    Package tests require `"testables": ["com.ltmx.mathematics.mathx"]` in your project `Packages/manifest.json`. See [Quality](QUALITY.md).

## Next steps

- [Fluent chains](guides/fluent-chains.md) — chaining, `.set(out x)`, readability
- [API reference](api/index.html) — full method list from XML docs
- [Contributing](contributing.md) — naming and file layout conventions
