using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.sealedconstreadonly
{
    class A   // sealed class A //prevents class from being inherited
    {
        public const double pi = 3.14;
        //•Can't be static.
        //•Value is evaluated at compile time.
        //•Initiailized at declaration only.
        public readonly double theNum = 1.618;
        //•Can be either instance-level or static.
        //•Value is evaluated at run time.
        //•Can be initialized in declaration or by code in the constructor.

        public virtual void methodA()
        {
            Console.WriteLine("pi value " + Math.PI);
        }
    }
}
