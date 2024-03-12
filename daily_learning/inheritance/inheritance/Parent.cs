using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }
        public Parent(String message):this()
        {
            Console.WriteLine(message);
        }
    }
}
