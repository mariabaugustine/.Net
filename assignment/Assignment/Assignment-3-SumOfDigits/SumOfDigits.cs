using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3_SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            Console.WriteLine("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
             sum = (number % 9 == 0) ? 9 : number % 9;
            //while (number > 0)
            //{
            //    int remainder = number % 10;
            //    sum = sum + remainder;
            //    number = number / 10;

            //}
            Console.WriteLine("Sum of digits is: {0}",sum);
            Console.ReadLine();
        }
    }
}
