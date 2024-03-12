namespace SRP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write("Enter the first number:");
            double firstNumber=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number");
            double secondNumber=Convert.ToDouble(Console.ReadLine());
            double sum = calculator.Add(firstNumber,secondNumber);
            Console.WriteLine(sum);
            double subtractionResult=calculator.Subtract(firstNumber,secondNumber);
            Console.WriteLine(subtractionResult);
            double multiplicationResult=calculator.Multiplication(firstNumber,secondNumber);
            Console.WriteLine(multiplicationResult);
            double divisionResult=calculator.division(firstNumber,secondNumber);
            Console.WriteLine(divisionResult);
        }
    }
}