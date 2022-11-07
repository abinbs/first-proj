using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    class Word : IOffice
    {
        public void Insert()
        {
            Console.WriteLine("Word Insert Method");
        }

        public void New()
        {
            Console.WriteLine("Create word doc");
        }

        public void Save()
        {
            Console.WriteLine("Save word doc");
        }

        public void Print()
        {
            Console.WriteLine("Print word doc");
        }

     
    }
}
