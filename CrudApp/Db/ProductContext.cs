using CrudApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Db
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> context) : base(context) { }
        public DbSet<Product> Products { get; set; }
    }
}
