using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance1
{
    class Child:Parent
    {
        public void printName()//To hide  the same method in the parent class add new keyword{public void new printName()}
        {                      //if parent and child class have same method if we call the method using child class object child class method is called
            Console.WriteLine("Iam from child");
        }
        public void getParentPrintName()
        {
            base.printName();
        }
       
    }
}
