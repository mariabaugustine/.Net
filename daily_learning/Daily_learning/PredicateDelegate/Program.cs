using System;

namespace PredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> predicate = IsEquals;
            predicate(10);
            Predicate<int> predicate2=(int number) =>   true; 
           // predicate2(10);
            Console.WriteLine(predicate2(0));
           // Predicate<string,string> predicate2 = IsPromoted;It is not possible because predicate take only one argument
           Func<int,bool>func= IsEquals;
            func(12);
            Predicate<string> predicate1 = (name) => { return true; };
       


        }
        static bool IsEquals(int number)
        {
            if (number == 0)
            {
                return true;
            }
            return false;
        }
    }
}