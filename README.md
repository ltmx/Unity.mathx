![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

<!-- ![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity.mathx) -->
![GitHub package.json version](https://img.shields.io/github/package-json/v/LTMX/Unity.mathx?color=blueviolet)
![GitHub top language](https://img.shields.io/github/languages/top/LTMX/Unity.mathx?color=success)
![GitHub](https://img.shields.io/github/license/LTMX/Unity.mathx)
[![openupm](https://img.shields.io/npm/v/com.ltmx.mathematics.mathx?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.ltmx.mathematics.mathx/)

<br>

## Extension Library for [`Unity.Mathematics`](https://github.com/Unity-Technologies/Unity.Mathematics)
& many useful methods !<br><br>
Package name : `com.ltmx.mathematics.mathx`

<!--
<a href="https://ko-fi.com/I2I0IMQA9">
  <img align="left" src="https://raw.githubusercontent.com/LTMX/Banners-And-Buttons/main/Support%20Me%20Kofi%20Banner%20Shader%20Graph%20Mastery.png" width="140px"/>
</a><br><br>
-->

## Chained Method Syntax
```cs
return anyVector.length().clamp(0, 10).cos().sq().cube().sum().cmul().rotate(anyQuaternion).clint().div(3.2f).rcp();
```

## Using Declaration
```cs
using static Unity.Mathematics.mathx;
```

# New in 1.3.1

## Features
- Matrix Truncation => `float3x2(float4x4)` // Truncates the input matrix to the desired size... can also be written as : `float4x4.f3x2()`
```c#
/// sets the value of x to f and returns f // Useful for modifying a variable in line.
public static T set<T>(this T f, out T x) {  x = f; return f; }

// Example :
float3 x = new float3(1,1,1);

// here x is set before computing lengthsq()
var x = x.dim(4.2f).shuffle().set(out x).lengthsq() + x; 

// we would have to write two lines instead
x = x.dim(4.2f).shuffle();
x = x.lengthsq() + x;
```

- Burst Compiled Function Pointers

 ## New Methods
```c#
anyType.dim(otherType) => anyType* otherType // to add functionality missing from internal operator overloads // named dim to not confuse with mul()
anyType.greater(otherType) => anyType > otherType
anyType.less(otherType) =>  anyType < otherType
anyType.greatereq(otherType) =>  anyType >= otherType
anyType.lesseq(otherType) =>  anyType <= otherType
anyType.eq(otherType) =>  anyType == otherType
anyType.neq(otherType) =>  anyType != otherType
randseed(seed)  => random float generated from a seed  // internally : Random.Init(seed).Nextfloat()
randseed2(seed) => random float2 generated from a seed // internally : Random.Init(seed).Nextfloat()
randseed3(seed) => random float3 generated from a seed // internally : Random.Init(seed).Nextfloat()
randseed4(seed) => random float4 generated from a seed // internally : Random.Init(seed).Nextfloat()
anyType.append()
anyType.m2n1() => anyType* 2 - 1 // remaps anything from [0, 1] to [-1, 1]
quaternion generation functions
matrix generation functions
transformation functions
dot() // for int types
value.lerp(MatrixA, MatrixB) // functionality to interpolate any matrix
anyType.dim(otherType) => anyType * otherType // to add functionality for missing from operator overloads // 'dim' to not confuse with mul()
anyType.div(otherType) => anyType / otherType
anyType.add(otherType) => anyType + otherType
anyType.sub(otherType) => anyType - otherType
anyType.shuffle() // only for float2, float3 and float4
anyType.hash() // math.hash(anyType)
type generation methods float4(), float2(), float4x4(), etc
asuint() // new overloads
asbool() // new overloads
```

## Fixed
```c#
rand(float)
rand(float float)
rand(float4 float)
randseed()
Burst Compiled Function Pointers
```

## New Structs
```c#
struct byte1
```

## Structs Updates
```c++
struct byte1;  // Added Conversions, constructors / implicit and explicit casts / operator overloads + (New)
struct byte2;  // Added Conversions, constructors / implicit and explicit casts / operator overloads + Using byte1 as unit type
struct byte3;  // Added Conversions, constructors / implicit and explicit casts / operator overloads + Using byte1 as unit type
struct byte4;  // Added Conversions, constructors / implicit and explicit casts / operator overloads + Using byte1 as unit type
struct bounds; // Added methods : Corners() , FaceCenters
```

## Renamings
```c#
const Sqrt2Over2 => SQRT2_2
changed all double precision constant suffix from _D to _DBL for consistency
removed duplicate constants
```

## Random Updates
- Fixed Broken Documentation
- Added Tons of Documentation

## WIP
- Multidimensional Noise Function
- Signed Distance Functions
- SDF Processing Functions
- Hashing Functions
- Function Iterators
- Generic Jobs


# Guidelines

 - All code must adhere to the `Unity.Mathematics` namespace (for ease of use, no need additional "using" declarations !)
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
    

# Install
#### Method 1 : <br>
1. Copy Git Package URL : `https://github.com/LTMX/Unity.mathx.git`
2. In Unity : `Window > Package Manager > Add Package From Git URL`

#### Method 2 : (Not Up To Date) <br>
1. Download the package in *releases*,
2. Unzip the file
3. Unity : `Window > Package Manager > Add Package From Disk`
4. Select the `.json` file inside the unzipped package


# Roadmap
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
  ```c++
  struct bounds; // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Bounds")
  struct ray;    // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Ray")
  struct color;  // UnityEngine translation compatible with Unity.Mathematics (implicit cast to "UnityEngine.Color")
  struct byte4;  // Useful for Color32 to byte conversion, Useful for image file export (implicit cast to "UnityEngine.Color32") //For Unity.QOI
  struct byte3;  // For Unity.QOI
  struct byte2;
  struct byte1;
  ```
  
## Method List (from 1.3.0... needs updating)
```purple
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
