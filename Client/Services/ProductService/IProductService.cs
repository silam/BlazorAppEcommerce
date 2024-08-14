using BlazorAppEcommerce.Shared;
using UNet7BlazorAppEcomm.Shared;

namespace BlazorAppEcommerce.Client.Products.Services
{
    public interface IProductService
    {
        List<Product> Products { get; }
        Task GetProducts();
    }
}
