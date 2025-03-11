using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public int Publish_Year;

        public Book(string title="Unknown", string author= "Unknown", string genre = "Unknown", int publish_Year=0)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Publish_Year = publish_Year;
        }

    }
}
