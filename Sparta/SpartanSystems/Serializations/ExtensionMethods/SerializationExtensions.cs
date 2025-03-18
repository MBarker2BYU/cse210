// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-17-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-18-2025
// ***********************************************************************
// <copyright file="SerializationExtensions.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json;
using SpartanSystems.Exceptions;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace SpartanSystems.Serializations.ExtensionMethods;

/// <summary>
/// Class SerializationExtensions.
/// </summary>
public static class SerializationExtensions
{
    /// <summary>
    /// Serializes the specified json.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj">The object.</param>
    /// <param name="json">The json.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="converters">The converters.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public static bool Serialize<T>(this T? obj, out string? json, out Exception? exception, params JsonConverter[] converters)
    {
        json = default;
        exception = default;

        try
        {

            json = JsonConvert.SerializeObject(obj, Formatting.Indented, converters);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    /// <summary>
    /// Deserializes the specified object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="json">The json.</param>
    /// <param name="obj">The object.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="converters">The converters.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    /// <exception cref="InvalidJsonException"></exception>
    public static bool Deserialize<T>(this string? json, out T? obj, out Exception? exception, params JsonConverter[] converters)
    {
        obj = default;
        exception = default;

        try
        {
            if (string.IsNullOrEmpty(json))
                throw new InvalidJsonException(json ?? "Json was null");

            obj = JsonConvert.DeserializeObject<T>(json, converters);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
}