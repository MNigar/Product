using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Db.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string PageCount { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? ModifyUserId { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
