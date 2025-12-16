using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class Title //class
    {
        public Styles styles = new Styles();
        public  void Show() // method hahaha
        {
            /*string titleScreenMusic = AppDomain.CurrentDomain.BaseDirectory + @"Musics\intro.wav";
            SoundPlayer soundPlayer = new SoundPlayer(titleScreenMusic);
            soundPlayer.PlayLooping();
            Console.ReadKey(true);*/

            int x = 0, y = 18;
            Console.CursorVisible = false; // para walang nag bblink na curser

            foreach (string line in styles.Bloomi)
            {
                Thread.Sleep(50); // for animation lang
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }
        }
    }
}