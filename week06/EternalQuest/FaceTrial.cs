// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="FaceTrial.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Base;

namespace EternalQuest;

/// <summary>
/// Class FaceTrial.
/// Implements the <see cref="Base.ActionBase" />
/// </summary>
/// <seealso cref="Base.ActionBase" />
public class FaceTrial : ActionBase
{
    /// <summary>
    /// The minimum trial strength
    /// </summary>
    public const int MIN_TRIAL_STRENGTH = 1;
    /// <summary>
    /// The maximum trial strength
    /// </summary>
    public const int MAX_TRIAL_STRENGTH = 10;

    /// <summary>
    /// The reward multip li er
    /// </summary>
    public const int REWARD_MULTIPLiER = 15;
    /// <summary>
    /// The loss multip li er
    /// </summary>
    public const int LOSS_MULTIPLiER = 5;

    /// <summary>
    /// The m trial strength
    /// </summary>
    private int m_TrialStrength = MIN_TRIAL_STRENGTH;

    /// <summary>
    /// The m victorious
    /// </summary>
    private int m_Victorious = 0;

    #region Overrides of ActionBase

    /// <summary>
    /// Updates the player.
    /// </summary>
    /// <param name="player">The player.</param>
    public override void UpdatePlayer(Player player)
    {
        Console.WriteLine();
        Console.WriteLine("\nA trial stands before you! Will you face it? (y/n)");
        Console.WriteLine();

        if (Console.ReadKey().Key != ConsoleKey.Y)
        {
            m_Victorious = 0;
            return;
        }

        m_TrialStrength = Random.Next(MIN_TRIAL_STRENGTH, MAX_TRIAL_STRENGTH + 1);

        if(player.FaithPoints >= m_TrialStrength * 10)
        {
            _LastAwardedFaithPoints = m_TrialStrength * REWARD_MULTIPLiER;
            m_Victorious = 1;
        }
        else
        {
            m_Victorious = -1;
            _LastAwardedFaithPoints = - m_TrialStrength * LOSS_MULTIPLiER;
        }

        player.FaithPoints += _LastAwardedFaithPoints;
    }

    /// <summary>
    /// Displays the action message.
    /// </summary>
    public override void DisplayActionMessage()
    {
        var currentPosition = Console.GetCursorPosition();

        Console.SetCursorPosition(currentPosition.Left == 0 ? 0 : currentPosition.Left - 1, currentPosition.Top);
        if (m_Victorious != 0)
        {
            Console.WriteLine($"Trial Strength: {m_TrialStrength}");
            Console.WriteLine();
        }

        var value = Math.Abs(_LastAwardedFaithPoints);

        switch (m_Victorious)
        {
            case -1:
                Console.WriteLine($"You faced the trial but were overwhelmed. You Lose {value} Faith Points.");
                break;
            case 0:
                Console.WriteLine("You chose not to face the trial.");
                break;
            case 1:
                Console.WriteLine($"You faced the trial and emerged victorious! You Gain {value} Faith Points.");
                break;
        }
        
    }

    #endregion
}