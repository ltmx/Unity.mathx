# Unity.Mathematics Extensions
Extension methods for generic `Unity.Mathematics` data-types <br>
& many useful methods to process mathematics !
Package name : `com.ltmx.unitymathematicsextensions`

<br>

## SYNTAX
*Old Code :*
> ```C#
> var v1 = math.cos(math.clamp(f.magnitude, 0, 10));
> return v1 * v1;
> ```
*New Code :*
> ```C#
> return f.length().clamp(0, 10).cos().sqr();
> ```

<br>

## INSTALL
### Method 1 : <br>
Git Package URL : https://github.com/LTMX/Unity.Mathematics-Extensions.git
<br>
Unity : `Window > Package Manager > Add Package From Git URL`
<br>
### Method 2 : <br>
1. Download the package in *releases*
2. Unzip the file
3. Unity : `Window > Package Manager > Add Package From Disk`
4. Select the `.json` file inside the unzipped package

<br>

## Roadmap
- [x] Add Fast Functions
- [ ] Complete Documentation `WIP`
- [ ] Signed Distance Functions `WIP`
- [ ] Jobify Class `WIP`

<br>

## LICENSING
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md">Unity Companion License</a>)</p>
