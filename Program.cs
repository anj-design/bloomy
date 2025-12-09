//dito tatawagin mga methods or classes
//may full screen dapat dito pero tmaaad na ako haha
using boom;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Music.PlayMusic("music2.wav");
        Title.Show();

        Console.Clear();//clear

        foreach (var line in Design.Bloomy)
        {
            Console.WriteLine(line);
        }
        Console.ReadKey();

        Console.Clear();
        foreach (var line in Design.MotivPage)
        {
            Console.WriteLine(line);
        }
        Console.ReadKey();

        Console.Clear();

        Menu menu = new Menu();
        while (true)
        {
            //  foreach (var line in Design.Bloomi)
            //{
            //    Console.WriteLine(line);
            //}
            menu.Show();

        }

    }
}

