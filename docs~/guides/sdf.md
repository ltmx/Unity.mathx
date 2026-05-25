# Signed distance fields

SDF primitives and operations for rendering, collision, and modeling. Implementation: `Runtime/SDF/`.

## Primitives

```cs
using static Unity.Mathematics.mathx;

float3 p = ...;
float d = p.sdSphere(1f);
float box = p.sdBox(float3(1), float3(0.5f));
float torus = p.sdTorus(0.5f, 0.2f);
```

Many shapes are available: capsule, cylinder, cone, hex prism, octahedron, etc.

## Combining fields

Use smooth min/max from [Interpolation](interpolation.md) to union, subtract, or blend SDFs:

```cs
float scene = t.smin(d1, d2);
```

See `SDF.PrimitiveCombination.cs` and `SDF.DistanceOperations.cs` for domain-specific helpers.

## 2D

2D variants live in `SDF2.cs` (`udTriangle`, `udQuad`, …).

## API

[SDF methods on mathx](../api/api/metadata/Unity.Mathematics.mathx.html)
