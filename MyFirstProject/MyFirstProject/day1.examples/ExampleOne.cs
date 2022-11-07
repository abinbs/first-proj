using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    class ExampleOne
    {
        // My first program
        static void Main()
        {
            Console.WriteLine("Hello World");

            int x = 10;
            int y = 3;
            int result = x % y;

            Console.WriteLine("result = " + result);

            /*
             * Multiline
             * comment
             * 
             * */

            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y));

        }
    }
}
