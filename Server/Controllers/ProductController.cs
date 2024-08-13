using BlazorAppEcommerce.Server.Controllers;
using BlazorAppEcommerce.Server.Data;
using Microsoft.AspNetCore.Mvc;
using UNet7BlazorAppEcomm.Shared;

namespace UNet7BlazorAppEcomm.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {


        private static List<Product> Products = new List<Product>();
        private readonly DataContext _context;
        private readonly ILogger<WeatherForecastController> _logger;

       
        public ProductController(DataContext context, ILogger<WeatherForecastController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
