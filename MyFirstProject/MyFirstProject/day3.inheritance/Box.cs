using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.inheritance
{
    // super class, base class, parent class
    class Box
    {
        public void CalculateArea(int length, int width)
        {
            Console.WriteLine("Area = " + (length * width));
        }
    }
}
