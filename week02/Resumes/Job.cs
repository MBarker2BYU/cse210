// ***********************************************************************
// Assembly         : Resumes
// Author           : Matthew D. Barker
// Created          : 03-04-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="Job.cs" company="Resumes">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Resumes;
/// <summary>
/// Class Job.
/// Implements the <see cref="Resumes.ResumeJobBase" />
/// Implements the <see cref="Resumes.IJob" />
/// </summary>
/// <param name="company">The company.</param>
/// <param name="jobTitle">The job title.</param>
/// <param name="startYear">The start year.</param>
/// <param name="endYear">The end year.</param>
/// <seealso cref="Resumes.ResumeJobBase" />
/// <seealso cref="Resumes.IJob" />
public class Job(string company, string jobTitle, int startYear, int endYear) : ResumeJobBase(company), IJob
{
    #region Overrides of ResumeJobBase

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public override void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }

    #endregion

    #region Implementation of IJob

    /// <summary>
    /// Gets the company.
    /// </summary>
    /// <value>The company.</value>
    public string Company
        => base.Name;
    /// <summary>
    /// Gets the job title.
    /// </summary>
    /// <value>The job title.</value>
    public string JobTitle { get; } = jobTitle;
    /// <summary>
    /// Gets the start year.
    /// </summary>
    /// <value>The start year.</value>
    public int StartYear { get; } = startYear;
    /// <summary>
    /// Gets the end year.
    /// </summary>
    /// <value>The end year.</value>
    public int EndYear { get; } = endYear;

    #endregion
}