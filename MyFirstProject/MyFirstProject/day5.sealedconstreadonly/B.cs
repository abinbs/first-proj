using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.sealedconstreadonly
{
    class B : A
    {
        public void methodB()
        {
            Console.WriteLine("some method B");
        }
        public sealed override void methodA() // sealed public override methodA() // prevent further overriding
        {
            Console.WriteLine("some method A");
        }
    }
}
