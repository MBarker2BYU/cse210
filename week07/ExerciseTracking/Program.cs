// ***********************************************************************
// Assembly        : ExerciseTracking
// Author            : Matthew D. Barker
// Created           : 03-17-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Program.cs" company="ExerciseTracking">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ExerciseTracking.Base;

namespace ExerciseTracking;

/// <summary>
/// Class Program.
/// </summary>
class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
        var running = new Running
        {
            ActivityStart = new DateTime(2023, 10, 1, 7, 0, 0),
            ActivityEnd = new DateTime(2023, 10, 1, 7, 27, 0)
        };
        running.SetDistance(4);


        var cycling = new Cycling()
        {
            ActivityStart = new DateTime(2023, 10, 1, 8, 0, 0),
            ActivityEnd = new DateTime(2023, 10, 1, 8, 45, 0)
        };
        cycling.SetDistance(15);

        var swimming = new Swimming()
        {
            ActivityStart = new DateTime(2023, 10, 1, 9, 0, 0),
            ActivityEnd = new DateTime(2023, 10, 1, 9, 33, 0)
        };
        swimming.SetDistance(20); // 20 laps in a 50m pool

        var activityList = new List<ActivityBase>
        {
            running,
            cycling, 
            swimming
        };

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine();
        Console.WriteLine("Welcome to the Exercise Tracking Program!");
        Console.WriteLine();
        Console.WriteLine("Here are the activities you have done:");
        Console.WriteLine();

        foreach (var activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Thank you for using the Exercise Tracking Program!");
        Console.WriteLine("Have a Blessed Day!");
        Console.WriteLine();
    }
}