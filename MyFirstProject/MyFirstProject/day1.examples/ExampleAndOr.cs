using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    class ExampleAndOr
    {
        static void Main()
        {
            int x = -10;
            int y = 10;

            if (x >= 0 && y >= 0)
            {
                Console.WriteLine(" both numbers positive");
            }
            else if (x >= 0 || y >= 0)
            {
                Console.WriteLine(" atleast one num is positive");
            }
            else
            {
                Console.WriteLine(" both numbers negative");
            }

        }
    }
}
