namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();
            customer.Name = "   Maria";
            customer.Id = 1;
            ProcessInput processInput=new ProcessInput(customer);
            processInput.Print();

        }
    }
}