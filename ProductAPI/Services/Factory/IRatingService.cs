using ProductAPI.Models;

namespace ProductAPI.Services.Factory
{
    public interface IRatingService
    {
        double Calculate(Product product);
    }
}