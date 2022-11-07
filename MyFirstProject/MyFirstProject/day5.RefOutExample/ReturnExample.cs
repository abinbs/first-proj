using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.RefOutExample
{
    class ReturnExample
    {
        public List<Object> SomeMethod()
        {
            List<Object> list = new List<Object>();
            list.Add("hello");
            list.Add(10);
            list.Add(34.5);
            list.Add(true);
            return list;
        }
    }
}
