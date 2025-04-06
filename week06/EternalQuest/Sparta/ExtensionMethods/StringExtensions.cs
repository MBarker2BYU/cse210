// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;

namespace EternalQuest.Sparta.ExtensionMethods;

public static class StringExtensions
{
    public static string InsertSpaces(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return value;

        var result = new StringBuilder();
        foreach (var c in value)
        {
            if (char.IsUpper(c) && result.Length > 0)
                result.Append(' ');
            result.Append(c);
        }

        return result.ToString();
    }
}