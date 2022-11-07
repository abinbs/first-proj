using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.RefOutExample
{
    class RefOutExample
    {
        public void SomeMethodA(int a)
        {
            a = a * a;
        }

        public void SomeMethodB(ref int a)
        {
            a = a * a;
        }

        public int GetParts(double n, out double frac)
        {
            int whole;
            whole = (int)n;
            frac = n - whole; // pass fractional part 
                              //back through frac
            return whole; // return integer portion
        }
    }
}
