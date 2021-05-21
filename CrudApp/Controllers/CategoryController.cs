using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProductContext _context;
        public CategoryController(ProductContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category model)
        {
            model.Id = Guid.NewGuid();
            model.Status =(int) Utils.Enums.Status.Active;
            await  _context.Categories.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult CategoryGrid()
        {
            
            IEnumerable<Category> categories = _context.Categories.ToList().Where(x=>x.Status==(int)Utils.Enums.Status.Active);
            ViewData["image"] = _context.SubHeaders.LastOrDefault().Image;

            return View(categories);
        }
        public  IActionResult CategoryList()
        {
            IEnumerable<Category> category =  _context.Categories.ToList();
            
            return PartialView(category);
        }
    }
}
