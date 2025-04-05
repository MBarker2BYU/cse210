// ***********************************************************************
// Assembly        : Mindfulness
// Author            : Matthew D. Barker
// Created           : 04-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="BreathingActivity.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Base;
using static Mindfulness.Sparta.Helpers.ConsoleHelper;

namespace Mindfulness;

/// <summary>
/// Class BreathingActivity.
/// Implements the <see cref="ActivityBase" />
/// </summary>
/// <seealso cref="ActivityBase" />
public class BreathingActivity() : ActivityBase(NAME, DESCRIPTION)
{
    /// <summary>
    /// The name
    /// </summary>
    private const string NAME = "Combat Breathing";
    /// <summary>
    /// The description
    /// </summary>
    private const string DESCRIPTION = "Combat breathing, also known as tactical breathing, is a technique used to manage stress and anxiety in high-pressure situations. It involves slow, controlled breaths that activate the parasympathetic nervous system, known as the \"rest and digest\" system. ";

    /// <summary>
    /// The m exercise steps
    /// </summary>
    private readonly List<string> m_ExerciseSteps =
    [
        "Breathe in slowly through your nose for a count of four",
        "Hold your breath for a count of four",
        "Breathe out slowly through your mouth for a count of four"
    ];

    #region Overrides of ActivityBase

    /// <summary>
    /// Runs the activity.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns>bool.</returns>
    protected override bool RunActivity(out Exception exception)
    {
        exception = default!;

        try
        {
            WriteLinePlus("Combat Breathing Technique:");
            WriteLinePlus($"{Indent}1. Inhale: {m_ExerciseSteps[0]}.");
            WriteLinePlus($"{Indent}2. Hold: {m_ExerciseSteps[1]}.");
            WriteLinePlus($"{Indent}3. Exhale: {m_ExerciseSteps[2]}.");
            WriteLinePlus($"{Indent}4. Repeat: Repeat this cycle.", trailingLines: 1);

            if (!NumberPrompt(out _Duration,
                    "How many cycle of this technique would you like to practice? (in cycles)"))
            {
                exception = new Exception("Invalid input");
                return false;
            }

            StandbyReadyBegin(top:1, clear: true);

            var timestamp = DateTime.Now;

            for (var cycleIndex = 0; cycleIndex < _Duration; cycleIndex++)
            {
                foreach (var step in m_ExerciseSteps)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write($"{step}. ");
                    CountTo(4, setCursorVisible: cycleIndex == 2);
                }

                Thread.Sleep(1000);
            }

            var secs = DateTime.Now.Subtract(timestamp).TotalSeconds;

            WriteLinePlus($"Outstanding!  You completed {secs:#,##0} seconds of the {NAME} activity.", trailingLines: 1, clear: true);

                    PressEnterToContinue();


            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion
}