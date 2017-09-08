using Domain.pcyp.BIZ;
using Domain.pcyp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.pcyp.BLL
{
    public class CategoryBusiness
    {

        private static CategoryBusiness _instance;
        private readonly CategoryRepository db = null;

        private CategoryBusiness()
        {
            this.db = new CategoryRepository();
        }

        public static CategoryBusiness Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoryBusiness();
                return _instance;
            }
        }



        public void Agregar(Category categoria)
        {
            categoria.Id = Guid.NewGuid().ToString();
            categoria.CreatedOn = DateTime.Now;
            categoria.ChangedOn = DateTime.Now;
            categoria.CreatedBy = 0;
            categoria.ChangedBy = 0;

            db.Add(categoria);
        }

        public List<Category> GetList()
        {
            return db.All();
        }
        public Category Find(Category categoria)
        {
            var category = db.Find(categoria);
            return categoria;
        }
        public void Delete (Category categoria)
        {
            db.Delete(categoria);
        }
    }
    }
