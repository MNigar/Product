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

namespace CrudApp.Areas.Admin.Controllers
{   
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment _environment;
        public CategoryController(ProductContext context,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult CultureManagemenet(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });

            return LocalRedirect(returnUrl);
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories.ToList().Where(x=>x.Status== (int)Utils.Enums.Status.Active);
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category model,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (Utils.Check.CheckFormat(image.ContentType))
                {
                    string fileName = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
                    string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                    FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                    await image.CopyToAsync(fileStream);
                    model.Image = fileName;
                    model.Id = Guid.NewGuid();
                    model.Status = (int)Utils.Enums.Status.Active;
                    await _context.Categories.AddAsync(model);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var model = _context.Categories.Where(x => x.Id == id).FirstOrDefault();
           

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit( Category model, IFormFile image)
        {       
            Category currentCategory = _context.Categories.AsNoTracking().FirstOrDefault(x => x.Id == model.Id);

            if (image != null)
            {
                string fileName = $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
                string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                await image.CopyToAsync(fileStream);
                model.Image = fileName;
                _context.Entry(currentCategory).State = EntityState.Detached;
            }

            if (image == null)
            {

                model.Image = currentCategory.Image;
            }

            model.Status = (int)Utils.Enums.Status.Active;
            var entity = _context.Entry(model);
            _context.Entry(model).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
      
        public async Task<IActionResult> Delete(Guid id)
        {
            Category currentCategory = _context.Categories.AsNoTracking().FirstOrDefault(x => x.Id == id);

            currentCategory.Status = (int)Utils.Enums.Status.Deactive;
            var entity = _context.Entry(currentCategory);
            _context.Entry(currentCategory).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id)
        {
            Category currentCategory = _context.Categories.AsNoTracking().FirstOrDefault(x => x.Id == id);
            


            return View(currentCategory);
        }
    }
}
