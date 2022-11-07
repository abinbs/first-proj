using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.inheritance
{
    // class BigBox inherits (extends) Box
    // subclass
    class BigBox : Box
    {
        public void CalculateVolume(int length, int width, int height)
        {
            Console.WriteLine("Volume= " + (length * width * height));
        }
    }
}
