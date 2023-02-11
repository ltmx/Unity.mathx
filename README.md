# Unity.Mathematics Extensions

![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity-Mathematics-Extensions)
![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.Mathematics-Extensions?color=blueviolet)
![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.Mathematics-Extensions?color=success)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.Mathematics-Extensions)

Extension Library for [`Unity.Mathematics`](https://github.com/Unity-Technologies/Unity.Mathematics) <br>
& many useful methods to process mathematics !<br>
Package name : `com.ltmx.unitymathematicsextensions`

<a href="https://ko-fi.com/I2I0IMQA9">
  <img align="left" src="https://raw.githubusercontent.com/LTMX/Banners-And-Buttons/main/Support%20Me%20Kofi%20Banner%20Shader%20Graph%20Mastery.png" width="140px"/>
</a><br><br>


## Exension Method Syntax
*Old Code :*
> ```C#
> var v1 = math.cos(math.clamp(f.magnitude, 0, 10));
> return v1 * v1;
> ```
*New Code :*
> ```C#
> return f.length().clamp(0, 10).cos().sqr();
> ```


## Install
#### Method 1 : <br>
1. Copy Git Package URL : `https://github.com/LTMX/Unity.Mathematics-Extensions.git`
2. In Unity : `Window > Package Manager > Add Package From Git URL`

#### Method 2 : <br>
1. Download the package in *releases*,
2. Unzip the file
3. Unity : `Window > Package Manager > Add Package From Disk`
4. Select the `.json` file inside the unzipped package


## Roadmap
- [x] Add Fast Functions
- [ ] Complete Documentation `WIP`
- [ ] Signed Distance Functions `WIP`
- [ ] Jobify Class `WIP`

<br>

## LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md">Unity Companion License</a>)</p>
