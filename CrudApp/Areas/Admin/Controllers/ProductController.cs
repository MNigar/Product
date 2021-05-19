using CrudApp.Db;
using CrudApp.Db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context )
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Index()
        
        {

            IEnumerable<Product> model = _context.Products.Include("Category").ToList();
            return View(model);
        }
        public async Task<IActionResult> Confirm(Guid id)
        {
            var  model = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            model.Status = (int)Utils.Enums.Status.Active;
            var entity = _context.Entry(model);
            _context.Entry(model).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return View(model);
        }
        public async Task<IActionResult> Cancel(Guid id)
        {
            var model = _context.Products.Where(x => x.Id == id).FirstOrDefault();
            model.Status = (int)Utils.Enums.Status.Deactive;
            var entity = _context.Entry(model);
            _context.Entry(model).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return View(model);
        }
        public IActionResult Details(Guid id)
        {
            var model = _context.Products.Where(x => x.Id == id).Include("Category").FirstOrDefault();
           
            return View(model);
        }

    }
}
