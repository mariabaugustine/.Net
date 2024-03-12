namespace ParameterizedThread
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Program program = new Program();
           // ParameterizedThreadStart parameterized = new ParameterizedThreadStart(program.DisplayNumber);
            Thread t1= new Thread(program.DisplayNumber);
            t1.Start();


        }
        public void DisplayNumber(object max)
        {
            max = 12;
            Console.WriteLine(max);
        }
    }
}