// ***********************************************************************
// Assembly         : ScriptureMemorizer
// Author           : Matthew D. Barker
// Created          : 03-21-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 03-21-2025
// ***********************************************************************
// <copyright file="Utilities.cs" company="Tools">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace ScriptureMemorizer.Sparta;

/// <summary>
/// Class Utilities.
/// </summary>
public static class Utilities
{
    /// <summary>
    /// Finds the file.
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="path">The path.</param>
    /// <param name="maximumTraverse">The maximum traverse.</param>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public static bool FindFile(string filename, out string path, int maximumTraverse = 10)
    {
        path = filename;
        
        // Limit the number of directory levels to traverse
        for (int i = 0; i < maximumTraverse; i++)
        {
            if (File.Exists(path))
            {
                return true;
            }

            path = Path.Combine("..", path);
        }

        path = null;
        return false;
    }
}