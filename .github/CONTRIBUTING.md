# 🌱 Contribute !

## 👉 Guidelines
 - Methods should exist in the `Unity.Mathematics.mathx` class (To prevent multiple using declarations)
 - Methods should follow a lower case syntax (shader like syntax)
 - Methods names should be as short as possible while conserving their meaning or naming convension
 - Everything must be Open Source
 - Credits should (if the author can be found) figure above code snipets or in the file header (if reusing existing code)
 - File mames should follow this convention : mathx.<usage>.<differentiation>
      Example : mathx.interpolation.common (common methods for interpolation) or mathx.logix.floatx (float type related logic functions)
    - File names for base types such as `bounds` or `byte2` should only have their type as a title : bounds.cs // byte2.cs
 - Every method should be static (if applicable)
 - Dependencies should not exist if applicable
    - Code must be rewritten and optimized for Unity.Mathematics, compatibility checked
    - Unification is key : if some functions are already available in math or Unity.Mathematics.math (sometimes under another name), use them !
 - Documentation should be inherited from Unity.Mathematics.math methods for direct extension method translations
