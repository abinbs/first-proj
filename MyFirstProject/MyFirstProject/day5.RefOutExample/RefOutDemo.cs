using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.RefOutExample
{
    class RefOutDemo
    {
        static void Main()
        {
            RefOutExample obj = new RefOutExample();
            int i = 10;

            Console.WriteLine(" i = " + i);
            obj.SomeMethodA(i);

            Console.WriteLine(" i = " + i);

            obj.SomeMethodB(ref i);
            Console.WriteLine(" i = " + i);

            Console.WriteLine("-------------");


            double f;
            i = obj.GetParts(10.125, out f);
            Console.WriteLine(" f = " + f);
        }
    }
}
