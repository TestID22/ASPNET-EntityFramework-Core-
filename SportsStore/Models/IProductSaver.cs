using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductSaver
    {
        IEnumerable<Product> Products { get;}
    }
}
