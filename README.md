# Unity-Mathematics-Extensions
Extension method syntax for generic Unity.Mathematics data-types

Converts   math.cos(math.clamp(V.magnitude,0,10))    
To -->     V.length().clamp(0,10).cos()

Which makes every function very easy to use!

I also added Unity Vectors to floatTypes automatic conversions --> example: new Vector3(0,3,4).abs() is actually a float3


All the code I wrote, was only checked by me many times.

Please BE Aware that the code could still have some errors. If you ever encounter an error, please notify me ASAP to prevent others from falling into ditches. Enjoy these 1080 lines of extension methods !
