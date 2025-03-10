using Journal.Interfaces;

namespace Journal;

public class PromptGenerator : IPromptGenerator
{
    private readonly Random m_Random = new();

    #region Implementation of IPromptGenerator
    private List<string> Prompts { get; } =
    [
        "What made you smile today?",
        "What is something you learned recently?",
        "Describe a moment you felt proud of yourself.",
        "What are you grateful for today?",
        "What is a goal you want to achieve this week?",
        "What is something good that happened to you today?",
        "What are you most grateful for right now?",
        "Describe a moment today that made you smile.",
        "What is a personal achievement you're proud of?",
        "What is one thing you're looking forward to?",
        "Who is someone that inspires you, and why?",
        "What is a kind act you witnessed or performed today?",
        "What is a favorite memory that brings you joy?",
        "What is something you love about yourself?",
        "What is one thing that made you feel peaceful today?"
    ];

    public string GetRandomPrompt()
    {
        if (Prompts == null || Prompts.Count == 0) throw new InvalidOperationException("No prompts available to select from.");
        
        var index = m_Random.Next(Prompts.Count);
        return Prompts[index];
    }

    #endregion
}