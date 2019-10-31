using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class Book
    {
        //Для EF требования первое свойсто должно иметь имя ID или постфикс ID.
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

    }
}