using Unity.Mathematics;
using UnityEngine;

public static partial class UME
{
    // Exponents ------------------------------------------
        
    public static float4 exp(this float4 f) => math.exp(f);
    public static float3 exp(this float3 f) => math.exp(f);
    public static float2 exp(this float2 f) => math.exp(f);
    public static float exp(this float f) => math.exp(f);
    public static float exp(this int f) => math.exp(f);
        
    public static float4 exp(this Vector4 f) => math.exp(f);
    public static float3 exp(this Vector3 f) => math.exp(f);
    public static float2 exp(this Vector2 f) => math.exp(f);

    public static double4 exp(this double4 f) => math.exp(f);
    public static double3 exp(this double3 f) => math.exp(f);
    public static double2 exp(this double2 f) => math.exp(f);
    public static double exp(this double f) => math.exp(f);

    // Exponential Base 2
    public static float4 exp2(this float4 f) => math.exp2(f);
    public static float3 exp2(this float3 f) => math.exp2(f);
    public static float2 exp2(this float2 f) => math.exp2(f);
    public static float exp2(this float f) => math.exp2(f);
    public static float exp2(this int f) => math.exp2(f);
        
    public static float4 exp2(this Vector4 f) => math.exp2(f);
    public static float3 exp2(this Vector3 f) => math.exp2(f);
    public static float2 exp2(this Vector2 f) => math.exp2(f);

    public static double4 exp2(this double4 f) => math.exp2(f);
    public static double3 exp2(this double3 f) => math.exp2(f);
    public static double2 exp2(this double2 f) => math.exp2(f);
    public static double exp2(this double f) => math.exp2(f);
        
    // Exponential Base 10
    public static float4 exp10(this float4 f) => math.exp10(f);
    public static float3 exp10(this float3 f) => math.exp10(f);
    public static float2 exp10(this float2 f) => math.exp10(f);
    public static float exp10(this float f) => math.exp10(f);
    public static float exp10(this int f) => math.exp10(f);
        
    public static float4 exp10(this Vector4 f) => math.exp10(f);
    public static float3 exp10(this Vector3 f) => math.exp10(f);
    public static float2 exp10(this Vector2 f) => math.exp10(f);
        
    public static double4 exp10(this double4 f) => math.exp10(f);
    public static double3 exp10(this double3 f) => math.exp10(f);
    public static double2 exp10(this double2 f) => math.exp10(f);
    public static double exp10(this double f) => math.exp10(f);

    // Logarithms -----------------------------------------------
        
    // Natural Logarithm renamed to "ln", to avoid confusion in the scientific community
    public static float4 ln(this float4 f) => math.log(f);
    public static float3 ln(this float3 f) => math.log(f);
    public static float2 ln(this float2 f) => math.log(f);
    public static float ln(this float f) => math.log(f);
    public static float ln(this int f) => math.log(f);
        
    public static float4 ln(this Vector4 f) => math.log(f);
    public static float3 ln(this Vector3 f) => math.log(f);
    public static float2 ln(this Vector2 f) => math.log(f);

    public static double4 ln(this double4 f) => math.log(f);
    public static double3 ln(this double3 f) => math.log(f);
    public static double2 ln(this double2 f) => math.log(f);
    public static double ln(this double f) => math.log(f);
        
    // Log Base 2
    public static float4 log2(this float4 f) => math.log2(f);
    public static float3 log2(this float3 f) => math.log2(f);
    public static float2 log2(this float2 f) => math.log2(f);
    public static float log2(this float f) => math.log2(f);
    public static float log2(this int f) => math.log2(f);
        
    public static float4 log2(this Vector4 f) => math.log2(f);
    public static float3 log2(this Vector3 f) => math.log2(f);
    public static float2 log2(this Vector2 f) => math.log2(f);

    public static double4 log2(this double4 f) => math.log2(f);
    public static double3 log2(this double3 f) => math.log2(f);
    public static double2 log2(this double2 f) => math.log2(f);
    public static double log2(this double f) => math.log2(f);
        
    // Log Base 10
    public static float4 log10(this float4 f) => math.log10(f);
    public static float3 log10(this float3 f) => math.log10(f);
    public static float2 log10(this float2 f) => math.log10(f);
    public static float log10(this float f) => math.log10(f);
    public static float log10(this int f) => math.log10(f);
        
    public static float4 log10(this Vector4 f) => math.log10(f);
    public static float3 log10(this Vector3 f) => math.log10(f);
    public static float2 log10(this Vector2 f) => math.log10(f);
        
    public static double4 log10(this double4 f) => math.log10(f);
    public static double3 log10(this double3 f) => math.log10(f);
    public static double2 log10(this double2 f) => math.log10(f);
    public static double log10(this double f) => math.log10(f);
}