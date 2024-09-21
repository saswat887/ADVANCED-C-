using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1Container c = new Model1Container();
            Book book = new Book()
            {
                BookId=1,
                BookAuthor="AA",
                BookName="AAA",
                Price=1000,
                PYear=2024
            };
            c.Books.Add(book);
            c.SaveChanges();

            
        }
    }
}
