using CrudApp.Db.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Utils
{
    public class BookDataController : Controller
    {
     
        public string RecipeDate(DateTime date1, DateTime date2)
        {
            var date = date1 - date2;
            if (date.TotalMinutes < 60 && date.TotalHours < 1 && date.TotalDays < 1)
            {
                var minutes = string.Format("{0:0}", date.TotalMinutes);
                ViewData["Date"] = minutes + "minutes";
            }
            if (date.TotalMinutes > 60 && date.TotalHours > 0 && date.TotalDays < 1)
            {
                var hours= string.Format("{0:0}", date.TotalHours);
                ViewData["Date"] = hours + "hours";
            }
            if (date.TotalDays > 1)
            {
                ViewData["Date"] = date.TotalDays.ToString().Split('.')[0] + "days";
            }
            return ViewBag.Date;
        }
        public  Product Edit(Product model, Product current, Guid UpdatedUserId,string filename)
        {
            Product newProduct = new Product();
            newProduct.Status = (int)Utils.Enums.Status.Waiting;
            
            newProduct.Name = model.Name;
            newProduct.Author = model.Author;
            newProduct.CategoryId = model.CategoryId;
            newProduct.UpdatedDate = DateTime.Now;
            newProduct.UserId = current.UserId;
            newProduct.ModifyUserId = UpdatedUserId;
            newProduct.Image = filename;
            newProduct.PageCount = model.PageCount;
            newProduct.PublishingHouse = model.PublishingHouse;
            newProduct.Description = model.Description;
            newProduct.CreatedDate = current.CreatedDate;
            newProduct.Id = current.Id;
            return newProduct;

        }
        public Product Create(Product model, Guid createdUserId, string filename)
        {
            Product newProduct = new Product();
            newProduct.Status = (int)Utils.Enums.Status.NewCreated;

            newProduct.Name = model.Name;
            newProduct.Author = model.Author;
            newProduct.CategoryId = model.CategoryId;
            newProduct.UpdatedDate = null;
            newProduct.UserId = createdUserId;
            newProduct.ModifyUserId = null;
            newProduct.Image = filename;
            newProduct.PageCount = model.PageCount;
            newProduct.PublishingHouse = model.PublishingHouse;
            newProduct.Description = model.Description;
            newProduct.CreatedDate = DateTime.Now;
            return newProduct;

        }


       
        public Tuple<string,FileStream> Image(IFormFile image, IHostingEnvironment _environment)
        {
            string fileName = $"_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{image.FileName}";
            string path = Path.Combine(_environment.WebRootPath, "Image", fileName);
            FileStream fileStream = new FileStream(path, FileMode.CreateNew);
            return Tuple.Create(fileName,fileStream);

        }
    }
}
