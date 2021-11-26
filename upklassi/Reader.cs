using System;
using System.Collections.Generic;
using System.Text;

namespace obwee
{
    class Reader
    {
        private string fullName;
        private int readerTicket;
        private string fakult;
        private string birthday;
        private string phone;

        public Reader(string fullName, int readerTicket, string fakult, string birthday, string phone)
        {
            this.fullName = fullName;
            this.readerTicket = readerTicket;
            this.fakult = fakult;
            this.birthday = birthday;
            this.phone = phone;

        }

        public string takeBook(int num) { return $"{fullName} взял {num} книги."; }
        public string takeBook(params string[] books)
        {
            string a = "";
            foreach (var item in books)
                a = a + ", " + item;
            return $"{fullName} взял {a} ";
        }

        public string takeBook(params Book[] books)
        {
            string a = "";
            foreach (var item in books)
                a = a + " | " + (item.getBook());
            return $"{fullName} взял {a} ";
        }
        public string returnBook(int num) { return $"{fullName} вернул {num} книги."; }
        public string returnBook(params string[] books)
        {
            string a = "";
            foreach (var item in books)
                a = a + ", " + item;
            return $"{fullName} вернул {a} ";
        }

        public string returnBook(params Book[] books)
        {
            string a = "";
            foreach (var item in books)
                a = a + " | " + (item.getBook());
            return $"{fullName} вернул {a} ";
        }
    }
}
