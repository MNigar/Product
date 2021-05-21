using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly IHostingEnvironment _environment;

        public HomeController(ProductContext context,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
   
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Top()
        {
          var users=  _context.Users.Include("Products").Where(x => x.Products.Count>1);

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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubHeader model, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (Utils.Check.CheckFormat(image.ContentType))
                {
                    string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
                    string path = Path.Combine(_environment.WebRootPath, "Public/metropolitanhost.com/themes/themeforest/html/trickly/assets/img", fileName);
                    FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                    await image.CopyToAsync(fileStream);
                    model.Image = fileName;
                    
                    await _context.SubHeaders.AddAsync(model);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");

        }
    }
}
