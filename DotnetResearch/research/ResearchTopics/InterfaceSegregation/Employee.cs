using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Employee : IProgrammer
    {
        public void WorkOnTask()
        {
            Console.WriteLine("Programmer doing task assigned");
        }
    }
}
