using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Db.Models
{
    public class User
    {
        public User()
        {
            Products = new List<Product>();
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public int Status { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}
