using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boom
{
    internal class Title //class
    {

        public static void Show() // method hahaha
        {
            int x = 0, y = 18;
            Console.CursorVisible = false; // para walang nag bblink na curser

            foreach (string line in Design.Bloomi)
            {
                Thread.Sleep(50); // for animation lang
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }
        }
    }
}

