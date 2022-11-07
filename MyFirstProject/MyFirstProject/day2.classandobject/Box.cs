using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.classandobject
{
    class Box
    {
        public int length;
        public int width;

        public int CalculateArea(int length, int width)
        {
            int area = this.length * this.width;
            Console.WriteLine("Area = " + area);
            return area;
        }
    }
}
