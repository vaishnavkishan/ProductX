using ProductAPI.Models;

namespace ProductAPI.Services.Factory
{
    public interface IRatingSuggestionService : IRatingService
    {
        string GetSuggestion(Product product);
    }
}