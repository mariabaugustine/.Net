using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort
{
    internal class Student:IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int mark { get; set; }

        public int CompareTo(Student? other)
        {
            //if (this.mark> other.mark)
            // { 
            // return 1;
            // }
            //else if (this.mark> other.mark) 
            // { 
            //     return -1;
            // }
            // return 0;
            return this.Name.CompareTo(other.Name);
        }

    }
}
