using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.extensionexample
{
    static class ExtensionExample
    {
        public static double divide(this double a, double b)
        {
            return a / b;
        }

        public static string ReverseText(this string str) // extend string
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
