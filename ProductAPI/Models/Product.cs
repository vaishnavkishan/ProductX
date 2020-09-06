using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Site))]
        public int SiteId { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        public bool Deleted { get; set; }

        public virtual Site Site { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<AttributeValue> AttributeValue { get; set; }
        public virtual ICollection<Comparision> Comparisions { get; set; }
    }
}
