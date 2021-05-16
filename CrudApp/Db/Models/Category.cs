
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Db.Models
{
    public class Category
    {  
        public Category()
        {
            Products = new List<Product>();
        }
        
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
