namespace TaskExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Statred");
            Task task1 = Task.Run(() =>
            {
                PrintCounter();
            });
            task1.Wait();
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadKey();
        }
        static void PrintCounter()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
        }
    }
    }
}