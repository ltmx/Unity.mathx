# Unity.Mathematics Extensions
Extension method syntax for generic Unity.Mathematics data-types & additional methods

### SYNTAX
<hr>
Changes 🡶
  ```C#
  var v1 = math.cos(math.clamp(f.magnitude, 0, 10));`{.ruby}
  return v1 * v1;
  ```
Into
  ```C#
  return f.length().clamp(0, 10).cos().sqr();
  ```

### INSTALL 
<hr>
<p><b>Git Package URL</b> > https://github.com/LTMX/Unity.Mathematics-Extensions.git</p>
<p><b>Unity :</b> Window > Package Manager > Add Package From Git URL</p>

### Roadmap

- [x] Add Fast Functions

- [ ] Complete Documentation

### LICENSING 
<hr>
<p>This project is licensed under the MIT License (<a href="https://github.com/LTMX/Unity.Mathematics-Extensions/blob/master/LICENSE">License</a>)</p>
<p>Unity.Mathematics Companion License (<a href="https://github.com/Unity-Technologies/Unity.Mathematics/blob/master/LICENSE.md">Unity Companion License</a>)</p>
