using Domain.pcyp.BIZ;
using Domain.pcyp.BLL;
using Domain.pcyp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCyP.WEBSITE.Controllers
{
    public class CategoryController : Controller
    {
        
        
        public ActionResult Index()
        {
            return View (CategoryBusiness.Instance.GetList());
        }

        public ActionResult Details(String id)
        {
            var category = CategoryBusiness.Instance.Find(new Category { Id = id });
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category model)
        {
            CategoryBusiness.Instance.Agregar(model);
            return Redirect("Index");
        }

        // GET: Category/Edit/5
        public ActionResult Edit(String id)
        {
            var category = CategoryBusiness.Instance.Find(new Category { Id = id });
            return View(category);
           
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            //CategoryBusiness.Edit(model);
            return RedirectToAction("Index");
        }

        // GET: Category/Delete/5
        public ActionResult Delete(String id)
        {
            var category = CategoryBusiness.Instance.Find(new Category { Id = id });
            return View(category);

        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(Category model)
        {
            CategoryBusiness.Instance.Delete(model);
            return RedirectToAction("Index");
        }
    }
}
