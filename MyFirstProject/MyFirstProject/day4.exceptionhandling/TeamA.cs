﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.exceptionhandling
{
    //throw an exception
    class TeamA
    {
        public int DivideNums(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch
            {
                throw new Exception("Please check your nums");
            }
            return c;
        }
    }
}
