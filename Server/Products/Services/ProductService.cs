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

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products.FindAsync(productId);
            if ( product == null)
            {
                response.Success = false;
                response.Message = "Product not existed";

            }
            else
            {
                response.Data = product;
            }
            return response;
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
