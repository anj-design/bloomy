using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Progress
    {
        public Design design = new Design();
        public void Play()
        {

           
            Console.ReadKey();

            foreach (var line in design.january)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in design.February)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in design.March)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in design.Aptil)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in design.May)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in design.June)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

    }
}
