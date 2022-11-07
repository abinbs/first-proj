using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.structandclass
{
    class MyClass
    {
        public int x;
    }

    class ClassAssignment
    {
        static void Main()
        {
            MyClass a = new MyClass();
            MyClass b = new MyClass();
            a.x = 10;
            b.x = 20;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
            a = b; // now a and b refer to same object. 
                   //if b changes a changes.
            b.x = 30;
            Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
        }
    }
}
