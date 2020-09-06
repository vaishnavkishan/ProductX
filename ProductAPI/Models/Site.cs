using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Site
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<Product> Products{ get; set; }
    }
}
