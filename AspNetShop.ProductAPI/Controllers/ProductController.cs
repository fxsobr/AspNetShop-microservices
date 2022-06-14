using AspNetShop.ProductAPI.Data.ValueObjects;
using AspNetShop.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetShop.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindByAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }
        
        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }


    }
}
