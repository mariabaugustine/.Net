using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrctClass
{
    abstract class Area
    {
        abstract public int Areaa(int length,int bredth);
        public int Perimeter(int length, int bredth)
        {
            return 2 * (length + bredth);

        }
        public void Display()
        {
            Console.WriteLine("hai");
        }

    }
}
