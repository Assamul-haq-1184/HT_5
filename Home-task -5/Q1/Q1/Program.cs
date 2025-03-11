using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Add_books(new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 1925));
            library.Add_books(new Book("1984", "George Orwell", "Dystopian", 1949));
            library.Add_books(new Book());
            
            library.Books_display();
            library.search("1984");
            
        }
    }
}
