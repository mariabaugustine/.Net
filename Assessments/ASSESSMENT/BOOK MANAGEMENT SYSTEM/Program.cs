using System.Security.Cryptography.X509Certificates;

namespace BOOK_MANAGEMENT_SYSTEM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************BOOK MANAGEMENT SYSTEM**************************");
            int choice=1;
            Book book = new Book();
            BookValidation bookValidation = new BookValidation();
            do
            {
                try
                {


                    Console.WriteLine("Enter the Choice:\n\n1.Add Book\n\n2.View All Book\n\n3.Search Book\n\n4.Remove All\n\n5.Exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                GetDetails();
                                bookValidation.validation(book);
                                var nameCount = book.AddBook();
                                if (nameCount > 0)
                                {
                                    Console.WriteLine("\n**********************Book Already Exist********************************");
                                }
                                else
                                {
                                    Console.WriteLine("\n********************Book Added Successfuuly*****************************");
                                }
                            }
                            catch (BookException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 2:
                            var show = book.ViewAllBook();
                            if (show.Count == 0)
                            {
                                Console.WriteLine("\n**************************No Record Found**********************************");

                            }
                            else
                            {
                                foreach (Book book1 in show)
                                {
                                    Console.WriteLine($"BOOK ID:{book1.BookId}\t BOOK NAME:{book1.Title}\tAUTHOR:{book1.Author}\tPRICE:{book1.Price}\tRating:{book1.Rating}");
                                }

                            }
                            break;
                        case 3:
                            Console.Write("\n\nEnter the author name to search the book:");
                            book.SearchName = Console.ReadLine();
                            var searchList = book.SearchBook();
                            if (searchList.Count == 0)
                            {
                                Console.WriteLine("\n********************No Book Found************************");

                            }
                            else
                            {
                                foreach (Book book2 in searchList)
                                {
                                    Console.WriteLine($"BOOK ID:{book2.BookId}\t BOOK NAME:{book2.Title}\tAUTHOR:{book2.Author}\tPRICE:{book2.Price}\tRating:{book2.Rating}");
                                }


                            }
                            break;
                        case 4:
                            var status = book.RemoveAll();
                            if (status.Count == 0)
                            {
                                Console.WriteLine("\n*******************************NO Record Found****************");
                            }
                            break;
                    }
                }
                catch(Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                }

            }while(choice != 5);
            void GetDetails()
            {
                Console.Write("\n\nEnter the Book Title:");
                book.Title = Console.ReadLine();
                Console.Write("\n\nEnter the Author Name:");
                book.Author = Console.ReadLine();
                Console.Write("\n\nEnter the Rating:");
                book.Rating=double.Parse(Console.ReadLine());
                Console.Write("\n\nEnter the Price:");
                book.Price=double.Parse(Console.ReadLine());
            }
        }
    }
}