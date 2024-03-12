using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeDemo
{
    public class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public DateOnly DateOfbirth { get; set; }

        public void Details()
        {
            Name = "Maria B Augustine";
            Age = 24;
            //DateOfbirth = 30 - 03 - 1999;
        }
    }
}
