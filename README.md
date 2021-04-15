# Unity.Mathematics Extensions
Extension method syntax for generic Unity.Mathematics data-types & additional methods

<h3>SYNTAX</h3><hr>
<p>Changes ➤<code class='language-cs'>var v1 = math.cos(math.clamp(f.magnitude, 0, 10)); return v1 * v1;</code></p>
<p>Into ➤<code class='language-cs'> return f.length().clamp(0, 10).cos().sqr(); </code></p>

<h3>INSTALL</h3><hr>
<p><b>Git Package URL</b> > https://github.com/LTMX/Unity.Mathematics-Extensions.git</p>
<p><b>Unity :</b> Window > Package Manager > Add Package From Git URL</p>

<h3>LICENSING</h3><hr>
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md">Unity Companion License</a>)</p>
