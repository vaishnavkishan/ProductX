using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class ComparisionDetails
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Comparision))]
        public int ComparisionId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public bool PreferredProduct { get; set; }
        public bool Deleted { get; set; }

        public virtual Comparision Comparision { get; set; }
        public virtual Product Product { get; set; }
    }
}
