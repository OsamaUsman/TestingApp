using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingApp.Model;
using TestingApp.Repo1;

namespace TestingApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryRepository repo;
        public CategoryController()
        {

            repo = new CategoryRepository();
        }
        
        
        [HttpGet]
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Category entity)
        {
            repo.Post(entity);

            int my = repo.Save();
            if (my > 0)
            {
                ViewBag.Success = "Your Record Has Been Submitted";
            }
            else
            {
                ViewBag.Err = " Error!! Something Went Wrong!! ";
            }
            return RedirectToAction("Index", "Category");
        }

        public ActionResult Update(int id)
        {
            var data = repo.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Update(Category entity)
        {
            repo.Put(entity);
            repo.Save();
            return RedirectToAction("Index", "Category");
        }

        public ActionResult Delete(int id)
        {

            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index", "Category");
        }
    }

}

