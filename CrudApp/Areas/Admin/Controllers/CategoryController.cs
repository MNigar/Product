using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Areas.Admin.Controllers
{   
    [Area("Admin")]
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
    }
}
