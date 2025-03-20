// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="Scripture.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ScriptureMemorizer;

/// <summary>
/// Class Scripture.
/// </summary>
/// <param name="scriptureReference">The scripture reference.</param>
/// <param name="text">The text.</param>
public class Scripture(ScriptureReference scriptureReference, string text)
{
    /// <summary>
    /// Gets the reference.
    /// </summary>
    /// <value>The reference.</value>
    public ScriptureReference Reference {get;} = scriptureReference;

    /// <summary>
    /// The text
    /// </summary>
    private Words _text = new(text);

    /// <summary>
    /// Hides the random words.
    /// </summary>
    /// <param name="count">The count.</param>
    /// <exception cref="System.NotImplementedException"></exception>
    public void HideRandomWords(int count)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a value indicating whether [all word are hidden].
    /// </summary>
    /// <value><c>true</c> if [all word are hidden]; otherwise, <c>false</c>.</value>
    public bool AllWordAreHidden
        => _text.AllWordAreHidden;

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text
        => _text.ToString();
}