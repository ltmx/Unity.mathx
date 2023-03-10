![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity.mathx)
![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.mathx?color=blueviolet)
![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.mathx?color=success)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.mathx)

## Extension Library for Unity.Mathematics

Extension Library for [`Unity.Mathematics`](https://github.com/Unity-Technologies/Unity.Mathematics) <br>
& many useful methods to process mathematics !<br>
Package name : `com.ltmx.mathematics.mathx`

<!--
<a href="https://ko-fi.com/I2I0IMQA9">
  <img align="left" src="https://raw.githubusercontent.com/LTMX/Banners-And-Buttons/main/Support%20Me%20Kofi%20Banner%20Shader%20Graph%20Mastery.png" width="140px"/>
</a><br><br>
-->

## Exension Method Syntax
*Old Code :*
```C#
var v1 = math.cos(math.clamp(f.magnitude, 0, 10));
return v1 * v1;
```
*New Code :*
```C#
return f.length().clamp(0, 10).cos().sq();
```

## Using Declaration
```C#
using static Unity.Mathematics.mathx;
```

## Guidelines

 - namespace `Unity.Mathematics` (for ease of use, no need additional "using" declarations !)
 - static class `Unity.Mathematics.mathx`


## Install
#### Method 1 : <br>
1. Copy Git Package URL : `https://github.com/LTMX/Unity.mathx.git`
2. In Unity : `Window > Package Manager > Add Package From Git URL`

#### Method 2 : <br>
1. Download the package in *releases*,
2. Unzip the file
3. Unity : `Window > Package Manager > Add Package From Disk`
4. Select the `.json` file inside the unzipped package


## Roadmap
- [x] Fast Functions
- [x] Constants (PI, HPI, EULER, TAU, 
- [x] `Mathf` functions missing from `Unity.Mathematics`
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
- [ ] Noise Functions `WIP` (`Simplex`, `Perlin`, `Whorley`, `Layered`, `Voronoi`)
- [ ] Documentation `80% Complete``
- [ ] Job Helpers `WIP`
- [ ] Burst Compiled Function Pointers `WIP`
- [ ] Function Iterators (prevents nested loops) `WIP`
- [ ] Mesh Processing

## New Structs
```C#
struct bounds // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Bounds")
```
```C#
struct ray    // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Ray")
```
```C#
struct color  // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Color")
```
```C#
struct byte4  // useful for Color to byte conversion for image file export (implicit cast to "UnityEngine.Color32")
```
```C#
struct byte3
```
```C#
struct byte2
```

<br>

## LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.mathx/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.mathx/blob/master/LICENSE.md">Unity Companion License</a>)</p>
