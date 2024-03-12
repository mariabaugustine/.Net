namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = ClsCalculator.AreEqual <int>(10,20);
            if (IsEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine(" Not Equal");
            }
        }
        
    }
    public class ClsCalculator
    {
        public static bool AreEqual<T>(T firstNumber, T secondNumber)
        {
            return firstNumber.Equals(secondNumber);
        }
    }
}