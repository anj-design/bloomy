using boom;
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
        public Calendar calendar = new Calendar();
        public void Play()
        {

           
            Console.ReadKey();

            foreach (var line in Calendar.january)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in Calendar.February)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in Calendar.March)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in Calendar.Aptil)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in Calendar.May)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();

            foreach (var line in Calendar.June)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

    }
}
