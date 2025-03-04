// ***********************************************************************
// Assembly         : Resumes
// Author           : Matthew D. Barker
// Created          : 03-04-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-04-2025
// ***********************************************************************
// <copyright file="Resume.cs" company="Resumes">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Resumes;

/// <summary>
/// Class Resume.
/// Implements the <see cref="Resumes.ResumeJobBase" />
/// Implements the <see cref="Resumes.IResume" />
/// </summary>
/// <param name="name">The name.</param>
/// <seealso cref="Resumes.ResumeJobBase" />
/// <seealso cref="Resumes.IResume" />
public class Resume(string name) : ResumeJobBase(name), IResume
{
    #region Overrides of ResumeJobBase

    /// <summary>
    /// Displays this instance.
    /// </summary>
    public override void Display()
    {
        Console.Clear();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        
        foreach (var job in Jobs)
        {
            job.Display();
        }
    }

    #endregion

    #region Implementation of IResume

    /// <summary>
    /// Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public new string Name
        => base.Name;

    /// <summary>
    /// Gets the jobs.
    /// </summary>
    /// <value>The jobs.</value>
    public List<IJob> Jobs { get; } = [];

    #endregion
}