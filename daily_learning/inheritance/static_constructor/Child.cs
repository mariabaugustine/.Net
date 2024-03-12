using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace static_constructor
{
    class Child:Parent
    {
        static Child()
        {
            Console.WriteLine("Child static constructor");
        }
        public Child()
        {
            Console.WriteLine("Child instance constructor");
        }
        public Child(int age)
        {
          
            Console.WriteLine($"{age}");
        }
    }
}
