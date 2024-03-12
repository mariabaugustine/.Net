using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance1
{
    class Parent
    {
        String name="maria";
        public void printName()
        {
            Console.WriteLine(name);
        }
       // private Parent()//if we make the parent class constructor private inheritance is not possible
        
      // {
          //  Console.WriteLine("Iam maria");
        //}
        public static void print()
        {
            Console.WriteLine("Hai");
        }


    }
}
