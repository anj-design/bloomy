using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Calendar2
        // okay before we start balak ko lng sabihin na ayaw ko na
    {

        public Design design = new Design();
        public Progress Progress = new Progress();
        private int currentMonth = 0;
        private List<string> monthNames;
        private List<int[]> monthData; // First day of month, total days 

        private void InitializeCalendar()
        {
            monthNames = new List<string>
            {
                "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE",
                "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"
            };

            // 2025 calendar data: {starting day of week (0=Sun), number of days}
            monthData = new List<int[]>
            {
                new int[] {3, 31}, // January starts on Wednesday
                new int[] {6, 28}, // February starts on Saturday
                new int[] {6, 31}, // March starts on Saturday
                new int[] {2, 30}, // April starts on Tuesday
                new int[] {4, 31}, // May starts on Thursday
                new int[] {0, 30}, // June starts on Sunday
                new int[] {2, 31}, // July starts on Tuesday
                new int[] {5, 31}, // August starts on Friday
                new int[] {1, 30}, // September starts on Monday
                new int[] {3, 31}, // October starts on Wednesday
                new int[] {6, 30}, // November starts on Saturday
                new int[] {1, 31}  // December starts on Monday
            };
        }

        public void Play()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;

            InitializeCalendar();

            Progress.ShowWelcomeScreen();

            bool running = true;
            while (running)
            {
                DisplayCurrentMonth();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentMonth < 11)
                            currentMonth++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (currentMonth > 0)
                            currentMonth--;
                        break;

                    case ConsoleKey.Escape:
                    case ConsoleKey.Q:
                        running = false;
                        break;
                }
            }

            Progress.ShowExitScreen(); 
            Console.CursorVisible = true; //awit sana wala pasok bukas
        }

        private void DisplayCurrentMonth()
        {
            Console.Clear();
            Progress.DrawCalendar(
                monthNames[currentMonth],
                monthData[currentMonth][0],
                monthData[currentMonth][1],
                currentMonth + 1
            );
            Progress.ShowNavigation(currentMonth, 11);
        }
    }
} // hehehehe ano lalagay ko whahaha