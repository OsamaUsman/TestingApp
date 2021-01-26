using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingApp.Model;
using TestingApp.Repo1;

namespace TestingApp.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        ProductRepository repo;
        
        public ProductController()
        {
            repo = new ProductRepository();
        }
        
        public ActionResult Index(string search)
        {
            if (search != null)
            {
                var data = repo.Search(search);
                
                return View(data);

            }
            
                return View(repo.GetAll());

        }

        public ActionResult Create()
        {
             
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product entity)
        {
            if(ModelState.IsValid == true)
            {
                string filename = Path.GetFileNameWithoutExtension(entity.ImgFile.FileName);
                string extension = Path.GetExtension(entity.ImgFile.FileName);
                filename = filename + extension;
                entity.ImgPath = "~/uploads/" + filename;
                filename = Path.Combine(Server.MapPath("~/uploads/"), filename);
                entity.ImgFile.SaveAs(filename);
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
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");
        }

        public ActionResult Update(int id)
        {
            var data = repo.Get(id);
            Session["Img"] = data.ImgPath.ToString();
            return View(data);
        }
        [HttpPost]
        public ActionResult Update(Product entity)
        {
            if (ModelState.IsValid == true) 
            { 
            if (entity.ImgFile != null)
            {
                    string filename = Path.GetFileNameWithoutExtension(entity.ImgFile.FileName);
                    string extension = Path.GetExtension(entity.ImgFile.FileName);
                    filename = filename + extension;
                    entity.ImgPath = "~/uploads/" + filename ;
                    filename = Path.Combine(Server.MapPath("~/uploads/"), filename);
                    entity.ImgFile.SaveAs(filename);

                    repo.Put(entity);
                    int check = repo.Save();
                    if(check > 0)
                    {
                        string Imgpath = Request.MapPath(Session["Img"].ToString());
                        if (System.IO.File.Exists(Imgpath))
                        {
                            System.IO.File.Delete(Imgpath);
                        }
                        ModelState.Clear();
                        return RedirectToAction("Index", "Product");
                    }
                    
            }
                else
                {
                    entity.ImgPath = Session["Img"].ToString();
                    repo.Put(entity);
                    repo.Save();
                    return RedirectToAction("Index" ,"Product");
                }
            }

            return View();
        }

        public ActionResult Delete(int id)
        {

            var row = repo.Delete(id);
            int check = repo.Save();
            if (check > 0)
            {
                string Imgpath = row.ImgPath.ToString();
                if (System.IO.File.Exists(Imgpath))
                {
                    System.IO.File.Delete(Imgpath);
                }
                return RedirectToAction("Index", "Product");

            }
            return RedirectToAction("Index", "Product");
        }

    }
}