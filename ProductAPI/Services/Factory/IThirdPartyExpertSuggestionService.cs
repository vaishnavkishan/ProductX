using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public interface IThirdPartyExpertSuggestionService
    {
        double GetRating(int productId);
        string GetSuggestion(int productId);

    }
}
