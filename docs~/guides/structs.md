# Structs

Unity.Mathematics-friendly structs with implicit casts to/from `UnityEngine` types.

| Struct | Purpose |
|--------|---------|
| `bounds` | Axis-aligned box; implicit `Bounds` |
| `ray` | Ray; implicit `Ray` |
| `color` | RGBA; implicit `Color` / `Color32` |
| `byte1` … `byte4` | Packed bytes; useful for image export (e.g. QOI) |

## Example

```cs
using Unity.Mathematics;

bounds b = new bounds(float3.zero, float3.one);
UnityEngine.Bounds unityBounds = b;  // implicit

color c = new color(1, 0, 0, 1);
UnityEngine.Color uc = c;
```

## API

- [bounds](../api/api/metadata/Unity.Mathematics.bounds.html)
- [ray](../api/api/metadata/Unity.Mathematics.ray.html)
- [color](../api/api/metadata/Unity.Mathematics.color.html)
- [byte4](../api/api/metadata/Unity.Mathematics.byte4.html)
