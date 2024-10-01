using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Business
{
    internal class CustomerDAO
    {
        private readonly Dictionary<int, Customer> CustomerList;
        private static int customerSecuencial;

        public CustomerDAO()
        {
            CustomerList = new Dictionary<int, Customer>();
            customerSecuencial = 0;

        }//Final de clase

        public bool AddCustomer(Customer customer)
        {
            try
            {
                customer.Id = ++customerSecuencial;
                CustomerList.Add((int)customer.Id, customer);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;

        }//Final de clase

        public bool RemoveCustomer(int id)
        {
            bool idExist = CustomerList.ContainsKey(id);
            if (idExist)
            {
                CustomerList.Remove(id);
                return true;
            }
            return false;

        }//Final de clase

        public Customer GetCustomer(int id)
        {
            bool idExist = CustomerList.ContainsKey(id);
            if (idExist)
            {
                return CustomerList[id];
            }
            return null;

        }//Final de clase

        public bool UpdateCustomer(int id, Customer customer)
        {
            bool idExist = CustomerList.ContainsKey(id);
            if (idExist)
            {
                try
                {
                    CustomerList[id] = customer;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;

        }//Final de clase

        public Dictionary<int, Customer> GetCustomerList()
        {
            return CustomerList;

        }//Final de clase
    }
}
