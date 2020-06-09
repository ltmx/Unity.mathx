# Unity.Mathematics Extensions
Extension method syntax for generic Unity.Mathematics data-types & additional methods

<h3>SYNTAX</h3>
<blockquote><p>Converts ➤ math.cos(math.clamp(V.magnitude, 0, 10)) * math.cos(math.clamp(V.magnitude, 0, 10))</p>
<p>To ➤ V.length().clamp(0, 10).cos().sqr()</blockquote></p>

Unity Vectors are converted to floatTypes by default
<blockquote> ex: new Vector3(0, 3, 4).abs() is actually a float3</blockquote>

<h3>PREVIEW PHASE</h3>
This code may not be suitable for production, still largely undocumented.

<h3>LICENSING</h3>

<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md">Unity Companion License</a>)</p>
