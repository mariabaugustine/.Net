using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace setting_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent("maria","Augustine");
            parent.PrintDetails();
            
            Console.ReadLine();
        }
    }
}
