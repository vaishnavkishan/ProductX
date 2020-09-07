using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    /// <summary>
    /// The third party service needs all the screen sizes in inches. 
    /// But our API works in the cm. 
    /// So, created adapter to convert to the third party supported format.
    /// </summary>
    public class ThirdPartyExpertSuggestionServiceAdapter : IThirdPartyExpertSuggestionService
    {
        private readonly IThirdPartyExpertSuggestionService _thirdPartyExpertSuggestionService;

        public ThirdPartyExpertSuggestionServiceAdapter(IThirdPartyExpertSuggestionService thirdPartyExpertSuggestionService)
        {
            _thirdPartyExpertSuggestionService = thirdPartyExpertSuggestionService;
        }
        public double GetRating(string productName, double screenSize)
        {
            double screenSizeInch = ConvertCmToInch(screenSize);
            return _thirdPartyExpertSuggestionService.GetRating(productName, screenSizeInch);
        }

        public string GetSuggestion(string productName, double screenSize)
        {
            double screenSizeInch = ConvertCmToInch(screenSize);

            //Call third party APIs to get suggestions.
            return _thirdPartyExpertSuggestionService.GetSuggestion(productName, screenSizeInch);
        }
    }
}
