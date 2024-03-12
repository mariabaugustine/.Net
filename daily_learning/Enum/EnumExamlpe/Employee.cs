using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExamlpe
{
    enum Gender 
    {
      Male,
      Female,
      Unknown
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender  Gender{ get; set; }

    }
}
