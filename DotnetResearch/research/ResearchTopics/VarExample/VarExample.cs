using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace VarExample
{
    internal class VarExample
    {
        public void GetDataType()
        {
            var a = 'f';
            var b = "Hello World";
            var c = 30.67d;
            var d = false;
            var e = 54544;
            //a = 10;//throws error because the compiler already decided the value of a is char
            
            Console.WriteLine("Type of 'a' is : {0} ", a.GetType());

            Console.WriteLine("Type of 'b' is : {0} ", b.GetType());

            Console.WriteLine("Type of 'c' is : {0} ", c.GetType());

            Console.WriteLine("Type of 'd' is : {0} ", d.GetType());

            Console.WriteLine("Type of 'e' is : {0} ", e.GetType());
        }
        //we can't use the var key word as a return type of a function or a parameter of a function
        //public var print()
        //{
        //    Console.WriteLine("Var Example");
        //}


    }
}
