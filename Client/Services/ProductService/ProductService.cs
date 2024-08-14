//using BlazorAppEcommerce.Server.Data;
using BlazorAppEcommerce.Shared;
using System.Net.Http.Json;
using UNet7BlazorAppEcomm.Shared;

namespace BlazorAppEcommerce.Client.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }
        public List<Product> Products {get; set; } = new List<Product>();


        public async Task GetProducts()
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null)
            {
                Products = result.Data;
            }

        }
    }
}
