using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.varkeyword
{
    class VarExample
    {
        static void Main()
        {
            var x = 10;
            x = 20;

            var y = "Hi";
            y = "Hello";
            //will not work as y is considered a string
            //y = 10;
        }
    }
}
