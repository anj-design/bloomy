using System.Globalization;
using System.Text;

class CalendarApp
{
    public Design design = new Design();
    public Calendar calendarDrawer = new();
    private int currentMonth = 0; // 0 = Jan, 11 = Dec

    public void Play()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        design.ShowWelcomeScreen();

        bool running = true;
        while (running)
        {
            DisplayCurrentMonth();

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    if (currentMonth < 11) currentMonth++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentMonth > 0) currentMonth--;
                    break;
                case ConsoleKey.Escape:
                case ConsoleKey.Q:
                    running = false;
                    break;
            }
        }
        design.ShowExitScreen();
        Console.CursorVisible = true;
    }

    private void DisplayCurrentMonth()
    {
        Console.Clear();
        calendarDrawer.DrawMonthArt(currentMonth);
        design.ShowNavigation(currentMonth, 11);
    }
}