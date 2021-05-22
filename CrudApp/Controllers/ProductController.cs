using CrudApp.Db;
using CrudApp.Db.Models;
using CrudApp.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly IHostingEnvironment _environment;
        private readonly ProductContext _context;
        public ProductController(IHostingEnvironment environment, ProductContext context)
        {
            _environment = environment;
            _context = context;
        }
        BookDataController method = new BookDataController();
        public IActionResult Index()
        {

            IEnumerable<Product> products = _context.Products.Include("User").Where(x => x.UserId.ToString() == HttpContext.Session.GetString("Id")).ToList();
            return View(products);
        }
        public IActionResult CultureManagemenet(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });

            return LocalRedirect(returnUrl);
        }
        [HttpGet]
        public IActionResult Views()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Id") == null || HttpContext.Session.GetString("Id") == "")
            {
                TempData["Message"] = "Please login for adding book";
                return RedirectToAction("Login", "Home");
            }
            IEnumerable<Category> category = _context.Categories.ToList();
            ViewBag.CategoryId = new SelectList(_context.Categories.ToList().Where(x => x.Status == (int)Utils.Enums.Status.Active), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product model, IFormFile image)
        {
            var transaction = _context.Database.BeginTransaction();
            try
            {
                model.Id = Guid.NewGuid();

                if (Utils.Check.CheckFormat(image.ContentType))
                {
                    string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";

                    string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                    FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                    await image.CopyToAsync(fileStream);
                    var newModel = method.Create(model, new Guid(HttpContext.Session.GetString("Id")), fileName);
                    await _context.Products.AddAsync(newModel);
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                    Utils.Email.SendEmail(HttpContext.Session.GetString("Email"), HttpContext.Session.GetString("Name"), "Kitab admin terefinden qiymetlendirirlecek", model.Name);
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var request = HttpContext.Request;
            var model = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.CategoryId = new SelectList(_context.Categories.ToList().Where(x => x.Status == (int)Utils.Enums.Status.Active), "Id", "Name");

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Product model, IFormFile image)
        {
            Product currentProduct = _context.Products.AsNoTracking().FirstOrDefault(x => x.Id == model.Id);

            var transaction = _context.Database.BeginTransaction();
            try
            {
                if (image != null)
                {
                    string fileName = $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
                    string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                    FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                    await image.CopyToAsync(fileStream);
                    model.Image = fileName;

                    Utils.Email.SendEmail(HttpContext.Session.GetString("Email"), HttpContext.Session.GetString("Name"), "Kitab admin terefinden qiymetlendirirlecek", model.Name);
                    _context.Entry(currentProduct).State = EntityState.Detached;
                }

                if (image == null)
                {
                    model.Image = currentProduct.Image;
                }
                var newModel = method.Edit(model, currentProduct, new Guid(HttpContext.Session.GetString("Id")), model.Image);

                var entity = _context.Entry(newModel);

                _context.Entry(newModel).State = EntityState.Modified;

                await _context.SaveChangesAsync();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            return RedirectToAction("Index");
        }



        public IActionResult BookGrid(Guid? id)
        {
            IEnumerable<Product> book = _context.Products.Include("Category").ToList().Where(x => x.Status == (int)Utils.Enums.Status.Active);
            ViewBag.Category = _context.Categories.Where(x => x.Status == (int)Enums.Status.Active).ToList().Distinct();

            if (id != null)
            {
                IEnumerable<Product> bookList = _context.Products.Include("Category").ToList().Where(x => x.Status == (int)Utils.Enums.Status.Active && x.CategoryId == id);

                return View(bookList);
            }
            ViewData["image"] = _context.SubHeaders.LastOrDefault().Image;
            return View(book);
        }

        public IActionResult BookDetails(Guid id)
        {
            var model = _context.Products.Include("Category").Include("User").FirstOrDefault(x => x.Id == id);
            ViewBag.day = model.CreatedDate.Day;
            ViewBag.Month = model.CreatedDate.ToString("MMMM");
            ViewBag.Date = method.RecipeDate(DateTime.Now, model.CreatedDate);
            ViewData["image"] = _context.SubHeaders.LastOrDefault().Image;

            return View(model);
        }

        public IActionResult HomePage()
        {
            IEnumerable<Category> categories = _context.Categories.Where(x => x.Status == (int)Enums.Status.Active).ToList();
            ViewBag.Book = _context.Products.Include("User").Include("Category").Where(x => x.Status == (int)Enums.Status.Active);
            ViewData["image"] = _context.SubHeaders.LastOrDefault().Image;

            return View(categories);
        }
        [HttpGet]
        public ActionResult Search(string Name, string categoryId, string Author)
        {
            IEnumerable<Product> result = _context.Products.Include("Category").Include("User").ToList().Where(x => x.Status == (int)Utils.Enums.Status.Active);

            if (!String.IsNullOrEmpty(Name))
            {
                result = result.Where(x => x.Name.ToLower().Contains(Name.ToLower()));
            }

            if (!String.IsNullOrEmpty(Author))
            {
                result = result.Where(x => x.Author.ToLower().Contains(Author.ToLower()));
            }
            if (!String.IsNullOrEmpty(categoryId))
            {
                result = result.Where(x => x.CategoryId.ToString() == categoryId);
            }

            ViewBag.Category = _context.Categories.Where(x => x.Status == (int)Enums.Status.Active).ToList().Distinct();
            ViewData["image"] = _context.SubHeaders.LastOrDefault().Image;

            return View(result);

        }
    }
}
