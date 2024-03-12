using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_MANAGEMENT_SYSTEM
{
    internal class BookValidation
    {
        public void validation(Book book)
        {
            if(string.IsNullOrEmpty(book.Title))
            {
                throw new BookException("Title Cannot be blank");
            }
            if (string.IsNullOrEmpty(book.Author))
            {
                throw new BookException("Author Name Cannot be blank");
            }
            if(book.Price<0)
            {
                throw new BookException("Price must be greater than 0");
            }
            if (book.Rating< 0)
            {
                throw new BookException("Rating must be greater than 0");
            }

        }
    }
    internal class BookException:Exception
    {
        public BookException(String message) : base(message) { }
    }
}
