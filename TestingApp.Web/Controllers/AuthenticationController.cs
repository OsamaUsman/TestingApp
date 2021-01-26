using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestingApp.Model;
using TestingApp.Repo1;

namespace TestingApp.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserRepository repo;
        public AuthenticationController()
        {
            repo = new UserRepository();
        }
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Members mem)
        {
            bool isvalid  = repo.IsExist(mem.Name,mem.Password);
            if (isvalid == true)
            {
                FormsAuthentication.SetAuthCookie(mem.Name ,false); 
                return RedirectToAction("Index" ,"Product") ;
            } 
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User user)
        {
            if (ModelState.IsValid ==  true)
            {
                repo.Post(user);
                int my = repo.Save();
                if (my > 0)
                {
                    ViewBag.Success = "Your Record Has Been Submitted";
                }
                else
                {
                    ViewBag.Err = " Error!! Something Went Wrong!! ";
                }
            }
            return RedirectToAction("Login", "Authentication");

        }
    }
}