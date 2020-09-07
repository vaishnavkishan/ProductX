using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public interface IThirdPartyExpertSuggestionService
    {
        double GetRating(string productName, double screenSize);
        string GetSuggestion(string productName, double screenSize);

    }
}
