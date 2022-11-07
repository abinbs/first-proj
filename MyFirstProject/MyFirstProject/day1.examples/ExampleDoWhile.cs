using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    class ExampleDoWhile
    {
        static void Main()
        {
            int x = -10;

            do
            {
                Console.WriteLine("x = " + x);
                x--;
            } while (x > 0);

        }
    }
}
