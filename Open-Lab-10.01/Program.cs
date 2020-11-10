using System;
using System.Text;

namespace Open_Lab_10._01
{
    class Program
    {
        public class Book
        {
            public string Title;
            private int Pages;

            public int _Pages
            {
                get { return Pages; }
                set { Pages = value; }
            }
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Lord of The Rings";
            book._Pages = 300;

            Console.WriteLine($"Title is: {book.Title} ");
            Console.WriteLine($"Number of pages: {book._Pages} ");
        }
    }
}
