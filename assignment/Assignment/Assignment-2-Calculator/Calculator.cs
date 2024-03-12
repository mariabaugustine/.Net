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
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the operation");
                Console.WriteLine("+ addition");
                Console.WriteLine("- subtraction");
                Console.WriteLine("* multiplication");
                Console.WriteLine("/ division");
                choice = Convert.ToChar(Console.ReadLine());
              
                int result;
               
                switch (choice)
                {


                    case '+': result = Calculate.add(number1, number2);
                        Console.WriteLine("{0}+{1}={2}",number1,number2,result);
                              break;
                    case '-': result = Calculate.subtraction(number1, number2);
                              Console.WriteLine("{0}-{1}={2}",number1,number2,result);
                              break;
                    case '*': result=Calculate.multiplication(number1,number2);
                              Console.WriteLine(result);
                              break;
                    case '/': result=Calculate.division(number1,number2);
                              Console.WriteLine("{0}/{1}={2}",number1,number2,result);
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

