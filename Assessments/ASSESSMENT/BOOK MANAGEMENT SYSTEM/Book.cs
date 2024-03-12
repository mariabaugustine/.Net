using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK_MANAGEMENT_SYSTEM
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author  { get; set; }

        public double Rating { get; set; }  
         
        public double Price { get; set; }
         public string SearchName { get; set; }
        
        public static List<Book>BookList=new List<Book>();
        public int AddBook()
        {
            var nameCount = BookList.Count(title => title.Title.ToLower() == Title.ToLower() && Author.ToLower()==Author.ToLower()); 
            BookId = BookList.Count == 0 ? 500 : BookList.Max(Id => Id.BookId) + 1;
            if (nameCount == 0)
            {
                BookList.Add(new Book() { BookId = BookId, Title = Title, Author = Author, Rating = Rating, Price = Price });

               
            }

            return nameCount;
        }
      public List<Book> ViewAllBook()
        { 
            return BookList;
        }
        public List<Book>SearchBook()
        {
            var searchList = BookList.FindAll(name => name.Author == SearchName);
            return searchList;
        }
     public List<Book>RemoveAll()
        {
            BookList.Clear();
            return BookList;
        }
    }
}
