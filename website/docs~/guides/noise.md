# Noise

Procedural noise for textures, terrain, and VFX. Sources live in `package/Runtime/Noise/`.

## 2D / 3D primitives

```cs
using static Unity.Mathematics.mathx;

float2 uv = ...;
float n = uv.simplex2();
float p = uv.perlin2();
float w = uv.worley2();
```

3D counterparts: `simplex3`, `perlin3`, `worley3`, etc.

## Fractal Brownian motion

```cs
float f = uv.fbm2(octaves: 4, lacunarity: 2f, gain: 0.5f);
```

## Jobs

Fill a `NativeArray<float>` on a grid with [Jobify](jobify.md):

```cs
output.FillNoise2D(size, origin, spacing, JobParallelFor.NoiseKind.Simplex2);
```

## Golden tests

Noise output is regression-tested in `package/Tests/GoldenNoiseTests.cs`. After intentional algorithm changes:

```bash
python package/.ci/scripts/golden_noise.py
```

Then update expected values in the test file.

## API

[Noise-related API](../api/api/metadata/Unity.Mathematics.mathx.html)
