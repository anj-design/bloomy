using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace ConsoleApp1
{
    
    public class FocusTimer
    {

        public Styles styles = new Styles();

        // 🎨 Public array holding ASCII art banners
        public  string[] FocusBanner = 
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
            public  string[] BreakBanner = 
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
            {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("\nFocus Minutes: ");
            int focusMin = int.Parse(Console.ReadLine());

            Console.Write("Break Minutes: ");
            int breakMin = int.Parse(Console.ReadLine());

            RunCountdown("FOCUS TIME", focusMin * 60,1);
            RunCountdown("BREAK TIME", breakMin * 60,2);
        }

 

            private  int GetMinutes(string[] banner, string label)
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

        
        public void RunCountdown(string label, int seconds, int mode)
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
                                Display(styles.sunflower_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(styles.sunflower_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(styles.sunflower_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(styles.sunflower_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(styles.sunflower_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(styles.sunflower_6, col, line);
                            }
                        }
                        else if (random_number == 1)
                        {
                            division = seconds / 6;
                            int col = 97;
                            int line = 10;
                            if (frame == 1)
                            {
                                Display(styles.rose_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(styles.rose_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(styles.rose_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(styles.rose_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(styles.rose_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(styles.rose_6, col, line);
                            }
                        }
                        else if (random_number == 2)
                        {
                            division = seconds / 8;
                            int col = 80;
                            int line = 10;
                            if (frame == 1)
                            {
                                Display(styles.bloom_1, col, line);
                            }
                            else if (frame == 2)
                            {
                                Display(styles.bloom_2, col, line);
                            }
                            else if (frame == 3)
                            {
                                Display(styles.bloom_3, col, line);
                            }
                            else if (frame == 4)
                            {
                                Display(styles.bloom_4, col, line);
                            }
                            else if (frame == 5)
                            {
                                Display(styles.bloom_5, col, line);
                            }
                            else if (frame == 6)
                            {
                                Display(styles.bloom_6, col, line);
                            }
                            else if (frame == 7)
                            {
                                Display(styles.bloom_7, col, line);
                            }
                            else if (frame == 8)
                            {
                                Display(styles.bloom_8, col, line);
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
                            Display(styles.sleeping_cat_1, col, line);
                            frame = 2;

                        }
                        else if (frame == 2)
                        {
                            Display(styles.sleeping_cat_2, col, line);
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

                    Thread.Sleep(1000);

            }


            // Display "DONE" on timer
            Display_Minute("DO");
                Display_Second("NE");
                Console.SetCursorPosition(32 - 4, 39);
                Console.WriteLine(styles.MAGENTA + "Press any key to proceed!" + styles.RESET);
                Console.ReadKey();
            }
            // --------------------------
            // YES / NO ASCII CONFIRMATION
            // --------------------------
            private  bool AskExitConfirmation()
            {
                int choice = 0; // 0 = YES, 1 = NO

                while (true)
                {
                    Console.Clear();

                    // Draw your YES/NO ASCII from another class
                    foreach (string line in styles.YesNoQuestion)
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
            public  void Load_Background()
            {
                Console.Clear();
                int line = 10;

                foreach (var print in styles.bg)
                {
                    Console.WriteLine(print);
                }

                line = 39;
                foreach (var print in styles.flower_design)
                {
                    Console.SetCursorPosition(5, line);
                    Console.Write(print);
                    line++;
                }

                line = 7;
                foreach (var print in styles.header)
                {
                    Console.SetCursorPosition(25, line);
                    Console.Write(print);
                    line++;
                }

            }
            public  void Display_Minute(string minute)
            {
                int line = 14;
                if (minute.Length == 1)
                {
                    minute = "0" + minute;
                }
                switch (minute.ToString().Substring(0, 1))
                {
                    case "0":
                        Display(styles.a0, 24, line);
                        break;
                    case "1":
                        Display(styles.a1, 24, line);
                        break;
                    case "2":
                        Display(styles.a2, 24, line);
                        break;
                    case "3":
                        Display(styles.a3, 24, line);
                        break;
                    case "4":
                        Display(styles.a4, 24, line);
                        break;
                    case "5":
                        Display(styles.a5, 24, line);
                        break;
                    case "6":
                        Display(styles.a6, 24, line);
                        break;
                    case "7":
                        Display(styles.a7, 24, line);
                        break;
                    case "8":
                        Display(styles.a8, 24, line);
                        break;
                    case "9":
                        Display(styles.a9, 24, line);
                        break;
                    case "D":
                        Display(styles.aD, 24, line);
                        break;
                }

                switch (minute.ToString().Substring(1, 1))
                {
                    case "0":
                        Display(styles.a0, 40, line);
                        break;
                    case "1":
                        Display(styles.a1, 40, line);
                        break;
                    case "2":
                        Display(styles.a2, 40, line);
                        break;
                    case "3":
                        Display(styles.a3, 40, line);
                        break;
                    case "4":
                        Display(styles.a4, 40, line);
                        break;
                    case "5":
                        Display(styles.a5, 40, line);
                        break;
                    case "6":
                        Display(styles.a6, 40, line);
                        break;
                    case "7":
                        Display(styles.a7, 40, line);
                        break;
                    case "8":
                        Display(styles.a8, 40, line);
                        break;
                    case "9":
                        Display(styles.a9, 40, line);
                        break;
                    case "O":
                        Display(styles.aO, 40, line);
                        break;
                }
            }
            public  void Display_Second(string second)
            {
                int line = 27;
                if (second.Length == 1)
                {
                    second = "0" + second;
                }


                switch (second.ToString().Substring(0, 1))
                {
                    case "0":
                        Display(styles.a0, 24, line);
                        break;
                    case "1":
                        Display(styles.a1, 24, line);
                        break;
                    case "2":
                        Display(styles.a2, 24, line);
                        break;
                    case "3":
                        Display(styles.a3, 24, line);
                        break;
                    case "4":
                        Display(styles.a4, 24, line);
                        break;
                    case "5":
                        Display(styles.a5, 24, line);
                        break;
                    case "6":
                        Display(styles.a6, 24, line);
                        break;
                    case "7":
                        Display(styles.a7, 24, line);
                        break;
                    case "8":
                        Display(styles.a8, 24, line);
                        break;
                    case "9":
                        Display(styles.a9, 24, line);
                        break;
                    case "N":
                        Display(styles.aN, 24, line);
                        break;
                }

                switch (second.ToString().Substring(1, 1))
                {
                    case "0":
                        Display(styles.a0, 40, line);
                        break;
                    case "1":
                        Display(styles.a1, 40, line);
                        break;
                    case "2":
                        Display(styles.a2, 40, line);
                        break;
                    case "3":
                        Display(styles.a3, 40, line);
                        break;
                    case "4":
                        Display(styles.a4, 40, line);
                        break;
                    case "5":
                        Display(styles.a5, 40, line);
                        break;
                    case "6":
                        Display(styles.a6, 40, line);
                        break;
                    case "7":
                        Display(styles.a7, 40, line);
                        break;
                    case "8":
                        Display(styles.a8, 40, line);
                        break;
                    case "9":
                        Display(styles.a9, 40, line);
                        break;
                    case "E":
                        Display(styles.aE, 40, line);
                        break;
                }
            }
            public  void Display(string[] number, int col, int line)
            {
                foreach (var print in number)
                {
                    Console.SetCursorPosition(col, line);
                    Console.Write(print);
                    line++;
                }
            }
        

        // --------------------------
        // ASCII PRINTER
        // --------------------------
        private void DisplayAscii(string[] art)
        {
            foreach (string line in art)
                Console.WriteLine(line);
        }

        // ror
    }
}