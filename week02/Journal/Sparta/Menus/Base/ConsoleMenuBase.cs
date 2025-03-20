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
    
    protected void Show(IEnumerable<Enum> menuItems)
        => Show(menuItems, out _);

    protected bool Show(IEnumerable<Enum> menuItems, out Exception exception)
    {
        exception = default;

        try
        {
            Console.CursorVisible = false;

            var currentIndex = 0;
            m_MenuItems =  menuItems.ToArray();

            StartPosition = Console.GetCursorPosition();
            EndPosition = (StartPosition.Left, StartPosition.Top + m_MenuItems.Length + 1);

            while (true)
            {
                if(m_Exit)
                    break;
                
                Console.SetCursorPosition(0, StartPosition.Top);

                if (m_MenuItems != null)
                {
                    for (var index = 0; index < m_MenuItems.ToArray().Length; index++)
                    {
                        WriteLine(m_MenuItems[index].ToString(), currentIndex == index);
                    }
                }

                var consoleKeyInfo = Console.ReadKey(true);

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        currentIndex = (currentIndex == m_MenuItems.Length - 1 ? 0 : currentIndex + 1);

                        break;
                    case ConsoleKey.UpArrow:
                        currentIndex = (currentIndex == 0 ? m_MenuItems.Length - 1 : currentIndex - 1);

                        break;
                    case ConsoleKey.Enter:
                        OnMenuSystemItemEvent(m_MenuItems[currentIndex]);
                        break;
                }
            }

            Console.SetCursorPosition(StartPosition.Left, StartPosition.Top);
            
            for (var index = StartPosition.Top; index < EndPosition.Top; index++)
            {
                WriteLine("");
            }
            
            Console.SetCursorPosition(StartPosition.Left, StartPosition.Top);
            
            return true;
        }
        catch (Exception ex)
        {
            exception = ex;
            return false;
        }
    }

    protected void WriteLine(string value, bool isSelected = false)
    {
        var currentBackgroundColor = Console.BackgroundColor;
        var currentForegroundColor = Console.ForegroundColor;

        try
        {
            var currentPosition = Console.GetCursorPosition();
            
            Console.WriteLine(new string(' ', Console.BufferWidth));
            
            if (isSelected)
            {
                Console.BackgroundColor = SelectedBackgroundColor;
                Console.ForegroundColor = SelectedForegroundColor;
            }
            
            Console.SetCursorPosition(currentPosition.Left, currentPosition.Top);
            Console.WriteLine($"{value}");
            
        }
        finally
        {
            Console.BackgroundColor = currentBackgroundColor;
            Console.ForegroundColor = currentForegroundColor;
        }
    }
    
    #endregion

    #region Properties

    public ConsoleColor SelectedBackgroundColor { get; set; } = backgroundColor;

    public ConsoleColor SelectedForegroundColor { get; set; } = foregroundColor;

    private Enum[] m_MenuItems { get; set; }

    public (int Left, int Top) StartPosition { get; protected set; }

    public (int Left, int Top) EndPosition { get; protected set; }
    
    private bool m_Exit;

    #endregion
}