using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.sampleproject
{
    class Department
    {
        private string deptName;
        private double deptBudget;
        private int counter = 0;
        //int[] x = new int[6];
        Employee[] emps = new Employee[5];
        //List<Employee> emps = new List<Employee>();

        public void AddEmployee(Employee obj)
        {
            //emps[counter] = obj;
            emps.Add(obj);
            counter++;
            if (obj.empGrade >= 5)
            {
                this.deptBudget += 150000;
            }
            else
            {
                this.deptBudget += 100000;
            }
        }

        public void describe()
        {

            string temp = "Department : " + this.deptName +
                "\nTotal budget : " + this.deptBudget +
                "\nEmployees : ";

            foreach (Employee t in emps)
            {
                if (t != null)
                {
                    temp += t + " ";
                }
            }
            Console.WriteLine(temp);
        }

        public Department(string deptName)
        {
            this.deptName = deptName;
            this.deptBudget = 50000;
        }
    }
}
