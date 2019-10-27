using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class Book
    {
        //Для EF требования 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public int Price { get; set; }

    }
}