using System;
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

        public void Start()
        {
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

        private void RunCountdown(string label, int seconds)
        {
            for (int i = seconds; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{label}: {i} seconds remaining...");
                Console.WriteLine("\n(Press BACKSPACE to exit timer)");

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
                            return;
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
        private void DisplayAscii(string[] art)
        {
            foreach (string line in art)
                Console.WriteLine(line);
        }
    }
}
