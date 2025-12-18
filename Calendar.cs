using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Progress
    {
        public Design design = new Design();
        public void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int padding = Math.Max(0, (windowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', padding) + text);
        }
        public void ShowWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();

            // Beautiful flower garden welcome eme kinuha lng naman sa ascii whahahaha
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("           .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-.        ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("          /  ()  \\_/  ()  \\_/  ()  \\_/  ()  \\_/  ()  \\       ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("         |  ____    ____    ____    ____    ____    |      ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("          \\      \\/      \\/      \\/      \\/      /       ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("           '-..-'  '-..-'  '-..-'  '-..-'  '-..-'         ");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            CenterText("╔══════════════════════════════════════════════════════╗");
            CenterText("║         🌸  2 0 2 5   C A L E N D A R  🌸          ║");
            CenterText("║              ~ Flower Garden Edition ~               ║");
            CenterText("╚══════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("          \\\\|//     \\\\|//     \\\\|//     \\\\|//          ");
            CenterText("           \\|/       \\|/       \\|/       \\|/           ");
            CenterText("            |         |         |         |            ");
            CenterText("       ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~  ");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("Use ◄ LEFT and RIGHT ► arrow keys to navigate months");
            CenterText("Press ESC or Q to exit the calendar");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            CenterText("Press any key to start your journey...");
            Console.ResetColor();
            Console.ReadKey(true);
        }

        public void ShowNavigation(int current, int max)
        {
            Console.WriteLine();

            // Bottom flower garden im coookeddd
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("    \\\\|//   \\\\|//   \\\\|//   \\\\|//   \\\\|//   \\\\|//   \\\\|//");
            CenterText("     \\|/     \\|/     \\|/     \\|/     \\|/     \\|/     \\|/");
            CenterText("      |       |       |       |       |       |       |");
            CenterText("  ========================================================");
            Console.ResetColor();

            Console.WriteLine();
            CenterText("════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Gray;

            string leftArrow = current > 0 ? "◄◄◄ PREVIOUS" : "            ";
            string rightArrow = current < max ? "NEXT ►►►" : "        ";
            string position = $"  [{current + 1} of {max + 1}]  ";

            CenterText($"    {leftArrow}{position}{rightArrow}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            CenterText("Press ESC or Q to exit");
            Console.ResetColor();
        }

        public void ShowExitScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            // Farewell flower bouquet
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("              @@@@@   @@@@@   @@@@@   @@@@@");
            CenterText("             @@@@@@@  @@@@@  @@@@@@@  @@@@@");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("            @@@  @@@@ @@@@@ @@@@  @@@ @@@@@");
            CenterText("             @@@  @@@ @ @@@ @@@  @@@  @@@");
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("               \\  \\ | | | | | /  /");
            CenterText("                \\  \\| | | | |/  /");
            CenterText("                 \\  \\| | | |/  /");
            CenterText("                  \\  \\|_|_|/  /");
            CenterText("                   \\   |||   /");
            CenterText("                    \\  |||  /");
            CenterText("                     \\_|||_/");
            CenterText("                      |||||");
            CenterText("                     _|||||_");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan; // ending ;>
            CenterText("╔══════════════════════════════════════════════════════╗");
            CenterText("║                                                      ║");
            CenterText("║       Thank you for using the 2025 Calendar!        ║");
            CenterText("║                                                      ║");
            CenterText("║           🌷 Have a blooming wonderful year! 🌷       ║");
            CenterText("║                                                      ║");
            CenterText("╚══════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            CenterText("Press any key to exit...");
            Console.ReadKey();
        }
        public void DrawCalendar(string monthName, int startDay, int totalDays, int monthNumber)
        {
            // Top flower decoration
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("        .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-. .-\"\"\"\"-.    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("       /  ()  \\_/  ()  \\_/  ()  \\_/  ()  \\_/  ()  \\   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("      |  ____    ____    ____    ____    ____    |  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("       \\      \\/      \\/      \\/      \\/      /   ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            CenterText("        '-..-'  '-..-'  '-..-'  '-..-'  '-..-'     ");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText($"      {monthName} 2025  🌺  Month {monthNumber} of 12");
            Console.ResetColor();
            Console.WriteLine();

            // Calendar frame top
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("  __| |_____________________________________________________________________________| |__  ");
            CenterText(" (___   ____SUNDAY_______MONDAY______TUESDAY_____WEDNESDAY____THURSDAY_____FRIDAY______SATURDAY___  __) ");
            Console.ResetColor();

            // Draw calendar grid
            int dayCounter = 1;

            for (int week = 0; week < 6; week++)
            {
                // Empty space rows
                for (int row = 0; row < 6; row++)
                {
                    string line = "     | |";

                    for (int day = 0; day < 7; day++)
                    {
                        int currentDay = week * 7 + day + 1 - startDay;

                        if (row == 5 && currentDay > 0 && currentDay <= totalDays)
                        {
                            line += $" {currentDay,2}.".PadRight(16) + "|";
                        }
                        else
                        {
                            line += "                |";
                        }
                    }
                    line += " |    ";

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    CenterText(line);
                    Console.ResetColor();
                }

                // Separator line
                if (week < 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    CenterText("     | |################################################################################| |    ");
                    Console.ResetColor();
                }

                // Check if we've printed all days
                if (week * 7 + 7 - startDay >= totalDays)
                    break;
            }

            // Calendar frame bottom pero yambao pogi promise
            Console.ForegroundColor = ConsoleColor.White;
            CenterText("  __| |_____________________________________________________________________________| |__  ");
            CenterText(" (__  ______________________________________________________________________________   __) ");
            CenterText("     | |                                                                            | |    ");
            Console.ResetColor();
        }

    }
}
