using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public string ManufacturedBy { get; set; }

        public int Price { get; set; }

        public string Description { get; set; }
        public void AddProduct(List<Product> ProductList)
        {
            

            var nameCount = ProductList.Count(name => name.Name.ToLower() == Name.ToLower());
            ProductID = ProductList.Count == 0 ? 1000 : ProductList.Max(product => product.ProductID) + 1;
           
            if (nameCount == 0)
            {

                ProductList.Add(new Product { ProductID = this.ProductID, Name = this.Name, ManufacturedBy = this.Name, Price = this.Price, Description = this.Description });
            }
            else
            {
                Console.WriteLine($"{Name} already exist");
            }
        }

        public void DisplayAll(List<Product> ProductList)
        {
            foreach (Product product in ProductList)
            {
                Console.WriteLine($"ID:{ProductID},Name:{Name},ManufacturedBy:{ManufacturedBy},Price:{Price}");
            }

        }
        public void ProductWithPrice(List<Product> ProductList)
        {
            var priceList = ProductList.FindAll(price => price.Price > 1000);
            {
                Console.WriteLine($"ID:{ProductID},Name:{Name},ManufacturedBy:{ManufacturedBy},Price:{Price}");
            }
        }
        public void RemoveProducts(List<Product> ProductList)
        {
            ProductList.Clear();
            Console.WriteLine("All products deleted successfully");
        }
    }
}
