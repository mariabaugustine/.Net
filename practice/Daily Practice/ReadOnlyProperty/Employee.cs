using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyProperty
{
    public  class Employee
    {
        int salary=1000;
        public int Salary   
        {
            get 
            { 
                return salary;  
            }
           

        }
    }
}
