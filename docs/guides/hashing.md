# Hashing

Deterministic hashes for procedural content, IDs, and sampling.

## Core APIs

```cs
using static Unity.Mathematics.mathx;

uint h = coords.xxhash32(seed);
float u = coords.hash01();       // 0..1
float3 np = coords.hashnp01();   // unit-ish vector
```

## Gradient hashes

Gradient noise helpers live in `mathx.hash.gradient.cs` — used internally by noise and available for custom fields.

## Golden tests

Exact hash outputs are locked in `GoldenHashTests.cs`. Change expected values only when the algorithm intentionally changes.

## API

[Hash members](../api/api/metadata/Unity.Mathematics.mathx.html)
