#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        // private static uint seed() => (uint) DateTime.Now.Millisecond;
        private static Random r = new(0x6E624EB7u);
        // private static XXHash xxhash = new XXHash(0x6E624EB7u);
        
        [MethodImpl(INLINE)] public static Random init(this Random rand){
            rand.InitState();
            return rand;
        }
        
        [MethodImpl(INLINE)] public static float randf() => r.NextFloat();
        [MethodImpl(INLINE)] public static float2 randf2() => r.NextFloat2();
        [MethodImpl(INLINE)] public static float3 randf3() => r.NextFloat3();
        [MethodImpl(INLINE)] public static float4 randf4() => r.NextFloat4();

        [MethodImpl(INLINE)] public static float seedrand(this float seed) => r.setseed(seed).NextFloat();
        [MethodImpl(INLINE)] public static float seedrand(this float2 seed) => r.setseed(seed).NextFloat();
        [MethodImpl(INLINE)] public static float seedrand(this float3 seed) => r.setseed(seed).NextFloat();
        [MethodImpl(INLINE)] public static float seedrand(this float4 seed) => r.setseed(seed).NextFloat();

        [MethodImpl(INLINE)] public static float2 seedrand2(this float2 seed) => r.setseed(seed).NextFloat2();
        [MethodImpl(INLINE)] public static float3 seedrand3(this float3 seed) => r.setseed(seed).NextFloat3();
        [MethodImpl(INLINE)] public static float4 seedrand4(this float4 seed) => r.setseed(seed).NextFloat4();
        
        [MethodImpl(INLINE)] public static float randmax(this float max) => r.NextFloat(max);
        [MethodImpl(INLINE)] public static float2 randmax(this float2 max) => r.NextFloat2(max);
        [MethodImpl(INLINE)] public static float3 randmax(this float3 max) => r.NextFloat3(max);
        [MethodImpl(INLINE)] public static float4 randmax(this float4 max) => r.NextFloat4(max);

        [MethodImpl(INLINE)] public static Random setseed(this Random rand, float seed) { rand.state = seed.hash(); return rand; }
        [MethodImpl(INLINE)] public static Random setseed(this Random rand, float2 seed) { rand.state = seed.hash(); return rand; }
        [MethodImpl(INLINE)] public static Random setseed(this Random rand, float3 seed) { rand.state = seed.hash(); return rand; }
        [MethodImpl(INLINE)] public static Random setseed(this Random rand, float4 seed) { rand.state = seed.hash(); return rand; }
        
        [MethodImpl(INLINE)] public static uint hash(this float seed) => math.asuint(seed) * 0x9B13B92Du + 0xD75513F9u;
        [MethodImpl(INLINE)] public static uint hash(this float2 seed) => math.hash(seed);
        [MethodImpl(INLINE)] public static uint hash(this float3 seed) => math.hash(seed);
        [MethodImpl(INLINE)] public static uint hash(this float4 seed) => math.hash(seed);
        [MethodImpl(INLINE)] public static uint2 hashwide(this float2 v) => math.hashwide(v) / uint.MaxValue;
        [MethodImpl(INLINE)] public static uint3 hashwide(this float3 v) => math.hashwide(v) / uint.MaxValue;
        [MethodImpl(INLINE)] public static uint4 hashwide(this float4 v) => math.hashwide(v) / uint.MaxValue;


        [MethodImpl(INLINE)] public static float varyrand(this float a, float min, float max) => a + rand(min, max);
        [MethodImpl(INLINE)] public static float2 varyrand(this float2 a, float2 min, float2 max) => a + rand(min, max);
        [MethodImpl(INLINE)] public static float3 varyrand(this float3 a, float3 min, float3 max) => a + rand(min, max);
        [MethodImpl(INLINE)] public static float4 varyrand(this float4 a, float4 min, float4 max) => a + rand(min, max);
        
        [MethodImpl(INLINE)] public static float addrand(this float a, float max) => a + r.NextFloat(max);
        [MethodImpl(INLINE)] public static float2 addrand(this float2 a, float2 max) => a + r.NextFloat2(max);
        [MethodImpl(INLINE)] public static float3 addrand(this float3 a, float3 max) => a + r.NextFloat3(max);
        [MethodImpl(INLINE)] public static float4 addrand(this float4 a, float4 max) => a + r.NextFloat4(max);
        
        [MethodImpl(INLINE)] public static float2 addrand(this float2 a, float max) => a + r.NextFloat2(max);
        [MethodImpl(INLINE)] public static float3 addrand(this float3 a, float max) => a + r.NextFloat3(max);
        [MethodImpl(INLINE)] public static float4 addrand(this float4 a, float max) => a + r.NextFloat4(max);

        

        
        [MethodImpl(INLINE)] public static float rand(float min, float max) => r.NextFloat(min, max);
        [MethodImpl(INLINE)] public static float2 rand(float2 min, float2 max) => r.NextFloat2(min, max);
        [MethodImpl(INLINE)] public static float3 rand(float3 min, float3 max) => r.NextFloat3(min, max);
        [MethodImpl(INLINE)] public static float4 rand(float4 min, float4 max) => r.NextFloat4(min, max);
        
        [MethodImpl(INLINE)] public static float2 rand(float min, float2 max) => r.NextFloat2(min, max);
        [MethodImpl(INLINE)] public static float3 rand(float min, float3 max) => r.NextFloat3(min, max);
        [MethodImpl(INLINE)] public static float4 rand(float min, float4 max) => r.NextFloat4(min, max);
        [MethodImpl(INLINE)] public static float2 rand(float2 min, float max) => r.NextFloat2(min, max);
        [MethodImpl(INLINE)] public static float3 rand(float3 min, float max) => r.NextFloat3(min, max);
        [MethodImpl(INLINE)] public static float4 rand(float4 min, float max) => r.NextFloat4(min, max);
        
        [MethodImpl(INLINE)] public static int randomint(int min, int max) => r.NextInt(min, max);
        [MethodImpl(INLINE)] public static int2 randomint(int2 min, int2 max) => r.NextInt2(min, max); 
        [MethodImpl(INLINE)] public static int3 randomint(int3 min, int3 max) => r.NextInt3(min, max);
        [MethodImpl(INLINE)] public static int4 randomint(int4 min, int4 max) => r.NextInt4(min, max);

        [MethodImpl(INLINE)] public static float3 randomInSphere(float radius = 1) => r.NextFloat3Direction() * r.NextFloat().cube() * radius; // Always outputting the same value
        [MethodImpl(INLINE)] public static float2 randomInCircle(float radius = 1) => r.NextFloat2Direction() * r.NextFloat().sq() * radius;
        
        [MethodImpl(INLINE)] public static float3 randomDir3D() => r.NextFloat3Direction();
        [MethodImpl(INLINE)] public static float2 randomDir2D() => r.NextFloat2Direction();
        
        [MethodImpl(INLINE)] public static quaternion randomrotation() => r.NextQuaternionRotation();
    }
}