using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabats.DataLayer.Entities;
using Talabats.DataLayer.Repositories;
using Talabats.RepositoryLayer.Implimentions;

namespace Talabats.PresentaionLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenaricrepository<Product> _genericRepository;

        public ProductController(IGenaricrepository<Product> genaricrepository)
        {
            _genericRepository = genaricrepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await _genericRepository.Get(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _genericRepository.GetAll();
            return Ok(products);
        }

    }

}
