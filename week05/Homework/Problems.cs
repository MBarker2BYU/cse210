// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="Problems.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Homework.Interfaces;

namespace Homework;

/// <summary>
/// Class Problems.
/// Implements the <see>
///     <cref>System.Collections.Generic.List{Homework.Interfaces.IProblem}</cref>
/// </see>
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.List{Homework.Interfaces.IProblem}</cref>
/// </seealso>
public class Problems : List<IProblem>, IProblems
{}