using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ProductList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>();

            Product product = new Product();
            int flag;

            do
            {

                int choice;
                Console.WriteLine("PRODUCT MANAGEMENT");
                Console.WriteLine("Enter the choice");
                Console.WriteLine("1.ADD PRODUCT");
                Console.WriteLine("2.VIEW ALL PRODUCT");
                Console.WriteLine("3.VIEW ALL PRODUCT PRICE > 1000");
                Console.WriteLine("4.REMOVE ALL PRODUCT");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        UserInput();
                        product.AddProduct(ProductList);
                        break;
                    case 2:
                        product.DisplayAll(ProductList);
                        break;
                    case 3:
                        product.ProductWithPrice(ProductList);
                        break;
                    case 4:
                        product.RemoveProducts(ProductList);
                        break;
                }
                Console.WriteLine("Do you wish to continue 1/2");
                flag = Convert.ToInt32(Console.ReadLine());

            } while (flag == 1);
             void UserInput()
            {
                Console.WriteLine("Enter the product name");
                product.Name = Console.ReadLine();
                Console.WriteLine("Enter the manufacturing date");
                product.ManufacturedBy = Console.ReadLine();
                Console.WriteLine("Enter the ddescription");
                product.Description = Console.ReadLine();
                Console.WriteLine("Enter the price");
                product.Price = Convert.ToInt32(Console.ReadLine());
            }

        }


        }
    }