using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models.BLModels
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Link { get; set; }
        public bool Deleted { get; set; }

        public double Rating { get; set; }
        public string Suggestion { get; set; }
    }
}
