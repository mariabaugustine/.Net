using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceExample
{
    internal class Student
    {
        public int Id;
        public string Name;
        public void Print()
        {
            Console.WriteLine($"Student Id:{Id},Name:{Name}");
        }
    }
}
