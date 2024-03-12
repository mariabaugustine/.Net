namespace FuncDelegate
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Func<int, int, int> func = add;//point to a function which has return type&parameter
            var sum = func(10, 10);
            Func<int,int,int>fun=(int first,int second) => { return first + second; };

            Console.WriteLine($"SUM:{sum}");
            Func<int> func1 = result;
            var c= func1();
            Console.WriteLine(c);

        }
       static int add(int first, int second)
        {
            return first + second;
        }
        static int result()
        {

            return 0;
        }
    }
}