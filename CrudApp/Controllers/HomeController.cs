using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace CrudApp.Controllers
{
    public class HomeController : Controller
    {
        const string RegistrationError = "RegistrationError";

         string SessionName = "Name";
         string SessionEmail = "Email";
         string SessionId = "Id";
        private readonly ProductContext _context;
        public HomeController(ProductContext context)
        {
            _context = context;

        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Profiles()
        {
            if (HttpContext.Session.GetString("Id") == null || HttpContext.Session.GetString("Id") == "")
            {
                TempData["Message"] = "Please login ";
                return RedirectToAction("Login", "Home");
            }
           
            return RedirectToAction("Index", "Product");

        }
        public IActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User user)
        {

            if (ModelState.IsValid)
            {
                user.Password = Crypto.HashPassword(user.Password);
               
                var check = _context.Users.Where(u => u.Email == user.Email).FirstOrDefault();

                if (check == null)
                {

                    _context.Add(user);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Login));
                }

                else
                {
                    HttpContext.Session.SetString(RegistrationError, true.ToString());

                    TempData["Error"]=HttpContext.Session.GetString(RegistrationError);
                    return View();

                }
            }

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {

            var check = _context.Users.Where(u => u.Email == user.Email).FirstOrDefault();
            if (check != null)
            {              

                if (Crypto.VerifyHashedPassword(check.Password, user.Password))
                {
                    HttpContext.Session.SetString(SessionEmail, check.Email);
                    HttpContext.Session.SetString(SessionId, check.Id.ToString());
                    HttpContext.Session.SetString(SessionName, check.Name.ToString());
                   
                    return RedirectToAction("HomePage","Product");
                    //}

                }
                else
                {
                    TempData["PasswordError"] = "Invalid password";
                }




            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
           

            HttpContext.Session.SetString("Email","");
            HttpContext.Session.SetString(SessionId, "");
            HttpContext.Session.SetString(SessionName, "");

            return RedirectToAction("Login");
        }
        
    }
}
