namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int number = 0;
            List<int> Lucky = new List<int>();

            while (number<1000)
            {
                if (number % 3 == 0|| number % 6 == 0|| number % 9 == 0)
                {
                    Lucky.Add(number);
                }
                number = number + 1;
                
            }
            foreach(var item in Lucky)
            {
                Console.WriteLine(item);
            }
        }
    }
}