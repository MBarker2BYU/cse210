// ***********************************************************************
// Assembly         : Resumes
// Author           : Matthew D. Barker
// Created          : 03-04-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="ResumeJobBase.cs" company="Resumes">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Resumes;

/// <summary>
/// Class ResumeJobBase.
/// </summary>
/// <param name="name">The name.</param>
public abstract class ResumeJobBase(string name)
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    protected string Name { get; set; } = name;

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public abstract void Display();
}