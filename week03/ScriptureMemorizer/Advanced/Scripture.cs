// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="Scripture.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Newtonsoft.Json;
using System.Text;

namespace ScriptureMemorizer.Advanced;

/// <summary>
/// Class Scripture.
/// </summary>
/// <param name="book">The book.</param>
/// <param name="chapter">The chapter.</param>
/// <param name="beginVerse">The begin verse.</param>
/// <param name="endVerse">The end verse.</param>
/// <param name="text">The text.</param>
public class Scripture(string book, int chapter, int beginVerse, int? endVerse, string text)
{
    //Random seed
    /// <summary>
    /// The random
    /// </summary>
    private readonly Random _random = new Random(DateTime.Now.Millisecond);

    /// <summary>
    /// The text
    /// </summary>
    private Words _text = new(text);

    /// <summary>
    /// Gets the book.
    /// </summary>
    /// <value>The book.</value>
    public string Book { get; init; } = book;

    /// <summary>
    /// Gets the chapter.
    /// </summary>
    /// <value>The chapter.</value>
    public int Chapter { get; init; } = chapter;

    /// <summary>
    /// Gets the begin verse.
    /// </summary>
    /// <value>The begin verse.</value>
    public int BeginVerse { get; init; } = beginVerse;

    /// <summary>
    /// Gets the end verse.
    /// </summary>
    /// <value>The end verse.</value>
    public int? EndVerse { get; init; } = endVerse > 0 ? endVerse : null;

    /// <summary>
    /// Gets the text.
    /// </summary>
    /// <value>The text.</value>
    public string Text
        => _text.ToString();

    /// <summary>
    /// Gets the reference.
    /// </summary>
    /// <value>The reference.</value>
    public string Reference
        => EndVerse > 0 ? $"{Book} {Chapter}:{BeginVerse}-{EndVerse}" : $"{Book} {Chapter}:{BeginVerse}";

    /// <summary>
    /// Hides the random words.
    /// </summary>
    /// <param name="count">The count.</param>
    /// <param name="exception"></param>
    public void HideRandomWords(int count, out Exception exception)
    {
        exception = default;
        
        try
        {
            for (var index = 0; index < count; index++)
            {
                var visibleWords = _text.VisibleWords;
                
                while (true)
                {
                    if (visibleWords.Count == 0) break;
                    var wordIndex = _random.Next(0, visibleWords.Count);
                    if (visibleWords[wordIndex].IsHidden) continue;

                    visibleWords[wordIndex].Hide();

                    break;
                }
            }
        }
        catch (Exception ex)
        {
            exception = ex;
        }
    }
    
    /// <summary>
    /// Hides the random words.
    /// </summary>
    /// <param name="count">The count.</param>
    public void HideRandomWords(int count)
        => HideRandomWords(count, out _);

    /// <summary>
    /// Gets a value indicating whether [all word are hidden].
    /// </summary>
    /// <value><c>true</c> if [all word are hidden]; otherwise, <c>false</c>.</value>
   [JsonIgnore]
    public bool AllWordAreHidden
        => _text.AllWordAreHidden;

    /// <summary>
    /// Displays this instance.
    /// </summary>
    /// <returns>System.String.</returns>
    public string Display()
        => WordWrap(Reference, _text);

    /// <summary>
    /// Words the wrap.
    /// </summary>
    /// <param name="scriptureReference">The scripture reference.</param>
    /// <param name="text">The text.</param>
    /// <returns>System.String.</returns>
    static string WordWrap(string scriptureReference, Words text)
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