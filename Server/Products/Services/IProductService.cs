using BlazorAppEcommerce.Shared;
using UNet7BlazorAppEcomm.Shared;

namespace BlazorAppEcommerce.Server.Products.Services
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
