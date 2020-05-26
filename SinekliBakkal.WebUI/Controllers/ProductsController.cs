using SinekliBakkal.BLL;
using SinekliBakkal.Entity;
using SinekliBakkal.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinekliBakkal.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        CategoryRepository catRepo = new CategoryRepository();
        ProductRepository proRepo = new ProductRepository();
        // GET: Products
        public ActionResult Index()
        {
            return View(proRepo.GetAll());
        }

        public ActionResult Add()
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Product = new Product();
            viewModel.Categories = catRepo.GetAll();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(ProductViewModel model)
        {
            proRepo.Add(model.Product);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Product = proRepo.GetById(id);
            viewModel.Categories = catRepo.GetAll();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel model)
        {
            proRepo.Update(model.Product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Product p = proRepo.GetById(id);
            proRepo.Delete(p);
            return RedirectToAction("Index");
        }
    }
}