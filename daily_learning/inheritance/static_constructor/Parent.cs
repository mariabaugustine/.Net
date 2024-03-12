using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace static_constructor
{
    class Parent
    {
        static Parent()
        {
            Console.WriteLine("Parent static construcor");
        }
        public Parent()
        {
            Console.WriteLine("Parent instance constructor");
        }
    }
}
