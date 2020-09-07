namespace ProductAPI.Services.Factory
{
    public interface IRatingSuggestionFactory
    {
        IRatingSuggestionService GetRatingService(bool isPremiumUser);
    }
}