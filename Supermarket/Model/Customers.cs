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
        public string PhoneNumber { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer(int? id, string firstName, string lastName, string documentNumber,
                string phoneNumber, string birthday, string email, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DocumentNumber = documentNumber;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Email = email;
            Address = address;
        }


    }//Ultima linea..
}
