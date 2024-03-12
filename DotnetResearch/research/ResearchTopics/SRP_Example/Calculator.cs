using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example
{
    internal class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;

        }
        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;

        }
        public double Multiplication(double firstNumber, double secondNumber) 
        {
            return firstNumber * secondNumber;
        }
        public double division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
