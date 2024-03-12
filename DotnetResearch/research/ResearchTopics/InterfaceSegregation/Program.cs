namespace InterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILead lead = new Manager();
            lead.AssignTask();
            lead.CreateSubTask();
            IProgrammer programmer = new Employee();
            programmer.WorkOnTask();
        }
    }
}