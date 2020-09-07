using ProductAPI.Services.BLServices;
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
        private readonly ILengthConverterService _lengthConverterService;

        public ThirdPartyExpertSuggestionServiceAdapter(IThirdPartyExpertSuggestionService thirdPartyExpertSuggestionService,
            ILengthConverterService lengthConverterService)
        {
            _thirdPartyExpertSuggestionService = thirdPartyExpertSuggestionService;
            this._lengthConverterService = lengthConverterService;
        }
        public double GetRating(string productName, double screenSize)
        {
            double screenSizeInch = _lengthConverterService.ConvertCmToInch(screenSize);
            return _thirdPartyExpertSuggestionService.GetRating(productName, screenSizeInch);
        }

        public string GetSuggestion(string productName, double screenSize)
        {
            double screenSizeInch = +_lengthConverterService.ConvertCmToInch(screenSize);

            //Call third party APIs to get suggestions.
            return _thirdPartyExpertSuggestionService.GetSuggestion(productName, screenSizeInch);
        }
    }
}
