namespace Journal.Sparta.Menus.Interfaces;

public interface IConsoleMenu : IConsoleMenuBase
{
    #region Methods

    /// <summary>
    /// Shows this instance.
    /// </summary>
    public void Show(IEnumerable<Enum> menuItems);

    /// <summary>
    /// Shows the specified exception.
    /// </summary>
    /// <param name="menuItems"></param>
    /// <param name="exception">The exception.</param>
    /// <returns><c>true</c> if the menu is shown successfully , <c>false</c> otherwise.</returns>
    public bool Show(IEnumerable<Enum> menuItems, out Exception exception);

    #endregion
}
    