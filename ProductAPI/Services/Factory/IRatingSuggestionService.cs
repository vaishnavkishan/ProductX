namespace ProductAPI.Services.Factory
{
    public interface IRatingSuggestionService : IRatingService
    {
        string GetSuggestion(int productId);
    }
}