using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class ProcessInput
    {
        IPrint _print;
        public ProcessInput(IPrint print)
        {
            _print = print;
        }
        public void Print() 
        {
            _print.Print();
        }
    }
}
