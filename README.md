# Unity.mathx   [![Documentation](https://img.shields.io/badge/docs-mathx-blueviolet?style=flat)](https://ltmx.github.io/Unity.mathx/) [![Donate](https://img.shields.io/badge/Donate-PayPal-3A8CA?style=flat&logo=paypal&logoColor=white)](https://www.paypal.me/ltmx/5usd)



![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

<p align="center">
  <a href="https://ltmx.github.io/Unity.mathx/">
    <img alt="Read the documentation" src="https://img.shields.io/badge/📖_Documentation-ltmx.github.io%2FUnity.mathx-7b4ae2?style=for-the-badge&logo=readthedocs&logoColor=white">
  </a>
  &nbsp;
  <a href="https://ltmx.github.io/Unity.mathx/api/">
    <img alt="API reference" src="https://img.shields.io/badge/API_Reference-mathx-9d6dff?style=for-the-badge">
  </a>
</p>

<p align="center">
  <strong>Guides</strong> · <a href="https://ltmx.github.io/Unity.mathx/getting-started/">Getting started</a> ·
  <a href="https://ltmx.github.io/Unity.mathx/guides/fluent-chains/">Fluent chains</a> ·
  <a href="https://ltmx.github.io/Unity.mathx/guides/noise/">Noise</a> ·
  <a href="https://ltmx.github.io/Unity.mathx/guides/sdf/">SDF</a> ·
  <a href="https://ltmx.github.io/Unity.mathx/guides/jobify/">Jobify</a>
</p>

<br>

![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.mathx?color=blueviolet&style=flat)
[![openupm](https://img.shields.io/npm/v/com.ltmx.mathematics.mathx?label=openupm&style=flat&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.ltmx.mathematics.mathx)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.mathx?style=flat)
[![Made for Unity](https://img.shields.io/badge/Made%20for-Unity-57b9d3.svg?style=flat&logo=unity&color=blueviolet)](https://unity3d.com)


<!--![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.mathx?color=success&style=flat)-->




<br>

# Extension Library for [Unity.Mathematics](https://github.com/Unity-Technologies/Unity.Mathematics) & quality of life improvements !

<br>

<!--
<a href="https://ko-fi.com/I2I0IMQA9">
  <img align="left" src="https://raw.githubusercontent.com/LTMX/Banners-And-Buttons/main/Support%20Me%20Kofi%20Banner%20Shader%20Graph%20Mastery.png" width="140px"/>
</a><br><br>
-->

### Package name

> [!NOTE]\
> 
> ```ruby
> com.ltmx.mathematics.mathx
> ```


# ⬇️ Install
#### Method 1 : <br>
1. Copy Git Package URL : `https://github.com/LTMX/Unity.mathx.git`
2. In Unity : `Window > Package Manager > Add Package From Git URL`

#### Method 2 : <br>
1. Download the package in *releases*
2. Unity : `Window > Package Manager > Add Package From Disk`
3. Select the `package.json` file inside the unzipped package

<br>

## #️⃣ Usage
```cs
using static Unity.Mathematics.mathx;
```
<br>

## ♾ Linq-Style Syntax
```cs
return anyVector.length().clamp(0, 10).cos().sq().cube().rotate(anyQuaternion).clint().div(3.2f).rcp().mul(3.2f).sum();
```

<br>

## 📈 A Few Neat Features

```c#
// Example
float3 x = new float3(1,1,1);

// here x is set before computing lengthsq()
var x = x.mult(4.2f).shuffle().set(out x).lengthsq() + x;

// we would have to write two lines instead
x = x.div(4.2f).shuffle();
x = x.lengthsq() + x;

bool4.any(); // returns true if any component is true // or-gate
bool4.all(); // returns true if all components are true // and-gate
```

<br>

# 🏛 Roadmap
- [x] Fast Functions
- [x] Constants (PI, HPI, EULER, TAU, and `many scientific constants`
- [x] `Mathf` function implementations missing from `Unity.Mathematics`
- [x] Random Extensions (`Random.range` and others)
- [x] Component based functions (`cmax`, `cmin`, `cmul`, `cmaxAxis`, `cminAxis`, `sum`)
- [x] Signed Distance Functions
- [x] Component based logic (`any`, `all`, `select`, `approx`, `odd`, `even`, `isnan`, `anynan`)
- [x] Multidimentional Array data accessors => `anyfloat4[,,].Get(anyInt3)`
- [x] Interpolation Functions (`InOutCubic`, `smoothstep`, `smoothstep11`, `smoothstep9`, and others)
- [x] `smoothmin`, `smoothmax`
- [x] Shorthands (`3D Directions`, `2D Directions`, and others)
- [x] Data Construction (`append`, `float2.xyzw()`, matrix construction, etc)
- [x] Data Conversion (`anyColortArray.tofloat4Array()`, and others)
- [x] Noise Functions (`Simplex`, `Perlin`, `Worley`, `Layered`, `Voronoi`)
- [x] Job Helpers
- [x] Burst Compiled Function Pointers
- [x] Function Iterators (prevents nested loops)
- [x] Hashing Functions
- [x] Vector Function Builders
- [x] Generic Jobs

<br>

## 🎇 Structs
  ```c#
  struct bounds; // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Bounds")
  struct ray;    // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Ray")
  struct color;  // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Color")
  struct byte4;  // Useful for Color32 to byte conversion, Useful for image file export (implicit cast to "UnityEngine.Color32") //For Unity.QOI
  struct byte3;  // For Unity.QOI
  struct byte2;
  struct byte1;
  ```

<br>

## API & method reference

The full searchable API (thousands of overloads) is generated from XML docs:

**[Browse API →](https://ltmx.github.io/Unity.mathx/api/)**

Topic guides: [fluent chains](https://ltmx.github.io/Unity.mathx/guides/fluent-chains/), [noise](https://ltmx.github.io/Unity.mathx/guides/noise/), [SDF](https://ltmx.github.io/Unity.mathx/guides/sdf/), [Jobify](https://ltmx.github.io/Unity.mathx/guides/jobify/), and more on the [docs home](https://ltmx.github.io/Unity.mathx/).


## Tests

Edit Mode tests ship in `Tests/` (Unity Test Framework). Package tests require `"testables": ["com.ltmx.mathematics.mathx"]` in your **project** `Packages/manifest.json` (plus `com.unity.test-framework`). Then open **Window → General → Test Runner → Edit Mode**.

See [docs~/QUALITY.md](docs~/QUALITY.md) or the [Quality page](https://ltmx.github.io/Unity.mathx/quality/) for setup, golden-value regeneration, and IL2CPP validation.

<br>

# 🌱 Contribute !

## 👉 Guidelines
 - All methods should exist in the `Unity.Mathematics.mathx` class (To prevent multiple using declarations)
 - All Methods should follow a lower case syntax (shader like syntax)
 - All methods names should be as short as possible while conserving their meaning or naming convension
 - Everything must be Open Source
 - Credits should (if the author can be found) figure above code snipets or in the file header (if reusing existing code)
 - file mames should follow this convention : mathx.<usage>.<differentiation>
      Example : mathx.interpolation.common (common methods for interpolation) or mathx.logix.floatx (float type related logic functions)
    - File names for base types such as `bounds` or `byte2` should only have their type as a title : bounds.cs // byte2.cs
 - Every method should be static (if applicable)
 - Dependencies should not exist if applicable
    - Code must be rewritten and optimized for Unity.Mathematics, compatibility checked
    - Unification is key : if some functions are already available in math or Unity.Mathematics.math (sometimes under another name), use them !
 - Documentation should be inherited from Unity.Mathematics.math methods for direct extension method translations

<br>

## 📜 LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.mathx/blob/master/LICENSE.md">License</a>)</p>
