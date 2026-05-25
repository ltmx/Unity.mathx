# Fast math

Approximations and intrinsics-backed paths in `Runtime/FastMath/` for hot loops.

## Examples

```cs
using static Unity.Mathematics.mathx;

float invLen = x.fsqrt();        // fast inverse sqrt style path
float r = x.fastrp();            // fast reciprocal (where applicable)
float s = x.fastsine();          // sine approximation
float a = y.fastatan2(x);        // fast atan2
```

## Accuracy

`FastMathAccuracyTests.cs` compares fast paths against `Unity.Mathematics` reference implementations within configured tolerances.

!!! warning "Know your error budget"
    Use fast variants in inner loops (particles, mesh deform, audio DSP). For critical precision (finance, long integrators), prefer `math.*` reference functions.

## Burst

Many fast paths use Burst intrinsics (`Unity.Burst.Intrinsics`) where SIMD helps.

## API

[Fast math members](../api/api/metadata/Unity.Mathematics.mathx.html)
