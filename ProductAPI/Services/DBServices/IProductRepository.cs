using ProductAPI.Models;

namespace ProductAPI.Services.DBServices
{
    public interface IProductRepository
    {
        Product Get(int productId);
    }
}