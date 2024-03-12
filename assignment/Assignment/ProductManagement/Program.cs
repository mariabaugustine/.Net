namespace ProductManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ProductValidation productValidation = new ProductValidation();
            int choice = 1;
            Console.WriteLine("............................PRODUCT MANAGEMENT.....................................");
            do
            {
                try
                {
                    Console.WriteLine("Enter the choice\n1.Add Product\n2.View All product\n3.Product with price>1000\n4.Remove all Product\n5.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:try
                            {
                                GetDetails();
                                productValidation.validation(product);
                                var count = product.AddProduct();
                                if (count > 0)
                                {
                                    Console.WriteLine("*************Product Already Exist***************");
                                }
                               
                            }catch(ProductException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:
                            var allProduct = product.ViewAllProduct();
                            if (allProduct.Count == 0)
                            {
                                Console.WriteLine("******************Product List is Empty*************");

                            }
                            else
                            {
                                foreach (Product product1 in allProduct)
                                {
                                    Console.WriteLine($"Id:{product1.ProductId}\nProduct Name:{product1.ProductName}\nDescription{product1.ProductDescription}\nManufacturedBy:{product1.ManuFacturedBy}\nPrice:{product1.Price}");
                                }

                            }
                            break;
                        case 3:
                            var expense = product.ExpensiveProduct();
                            if (expense.Count == 0)
                            {
                                Console.WriteLine("***************************No Record Found*********************");
                            }
                            else
                            {
                                foreach (Product product2 in expense)
                                {
                                    Console.WriteLine($"Id:{product2.ProductId}\tProduct Name:{product2.ProductName}\tDescription{product2.ProductDescription}\tManufacturedBy:{product2.ManuFacturedBy}\tPrice:{product2.Price}");
                                }
                            }
                            break;
                        case 4:
                            var status = product.RemoveProduct();
                            if (status.Count == 0)
                            {
                                Console.WriteLine("Products deleted successfully");

                            }
                            break;
                        case 5:
                            break;


                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            } while (choice != 5);
        
        void GetDetails()
            {
                Console.Write("Enter the product Name:");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Discripion");
                product.ProductDescription = Console.ReadLine();
                Console.WriteLine("Enter manufacturedBy");
                product.ManuFacturedBy = Console.ReadLine();
                Console.WriteLine("Enter the Price");
                product.Price = double.Parse(Console.ReadLine());
            }

        }
    }
}
