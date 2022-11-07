using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.abstractclasses
{
    class CircleContainer : Container
    {
        public override double AreaOfBase(int length)
        {
            double area = Math.PI * (length / 2) * (length / 2);
            Console.WriteLine("Circle Area = " + area);
            return area;
        }
    }
}
