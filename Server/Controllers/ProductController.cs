using BlazorAppEcommerce.Server.Controllers;
using BlazorAppEcommerce.Server.Data;
using BlazorAppEcommerce.Server.Products.Services;
using BlazorAppEcommerce.Shared;
using Microsoft.AspNetCore.Mvc;
using UNet7BlazorAppEcomm.Shared;

namespace UNet7BlazorAppEcomm.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {


        private static List<Product> Products = new List<Product>();
        private readonly IProductService _productService;
        private readonly ILogger<WeatherForecastController> _logger;

       
        public ProductController(IProductService productService, ILogger<WeatherForecastController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var products = await _productService.GetProductsAsync();
            
            return Ok(products);
        }
    }
}
