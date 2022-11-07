using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.statickeyword
{
    class ExampleStatic
    {
        public static int staticcount;
        public int nonstaticcount;

        public void CallStaticCount()
        {
            Console.WriteLine("static count : " + staticcount);
            staticcount++;
        }

        public void CallNonStaticCount()
        {
            Console.WriteLine("non static count : " + nonstaticcount);
            nonstaticcount++;
        }

        // a static contructor is fired before the instance contructor. used to set class values
        static ExampleStatic()
        {
            Console.WriteLine("Static constructor");
        }
        public ExampleStatic()
        {
            Console.WriteLine("Instance constructor");
        }
    }
}
