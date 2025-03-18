// ***********************************************************************
// Assembly        : SerializationApp2
// Author            : Matthew D. Barker
// Created           : 03-18-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-18-2025
// ***********************************************************************
// <copyright file="InterfaceConverter.cs" company="Spartan Systems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace SpartanSystems.Serializations.Converters;

/// <summary>
/// Class InterfaceConverter.
/// Implements the <see cref="JsonConverter" />
/// </summary>
/// <typeparam name="TInterface">The type of the t interface.</typeparam>
/// <typeparam name="TConcrete">The type of the t concrete.</typeparam>
/// <seealso cref="JsonConverter" />
public class InterfaceConverter<TInterface, TConcrete> : JsonConverter where TConcrete : TInterface, new()
{
    /// <summary>
    /// Determines whether this instance can convert the specified object type.
    /// </summary>
    /// <param name="objectType">Type of the object.</param>
    /// <returns><c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.</returns>
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(TInterface);
    }
    /// <summary>
    /// Reads the JSON representation of the object.
    /// </summary>
    /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
    /// <param name="objectType">Type of the object.</param>
    /// <param name="existingValue">The existing value of object being read.</param>
    /// <param name="serializer">The calling serializer.</param>
    /// <returns>The object value.</returns>
    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        return serializer.Deserialize<TConcrete>(reader);
    }
    /// <summary>
    /// Writes the JSON representation of the object.
    /// </summary>
    /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
    /// <param name="value">The value.</param>
    /// <param name="serializer">The calling serializer.</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}