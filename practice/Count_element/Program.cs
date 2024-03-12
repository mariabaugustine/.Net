namespace Count_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter the size ");
            int limit = Convert.ToInt32(Console.ReadLine());
            char[] element = new char[limit];
            Console.WriteLine("Enter the elements");
            for(int i=0; i < limit; i++)
            {

                element[i]=Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("enter the target element");
            char target = Convert.ToChar(Console.ReadLine());
            for (int i=0;i<limit;i++)
            {
                if (element[i]==target)
                {

                count++;

                }
            }
            Console.WriteLine("Count={0}", count);

        }
    }
}