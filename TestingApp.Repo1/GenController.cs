using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TestingApp.Repo1
{
    //public class GenController<T,Repo> : Controller where T : class  where Repo : IRepository<T> 
    //{
    //    // GET: Category
    //    Repo repo;
    //    public GenController(Repo repo)
    //    {
    //        this.repo = repo;
    //    }
    //    [HttpGet]
    //    public ActionResult Index()
    //    {
    //        return View(repo.GetAll());
    //    }

    //    public ActionResult Create()
    //    {

    //        return View();
    //    }
    //    [HttpPost]
    //    public ActionResult Create(T entity)
    //    {
    //        repo.Post(entity);

    //        int my = repo.Save();
    //        if (my > 0)
    //        {
    //            ViewBag.Success = "Your Record Has Been Submitted";
    //        }
    //        else
    //        {
    //            ViewBag.Err = " Error!! Something Went Wrong!! ";
    //        }
    //        return RedirectToAction("Index", "Category");
    //    }

    //    public ActionResult Update(int id)
    //    {
    //        var data = repo.Get(id);
    //        return View(data);
    //    }
    //    [HttpPost]
    //    public ActionResult Update(T entity)
    //    {
    //        repo.Put(entity);
    //        repo.Save();
    //        return RedirectToAction("Index", "Category");
    //    }

    //    public ActionResult Delete(int id)
    //    {

    //        repo.Delete(id);
    //        repo.Save();
    //        return RedirectToAction("Index", "Category");
    //    }
    //}
}
