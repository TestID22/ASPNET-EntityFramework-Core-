using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class Purchase
    {
        //EF условность требует обозначения первичного ключа с постфиксом ID или иметь имя ID.
        public int PurchaseID { get; set; }
        //имя и фамилия покупателя
        public string Person { get; set; }
        public string Adress { get; set; }
        //номер книги, которую купил.
        public int BookId { get; set; }
        //время покупки
        public DateTime Date { get; set; }

    }
}