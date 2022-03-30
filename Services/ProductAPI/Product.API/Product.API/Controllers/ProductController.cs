using Microsoft.AspNetCore.Mvc;
using Product.API.Infrastructure;
using Product.API.Models;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet("{Id}")]
        public ProductDTO GetProductById(int Id)
        {
            return _productService.GetProductById(Id);
        }
    }
}
