using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedPrivateConstructor
{
    internal class Class1
    {
        private Class1()
        {
            Console.WriteLine("C#");
        }
        private Class1(String message)
        {
            Console.WriteLine($"{message}");
        }
        //public Class1(String message) { }
    }
}
