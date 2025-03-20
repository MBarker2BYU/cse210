using Journal.Sparta.Menus.Base;
using Journal.Sparta.Menus.Interfaces;

namespace Journal.Sparta.Menus;

public class ConsoleColorMenu : ConsoleMenuBase, IConsoleColorMenu
{
    #region Implementation of IConsoleColorMenu

    public void Show()
        => Show(out _);

    public void Show(out Exception exception)
        => base.Show(Enum.GetValues(typeof(ConsoleColor)).Cast<Enum>() , out exception);

    #endregion
}