using SinekliBakkal.BLL;
using SinekliBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinekliBakkal.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        CategoryRepository repo = new CategoryRepository();
        // GET: Categories
        public ActionResult Index()
        {
            List<Category> categoryList = repo.GetAll();
            return View(categoryList);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category entity)
        {
            repo.Add(entity);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Category category = repo.GetById(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category entity)
        {
            repo.Update(entity);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Category category = repo.GetById(id);
            repo.Delete(category);
            return RedirectToAction("Index");
        }
    }
}