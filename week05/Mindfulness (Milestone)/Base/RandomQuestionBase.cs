using Mindfulness.Interfaces;

namespace Mindfulness.Base;

public abstract class RandomQuestionBase(string name, string description) :  RandomPromptBase(name, description), IRandomQuestionBase
{
    protected virtual bool GetRandomQuestion<T>(out T prompt, out Exception exception) where T : IPrompt
    {
        prompt = default;
        exception = default;

        try
        {



            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    protected readonly IPrompts Questions = new Prompts();

}