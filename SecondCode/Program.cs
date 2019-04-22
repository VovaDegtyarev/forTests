using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace SecondCode
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }

    class BookContext : DbContext
    {

        public BookContext() : base("UserDB")
        {

        }

        public DbSet<Book> booklist { set; get; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            using (BookContext bk = new BookContext())
            {
                var books = bk.booklist;
                foreach (Book b in books)
                {
                    Console.WriteLine(b.id + " " + b.Title + " " + b.Author);
                }

                Console.ReadKey();
            }


        }
    }
}
