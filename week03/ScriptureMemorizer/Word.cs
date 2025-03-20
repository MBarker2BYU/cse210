// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="Word.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;

namespace ScriptureMemorizer;

/// <summary>
/// Class Word.
/// </summary>
/// <param name="text">The text.</param>
public class Word(string text)
{
    /// <summary>
    /// The is hidden
    /// </summary>
    private bool _isHidden = false;

    /// <summary>
    /// Gets a value indicating whether this instance is hidden.
    /// </summary>
    /// <value><c>true</c> if this instance is hidden; otherwise, <c>false</c>.</value>
    public bool IsHidden
        => _isHidden;

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text {get;} = text;

    /// <summary>
    /// Shows this instance.
    /// </summary>
    public void Show()
        => _isHidden = false;

    /// <summary>
    /// Hides this instance.
    /// </summary>
    public void Hide()
        => _isHidden = true;

    /// <summary>
    /// Formatteds the text.
    /// </summary>
    /// <returns>System.String.</returns>
    public string FormattedText()
    {
        return IsHidden ? FormatWithPunctuation(Text) : Text;
    }

    /// <summary>
    /// Formats the with punctuation.
    /// </summary>
    /// <param name="word">The word.</param>
    /// <returns>System.String.</returns>
    private string FormatWithPunctuation(string word)
    {
        if (string.IsNullOrEmpty(word)) return word;

        var output = new StringBuilder();
        
        foreach (var character in word.ToCharArray())
        {
            if (char.IsPunctuation(character) || character == '-')
            {
                output.Append(character);
                continue;
            }

            if (char.IsAsciiLetterOrDigit(character))
                output.Append('_');
        }

        return output.ToString();
    }

}