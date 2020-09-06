using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.DBServices
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {

        }

        public Product Get(int productId)
        {
            return new Product
            {
                Id = productId,
                Name = "Samsung Galaxy Note 9"
            };
        }
    }
}
