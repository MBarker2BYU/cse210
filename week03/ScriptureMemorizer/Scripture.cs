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

using System.Text;

namespace ScriptureMemorizer;

/// <summary>
/// Class Scripture.
/// </summary>
/// <param name="scriptureReference">The scripture reference.</param>
/// <param name="text">The text.</param>
public class Scripture(ScriptureReference scriptureReference, string text)
{
    //Random seed
    private readonly Random _random = new Random(DateTime.Now.Millisecond);

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
        for(var index = 0; index<count; index++)
        {
            var visibleWords = _text.VisibleWords;
            
            while(true)
            {
                var wordIndex = _random.Next(0, visibleWords.Count);
                if (visibleWords[wordIndex].IsHidden) continue;
                
                visibleWords[wordIndex].Hide();
                
                break;
            }            
        }
    }

    /// <summary>
    /// Gets a value indicating whether [all word are hidden].
    /// </summary>
    /// <value><c>true</c> if [all word are hidden]; otherwise, <c>false</c>.</value>
    public bool AllWordAreHidden
        => _text.AllWordAreHidden;

    public string Display()
        => WordWrap(Reference.Display(), _text);

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text
        => _text.ToString();

    static string WordWrap(string scriptureReference,  Words text)
    {
        var paragraph = new StringBuilder(scriptureReference).AppendLine().AppendLine();
        var line = new StringBuilder();

        for (var index = 0; index < text.Count; index++)
        {
            if (line.Length + text[index].Text.Length < Console.BufferWidth - 1)
            {
                line.Append(text[index].FormattedText()).Append(' ');
            }
            else
            {
                paragraph.AppendLine(line.ToString().TrimEnd());
                line.Clear();
                line.Append(text[index].FormattedText()).Append(' ');
            }
        }

        paragraph.Append(line.ToString());

        return paragraph.ToString();
    }
}