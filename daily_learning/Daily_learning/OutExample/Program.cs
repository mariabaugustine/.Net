namespace OutExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Addition = 0;
            int Multiplication = 0;
            int Subtraction = 0;
            int Division = 0;
            //While calling the Method, decorate the out keyword for out arguments
            //Addition, Multiplication, Subtraction, and Division variables values will be updated by Math Function
            Math(200, 100, out Addition, out Multiplication, out Subtraction, out Division);
            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Division: {Division}");

            Console.ReadKey();
        }
        //Declaring Method with out Parameters
        public static void Math(int number1, int number2, out int Addition,
            out int Multiplication, out int Subtraction, out int Division)
        {
            Addition = number1 + number2; //This will Update the Addition variable Declared in Main Method
            Multiplication = number1 * number2; //This will Update the Multiplication variable Declared in Main Method
            Subtraction = number1 - number2; //This will Update the Subtraction variable Declared in Main Method
            Division = number1 / number2; //This will Update the Division variable Declared in Main Method
        }
    
    }
}