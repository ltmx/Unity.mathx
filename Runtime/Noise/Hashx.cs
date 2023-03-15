#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public static partial class mathx
    {
        // private static uint hashx (uint seed, uint x, uint y)
        // {
        //     seed ^= x;
        //     seed *= 0x51d7348d;
        //     seed ^= y;
        //     seed *= 0x85dbdda2;
        //     seed ^= seed >> 16;
        //     seed *= 0x78e5d257;
        //     seed ^= seed >> 16;
        //     return seed;
        // }
        // private static uint hashx(uint seed, uint2 p)
        // {
        //     seed ^= p.x;
        //     seed *= 0x51d7348d;
        //     seed ^= p.y;
        //     seed *= 0x85dbdda2;
        //     seed ^= seed >> 16;
        //     seed *= 0x78e5d257;
        //     seed ^= seed >> 16;
        //     return seed;
        // }
        // private static uint hashx(uint seed, uint3 p)
        // {
        //     seed ^= p.x;
        //     seed *= 0x51d7348d;
        //     seed ^= p.y;
        //     seed *= 0x85dbdda2;
        //     seed ^= p.z;
        //     seed *= 0x7e78a65f;
        //     seed ^= seed >> 16;
        //     seed *= 0x7e78a65f;
        //     seed ^= seed >> 16;
        //     seed *= 0x7e78a65f;
        //     seed ^= seed >> 16;
        //     return seed;
        // }
        // private static uint hashx(uint seed, uint4 p)
        // {
        //     seed ^= p.x;
        //     seed *= 0x51d7348d;
        //     seed ^= p.y;
        //     seed *= 0x85dbdda2;
        //     seed ^= p.z;
        //     seed *= 0x7e78a65f;
        //     seed ^= p.w;
        //     seed *= 0x8ebc6af1;
        //     seed ^= seed >> 16;
        //     seed *= 0x7e78a65f;
        //     seed ^= seed >> 16;
        //     seed *= 0x8ebc6af1;
        //     seed ^= seed >> 16;
        //     seed *= 0x7e78a65f;
        //     seed ^= seed >> 16;
        //     return seed;
        // }

        // private static int4 prime = new int4(73856093, 19349663, 83492791, 1376312589);
        // private static int Hash(int x)
        // {
        //     int hash = x * 73856093;
        //     hash = (hash ^ (hash >> 13)) * 19349663;
        //     return (hash ^ (hash >> 15)) * 83492791;
        // }
        // private static int Hash(int2 coord)
        // {
        //     int hash = coord.x * 73856093 + coord.y * 19349663;
        //     hash = coord.dot(prime.xy);
        //     return (hash ^ (hash >> 13)) * 73856093;
        // }
        // private static int hashx(int3 coord)
        // {
        //     int hash = coord.x * 73856093 + coord.y * 19349663 + coord.z * 83492791;
        //     return (hash ^ (hash >> 13)) * 73856093;
        // }
        //
        // private static int Hash(int4 coord)
        // {
        //     int hash = coord.x * 73856093 + coord.y * 19349663 + coord.z * 83492791 + coord.w * 1376312589;
        //     return (hash ^ (hash >> 13)) * 73856093;
        // }
        
        
        private static readonly float4 primef = new(73856093, 19349663, 83492791, 16835253);
        private static readonly int4 prime = new(73856093, 19349663, 83492791, 16835253);
        
        private static float hash01(this float value) => (value + primef.x) % primef.y / primef.y;
        private static float hash01(this float2 coord) => (coord.dot(primef.xy) % primef.y) / primef.y;
        private static float hash01(this float3 coord) => coord.dot(primef.xyz) % primef.y / primef.y;
        private static float hash01(this float4 coord) => coord.dot(primef) % primef.y / primef.y;
        private static float hash01(this int value) => (value + primef.x) % primef.y / primef.y;
        private static float hash01(this int2 coord) => coord.dot(prime.xy) % primef.y / primef.y;
        private static float hash01(this int3 coord) => coord.dot(prime.xyz) % primef.y / primef.y;
        private static float hash01(this int4 coord) => coord.dot(prime) % primef.y / primef.y;
        
        public static float hashnp01(this float value) => value.hash01().m2n1();
        // public static float hashnp01(this float2 coord) => coord.hash01().m2n1();
        public static float hashnp01(this float3 coord) => coord.hash01().m2n1();
        public static float hashnp01(this float4 coord) => coord.hash01().m2n1();
        public static float hashnp01(this int value) => value.hash01().m2n1();
        public static float hashnp01(this int2 coord) => coord.hash01().m2n1();
        public static float hashnp01(this int3 coord) => coord.hash01().m2n1();
        public static float hashnp01(this int4 coord) => coord.hash01().m2n1();
        
        // public static float hashnp01(this float2 coord)
        // {
        //     const int prime1 = 73856093;
        //     const int prime2 = 19349663; 
        //     int x = (int)coord.x;
        //     int y = (int)coord.y;
        //     int hash = (x * prime1) ^ (y * prime2);
        //     hash = (hash << 13) ^ hash;
        //     return (float)(hash & 0x7fffffff) / (float)0x7fffffff;
        // }
        
        const float F1 = 0.3176f;
        const float F2 = 0.7393f;
        const float F3 = 0.2847f;
        private static float Hash(float3 coord)
        {
            float3 n = frac(coord * F1);
            n += dot(n, n.yxz + 19.19f) + F2;
            n = frac(n * F3);
            n += dot(n, n.yxz + 57.57f) + F1;
            return frac(n.cmul() * n.sum());
        }
        
        public static float hashnp01(this float2 coord)
        {
            float2 n = frac(coord * F1);
            n += dot(n, n.yx + 19.19f) + F2;
            n = frac(n * F3);
            n += dot(n, n.yx + 57.57f) + F1;
            return frac(n.cmul() * n.sum());
        }
        private static float Hash(float coord)
        {
            float n = frac(coord * F1);
            n += n * (n + 19.19f) + F2;
            n = frac(n * F3);
            n += n * (n + 57.57f) + F1;
            return frac(n * n);
        }


        public static float GradientNoise(float3 position)
        {
            int3 cell = (int3)math.floor(position);
            float3 frac = position - cell;

            float3x4 corners = new float3x4(
                GenerateGradient(cell + int3(0, 0, 0)),
                GenerateGradient(cell + int3(1, 0, 0)),
                GenerateGradient(cell + int3(0, 1, 0)),
                GenerateGradient(cell + int3(1, 1, 0))
            );

            float3x4 corners_z1 = new float3x4(
                GenerateGradient(cell + int3(0, 0, 1)),
                GenerateGradient(cell + int3(1, 0, 1)),
                GenerateGradient(cell + int3(0, 1, 1)),
                GenerateGradient(cell + int3(1, 1, 1))
            );

            float3x4 blend_x = frac.z.lerp(corners, corners_z1);
            float3x2 blend_xy = frac.y.lerp(new float3x2(blend_x.c0, blend_x.c1), new float3x2(blend_x.c2, blend_x.c3));
            float3 blend_xyz = frac.x.lerp(blend_xy.c0, blend_xy.c1);

            return blend_xyz.dot(0.25f);
        }

        public static float3 GenerateGradient(int3 cell) => cell.hashnp01();


        public static float2 unity_gradientNoise_dir(float2 p)
        {
            p = p % 289;
            float x = (34 * p.x + 1) * p.x % 289 + p.y;
            x = (34 * x + 1) * x % 289;
            x = frac(x / 41) * 2 - 1;
            return normalize(float2(x - floor(x + 0.5f), abs(x) - 0.5f));
        }

        public static float unity_gradientNoise(float2 p)
        {
            float2 ip = floor(p);
            float2 fp = frac(p);
            float d00 = dot(unity_gradientNoise_dir(ip), fp);
            float d01 = dot(unity_gradientNoise_dir(ip + float2(0, 1)), fp - float2(0, 1));
            float d10 = dot(unity_gradientNoise_dir(ip + float2(1, 0)), fp - float2(1, 0));
            float d11 = dot(unity_gradientNoise_dir(ip + float2(1, 1)), fp - float2(1, 1));
            fp = fp * fp * fp * (fp * (fp * 6 - 15) + 10);
            return lerp(lerp(d00, d01, fp.y), lerp(d10, d11, fp.y), fp.x);
        }
        
        const float F = 0.61803398875f; // golden ratio
        public static float hashx(this float3 coord) {
            coord = frac(coord * F);
            coord += dot(coord, coord.yzx + 37);
            return frac(coord.cmul() * coord.sum());
        }
        public static float hashx(this float2 coord)
        {
            coord = frac(coord * F);
            coord += dot(coord, coord.yx + 37);
            return frac(coord.cmul() * coord.sum());
        }
    }
}