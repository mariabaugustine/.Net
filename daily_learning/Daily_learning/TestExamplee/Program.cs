namespace TestExamplee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber = new int[] { 13, 14, 25, 30, 56, 11, 20, 29 };

           
            Task<int> task = new Task<int>(() => SumOfAllNumber(arrNumber));
            task.Start();

            
            int sum = task.Result;
            Console.WriteLine("Sum of all numbers in array : {0}", sum);
            Console.WriteLine("In Main Method, Finished work on thread Id: {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
        }
        private static Int32 SumOfAllNumber(int[] arrNumber)
        {
            int sum = 0;
            for (int i = 0; i < arrNumber.Length; i++)
                sum = sum + arrNumber[i];

            Console.WriteLine("In Child Method, Finished work on thread Id : {0}", System.Threading.Thread.CurrentThread.ManagedThreadId);
            return sum;
        }
    }
}