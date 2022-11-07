using MyFirstProject.day3.sampleproject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.collections
{
    class ExampleList
    {
        static void Main()
        {
            // An array is fixed length. We cannot add more elements
            string[] arr = new string[10];
            arr[0] = "zero";
            arr[9] = "nine";
            //arr[10] = "onemore"; // Index out of bounds exception
            foreach (string x in arr)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------");

            //Non Generic collection
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(true);

            Employee alex = new Employee("Alex Rod", 5);
            list.Add(alex);

            Console.WriteLine(list[2]);

            foreach (Object temp in list)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("------------------------");

            //Generic collection

            List<Employee> list1 = new List<Employee>();
            list1.Add(alex);

            //list1.Add("One"); // error
            // only string objects can be added
            List<string> list2 = new List<string>();
            list2.Add("Zero");
            list2.Add("One");
            list2.Add("Two");
            list2.Add("Three");
            list2.Add("Zero");
            list2.Add("One");

            

            Console.WriteLine(list2.Count);
            Console.WriteLine("------------------------");
            list2.Remove("Zero");
            Console.WriteLine(list2.Count);
            Console.WriteLine("------------------------");
            foreach (string x in list2)
            {
                Console.WriteLine(x);
            }

            
        }
            
    }
}
