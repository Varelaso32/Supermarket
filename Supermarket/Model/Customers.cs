using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model //Samuel Varela Morales
{
    internal class Customer
    {
        public int? Id { get; set; }
        public string DocumentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Customer(int? id, string documentNumber, string firstName, string lastName, string address, DateTime birthday, string phoneNumber, string email)
        {
            Id = id;
            DocumentNumber = documentNumber;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            Email = email;
        }

    }//Ultima linea..
}
