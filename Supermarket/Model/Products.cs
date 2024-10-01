using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model //Samuel Varela Morales
{
    internal class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        public Product(int? id, string name, decimal price, int stock, int categoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            CategoryId = categoryId;
        }

    }//Ultima linea...
}
