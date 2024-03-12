using System.Reflection.Metadata;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,limit,flag=0;
            Console.WriteLine("Enter the number");
            number =Convert.ToInt32(Console.ReadLine());
            limit=number/2;
            for(int i=2;i<=limit;i++) 
            {
                if(number%i==0)
                {
                    flag = 1;
                }
            }
            if(flag==0) 
            {
                Console.WriteLine("number is prime");
            }

        }
    }
}