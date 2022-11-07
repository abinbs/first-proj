using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.OptionalNamedArgs
{
    class OptionalNamed
    {
        static void OptArgMeth(int alpha, int beta = 10, int gamma = 20)
        {
            Console.WriteLine("Here is alpha, beta, and gamma: " +
            alpha + " " + beta + " " + gamma);
        }

        static void Main()
        {
            // Pass all arguments explicitly.
            OptArgMeth(1, 2, 3);
            // Let gamma default.
            OptArgMeth(alpha : 1, gamma : 2);
            // Let both beta and gamma default.
            OptArgMeth(1);

        }
    }
}
