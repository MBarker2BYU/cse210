// ***********************************************************************
// Assembly        : SpartanSystems
// Author            : Matthew D. Barker
// Created           : 03-13-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-13-2025
// ***********************************************************************
// <copyright file="ExceptionExtensions.cs" company="SpartanSystems">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace SpartanSystems.Extensions;

/// <summary>
/// Class ExceptionExtensions.
/// </summary>
public static class ExceptionExtensions
{
    /// <summary>
    /// Throws if not null.
    /// </summary>
    /// <param name="exception">The exception.</param>
    public static void ThrowIfNotNull(this Exception? exception)
    {
        if (exception is not null) throw exception;
    }

}