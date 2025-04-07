// ***********************************************************************
// Assembly        : ExerciseTracking
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="ActivityBase.cs" company="ExerciseTracking">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Text;

namespace ExerciseTracking.Base;

/// <summary>
/// Class ActivityBase.
/// </summary>
/// <param name="activityType">Type of the activity.</param>
public abstract class ActivityBase(string activityType)
{
    /// <summary>
    /// The activity start
    /// </summary>
    private DateTime m_ActivityStart;
    /// <summary>
    /// The activity end
    /// </summary>
    private DateTime m_ActivityEnd;

    /// <summary>
    /// The distance
    /// </summary>
    private double m_Distance; // In miles

    /// <summary>
    /// The activity type
    /// </summary>
    private readonly string m_ActivityType = activityType;

    /// <summary>
    /// Gets or sets the activity start.
    /// </summary>
    /// <value>The activity start.</value>
    public DateTime ActivityStart
    {
        get => m_ActivityStart;
        set => m_ActivityStart = value;
    }

    /// <summary>
    /// Gets or sets the activity end.
    /// </summary>
    /// <value>The activity end.</value>
    public DateTime ActivityEnd
    {
        get => m_ActivityEnd;
        set => m_ActivityEnd = value;
    }

    /// <summary>
    /// Gets the duration.
    /// </summary>
    /// <returns>System.Double.</returns>
    public double GetDuration() //In minutes
    {
        var time = m_ActivityEnd - m_ActivityStart;
        return time.TotalMinutes;
    }

    /// <summary>
    /// Gets the speed.
    /// </summary>
    /// <returns>System.Double.</returns>
    public double GetSpeed() //Miles per hour
    { 
        var time = m_ActivityEnd - m_ActivityStart;
        var speed = m_Distance / time.TotalHours;
        
        return speed;
    }

    /// <summary>
    /// Gets the pace.
    /// </summary>
    /// <returns>System.Double.</returns>
    public double GetPace() //Minutes per mile
    {
        var time = m_ActivityEnd - m_ActivityStart;
        var pace = time.TotalMinutes / m_Distance;

        return pace;
    }

    /// <summary>
    /// Sets the distance.
    /// </summary>
    /// <param name="distance">The distance.</param>
    public virtual void SetDistance(double distance)
    {
        if (distance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(distance), "Distance cannot be negative.");
        }
        m_Distance = distance;
    }

    /// <summary>
    /// Gets the summary.
    /// </summary>
    /// <returns>System.String.</returns>
    public virtual string GetSummary()
    {
        var stringBuilder = new StringBuilder($"{m_ActivityStart: dd MMM yyyy}").AppendLine();
        stringBuilder.AppendLine($"\t◦Activity Type: {m_ActivityType} ({GetDuration()} min) - Distance: {m_Distance:#,##0.0} miles, Speed: {GetSpeed():#,##0.0} mph, Pace: {GetPace(): #,##0.0} min per mile.");
        
        return stringBuilder.ToString();
    }
}