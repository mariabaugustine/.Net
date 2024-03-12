using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.printName();
            Child.print();
            Console.ReadLine();
        }
    }
}
