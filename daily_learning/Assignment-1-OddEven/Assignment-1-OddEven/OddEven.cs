using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the target number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Choice:");
            Console.WriteLine("E for Even numbers");
            Console.WriteLine("O for Odd numbers");
            Char choice =Convert.ToChar(Console.ReadLine().ToLower());
            switch (choice)
            {
                case 'o':
                    Console.WriteLine("Odd numbers are ");
                    
                    for (int i = 1; i < number; )
                    {
                        
                        Console.WriteLine(i);
                        i = i + 2;
                    }
                    break;
                case 'e':
                    Console.WriteLine("Even numbers are");
                    for (int i = 0; i < number; )
                    {
                       
                        Console.WriteLine(i);
                        i = i + 2;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

            Console.ReadLine();

        }
    }
}
