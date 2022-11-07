using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.exercises
{
    class ExerciseB
    {
        static void Main()
        {
            string[] strs = { "3.45", "3.87", "87.98", "56.7" };

            double total = 0.0;

            foreach (string temp in strs)
            {
                total += Convert.ToDouble(temp);
            }

            Console.WriteLine("Total = " + total);

        }
    }
}
