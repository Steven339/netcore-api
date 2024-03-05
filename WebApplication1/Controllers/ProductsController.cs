using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public dynamic getProducts()
        {
            return _productsRepository.GetProducts();
        }

        [HttpPost]
        public void addProduct([FromBody] Products product) { _productsRepository.AddProduct(product); }
    }
}
