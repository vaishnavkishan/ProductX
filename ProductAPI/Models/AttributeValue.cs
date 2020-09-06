using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class AttributeValue
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Attribute))]
        public int AttributeId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public EAttributeType Type { get; set; }
        public string Value { get; set; }
        [StringLength(255)]
        public bool Deleted { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
