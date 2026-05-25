# Interpolation

Smooth blending, easing, and soft min/max live under `mathx.interpolation.*`.

## Smoothstep family

```cs
using static Unity.Mathematics.mathx;

float t = 0.5f;
float s = t.smoothstep();           // 0..1 input
float s2 = value.smoothstep(a, b);  // range remap + smooth Hermite
float s3 = t.smootherstep();        // quintic smoothstep
```

## Easing

Penner-style easing functions are available as extension methods:

```cs
float x = t.easeInOutCubic();
float y = t.easeOutElastic();
```

See [API: interpolation members](../api/api/metadata/Unity.Mathematics.mathx.html) for the full easing list.

## Soft min / max

Blend between values without hard corners:

```cs
float d = t.smin(a, b);   // smooth minimum
float m = t.smax(a, b);   // smooth maximum
```

Variants (`smin_exp`, `smin_polynomial`, …) trade sharpness vs cost.

## Related

- [Fluent chains](fluent-chains.md)
- [Fast math](fast-math.md) — approximations used in some smooth kernels
