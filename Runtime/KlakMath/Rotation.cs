#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using Unity.Mathematics;

namespace Unity.Mathematics {

public static class Rotation
{
    public static quaternion FromTo(float3 v1, float3 v2)
    {
        var a = math.cross(v1, v2);
        var v1v2 = math.dot(v1, v1) * math.dot(v2, v2);
        var w = math.sqrt(v1v2) + math.dot(v1, v2);
        return math.normalizesafe(math.quaternion(math.float4(a, w)));
    }
}

} // namespace Klak.Math
