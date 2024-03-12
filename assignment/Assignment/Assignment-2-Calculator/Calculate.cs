using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2_Calculator
{
    class Calculate
    {
        public static int add(int firstNumber,int secondNumber)
        {
            return firstNumber+secondNumber;
            
        }
        public static int subtraction(int firstNumber,int secondNumber)
        {
            return firstNumber - secondNumber;
           
        }
        public static int multiplication(int firstNumber,int secondNumber)
        {
            return firstNumber * secondNumber;
        
        }
        public static int division(int firstNumber,int secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("division is not possible");
            }
            return firstNumber / secondNumber;
       
        }
    }
}
