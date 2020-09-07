using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public class ExpertRatingService : IRatingSuggestionService
    {
        private readonly IThirdPartyExpertSuggestionService _thirdPartyExpertSuggestionService;

        public ExpertRatingService(IThirdPartyExpertSuggestionService thirdPartyExpertSuggestionService)
        {
            _thirdPartyExpertSuggestionService = thirdPartyExpertSuggestionService;
        }

        public double Calculate(Product product)
        {
            if (product is null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            //Some rating calculations based on specifications.
            return _thirdPartyExpertSuggestionService.GetRating(product.Name, 12);
        }

        public string GetSuggestion(Product product)
        {
            return _thirdPartyExpertSuggestionService.GetSuggestion(product.Name, 12);
        }
    }
}
