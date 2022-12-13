using System;

namespace Unity.Mathematics
{
    public partial class Math
    {
        private static uint seed() => (uint) DateTime.Now.Millisecond;
        private static Random random => new Random(seed()).Init();

        // Extension returning type
        public static Random Init(this Random random){
            random.InitState();
            return random;
        }

        public static float randomrange(float min, float max) => random.NextFloat(min, max);
        public static float2 randomrange(float2 min, float2 max) => random.NextFloat2(min, max);
        public static float3 randomrange(float3 min, float3 max) => random.NextFloat3(min, max);
        public static float4 randomrange(float4 min, float4 max) => random.NextFloat4(min, max);
        
        public static float randomintrange(int min, int max) => random.NextInt(min, max);
        public static int2 randomint2range(int min, int max) => random.NextInt2(min, max);
        public static int3 randomint3range(int min, int max) => random.NextInt3(min, max);
        public static int4 randomint4range(int min, int max) => random.NextInt4(min, max);
        
        public static float3 randomInsideUnitSphere() => random.NextFloat3Direction() * random.NextFloat().cube();
        public static float2 randomInsideUnitCircle() => random.NextFloat2Direction() * random.NextFloat().sq();
        
        public static float3 randomInsideSphere(float radius = 1) => random.NextFloat3Direction() * random.NextFloat().cube() * radius; // Always outputting the same value
        public static float2 randomInsideCircle(float radius = 1) => random.NextFloat2Direction() * random.NextFloat().sq() * radius;
        
        public static float3 random3Ddirection() => random.NextFloat3Direction();
        public static float2 random2Ddirection() => random.NextFloat2Direction();
        
        public static quaternion randomquaternionrotation() => random.NextQuaternionRotation();
        

    }
}