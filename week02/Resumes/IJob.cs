// ***********************************************************************
// Assembly         : Resumes
// Author           : Matthew D. Barker
// Created          : 03-04-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="IJob.cs" company="Resumes">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Resumes;

/// <summary>
/// Interface IJob
/// Extends the <see cref="Resumes.IResumeJob" />
/// </summary>
/// <seealso cref="Resumes.IResumeJob" />
public interface IJob : IResumeJob
{
    /// <summary>
    /// Gets the company.
    /// </summary>
    /// <value>The company.</value>
    public string Company { get; }

    /// <summary>
    /// Gets the job title.
    /// </summary>
    /// <value>The job title.</value>
    public string JobTitle { get; }

    /// <summary>
    /// Gets the start year.
    /// </summary>
    /// <value>The start year.</value>
    public int StartYear { get; }

    /// <summary>
    /// Gets the end year.
    /// </summary>
    /// <value>The end year.</value>
    public int EndYear { get; }
}