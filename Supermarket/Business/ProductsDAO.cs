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

        }//Final de clase

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

        }//Final de clase

        public bool RemoveProduct(int id)
        {
            bool idExist = ProductList.ContainsKey(id);
            if (idExist)
            {
                ProductList.Remove(id);
                return true;
            }
            return false;

        }//Final de clase

        public Product GetProduct(int id)
        {
            bool idExist = ProductList.ContainsKey(id);
            if (idExist)
            {
                return ProductList[id];
            }
            return null;

        }//Final de clase

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

        }//Final de clase

        public Dictionary<int, Product> GetProductList()
        {
            return ProductList;

        }//Final de clase

    }//Final de la Clase
}
