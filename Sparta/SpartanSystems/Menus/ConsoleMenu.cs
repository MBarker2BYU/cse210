using SpartanSystems.Menus.Base;
using SpartanSystems.Menus.Interfaces;

namespace SpartanSystems.Menus;

public class ConsoleMenu : ConsoleMenuBase, IConsoleMenu
{
    #region Implementation of IConsoleMenu

    public new void Show(IEnumerable<Enum> menuItems)
        => Show(menuItems, out _);

    public new bool Show(IEnumerable<Enum> menuItems, out Exception exception)
        => base.Show(menuItems, out exception);

    #endregion
}