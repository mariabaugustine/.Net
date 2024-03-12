using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_example
{
    internal class Child:Parent
    {
        public Child() : base(12)
        {
            Console.WriteLine("child");
        }
    }
}
