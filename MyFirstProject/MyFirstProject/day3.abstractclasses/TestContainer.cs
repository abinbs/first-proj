using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.abstractclasses
{
    class TestContainer
    {
        static void Main()
        {
            Container c1 = new SquareContainer();
            c1.CalculateVolume(10, 5);

            c1 = new CircleContainer();
            c1.CalculateVolume(10, 5);
            
        }
    }
}
