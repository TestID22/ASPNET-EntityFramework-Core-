using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithVisualStudioCreateArchitectureProject.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();
        public static SimpleRepository ShraredRepository => sharedRepository;
       
        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product(){Name="Ауди",Price=129099.45m},
                new Product(){Name="БМВ",Price=79099.45m},
                new Product(){Name="Мерс",Price=3099.45m},
                new Product(){Name="Лада",Price=1299.45m}
            };
            foreach(Product p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);
        }
        
        public IEnumerable<Product> Products => products.Values;
       
        //в строке поставим Имя; объект Продукта в значение
        public void AddProduct(Product p) => products.Add(p.Name, p);
        
    }
}
