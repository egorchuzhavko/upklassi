using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Book
    {
        private string nameBook;
        private string author;

        public Book(string nameBook, string author)
        {
            this.nameBook = nameBook;
            this.author = author;
        }

        public string getBook() { return nameBook; }
    }
}
