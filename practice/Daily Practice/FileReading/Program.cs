using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace FileReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input;
            string[] str;
            int count = 0;
            String file = @"C:\reading\reading.text";
            //using(StreamReader sr = new StreamReader(file)) 
            str =File.ReadAllLines(file);
            Console.WriteLine("Enter the input");
            input=Console.ReadLine();
            foreach (string line in str)
            {
                if (line.Contains(input))
                {
                    Console.WriteLine(input);
                    count++;
                }
            }
             if(count == 0)
            {
                Console.WriteLine("No Record Found");
            }  
            
        }
    }
}