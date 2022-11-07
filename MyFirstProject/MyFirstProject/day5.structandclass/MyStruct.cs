using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.structandclass
{
        struct MyStruct
        {
            public int x;
        }

        class StructAssignment
        {
            static void Main()
            {
                MyStruct a;
                MyStruct b;
                a.x = 10;
                b.x = 20;
                Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
                // When you assign one structure to another, 
                // a copy of the object is made.
                a = b; // a and b refer to different object. 
                       //if b changes, it doesn't affect a.
                b.x = 30;
                Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
            }
        }
   
}
