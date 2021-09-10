using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExample
{
    class Program
    {
       
        static void Main(string[] args)
        {


            Books bookList = new Books();
            int option;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("*************Book Management**********");
                Console.WriteLine("1: Add a new Book");
                Console.WriteLine("2: Find an Book");
                Console.WriteLine("3: Remove an Book");
                Console.WriteLine("4: Show All Books");
                Console.WriteLine("5: Quit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bookList.AddBook();
                        break;
                    case 2:
                        Console.WriteLine(bookList.BookFound()); 
                        break;
                    case 3:
                        Console.WriteLine(bookList.RemoveBook());
                        break;
                    case 4:
                        bookList.ShowAllBooks();
                        break;
                    case 5:
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;

                }
            }

        }
        
    }
}
