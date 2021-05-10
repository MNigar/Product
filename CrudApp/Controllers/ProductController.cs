using CrudApp.Db;
using CrudApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product model,IFormFile image)
        {
            model.Id = Guid.NewGuid();
            model.Image = image.FileName;
            if (ModelState.IsValid)
            {
                string path = Path.Combine(_environment.WebRootPath, "Image", image.FileName);
                FileStream fileStream = new FileStream(path, FileMode.CreateNew);
                await image.CopyToAsync(fileStream);
                await _context.Products.AddAsync(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("Index");
        }
    }
}
