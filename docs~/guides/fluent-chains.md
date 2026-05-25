# Fluent chains

mathx methods return the same vector/scalar type they operate on, so you can chain calls like GLSL or HLSL.

## Basic chaining

```cs
using static Unity.Mathematics.mathx;

float3 v = position.sub(origin).normalize().mul(scale).clamp(min, max);
```

Most families support `float`, `float2`, `float3`, and `float4` (and many also support `double*` / `int*` variants).

## Side effects with `.set(out x)`

Update a variable mid-chain without splitting lines:

```cs
float3 x = new float3(1, 1, 1);

var result = x.mult(4.2f).shuffle().set(out x).lengthsq() + x;
// x is updated before lengthsq(); result uses the new x
```

=== "With `.set`"

    ```cs
    var result = x.mult(4.2f).shuffle().set(out x).lengthsq() + x;
    ```

=== "Without"

    ```cs
    x = x.div(4.2f).shuffle();
    x = x.lengthsq() + x;
    ```

## Component logic

```cs
bool4 flags = ...;
if (flags.any()) { /* any component true */ }
if (flags.all()) { /* all components true */ }
```

## When to break a chain

- When debugging a specific step — assign to a named local.
- When reusing an intermediate value in multiple expressions.
- When mixing Burst jobs / function pointers (see [Jobify](jobify.md)) — chains are for synchronous scalar/vector math.

## API

Browse [mathx members in the API reference](../api/api/metadata/Unity.Mathematics.mathx.html).
