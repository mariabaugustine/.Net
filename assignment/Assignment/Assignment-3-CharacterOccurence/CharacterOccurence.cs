using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3_CharacterOccurence
{
    class CharacterOccurence
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the word:");
            input = Console.ReadLine();
            Console.WriteLine("Occurance of each character is:");
            while (input.Length > 0)
            {
                
                Console.Write(input[0] + ":");
                

                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {

                        count = count + 1;
                    }


                }
                
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            
            }

                
           

           // Console.WriteLine("{0}={1}", input[i], count);
            Console.ReadLine();

        }
    }
}
