using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleValues
{
    class Program
    {
        static void Main(string[] args)
        {

            Parent parent = new Parent();
            Child a = parent.GetData();
            Console.WriteLine(a.name1);
            Console.WriteLine(a.name2);
            Console.ReadLine();
        }
    }
}
