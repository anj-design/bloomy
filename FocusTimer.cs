using System;
using System.Globalization;
using System.Media;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using WindowsInput;

namespace ConsoleApp1
{

    // Main class para sa Focus Timer functionality
    // Dito nangyayari lahat ng timer operations, animations, at user interactions
    public class FocusTimer
    {
        // Instance ng Styles class para ma-access yung lahat ng ASCII art designs
        public Styles styles = new Styles();
        // Position variables para sa cursor placement sa console
        public int x = 0, y = 25;
        // Method na nag-display ng "Press X to go back" message
        // Simple lang, nag-clear ng screen tapos nag-print ng instruction
        public void showXr()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var xr in styles.x_to_back)
            {
             Console.SetCursorPosition(x, y + 5);
               Console.WriteLine(xr);
            }
        }

        // Banner para sa Focus Timer setup screen
        // Nag-display ng "FOCUS MINUTES" text sa ASCII art format
        public void FocusBanner()
        {
            string[] FocusBanner = {

            @" .----..----.  .---. .-. .-. .----.      .-.   .-..-..-. .-..-. .-. .---. .----. .----.  ",
            @" | {_ /  {}  \/  ___}| { } |{ {__        |  `.'  || ||  `| || { } |{_   _}| {_  { {__   O",
            @" | |  \      /\     }| {_} |.-._} }      | |\ /| || || |\  || {_} |  | |  | {__ .-._} } O",
            @" `-'   `----'  `---' `-----'`----'       `-' ` `-'`-'`-' `-'`-----'  `-'  `----'`----'   "
};
            // Loop para i-print yung bawat line ng banner
            foreach (var line in FocusBanner)
            {
                Console.WriteLine(line);
            }
        }
        // Banner para sa Break Timer setup screen
        // Same concept sa FocusBanner pero para sa break time
        public void BreakBanner()
        {
            string[] BreakBanner =
            {
            @" .----. .----. .----.  .--.  .-. .-.   .-.   .-..-..-. .-..-. .-. .---. .----. .----.   ",
            @" | {}  }| {}  }| {_   / {} \ | |/ /    |  `.'  || ||  `| || { } |{_   _}| {_  { {__    O",
            @" | {}  }| .-. \| {__ /  /\  \| |\ \    | |\ /| || || |\  || {_} |  | |  | {__ .-._} }  O",
            @" `----' `-' `-'`----'`-'  `-'`-' `-'   `-' ` `-'`-'`-' `-'`-----'  `-'  `----'`----'    "
            };
            foreach (var line in BreakBanner)
            {
                Console.WriteLine(line);
            }
            showXr();  // Tapos ipakita yung exit instruction 
        }

        public void Start()
        {


            // Initialize history para ma-save yung sessions later
            var history = new History();
            InputSimulator inputSimulator = new InputSimulator();

            for (int i = 0; i <= 10; i++)
            {
                inputSimulator.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.CONTROL, WindowsInput.Native.VirtualKeyCode.OEM_PLUS);
            }
            Thread.Sleep(300);

            int col = 27;
            int line = 7;

            Console.Clear();
            // Set encoding to UTF8 para gumana yung special characters
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FocusBanner();
            int focusMin = (int)ReadNumberWithArt(col, line, FocusBanner);

            Console.Clear();
            BreakBanner();
            int breakMin = (int)ReadNumberWithArt(col, line, BreakBanner);

            for (int i = 0; i <= 9; i++)
            {
                inputSimulator.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.CONTROL, WindowsInput.Native.VirtualKeyCode.OEM_MINUS);
            }

            Thread.Sleep(300);

            RunCountdown("FOCUS TIME", focusMin * 60, 1);

            var session = new FocusSession //para masave yung progress
            {
                Date = DateTime.Now,
                Minutes = focusMin
            };
            history.AddSession(session);

            RunCountdown("BREAK TIME", breakMin * 60, 2);

            Console.Clear();
            history.NavigateSessions();
        }


        //Method para sa pag read ng number with ASCII art
        public object ReadNumberWithArt(int col, int line, Action banner)
        {
            
            string buffer = "";

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                    break;

                if (key.Key == ConsoleKey.Backspace && buffer.Length > 0)
                {
                    buffer = buffer[..^1];
                }

                else if (char.IsDigit(key.KeyChar))
                {
                    buffer += key.KeyChar;
                }

                Console.Clear();
                banner();

                Console.SetCursorPosition(col, line);

                DisplayNumberArt(buffer, col, line + 2);

                if (key.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Start();
                    return 0;
                }
            }

            return buffer == "" ? 0 : int.Parse(buffer);
        }

        // Method to display number in ASCII art
        public void DisplayNumberArt(string number, int col, int line)
        {
            foreach (char digit in number)
            {
                string[] art;
                switch (digit)
                {
                    case '0': art = styles.a0; break;
                    case '1': art = styles.a1; break;
                    case '2': art = styles.a2; break;
                    case '3': art = styles.a3; break;
                    case '4': art = styles.a4; break;
                    case '5': art = styles.a5; break;
                    case '6': art = styles.a6; break;
                    case '7': art = styles.a7; break;
                    case '8': art = styles.a8; break;
                    case '9': art = styles.a9; break;
                    default: art = Array.Empty<string>(); break;
                }

                Display(art, col, line);
                col += 14;
            }
        }
     
        public void RunCountdown(string label, int seconds, int mode)
            {

            SoundPlayer ftbg = new SoundPlayer("focustimermusic.wav");
            ftbg.Load();
            ftbg.PlayLooping();
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
                                //player.Stop();
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