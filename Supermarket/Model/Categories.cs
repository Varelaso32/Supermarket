using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model //Samuel Varela Morales
{
    internal class Category
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int? id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

    }//Ultima linea..
}
