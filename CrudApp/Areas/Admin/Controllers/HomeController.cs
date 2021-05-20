using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace CrudApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        const string SessionName = "Name";
        const string SessionEmail = "Email";
        const string SessionId = "Id";
        const string LoginError = "LoginError";

        private readonly ProductContext _context;
        public HomeController(ProductContext context)
        {
            _context = context;
           
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Top()
        {
          var users=  _context.Users.Include("Products").Where(x => x.Products.Count > 3);

            return View(users);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {

            var check = _context.Users.Where(u => u.Email == user.Email).FirstOrDefault();
            if (check != null)
            {
                HttpContext.Session.SetString(SessionEmail, check.Email);
                HttpContext.Session.SetString(SessionId, check.Id.ToString());
                HttpContext.Session.SetString(SessionName, check.Name.ToString());

                if (Crypto.VerifyHashedPassword(check.Password, user.Password))
                {

                    if (HttpContext.Session.GetString(SessionName) == "admin")
                    {
                        HttpContext.Session.SetString(LoginError, true.ToString());

                        TempData["LoginError"] = HttpContext.Session.GetString(LoginError);
                        //return View("~/Areas/Manage/Views/Home/Index.cshtml");
                        return RedirectToAction("Index", "Product");
                    }
                    else
                    {
                        return RedirectToAction("Login", "Home");
                    }

                }


            }
            return View();
        }
    }
}
