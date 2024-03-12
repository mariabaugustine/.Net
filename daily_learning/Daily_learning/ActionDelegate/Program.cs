using System.Threading.Channels;

namespace ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = Hello;
            action();
            Action action2 = () => Console.WriteLine("Hello WELCOME");
            action2();

            Action<string,string>actionWithPara= Hai;
            actionWithPara("Hai","Hello");
            Action<string>action1 =(string message)=>Console.WriteLine(message);
            action1("hai");
            Action<string>actionWithOnePara= Hellooo;
            actionWithOnePara("Helloooo");

        }
        static void Hello()
        {
            Console.WriteLine("hello");
        }
        static void Hai(string message,string message1)
        {
            Console.WriteLine("Hai");
        }
        static void Hellooo(string message)
        {
            Console.WriteLine("Hellooo");
        }
    }
}