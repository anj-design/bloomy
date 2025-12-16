class Styles
{
    public void ShowWelcomeScreen()
    {
        Console.Clear();
        Console.WriteLine("\n\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        CenterText("╔══════════════════════════════════════════════════════╗");
        CenterText("║          🌸  2 0 2 5   C A L E N D A R  🌸           ║");
        CenterText("╚══════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine("\n");
        CenterText("Use LEFT/RIGHT arrows to navigate. Press Q to exit.");
        Console.ReadKey(true);
    }

    public void ShowNavigation(int current, int max)
    {
        Console.WriteLine();
        string left = current > 0 ? "◄ PREV" : "      ";
        string right = current < max ? "NEXT ►" : "      ";
        Console.ForegroundColor = ConsoleColor.Green;
        CenterText($"{left}   [ Month {current + 1} of 12 ]   {right}");
        Console.ResetColor();
    }

    public void ShowExitScreen()
    {
        Console.Clear();
        Console.WriteLine("\n\n");
        CenterText("Goodbye! Have a great year.");
    }

    private void CenterText(string text)
    {
        int padding = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
        Console.WriteLine(new string(' ', padding) + text);
    }
}