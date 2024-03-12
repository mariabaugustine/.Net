using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Class1 : Interface1, Interface2
    {
        void Interface1.print()
        {
            Console.WriteLine("interface1");
        }

        void Interface2.print()
        {
            Console.WriteLine("Interface2");
        }
    }
}
