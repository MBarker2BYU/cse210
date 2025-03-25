// ***********************************************************************
// Assembly        : Homework
// Author            : Matthew D. Barker
// Created           : 03-25-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-25-2025
// ***********************************************************************
// <copyright file="IProblems.cs" company="Homework">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Homework.Interfaces;

/// <summary>
/// Interface IProblems
/// Extends the <see>
///     <cref>System.Collections.Generic.IList{Homework.Interfaces.IProblem}</cref>
/// </see>
/// </summary>
/// <seealso>
///     <cref>System.Collections.Generic.IList{Homework.Interfaces.IProblem}</cref>
/// </seealso>
public interface IProblems : IList<IProblem>
{}