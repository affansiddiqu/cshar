﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    internal class Class1
    {

        public int num1;
        public int num2;

        //constructor function
        public Class1() {
            Console.WriteLine("first constructor");
        }

        //constructor function with prameters
        public Class1(int num1, int num2):this()
        {
            Console.WriteLine(num1 + num2);
        }

        public Class1(int num):this(46,2)
        {
            Console.WriteLine("third constructor" + num);
        }


        public void meg6()
            {
                Console.WriteLine("hellloo");
            }

        public void meg1()
        {
            Console.WriteLine("second function");
        }

        //add two number

        public void add()
        {
            Console.WriteLine(num1 + num2);
        }

    } 
}
