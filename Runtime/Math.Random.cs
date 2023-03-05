#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        // private static uint seed() => (uint) DateTime.Now.Millisecond;
        private static Random r = new(0x6E624EB7u);
        
        public static Random init(this Random rand){
            rand.InitState();
            return rand;
        }
        
        public static float rand() => r.NextFloat();
        public static float rand(this float max) => r.NextFloat(max);
        
        public static float varyrand(this float a, float min, float max) => a + rand(min, max);
        public static float2 varyrand(this float2 a, float2 min, float2 max) => a + rand(min, max);
        public static float3 varyrand(this float3 a, float3 min, float3 max) => a + rand(min, max);
        public static float4 varyrand(this float4 a, float4 min, float4 max) => a + rand(min, max);
        
        public static float addrand(this float a, float max) => a + r.NextFloat(max);
        public static float2 addrand(this float2 a, float2 max) => a + r.NextFloat2(max);
        public static float3 addrand(this float3 a, float3 max) => a + r.NextFloat3(max);
        public static float4 addrand(this float4 a, float4 max) => a + r.NextFloat4(max);
        
        public static float2 addrand(this float2 a, float max) => a + r.NextFloat2(max);
        public static float3 addrand(this float3 a, float max) => a + r.NextFloat3(max);
        public static float4 addrand(this float4 a, float max) => a + r.NextFloat4(max);

        

        
        public static float rand(float min, float max) => r.NextFloat(min, max);
        public static float2 rand(float2 min, float2 max) => r.NextFloat2(min, max);
        public static float3 rand(float3 min, float3 max) => r.NextFloat3(min, max);
        public static float4 rand(float4 min, float4 max) => r.NextFloat4(min, max);
        
        public static float2 rand(float min, float2 max) => r.NextFloat2(min, max);
        public static float3 rand(float min, float3 max) => r.NextFloat3(min, max);
        public static float4 rand(float min, float4 max) => r.NextFloat4(min, max);
        public static float2 rand(float2 min, float max) => r.NextFloat2(min, max);
        public static float3 rand(float3 min, float max) => r.NextFloat3(min, max);
        public static float4 rand(float4 min, float max) => r.NextFloat4(min, max);
        
        public static int randomint(int min, int max) => r.NextInt(min, max);
        public static int2 randomint(int2 min, int2 max) => r.NextInt2(min, max); 
        public static int3 randomint(int3 min, int3 max) => r.NextInt3(min, max);
        public static int4 randomint(int4 min, int4 max) => r.NextInt4(min, max);

        public static float3 randomInSphere(float radius = 1) => r.NextFloat3Direction() * r.NextFloat().cube() * radius; // Always outputting the same value
        public static float2 randomInCircle(float radius = 1) => r.NextFloat2Direction() * r.NextFloat().sq() * radius;
        
        public static float3 randomDir3D() => r.NextFloat3Direction();
        public static float2 randomDir2D() => r.NextFloat2Direction();
        
        public static quaternion randomrotation() => r.NextQuaternionRotation();
    }
}