// ***********************************************************************
// Assembly        : Journal
// Author            : Matthew D. Barker
// Created           : 03-16-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-16-2025
// ***********************************************************************
// <copyright file="SerializationExtensions.cs" company="Journal">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json;

namespace Journal.ExtensionMethods;

/// <summary>
/// Class SerializationExtensions.
/// </summary>
public static class SerializationExtensions
{
    /// <summary>
    /// Serializes to json.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <param name="json">The json.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="converters">The converters.</param>
    /// <returns><c>true</c> if the object is serialized successfully, <c>false</c> otherwise.</returns>
    public static bool SerializeToJson(this object obj, out string json, out Exception exception, params JsonConverter[] converters)
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
    /// Deserializes from json.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="json">The json.</param>
    /// <param name="obj">The object.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="converters">The converters.</param>
    /// <returns><c>true</c> if the Json is deserialized successfully, <c>false</c> otherwise.</returns>
    public static bool DeserializeFromJson<T>(this string json, out T? obj, out Exception exception, params JsonConverter[] converters)
    {
        obj = default;
        exception = default;

        try
        {
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