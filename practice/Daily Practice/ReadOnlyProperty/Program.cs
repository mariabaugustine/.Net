namespace ReadOnlyProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
           // employee.Salary = 1000;// it is not possible because it is read only
            Console.WriteLine($"Salary:{ employee.Salary}");
        }
    }
}