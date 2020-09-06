using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public class ThirdPartyExpertSuggestionService : IThirdPartyExpertSuggestionService
    {
        public double GetRating(int productId)
        {
            return new Random().Next(10);
        }

        public string GetSuggestion(int productId)
        {
            //Call third party APIs to get suggestions.
            return "This is an expert suggestion";
        }
    }
}
