using ProductAPI.Models;
using ProductAPI.Models.BLModels;
using ProductAPI.Services.DBServices;
using ProductAPI.Services.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.BLServices
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        private IRatingSuggestionService _ratingService;

        private IRatingSuggestionService RatingSuggestionService
        {
            get
            {
                //Some mechanism to determine whether the current user is a Premium user or Standard.
                bool isPremium = true;

                if (_ratingService == null)
                    _ratingService = new RatingSuggestionFactory().GetRatingService(isPremium);

                return _ratingService;
            }
        }

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductDetails Get(int productId)
        {
            ProductDetails productDetails = new ProductDetails();

            Product product = _productRepository.Get(productId);

            productDetails.Rating = _ratingService.Calculate(product);
            productDetails.Suggestion = _ratingService.GetSuggestion(product);

            return productDetails;
        }
    }
}
