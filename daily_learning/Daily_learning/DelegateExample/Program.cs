namespace DelegateExample
{
    internal class Program
    {
        
        delegate int DelegateExample(int a,int b);

        static void Main(string[] args)
        {
            
            DelegateExample delegateExample = new DelegateExample(print);
            // delegateExample(1,2);
            int c = delegateExample.Invoke(1, 2);
            Console.WriteLine(c);
           
        }
        static int print(int a,int b)
        {

            return a + b;
        }
    }
}