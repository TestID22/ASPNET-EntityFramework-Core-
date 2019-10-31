using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "We Are Anonymous", Author = "Parmy Olson", Price = 45 });
            db.Books.Add(new Book { Name = "Hacker, Hoaxer, Whistleblower, Spy", Author = "Gabriela Coleman", Price = 35 });
            db.Books.Add(new Book { Name = "Clr Via C#", Author = "Rihter", Price = 25 });
            db.Books.Add(new Book { Name = "Asp.Net Core", Author = "Adan Frimen", Price = 100 });

            base.Seed(db);
        }

    }
}