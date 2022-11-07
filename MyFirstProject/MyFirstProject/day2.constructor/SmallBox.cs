using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.constructor
{
    class SmallBox
    {
        public int length;
        public int width;

        //constructor : method that has the same name as the class.
        //              executes when an object is created.

        public SmallBox()
        {
            length = 6;
            width = 5;
            Console.WriteLine("Constructor fired");
        }

        public SmallBox(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Area = " + (length * width));
        }
    }
}
