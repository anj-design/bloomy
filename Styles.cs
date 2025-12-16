using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Styles
    {
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


        // --------------------------
        // COLOR
        // --------------------------

        public  string RESET = "\u001b[0m";
        public  string MAGENTA = "\u001b[35m";


        // --------------------------
        // TITLE
        // --------------------------
        public  string[] Bloomi = {
 @"    ┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ",
 @"    │   _______             .---.                 ,-----.                ,-----.            ,---.    ,---.        .-./`)          ________            ____     __  │ ",
 @"    │  \  ____  \           | ,_|               .'  .-,  '.            .'  .-,  '.          |    \  /    |        \ .-.')        |        |           \   \   /  / │ ",
 @"    │  | |    \ |         ,-./  )              / ,-.|  \ _ \          / ,-.|  \ _ \         |  ,  \/  ,  |        / `-' \        |   .----'            \  _. /  '  │ ",
 @"    │  | |____/ /         \  '_ '`)           ;  \  '_ /  | :        ;  \  '_ /  | :        |  |\_   /|  |         `-'`""`        |  _|____              _( )_ .'   │ ",
 @"    │  |   _ _ '.          > (_)  )           |  _`,/ \ _/  |        |  _`,/ \ _/  |        |  _( )_/ |  |         .---.         |_( )_   |         ___(_ o _)'    │ ",
 @"    │  |  ( ' )  \        (  .  .-'           : (  '\_/ \   ;        : (  '\_/ \   ;        | (_ o _) |  |         |   |         (_ o._)__|        |   |(_,_)'     │ ",
 @"    │  | (_{;}_) |         `-'`-'|___          \ `""/  \  ) /          \ `""/  \  ) /         |  (_,_)  |  |         |   |         |(_,_)            |   `-'  /      │ ",
 @"    │  |  (_,_)  /          |        \          '. \_/``"".'            '. \_/``"".'          |  |      |  |         |   |         |   |              \      /       │ ",
 @"    │  /_______.'           `--------`            '-----'                '-----'            '--'      '--'         '---'         '---'               `-..-'        │ ",
 @"    │                                                                                                                                                              │ ",
 @"    └──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘ ",
 @"                                                                         PRESS ANY KEY TO START                                                                      "   

        }; // ror

        public  string[] MotivPage = {
 @"                                                                                                                                                                     ",
 @"                                                                                                                                                                     ",
 @"           /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\              ",
 @"            \       _ _  __             _ _  __            _ _  __              _ _  __              _ _  __               _ _  __             _ _  __  /            ",
 @"            /      ( | )/_/            ( | )/_/           ( | )/_/             ( | )/_/             ( | )/_/              ( | )/_/            ( | )/_/  \            ",
 @"            \   __( >O< )           __( >O< )          __( >O< )            __( >O< )            __( >O< )             __( >O< )           __( >O< )    /            ",
 @"            /   \_\(_|_)            \_\(_|_)           \_\(_|_)             \_\(_|_)             \_\(_|_)              \_\(_|_)            \_\(_|_)     \            ",
 @"            \                                                                                                                                           /            ",
 @"            /                                                                                                                                           \            ",
 @"            /                                                                                                                                           \            ",
 @"            \       _ _  __                                                                                                                    _ _  __  /            ",
 @"            /      ( | )/_/                                                                                                                   ( | )/_/  \            ",
 @"            \   __( >O< )                                                                                                                  __( >O< )    /            ",
 @"            /   \_\(_|_)                                                                                                                   \_\(_|_)     \            ",
 @"            \                                                                                                                                           /            ",
 @"            \                                                                                                                                           /            ",
 @"            /                      .---. .----.  .----. .-. . .-.   .-.  .-..----. .-. .-..----.    .----..----.  .---. .-. .-. .----.                  \            ",
 @"            \       _ _  __       /   __}| {}  }/  {}  \| |/ \| |    \ \/ //  {}  \| { } || {}  }   | {_ /  {}  \/  ___}| { } |{ {__           _ _  __  /            ",
 @"            /      ( | )/_/       \  {_ }| .-. \\      /|  .'.  |     }  { \      /| {_} || .-. \   | |  \      /\     }| {_} |.-._} }        ( | )/_/  \            ",
 @"            \   __( >O< )          `---' `-' `-' `----' `-'   `-'     `--'  `----' `-----'`-' `-'   `-'   `----'  `---' `-----'`----'      __( >O< )    /            ",
 @"            /   \_\(_|_)          .----. .-.    .----.  .----. .-.   .-.   .-.  .-..----. .-. .-..----.    .-.   .-..-..-. .-..----.       \_\(_|_)     \            ",
 @"            \                     | {}  }| |   /  {}  \/  {}  \|  `.'  |    \ \/ //  {}  \| { } || {}  }   |  `.'  || ||  `| || {}  \                   /            ",
 @"            /                     | {}  }| `--.\      /\      /| |\ /| |     }  { \      /| {_} || .-. \   | |\ /| || || |\  ||     /                   \            ",
 @"            \      _ _  __        `----' `----' `----'  `----' `-' ` `-'     `--'  `----' `-----'`-' `-'   `-' ` `-'`-'`-' `-'`----'           _ _  __  /            ",
 @"            /     ( | )/_/                                                                                                                    ( | )/_/  \            ",
 @"            \  __( >O< )                                                                                                                   __( >O< )    /            ",
 @"            /  \_\(_|_)                                                                                                                    \_\(_|_)     \            ",
 @"            \                                                                                                                                           /            ",
 @"            /                                                                                                                                           \            ",
 @"            /                                                                                                                                           \            ",
 @"            \      _ _  __                                  ******************************************                                         _ _  __  /            ",
 @"            /     ( | )/_/                                  *    Your Focus Garden Starts Here...    *                                        ( | )/_/  \            ",
 @"            \  __( >O< )                                    ******************************************                                     __( >O< )    /            ",
 @"            /  \_\(_|_)                                                                                                                    \_\(_|_)     \            ",
 @"            \                                                                                                                                           /            ",
 @"            /                                                                                                                                           \            ",
 @"            /                                                                                                                                           \            ",
 @"            \      _ _  __            _ _  __             _ _  __               _ _  __             _ _  __               _ _  __              _ _  __  /            ",
 @"            /     ( | )/_/           ( | )/_/            ( | )/_/              ( | )/_/            ( | )/_/              ( | )/_/             ( | )/_/  \            ",
 @"            \  __( >O< )          __( >O< )           __( >O< )             __( >O< )           __( >O< )              _( >O< )             _( >O< )    /            ",
 @"            /  \_\(_|_)           \_\(_|_)            \_\(_|_)              \_\(_|_)            \_\(_|_)              \_\(_|_)             \_\(_|_)     \            ",
 @"            \                                                                                                                                           /            ",
 @"             \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/            "
        };




        // --------------------------
        // MENU
        // --------------------------
        public string[] MenuStart = {
@"                                              ____  ____  __   ____  ____    ____  __     ____  __    ___  _  _  ____                                                 ",
@"                                             / ___)(_  _)/ _\ (  _ \(_  _)  (_  _)/  \   (  __)/  \  / __)/ )( \/ ___)                                                ",
@"                                             \___ \  )( /    \ )   /  )(      )( (  O )   ) _)(  O )( (__ ) \/ (\___ \                                                ",
@"                                             (____/ (__)\_/\_/(__\_) (__)    (__) \__/   (__)  \__/  \___)\____/(____/                                                ",
        };
        public string[] MenuHistory = {
@"                                                          _  _    __    ____    ____     __     ____    _  _                                                            ",
@"                                                         / )( \  (  )  / ___)  (_  _)   /  \   (  _ \  ( \/ )                                                           ",
@"                                                         ) __ (   )(   \___ \    )(    (  O )   )   /   )  /                                                            ",
@"                                                         \_)(_/  (__)  (____/   (__)    \__/   (__\_)  (__/                                                             "
        };
        public string[] Exit = {
@"                                                                  ____    _  _    __    ____                                                                            ",
@"                                                                 (  __)  ( \/ )  (  )  (_  _)                                                                           ",
@"                                                                  ) _)    )  (    )(     )(                                                                             ",
@"                                                                 (____)  (_/\_)  (__)   (__)                                                                            "
        };




        // --------------------------
        // FOCUS TIMER
        // --------------------------
        public  string[] YesNoQuestion = {
@"                                                                                                                                                       ",
@"            .-""-,-""-.          .-""-,-""-.           .-""-,-""-.          .-""-,-""-.          .-""-,-""-.         .-""-,-""-.         .-""-,-""-.                ",
@"      _.-._(         ).-._.-._(         ).-._.--._(         ).-._ -._(         ).-._ -._(         ).-._-._(         ).-. -._(         ).-._.-._       ",
@"    .'_.-._.`.     .'_.-._.-._.`.     .'_.-._.--._.`.     .'_.-._.-._.`.     .'_.-._ -._.`.     .'_.-._-._.`.     .'_.-. -._.`.     .'_.-._.-._`.     ",
@"   ( (        `._.'              `._.'               `._.'              `._.'              `._.'             `._.'             `._.'           ) )    ",
@"    ) )                                                                                                                                       ( (     ",
@" .-""-,-""-.                                                                                                                                  .-""-,-""-. ",
@"(         )                                                                                                                                (         )",
@" `.     .'                           __   ____  ____    _  _  __   _  _    ____  _  _  ____  ____    _  _  __   _  _                        `.     .' ",
@"   `._.'                            / _\ (  _ \(  __)  ( \/ )/  \ / )( \  / ___)/ )( \(  _ \(  __)  ( \/ )/  \ / )( \                         `._.'   ",
@"    ) )                            /    \ )   / ) _)    )  /(  O )) \/ (  \___ \) \/ ( )   / ) _)    )  /(  O )) \/ (                          ( (    ",
@"   ( (                             \_/\_/(__\_)(____)  (__/  \__/ \____/  (____/\____/(__\_)(____)  (__/  \__/ \____/                           ) )   ",
@"    ) )                                   _  _   __   __ _  ____    ____  __     ____  _  _  __  ____  ___                                     ( (    ",
@" .-""-,-""-.                               / )( \ / _\ (  ( \(_  _)  (_  _)/  \   (  __)( \/ )(  )(_  _)(__ \                                 .-""-,-""-. ",
@"(         )                              \ /\ //    \/    /  )(      )( (  O )   ) _)  )  (  )(   )(   (__/                                (         )",
@" `.     .'                               (_/\_)\_/\_/\_)__) (__)    (__) \__/   (____)(_/\_)(__) (__)  (_)                                  `.     .' ",
@"   `._.'                                                                                                                                      `._.'   ",
@"    ) )                                                                                                                                        ( (    ",
@"   ( (                                                                                                                                          ) )   ",
@"     ) )     .-""-,-""-.          .-""-,-""-.          .-""-,-""-.          .-""-,-""-.         .-""-,-""-.          .-""-,-""-.           .-""-,-""-.       ( (    ",
@"    ( (_.-._(         ).-._.-._(         ).-._.-._(         ).-._.-._(         ).-._-._(         ).-._.-._(         )..-._.-._(         ).-._. _) )   ",
@"     `._.-._.`.     .'_.-._.-._.`.     .'_.-._.-._.`.     .'_.-._.-._.`.     .'_.-._-._.`.     .'_.-._.-._.`.     .'_..-._.-._.`.     .'_.-._. _,'    ",
@"               `._.'              `._.'              `._.'              `._.'             `._.'              `._.'               `._.'                ",
@"                                                                                                                                                       "
};

        public  string[] FocusInputBox = {
@"   ┌───────────────────────────┐",
@"   │   ENTER FOCUS MINUTES:    │",
@"   └───────────────────────────┘",
@"   ┌───────────────────────────┐",
@"   │   ENTER BREAK MINUTES:    │",
@"   └───────────────────────────┘"
        };

        public  string[] YesSelected =
{
@"┌──────────────────────┐",
@"│   _  _   ___   ___   │",
@"│  | || | / -_) (_-<   │",
@"│   \_, | \___| /__/   │",
@"│   |__/               │",
@"│                      │",
@"└──────────────────────┘"
};

        public  string[] NoSelected =
{
@"┌───────────────────┐",
@"│    _ _    ___     │",
@"│   | ' \  / _ \    │",
@"│   |_||_| \___/    │",
@"│                   │",
@"│                   │",
@"└───────────────────┘"
};


        public  string[] a0 = {
        @"  .-```````-.  ",
        @" / ,```````. \ ",
        @" |/ .-./ )  \| ",
        @" || \ '_ .')|| ",
        @" ||(_ (_) _)|| ",
        @" ||  / .  \ || ",
        @" ||  `-'`   || ",
        @" \'._______.'/ ",
        @"  '._______.'  "
        };

        public  string[] a1 = {
        @"        ,---.  ",
        @"       /_   |  ",
        @"         ,_ |  ",
        @"     ,-./  )|  ",
        @"     \  '_ '`) ",
        @"      > (_)  ) ",
        @"     (  .  .-' ",
        @"      `-'`-'|  ",
        @"        '---'  "
        };

        public  string[] a2 = {
        @"    .`````-.   ",
        @"   /   ,-.  \  ",
        @"  (___/  |   | ",
        @"        .'  /  ",
        @"    _.-'_.-'   ",
        @"  _/_  .'      ",
        @" ( ' )(__..--. ",
        @"(_{;}_)      | ",
        @" (_,_)-------' "
        };

        public  string[] a3 = {
        @"    .-'''-.    ",
        @"   /   _   \   ",
        @"  |__/` '.  |  ",
        @"     .--'  /   ",
        @"  ___'--._ _\  ",
        @" |   |  ( ` )  ",
        @" |   `-(_{;}_) ",
        @"  \     (_,_)  ",
        @"   `-..__.-'   "
        };

        public  string[] a4 = {
        @"      ,---.   ",
        @"     /,--.|   ",
        @"    //_  ||   ",
        @"   /_( )_||   ",
        @"  /(_ o _)|   ",
        @" / /(_,_)||_  ",
        @"/  `-----' || ",
        @"`-------|||-' ",
        @"        '-'   "
        };

        public  string[] a5 = {
        @"  ,--------.   ",
        @"  |   _____|   ",
        @"  |  )         ",
        @"  |  '----.    ",
        @"  |_.._ _  '.  ",
        @"     ( ' )   \ ",
        @"   _(_{;}_)  | ",
        @"  |  (_,_)  /  ",
        @"   `...__..'   "
        };


        public  string[] a6 = {
        @"    .------.   ",
        @"   /  .-.   \  ",
        @"  /  /   `--'  ",
        @"  |  .----.    ",
        @"  |   _ _  '.  ",
        @"  |  ( ' )   \ ",
        @"  | (_{;}_)  | ",
        @"  \  (_,_)  /  ",
        @"   `...__..'   "
        };

        public  string[] a7 = {
        @" ,----------. ",
        @"'..-------,(  ",
        @"    _ _   //  ",
        @"   (_I_) //   ",
        @"  (_(=)_)/    ",
        @"   (_I_)/     ",
        @"    ,-'/      ",
        @"   )  (       ",
        @"   `---'      "
        };

        public  string[] a8 = {
        @"   .-''''-.    ",
        @"  /  _--.  \   ",
        @"  |_( )_ ' |   ",
        @"  (_ o _). /   ",
        @" .'(_,_).  `.  ",
        @"|_( )_    \  | ",
        @"(_ o _)   /  | ",
        @" (_,_)..-' .'  ",
        @"   `-....-'    "
        };

        public  string[] a9 = {
        @"     .-````-.  ",
        @"    /  _ _   \ ",
        @"   |  ( ' )  | ",
        @"   | (_{;}_) | ",
        @"   |  (_,_)  | ",
        @"    \        | ",
        @"     `----`  | ",
        @"     .--. /  / ",
        @"     )_____.'  "
        };

        public  string[] aD = {
        @"   ______      ",
        @"  |    _ `''.  ",
        @"  | _ | ) _  \ ",
        @"  |( ''_'  ) | ",
        @"  | . (_) `. | ",
        @"  |(_    ._) ' ",
        @"  |  (_.\.' /  ",
        @"  |       .'   ",
        @"  '-----'`     "
        };

        public  string[] aO = {
        @"    ,-----.     ",
        @"  .'  .-,  '.   ",
        @" / ,-.|  \ _ \  ",
        @";  \  '_ /  | : ",
        @"|  _`,/ \ _/  | ",
        @": (  '\_/ \   ; ",
        @" \ ` /  \  ) /  ",
        @"  '. \_/`` .'   ",
        @"    '-----'     "
        };

        public  string[] aN = {
        @"  ,---.   .--. ",
        @"  |    \  |  | ",
        @"  |  ,  \ |  | ",
        @"  |  |\_ \|  | ",
        @"  |  _( )_\  | ",
        @"  | (_ o _)  | ",
        @"  |  (_,_)\  | ",
        @"  |  |    |  | ",
        @"  '--'    '--' ",
        };

        public  string[] aE = {
        @"     .-''-.    ",
        @"    .'_ _   \  ",
        @"   / ( ` )   ' ",
        @"  . (_ o _)  | ",
        @"  |  (_,_)___| ",
        @"  '  \   .---. ",
        @"   \  `-'    / ",
        @"    \       /  ",
        @"     `'-..-'   "
        };

        public  String[] flower_design = {
        @"    (_\_)",
        @"   (__<_{}",
        @"    (_/_)",
        @"   |\ |",
        @"    \\| /|",
        @"     \|//",
        @"      |/",
        @" ,.,.,|.,.,.",
        @" ^`^`^`^`^`^"
        };

        public  string[] header =
        {
        @"                         _  ",
        @" |_  |  _   _  ._ _  o _|_  ",
        @" |_) | (_) (_) | | | |  | \/",
        @"                          / "
        };

        public  string[] bg =
        {
            @"┌───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"│                                                                                                                                                                       │ ",
            @"└───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘ "
        };
















        // --------------------------
        // ANIMATION
        // --------------------------
        public  string[] rose_1 = {
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"             ⢠⠃⠱⡀         ",
        @"             ⡞  ⢣         ",
        @"            ⢠⠇  ⠘⡆        ",
        @"            ⡞    ⢱        ",
        @"           ⢰⠁    ⠈⡆       ",
        @"           ⡞      ⢱       ",
        @"           ⡇      ⢸       ",
        @"           ⠓⠒⠒⠒⠒⠒⠒⠚       ",
        @"             ⢸⠇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⠇           ",
        @"             ⠘⠃           ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀            ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };

        public  string[] rose_2 = {
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"               ⢀⣀         ",
        @"             ⢀⡔⠋⠈⠳⡀       ",
        @"            ⢠⠎    ⠱⡀      ",
        @"            ⡞      ⢣      ",
        @"            ⡇      ⠘⡆     ",
        @"            ⣇       ⢸     ",
        @"            ⠸⡀      ⡸     ",
        @"             ⠳⡄   ⢀⡜⠁     ",
        @"              ⠈⠑⠒⠊⠁       ",
        @"               ⢸⡇         ",
        @"               ⢸⠇         ",
        @"               ⢸          ",
        @"               ⠚          ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀            ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };

        public  string[] rose_3 = {
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"              ⣀⡀                   ",
        @"           ⢀⠔⠋⠁⠈⠓⢄                 ",
        @"          ⡠⠃     ⠈⢆                ",
        @"         ⡰⠁       ⠈⢆               ",
        @"        ⢠⠃         ⠈⡆              ",
        @"        ⡎           ⢱              ",
        @"       ⢰⠁           ⠈⡆             ",
        @"       ⡎             ⢱             ",
        @"      ⢰⠁             ⠈⡆            ",
        @"      ⠸⡀             ⢀⠇            ",
        @"       ⠱⣄           ⣠⠎             ",
        @"        ⠈⠓⢄⡀     ⣀⡤⠊               ",
        @"       ⣀⠤⠒⠒⠚⠛⠒⠒⠛⠉⠁                 ",
        @"     ⣠⠞⠁       ⢸⡇                  ",
        @"     ⠈⠉⠉⠉⠉⠉⠉⠉⠉⠉⢸⠇ ⠉⠉⣠⠞⠁            ",
        @"               ⡞      ⣠⠞⠁          ",
        @"               ⠓⠂ ⠉⠉⠉⠉⠉⠉           ",
        @"              ⢸⡇                   ",
        @"              ⢸⡇                   ",
        @"              ⢸⡇                   ",
        @"              ⢸⡇                   ",
        @"⠀⠀  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀         ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀            ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
};

        public  string[] rose_4 = {
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"                                   ",
        @"               ⣀⡀                  ",
        @"           ⢀⠤⠊⠉ ⠈⠑⢄                ",
        @"          ⡰⠁      ⠈⢆               ",
        @"         ⡜  ⡠⠒⠉⠉⠒⢄ ⠈⡆              ",
        @"        ⢰⠁⢀⠎     ⠈⢆ ⠸⡀             ",
        @"        ⡎ ⡎       ⠘⡆ ⢣             ",
        @"       ⢰⠁⢰⠁        ⢱ ⠘⡆            ",
        @"       ⡎ ⡎         ⠘⡆ ⢱            ",
        @"      ⢰⠁ ⣇          ⣸ ⠈⡆           ",
        @"      ⠸⡀ ⠘⢆        ⡰⠁ ⢀⠇           ",
        @"       ⠱⡀ ⠈⠳⢄⡀  ⣀⡠⠞⠁ ⢀⡞            ",
        @"        ⠈⠢⣀  ⠈⠉⠉⠁  ⢀⡤⠊             ",
        @"           ⠉⠒⠤⣀⣀⡤⠔⠊⠁               ",
        @"               ⢸⡇ ⡠⠒⠒⠉⠉⠉⠉⠑⠢⠤⡀      ",
        @"               ⡞⡴⠋          ⠈⡆     ",
        @"              ⢠⢃⠇            ⢸     ",
        @"              ⡞⡼             ⢸     ",
        @"              ⡇⡇⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉       ",
        @"              ⠓⠓                   ",
        @"       ⣠⠞⠁⠉⠉⠉⢸⡇                    ",
        @"      ⣠⠞     ⢸⡇                    ",
        @"        ⠉⠉⠉⠉⠉⢸⡇                    ",
        @"             ⢸⡇                    ",
        @"             ⢸                     ",
        @"             ⢸⡇                    ",
        @"             ⢸                     ",
        @"             ⢸⡇                    ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };

        public  string[] rose_5 = {
        @"                              ",
        @"                              ",
        @"                              ",
        @"                              ",
        @"                              ",
        @"                              ",
        @"                              ",
        @"                              ",
        @"                         ⢱     ",
        @"                        ⢱ ⢱         ",
        @"              ⢀⠤      ⢱⢄  ⢱         ",
        @"             ⡰⠁⢱     ⢱⠈⢆ ⢱ ⢱        ",
        @"            ⡜  ⡠⠒⠉⠉ ⠒⢄ ⠈⡆ ⢱         ",
        @"           ⢰⠁⢀⠎     ⠈⢱ ⢆ ⠸⡀⢱        ",
        @"           ⡎ ⡎ ⢱     ⢱ ⠘⡆ ⢣⢱ ⣶⠤     ",
        @"          ⢰⠁⢰⠁⢱     ⢱  ⢱ ⠘⡆⢱  ⡤⠚⠁⣶⠤ ",
        @"         ⡎ ⡎    ⢱  ⢱    ⠘⡆ ⢱⠖⠒⠒⢒    ",
        @"         ⢰⠁ ⣇    ⢱      ⣸ ⠈⡆        ",
        @"       ⣶⠤ ⠸⡀ ⠘⢆   ⢱     ⡰⠁ ⢀⠇       ",
        @"       ⠉⠒ ⠱⡀ ⠈⠳⢄⡀⢱  ⣀⡠⠞⠁ ⢀⡞         ",
        @"        ⣶⠤ ⠈⠢⣀  ⠈⠉⠉⠁  ⢀⡤⠊           ",
        @"              ⠉⠒⠤⣀⣀⡤⠔⠊⠁             ",
        @"     ⢤⣤⣤⡤⠤⠤⠤⠤⣌⡉⠉⠁  ⢸⢸⠁⡠⠖⠒⠒⢒⣒⡶⣶⠤     ",
        @"      ⠉⠲⣍⠓⠦⣄  ⠙⣆   ⡞⡼⡼⢀⣠⠴⠊⢉⡤⠚⠁      ",
        @"        ⠈⠳⣄⠈⠙⢦⡀⢸⡀ ⢰⢣⡧⠷⣯⣤⠤⠚⠉         ",
        @"          ⠈⠑⣲⠤⠬⠿⠧⣠⢏⡞                ",
        @"        ⢀⡴⠚⠉⠉⢉⣳⣄⣠⠏⡞                 ",
        @"      ⣠⣴⣟⣒⣋⣉⣉⡭⠟⢡⠏⡼                  ",
        @"      ⠉       ⢀⠏⣸⠁                  ",
        @"              ⡞⢠⠇                   ",
        @"             ⠘ ⠚                    ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⠘⠓⠚⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };


        public  string[] rose_6 = {
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"                                       ",
        @"               ⣀⡀                      ",
        @"             ⡠⠖⠋⠉⠉⠳⡴⠒⠒⠒⠲⠤⢤⣀            ",
        @"           ⣠⠊  ⡴⠚⡩⠟⠓⠒⡖⠲⡄  ⠈⡆           ",
        @"       ⢀⡞⠁⢠⠒⠾⢥⣀⣇⣚⣹⡤⡟ ⡇⢠ ⢠⠇             ",
        @"         ⢸⣄⣀ ⡇     ⢀⡜⠁⣸⢠⠎⣰⣃            ",
        @"        ⠸⡍ ⠉⠉⠛⠦⣄ ⢀⡴⣫⠴⠋⢹⡏⡼⠁⠈⠙⢦⡀         ",
        @"        ⣀⡽⣄    ⠈⠙⠻⣎⡁  ⣸⡾    ⣀⡹⠂        ",
        @"      ⢀⡞⠁ ⠈⢣⡀      ⠉⠓⠶⢟ ⢀⡤⠖⠋⠁          ",
        @"       ⠉⠙⠒⠦⡀⠙⠦⣀      ⢀⣴⡷⠋              ",
        @"           ⠘⢦⣀⠈⠓⣦⣤⣤⣤⢶⡟⠁                ",
        @"     ⢤⣤⣤⡤⠤⠤⠤⠤⣌⡉⠉⠁  ⢸⢸⠁⡠⠖⠒⠒⢒⣒⡶⣶⠤        ",
        @"      ⠉⠲⣍⠓⠦⣄  ⠙⣆   ⡞⡼⡼⢀⣠⠴⠊⢉⡤⠚⠁         ",
        @"        ⠈⠳⣄⠈⠙⢦⡀⢸⡀ ⢰⢣⡧⠷⣯⣤⠤⠚⠉            ",
        @"          ⠈⠑⣲⠤⠬⠿⠧⣠⢏⡞                   ",
        @"        ⢀⡴⠚⠉⠉⢉⣳⣄⣠⠏⡞                    ",
        @"      ⣠⣴⣟⣒⣋⣉⣉⡭⠟⢡⠏⡼                     ",
        @"      ⠉       ⢀⠏⣸⠁                     ",
        @"              ⡞⢠⠇                      ",
        @"             ⠘ ⠚                       ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⠘ ⠚⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };




        public  string[] sunflower_1 = {
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"                       ",
        @"             ⣀⣀        ",
        @"           ⢀⣾⣿⣿⡄       ",
        @"           ⣾⣿⣿⣿⣷       ",
        @"           ⢿⣿⣿⣿⡿       ",
        @"           ⠈⠻⠿⠟⠁       ",
        @"             ⢸         ",
        @"             ⢸         ",
        @"             ⢸         ",
        @"             ⢸         ",
        @"             ⢸         ",
        @"             ⢸⡇        ",
        @"             ⢸⡇        ",
        @"             ⢸⡇        ",
        @"             ⢸⡇        ",
        @"             ⢸⡇        ",
        @"             ⢸⣿        ",
        @"             ⢸⣿        ",
        @"             ⢸⣿        ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
};

        public  string[] sunflower_2 = {
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"                          ",
        @"          ⣀  ⢀⡀           ",
        @"          ⠹⣄ ⢸⠁           ",
        @"           ⢹⡄⣾            ",
        @"            ⢿⣿⣷⡀          ",
        @"           ⢀⣿⣿⣿⣧          ",
        @"           ⣾⣿⣿⣿⣿          ",
        @"           ⢿⣿⣿⡿⠃          ",
        @"           ⠈⠉⢹⠁           ",
        @"             ⢸            ",
        @"             ⢸            ",
        @"             ⢸⡆           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⡇           ",
        @"             ⢸⣧           ",
        @"             ⢸⣿           ",
        @"             ⢸⣿           ",
        @"             ⢸⣿           ",
        @"             ⠘⠉           ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
};

        public  string[] sunflower_3 = {
        @"                                ",
        @"                                ",
        @"                                ",
        @"                                ",
        @"                                ",
        @"                                ",
        @"                                ",
        @"          ⢠⡀ ⢸  ⢀⡄              ",
        @"          ⠈⣧ ⣾  ⣼⠁              ",
        @"           ⢹⣰⡏ ⢠⡏               ",
        @"           ⠘⣿⡇ ⢸⠇⢠⡏    ⢀⡄       ",
        @"           ⢀⣿⣷⣴⣿⡀    ⢀⡄ ⢠⡏      ",
        @"          ⢀⣾⣿⣿⣿⣿⣧⣼⠁⢀⡄  ⢀⡄       ",
        @"          ⣾⣿⣿⣿⣿⣿⣿  ⢠⡏⢸⠇         ",
        @"          ⢻⣿⣿⣿⣿⡿⠋⢸⠇             ",
        @"           ⠉⠉⢹⠋                 ",
        @"             ⢸⡀                 ",
        @"             ⢸⡇                 ",
        @"             ⢸⡇                 ",
        @"             ⢸⡇                 ",
        @"             ⢸⡇                 ",
        @"             ⢸⡇                 ",
        @"             ⢸⡇   ⢠⡏            ",
        @"             ⢸⡷ ⢠⡏              ",
        @"         ⢠⡏  ⢸⡇                 ",
        @"          ⢠⡏ ⢸⡇                 ",
        @"            ⢠⡏⣧                 ",
        @"             ⢸⣿                 ",
        @"             ⢸⣿                 ",
        @"             ⢸⣿                 ",
        @"             ⠘⠉                 ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
        };


        public  string[] sunflower_4 = {
        @"                                    ",
        @"                   ⣾⠁                ",
        @"                ⢠⠘⣷⣾⠁                ",
        @"          ⠙⢦⡀   ⢠⡄⣿⡇ ⢠⡇⢠⡄⢠⡄⢠ ⢀⣴⠋    ",
        @"            ⠙⢦⣀ ⢠⡄⣿⣧⣴⣿     ⢀⣠⠞⠋     ",
        @"              ⠙⢷⣦⣴⣾⣿⣿⣿⣿⣷⣦⡴⠾⠋⠁       ",
        @"         ⡴⠾⠋⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀ ⠙⢷⣦     ",
        @"        ⡴⠾⠋⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀        ",
        @"       ⡴⠾⠋⡴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢦⡀⠙⢷⣦   ",
        @"     ⠙⢷⣦⣠⠋⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠙⣆      ",
        @"       ⣰⠃ ⢸⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟ ⠸⣆ ⠙⢷⣦  ",
        @"    ⡴⠾⠋⡟  ⠘  ⠉⠛⢿⣿⣿⡿⣿⠟⠋⠉      ⣿  ⠙⢷⣦ ",
        @"    ⠙⢷⣦⢧    ⢸⠿⣿⣿⣿⣿⣿⣿        ⡟⣴⠋⢰⡆   ",
        @"       ⠘⣆  ⢸⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿  ⣼⠁   ⢰⡆   ",
        @"      ⡴⠾⠋⠘⢦⡀ ⢸⠿⣿⣿⣿⣿⣿⣿   ⢀⣠⠞⠁  ⣠⠞⠋   ",
        @"     ⠙⢷⣦⠙⢷⣦⠙⠦⣄⡀       ⣀⡤⠖⠋ ⠾⠋⠁      ",
        @"             ⠉⠓⠦⢤⣀⣸⠒⠋  ⢰⡆   ⠙⢷⣦     ",
        @"         ⡴⠾⡴⠾⠋ ⣀⡴  ⠙⢷⣦ ⢰⡆⣠⢰⣠⠞⠋      ",
        @"               ⢸⡿                   ",
        @"               ⢸⡇          ⢀⠆       ",
        @"               ⢸⣧       ⢀⡿⠛⠋        ",
        @"       ⣷⣤     ⢸⣿       ⣠⠊           ",
        @"        ⣿⣿⣿   ⢸⣿ ⣧ ⣀⡴⠃              ",
        @"         ⠈⠛⠿⣿ ⢸⣿                    ",
        @"            ⠸⡆ ⠘⠉                   ",
        @"              ⢻⢸⣿                   ",
        @"             ⢸⣿                     ",
        @"             ⢸⣿                     ",
        @"              ⢸⣿                    ",
        @"             ⢸⣿                     ",
        @"             ⢸⣿                     " ,
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
};

        public  string[] sunflower_5 = {
        @"                                                  ",
        @"                                                  ",
        @"                         ⢀⡾⢷⡄                     ",
        @"                        ⢀⣾⠁ ⠻⣆    ⣀⣤⢶⡄           ",
        @"                ⢰⡷⠶⠶⣤⣄  ⣼⠃⢀  ⢻⡆⢀⣴⠟⠉ ⢸⡇           ",
        @"                ⢸⡇   ⠙⢿⣤⡿⢀⢸⡇ ⠘⣷⣿⠁   ⢸⡇           ",
        @"                ⠘⣷  ⢠⡀⠈⢻⣷⠸⣼⡇ ⢠⣿⣹⠁ ⢀⢀⣾⢁⣀⣀⣤⣤⣤⣤⡀    ",
        @"           ⢸⡟⠛⠛⠛⠛⢿⣧⡀⢀⣳⡜ ⣿⣦⡿⠧⠤⢾⣿⣯⣘⡔⣡⣾⠟⠋⠉   ⢀⣾⠁    ",
        @"            ⢻⡄ ⢀⡀ ⠙⢿⣶⣬⣵⠞⠋     ⢠⢈⡝⢿⣿⠡⣃⠴⠊  ⣠⡾⠃     ",
        @"             ⠻⣆ ⠙⠢⣔⡌⣻⡞⠡⣌⣉     ⠘⠂ ⠠⠙⣯⡑⠂⢀⣠⣶⠟⠁      ",
        @"             ⣀⣙⣷⣦⣾⣾⢿⡟⠠⠤⡤           ⢸⣿⣿⡿⠿⢥⣤⣄⣀     ",
        @"          ⣠⡶⠟⠋⠉⠁⠉⢉⡛⣿⡇ ⠖⠂           ⢸⡏⢻⣉⣀  ⠈⠙⠻⣦⣄  ",
        @"         ⢸⣏⡀    ⠒⠂⡀⢸⡇           ⣀⣀⡏⢸⣷⣝⣒⠂⠤⣀⣀⣠⣤⠾⠋  ",
        @"          ⠈⠛⠷⢶⣤⣤⣬⡿⠾⠿⣷⡀          ⠉⠍⢁⣿⣿⠛⠿⢿⣟⠛⠉⠉     ",
        @"            ⢀⣴⠞⠋  ⣀⠷⣸⣷⣄⡀        ⠂⣠⣾⣯⠛⢭⡁ ⠙⢷⣄      ",
        @"            ⣾⠃   ⠉ ⢠⣷⠿⢛⠻⣶⣤⣄⣀⣀⣀⣠⣤⣾⣟⠻⢿⣧⡀    ⠹⣦     ",
        @"           ⠘⠳⠶⠶⠶⠶⠶⣾⠟⠁⢀⠞⡏⢸⣿⢏⠯⠉⡍⣿⡏⢇⠛⠑ ⠙⣿⢶⣤⣄⣀⣠⣼⡇    ",
        @"                 ⢸⡏    ⣡⡿⡟⠈⢸ ⠁⣼⣷⡘    ⢿ ⠈⠉⠉⠉      ",
        @"                 ⣾⠇ ⣠⣴⠾⠋ ⣿   ⢠⡟⠙⢷⣄⡀  ⣼           ",
        @"                 ⠹⠶⠛⠉    ⢹⣇ ⢠⡿⠁  ⠙⠻⣦⣄⣿           ",
        @"                ⡿         ⠻⣦⡟⠁      ⠉⠁           ",
        @"             ⢸⡿                                  ",
        @"               ⢸⡇          ⢀⠆                    ",
        @"               ⢸⣧    ⡴⠉⣠⠴⠛⠉⠛⣋⡗⠢⢤⢀                ",
        @"       ⣷⣤     ⢸⣿            ⣠⣬⡵⣠⣬⡵               ",
        @"     ⢿⣰⠇⣿⣿⣿   ⢸⣿ ⣧ ⣀  ⣠⣬⡵     ⡴⠃                 ",
        @"      ⢿⣰⠇⠈⠛⠿⣿ ⢸⣿    ⢷⣳⡒⠄⢀⣤⣤⡤⡤⠛⠉⠁                 ",
        @"      ⠘⢷⣾⠓    ⠸⡆ ⠘⠉                              ",
        @"      ⢿⣰⠇     ⢻⢸⣿                                ",
        @"              ⢸⣿                                 ",
        @"             ⢸⣿                                  ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀     ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠈"
};


        public  string[] sunflower_6 = {
        @"          ⣤⡀  ⣷⡄ ⢀⣷                            ",
        @"        ⣤⣀⣀ ⠐⣿⠙⢦⣼⡃⠉⢦⡼⠏⣇⣀⣼⡇  ⡀                  ",
        @"        ⠹⡄ ⠉⠑⢿  ⣏  ⢸⠁ ⢿⡿⢣⢹⣠⠴⣿                  ",
        @"      ⢶⢤⣤⣿⡀   ⠱⡀⢹⡀ ⡯⠄ ⢨⣇⡴⠃  ⡏⢀⣠⡶               ",
        @"    ⢀⣀⣸⣦  ⢣⡀   ⣧⡀⠳⣄⣹⡄⢀⣾⡟⢀⡴⠒⠋⠉⠁⢸⠁⢀⣀⡀            ",
        @"    ⠹⣅ ⠹⣄⣀ ⠈⠲⢤⣴⣾⣽⣿⣾⣿⣿⣿⣿⣧⣼    ⡠⠛⠛⣻⠋             ",
        @"   ⢠⡴⠛⠉⠉⠙⠺⣍⠙⣶⣺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡤⠖⠋⢀⡠⠾⠉⠙⣶⡶           ",
        @"    ⣉⡷⣀   ⢈⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡖⢋⣩⠤⢄⣢⡼⠋            ",
        @"   ⠻⣇  ⣉⣩⣙⡛⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠉    ⠙⣲⣤⣀          ",
        @"   ⢀⣠⠟⠋⠁  ⠉⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣍⡷⠦⣄⣀⣀⣀⠼⠛⠋          ",
        @"   ⠛⠳⣄⣀⣤⠶⠛⠛⢛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠛⠒⠲⢄⡀ ⠈⢳⡀           ",
        @"     ⢀⠏    ⡴⠭⢾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠊⠑⠒⢄ ⠙⣆⣀⣸⡷⠄          ",
        @"     ⣿⣀ ⢀⣠⠞  ⡸⢙⡿⢻⢿⣿⢿⡿⡟⣿⣿⠙⢣   ⠈⣦⡀⠹⣧⡀            ",
        @"     ⠉⠉⢉⡟⠁ ⣠⣶⡟⠁ ⢸⠋⢻⡜ ⠛⣟⢱  ⠳⣀  ⠸⣌⠉⠉⠃            ",
        @"       ⢸⡷⣶⡾⣋⡟ ⢀⣀⡞ ⢸   ⠸⡈⢆  ⠸⡍⠉⠉⠙⠃              ",
        @"         ⠘⠉⢡⡷⠖⣾⡷  ⠸⣄⡀ ⣼⣇⠈⠻⡦⣤⣇                  ",
        @"              ⣿⢳⣤⣤⡔⠙⢷⣼⠇⠉⠷⣸⡇ ⠉                  ",
        @"             ⢸⣼ ⠛⠁   ⠉   ⠈⠁                    ",
        @"       ⣀⡤⠤⡤⣀ ⢸⡿                                ",
        @"    ⢀⡴⠚⠉⣀⣤⣄⣁⣵⢼⡳  ⢀⣀⣀⣀⣀⡀                        ",
        @"    ⣾⠃⣠⠞⡟⢁⡴⠛⣻⢾⡇ ⡴⠉⣠⠴⠛⠉⠛⣋⡗⠢⢤⡀                   ",
        @"    ⢿⣰⠇⡀⣰⠋  ⣻⢹⡇⠈⡇⣠⠋⣀⡤⠚⠉ ⠉⢀⣠⣬⡵⢦⣀                ",
        @"    ⠘⣿⡇⡗⠃⢀⣼⣵⠟⢸⣧⣾⡿⠟⠙⠯⡛⠫⢍⠉⠉⠙⠽⢖⡛⢭⣿⣷⡄              ",
        @"     ⠘⢷⣾⠓⠉⠉  ⢸⡟⢰⠳⠄  ⠈⠲⣄⠈  ⣀⡴⠟⠛⠉⠉               ",
        @"      ⠈⠛     ⢸⠇⠘⢷⣳⡒⠄⢀⣤⣤⡤⡤⠛⠉⠁                   ",
        @"             ⢸⢿  ⠉⠉⠉⠉⠉                         ",
        @"             ⢸⣾⠁                               ",
        @"             ⢸⣿                                ",
        @"             ⢸⣿                                ",
        @"             ⢸⣿                                ",
        @"             ⢸⣿                                ",
        @"             ⠘⠉                                ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀            ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠈"
         };

        public  string[] bloom_1 = {
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                                                ",
        @"                                           ⢀⠆                   ",
        @"                                          ⣠⣿⡇                   ",
        @"                                        ⣠⣾⣿⣿⡇                   ",
        @"                                       ⣼⣿⣿⣿⣿                    ",
        @"                                       ⣿⣿⣿⡿⠃                    ",
        @"                                      ⢀⡿⠛⠋                      ",
        @"                                     ⣠⠊                         ",
        @"                                   ⣀⡴⠃                          ",
        @"                                 ⣠⠴⠚⠁                           ",
        @"                              ⣠⠴⠚⠁                              ",
        @"                           ⣤⠖⠋⠁                                 ",
        @"                         ⢠⡟⠉                                    ",
        @"                        ⢠⡿                                      ",
        @"                       ⢀⡾⠁                                      ",
        @"                      ⢠⡿⠁                                       ",
        @"                     ⣰⢟                                         ",
        @"                    ⢀⣼⠃                                         ",
        @"                    ⢀⡾                                          ",
        @"                    //⣼⠃                                       ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀ // ⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀             ",
        @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀ ⠋            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
        @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
        @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };


        public  string[] bloom_2 = {
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                       ⣇                ",
            @"                                       ⢸      ⢀⠆        ",
            @"                                       ⠘⡆    ⣠⣿⡇        ",
            @"                                        ⢻⡀ ⣠⣾⣿⣿⡇        ",
            @"                                         ⢧⣼⣿⣿⣿⣿         ",
            @"                                         ⣿⣿⣿⣿⡿⠃         ",
            @"                                        ⢀⡿⠛⠋            ",
            @"                                       ⣠⠊               ",
            @"                            ⣇        ⣀⡴⠃                ",
            @"                            ⢻⡀    ⣠⠴⠚⠁                  ",
            @"                              ⣇ ⣠⠴⠚⠁                    ",
            @"                            ⣤⠖⠋⠁                        ",
            @"                          ⢠⡟⠉                           ",
            @"                         ⢠⡿                             ",
            @"                        ⢀⡾⠁                             ",
            @"                       ⢠⡿⠁                              ",
            @"                      ⣰⢟                                ",
            @"                     ⢀⣼⠃                                ",
            @"                     ⢀⡾                                 ",
            @"                     ⣼⠃                                 ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀  ⣼⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀  ⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠋            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };

        public  string[] bloom_3 = {
            @"                                              ",
            @"                                              ",
            @"                                              ",
            @"                                              ",
            @"                                              ",
            @"                                                ",
            @"                                                ",
            @"                                                 ",
            @"                                                 ",
            @"                                      ⢠          ",
            @"                                      ⣿          ",
            @"                                     ⣼⣿          ",
            @"                                      ⡿⠋         ",
            @"                             ⣿⣷⣦    ⢸⣿      ⣇    ",
            @"                              ⣿⣿⣿⣷  ⢸⣧       ⢀⠆  ",
            @"                               ⣿    ⠉⠻⣆     ⣠⣿   ",
            @"                               ⠙⣧⡀    ⢸    ⣾⣿⣿   ",
            @"                   ⣄             ⢹        ⣿⣿⣿    ",
            @"                    ⣷⣤           ⣇       ⣿⣿⡿⠃    ",
            @"                    ⣿⣿⣿           ⢸     ⢀⡿⠛      ",
            @"                     ⣿⣿           ⠘⡆   ⣠⠊        ",
            @"                     ⣿⣿⣿           ⣧ ⣀⡴⠃         ",
            @"                     ⢿⣿⣿⣿          ⢸⠴⠚⠁          ",
            @"                     ⠈⠛⠿⣿⠇        ⣠⠋             ",
            @"                        ⠸⡆       ⡴⠃              ",
            @"                         ⢻⡀   ⣠⠴⠚⠁               ",
            @"                          ⢧⣤⠖⠋⠁                  ",
            @"                         ⢠⡟⠉                     ",
            @"                        ⢠⡿                       ",
            @"                       ⢠⡿                        ",
            @"                     ⢠⡿                        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀   ⣼⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠋            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };

        public  string[] bloom_4 = {
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                                        ",
            @"                                      ⣾⣧                ",
            @"                                     ⣼⣿⣿⡆               ",
            @"                            ⣄       ⢰⣿⡿⠋                ",
            @"                            ⢹⣿⣷⣦    ⢸⣿      ⣇           ",
            @"                             ⢻⣿⣿⣿⣷  ⢸⣧       ⢀⠆         ",
            @"                              ⢻⣿    ⠉⠻⣆     ⣠⣿          ",
            @"                               ⠙⣧⡀    ⢸   ⣠ ⣿⣿⡇         ",
            @"                   ⣄             ⢹       ⣼⣿⣿ ⣿          ",
            @"                   ⢻⣷⣤⡀           ⣇      ⣿  ⡿⠃          ",
            @"                   ⢸ ⣿⣿⣦⡀         ⢸     ⢀⡿⠛⠋            ",
            @"                   ⢸⣿⣿  ⣷⡀        ⠘⡆   ⣠⠊               ",
            @"                   ⠈⣿  ⣿⣿⣷         ⣧ ⣀⡴⠃                ",
            @"                    ⠘⢿⣿            ⢸⠴⠚⠁                 ",
            @"                     ⠈⠛⠿⣿⠇       ⣠⠋                     ",
            @"                        ⠸⡆     ⡴⠃                       ",
            @"                         ⢻⡀ ⣠⠴⠚⠁                        ",
            @"                          ⢧⣤⠖⠋⠁                         ",
            @"                         ⢠⡟⠉                            ",
            @"                        ⢠⡿                              ",
            @"                       ⢠⡿                               ",
            @"                      ⢠⡿                                 ",
            @"                     ⢠⡿                                ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀   ⣼⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠋            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };

        public  string[] bloom_5 = {
            @"                                                     ",
            @"                                                     ",
            @"                                                     ",
            @"                                                     ",
            @"                                                     ",
            @"                                                     ",
            @"                                                     ",
            @"                                       ⢠             ",
            @"                                       ⣾⣧            ",
            @"                                      ⣼⣿⣿⡆           ",
            @"                             ⣄       ⢰⣿⡿⠋            ",
            @"                             ⢹⣿⣷⣦    ⢸⣿      ⣇       ",
            @"                              ⢻⣿⣿⣿⣷  ⢸⣧       ⢀⠆     ",
            @"                               ⢻⣿    ⠉⠻⣆     ⣠⣿⡇     ",
            @"                                ⠙⣧⡀    ⢸   ⣠⣾⣿⣿⡇     ",
            @"                    ⣄             ⢹   ⣿   ⣼⣿⣿⣿⣿      ",
            @"                    ⢻⣷⣤⡀           ⣇  ⢸   ⣿⣿⣿⡿⠃      ",
            @"                    ⢸⣿⣿⣿⣦⡀         ⢸  ⣿ ⢀⡿⠛⠋         ",
            @"                    ⢸⣿⣿⣿⣿⣷⡀        ⠘⡆⢸  ⣠⠊           ",
            @"                    ⠈⣿⣿⣿⣿⣿⣷         ⣧ ⢸⣀⡴⠃           ",
            @"                     ⠘⢿⣿⣿⣿⣿         ⢸⠴⠚⠁             ",
            @"                      ⠈⠛⠿⣿⠇        ⣠⠋                ",
            @"                         ⠸⡆       ⡴⠃                 ",
            @"                          ⢻⡀   ⣠⠴⠚⠁                  ",
            @"                           ⢧⣤⠖⠋⠁                     ",
            @"                          ⢠⡟⠉                        ",
            @"                        ⢠⡿                           ",
            @"                       ⢠⡿                            ",
            @"                      ⢠⡿                             ",
            @"                     ⢠⡿                                 ",
            @"                     ⢠⡿                              ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀   ⣼⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀          ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠋            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"

        };


        public  string[] bloom_6 = {
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                                         ",
            @"                                                      ⢀⡔⠋⠻⠚⣆             ",
            @"                                                     ⠈⠳⡝⠆   ⠁⡧           ",
            @"                                                       ⢹⣼⡀⢀⣀⠜⠃           ",
            @"                                                       ⣾⠿⠛⠙              ",
            @"                                           ⢺⢽        ⢠⡿⠄                 ",
            @"                                            ⣰⣤⣄⡌   ⢀⣴⠟⠁                  ",
            @"                                                ⠶⣮⣠⡾⠃           ⣰⣤⣄⡌⣄⢀   ",
            @"                             ⣰⣤⣄⡌⣄⢀             ⡟⣿⠉           ⢺⢽⡝⣦⣺⢁⣴⡊   ",
            @"                            ⢺⢽⡝⣦⣺⢁⣴⡊            ⢰⡿⠃         ⠷⡜⢱⠙⡴⣧       ",
            @"                            ⢈⡯⢮⣏⣸⣗⠛⠏           ⢠⣻⠋       ⣞⠁ ⠁⠌⠛⠹⣀        ",
            @"                             ⠷⡜⢱⠙⡴⣧           ⢠⣷⠃  ⢀⣀⣤⣴⡶⠿⠛⠳⢤⣀            ",
            @"                              ⠁⠌⠛⠹⣀         ⢀⡴⣣⣷⣶⡾⠽⠿⣫⠭⠤⢤⡀                ",
            @"                                  ⡞⣆        ⢀⡴⣿⠟⠉⠁                       ",
            @"                                   ⡞⣆  ⢀⣤⢞⡵⠟⠁                            ",
            @"                                   ⡟⢸⠒⣋⡥⠞⠉                               ",
            @"                                 ⢠⠞⠁⣩⠞⠁                                  ",
            @"                               ⣠⠖⢋⡠⠞⠁                                    ",
            @"                             ⣖⠋⣡⡔⠋                                       ",
            @"                            ⢸⠃⣴⠗                                         ",
            @"                           ⢠⠏⣸⠏                                          ",
            @"                          ⣰⠃⢠⠇                                           ",
            @"                        ⢀⠞⠁⢀⠞                                            ",
            @"                     ⢀⣴⣫⠤⠖⠋                                              ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀   ⣼⣼⠋⠀  ⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⠀⠀        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠋⣼            ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };

        public  string[] bloom_7 = {
            @"                                                                             ",
            @"                                                                             ",
            @"                                                                             ",
            @"                                                                             ",
            @"                                                            ⣀⡤               ",
            @"                                                         ⣠⠖⠋ ⢻⡀              ",
            @"                                                   ⢀⢴⠾⠑⢦⡞⠃  ⣼⠇               ",
            @"                                                   ⣯⠌   ⢳   ⢠⠧               ",
            @"                                                   ⢇⢀⡔⠋⠻⠚⣆⢀⣀⡠⠋               ",
            @"                                                    ⡝⠆   ⠁⡧⠆⠈⢣               ",
            @"                                         ⡄⠉         ⣼⡀⢀⣀⠜⠃  ⢺⡃               ",
            @"                                        ⢧   ⠙⢶       ⣾⠿⠛⠙                    ",
            @"                         ⢀               ⣇    ⠈⡇    ⢠⡿⠄      ⡒⠒⠲⢤⡀ ⢀  ⣀⣠     ",
            @"                        ⢠⠋ ⢠ ⠙⣆           ⢦⡀⡀  ⢀⡏ ⢀⣴⠟⠁    ⢀⡜  ⡄  ⢙⡞⠁  ⢀⠈⢦    ",
            @"                        ⡇⠨⡄  ⢀⠜⠃⠈⠉⣱⡆        .⠲⠶⠶⣮⣠⡾⠃      ⠈⣇    ⢸ ⢠⢀   ⠈⣶    ",
            @"                        ⢳⡀  ⣰⣤⣄⡌⣄⢀⢀⠠⠒⠁⡇         ⡟⣿⠉      ⢀⡴⠼⠦⠄⡀⠡⣰⣼⠻⣾⠟⣀ ⢀⡼⠈   ",
            @"                       ⠋⠉⠓⢺⢽⡝⣦⣺⢁⣴⡊ ⣀⣰⠛        ⢰⡿⠃       ⡇     ⠱⡯⡖  ⣺⡟⠋ ⠙⠢⡀   ",
            @"                        ⢈⡯⢮⣏⣸⣗⠛⠏⠉ ⠉           ⢠⣻⠋       ⣞⠁ ⠉⠁ ⣨⠽⠛⢿⢿⣽ ⠟⢄⡀ ⢳⡀  ",
            @"                      ⠒ ⠈⠉⠉ ⠷⡜⢱⠙⡴⣧⡒⠠ ⣧       ⢠⣷⠃  ⢀⣀⣤⣴⡶⠿⠛⠳⢤⣀ ⡰⠁ ⠆ ⠙⡆  ⠈⠁⢀    ",
            @"                        ⣅⡄⣀⡴⠁⠌⠛⠹    ⣸      ⢀⡴⣣⣷⣶⡾⠽⠿⣫⠭       ⠉⢳    ⣸⠦⠤⠤⠔⠊     ",
            @"                        ⠉⠉⡏  ⣘ ⠙⣦⢄⡴⠋⠁   ⢀⡴⣿⠟⠉⠁    ⡇  ⠈⢢⡄     ⢮⡂⡀⢀⡴⠃          ",
            @"                           ⡠⡀⠃⢀⡜⡞⣆   ⢀⣤⢞⡵⠟⠁        ⡄   ⢧      ⠈⠋             ",
            @"                           ⠈ ⠦⠔⠒⠉ ⡟⢸⠒⣋⡥⠞⠉           ⠙⢶⡀⢸                     ",
            @"                                ⢠⠞⠁⣩⠞⠁                ⠉                      ",
            @"                              ⣠⠖⢋⡠⠞⠁                                         ",
            @"                            ⣖⠋⣡⡔⠋                                            ",
            @"                           ⢸⠃⣴⠗                                              ",
            @"                          ⢠⠏⣸⠏                                               ",
            @"                         ⣰⠃⢠⠇                                                ",
            @"                       ⢀⠞⠁⢀⠞                                           ",
            @"                     ⢀⣴⣫⠤⠖⠋                                            ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀⢀⣴⣫  ⠖⠋⠀⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀  ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀⠖⠋          ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"
        };

        public  string[] bloom_8 = {
            @"                                                                             ",
            @"                                                                             ",
            @"                                                                             ",
            @"                                                                             ",
            @"                                                           ⣀⡤⠒⡇              ",
            @"                                                        ⣠⠖⠋   ⢻⡀             ",
            @"                                                  ⢀⢴⠾⠑⢦⡞⠃     ⣼⠇             ",
            @"                                                 ⢠⣯⠌   ⢳     ⢠⠧              ",
            @"                                                 ⠈⢇ ⢀⡔⠋⠻⠚⣆⢀⣀⡠⠋               ",
            @"                                      ⣄⣀⡀         ⠈⠳⡝⠆   ⠁⡧⠆⠈⢣               ",
            @"                                      ⢹⡄⠉⠉⠉⠒⠢⢄⡀     ⢹⣼⡀⢀⣀⠜⠃  ⢺⡃              ",
            @"                         ⢀             ⢧      ⠙⢶    ⣾⠿⠛⠙⠢⠤⠤⠤⠒⠉               ",
            @"                        ⢀⢾⠢⠴⠤⢄⡀        ⠘⣇      ⠈⡇  ⢠⡿⠄    ⢀⡷⡒⠒⠲⢤⡀ ⢀⣠⢀⣀⣠      ",
            @"                       ⢠⠋ ⢠   ⠙⣆⣀⡤⠤⠤⣄⡀  ⠈⢦⡀⡀   ⢀⡏⢀⣴⠟⠁    ⢀⡜  ⡄  ⢙⡞⠁  ⢀⠈⢦     ",
            @"                       ⡇  ⠨⡄  ⢀⠜⠃   ⠈⠉⣱⡆  ⠉⠓⠲⠶⠶⣮⣠⡾⠃      ⠈⣇  ⠰⡀ ⢸ ⢠⢀⠔⠁ ⠈⣶    ",
            @"                       ⢳⡀  ⣰⣤⣄⡌⣄⢀⢀⠠⠒⠁  ⡇       ⡟⣿⠉      ⢀⡴⠼⠦⠄⡀⠡⣰⣼⠻⣾⠟⣀ ⢀⡼⠈    ",
            @"                     ⢀⡔⠋⠉⠓⢺⢽⡝⣦⣺⢁⣴⡊ ⣀  ⣰⠛      ⢰⡿⠃      ⢰⡇     ⠱⡯⡖⠛⡤⣺⡟⠋⠉⠙⠢⡀   ",
            @"                    ⢠⠯    ⢈⡯⢮⣏⣸⣗⠛⠏⠉ ⠉⠙⢦⡀     ⢠⣻⠋       ⣞⠁ ⠉⠁ ⣨⠽⠛⢿⢿⣽⠓⠟⢄⡀  ⢳⡀  ",
            @"                    ⣞⠒ ⠈⠉⠉ ⠷⡜⢱⠙⡴⣧⡒⠠⢀   ⣧    ⢠⣷⠃  ⢀⣀⣤⣴⡶⠿⠛⠳⢤⣀ ⡰⠁  ⠆ ⠙⡆  ⠈⠁⢀⣘⡤  ",
            @"                     ⠑⣅⡄  ⣀⡴⠁⠌⠛⠹⣀      ⣸  ⢀⡴⣣⣷⣶⡾⠽⠿⣫⠭⠤⢤⡀   ⠈⠉⢳  ⠸   ⣸⠦⠤⠤⠔⠊    ",
            @"                       ⠉⠉⡏  ⣘   ⠙⣦⢄⣠⣀⡴⠋⠁⢀⡴⣿⠟⠉⠁    ⡇   ⠈⢢⡄   ⠈⢮⡂⡀ ⢀⡴⠃         ",
            @"                         ⠳⡠⡀⠃  ⢀⡜⡞⣆  ⢀⣤⢞⡵⠟⠁       ⠸⡄    ⢧     ⠈⠗⠋⠉           ",
            @"                          ⠈⢦⠦⠔⠒⠉ ⡟⢸⠒⣋⡥⠞⠉           ⠙⢶⡀  ⢸                    ",
            @"                               ⢠⠞⠁⣩⠞⠁                ⠉⠓⠢⢼⣆                   ",
            @"                             ⣠⠖⢋⡠⠞⠁                      ⠉                   ",
            @"                           ⣖⠋⣡⡔⠋                                             ",
            @"                          ⢸⠃⣴⠗                                               ",
            @"                         ⢠⠏⣸⠏                                                ",
            @"                        ⣰⠃⢠⠇                                                 ",
            @"                      ⢀⠞⠁⢀⠞                                                  ",
            @"                    ⢀⣴ ⠖⠋                                                    ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡊⠄⠀  ⠀⠀⠀⢀⣴⣫  ⠖⠋⠀⠀⠀⠀⠀       ⠀⠀⠀⠀⠀⠀⠀⠀⠀      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀        ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀⠖⠋          ⠀⠀⠀⠀⠀⠀⠀⠀⢀⠌⠀⠐⡀⢰⠉⢆⠀⡏⠱⡀⠀⠀          ",
            @"⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀    ⠀⠀⡐⠱⡀⠀⢀⠌⠀⠀⠀⠒⢰⡀⠀⠑⢄⡇⠀⠑⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀   ",
            @"⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠒⠀⠂⠀⠀⡂⡀⠂⠈⡎⠀⠀⠀⠀⠀⠘⠄⠀⠀⠀⠙⠀⠀⠈⠑⠒⠬⠷⠄⠀⠀⠁⠑⠛⠈"


        };

        public  string[] sleeping_cat_2 = {
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⣀⣀⡀⠀             ",
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠉⠉⠉⠉⢉⣿⠏⠀⠀             ",
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡾⠃⠀⠀⠀             ",
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢀⣀⣀⡀⠀⠀⠀⠀⢀⣾⠟⠀⠀⠀⠀⠀             ",
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠛⠛⠋⠉⣩⡿⠃⠀⠀⠀⣰⣿⣃⣀⣠⣤⣤⣴⡤             ",
            @"                      ⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠋⠀⠀⠀⠀⠚⠛⠛⠉⠉⠉⠁⠀⠀⠀             ",
            @"                      ⠠⠤⠶⠶⣶⡷⠀⠀⣰⣟⣃⣤⣤⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀             ",
            @"                      ⠀⠀⣠⡾⠋⠀⠀⠀⠙⠉⠁⠀⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀             ",
            @"                      ⢠⣾⣯⡤⠤⠦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀             ",
            @"                   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀    ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⠿⢿⣷⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⠿⠉⠀⠀⣿⡇⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣾⡿⠉⠀⣠⡆⠀⣿⡇⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣶⣶⣿⡿⠿⠿⠋⠀⠤⢾⣿⣧⠀⢸⣿⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⣿⣿⣏⠉⠻⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠉⠀⢸⣿⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡿⠋⠙⢿⣿⣿⣧⠀⠈⢻⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⣤⣶⣶⡶⠶⠿⠿⠿⠿⠿⠿⣿⣿⣦⡀⠀⠙⣿⣿⡆⠀⠀⠙⠛⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⣠⣾⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⢿⣿⡀⠀⣠⣄⣀⡦⠀⠀⠀⠈⠻⣿⣿⡤⠀⠈⠿⠇⠀⠀⠀⠀⠀⢀⡄⠀⣀⣴⡿⠁⠀⢸⡿⠟⠋⢻⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠈⠻⣿⣄⠀⠙⢿⠁⠀⠀⠀⠀⠀⠈⠻⠟⠂⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠿⠟⠋⠀⠀⠀⠀⣀⣴⣶⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠈⢿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛⠛⣿⣿⣿⣷⣶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⢸⣿⠃⠀⠀⠀⠀⠀⠀⠀⢠⣤⠀⠀⠀⠚⠛⢻⡄⠀⠀⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⡿⠀⠈⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⢻⣿⠀⠀⠀⠀⣀⠀⠀⣠⣾⡟⠀⠀⠀⠀⠀⢸⡟⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⢻⡿⠁⠀⣼⣿⠟⢹⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠸⣿⡀⠀⠀⠈⠻⠿⠿⠛⠁⠀⠀⠀⠀⠈⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⠇⠀⠀⠀⠀⠉⠀⢀⣾⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⢿⣷⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣷⣦⠀⠀⠀⠀⠀⠀⠈⠉⢁⣨⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⡿⠋⠁⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡋⠈⠙⢿⣧⡀⠀⠀⠀⠀⠀⠙⠿⠿⢿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠻⣿⣧⣀⣤⣶⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⠿⠛⠻⢿⣦⡀⠐⠙⠃⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⡿⣿⣧⣀⡀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣴⣶⠿⠿⠛⠛⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⣿⣶⣤⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠸⠟⠉⠛⠛⠛⠛⠛⠛⠛⠻⣿⣿⠟⠁⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣤⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣧⣄⣠⣼⣄⠀⣠⣶⠀⣰⡆⣠⣿⣿⡀⣠⣿⣦⢀⣴⣿⣄⣀⣤⣼⣇⣀⡀⢀⠀⢀⣀⣠⣤⣴⣶⣦⣾⣿⣿⣿⠟⠈⢿⣿⡀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛⠛⠿⠿⠿⠿⠿⠟⠿⠿⠛⠻⠿⠿⠿⠿⠿⠿⠿⠿⠟⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠋⠉⠈⠉⠛⢿⣿⡁⢀⣠⣾⣿⣿⡀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣧⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⠉⠉⠉⢹⣿⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣇⣀⢀⣀⣼⣿⡆  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣇  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡟⢿⣿⣿⠿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣧⣤⣠⣤⣴⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡿⢿⣿⣿⠿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡇⠀⠀⠀⠀⣿⣿  "
        };

        public  string[] sleeping_cat_1 = {
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                                                             ",
            @"                   ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀    ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⠿⢿⣷⠀⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⠿⠉⠀⠀⣿⡇⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣾⡿⠉⠀⣠⡆⠀⣿⡇⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣶⣶⣿⡿⠿⠿⠋⠀⠤⢾⣿⣧⠀⢸⣿⠀⠀⠀                  ⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⣿⣿⣏⠉⠻⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠉⠀⢸⣿⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡿⠋⠙⢿⣿⣿⣧⠀⠈⢻⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⣤⣶⣶⡶⠶⠿⠿⠿⠿⠿⠿⣿⣿⣦⡀⠀⠙⣿⣿⡆⠀⠀⠙⠛⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⣠⣾⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⢿⣿⡀⠀⣠⣄⣀⡦⠀⠀⠀⠈⠻⣿⣿⡤⠀⠈⠿⠇⠀⠀⠀⠀⠀⢀⡄⠀⣀⣴⡿⠁⠀⢸⡿⠟⠋⢻⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠈⠻⣿⣄⠀⠙⢿⠁⠀⠀⠀⠀⠀⠈⠻⠟⠂⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠿⠟⠋⠀⠀⠀⠀⣀⣴⣶⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠈⢿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡤⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛⠛⣿⣿⣿⣷⣶⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⢸⣿⠃⠀⠀⠀⠀⠀⠀⠀⢠⣤⠀⠀⠀⠚⠛⢻⡄⠀⠀⣤⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⡿⠀⠈⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⢻⣿⠀⠀⠀⠀⣀⠀⠀⣠⣾⡟⠀⠀⠀⠀⠀⢸⡟⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⢻⡿⠁⠀⣼⣿⠟⢹⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠸⣿⡀⠀⠀⠈⠻⠿⠿⠛⠁⠀⠀⠀⠀⠈⠛⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⠇⠀⠀⠀⠀⠉⠀⢀⣾⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⢿⣷⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣷⣦⠀⠀⠀⠀⠀⠀⠈⠉⢁⣨⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠈⢿⣿⣿⣿⡿⠋⠁⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⡋⠈⠙⢿⣧⡀⠀⠀⠀⠀⠀⠙⠿⠿⢿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠻⣿⣧⣀⣤⣶⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⠿⠛⠻⢿⣦⡀⠐⠙⠃⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⡿⣿⣧⣀⡀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣤⣴⣶⠿⠿⠛⠛⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠛⣿⣶⣤⠀⠀⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠀⠸⠟⠉⠛⠛⠛⠛⠛⠛⠛⠻⣿⣿⠟⠁⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣤⠀⠀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢿⣧⣄⣠⣼⣄⠀⣠⣶⠀⣰⡆⣠⣿⣿⡀⣠⣿⣦⢀⣴⣿⣄⣀⣤⣼⣇⣀⡀⢀⠀⢀⣀⣠⣤⣴⣶⣦⣾⣿⣿⣿⠟⠈⢿⣿⡀⠀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠛⠛⠿⠿⠿⠿⠿⠟⠿⠿⠛⠻⠿⠿⠿⠿⠿⠿⠿⠿⠟⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠋⠉⠈⠉⠛⢿⣿⡁⢀⣠⣾⣿⣿⡀⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣿⣿⣿⣿⣿⣧⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡏⠉⠉⠉⢹⣿⠀  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣇⣀⢀⣀⣼⣿⡆  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣇  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡟⢿⣿⣿⠿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣧⣤⣠⣤⣴⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡿⢿⣿⣿⠿⣿⣿  ",
            @"⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⡇⠀⠀⠀⠀⣿⣿  "
        };
    }
}