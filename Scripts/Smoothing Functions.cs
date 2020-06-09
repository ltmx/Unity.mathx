using Unity.Mathematics;

namespace LTMX
{
    public partial class UnityMathematicsExtensions
    {
        // https://github.com/FreyaHolmer/Mathfs/blob/master/Mathfs.cs
        
        public static float4 smootherstep(this float4 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float3 smootherstep(this float3 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float2 smootherstep(this float2 f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();
        public static float smootherstep(this float f) => f.cube() * (f * (f * 6 - 15) + 10).saturate();

        public static float4 smoothstepcos(this float4 f) => - (f * math.PI).cos() * 0.5f + 0.5f;
        public static float3 smoothstepcos(this float3 f) => - (f * math.PI).cos() * 0.5f + 0.5f;
        public static float2 smoothstepcos(this float2 f) => - (f * math.PI).cos() * 0.5f + 0.5f;
        public static float smoothstepcos(this float f) => - (f * math.PI).cos() * 0.5f + 0.5f;

        public static float4 eerp(this float4 f, float4 a, float4 b) => a.pow(1 - f) * b.pow(f);
        public static float3 eerp(this float3 f, float3 a, float3 b) => a.pow(1 - f) * b.pow(f);
        public static float2 eerp(this float2 f, float2 a, float2 b) => a.pow(1 - f) * b.pow(f);
        public static float eerp(this float f, float a, float b) => a.pow(1 - f) * b.pow(f);

        public static float4 uneerp(this float4 f, float4 a, float4 b) => (a / f).ln() / (a / b).ln();
        public static float3 uneerp(this float3 f, float3 a, float3 b) => (a / f).ln() / (a / b).ln();
        public static float2 uneerp(this float2 f, float2 a, float2 b) => (a / f).ln() / (a / b).ln();
        public static float uneerp(this float f, float a, float b) => (a / f).ln() / (a / b).ln();
    }
}