using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.extensionexample
{
    class ExtensionDemo
    {
        static void Main()
        {
            double a = 10;
            Console.WriteLine(a.divide(2));

            string str = "World";
            Console.WriteLine(str.ReverseText());
        }
    }
}
