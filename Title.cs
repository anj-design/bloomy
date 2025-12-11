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
            Console.CursorVisible = false; // para walang nag bblink na curser
            Console.Clear();
            foreach (string line in Design.Bloomy)
            {
                Console.WriteLine(line);
            }
        }
    }
}

