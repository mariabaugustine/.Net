using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleValues
{
    class Parent
    {
        string firstName = "Maria";
        string lastName = "Augusine";
        public Child GetData()
        {
            Child child = new Child();
            child.name1 =this.firstName;
            child.name2 =this.lastName;
            return child;
        }
       

    }
}
