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
        
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create(ProductVO valueObject)
        {
            if (valueObject == null) return BadRequest();
            var product = await _repository.Create(valueObject);
            return Ok(product);
        }
        
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO valueObject)
        {
            if (valueObject == null) return BadRequest();
            var product = await _repository.Update(valueObject);
            return Ok(product);
        }
        
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }


    }
}
