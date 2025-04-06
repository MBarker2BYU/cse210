// ***********************************************************************
// Assembly        : EternalQuest
// Author            : Matthew D. Barker
// Created           : 04-06-2025
//
// Last Modified By : Matthew D. Barker
// Last Modified On : 04-06-2025
// ***********************************************************************
// <copyright file="Level.cs" company="EternalQuest">
//     Copyright (c) Spartan Systems. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using EternalQuest.Attributes;

namespace EternalQuest.Enums;

/// <summary>
/// Enum Level
/// </summary>
public enum Level
{
    /// <summary>
    /// The premortal council
    /// </summary>
    [LevelDescription("The Premortal Council",
        "Choose to follow Heavenly Father’s plan and prepare for mortal life.",
        "Participate in the Grand Council in Heaven, sustain Jesus Christ as the Savior, and reject Lucifer’s rebellion (Abraham 3:24-28).",
        "\"Veil of Mortality\" ticket—your pass to enter Earth life with a physical body.",
       "This level represents the premortal existence, where spirit children exercised agency to accept the Plan of Salvation, which includes mortality, the Atonement, and the potential for exaltation.",
   0)]
    ThePremortalCouncil = 0,
    /// <summary>
    /// The seekers spark
    /// </summary>
    [LevelDescription("The Seeker’s Spark", 
        "Awaken curiosity about Heavenly Father and His plan.",
        "Hear the gospel, ask questions, and feel a desire to know more.",
        "A \"Seed of Faith\" (Alma 32:28) to plant and nurture.",
       "Represents the initial interest in God, like an investigator attending church or reading the Book of Mormon.",
        1, .5)]
    TheSeekersSpark = 1,
    /// <summary>
    /// The believers foundation
    /// </summary>
    [LevelDescription("The Believer’s Foundation",
        "Gain belief in Heavenly Father, Jesus Christ, and the Holy Ghost.",
        "Study scriptures (e.g., John 3:16) and pray to feel Their reality.",
        "A \"Tree of Faith\" (Alma 32:41) to grow and strengthen.",
        "Represents the commitment to follow Christ, like a new member of the Church.",
        2, .75)]
    TheBelieversFoundation = 2,
    /// <summary>
    /// The restorers challenge
    /// </summary>
    [LevelDescription("The Restorer’s Challenge",
        "Accept the Restoration and Joseph Smith’s role as a prophet.",
        "Read the Book of Mormon and pray for confirmation (Moroni 10:4-5).",
        "\"Key of Truth\" to unlock further knowledge.",
        "Faith in the restored gospel is a pivotal step in the journey.",
        3)]
    TheRestorersChallenge = 3,
    /// <summary>
    /// The repentance gate
    /// </summary>
    [LevelDescription("The Repentance Gate",
        "Repent and prepare to make covenants with Heavenly Father.",
        "Reflect on sins, seek forgiveness, and commit to change.",
        "\"Cleansing Waters\" of baptism to wash away past mistakes.",
        "Repentance is the gateway to covenant-making, a core principle (Articles of Faith 1:4).",
        4, 1.1)]
    TheRepentanceGate = 4,
    /// <summary>
    /// The covenant crossroads
    /// </summary>
    [LevelDescription("The Covenant Crossroads",
        "Enter into covenants through baptism and receive the Holy Ghost.",
        "Be baptized and confirmed by priesthood authority.",
        "\"Companion of the Spirit\" to guide future levels.",
        "Baptism marks formal entry into the church, with the Holy Ghost as a constant companion.",
        5, 1.15)]
    TheCovenantCrossroads = 5,
    /// <summary>
    /// The obedience trials
    /// </summary>
    [LevelDescription("The Obedience Trials",
        "Build faith through consistent obedience to commandments.",
        "Pay tithing, live the Word of Wisdom, and honor the Sabbath—collect \"Blessing Tokens\" for each.",
        "\"Armor of Faith\" to withstand temptation (James 2:17-18).",
        "Obedience strengthens faith and prepares for greater challenges.",
        6, 1.2)]
    TheObedienceTrials = 6,
    /// <summary>
    /// The adversity forge
    /// </summary>
    [LevelDescription("The Adversity Forge",
        "Endure trials with trust in Heavenly Father’s plan.",
        "Face a personal hardship (e.g., loss or doubt) and seek comfort through prayer and scripture.",
        "A \"Sword of Faith\" (Ephesians 6:17) to wield and defend.",
        "Represents the growth through trials, like a member facing personal challenges or helping others through theirs.",
        7, 1.25)]
    TheAdversityForge = 7,
    /// <summary>
    /// The revelation summit
    /// </summary>
    [LevelDescription("The Revelation Summit",
        "Seek and trust personal revelation from Heavenly Father.",
        "Study a question, pray, and act on a prompting (D&C 9:8-9).",
        "A \"Compass of Faith\" (Proverbs 3:5-6) to navigate and direct.",
        "Personal revelation empowers members to align with God’s will.",
        8, 1.3)]
    TheRevelationSummit = 8,
    /// <summary>
    /// The temple pinnacle
    /// </summary>
    [LevelDescription("The Temple Pinnacle",
        "Enter the temple and make eternal covenants.",
        "Prepare worthily, receive your endowment, and seal your family (if applicable).",
        "\"Crown of Eternity\" symbolizing eternal life (D&C 131:1-4).",
        "Temple ordinances are the highest earthly steps toward returning to Heavenly Father.",
        9, 1.35)]
    TheTemplePinnacle = 9,
    /// <summary>
    /// The celestial victory
    /// </summary>
    [LevelDescription("The Celestial Victory",
        "Endure to the end with Christlike faith, hope, and charity.",
        "Live a life of service, love, and reliance on the Atonement, pressing forward faithfully (2 Nephi 31:20).",
        "\"Embrace of Heavenly Father\" and exaltation in the Celestial Kingdom.",
        "The ultimate goal—becoming like God and dwelling with Him forever.", 
        10, 1.4)]
    TheCelestialVictory = 10
}