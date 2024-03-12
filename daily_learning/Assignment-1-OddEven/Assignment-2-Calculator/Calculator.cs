using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2_Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {

            char ch;
            do
            {
                char choice;

                Console.WriteLine("Enter the first number");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation");
                Console.WriteLine("+ addition");
                Console.WriteLine("- subtraction");
                Console.WriteLine("* multiplication");
                Console.WriteLine("/ division");
                choice = Convert.ToChar(Console.ReadLine());
                int answer;
                switch (choice)
                {


                    case '+': answer =Calculate.add(firstNumber,secondNumber);
                        Console.WriteLine("{0}+{1}={2}", firstNumber, secondNumber, answer);
                        break;
                    case '-': answer = firstNumber - secondNumber;
                        Console.WriteLine("{0}-{1}={2}", firstNumber, secondNumber, answer);
                        break;
                    case '*': answer = firstNumber * secondNumber;
                        Console.WriteLine("{0}*{1}={2}", firstNumber, secondNumber, answer);
                        break;
                    case '/': answer = firstNumber / secondNumber;
                        Console.WriteLine("{0}/{1}={2}", firstNumber, secondNumber, answer);
                        break;

                    default: Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Do you wish to continue y/n");
                ch = Convert.ToChar(Console.ReadLine().ToLower());

            } while (ch == 'y');
              Console.ReadLine();
          }
    }
}
