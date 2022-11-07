using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.partialclasses
{
    class TestBox
    {
        static void Main()
        {
            Box obj = new Box();
            obj.methodA();
            obj.methodB();

            obj.callC();
        }
    }
}
