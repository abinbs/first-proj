using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.partialclasses
{
    public partial class Box
    {
        public void methodA()
        {
            Console.WriteLine("MethodA");
        }

        partial void methodC();
    }
}
