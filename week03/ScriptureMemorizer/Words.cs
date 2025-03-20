// ***********************************************************************
// Assembly        : ScriptureMemorizer
// Author            : Matthew D. Barker
// Created           : 03-20-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-20-2025
// ***********************************************************************
// <copyright file="Words.cs" company="ScriptureMemorizer">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections;

namespace ScriptureMemorizer;

/// <summary>
/// Class Words.
/// Implements the <see cref="System.Collections.Generic.IReadOnlyList{ScriptureMemorizer.Word}" />
/// </summary>
/// <seealso cref="System.Collections.Generic.IReadOnlyList{ScriptureMemorizer.Word}" />
public class Words : IReadOnlyList<Word>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Words"/> class.
    /// </summary>
    /// <param name="text">The text.</param>
    public Words(string text)
    {
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(w => new Word(w));

        foreach (var word in words)
        {
            _words.Add(word);
        }
    }

    /// <summary>
    /// The words
    /// </summary>
    private readonly List<Word> _words = [];

    #region Implementation of IEnumerable

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    public IEnumerator<Word> GetEnumerator()
        => _words.GetEnumerator();


    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();

    #endregion

    #region Implementation of IReadOnlyCollection<out Word>

    /// <summary>
    /// Gets the number of elements in the collection.
    /// </summary>
    /// <value>The count.</value>
    public int Count
        => _words.Count;

    #endregion

    #region Implementation of IReadOnlyList<out Word>

    /// <summary>
    /// Gets the <see cref="Word"/> at the specified index.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <returns>Word.</returns>
    public Word this[int index]
        => _words[index];

    #endregion

    /// <summary>
    /// Gets a value indicating whether this instance is all hidden.
    /// </summary>
    /// <value><c>true</c> if this instance is all hidden; otherwise, <c>false</c>.</value>
    public bool AllWordAreHidden
        => _words.All(word => word.IsHidden);
        

    #region Overrides of Object

    /// <summary>
    /// Returns a <see cref="System.String" /> that represents this instance.
    /// </summary>
    /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
    public override string ToString()
    {
        return string.Join(" ", _words.Select(w => w.Text));
    }

    #endregion
}