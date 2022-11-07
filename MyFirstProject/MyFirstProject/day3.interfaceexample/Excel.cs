using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    class Excel : IOffice
    {
        public void New()
        {
            Console.WriteLine("Create excel doc");
        }

        public void Save()
        {
            Console.WriteLine("Save excel doc");
        }


        public void Print()
        {
            Console.WriteLine("Print excel doc");
        }
    }
}
