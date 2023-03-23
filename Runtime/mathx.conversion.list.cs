#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
    public partial class mathx
    {
        /// <summary> Returns a list containing individual components of this vector </summary>
        [MethodImpl(IL)] public static List<float> List(this float4 f) => new() {f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        [MethodImpl(IL)] public static List<float> List(this float3 f) => new() {f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        [MethodImpl(IL)] public static List<float> List(this float2 f) => new() {f.x, f.y};
        
        /// <inheritdoc cref="List(float4)"/>
        [MethodImpl(IL)] public static List<float> List(this Vector4 f) => new() {f.x, f.y, f.z, f.w};
        /// <inheritdoc cref="List(float4)"/>
        [MethodImpl(IL)] public static List<float> List(this Vector3 f) => new() {f.x, f.y, f.z};
        /// <inheritdoc cref="List(float4)"/>
        [MethodImpl(IL)] public static List<float> List(this Vector2 f) => new() {f.x, f.y};
        
        
                
        //IEnumerable Type Conversion -------------------------------------------------------------------
        
        

        /// Converts to a Unity Vector type List
        [MethodImpl(IL)] public static List<Vector4> toVectorList(this IEnumerable<float4> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Vector3> toVectorList(this IEnumerable<float3> f) => f.toVectorIE().ToList();
        /// <inheritdoc cref="toVectorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Vector2> toVectorList(this IEnumerable<float2> f) => f.toVectorIE().ToList();

        /// Converts to a float-type List
        [MethodImpl(IL)] public static List<float4> tofloatList(this IEnumerable<Vector4> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static List<float3> tofloatList(this IEnumerable<Vector3> f) => f.tofloatIE().ToList();
        /// <inheritdoc cref="tofloatList(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static List<float2> tofloatList(this IEnumerable<Vector2> f) => f.tofloatIE().ToList();

        /// Converts to a UnityEngine.Color List
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float4> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float3> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float2> f) => f.toColorIE().ToList();
        /// <inheritdoc cref="toColorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<Color> toColorList(this IEnumerable<float> f) => f.toColorIE().ToList();

        /// Converts to a Unity.Mathematics.color List
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float4> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float3> f) => f.tocolorIE().ToList();
        /// <inheritdoc cref="tocolorList(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static List<color> tocolorList(this IEnumerable<float2> f) => f.tocolorIE().ToList();
                
                
        /// Converts to a Unity Vector IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Vector4> toVectorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static IEnumerable<Vector3> toVectorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="toVectorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] public static IEnumerable<Vector2> toVectorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(IL)] public static IEnumerable<float4> tofloatIE(this IEnumerable<Vector4> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static IEnumerable<float3> tofloatIE(this IEnumerable<Vector3> f2s) => f2s.Select(f => f.cast());
        /// <inheritdoc cref="tofloatIE(IEnumerable{Vector4})"/>
        [MethodImpl(IL)] public static IEnumerable<float2> tofloatIE(this IEnumerable<Vector2> f2s) => f2s.Select(f => f.cast());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.asColor());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.asColor());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.asColor());
        /// <inheritdoc cref="toColorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<float> f2s) => f2s.Select(f => f.asColor());
        
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float4> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float3> f2s) => f2s.Select(f => f.ascolor());
        /// <inheritdoc cref="tocolorIE(IEnumerable{float4})"/>
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<float2> f2s) => f2s.Select(f => f.ascolor());
        
        /// Converts to a float-type IEnumerable
        [MethodImpl(IL)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<Color> f2s) => f2s.Select(f => f.asfloat3());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float4> tofloat4IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat());
        /// <inheritdoc cref="tofloat4IE(IEnumerable{Color})"/>
        [MethodImpl(IL)] private static IEnumerable<float3> tofloat3IE(this IEnumerable<color> f2s) => f2s.Select(f => f.asfloat3());
        
        /// Converts to a UnityEngine.Color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<Color> toColorIE(this IEnumerable<color> f2s) => f2s.Select(f => f.cast());
        /// Converts to a Unity.Mathematics.color IEnumerable
        [MethodImpl(IL)] private static IEnumerable<color> tocolorIE(this IEnumerable<Color> f2s) => f2s.Select(f => f.cast());
    }
}
