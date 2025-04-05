// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 03-21-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mindfulness.Sparta.ExtensionMethods;

/// <summary>
/// Class ExceptionExtensions.
/// </summary>
public static class ExceptionExtensions
{
    /// <summary>
    /// Throws if not null.
    /// </summary>
    /// <param name="exception">The exception.</param>
    public static void ThrowIfNotNull(this Exception exception)
    {
        if (exception != null)
            throw exception;
    }

}