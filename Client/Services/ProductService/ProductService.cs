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

        public Product Product;

        //public async Task GetProduct(int productId)
        //{
        //    var result = await _client.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
        //    if (result != null)
        //    {
        //        Product = result?.Data;
        //    }
        //}

        public async Task GetProducts()
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            if (result != null)
            {
                Products = result.Data;
            }

        }

        public async Task<Product> GetProduct(int productId)
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            if (result != null)
            {
                Product = result?.Data;
            }
            return Product;
        }
    }
}
