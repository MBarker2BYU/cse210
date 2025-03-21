using ScriptureMemorizer.Sparta.Menus.Base;
using ScriptureMemorizer.Sparta.Menus.Interfaces;

namespace ScriptureMemorizer.Sparta.Menus;

public class ConsoleColorMenu : ConsoleMenuBase, IConsoleColorMenu
{
    #region Implementation of IConsoleColorMenu

    public void Show()
        => Show(out _);

    public void Show(out Exception exception)
        => base.Show(Enum.GetValues(typeof(ConsoleColor)).Cast<Enum>() , out exception);

    #endregion
}