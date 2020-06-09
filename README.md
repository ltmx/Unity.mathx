# Unity.Mathematics Extensions
Extension method syntax for generic Unity.Mathematics data-types & additional methods

<h3>SYNTAX</h3>
<blockquote>Converts ➤ math.cos( math.clamp( V.magnitude, 0, 10 ) ) * math.cos( math.clamp( V.magnitude, 0, 10 ) )   
<br>To ➤ V.length().clamp( 0, 10 ).cos().sqr()</blockquote>

Unity Vectors to floatTypes automatic conversions are added
<blockquote> ex: new Vector3(0,3,4).abs() is actually a float3</blockquote>

<h3>PREVIEW PHASE</h3>
This code may not be suitable for production, still largely undocumented.

<h3>LICENSING</h3>

This project is licensed under the MIT License --> https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE
<br>Unity Companion License --> https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md
