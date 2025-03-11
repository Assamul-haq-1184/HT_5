using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Library
    {
        private Book[] books;
        private int book_count;
        public Library()
        {
            books = new Book[10];
            book_count = 0;
        }
        public void Add_books(Book book)
        {

            books[book_count] = book;
            book_count++;


        }
        public void Books_display()
        {
            Console.WriteLine("                   \t\t-----Books in the library------\n");

            for (int i = 0; i < book_count; i++)
            {
                Console.WriteLine($"->BOOK{i + 1} :");
                Console.WriteLine($"Title  : {books[i].Title}");
                Console.WriteLine($"Author : {books[i].Author}");

                Console.WriteLine($"Genre  : {books[i].Genre}");
                Console.WriteLine($"Year  : {books[i].Publish_Year}\n");

            }
        }
        public void search(string search)
        {
            Console.WriteLine($"->Book detail which you search {search}:");
            Console.WriteLine();

            for (int i = 0; i < book_count; i++)
            {
                if (search == books[i].Title || search == books[i].Author || search == books[i].Genre)
                {
                    Console.WriteLine($"Title : {books[i].Title}         Author : {books[i].Author}");
                    Console.WriteLine($"Genre : {books[i].Genre}              Year   : {books[i].Publish_Year}\n");
                    break;
                }
                
            }


        }
    }
}

