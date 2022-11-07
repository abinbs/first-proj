using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.enumeration
{
    class EnumExample
    {
        public enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

        static void Main()
        {
            Days day = Days.Tue;
            Console.WriteLine(day + " " + (int)day);
        }
    }
}
