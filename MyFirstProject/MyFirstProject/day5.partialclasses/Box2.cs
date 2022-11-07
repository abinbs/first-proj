using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.partialclasses
{
    partial class Box
    {
        public void methodB()
        {
            Console.WriteLine("Method B");
        }

        partial void methodC()
        {
            Console.WriteLine("Method C");
        }
    }

    partial class Box
    {
        public void callC()
        {
            methodC();
        }
    }
}
