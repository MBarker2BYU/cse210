// ***********************************************************************
// Assembly         : Mindfulness
// Author           : Matthew D. Barker
// Created          : 04-05-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-05-2025
// ***********************************************************************
// <copyright file="Program.cs" company="Mindfulness">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mindfulness.Base;
using Mindfulness.Enums;
using Mindfulness.Sparta.Helpers;
using Mindfulness.Sparta.Menus;

namespace Mindfulness;

/// <summary>
/// Class Program.
/// </summary>
public class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void Main(string[] args)
    {
        var activities = new Dictionary<ActivityMenu, ActivityBase>
        {
            { ActivityMenu.StartBreathingActivity, new BreathingActivity() },
            { ActivityMenu.StartReflectingActivity, new ReflectingActivity() },
            { ActivityMenu.StartListingActivity, new ListingActivity() }
        };

        OpeningMessage();
        
        var menu = new ConsoleMenu();
        menu.MenuSystemItemEvent += (sender, eventArgs) =>
        {
            if (sender is not ConsoleMenu consoleMenu) return;
            switch ((ActivityMenu)eventArgs.MenuItem)
            {
                case ActivityMenu.StartBreathingActivity:
                case ActivityMenu.StartReflectingActivity:
                case ActivityMenu.StartListingActivity:
                    // Handle activity selection
                    
                    if(!activities[(ActivityMenu)eventArgs.MenuItem].Show(out var exception))
                    {
                        ConsoleHelper.WriteLinePlus($"An error occurred: {exception}", true, 2, 2);
                        ConsoleHelper.PressEnterToContinue();
                    }

                    OpeningMessage();

                    break;
                case ActivityMenu.Quit:
                    consoleMenu.Exit();
                    break;
            }
        };
        menu.Show(Enum.GetValues<ActivityMenu>().Cast<Enum>());

        ExitMessage();
    }

    private static void OpeningMessage()
        => ConsoleHelper.WriteLinePlus("Welcome to the Mindfulness App!", true, 0, 2);
    

    /// <summary>
    /// Exits the message.
    /// </summary>
    private static void ExitMessage()
        => ConsoleHelper.WriteLinePlus("Thank you! Have a blessed day!", true, 2, 2);
    
}