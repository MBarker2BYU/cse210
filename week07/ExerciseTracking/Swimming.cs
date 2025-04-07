// ***********************************************************************
// Assembly        : ExerciseTracking
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Swimming.cs" company="ExerciseTracking">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ExerciseTracking.Base;

namespace ExerciseTracking;

/// <summary>
/// Class Swimming.
/// Implements the <see cref="ActivityBase" />
/// </summary>
/// <seealso cref="ActivityBase" />
public class Swimming() : ActivityBase(nameof(Swimming))
{
    /// <summary>
    /// The meters per mile
    /// </summary>
    private const double METERS_PER_MILE = 1609.34;
    /// <summary>
    /// The lap length meters
    /// </summary>
    private const double LAP_LENGTH_METERS = 50.0;

    #region Overrides of ActivityBase

    /// <summary>
    /// Sets the distance.
    /// </summary>
    /// <param name="laps">The laps.</param>
    /// <exception cref="ArgumentOutOfRangeException">nameof(laps), Laps cannot be negative.</exception>
    public override void SetDistance(double laps)
    {
        if (laps < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(laps), "Laps cannot be negative.");
        }

        // Convert laps to distance in miles
        var distanceInMeters = laps * LAP_LENGTH_METERS;
        var distanceInMiles = distanceInMeters / METERS_PER_MILE;

        base.SetDistance(distanceInMiles);
    }

    #endregion
}