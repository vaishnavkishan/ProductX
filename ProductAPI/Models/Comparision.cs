using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Comparision
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(FirstProduct))]
        public int FirstProductId { get; set; }
        [ForeignKey(nameof(SecondProduct))]
        public int SecondProductId { get; set; }

        public int PreferredProduct { get; set; }
        public bool Deleted { get; set; }

        public virtual Product FirstProduct { get; set; }
        public virtual Product SecondProduct { get; set; }
    }
}
