using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ConsoleApp1
{
    // History class - dito nag-manage ng lahat ng focus sessions na natapos mo na
    // May grid view ng flowers at detailed view ng bawat session

    public class History
    {
        // Filename ng JSON file kung saan naka-save yung history
        private const string FileName = "history.json";
        public List<FocusSession> Sessions { get; private set; } = new List<FocusSession>();

        // Ito ang "Full Screen" art kapag pinili (Enter) ang isang session
        private string[] fullFlowerArt = new string[]
        {
 @"                     _                                                                                                     ",
 @"                   _(_)_                          wWWWw   _                    _(_)_                          wWWWw   _    ",
 @"       @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_  ",
 @"      @@()@@ wWWWw  (_)\    (___)   _(_)_  @@()@@   Y  (_)@(_)    @@()@@ wWWWw  (_)\    (___)   _(_)_  @@()@@   Y  (_)@(_) ",
 @"       @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \|/   (_)\      @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \|/   (_)\  ",
 @"        /      Y       \|    \|/    /(_)    \|      |/      |       /      Y       \|    \|/    /(_)    \|      |/      |  ",
 @"     \ |     \ |/       | / \ | /  \|/       |/    \|      \|/   \ |     \ |/       | / \ | /  \|/       |/    \|      \|/ ",
 @"     \\|//   \\|///  \\\|//\\\|/// \|///  \\\|//  \\|//  \\\|//  \\|//   \\|///  \\\|//\\\|/// \|///  \\\|//  \\|//  \\\|//",
 @" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^",
        };
        // Banner na nag-display sa taas ng garden view
        // "YOUR FLOWER COLLECTIONS" in ASCII art
        private string[] kinemeLang = new string[]
        {
@"                                _  _ _____ __  __ ____    ____ __   _____ _    _ ____ ____     ___ _____ __   __   ____ ___ ____ ____ _____ _  _ ___ ",
@"                               ( \/ (  _  (  )(  (  _ \  ( ___(  ) (  _  ( \/\/ ( ___(  _ \   / __(  _  (  ) (  ) ( ___/ __(_  _(_  _(  _  ( \( / __)",
@"                                \  / )(_)( )(__)( )   /   )__) )(__ )(_)( )    ( )__) )   /  ( (__ )(_)( )(__ )(__ )__( (__  )(  _)(_ )(_)( )  (\__ \",
@"                                (__)(_____(______(_)\_)  (__) (____(_____(__/\__(____(_)\_)   \___(_____(____(____(____\___)(__)(____(_____(_)\_(___/",
        };

        // Mini icon ng flower - ito yung lumalabas sa grid view
        // Maliit na flower design para sa overview ng sessions
        private string[] iconArt = new string[]
        {          
@"     _/ \ / \ / \_     ",
@"   _\ \ .'- -'. / /_   ",  
@"  \_ \,___   ___,/ _/  ", 
@" < _ ( \__)-(__/ ) _ > ", 
@"  /_  -  .___.  -  _\  ", 
@"   /_ / -.. ..- \ _\   ",
@"      \ / \ / \ /      ",
@"          |'|_.---._,  ",
@"  ,_.---._| |- --- /   ",
@"   \ --- -| | '---'    ",
@"    '---'_|_|___       ",
@"      [_________]      ",
@"       \______/        ", 
        };

        public History()
        {
            Load();
        }
        // Method para mag-add ng new session sa history
        // Automatically nag-save din sa file after adding
        public void AddSession(FocusSession session)
        {
            Sessions.Add(session);// dagdag sa list
            Save();// I-save sa JSON file
        }
        // Private method para mag-save ng sessions sa JSON file
        // Nag-convert ng list to JSON format at nag-write sa file
        private void Save()
        {
            string json = JsonSerializer.Serialize(Sessions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileName, json);
        }

        private void Load()
        {
            if (File.Exists(FileName))
            {
                string json = File.ReadAllText(FileName);
                Sessions = JsonSerializer.Deserialize<List<FocusSession>>(json) ?? new List<FocusSession>();
            }
        }

        // --- GRID NAVIGATION LOGIC ---
        public void NavigateSessions()
        {
            if (Sessions.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n      No sessions yet. Start focusing to grow your garden! 🌱");
                Console.WriteLine("\n      Press any key to return...");
                Console.ReadKey();
                return;
            }

            int selectedIndex = 0;
            int columns = 6; // Ilang icons ang kasya sa isang row
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                foreach (var banner in kinemeLang)
                {
                    Console.WriteLine(banner);
                }
                Console.ResetColor();



                // Grid Settings
                int startX = 10;  // Margin sa kaliwa
                int startY = 10;  // Margin sa taas
                int spacingX = 26; // Layo ng icons sa isa't isa (Horizontal)
                int spacingY = 14;  // Layo ng icons sa isa't isa (Vertical)

                for (int i = 0; i < Sessions.Count; i++)
                {
                    // THE GRID MATH 🧮
                    // Kung i = 5 at columns = 4:
                    // Col = 5 % 4 = 1 (Pangalawang pwesto)
                    // Row = 5 / 4 = 1 (Pangalawang row)

                    int col = i % columns;
                    int row = i / columns;

                    int x = startX + (col * spacingX);
                    int y = startY + (row * spacingY);

                    bool isSelected = (i == selectedIndex);
                    DrawIcon(x, y, Sessions[i], isSelected);
                }

                // Controls
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (selectedIndex < Sessions.Count - 1) selectedIndex++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (selectedIndex > 0) selectedIndex--;
                        break;
                    case ConsoleKey.DownArrow: // Talon ng isang row pababa
                        if (selectedIndex + columns < Sessions.Count) selectedIndex += columns;
                        break;
                    case ConsoleKey.UpArrow: // Talon ng isang row pataas
                        if (selectedIndex - columns >= 0) selectedIndex -= columns;
                        break;
                    case ConsoleKey.Enter:
                        ShowSessionDetails(Sessions[selectedIndex]);
                        break;
                    case ConsoleKey.Backspace: // Return to Menu
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                }
            }
        }

        private void DrawIcon(int x, int y, FocusSession s, bool isSelected)
        {
            Console.ForegroundColor = isSelected ? ConsoleColor.Green : ConsoleColor.Gray;

            // Draw the mini flower
            for (int i = 0; i < iconArt.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(iconArt[i]);
            }

            // Draw the label (Date) under the flower
            Console.SetCursorPosition(x - 1, y + iconArt.Length);
            // "MMM dd" = Jan 01
            Console.Write(isSelected ? $"[{s.Date.ToString("MMM dd")}]" : $" {s.Date.ToString("MMM dd")} ");

            Console.ResetColor();
        }

        private string CenterText(string text)
        {
            int winWidth = Console.WindowWidth;
            int padding = Math.Max(0, (winWidth - text.Length) / 2);
            return new string(' ', padding) + text;
        }

        public void ShowSessionDetails(FocusSession session)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            int winWidth = Console.WindowWidth;

            // Center each line of the flower art
            foreach (var line in fullFlowerArt)
            {
                int padding = Math.Max(0, (winWidth - line.Length) / 2);
                Console.WriteLine(new string(' ', padding) + line);
            }

            Console.ResetColor();

            // Add spacing below the art
            Console.WriteLine();

            // Prepare details text
            string separator = "--------------------------------";
            string dateLine = $" 📅 Date:     {session.Date:F}";
            string durationLine = $" ⏱️ Duration: {session.Minutes} minutes";
            string backLine = "[Backspace] Back to Garden";

            // Helper to center any line
            void WriteCentered(string text)
            {
                int padding = Math.Max(0, (winWidth - text.Length) / 2);
                Console.WriteLine(new string(' ', padding) + text);
            }

            // Centered output
            WriteCentered(separator);
            WriteCentered(dateLine);
            WriteCentered(durationLine);
            WriteCentered(separator);
            Console.WriteLine();
            WriteCentered(backLine);

            Console.ReadKey();
        }
    }
}