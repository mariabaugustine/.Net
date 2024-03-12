namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            ((Interface1)class1).print();
            //var ch = class1 as Interface2;
           // ch.print();
            
        }
    }
}