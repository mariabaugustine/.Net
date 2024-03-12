//using System.Threading.Tasks;
namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a task instance
            Task t = new Task(PrintOddEvenNumbers);
            t.Start();
           // t.Wait();
            Console.WriteLine("In Main Method, Finished work on thread : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }
        public static void PrintOddEvenNumbers()
        {
            Console.WriteLine("Even and Odd numbers less than 10");

            //Print even numbers
            for (int i = 0; i <= 10; i++)
                if (i % 2 == 0)
                    Console.WriteLine("Even Number : {0}", i);

            //Print odd numbers
            for (int i = 0; i <= 10; i++)
                if (i % 2 != 0)
                    Console.WriteLine("Odd Number : {0}", i);
            Console.WriteLine("In Child Method, Finished work on thread : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
        }
    }
}
