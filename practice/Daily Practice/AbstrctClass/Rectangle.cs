using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrctClass
{
    internal class Rectangle : Area

    {
        public override int Areaa( int length,int bredth)
        {
            return length * bredth;
           
        }
        public void Display()
        {
            Console.WriteLine("hello");
        }
    }
}
