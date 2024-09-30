# Unity.mathx   [![Donate](https://img.shields.io/badge/Donate-PayPal-3A8CA?style=flat&logo=paypal&logoColor=white)](https://www.paypal.me/ltmx/5usd)



![Banner](https://raw.githubusercontent.com/LTMX/Unity.mathx/master/.branding/LTMX_Unity_Mathematics_Mathx_Github_Banner_Thin.png)

<!-- ![GitHub repo size](https://img.shields.io/github/repo-size/LTMX/Unity.mathx) -->
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
- [ ] Noise Functions `WIP` (`Simplex`, `Perlin`, `Whorley`, `Layered`, `Voronoi`)
- [ ] Job Helpers `WIP`
- [ ] Burst Compiled Function Pointers `WIP 80%`
- [ ] Function Iterators (prevents nested loops) `WIP 50%`
- [ ] Hashing Functions `WIP 80%`
- [ ] Vector Function Builders `WIP 50%`
- [ ] Generic Jobs `WIP 50%`
- [ ] Mesh Processing `WIP 0%`

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

##  Method List
```ruby
// most methods have at least a dozen overloads

fcos() veryFastCos() ultraFastCos() CosLoop() SinLoop() sfcos() fsqrt()
fdistance() flength() log2int() fastmodinv() fexp() sfastsine() sfastcosine()
fastsine() fastcosine() anglerad() angledeg() fastangle() straightsignedangle()
preciseangle() signedangle() signedanglethis() fastatan2() sign() abs() mod()
frac() csum() cmul() inv() neg() rcp() pow() sq() cube() pow4() pow5() sqrt()
cbrt() rcbrt() rsqrt() m2n1() add() sub() div() cycle() swapx() swapy() swapz()
swapw() chgsign() saturate() snap() bitwave() bitwave2() triwave() set()
quaternion() conjugate() inverse() dot() length() lengthsq() norm() normsafe()
unitexp() exp() unitlog() log() mul() nlerp() slerp() hash() hashwide()
forward() toColorArray() tocolorArray() tofloat4List() tofloat3List()
tofloat4Array() tofloat3Array() toVectorArray() tofloatArray() CopyFrom()
asint() asbool() asfloat() asdouble() asuint() ascolor() asColor() asfloat4()
asfloat3() cast() f() i() List() toVectorList() tofloatList() toColorList()
tocolorList() toVectorIE() tofloatIE() xx() xxx() xxxx() nexp() exp2() exp10()
ln() log2() log10() f4() f3() f2() append() y() z() yz() w() zw() yzw() xyzw()
xyz() xy() x() smootherstep() smoothstepcos() eerp() uneerp() smoothstep()
unlerp() lerp() lerpAngle() remap() step() arc() arch2() linstep() sine01()
smin() smax() smax_exp() smax_exp2() smin_exp() smin_pow() smin_root()
smin_polynomial() smin_quadratic() smin_cubic() smin_factor()
smin_cubic_factor() smin_N_factor() mix() smoothstart() smoothstop() xfade()
easeInSine() easeOutSine() easeInOutSine() easeInQuad() easeOutQuad()
easeInOutQuad() easeInCubic() easeOutCubic() easeInOutCubic() easeInQuart()
easeOutQuart() easeInOutQuart() easeInQuint() easeOutQuint() easeInOutQuint()
easeInExpo() easeOutExpo() easeInOutExpo() easeInCirc() easeOutCirc()
easeInOutCirc() easeInBack() easeOutBack() easeInOutBack() easeInElastic()
easeOutElastic() easeInOutElastic() easeInBounce() easeOutBounce()
easeInOutBounce() smooth() smoothstepD() smooth5() smooth5D() smooth7()
smooth7D() smooth9() smooth9D() smooth11() smooth11D() smoothD() smoother7D()
i4() i3() i2() any() all() select() approx() odd() even() greater() less()
lesseq() greatereq() eq() neq() anygreater() anygreatereq() anyless()
anylesseq() anyeq() anyneq() isgreatest() isshortest() ispow2() isnan() anynan()
isinf() isfinite() get() pingpong() SampleParabola() movetowards() repeat()
smoothdamp() b4x4() b4x3() b4x2() b3x4() b3x3() b3x2() b2x4() b2x3() b2x2()
d4x4() d4x3() d4x2() d3x4() d3x3() d3x2() d2x4() d2x3() d2x2() mult()
transpose() diag() f4x4() f4x3() f4x2() f3x4() f3x3() f3x2() f2x4() f2x3()
f2x2() i4x4() i4x3() i4x2() i3x4() i3x3() i3x2() i2x4() i2x3() i2x2() u4x4()
u4x3() u4x2() u3x4() u3x3() u3x2() u2x4() u2x3() u2x2() init() randf() randf2()
randf3() randf4() seedrand() seedrand2() seedrand3() seedrand4() randmax()
setseed() varyrand() addrand() rand() randomint() randomInSphere()
randomInCircle() randomDir3D() randomDir2D() randomrotation() rotate()
rotateAxisAngle() rotateRad() rotateDeg() rotateAround() clamp() min() max()
round() rint() ceil() clint() floor() flint() sat() limp() limn() under1()
clampsigned() maxsigned() minsigned() satsigned() cmax() cmin() acmax() acmin()
matrix() float3x4() rotationMatrix() translationMatrix() transform() rotation()
up() right() scale() sin() cos() tan() sec() cot() csc() asin() acos() atan()
atan2() acot() asec() acsc() sin2() cos2() tan2() sec2() deg() rad() cossin()
sincos() mod360() mod2PI() sinh() cosh() tanh() sech() coth() csch() acosh()
asinh() atanh() acoth() asech() acsch() distance() distancesq() reflect()
refract() project() projectsafe() manhattan() minkowski() chebyshev() cross()
perp() exterior() orthonorm() cdistance() cdistancesq() ccross() cdot()
openSimplex2_ImproveXY() openSimplex2SDerivatives_ImproveXY() sdSphere() sdBox()
sdRoundBox() sdBoxFrame() sdTorus() sdCappedTorus() sdLink() sdCylinder()
sdCone() sdConeBound() sdPlane() sdHexPrism() sdTriPrism() sdCapsule()
sdVerticalCapsule() sdCappedCylinder() sdRoundedCylinder() sdCappedCone()
sdSolidAngle() sdCutSphere() sdCutHollowSphere() sdDeathStar() sdRoundCone()
sdEllipsoid() sdbEllipsoid_2() sdaEllipsoid_3() sdRhombus() sdOctahedron()
sdOctahedronBound() sdPyramid() udTriangle() udQuad() length2() length6()
length8() byte1() byte2() byte3() byte4() color() gammatolinear()
lineartogama() Erf() Erfc() ErfInv() ErfcInv() GammaLn() Gamma() DiGamma()
DiGammaInv() projectplane() apply() smin() smax()
smax_exp() smin_exp()
```

##  Constant & Static fields
```ruby
RAD DEG RAD_DBL DEG_DBL EPSILON EPSILON_DBL FourPI FourPI_DBL TAU TAU_DBL TwoPI
TwoPI_DBL PI PI_DBL HalfPI HPI HalfPI_DBL HPId PHI_DBL PHI PINF NINF PINF_DBL
NINF_DBL E_DBL E TwoSqrtEOverPI LnPI LogTwoSqrtEOverPI HalfSQRT2 HSQRT SQRT3
HalfSQRT3 HSQRT3 InvSQRT2 RSQRT2 INLINE IL NEVER upd2 downd2 rightd2 leftd2 upd3
rightd3 forwardd3 downd3 leftd3 backd3 oned2 zerod2 oned3 zerod3 oned4 zerod4
upf2 downf2 rightf2 leftf2 upf3 rightf3 forwardf3 downf3 leftf3 backf3 onef2
zerof2 onef3 zerof3 onef4 zerof4 upi2 downi2 righti2 lefti2 upi3 righti3
forwardi3 downi3 lefti3 backi3 onei2 zeroi2 onei3 zeroi3 onei4 zeroi4
```


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
