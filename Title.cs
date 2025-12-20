using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using ConsoleApp1;
using System.IO;

namespace ConsoleApp1
{

    public class Title //class
    {
        public Styles styles = new Styles();
        public void Show() // method hahaha
        {

        SoundPlayer player = new SoundPlayer("intro.wav");
            player.Load();
        player.PlayLooping();

            int x = 0, y = 10;
            Console.CursorVisible = false; // para walang nag bblink na curser

            foreach (string line in styles.Bloomi)
            {
                Thread.Sleep(50); // for animation lang
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;

                Console.SetCursorPosition((int)x, (int)y);
            }
            Console.ReadKey();

        }
    }
}