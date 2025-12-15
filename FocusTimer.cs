using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using boom; // your ASCII class namespace

namespace MyApp
{
    internal class FocusTimer
    {
        private int v;

        public FocusTimer(int v)
        {
            this.v = v;
        }

        public class TimerApp
        {
            // 🎨 Public array holding ASCII art banners
            public static string[] FocusBanner = new string[]
{
            @"                         .-.   .-. .-.   .----.    .-. .-.    .---.                    ",
            @"                         | |   |  `| |   | {}  }   | { } |   {_   _}                   ",
            @"                         | |   | |\  |   | .--'    | {_} |     | |                     ",
            @"                         `-'   `-' `-'   `-'       `-----'     `-'                     ",
            @" .----..----.  .---. .-. .-. .----.      .-.   .-..-..-. .-..-. .-. .---. .----. .----.",
            @" | {_ /  {}  \/  ___}| { } |{ {__        |  `.'  || ||  `| || { } |{_   _}| {_  { {__  ",
            @" | |  \      /\     }| {_} |.-._} }      | |\ /| || || |\  || {_} |  | |  | {__ .-._} }",
            @" `-'   `----'  `---' `-----'`----'       `-' ` `-'`-'`-' `-'`-----'  `-'  `----'`----' "
};

<<<<<<< HEAD
            public static string[] BreakBanner = new string[]
            {
            @"                         .-.   .-. .-.   .----.    .-. .-.    .---.                     ",
            @"                         | |   |  `| |   | {}  }   | { } |   {_   _}                    ",
            @"                         | |   | |\  |   | .--'    | {_} |     | |                      ",
            @"                         `-'   `-' `-'   `-'       `-----'     `-'                      ",
            @" .----. .----. .----.  .--.  .-. .-.   .-.   .-..-..-. .-..-. .-. .---. .----. .----.   ",
            @" | {}  }| {}  }| {_   / {} \ | |/ /    |  `.'  || ||  `| || { } |{_   _}| {_  { {__     ",
            @" | {}  }| .-. \| {__ /  /\  \| |\ \    | |\ /| || || |\  || {_} |  | |  | {__ .-._} }   ",
            @" `----' `-' `-'`----'`-'  `-'`-' `-'   `-' ` `-'`-'`-' `-'`-----'  `-'  `----'`----'    "
            };

            public void Start()
=======
            Console.Write("\nFocus Minutes: ");
            int focusMin = int.Parse(Console.ReadLine());

            Console.Write("Break Minutes: ");
            int breakMin = int.Parse(Console.ReadLine());

            RunCountdown("FOCUS TIME", focusMin * 60);
            RunCountdown("BREAK TIME", breakMin * 60);
        }

        private void RunCountdown(string label, int seconds)
        {
            for (int i = seconds; i >= 0; i--)
>>>>>>> 0a95196a9475b28693bdb40b1e93ad594eda6996
            {
                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int focusMin = GetMinutes(FocusBanner, "Focus Minutes");
                int breakMin = GetMinutes(BreakBanner, "Break Minutes");

                RunCountdown("FOCUS TIME", focusMin * 60, 1);
                RunCountdown("BREAK TIME", breakMin * 60, 2);
            }

            private int GetMinutes(string[] banner, string label)
            {
                while (true)
                {
                    Console.Clear();

                    // Print ASCII banner centered horizontally
                    foreach (var line in banner)
                    {
                        int horizontalCenter = (Console.WindowWidth - line.Length) / 2;
                        Console.SetCursorPosition(Math.Max(0, horizontalCenter), Console.CursorTop);
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.Write($"{label} (or type 'B' to go back): ");
                    string? input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) && input.Trim().Equals("B", StringComparison.OrdinalIgnoreCase))
                    {
                        return 0; // back button logic
                    }

                    if (int.TryParse(input, out int minutes) && minutes > 0)
                    {
                        return minutes;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input. Please enter a number.");
                        System.Threading.Thread.Sleep(1500);
                    }
                }
            }

            private void RunCountdown(string label, int seconds, int mode)
            {
                // --------------------------
                // TIMER User Interface         
                // --------------------------
                Load_Background();


                // --------------------------
                // ACTUAL TIMES
                // --------------------------

                // Declaring variables
                int division = 0;
                int frame = 1;

                // Generate a random number for a random flower animation
                Random random = new Random();
                int random_number = random.Next(3);

                // Timer Process
                for (int i = seconds; i >= 0; i--)
                {

                    int minute_output = i / 60;
                    int seconds_output = i - (minute_output * 60);

                    // Display minute and second every tick
                    Display_Minute(minute_output.ToString());
                    Display_Second(seconds_output.ToString());

                    if (mode == 1)
                    {

                        // FOCUS TIMER MODE
                        if (random_number == 0)
                        {
                            division = seconds / 6;
                            int col = 90;
                            int line = 10;
                            if (frame == 1)
                            {
                                Display(Design.sunflower_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(Design.sunflower_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(Design.sunflower_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(Design.sunflower_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(Design.sunflower_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(Design.sunflower_6, col, line);
                            }
                        }
                        else if (random_number == 1)
                        {
                            division = seconds / 6;
                            int col = 97;
                            int line = 10;
                            if (frame == 1)
                            {
                                Display(Design.rose_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(Design.rose_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(Design.rose_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(Design.rose_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(Design.rose_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(Design.rose_6, col, line);
                            }
                        }
                        else if (random_number == 2)
                        {
                            division = seconds / 8;
                            int col = 80;
                            int line = 10;
                            if (frame == 1)
                            {
                                Display(Design.bloom_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(Design.bloom_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(Design.bloom_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(Design.bloom_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(Design.bloom_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(Design.bloom_6, col, line);
                            }
                            else if (frame == 7)
                            {
                                Display(Design.bloom_7, col, line);
                            }
                            else if (frame == 8)
                            {
                                Display(Design.bloom_8, col, line);
                            }
                        }
                        ;

                        // for moving a frame logic
                        if (seconds - i >= division * frame)
                        {
                            frame++;
                        }


                    }
                    else if (mode == 2)
                    {

                        // BREAK TIMER MODE
                        int col = 84;
                        int line = 6;
                        if (frame == 1)
                        {
                            Display(Design.sleeping_cat_1, col, line);
                            frame = 2;

                        }
                        else if (frame == 2)
                        {
                            Display(Design.sleeping_cat_2, col, line);
                            frame = 1;
                        }
                        // changing frame every second

                    }
                    // --------------------------
                    // USER INPUT
                    // --------------------------
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;

                        if (key == ConsoleKey.Backspace)
                        {
                            bool stop = AskExitConfirmation();
                            if (stop)
                            {
                                Console.Clear();
                                Console.WriteLine("Timer stopped.");
                                Thread.Sleep(1000);
                                Start();
                                return;
                            }
                            else
                            {
                                Load_Background();
                            }
                        }
                        else if (key == ConsoleKey.M)
                        {
                            i -= 10;
                        }
                    }

                    Thread.Sleep(50);
                }


                // Display "DONE" on timer
                Display_Minute("DO");
                Display_Second("NE");
                Console.SetCursorPosition(32 - 4, 39);
                Console.WriteLine(Design.MAGENTA + "Press any key to proceed!" + Design.RESET);
                Console.ReadKey();
            }
            // --------------------------
            // YES / NO ASCII CONFIRMATION
            // --------------------------
            private bool AskExitConfirmation()
            {
                int choice = 0; // 0 = YES, 1 = NO

                while (true)
                {
                    Console.Clear();

                    // Draw your YES/NO ASCII from another class
                    foreach (string line in Design.YesNoQuestion)
                        Console.WriteLine(line);

                    // Draw selection indicator
                    Console.WriteLine();
                    Console.WriteLine(choice == 0
                        ? @"                                                    
 ┌──────────────────────┐                            
 │   _  _   ___   ___   │              _ _    ___    
 │  | || | / -_) (_-<   │             | ' \  / _ \   
 │   \_, | \___| /__/   │             |_||_| \___/   
 │   |__/               │                            
 │                      │                            
 └──────────────────────┘                             "
                        : @"                                                      
                                ┌───────────────────┐ 
   _  _   ___   ___             │    _ _    ___     │ 
  | || | / -_) (_-<             │   | ' \  / _ \    │ 
   \_, | \___| /__/             │   |_||_| \___/    │ 
   |__/                         │                   │ 
                                │                   │ 
                                └───────────────────┘ 
                                                      ");

                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.LeftArrow)
                        choice = 0;
                    else if (key == ConsoleKey.RightArrow)
                        choice = 1;
                    else if (key == ConsoleKey.Enter)
                    {
                        return choice == 0;
                    }
                }
            }



















            // --------------------------
            // ASCII PRINTER
            // --------------------------
            //   - Mothods for displaying ASCII Timer and Art
            public static void Load_Background()
            {
                Console.Clear();
                int line = 10;

                foreach (var print in Design.bg)
                {
                    Console.WriteLine(print);
                }

                line = 39;
                foreach (var print in Design.flower_design)
                {
                    Console.SetCursorPosition(5, line);
                    Console.Write(print);
                    line++;
                }

                line = 7;
                foreach (var print in Design.header)
                {
                    Console.SetCursorPosition(25, line);
                    Console.Write(print);
                    line++;
                }

            }
            public static void Display_Minute(string minute)
            {
                int line = 14;
                if (minute.Length == 1)
                {
                    minute = "0" + minute;
                }
                switch (minute.ToString().Substring(0, 1))
                {
                    case "0":
                        Display(Design.a0, 24, line);
                        break;
                    case "1":
                        Display(Design.a1, 24, line);
                        break;
                    case "2":
                        Display(Design.a2, 24, line);
                        break;
                    case "3":
                        Display(Design.a3, 24, line);
                        break;
                    case "4":
                        Display(Design.a4, 24, line);
                        break;
                    case "5":
                        Display(Design.a5, 24, line);
                        break;
                    case "6":
                        Display(Design.a6, 24, line);
                        break;
                    case "7":
                        Display(Design.a7, 24, line);
                        break;
                    case "8":
                        Display(Design.a8, 24, line);
                        break;
                    case "9":
                        Display(Design.a9, 24, line);
                        break;
                    case "D":
                        Display(Design.aD, 24, line);
                        break;
                }

                switch (minute.ToString().Substring(1, 1))
                {
                    case "0":
                        Display(Design.a0, 40, line);
                        break;
                    case "1":
                        Display(Design.a1, 40, line);
                        break;
                    case "2":
                        Display(Design.a2, 40, line);
                        break;
                    case "3":
                        Display(Design.a3, 40, line);
                        break;
                    case "4":
                        Display(Design.a4, 40, line);
                        break;
                    case "5":
                        Display(Design.a5, 40, line);
                        break;
                    case "6":
                        Display(Design.a6, 40, line);
                        break;
                    case "7":
                        Display(Design.a7, 40, line);
                        break;
                    case "8":
                        Display(Design.a8, 40, line);
                        break;
                    case "9":
                        Display(Design.a9, 40, line);
                        break;
                    case "O":
                        Display(Design.aO, 40, line);
                        break;
                }
            }
            public static void Display_Second(string second)
            {
                int line = 27;
                if (second.Length == 1)
                {
                    second = "0" + second;
                }


                switch (second.ToString().Substring(0, 1))
                {
                    case "0":
                        Display(Design.a0, 24, line);
                        break;
                    case "1":
                        Display(Design.a1, 24, line);
                        break;
                    case "2":
                        Display(Design.a2, 24, line);
                        break;
                    case "3":
                        Display(Design.a3, 24, line);
                        break;
                    case "4":
                        Display(Design.a4, 24, line);
                        break;
                    case "5":
                        Display(Design.a5, 24, line);
                        break;
                    case "6":
                        Display(Design.a6, 24, line);
                        break;
                    case "7":
                        Display(Design.a7, 24, line);
                        break;
                    case "8":
                        Display(Design.a8, 24, line);
                        break;
                    case "9":
                        Display(Design.a9, 24, line);
                        break;
                    case "N":
                        Display(Design.aN, 24, line);
                        break;
                }

                switch (second.ToString().Substring(1, 1))
                {
                    case "0":
                        Display(Design.a0, 40, line);
                        break;
                    case "1":
                        Display(Design.a1, 40, line);
                        break;
                    case "2":
                        Display(Design.a2, 40, line);
                        break;
                    case "3":
                        Display(Design.a3, 40, line);
                        break;
                    case "4":
                        Display(Design.a4, 40, line);
                        break;
                    case "5":
                        Display(Design.a5, 40, line);
                        break;
                    case "6":
                        Display(Design.a6, 40, line);
                        break;
                    case "7":
                        Display(Design.a7, 40, line);
                        break;
                    case "8":
                        Display(Design.a8, 40, line);
                        break;
                    case "9":
                        Display(Design.a9, 40, line);
                        break;
                    case "E":
                        Display(Design.aE, 40, line);
                        break;
                }
            }
            public static void Display(string[] number, int col, int line)
            {
                foreach (var print in number)
                {
                    Console.SetCursorPosition(col, line);
                    Console.Write(print);
                    line++;
                }
            }
        }
<<<<<<< HEAD
=======

        // --------------------------
        // ASCII PRINTER
        // --------------------------
        private void DisplayAscii(string[] art)
        {
            foreach (string line in art)
                Console.WriteLine(line);
        }

        // ror
>>>>>>> 0a95196a9475b28693bdb40b1e93ad594eda6996
    }
}