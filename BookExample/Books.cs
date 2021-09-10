using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    class Books
    {
        public List<Book> books = new List<Book>();
        public bool CompareBook(Book b1)
        {
            bool found = false;

            foreach (Book b in books)
            {
                if (b.ISBN == b1.ISBN)
                {
                    found = true;
                }
            }
            return found;

        }

        public void AddBook()
        {
            Book b = new Book();

            Console.WriteLine("Please enter the ISBN");
            b.ISBN = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Title");
            b.Title = Console.ReadLine();

            Console.WriteLine("Please enter the Author");
            b.Author = Console.ReadLine();

            Console.WriteLine("Please enter th Price");
            b.Price = double.Parse(Console.ReadLine());

            if (!CompareBook(b))
            {
                books.Add(b);
                Console.WriteLine("Book has been added");
            }
            else
            {
                Console.WriteLine("Book already exists");
            }

        }

        public void ShowAllBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }

        }

        public string BookFound()
        {
            int isbn;
            bool found = false;
            Book b1 = new Book();

            Console.WriteLine("Please enter their ID");
            isbn = int.Parse(Console.ReadLine());

            foreach (Book b in books)
            {
                if (b.ISBN == isbn)
                {
                    b1 = b;
                    found = true;
                }

            }
            if (found)
            {
                return b1.ToString();
            }
            else return "Book not found";
        }



        public string RemoveBook()
        {
            int isbn;
            bool removed = false;

            Console.WriteLine("Please enter Book ID");
            isbn = int.Parse(Console.ReadLine());

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn)
                {
                    books.Remove(books[i]);
                    removed = true;
                }
            }
            if (removed)
            {
                return "The book was removed";
            }
            else return "The book did not exist";

        }
    }
}
