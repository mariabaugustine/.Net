namespace RefExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Declare the Variables
            int Addition = 0;
            int Multiplication = 0;
            int Subtraction = 0;
            int Division = 0;
            //While calling the Method, decorate the ref keyword for ref arguments
            //Addition, Multiplication, Subtraction, and Division variables values will be updated by Math Function
            Math(200, 100, ref Addition, ref Multiplication, ref Subtraction, ref Division);
            Console.WriteLine($"Addition: {Addition}");
            Console.WriteLine($"Multiplication: {Multiplication}");
            Console.WriteLine($"Subtraction: {Subtraction}");
            Console.WriteLine($"Division: {Division}");

            Console.ReadKey();
        }
        public static void Math(int number1, int number2, ref int Addition,
           ref int Multiplication, ref int Subtraction, ref int Division)
        {
            Addition = number1 + number2; //This will Update the Addition variable Declared in Main Method
            Multiplication = number1 * number2; //This will Update the Multiplication variable Declared in Main Method
            Subtraction = number1 - number2; //This will Update the Subtraction variable Declared in Main Method
            Division = number1 / number2; //This will Update the Division variable Declared in Main Method
        }
    }
    }
