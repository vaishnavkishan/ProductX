using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(ParentCategory))]
        public int ParentCategoryId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}
