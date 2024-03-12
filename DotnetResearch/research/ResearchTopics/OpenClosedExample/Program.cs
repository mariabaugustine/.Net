namespace OpenClosedExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle=new Circle(10);
            var cArea=circle.Area();
            Console.WriteLine(cArea);
            Rectangle rectangle = new Rectangle(10, 20);
            var rArea=rectangle.Area();
            Console.WriteLine(rArea);
        }
    }
}