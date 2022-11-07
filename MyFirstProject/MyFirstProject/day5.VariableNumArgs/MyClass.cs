using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.VariableNumArgs
{
    class MyClass
    {
        public void ShowArgs(string msg, params int[] nums)
        {
            Console.Write(msg + " : ");

            foreach (int i in nums)
                Console.Write(i + " ");

            Console.WriteLine("------------");
        }

        static void Main()
        {
            MyClass ob = new MyClass();
            ob.ShowArgs("Here are some integers",
            1, 2, 3, 4, 5);

            ob.ShowArgs("Here are two more",
            17, 20);
        }
    }
}
