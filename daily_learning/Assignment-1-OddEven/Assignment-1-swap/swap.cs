using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_1_swap
{
    class swap
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("Enter the first number");
            firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            SwapNumber sn = new SwapNumber();
            sn.Swap(firstNumber,secondNumber);
            Console.ReadLine();



        }
    }
}
