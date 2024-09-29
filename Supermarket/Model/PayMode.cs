using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model //Samuel Varela Morales
{
    internal class PayMode
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public PayMode(int? id, string name)
        {
            Id = id;
            Name = name;
        }

    }//Ultima linea
}
