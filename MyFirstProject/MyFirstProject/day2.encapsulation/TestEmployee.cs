using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.encapsulation
{
    class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            alex.SetSalary(100000);
            //alex.bonus = 20000;
            Console.WriteLine("Bonus = " + alex.bonus);
            
            alex.CalculateTotalPay();

            lynda.SetSalary(100000);
            //lynda.bonus = 20000;
            lynda.CalculateTotalPay();
        }
    }
}
