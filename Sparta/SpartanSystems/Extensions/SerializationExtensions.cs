// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-12-2025
// ***********************************************************************
// <copyright file="SerializationExtensions.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpartanSystems.Extensions;

/// <summary>
/// Class SerializationExtensions.
/// </summary>
public static class SerializationExtensions
{
    /// <summary>
    /// Saves the specified filename.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="overwrite">if set to <c>true</c> [overwrite].</param>
    /// <returns><c>true</c> if the file is successfully saved, <c>false</c> otherwise.</returns>
    /// <exception cref="System.Exception">File '{filename}' already exists.</exception>
    public static bool Save(this object obj, string filename, out Exception? exception, bool overwrite = false)
    {
        exception = null;

        try
        {
            if (File.Exists(filename) && !overwrite)
                throw new Exception($"File '{filename}' already exists.");

            var json = JsonSerializer.Serialize(obj);

            File.WriteAllText(filename, json);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;

            return false;
        }
    }

    /// <summary>
    /// Loads the specified object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="filename">The filename.</param>
    /// <param name="obj">The object.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="converters">The converters.</param>
    /// <returns><c>true</c> if the file is successfully loaded, <c>false</c> otherwise.</returns>
    /// <exception cref="System.Exception">File '{filename}' does not exist.</exception>
    public static bool Load<T>(this string filename, out T? obj, out Exception? exception, List<JsonConverter>? converters = null)
    {
        exception = null;
        obj = default;

        try
        {
            if (!File.Exists(filename))
                throw new Exception($"File '{filename}' does not exist.");

            var serializerOptions = new JsonSerializerOptions();

            if (converters != null)
            {
                foreach (var converter in converters)
                {
                    serializerOptions.Converters.Add(converter);
                }
            }

            var json = File.ReadAllText(filename);

            obj = JsonSerializer.Deserialize<T>(json, serializerOptions);

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;

            return false;
        }
    }
}