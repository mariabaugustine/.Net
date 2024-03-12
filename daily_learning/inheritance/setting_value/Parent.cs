using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace setting_value
{
    class Parent
    {
        string firstNamee;
        string lastNamee;
        public Parent( string firstName,string secondName)
        {
            firstNamee = firstName;
            lastNamee = secondName;
            Console.WriteLine(firstNamee);
            Console.WriteLine(lastNamee);

        }
        public void PrintDetails()
        {
             Console.WriteLine(firstNamee);
             Console.WriteLine(lastNamee);

        }
        
    }
}
