using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_1_swap
{
   class SwapNumber
    {
        
        public void Swap(int firstN,int secondN)
        {
            firstN = firstN + secondN;
            secondN = firstN - secondN;
            firstN = firstN - secondN;
            Console.WriteLine("After swapping");
            Console.WriteLine("First Number:"+firstN);
            Console.WriteLine("Second Number:"+secondN);
        }


    }
}
