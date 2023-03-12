![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity.mathx)
![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.mathx?color=blueviolet)
![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.mathx?color=success)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.mathx)
[![openupm](https://img.shields.io/npm/v/com.ltmx.mathematics.mathx?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.ltmx.mathematics.mathx/)

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
- [ ] Documentation `80% Complete`
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
  
## Method List
```C#
// most methods have at least a dozen overloads
asint asbool asfloat asdouble ascolor asfloat4 asfloat3 toVectorList 
tofloatList toColorList tocolorList toColorArray tocolorArray tofloat4List
tofloat3List tofloat4Array tofloat3Array toVectorArray tofloatArray
toVectorIE tofloatIE cast List xx xxx xxxx append xy xyz xyzw 
f4x4 f4x3 f4x2 f3x4 f3x3 f3x2 f2x4 f2x3 f2x2 
b4x4 b4x3 b4x2 b3x4 b3x3 b3x2 b2x4 b2x3 b2x2 
i4x4 i4x3 i4x2 i3x4 i3x3 i3x2 i2x4 i2x3 i2x2 
u4x4 u4x3 u4x2 u3x4 u3x3 u3x2 u2x4 u2x3 u2x2 
fcos veryFastCos ultraFastCos CosLoop SinLoop sfcos fsqrt fdistance flength 
log2int fastmodinv mod frac fexp sfastsine sfastcosine fastsine fastcosine 
smootherstep smoothstepcos eerp uneerp smoothstep unlerp lerp lerpAngle 
remap step smin smax smax_exp smax_exp2 smax_expOP smin_exp smin_pow 
smin_root smin_polynomial smin_quadratic smin_cubic smin_factor 
smin_cubic_factor smin_N_factor easeInSine easeOutSine easeInOutSine 
easeInQuad easeOutQuad easeInOutQuad easeInCubic easeOutCubic easeInOutCubic 
easeInQuart easeOutQuart easeInOutQuart easeInQuint easeOutQuint easeInOutQuint 
easeInExpo easeOutExpo easeInOutExpo easeInCirc easeOutCirc easeInOutCirc 
easeInBack easeOutBack easeInOutBack easeInElastic easeOutElastic 
easeInOutElastic easeInBounce easeOutBounce easeInOutBounce smooth 
smoothstepD smooth5 smooth5D smooth7 smooth7D smooth9 smooth9D smooth11 
smooth11D smoothD smoother7D smoothdamp anglerad angledeg fastangle 
straightsignedangle preciseangle signedangle fastatan2 rotate rotateAxisAngle 
rotateRad rotateDeg quaternion sign abs sum cmul inv neg rcp pow sq 
cube pow4 pow5 exp nexp exp2 exp10 ln log2 log10 any all select approx 
odd even get anynan isnan isgreaterthan init rand varyrand addrand 
randomint randomInSphere randomInCircle randomDir3D randomDir2D 
randomrotation round rint clamp min max ceil clint floor flint saturate 
npsaturate p n under1 cmax cmin cmaxAxis cminAxis sin cos tan sec cot 
csc asin acos atan atan2 acot asec acsc sin2 cos2 tan2 sec2 deg rad 
cossin sincos sinh cosh tanh sech coth csch acosh asinh atanh acoth 
asech acsch norm normsafe distance distancesq cross orthonormalize 
length lengthsq sqrt cbrt rcbrt rsqrt dot reflect refract project 
projectsafe repeat pingpong SampleParabola matrix inverse float3x4 
rotation translation transform mul sub add mult div transpose 
openSimplex2_ImproveXY openSimplex2SDerivatives_ImproveXY byte2 
hash hashwide byte3 byte4 color shuffle gammatolinear lineartogama 
movetowards Erf Erfc ErfInv ErfcInv GammaLn Gamma DiGamma DiGammaInv
```
<br>

## LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.mathx/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.mathx/blob/master/LICENSE.md">Unity Companion License</a>)</p>
