using Interface;

namespace Interface
{
   
   class Customer: ICustomer,ICustomer3
    {
        public void display()
        {
            throw new NotImplementedException();
        }

        public void get()
        {
            throw new NotImplementedException();
        }

        public void GetData(string name)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
        public void Test()
        {
            Console.WriteLine("Hai");
        }

        
    }
}
 public class Program
{
    static void Main(string[] args)
    {
       //ICustomer customer=new Customer();
        //customer.Test();//It is not in the interface.So this is not possible because the customer is the type of ICustomer
    
       Customer customer1=new Customer();
        customer1.Test();
        ICustomer3 customer3=new Customer();//In this only the methods in th interface ICustomer3 is displayed.Because the object customer3 is of type ICustomer3  
        customer3.display();


    }

}