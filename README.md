![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity.mathx)
![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.mathx?color=blueviolet)
![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.mathx?color=success)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.mathx)

## Extension Library for Unity.Mathematics

Extension Library for [`Unity.Mathematics`](https://github.com/Unity-Technologies/Unity.Mathematics) <br>
& many useful methods to process mathematics !<br>
Package name : `com.ltmx.mathematics.mathx`

<a href="https://ko-fi.com/I2I0IMQA9">
  <img align="left" src="https://raw.githubusercontent.com/LTMX/Banners-And-Buttons/main/Support%20Me%20Kofi%20Banner%20Shader%20Graph%20Mastery.png" width="140px"/>
</a><br><br>


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

 - shader like syntax
 - namespace `Unity.Mathematics`
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
- [x] Add Fast Functions
- [x] Signed Distance Functions
- [ ] Complete Documentation `WIP`
- [ ] Jobify Class `WIP`
- [ ] Burst Compiled Function Pointers `WIP`
- [ ] Function Iterators `WIP`
- [ ] Geometry Processing

<br>

## LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.mathx/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.mathx/blob/master/LICENSE.md">Unity Companion License</a>)</p>
