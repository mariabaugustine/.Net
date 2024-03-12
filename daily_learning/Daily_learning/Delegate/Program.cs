namespace Delegate
{
    internal class Program
    {
        delegate void MyFirstDelegate();//MyFirstDelegate is a delegate which pointiing to a function with same signature
        static void Main(string[] args)
        {
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(Display);
            myFirstDelegate();

            
        }
        static void Display()
        {
            Console.WriteLine("My First Delegate");
        }
        static void Print(int value)
        { 
            
        }
    }
}