// ***********************************************************************
// Assembly         : Resumes
// Author           : Matthew D. Barker
// Created          : 03-04-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="IResume.cs" company="Resumes">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Resumes;

/// <summary>
/// Interface IResume
/// Extends the <see cref="Resumes.IResumeJob" />
/// </summary>
/// <seealso cref="Resumes.IResumeJob" />
public interface IResume : IResumeJob
{
    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; }

    /// <summary>
    /// Gets the jobs.
    /// </summary>
    /// <value>The jobs.</value>
    public List<IJob> Jobs { get; }
}