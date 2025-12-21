using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    // Menu class - yung main menu ng app kung saan nag-start lahat
    // Dito nag-navigate yung user between Start, History, About, at Exit
    public class Menu
    {
        // Instance ng Styles para ma-access yung ASCII art designs
        public Styles styles = new Styles();
        // Instance ng FocusTimer para ma-run yung actual timer
        FocusTimer FocusTimer = new FocusTimer();

        public string[][] options;

        public int selectedIndex = 0;

        public Menu()
        {
            options = new string[][]
            {
                styles.MenuStart,
                styles.MenuHistory,
                styles.MenuAbout,
                styles.Exit
            };
        }
        public void Background_Header()
        {
            int line = 2;

            foreach (var print in styles.Bloomy)
            {
                Console.WriteLine(print);
            }
        }



        public void Start()
        {

        Console.Clear();
            // Load at i-play yung background music sa loop
            SoundPlayer bg = new SoundPlayer("bgmusic1.wav");
        bg.Load();
        bg.PlayLooping();
            
            ConsoleKey key;

            do
            {
                Console.Clear();
                Background_Header();
                DisplayMenu();
                // Wait for key press
                key = Console.ReadKey(true).Key;
                // Down arrow = move selection down
                if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    // Pag lampas na sa last option, bumalik sa first option (wrap around)
                    if (selectedIndex >= options.Length) selectedIndex = 0;
                }
                // Up arrow = move selection up
                else if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    // Pag negative na, pumunta sa last option (wrap around)
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
                FocusTimer.Start();

                Console.ReadKey();
            }
            else if (selectedIndex == 1) // focus timer yarn?
            {
                History history = new History();
                history.NavigateSessions();
            }
            else if (selectedIndex == 2) // about to
            {
                var about = new About();
                about.DisplayAbout();
            }
            else if (selectedIndex == 3) // Exit
            {
                Environment.Exit(0);
            }
            else
            {

                Console.ReadKey();
                bg.Stop();  
            }
        }

        // ---------------------------
        //     CENTERING FUNCTIONS
        // ---------------------------

        public string CenterText(string text)
        {
            int winWidth = Console.WindowWidth;
            int padding = Math.Max(0, (winWidth - text.Length) / 2);
            return new string(' ', padding) + text;
        }


        private void DisplayMenu()
        {

            int totalLines = 0;

            foreach (var block in options)
            {
                totalLines += block.Length + 1; // +1 for spacing
            }

            int winHeight = Console.WindowHeight;

            int topPadding = 2;

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
        // Private method para mag-display ng ASCII art naka-center vertically at horizontally
        // Ginagamit to pag nag-confirm na ng selection
        private void DisplayAscii(string[] art)
        {
            int winHeight = Console.WindowHeight;// Get console height
            int blockHeight = art.Length;// Get height ng ASCII art
            // Calculate top padding para ma-center vertically
            int topPadding = Math.Max(0, (winHeight - blockHeight) / 2);
            // Print empty lines para ma-push down yung art
            for (int i = 0; i < topPadding; i++)
                Console.WriteLine();
            // Print each line ng art, naka-center horizontally
            foreach (var line in art)
                Console.WriteLine(CenterText(line));
        }

        
    }
}