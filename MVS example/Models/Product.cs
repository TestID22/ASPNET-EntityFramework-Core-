using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeaturesCore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public string Category { get; set; } = "Водный спорт";
        public Product Related { get; set; }
        public bool InStock { get; } = true;

        public Product(bool InStock = true)
        {
            this.InStock = InStock;
        }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Category="Лодка", Price = 45.55m };
            Product lifeJacket = new Product { Name = "Jacket", Price = 10.55m };
            kayak.Related = lifeJacket;
            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
