using Domain.pcyp.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BLL
{
    public static class CategoryBusiness
    {
        private static List<Category> _categoryList = new List<Category>();

        public static void add(Category categoria)
        {
            _categoryList.Add(categoria);
        }

        public static List<Category> getCategoryList()
        {
            return _categoryList;
        }
    }
}
