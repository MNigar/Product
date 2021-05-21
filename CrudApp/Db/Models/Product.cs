using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Db.Models
{
    public class Product
    {
        
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Author { get; set; }
        [Required]

        public Guid CategoryId { get; set; }
        [Required]

        public virtual Category Category { get; set; }
        [Required]

        public string PageCount { get; set; }
        [Required]

        public string Image { get; set; }
        

        public int Status { get; set; }
        [Required]

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? ModifyUserId { get; set; }
        [Required]

        public string Description { get; set; }
      

        public string PublishingHouse { get; set; }
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
