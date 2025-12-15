//dito tatawagin mga methods or classes
//may full screen dapat dito pero tmaaad na ako haha    ================     DONE
using boom;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput; // input Simulator
using WindowsInput.Native;

class Program
{
    static void Main(string[] args)
    {

        InputSimulator simulator = new InputSimulator();

        Thread.Sleep(50); // delay para magawa ng isa isa yung key press
        simulator.Keyboard.KeyPress(VirtualKeyCode.F11); // full screen
        Thread.Sleep(50);
        simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.SUBTRACT); //zoom out para makita ng buo yung title

        // Music.PlayMusic("music2.wav");
        Title.Show();

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