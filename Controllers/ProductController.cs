using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _service;

        public ProductsController(ProductService service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet]
        public ActionResult<List<Product>> GetAll() => _service.GetAll();

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _service.Get(id);

            return product is null ? NotFound() : product;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _service.Add(product);

            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var existing = _service.Get(id);

            if (existing is null) return NotFound();
            _service.Remove(id);
            return NotFound();
        }
    }
}
