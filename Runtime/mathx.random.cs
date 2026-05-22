#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.mathx
#endregion

using System.Runtime.CompilerServices;
using MI = System.Runtime.CompilerServices.MethodImplAttribute;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // Blittable static state — Burst-safe (Random is a single uint state field).
        // Note: shared global state is not safe across parallel jobs; use a per-job Random field there.
        private static uint _rngState = 0x6E624EB7u;

        [MI(IL)] private static ref Random globalRng() => ref Unsafe.As<uint, Random>(ref _rngState);

        [MI(IL)] public static Random init(this Random rand){
            rand.InitState();
            return rand;
        }
        
        [MI(IL)] public static float randf() => globalRng().NextFloat();
        [MI(IL)] public static float2 randf2() => globalRng().NextFloat2();
        [MI(IL)] public static float3 randf3() => globalRng().NextFloat3();
        [MI(IL)] public static float4 randf4() => globalRng().NextFloat4();

        [MI(IL)] public static float seedrand(this float seed) => new Random(seed.hash()).NextFloat();
        [MI(IL)] public static float seedrand(this float2 seed) => new Random(seed.hash()).NextFloat();
        [MI(IL)] public static float seedrand(this float3 seed) => new Random(seed.hash()).NextFloat();
        [MI(IL)] public static float seedrand(this float4 seed) => new Random(seed.hash()).NextFloat();

        [MI(IL)] public static float2 seedrand2(this float2 seed) => new Random(seed.hash()).NextFloat2();
        [MI(IL)] public static float3 seedrand3(this float3 seed) => new Random(seed.hash()).NextFloat3();
        [MI(IL)] public static float4 seedrand4(this float4 seed) => new Random(seed.hash()).NextFloat4();
        
        [MI(IL)] public static float randmax(this float max) => globalRng().NextFloat(max);
        [MI(IL)] public static float2 randmax(this float2 max) => globalRng().NextFloat2(max);
        [MI(IL)] public static float3 randmax(this float3 max) => globalRng().NextFloat3(max);
        [MI(IL)] public static float4 randmax(this float4 max) => globalRng().NextFloat4(max);

        [MI(IL)] public static Random setseed(this ref Random rand, float seed) { rand.state = seed.hash(); return rand; }
        [MI(IL)] public static Random setseed(this ref Random rand, float2 seed) { rand.state = seed.hash(); return rand; }
        [MI(IL)] public static Random setseed(this ref Random rand, float3 seed) { rand.state = seed.hash(); return rand; }
        [MI(IL)] public static Random setseed(this ref Random rand, float4 seed) { rand.state = seed.hash(); return rand; }
        
        [MI(IL)] public static uint hash(this float seed) => math.asuint(seed) * 0x9B13B92Du + 0xD75513F9u;
        [MI(IL)] public static uint hash(this float2 seed) => math.hash(seed);
        [MI(IL)] public static uint hash(this float3 seed) => math.hash(seed);
        [MI(IL)] public static uint hash(this float4 seed) => math.hash(seed);
        [MI(IL)] public static uint2 hashwide(this float2 v) => math.hashwide(v);
        [MI(IL)] public static uint3 hashwide(this float3 v) => math.hashwide(v);
        [MI(IL)] public static uint4 hashwide(this float4 v) => math.hashwide(v);


        [MI(IL)] public static float varyrand(this float a, float min, float max) => a + rand(min, max);
        [MI(IL)] public static float2 varyrand(this float2 a, float2 min, float2 max) => a + rand(min, max);
        [MI(IL)] public static float3 varyrand(this float3 a, float3 min, float3 max) => a + rand(min, max);
        [MI(IL)] public static float4 varyrand(this float4 a, float4 min, float4 max) => a + rand(min, max);
        
        [MI(IL)] public static float addrand(this float a, float max) => a + globalRng().NextFloat(max);
        [MI(IL)] public static float2 addrand(this float2 a, float2 max) => a + globalRng().NextFloat2(max);
        [MI(IL)] public static float3 addrand(this float3 a, float3 max) => a + globalRng().NextFloat3(max);
        [MI(IL)] public static float4 addrand(this float4 a, float4 max) => a + globalRng().NextFloat4(max);
        
        [MI(IL)] public static float2 addrand(this float2 a, float max) => a + globalRng().NextFloat2(max);
        [MI(IL)] public static float3 addrand(this float3 a, float max) => a + globalRng().NextFloat3(max);
        [MI(IL)] public static float4 addrand(this float4 a, float max) => a + globalRng().NextFloat4(max);
        
        
        [MI(IL)] public static float rand(float min, float max) => globalRng().NextFloat(min, max);
        [MI(IL)] public static float2 rand(float2 min, float2 max) => globalRng().NextFloat2(min, max);
        [MI(IL)] public static float3 rand(float3 min, float3 max) => globalRng().NextFloat3(min, max);
        [MI(IL)] public static float4 rand(float4 min, float4 max) => globalRng().NextFloat4(min, max);
        
        [MI(IL)] public static float2 rand(float min, float2 max) => globalRng().NextFloat2(min, max);
        [MI(IL)] public static float3 rand(float min, float3 max) => globalRng().NextFloat3(min, max);
        [MI(IL)] public static float4 rand(float min, float4 max) => globalRng().NextFloat4(min, max);
        [MI(IL)] public static float2 rand(float2 min, float max) => globalRng().NextFloat2(min, max);
        [MI(IL)] public static float3 rand(float3 min, float max) => globalRng().NextFloat3(min, max);
        [MI(IL)] public static float4 rand(float4 min, float max) => globalRng().NextFloat4(min, max);
        
        [MI(IL)] public static int randomint(int min, int max) => globalRng().NextInt(min, max);
        [MI(IL)] public static int2 randomint(int2 min, int2 max) => globalRng().NextInt2(min, max); 
        [MI(IL)] public static int3 randomint(int3 min, int3 max) => globalRng().NextInt3(min, max);
        [MI(IL)] public static int4 randomint(int4 min, int4 max) => globalRng().NextInt4(min, max);

        [MI(IL)] public static float3 randomInSphere(float radius = 1) => globalRng().NextFloat3Direction() * globalRng().NextFloat().cube() * radius;
        [MI(IL)] public static float2 randomInCircle(float radius = 1) => globalRng().NextFloat2Direction() * globalRng().NextFloat().sq() * radius;
        
        [MI(IL)] public static float3 randomDir3D() => globalRng().NextFloat3Direction();
        [MI(IL)] public static float2 randomDir2D() => globalRng().NextFloat2Direction();
        
        [MI(IL)] public static quaternion randomrotation() => globalRng().NextQuaternionRotation();
    }
}
