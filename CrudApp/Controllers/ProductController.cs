﻿using CrudApp.Db;
using CrudApp.Db.Models;
using CrudApp.Utils;
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
        BookDataController method = new BookDataController();
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
                    model.CreatedDate = DateTime.Now;
                    model.Status = (int) Utils.Enums.Status.Waiting;
                    await _context.Products.AddAsync(model);
                    await _context.SaveChangesAsync();
                    Utils.Email.SendEmail("nigarmammadova4t@gmail.com", "Nigar", "Kitab admin terefinden qiymetlendirirlecek", model.Name);
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
            var request = HttpContext.Request;
            var model = _context.Products.Where(x => x.Id == id).FirstOrDefault();
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
                model.UpdatedDate = DateTime.Now;
                model.CreatedDate = currentProduct.CreatedDate;
                Utils.Email.SendEmail("nigarmammadova4t@gmail.com", "Nigar", "Kitab admin terefinden qiymetlendirirlecek", model.Name);
                //var currentPhotoPath= Path.Combine(_environment.WebRootPath, "Image", currentProduct.Image);
                //System.IO.File.Delete(currentPhotoPath);
                _context.Entry(currentProduct).State = EntityState.Detached;
            }

            if (image == null)
            {
               
                //_context.Entry(contextModel).Property(p => p.Photo).IsModified = false;
                model.Image = currentProduct.Image;
            }

            model.Status = (int)Utils.Enums.Status.Waiting;              
            var entity = _context.Entry(model);
            _context.Entry(model).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

       

        public IActionResult BookGrid()
        {
            IEnumerable<Product> book = _context.Products.ToList();
            return View(book);
        }
        public IActionResult BookDetails(Guid id)
        {
            var model = _context.Products.FirstOrDefault(x => x.Id == id);
            ViewBag.day = model.CreatedDate.Day;
            ViewBag.Month = model.CreatedDate.ToString("MMMM");
            ViewBag.Date = method.RecipeDate(DateTime.Now, model.CreatedDate);
            return View(model);
        }

    }
}
