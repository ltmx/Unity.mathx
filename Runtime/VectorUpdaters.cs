using Unity.Mathematics;
using UnityEngine;

public partial class UME
{
    /// Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta
    public static float4 movetowards(this float4 current, float4 target, float maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float3 movetowards(this float3 current, float3 target, float maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float2 movetowards(this float2 current, float2 target, float maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float movetowards(this float current, float target, float maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
        
        
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float4 movetowards(this Vector4 current, float4 target, float maxDistanceDelta)
    {
        var delta = target - current.asfloat();
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current.asfloat() + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float3 movetowards(this Vector3 current, float3 target, float maxDistanceDelta)
    {
        var delta = target - current.asfloat();
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current.asfloat() + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static float2 movetowards(this Vector2 current, float2 target, float maxDistanceDelta)
    {
        var delta = target - current.asfloat();
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current.asfloat() + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }

    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static double4 movetowards(this double4 current, double4 target, float maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static double3 movetowards(this double3 current, double3 target, double maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static double2 movetowards(this double2 current, double2 target, double maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }
    /// <inheritdoc cref="movetowards(float4,float4,float)"/>
    public static double movetowards(this double current, double target, double maxDistanceDelta)
    {
        var delta = target - current;
        var deltaLength = delta.selfmul();
        if (deltaLength == 0 || maxDistanceDelta >= 0 && deltaLength <= maxDistanceDelta.sqr())
            return target;
        return (current + delta) / deltaLength.sqrt() * maxDistanceDelta;
    }


}