using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class About
    { 
        public string [] AboutaPage = {

@".-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-.",
@"|                                                                                                                                                                                         |",
@"|                                                                                ____  _____  ____  __ __  _____                                                                          |",
@"|                                                                               / () \ | () )/ () \|  |  ||_   _|                                                                         |",
@"|                                                                              /__/\__\|_()_)\____/ \___/   |_|                                                                           |",
@"|                                                                                                                                                                                         |",
@"|                                                                                                                                                                                         |",
@"|                                      Welcome to Bloomify, an engaging productivity tool designed to help you cultivate discipline, mindfulness, and                                     |",
@"|                              consistent habits through a visually interactive virtual garden experience. By transforming time-tracking into a rewarding                                 |",
@"|                                   journey,Focus Timer turns each completed focus session into a thriving plant, while interruptio ones—gently reinforcing                               |",
@"|                                                                 the value of commitment and accountability.                                                                             |",
@"|                                                                                                                                                                                         |",
@"|                                                                                                                                                                                         |",
@"!                     How It Works :                                                                                                                                                      !",
@":                   • Just choose a custom focus duration to get started.                                                                                                                 :",
@":                                                                                                                                                                                         :",
@":                   • Use arrow keys to move through the interface, interacting with visual elements in a distraction-free environment.                                                   :",
@".                                                                                                                                                                                         .",
@".                   • As your timer runs, watch a plant or flower animation grow on-screen, motivating you to stay focused. Complete the session for a blooming plant;                    .",
@".                     stop early, and it wilts, symbolizing the importance of finishing what you start.                                                                                   .",
@":                                                                                                                                                                                         :",
@":                   • Every session is automatically logged with details like date, duration, and outcome (bloom or wilt). Review your history to see how your focus                      :",
@":                     habits evolve over time.                                                                                                                                            :",
@":                                                                                                                                                                                         :",
@"!                   • Successfully grown plants populate a dedicated calander garden–serving as a history of your progress,creating a meaningful, visual                                  !",
@"|                      representation of your dedication.                                                                                                                                 |",
@"|                                                                                                                                                                                         |",
@"|                                                                                                                                                                                         |",
@"|                                                                                  Contributors:                                                                                          |",
@"|                                                                                                                                                                    |",
@"|                                                                               Del Mundo, Cyrille                                                                                        |",
@"|                                                                                Ferrer, Anjilyn                                                                                          |",
@"|                                                                                  Yambao, Marc                                                                                           |",
@"|                                                                                                                                                                                         |",
@"|                                                                                Bautista, John Nesty                                                                                       |",
@"|                                                                                Bogñalbal, Geogie                                                                                        |",
@"|                                                                                                                                                                                         |",
@"|                                                                                                                                                                                         |",
@"`-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='",                                                                                      
        };
        public void ShowAbout()
        {
            foreach (var item in AboutaPage)
            {
                Console.WriteLine(item);
            }
        }
    }
}
