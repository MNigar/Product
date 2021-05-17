using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Views()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            IEnumerable<Category> category = _context.Categories.ToList();
            ViewBag.CategoryId = new SelectList(_context.Categories.ToList(), "Id", "Name"); 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product model,IFormFile image)
        {

            model.Id = Guid.NewGuid();
            
            
            if (ModelState.IsValid)
            {
                if (Utils.Check.CheckFormat(image.ContentType))
                {
                    string fileName = $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";

                    string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                    FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                    await image.CopyToAsync(fileStream);
                    model.Image = fileName;
                    await _context.Products.AddAsync(model);
                    await _context.SaveChangesAsync();

                }
                    return RedirectToAction("Index");
                
            }
            else
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
            var model = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.image = model.Image;
            ViewBag.CategoryId = new SelectList(_context.Categories.ToList(), "Id", "Name");

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id,Product model, IFormFile image)
        {
            Product currentProduct = _context.Products.AsNoTracking().FirstOrDefault(x=>x.Id==model.Id);

            if (image != null)
            {
                string fileName = $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
                string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
                FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                await image.CopyToAsync(fileStream);
                model.Image = fileName;
                //var currentPhotoPath= Path.Combine(_environment.WebRootPath, "Image", currentProduct.Image);
                //System.IO.File.Delete(currentPhotoPath);
                _context.Entry(currentProduct).State = EntityState.Detached;
            }

            if (image == null)
            {
               
                //_context.Entry(contextModel).Property(p => p.Photo).IsModified = false;
                model.Image = currentProduct.Image;
            }
            model.Status = (int)Utils.Enums.Status.Active;


            var entity = _context.Entry(model);
            _context.Entry(model).State = EntityState.Modified;


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
