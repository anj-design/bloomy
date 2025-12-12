using boom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using MyApp;

namespace ConsoleApp1
{
    internal class Menu
    {
        private string[][] options = {
        Design.MenuStart,
        Design.MenuHistory,
        Design.MenuGarden,
        Design.Exit
    };

        private int selectedIndex = 0;

        public void Show()
        {
            Console.Clear();

            ConsoleKey key;

            do
            {
                Console.Clear();
                DisplayMenu();

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= options.Length) selectedIndex = 0;
                }
                else if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0) selectedIndex = options.Length - 1;
                }

            } while (key != ConsoleKey.Enter);

            Console.Clear();
            DisplayAscii(options[selectedIndex]);

            // ----------------------------
            // Run Focus Timer on START
            // ----------------------------
            if (selectedIndex == 0) // MenuStart selected
            {
                FocusTimer timer = new(10); // change seconds here
                timer.Start();

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
            else if (selectedIndex == 3) // Exit
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }

        // ---------------------------
        //     CENTERING FUNCTIONS
        // ---------------------------

        private string CenterText(string text)
        {
            int winWidth = Console.WindowWidth;
            int padding = Math.Max(0, (winWidth - text.Length) / 2);
            return new string(' ', padding) + text;
        }

        private void DisplayMenu()
        {
            // ---------------------------
            // Calculate vertical centering
            // ---------------------------

            int totalLines = 0;

            foreach (var block in options)
            {
                totalLines += block.Length + 1; // +1 for spacing
            }

            int winHeight = Console.WindowHeight;

            int topPadding = Math.Max(0, (winHeight - totalLines) / 2);

            // Print empty lines at the top to push content down
            for (int i = 0; i < topPadding; i++)
                Console.WriteLine();

            // ---------------------------
            // Draw each ASCII menu option
            // ---------------------------

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                foreach (var line in options[i])
                    Console.WriteLine(CenterText(line));

                Console.ResetColor();
                Console.WriteLine();
            }
        }

        private void DisplayAscii(string[] art)
        {
            int winHeight = Console.WindowHeight;
            int blockHeight = art.Length;

            int topPadding = Math.Max(0, (winHeight - blockHeight) / 2);

            for (int i = 0; i < topPadding; i++)
                Console.WriteLine();

            foreach (var line in art)
                Console.WriteLine(CenterText(line));
        }
    }
}
