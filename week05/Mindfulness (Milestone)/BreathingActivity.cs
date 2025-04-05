using Mindfulness.Base;
using Mindfulness.Interfaces;
using Mindfulness.Sparta.ExtensionMethods;

namespace Mindfulness;

public class BreathingActivity() : ActivityBase(NAME, DESCRIPTION), IBreathingActivity
{
    private const string NAME = "Welcome to the Combat Breathing Activity.";
    private const string DESCRIPTION = "Combat breathing, also known as tactical breathing, is a technique used to manage stress and anxiety in high-pressure situations. It involves slow, controlled breaths that activate the parasympathetic nervous system, known as the \"rest and digest\" system. ";

    private readonly List<string> m_ExerciseSteps =
    [
        "Breathe in slowly through your nose for a count of four",
        "Hold your breath for a count of four",
        "Breathe out slowly through your mouth for a count of four"
    ];
    

    public override bool Show(out Exception exception)
    {
        exception = default;

        try
        {
            if(!base.Show(out exception))
                exception.ThrowIfNotNull();

            var indent = new string(' ', 2);

            ConsoleHelper.WriteLinePlus("Combat Breathing Technique:");
            ConsoleHelper.WriteLinePlus($"{indent}1. Inhale: {m_ExerciseSteps[0]}.");
            ConsoleHelper.WriteLinePlus($"{indent}2. Hold: {m_ExerciseSteps[1]}.");
            ConsoleHelper.WriteLinePlus($"{indent}3. Exhale: {m_ExerciseSteps[2]}.");
            ConsoleHelper.WriteLinePlus($"{indent}4. Repeat: Repeat this cycle.", trailingLines:1);

            ConsoleHelper.PressEnterToContinue();

            ConsoleHelper.WriteLinePlus("This will be a 3 cycle exercise.", true, 1);
            Thread.Sleep(3000);

            Console.Clear();
            ConsoleHelper.StandbyReadyBegin(top: 1);

            var timestamp = DateTime.Now;

            for (var cycleIndex=0; cycleIndex < 3; cycleIndex++)
            {
                foreach (var step in m_ExerciseSteps)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write($"{step}. ");
                    ConsoleHelper.CountTo(4, setCursorVisible: cycleIndex == 2);
                }

                Thread.Sleep(1000);
            }

            var secs = DateTime.Now.Subtract(timestamp).TotalSeconds;

            ConsoleHelper.WriteLinePlus("Outstanding! ", true, trailingLines: 2);

            ConsoleHelper.WriteLinePlus($"You completed {secs:#,##0} seconds of the Combat Breathing Activity.", trailingLines: 1);

            ConsoleHelper.PressEnterToContinue();

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

}
