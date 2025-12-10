using System;
using System.Reflection.PortableExecutable;
using System.Threading;
using boom; // your ASCII class namespace

namespace MyApp {
    internal class FocusTimer {
        private int v;

        public FocusTimer(int v) {
            this.v = v;
        }

        public void Start() {
            Console.Clear();

            // SAFELY CALL THE INPUT ASCII BOX (replace with your own name)
            DisplayAscii(Design.Bloomi);

            Console.Write("\nFocus Minutes: ");
            int focusMin = int.Parse(Console.ReadLine());

            Console.Write("Break Minutes: ");
            int breakMin = int.Parse(Console.ReadLine());

            RunCountdown("FOCUS TIME", focusMin * 60);
            RunCountdown("BREAK TIME", breakMin * 60);
        }

        private void RunCountdown(string label, int seconds) {
            // TIMER User Interface 
            Load_Background();

            // ACTUAL TIMER
            for (int i = seconds; i >= 0; i--) {
                //Console.Clear();
                //Console.WriteLine($"{label}: {i} seconds remaining...");
                //Console.WriteLine("\n(Press BACKSPACE to exit timer)");

                int minute_output = i / 60;
                int seconds_output = i - (minute_output * 60);
                //Console.WriteLine(minute_output + " : "+ i +":" + seconds_output);

                Display_Minute(minute_output.ToString());
                Display_Second(seconds_output.ToString());
                Display(Design.flower_1, 85, 10);

                if (Console.KeyAvailable) {
                    var key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Backspace) {
                        bool stop = AskExitConfirmation();
                        if (stop) {
                            Console.Clear();
                            Console.WriteLine("Timer stopped.");
                            Thread.Sleep(1000);
                            Start();
                            return;
                        } else {
                            Load_Background();
                        }
                    }
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("\nTimer Complete!");
            Console.ReadKey();
        }

        // --------------------------
        // YES / NO ASCII CONFIRMATION
        // --------------------------
        private bool AskExitConfirmation() {
            int choice = 0; // 0 = YES, 1 = NO

            while (true) {
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
                else if (key == ConsoleKey.Enter) {
                    return choice == 0;
                }
            }
        }

        // --------------------------
        // ASCII PRINTER
        // --------------------------
        private void DisplayAscii(string[] art) {
            foreach (string line in art)
                Console.WriteLine(line);
        }



        // METHODS FOR DISPLAYING TIME IN ASCII
        public static void Load_Background() {
            Console.Clear();
            int line = 10;

            foreach (var print in Design.bg) {
                Console.WriteLine(print);
            }

            line = 39;
            foreach (var print in Design.flower_design) {
                Console.SetCursorPosition(5, line);
                Console.Write(print);
                line++;
            }

            line = 7;
            foreach (var print in Design.header) {
                Console.SetCursorPosition(25, line);
                Console.Write(print);
                line++;
            }

        }
        public static void Display_Minute(string minute) {
            int line = 14;
            if (minute.Length == 1) {
                minute = "0" + minute;
            }
            switch (minute.ToString().Substring(0, 1)) {
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
            }

            switch (minute.ToString().Substring(1, 1)) {
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
            }
        }
        public static void Display_Second(string second) {
            int line = 27;
            if (second.Length == 1) {
                second = "0" + second;
            }


            switch (second.ToString().Substring(0, 1)) {
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
            }

            switch (second.ToString().Substring(1, 1)) {
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
            }
        }
        public static void Display(string[] number, int col, int line) {
            foreach (var print in number) {
                Console.SetCursorPosition(col, line);
                Console.Write(print);
                line++;
            }
        }

    }
}
