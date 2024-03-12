namespace AbstrctClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Rectangle rectangle = new Rectangle();
         int area=   rectangle.Areaa(10, 20);
            Console.WriteLine($"Area:{area}");
            int perimeter= rectangle.Perimeter(10,20);
            Console.WriteLine($"Perimeter:{perimeter}");
//Area areaa = new Rectangle();
           // areaa.Display();
        }
    }
}