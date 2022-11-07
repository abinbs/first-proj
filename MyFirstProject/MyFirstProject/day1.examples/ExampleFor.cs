using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    class ExampleFor
    {
        static void Main()
        {
            // i++  short form for i = i + 1
           // for(initia value, condition, incrementor/ decrementor)
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
