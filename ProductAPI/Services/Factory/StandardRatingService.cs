using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public class StandardRatingService : IRatingSuggestionService
    {
        public StandardRatingService()
        {

        }

        public double Calculate(Product product)
        {
            return new Random().Next(10);
        }

        public string GetSuggestion(Product product)
        {
            //Return standard suggestion.
            return "This is a test suggestion";
        }
    }
}
