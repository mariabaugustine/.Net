using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism1
{
    class Employee
    {
        public string firstName = "John";
        public  virtual void printName()
        {
            Console.WriteLine(firstName);

        }
    }
}
