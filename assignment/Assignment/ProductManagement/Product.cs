
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ManuFacturedBy { get; set; }
        public double Price { get; set; }

        public static List<Product> ProductList= new List<Product>();
        public int AddProduct()
        {
            var nameCount = ProductList.Count(name => name.ProductName.ToLower() == ProductName.ToLower());
            ProductId = ProductList.Count == 0 ? 1000 : ProductList.Max(id => id.ProductId) + 1;
           );
            int limit=nameList.
            if (nameCount == 0)
            {
                ProductList.Add(new Product
                {
                    ProductName = ProductName,
                    Price = Price,
                    ProductDescription = ProductDescription,
                    ProductId = ProductId,
                    ManuFacturedBy = ManuFacturedBy
                });
            }
            return nameCount;
        }
        public List<Product>ViewAllProduct()
        { 
            return ProductList; 
        }
        public List<Product>ExpensiveProduct()
        {
            var expensiveList = ProductList.FindAll(expense => expense.Price > 1000);
            return expensiveList;
        }
        public List<Product> RemoveProduct()
        {
            ProductList.Clear();
            return ProductList;
        }
    }
}
