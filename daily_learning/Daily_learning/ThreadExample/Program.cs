namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "MAIN THREAD";
            Console.WriteLine("main thread started");
            Thread threadOne = new Thread(MethodOne);
            Thread threadTwo = new Thread(MethodTwo);
           
            threadOne.Start();
            threadTwo.Start();
           
            Console.WriteLine("Main thread ended");


        }
        static void MethodOne()
        {
           
            Console.WriteLine("Thread one");
        }
        static void MethodTwo()
        {
            Console.WriteLine("Thread two");
       }
       
    }

}