using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

namespace UME
{
    public partial class Math
    {
        //cotangent
        public static float4 cot(this float4 f) => f.tan().rcp();
        public static float3 cot(this float3 f) => f.tan().rcp();
        public static float2 cot(this float2 f) => f.tan().rcp();
        public static float cot(this float f) => f.tan().rcp();
        public static float cot(this int f) => f.tan().rcp();
        
        public static double4 cot(this double4 f) => f.tan().rcp();
        public static double3 cot(this double3 f) => f.tan().rcp();
        public static double2 cot(this double2 f) => f.tan().rcp();
        
        public static Vector4 cot(this Vector4 f) => f.tan().rcp();
        public static Vector3 cot(this Vector3 f) => f.tan().rcp();
        public static Vector2 cot(this Vector2 f) => f.tan().rcp();

        
        
        
        public static float4 csc(this float4 f) => f.sin().rcp();
        public static float3 csc(this float3 f) => f.sin().rcp();
        public static float2 csc(this float2 f) => f.sin().rcp();
        public static float csc(this float f) => f.sin().rcp();
        
        // Move Sec To Here or move above to "Trigonometry)

        // Arccotangent
        public static float4 acot(this float4 f) => f.rcp().atan();
        public static float3 acot(this float3 f) => f.rcp().atan();
        public static float2 acot(this float2 f) => f.rcp().atan();
        public static float acot(this float f) => f.rcp().atan();
        
        // Arcsecant
        public static float4 asec(this float4 f) => f.rcp().acos();
        public static float3 asec(this float3 f) => f.rcp().acos();
        public static float2 asec(this float2 f) => f.rcp().acos();
        public static float asec(this float f) => f.rcp().acos();
        
        // Arccosecant
        public static float4 acsc(this float4 f) => f.rcp().asin();
        public static float3 acsc(this float3 f) => f.rcp().asin();
        public static float2 acsc(this float2 f) => f.rcp().asin();
        public static float acsc(this float f) => f.rcp().asin();
        
        // Hyperbolic Cotangent
        public static float4 coth(this float4 f) => f.tanh().rcp();
        public static float3 coth(this float3 f) => f.tanh().rcp();
        public static float2 coth(this float2 f) => f.tanh().rcp();
        public static float coth(this float f) => f.tanh().rcp();
        
        // sech already implemented
        
        // Hyperbolic Cosecant
        public static float4 csch(this float4 f) => f.sinh().rcp();
        public static float3 csch(this float3 f) => f.sinh().rcp();
        public static float2 csch(this float2 f) => f.sinh().rcp();
        public static float csch(this float f) => f.sinh().rcp();
        
        // asech already implemented
        
        // acsch already implemented
        
        

    }
}