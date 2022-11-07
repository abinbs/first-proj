using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.exercises
{
    class ExerciseA
    {
        static void Main()
        {
            Console.WriteLine("Please enter salary");
            string input = Console.ReadLine();

            double salary = Convert.ToDouble(input);
            double tax;
            if (salary <= 8350)
            {
                tax = 8350 * .10;
            }
            else if (salary <= 33950)
            {
                tax = (8350 * .10) + ((salary - 8350) * .15);
            }
            else
            {
                tax = (8350 * .10) + ((33950 - 8350) * .15) + ((salary - 33950) * .25);
            }
            Console.WriteLine("Tax = " + tax);
        }
    }
}
