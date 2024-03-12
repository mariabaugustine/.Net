using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_example
{
    internal class Parent
    {
        public Parent(int age):this("na",15)
        {
            Console.WriteLine(age);
        }
        public Parent(string name,int age)
        {

            Console.WriteLine(name);
        }
    }
}
