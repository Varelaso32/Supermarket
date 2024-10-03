using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket.Model;

namespace Supermarket.Business //Samuel Varela Morales
{
    internal class CategoriesDAO
    {
        private readonly Dictionary<int, Category> CategoryList;
        private static int categorySecuencial;

        public CategoriesDAO()
        {
            CategoryList = new Dictionary<int, Category>();
            categorySecuencial = 0;

        }//Final de clase

        public bool AddCategory(Category category)
        {
            try
            {
                category.Id = ++categorySecuencial;
                CategoryList.Add((int)category.Id, category);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;

        }//Final de clase

        public bool RemoveCategory(int id)
        {
            bool idExist = CategoryList.ContainsKey(id);
            if (idExist)
            {
                CategoryList.Remove(id);
                return true;
            }
            return false;

        }//Final de clase

        public Category GetCategory(int id)
        {
            bool idExist = CategoryList.ContainsKey(id);
            if (idExist)
            {
                return CategoryList[id];
            }
            return null;

        }//Final de clase

        public bool UpdateCategory(int id, Category category)
        {
            bool idExist = CategoryList.ContainsKey(id);
            if (idExist)
            {
                try
                {
                    CategoryList[id] = category;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;

        }//Final de clase

        public Dictionary<int, Category> GetCategoryList()
        {
            return CategoryList;

        }//Final de clase

    }//Final de linea
}
