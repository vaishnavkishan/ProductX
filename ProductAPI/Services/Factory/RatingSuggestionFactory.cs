using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services.Factory
{
    public class RatingSuggestionFactory
    {
        private IRatingSuggestionService _standardService;
        private IRatingSuggestionService _expertService;

        private IRatingSuggestionService StandardService
        {
            get
            {
                if (_standardService == null)
                    _standardService = new StandardRatingService();
                return _standardService;
            }
        }

        private IRatingSuggestionService ExpertService
        {
            get
            {
                if (_expertService == null)
                    _expertService = new ExpertRatingService(new ThirdPartyExpertSuggestionService());
                return _expertService;
            }
        }


        public RatingSuggestionFactory()
        {
        }

        public IRatingSuggestionService GetRatingService(bool isPremiumUser)
        {
            if (isPremiumUser)
                return ExpertService;
            else
                return StandardService;
        }
    }
}
