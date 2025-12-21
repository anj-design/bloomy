using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    // Ito yung About class - dito naka-store lahat ng information tungkol sa app
    // May tatlong main screens: description, how to use, at credits
    class About
    {
        // Array na naglalaman ng welcome message sa loob ng ASCII art box
        // Ito yung unang makikita ng user pag pinindot nila yung about section
        public string[] Description = {
@"            .--------------------------------------------------------------------------------------------------------------------------------------------.    ",
@"           /  .-.                                                                                                                                    .-.  \   ",
@"          |  /   \           Welcome to Bloomify! an engaging rod activity tool designed to help you cultivate discipline, mindfulness, and         /   \  |  ",
@"          | |\_.  |  consistent habits through a visually interactive virtual garden experience. By transforming time-tracking into a rewarding    |    /| |   ",
@"          |\|  | /|               journey. Focus Timer turns each completed focus session into a thriving plant.                                   |\  | |/| ",
@"          | `---' |                                      Grow your Focus, Bloom your Mind.                                                         | `---' |  ",
@"          |       |                                                                                                                                |       |  ",
@"          |       |--------------------------------------------------------------------------------------------------------------------------------|       |  ",
@"          \       |                                                                                                                                |       /  ",
@"           \     /                                                                                                                                  \     /   ",
@"            `---'                                                                                                                                    `---'    ",
};
        // Array para sa instructions kung paano gamitin ang Bloomify
        // Step-by-step guide para hindi malito yung user
        public string[] How = {
@"      ┏ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━•❃°•°❀°•°❃•━ ━•❃°•°❀°•°❃•━ ━•❃°•°❀°•°❃•━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━┓",
@"      ┊  How It Works :                                                                                                                                    ┊",
@"      ┊• Just choose a custom focus duration to get started.                                                                                               ┊",
@"      ┊                                                                                                                                                    ┊",
@"      ┊• Use arrow keys to move through the interface, interacting with visual elements in a distraction-free environment.                                 ┊",
@"      ┊                                                                                                                                                    ┊",
@"      ┊• As your timer runs, watch a plant or flower animation grow on-screen, motivating you to stay focused. Complete the session for a blooming plant.  ┊ ",
@"      ┊                                                                                                                                                    ┊",
@"      ┊• Every session is automatically logged with details like date, duration, and outcome(bloom or wilt). Review your history to see how your focus     ┊ ",
@"      ┊  habits evolve over time.                                                                                                                          ┊",
@"      ┊                                                                                                                                                    ┊",
@"      ┊• Successfully grown plants populate a dedicated note list as a history of your progress, creating a meaningful, visual representation              ┊ ",
@"      ┊  of your dedication.                                                                                                                               ┊",
@"      ┗━━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━•❃°•°❀°•°❃•━ ━•❃°•°❀°•°❃•━ ━•❃°•°❀°•°❃•━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━ ━┛",
};
        public string[] namesx = {
@"       /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\",
@"       \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/",
@"       /\                                           ___  __   __ _  ____  ____  __  ____  _  _  ____  __  ____  ____  _                                      /\",
@"       \/                                          / __)/  \ (  ( \(_  _)(  _ \(  )(  _ \/ )( \(_  _)/  \(  _ \/ ___)(_)                                     \/",
@"       /\                                         ( (__(  O )/    /  )(   )   / )(  ) _ () \/ (  )( (  O ))   /\___ \ _                                      /\",
@"       \/                                          \___)\__/ \_)__) (__) (__\_)(__)(____/\____/ (__) \__/(__\_)(____/(_)                                     \/",
@"       /\                        ____  ____  __          _  _  _  _  __ _  ____   __           ___  _  _  ____  __  __    __    ____                         /\",
@"       \/                       (    \(  __)(  )        ( \/ )/ )( \(  ( \(    \ /  \  _      / __)( \/ )(  _ \(  )(  )  (  )  (  __)                        \/",
@"       /\                        ) D ( ) _) / (_/\      / \/ \) \/ (/    / ) D ((  O )( )    ( (__  )  /  )   / )( / (_/\/ (_/\ ) _)                         /\",
@"       \/                       (____/(____)\____/      \_)(_/\____/\_)__)(____/ \__/ (/      \___)(__/  (__\_)(__)\____/\____/(____)                        \/",
@"       /\                              ____  ____  ____  ____  ____  ____          __   __ _    __  __  __    _  _  __ _                                     /\",
@"       \/                             (  __)(  __)(  _ \(  _ \(  __)(  _ \ _      / _\ (  ( \ _(  )(  )(  )  ( \/ )(  ( \                                    \/",
@"       /\                              ) _)  ) _)  )   / )   / ) _)  )   /( )    /    \/    // \) \ )( / (_/\ )  / /    /                                    /\",
@"       \/                             (__)  (____)(__\_)(__\_)(____)(__\_)(/     \_/\_/\_)__)\____/(__)\____/(__/  \_)__)                                    \/",
@"       /\                                          _  _  __   _  _  ____   __    __          _  _   __   ____   ___                                          /\",
@"       \/                                         ( \/ )/ _\ ( \/ )(  _ \ / _\  /  \  _     ( \/ ) / _\ (  _ \ / __)                                         \/",
@"       /\                                          )  //    \/ \/ \ ) _ (/    \(  O )( )    / \/ \/    \ )   /( (__                                          /\",
@"       \/                                         (__/ \_/\_/\_)(_/(____/\_/\_/ \__/ (/     \_)(_/\_/\_/(__\_) \___)                                         \/",
@"       /\                  ____   __   _  _  ____  __  ____  ____  __            __   __   _  _  __ _        __ _  ____  ____  ____  _  _                    /\",
@"       \/                 (  _ \ / _\ / )( \(_  _)(  )/ ___)(_  _)/ _\  _      _(  ) /  \ / )( \(  ( \      (  ( \(  __)/ ___)(_  _)( \/ )                   \/",
@"       /\                  ) _ (/    \) \/ (  )(   )( \___ \  )( /    \( )    / \) \(  O )) __ (/    /      /    / ) _) \___ \  )(   )  /                    /\",
@"       \/                 (____/\_/\_/\____/ (__) (__)(____/ (__)\_/\_/(/     \____/ \__/ \_)(_/\_)__)      \_)__)(____)(____/ (__) (__/                     \/",
@"       /\                                    ____   __    ___   __   __    ____   __   __            ___  ____  __    ___  __  ____                          /\",
@"       \/                                   (  _ \ /  \  / __) / _\ (  )  (  _ \ / _\ (  )   _      / __)(  __)/  \  / __)(  )(  __)                         \/",
@"       /\                                    ) _ ((  O )( (_ \/    \/ (_/\ ) _ (/    \/ (_/\( )    ( (_ \ ) _)(  O )( (_ \ )(  ) _)                          /\",
@"       \/                                   (____/ \__/  \___/\_/\_/\____/(____/\_/\_/\____/(/      \___/(____)\__/  \___/(__)(____)                         \/",
@"       /\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\",
@"       \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/",        };

        // Variables para sa positioning ng cursor sa console
        // x = horizontal position (0 means start from left edge)
        // y = vertical position (19 means mag-start sa line 19 from top)
        public int x = 0, y = 19;

        // Method na nag-display ng description screen
        // Binubura muna yung console, tapos nag-set ng color at position bago i-print yung text
        public void showDescription()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(x, y);
            // Loop through each line ng description at i-print lahat
            foreach (var d in Description)
            {
                Console.WriteLine(d);
            }


        }
        public void showHow()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(x + 1, y);
            foreach (var e in How)
            {
                Console.WriteLine(e);
            }

        }
        // Method para sa credits/contributors screen
        // I-display yung mga pangalan ng contributors sa ASCII art format
        public void showWho()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(x, 5);
            foreach (var f in namesx)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
        // Main method na nag-control ng flow ng About section
        // Nag-aantay ng key press para mag-navigate through different screens
        public void DisplayAbout()
        {   
            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {  
                showDescription();
                key = Console.ReadKey();
                showHow();
                key = Console.ReadKey();
                showWho();
                key = Console.ReadKey();
                // After lahat ng screens, bumalik sa main menu
                Menu menu = new Menu();
                menu.Start();
            }
            else if (key.Key == ConsoleKey.X)
            { 
                return;// Bumalik sa previous screen whahha
            }
        }
    }
}
