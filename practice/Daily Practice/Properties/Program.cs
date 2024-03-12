namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Maria";
            Console.WriteLine("Employee Name:"+employee.Name);
        }
    }
}