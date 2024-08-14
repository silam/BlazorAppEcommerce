using BlazorAppEcommerce.Server.Data;
using BlazorAppEcommerce.Shared;
using UNet7BlazorAppEcomm.Shared;

namespace BlazorAppEcommerce.Server.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync<Product>()
            };

            return response;
        }
    }
}
