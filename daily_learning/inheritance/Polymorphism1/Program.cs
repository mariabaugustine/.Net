using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Employee employee = new FullTime();
            FullTime fulltime = new FullTime();
            fulltime.printName();
            Console.ReadLine();
        }
    }
}
