using ScriptureMemorizer.Sparta.Menus.Base;
using ScriptureMemorizer.Sparta.Menus.Interfaces;

namespace ScriptureMemorizer.Sparta.Menus;

public class ConsoleMenu : ConsoleMenuBase, IConsoleMenu
{
    #region Implementation of IConsoleMenu

    public new void Show(IEnumerable<Enum> menuItems)
        => Show(menuItems, out _);

    public new bool Show(IEnumerable<Enum> menuItems, out Exception exception)
        => base.Show(menuItems, out exception);

    #endregion
}