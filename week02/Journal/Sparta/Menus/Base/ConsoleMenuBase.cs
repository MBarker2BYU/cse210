using Journal.Sparta.Menus.EventArgs;
using Journal.Sparta.Menus.Interfaces;

namespace Journal.Sparta.Menus.Base;

public abstract class ConsoleMenuBase(ConsoleColor backgroundColor = ConsoleColor.White, ConsoleColor foregroundColor = ConsoleColor.Black) : IConsoleMenuBase
{
    #region Events

    public event EventHandler<MenuEventArgs<Enum>> MenuSystemItemEvent;
    
    protected void OnMenuSystemItemEvent(Enum menuItem)
    {
        MenuSystemItemEvent?.Invoke(this, new MenuEventArgs<Enum>(menuItem));
    }

    #endregion

    #region Methods

    public void Exit()
        => Exit(out _);
        
    public bool Exit(out Exception exception)
    {
        exception = default;

        try
        {
            m_Exit = true;

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }
    
    public void Show()
        => Show(out _);

    public bool Show(out Exception exception)
    {
        exception = default;

        try
        {
            Console.CursorVisible = false;

            var currentIndex = 0;
            var menuItems = MenuItems.ToArray();

            StartPosition = Console.GetCursorPosition();
            EndPosition = (StartPosition.Left, StartPosition.Top + menuItems.Length + 1);

            while (true)
            {
                if(m_Exit)
                    break;
                
                Console.SetCursorPosition(0, StartPosition.Top);
                
                
                
            }
            

            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    #endregion

    #region Properties

    public ConsoleColor SelectedBackgroundColor { get; set; }
    
    public ConsoleColor SelectedForegroundColor { get; set; }

    public IEnumerable<Enum> MenuItems { get; protected set; }

    public (int Left, int Top) StartPosition { get; protected set; }

    public (int Left, int Top) EndPosition { get; protected set; }

    private bool m_Exit;

    #endregion
}