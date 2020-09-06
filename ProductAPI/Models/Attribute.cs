using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Attribute
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public int Name { get; set; }
        public EAttributeType Type { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
}
