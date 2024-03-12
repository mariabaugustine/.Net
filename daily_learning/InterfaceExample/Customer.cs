using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Customer:IPrint
    {
        public int Id;
        public string Name;

        public void Print()
        {
            Console.WriteLine($"Customer Id:{Id},Name:{Name}");
        }
    }
}
