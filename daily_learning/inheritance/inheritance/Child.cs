using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class Child:Parent

    {
        public Child():base()
        {
            Console.WriteLine("Child Constructor");
        }
       // public Child(String message):base(message)
       // {
       // }
    }
}
