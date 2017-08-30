using Domain.pcyp.BIZ;
using Domain.pcyp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCyP.WEBSITE.Controllers
{
    public class CategoryController : Controller
    {

        // GET: Category
        public ActionResult Index()
        {
            var vista = CategoryBusiness.getCategoryList();
            /*var cat = new Category();
            cat.Name = "ismael";
            cat.ChangedOn= DateTime.Now;
            cat.ChangedBy = 5;
            cat.CreatedOn= DateTime.Now;
            cat.CreatedBy = 6;
            vista.Add(cat);*/
            return View(vista);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            try
            {
                // TODO: Add insert logic here
                CategoryBusiness.add(model);        
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
