namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number,r,sum=0;
            Console.WriteLine("Enter the number");
            number=Convert.ToInt32(Console.ReadLine());
            int temp= number;
            while (number > 0)
            {
                r = number % 10;
                sum = sum + r * r * r;
                number = number / 10;
            }
            if (temp==sum)
            {
                Console.WriteLine("armstrong number");
            }

            }
        }
    }
