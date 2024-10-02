using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Business //Samuel Varela Morales
{
    internal class ProductDAO
    {
        private readonly Dictionary<int, Product> ProductList;
        private static int productSecuencial;

        public ProductDAO()
        {
            ProductList = new Dictionary<int, Product>();
            productSecuencial = 0;
        }

        public bool AddProduct(Product product)
        {
            try
            {
                product.Id = ++productSecuencial;
                ProductList.Add((int)product.Id, product);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        public bool RemoveProduct(int id)
        {
            bool idExist = ProductList.ContainsKey(id);
            if (idExist)
            {
                ProductList.Remove(id);
                return true;
            }
            return false;
        }

        public Product GetProduct(int id)
        {
            bool idExist = ProductList.ContainsKey(id);
            if (idExist)
            {
                return ProductList[id];
            }
            return null;
        }

        public bool UpdateProduct(int id, Product product)
        {
            bool idExist = ProductList.ContainsKey(id);
            if (idExist)
            {
                try
                {
                    ProductList[id] = product;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }

        public Dictionary<int, Product> GetProductList()
        {
            return ProductList;
        }
    }
}
