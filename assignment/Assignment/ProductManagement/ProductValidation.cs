using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    internal class ProductValidation
    {
        public void validation(Product product)
        {
            if(string.IsNullOrEmpty(product.ProductName)) 
            {
                throw new ProductException("Name cannot be null or empty");

            }
            if(!product.ProductName.All(char.IsLetter))
            {
                throw new ProductException("name must be letter");
            }
            if (string.IsNullOrEmpty(product.ProductDescription))
            {
                throw new ProductException("Name cannot be null or empty");

            }
            if (string.IsNullOrEmpty(product.ManuFacturedBy))
            {
                throw new ProductException("Name cannot be null or empty");

            }
            if (product.Price < 0)
            {
                throw new ProductException("Price must be greaterthan zero");
            }
        }
    }
    internal class ProductException:Exception
    {
        public ProductException(String message):base(message) { } 
       
    }
}
