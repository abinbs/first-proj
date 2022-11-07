using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.overloading
{
    class Box
    {
        // Polymorphism / overloading : when methods of the same name are differentiated by their passing arguments.
        public void CalculateArea(int length)
        {
            Console.WriteLine("Area = " + (length * length));
        }

        public void CalculateArea(double length)
        {
            Console.WriteLine("Area double= " + (length * length));
        }

        public void CalculateArea(int length, int width)
        {
            Console.WriteLine("Area = " + (length * width));
        }
    }
}
